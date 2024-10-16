using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using MundialApiPet.Modelo;
using MundialApiPet.Modelo.Inventario;
using MundialApiPet.Modelo.Inventario.ModelosRespuesta;
using MundialApiPet.Modelo.ProductosServicios;
using MundialApiPet.Modelo.Ventas.ModelosRespuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MundialApiPet.Service
{
    public class RepositorioInventario
    {
        private readonly Context _context;

        public RepositorioInventario(Context context)
        {
            _context = context;
        }


        public List<SelectListItem> ConsultarListaTipoArticulo()
        {
            try
            {
                List<SelectListItem> lista = new List<SelectListItem>();


                lista = (from tipoMarca in _context.TiposArticulosInventarios
                         where tipoMarca.EstadoActivo
                         select new SelectListItem
                         {
                             Text = tipoMarca.Nombre,
                             Value = tipoMarca.IdTipoArticulo.ToString()
                         }).ToList();



                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }


        public bool AddAgregarArticuloInventario(string tipoArticulo, string tipoMarca, string cantidad, string precio, ref int idArticulo)
        {
            try
            {

                ArticuloInventario modeloInventario = new ArticuloInventario();

                int count = _context.ArticulosInventarios.Count();

                modeloInventario.FechaCreacion = DateTime.Now;
                modeloInventario.EstadoActivo = true;
                modeloInventario.IdTipoArticulo = Convert.ToInt32(tipoArticulo);
                modeloInventario.IdTipoMarca = Convert.ToInt32(tipoMarca);
                modeloInventario.Precio = Convert.ToDecimal(precio);
                modeloInventario.Codigo = "COD_00" + count;
                modeloInventario.CantidadDisponible = Convert.ToInt32(cantidad);



                _context.ArticulosInventarios.Add(modeloInventario);
                _context.SaveChanges();

                idArticulo = _context.ArticulosInventarios.Where(arti => arti.Codigo == modeloInventario.Codigo)
                                                          .Select(select => select.IdArticulo)
                                                          .FirstOrDefault();


                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }
        }
        
        public bool AddAgregarDocumentoArticuloInventario(string nombreImagen, int idArticulo)
        {
            try
            {
            

                DocumentoAdjuntoArticulo modeloDocumentoAdjuntoArticulo = new DocumentoAdjuntoArticulo();


                modeloDocumentoAdjuntoArticulo.Archivo = nombreImagen;
                modeloDocumentoAdjuntoArticulo.Codigo = Guid.NewGuid().ToString();
                modeloDocumentoAdjuntoArticulo.EstadoActivo = true;
                modeloDocumentoAdjuntoArticulo.IdArticulo = idArticulo;


                _context.DocumentosAdjuntosArticulos.Add(modeloDocumentoAdjuntoArticulo);
                _context.SaveChanges();

                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }
        }

        public List<SelectListItem> ConsultarListaTipoMarca()
        {
            try
            {
                List<SelectListItem> lista = new List<SelectListItem>();


                lista = (from tipoMarca in _context.TiposMarcasInventarios
                         where tipoMarca.EstadoActivo
                         select new SelectListItem
                         {
                             Text = tipoMarca.Nombre,
                             Value = tipoMarca.IdTipoMarca.ToString()
                         }).ToList();



                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }


        public List<RArticuloInventario> ConsultarListaArticulo()
        {
            try
            {
                List<RArticuloInventario> lista = new List<RArticuloInventario>();


                lista = _context.ArticulosInventarios.Where(modeloarticulo => modeloarticulo.EstadoActivo == true)
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
                                                     .OrderByDescending(orden => orden.IdArticulo)
                                                     .ToList()
                                                     ;



                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }

        public RArticuloInventario ConsultarArticuloPorId(int idArticulo)
        {
            try
            {
                RArticuloInventario lista = new RArticuloInventario();


                lista = _context.ArticulosInventarios.Where(modeloarticulo => modeloarticulo.EstadoActivo == true && modeloarticulo.IdArticulo == idArticulo)
                                                     .Select(modeloSelect => new RArticuloInventario 
                                                     {
                                                      IdArticulo = modeloSelect.IdArticulo.ToString(),
                                                      CantidadDisponible = modeloSelect.CantidadDisponible.ToString(),
                                                      Codigo = modeloSelect.Codigo,
                                                      Precio = modeloSelect.Precio.ToString(),
                                                      TipoArticulo = modeloSelect.FK_TipoArticuloInventarioConArticuloInventario.Nombre,
                                                      TipoMarca = modeloSelect.FK_TipoMarcaInventarioConArticuloInventario.Nombre
                                                     })
                                                     .FirstOrDefault();



                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }

        public bool ActualizarArticuloInventario(RArticuloInventario modeloRArticuloInventario)
        {
            try
            {

                ArticuloInventario modeloInventario = new ArticuloInventario();

                modeloInventario = _context.ArticulosInventarios.Where(modeloArticulo => modeloArticulo.IdArticulo == Convert.ToInt32(modeloRArticuloInventario.IdArticulo))
                                                                .FirstOrDefault();

                modeloInventario.CantidadDisponible = Convert.ToInt32(modeloRArticuloInventario.CantidadDisponible);
                modeloInventario.Precio = Convert.ToDecimal(modeloRArticuloInventario.Precio);


                _context.Entry(modeloInventario).State = EntityState.Modified;
                _context.SaveChanges();

                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }
        }
        
        public bool CrearMarcaInventario(RMarca RModelMarca)
        {
            try
            {

                TipoMarcaInventario rTipoMarcaInventario = new TipoMarcaInventario();

                int coun = _context.TiposMarcasInventarios.Count();
                int count = coun + 1;

                rTipoMarcaInventario.Nombre = RModelMarca.nombreMarca;
                rTipoMarcaInventario.Codigo = "COD_MARCA_" + count;
                rTipoMarcaInventario.EstadoActivo = true;

                _context.TiposMarcasInventarios.Add(rTipoMarcaInventario);
                _context.SaveChanges();

                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }
        }
        
        public bool CrearTipoArticuloInventario(RArticulo RmodeloArticulo)
        {
            try
            {

                TipoArticuloInventario rTipoArticuloInventario = new TipoArticuloInventario();

                int coun = _context.TiposArticulosInventarios.Count();
                int count = coun + 1;

                rTipoArticuloInventario.Nombre = RmodeloArticulo.nombreArticulo;
                rTipoArticuloInventario.Codigo = "COD_MARCA_" + count;
                rTipoArticuloInventario.EstadoActivo = true;

                _context.TiposArticulosInventarios.Add(rTipoArticuloInventario);
                _context.SaveChanges();

                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }
        }
    }
}
