using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using MundialApiPet.Modelo;
using MundialApiPet.Modelo.Inventario;
using MundialApiPet.Modelo.Inventario.ModelosRespuesta;
using MundialApiPet.Modelo.Ventas;
using MundialApiPet.Modelo.Ventas.ModelosRespuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundialApiPet.Service
{
    public class RepositorioVentas
    {
        private readonly Context _context;

        public RepositorioVentas(Context context)
        {
            _context = context;
        }

        public List<SelectListItem> ConsultarListaPurina()
        {
            try
            {
                List<SelectListItem> lista = new List<SelectListItem>();

                int idPurina = _context.TiposArticulosInventarios.Where(modeloMarca => modeloMarca.Codigo == "COD_PURINA_03").Select(modeloselec => modeloselec.IdTipoArticulo).FirstOrDefault();

                lista = (from tipoPurina in _context.ArticulosInventarios
                         join tipoMarca in _context.TiposMarcasInventarios on tipoPurina.IdTipoMarca equals tipoMarca.IdTipoMarca
                         where tipoPurina.EstadoActivo
                             && tipoPurina.IdTipoArticulo == idPurina
                         select new SelectListItem
                         {
                             Text = tipoMarca.Nombre,
                             Value = tipoPurina.IdArticulo.ToString()
                         }).ToList();



                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }


        public List<SelectListItem> ConsultarListaAccesoriosMedicamentos()
        {
            try
            {
                List<SelectListItem> lista = new List<SelectListItem>();

                int idPurina = _context.TiposArticulosInventarios.Where(modeloMarca => modeloMarca.Codigo == "COD_MEDICAMENTO_01").Select(modeloselec => modeloselec.IdTipoArticulo).FirstOrDefault();
                int idMedicamento = _context.TiposArticulosInventarios.Where(modeloMarca => modeloMarca.Codigo == "COD_ACCESORIO_02").Select(modeloselec => modeloselec.IdTipoArticulo).FirstOrDefault();

                lista = (from tipoPurina in _context.ArticulosInventarios
                         join tipoMarca in _context.TiposMarcasInventarios on tipoPurina.IdTipoMarca equals tipoMarca.IdTipoMarca
                         where tipoPurina.EstadoActivo
                             && ( tipoPurina.IdTipoArticulo == idPurina
                             || tipoPurina.IdTipoArticulo == idMedicamento)
                         select new SelectListItem
                         {
                             Text = tipoMarca.Nombre,
                             Value = tipoPurina.IdArticulo.ToString()
                         }).ToList();



                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }

       

        public List<SelectListItem> ConsultarListaTipoBaño()
        {
            try
            {
                List<SelectListItem> lista = new List<SelectListItem>();


                lista = (from tipoBaño in _context.TiposBanosInventarios
                         where tipoBaño.EstadoActivo
                         select new SelectListItem
                         {
                             Text = tipoBaño.Nombre,
                             Value = tipoBaño.IdTipoBanoInventario.ToString()
                         }).ToList();



                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }

        public List<SelectListItem> ConsultarListaAnimales()
        {
            try
            {
                List<SelectListItem> lista = new List<SelectListItem>();


                lista = (from animal in _context.AnimalesInventarios
                         where animal.EstadoActivo
                         select new SelectListItem
                         {
                             Text = animal.Nombre,
                             Value = animal.IdAnimalInventario.ToString()
                         }).ToList();



                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }


        public bool RegistrarVenta(List<RVentaIngresar> ventasRegistradas)
        {
            try
            {
                ArticuloInventario modeloArticulo = new ArticuloInventario();
                IngresaVentaTH modeloIngresaVentaTH = new IngresaVentaTH();
                LogArticuloInventario modelologArticulo = new LogArticuloInventario();
                LogArticuloInventario modelologArticuloAccesorio = new LogArticuloInventario();
                BanosInventario modeloBaño = new BanosInventario();

                foreach (RVentaIngresar itemventasRegistradas in ventasRegistradas)
                {

                    if (itemventasRegistradas.code == "PURINA")
                    {
                        modeloArticulo = _context.ArticulosInventarios.Where(modelConsulta => modelConsulta.IdArticulo == int.Parse(itemventasRegistradas.tipoPurina))
                                                                      .FirstOrDefault();

                        int precioGramo = (int)modeloArticulo.Precio / 1000;

                        //int cantidadVendidaGramos = (int)itemventasRegistradas.precio / precioGramo;
                        int cantidadVendidaGramos = (int)(int.Parse(itemventasRegistradas.precio) / precioGramo);


                        modeloArticulo.CantidadDisponible = modeloArticulo.CantidadDisponible - cantidadVendidaGramos;
                        modeloArticulo.FechaActualizacion = DateTime.Now;

                        _context.Entry(modeloArticulo).State = EntityState.Modified;
                        _context.SaveChanges();

                        int countArticulo = _context.LogsArticulosInventarios.Count();

                        modelologArticulo.Codigo = "CODE_" + countArticulo;
                        modelologArticulo.EstadoActivo = true;
                        modelologArticulo.Precio = modeloArticulo.Precio;
                        modelologArticulo.CantidadDisponible = modeloArticulo.CantidadDisponible;
                        modelologArticulo.CantidadVendidad = cantidadVendidaGramos;
                        modelologArticulo.PrecioVenta = int.Parse(itemventasRegistradas.precio);
                        modelologArticulo.Transaccion = "INSERCIÓN";
                        modelologArticulo.IdTipoArticulo = modeloArticulo.IdTipoArticulo;
                        modelologArticulo.IdTipoMarca = modeloArticulo.IdTipoMarca;
                        modelologArticulo.IdArticulo = modeloArticulo.IdArticulo;

                        _context.LogsArticulosInventarios.Add(modelologArticulo);
                        _context.SaveChanges();
                        
                        
                        int countVenta = _context.IngresasVentasTHs.Count();

                        modeloIngresaVentaTH.Codigo = "CODE_" + countVenta;
                        modeloIngresaVentaTH.EstadoActivo = true;
                        modeloIngresaVentaTH.FechaCreacion = DateTime.Now;
                        modeloIngresaVentaTH.Precio = modeloArticulo.Precio;
                        modeloIngresaVentaTH.IdArticulo = modeloArticulo.IdArticulo;

                        _context.IngresasVentasTHs.Add(modeloIngresaVentaTH);
                        _context.SaveChanges();

                    }
                    else if (itemventasRegistradas.code == "ACCESORIO")
                    {
                        modeloArticulo = _context.ArticulosInventarios.Where(modelConsulta => modelConsulta.IdArticulo == int.Parse(itemventasRegistradas.tipoAccesorio))
                                                                    .FirstOrDefault();

                        int cantidadVendida = (int)modeloArticulo.Precio / (int)int.Parse(itemventasRegistradas.precio);

                        modeloArticulo.CantidadDisponible = modeloArticulo.CantidadDisponible - cantidadVendida;
                        modeloArticulo.FechaActualizacion = DateTime.Now;

                        _context.Entry(modeloArticulo).State = EntityState.Modified;
                        _context.SaveChanges();



                        int countArticulo = _context.LogsArticulosInventarios.Count();

                        modelologArticuloAccesorio.Codigo = "CODE_" + countArticulo;
                        modelologArticuloAccesorio.EstadoActivo = true;
                        modelologArticuloAccesorio.Precio = modeloArticulo.Precio;
                        modelologArticuloAccesorio.CantidadDisponible = modeloArticulo.CantidadDisponible;
                        modelologArticuloAccesorio.CantidadVendidad = cantidadVendida;
                        modelologArticuloAccesorio.PrecioVenta = int.Parse(itemventasRegistradas.precio);
                        modelologArticuloAccesorio.Transaccion = "INSERCIÓN";
                        modelologArticuloAccesorio.IdTipoArticulo = modeloArticulo.IdTipoArticulo;
                        modelologArticuloAccesorio.IdTipoMarca = modeloArticulo.IdTipoMarca;
                        modelologArticuloAccesorio.IdArticulo = modeloArticulo.IdArticulo;

                        _context.LogsArticulosInventarios.Add(modelologArticuloAccesorio);
                        _context.SaveChanges();


                        int countVenta = _context.IngresasVentasTHs.Count();

                        modeloIngresaVentaTH.Codigo = "CODE_" + countVenta;
                        modeloIngresaVentaTH.EstadoActivo = true;
                        modeloIngresaVentaTH.FechaCreacion = DateTime.Now;
                        modeloIngresaVentaTH.Precio = modeloArticulo.Precio;
                        modeloIngresaVentaTH.IdArticulo = modeloArticulo.IdArticulo;

                        _context.IngresasVentasTHs.Add(modeloIngresaVentaTH);
                        _context.SaveChanges();
                    }
                    else
                    {
                        int idTipoBaño = _context.TiposBanosInventarios.Where(modeloBaños => modeloBaños.Nombre == itemventasRegistradas.tipoBano)
                                                                       .Select(modreloSele => modreloSele.IdTipoBanoInventario)
                                                                       .FirstOrDefault();

                        int idAnimal = _context.AnimalesInventarios.Where(modeloBaños => modeloBaños.Nombre == itemventasRegistradas.animal)
                                                                       .Select(modreloSele => modreloSele.IdAnimalInventario)
                                                                       .FirstOrDefault();

                        int countBaño = _context.LogsArticulosInventarios.Count();

                        modeloBaño.Codigo = "BANO_" + countBaño;
                        modeloBaño.FechaCreacion = DateTime.Now;
                        modeloBaño.EstadoActivo = true;
                        modeloBaño.Precio = int.Parse(itemventasRegistradas.precio);
                        modeloBaño.Transaccion = "INSERCIÓN";

                        modeloBaño.IdTipoBanoInventario = idTipoBaño;
                        modeloBaño.IdAnimalInventario = idAnimal;

                        _context.BanosInventarios.Add(modeloBaño);
                        _context.SaveChanges();


                    }

                }







                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }
        }

        public RArticuloInventario ConsultarArticuloId(string idArticulo)
        {
            try
            {
                RArticuloInventario articulo = new RArticuloInventario();


                articulo = _context.ArticulosInventarios.Where(modeloarticulo => modeloarticulo.EstadoActivo == true
                                                           && modeloarticulo.IdArticulo == int.Parse(idArticulo))
                                                     .Select(modeloSelect => new RArticuloInventario
                                                     {
                                                         IdArticulo = modeloSelect.IdArticulo.ToString(),
                                                         CantidadDisponible = modeloSelect.CantidadDisponible.ToString(),
                                                         Codigo = modeloSelect.Codigo,
                                                         Precio = modeloSelect.Precio.ToString(),
                                                         TipoArticulo = modeloSelect.FK_TipoArticuloInventarioConArticuloInventario.Nombre,
                                                         TipoMarca = modeloSelect.FK_TipoMarcaInventarioConArticuloInventario.Nombre,
                                                         ArchivoImagen = _context.DocumentosAdjuntosArticulos.Where(docu => docu.EstadoActivo && docu.IdArticulo == modeloSelect.IdArticulo)
                                                                                                          .Select(select => select.Archivo)
                                                                                                          .FirstOrDefault()
                                                     })
                                                     .FirstOrDefault()
                                                     ;



                return articulo;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }
        
        public List<RReporteIngresaVentaTH> ConsultarVentas(DateTime? fechaInici, DateTime? fechaFin, string idArticulo)
        {
            try
            {
                List<RReporteIngresaVentaTH> listaArticulo = new List<RReporteIngresaVentaTH>();


                listaArticulo = (from venta in _context.IngresasVentasTHs
                                 join articulo in _context.ArticulosInventarios on venta.IdArticulo equals articulo.IdArticulo
                                 join marca in _context.TiposMarcasInventarios on articulo.IdTipoMarca equals marca.IdTipoMarca
                                 where       // Si no se pasa fechaInici, no se aplica este filtro
                             (!fechaInici.HasValue || venta.FechaCreacion >= fechaInici.Value)
                             // Si no se pasa fechaFin, no se aplica este filtro
                             && (!fechaFin.HasValue || venta.FechaCreacion <= fechaFin.Value)
                             // Si idArticulo está vacío o null, no se aplica este filtro
                             && (string.IsNullOrEmpty(idArticulo) || venta.IdArticulo == int.Parse(idArticulo))
                                 select new RReporteIngresaVentaTH 
                                 {
                                     IdIngresaVenta = venta.IdIngresaVenta,
                                     FechaCreacion = venta.FechaCreacion,
                                     NombreArticulo = marca.Nombre
                                 }).ToList();



                return listaArticulo;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }

    }
}
