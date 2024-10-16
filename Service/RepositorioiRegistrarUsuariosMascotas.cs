using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MundialApiPet.Modelo;
using MundialApiPet.Modelo.Inventario;
using MundialApiPet.Modelo.Inventario.ModelosRespuesta;


namespace MundialApiPet.Service
{
    public class RepositorioiRegistrarUsuariosMascotas
    {

        private readonly Context _context;

        public RepositorioiRegistrarUsuariosMascotas(Context context)
        {
            _context = context;
        }

        public bool AddAgregarMascota(string nombre, string Telefono, string TelefonoDos, string NombrePropietario, string NombrePropietarioDos, string Genero, string Edad, string PrecioBano, string IdTipoRaza, string Observacion)
        {
            try
            {
                int countAnimal = _context.AnimalesInventarios.Count();

                AnimalInventario modeloAnimal = new AnimalInventario();

                int count = _context.ArticulosInventarios.Count();

                modeloAnimal.FechaCreacion = DateTime.Now;
                modeloAnimal.EstadoActivo = true;
                modeloAnimal.Codigo = "CODIGO_" + countAnimal;
                modeloAnimal.Nombre = nombre;
                modeloAnimal.NombrePropietario = NombrePropietario;
                modeloAnimal.NombrePropietarioDos = NombrePropietarioDos;
                modeloAnimal.Telefono = Telefono;
                modeloAnimal.TelefonoDos = TelefonoDos;
                modeloAnimal.Genero = Genero;
                modeloAnimal.Edad = Edad;
                modeloAnimal.PrecioBano = Convert.ToDecimal(PrecioBano);
                modeloAnimal.IdTipoRazaInventario = Convert.ToInt32(IdTipoRaza);
                modeloAnimal.Observacion = Observacion;
                modeloAnimal.BanderaAnimalBañoActivo = true;





                _context.AnimalesInventarios.Add(modeloAnimal);
                _context.SaveChanges();

                return true;



            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }
        }

        public List<SelectListItem> ConsultarListaTiporaza()
        {
            try
            {
                List<SelectListItem> lista = new List<SelectListItem>();


                lista = (from tipoMarca in _context.TiposRazasInventarios
                         where tipoMarca.EstadoActivo
                         select new SelectListItem
                         {
                             Text = tipoMarca.Nombre,
                             Value = tipoMarca.IdTipoRazaInventario.ToString()
                         }).ToList();



                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }

        public List<RAnimalInventario> ConsultarListaMascotaRegistradas()
        {
            try
            {
                List<RAnimalInventario> lista = new List<RAnimalInventario>();


                lista = (from mascota in _context.AnimalesInventarios
                         join tipoRaza in _context.TiposRazasInventarios on mascota.IdTipoRazaInventario equals tipoRaza.IdTipoRazaInventario
                         orderby mascota.IdAnimalInventario descending
                         where mascota.EstadoActivo
                         
                         select new RAnimalInventario
                         {
                            IdAnimalInventario = mascota.IdAnimalInventario,
                            Edad = mascota.Edad,
                            Genero = mascota.Genero,
                            Nombre = mascota.Nombre,
                            NombrePropietario = mascota.NombrePropietario,
                            NombrePropietarioDos = mascota.NombrePropietarioDos,
                            IdTipoRazaInventario = tipoRaza.Nombre,
                            PrecioBano = mascota.PrecioBano.ToString(),
                            Telefono = mascota.Telefono,
                            TelefonoDos = mascota.TelefonoDos,
                         }).ToList();



                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }

        public RAnimalInventario ConsultarMascotaPorId(string animales, string codigo)
        {
            try
            {
                RAnimalInventario lista = new RAnimalInventario();

                switch (codigo)
                {
                    case "tipoPurina":

                        lista = (from articuloInfoermacion in _context.ArticulosInventarios
                                 join tipoMarca in _context.TiposMarcasInventarios on articuloInfoermacion.IdTipoMarca equals tipoMarca.IdTipoMarca
                                 where articuloInfoermacion.EstadoActivo
                                 && articuloInfoermacion.IdArticulo == Convert.ToInt32(animales)
                                 select new RAnimalInventario
                                 {
                                     IdAnimalInventario = articuloInfoermacion.IdArticulo,
                                     Edad = articuloInfoermacion.CantidadDisponible.ToString(),
                                     Genero = articuloInfoermacion.Precio.ToString(),
                                     Nombre = tipoMarca.Nombre,
                                     NombrePropietario = tipoMarca.Nombre,
                                     NombrePropietarioDos = tipoMarca.Nombre,
                                     IdTipoRazaInventario = tipoMarca.Nombre,
                                     PrecioBano = tipoMarca.Nombre,
                                     Telefono = tipoMarca.Nombre,
                                     TelefonoDos = tipoMarca.Nombre,
                                     Observacion = tipoMarca.Nombre,
                                 }).FirstOrDefault();
                        break;

                    case "tipoAccesorio":

                        lista = (from articuloInfoermacion in _context.ArticulosInventarios
                                 join tipoMarca in _context.TiposMarcasInventarios on articuloInfoermacion.IdTipoMarca equals tipoMarca.IdTipoMarca
                                 where articuloInfoermacion.EstadoActivo
                                 && articuloInfoermacion.IdArticulo == Convert.ToInt32(animales)
                                 select new RAnimalInventario
                                 {
                                     IdAnimalInventario = articuloInfoermacion.IdArticulo,
                                     Edad = articuloInfoermacion.CantidadDisponible.ToString(),
                                     Genero = articuloInfoermacion.Precio.ToString(),
                                     Nombre = tipoMarca.Nombre,
                                     NombrePropietario = tipoMarca.Nombre,
                                     NombrePropietarioDos = tipoMarca.Nombre,
                                     IdTipoRazaInventario = tipoMarca.Nombre,
                                     PrecioBano = tipoMarca.Nombre,
                                     Telefono = tipoMarca.Nombre,
                                     TelefonoDos = tipoMarca.Nombre,
                                     Observacion = tipoMarca.Nombre,
                                 }).FirstOrDefault();
                        break;

                    case "tipoBano":

                        lista = (from articuloInfoermacion in _context.ArticulosInventarios
                                 join tipoMarca in _context.TiposMarcasInventarios on articuloInfoermacion.IdTipoMarca equals tipoMarca.IdTipoMarca
                                 where articuloInfoermacion.EstadoActivo
                                 && articuloInfoermacion.IdArticulo == Convert.ToInt32(animales)
                                 select new RAnimalInventario
                                 {
                                     IdAnimalInventario = articuloInfoermacion.IdArticulo,
                                     Edad = articuloInfoermacion.CantidadDisponible.ToString(),
                                     Genero = articuloInfoermacion.Precio.ToString(),
                                     Nombre = tipoMarca.Nombre,
                                     NombrePropietario = tipoMarca.Nombre,
                                     NombrePropietarioDos = tipoMarca.Nombre,
                                     IdTipoRazaInventario = tipoMarca.Nombre,
                                     PrecioBano = tipoMarca.Nombre,
                                     Telefono = tipoMarca.Nombre,
                                     TelefonoDos = tipoMarca.Nombre,
                                     Observacion = tipoMarca.Nombre,
                                 }).FirstOrDefault();
                        break;

                    case "animal":

                        lista = (from mascota in _context.AnimalesInventarios
                                 join tipoRaza in _context.TiposRazasInventarios on mascota.IdTipoRazaInventario equals tipoRaza.IdTipoRazaInventario
                                 where mascota.EstadoActivo
                                 && mascota.IdAnimalInventario == Convert.ToInt32(animales)
                                 select new RAnimalInventario
                                 {
                                     IdAnimalInventario = mascota.IdAnimalInventario,
                                     Edad = mascota.Edad,
                                     Genero = mascota.Genero,
                                     Nombre = mascota.Nombre,
                                     NombrePropietario = mascota.NombrePropietario,
                                     NombrePropietarioDos = mascota.NombrePropietarioDos,
                                     IdTipoRazaInventario = tipoRaza.Nombre,
                                     PrecioBano = mascota.PrecioBano.ToString(),
                                     Telefono = mascota.Telefono,
                                     TelefonoDos = mascota.TelefonoDos,
                                     Observacion = mascota.Observacion,
                                 }).FirstOrDefault();
                        break;


                    default:
                        break;
                }




                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }
    }
}
