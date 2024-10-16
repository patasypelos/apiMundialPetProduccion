using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundialApiPet.Modelo.Inventario.ModelosRespuesta;
using MundialApiPet.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundialApiPet.Controllers
{
    [Route("api/RegistrarUsuariosMascotas")]
    [ApiController]
    public class RegistrarUsuariosMascotas : ControllerBase
    {
        private readonly RepositorioiRegistrarUsuariosMascotas repositorio;

        public RegistrarUsuariosMascotas(RepositorioiRegistrarUsuariosMascotas repositorioConsulta)
        {
            repositorio = repositorioConsulta;
        }

        [Route("PostregistrarMascota")]
        [HttpPost]
        public IActionResult PostregistrarMascota(string nombre, string Telefono, string TelefonoDos, string NombrePropietario, string NombrePropietarioDos, string Genero, string Edad, string PrecioBano, string IdTipoRaza, string Observacion, string imagen)
        {
            try
            {
                List<RAnimalInventario> lista = new List<RAnimalInventario>();

                bool validarInsert = repositorio.AddAgregarMascota(nombre, Telefono, TelefonoDos, NombrePropietario, NombrePropietarioDos, Genero, Edad, PrecioBano, IdTipoRaza, Observacion);

                if (validarInsert)
                {
                  

                    lista = repositorio.ConsultarListaMascotaRegistradas();
                }
             

                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }



        [Route("GetConsultarListaTipoRaza")]

        [HttpGet]
        public IActionResult GetConsultarListaTipoRaza()
        {
            try
            {
                List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> lista = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();

                lista = repositorio.ConsultarListaTiporaza();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }


        [Route("GetConsultarListaMascotaRegistradas")]

        [HttpGet]
        public IActionResult GetConsultarListaMascotaRegistradas()
        {
            try
            {
                List<RAnimalInventario> lista = new List<RAnimalInventario>();

                lista = repositorio.ConsultarListaMascotaRegistradas();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }


        [Route("GetConsultarMascotaPorId")]

        [HttpGet]
        public IActionResult GetConsultarMascotaPorId(string animales, string codigo)
        {
            try
            {
                RAnimalInventario lista = new RAnimalInventario();

                lista = repositorio.ConsultarMascotaPorId(animales, codigo);
                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }

        [HttpPut("ActualizarMascota/{id}")]
        public IActionResult ActualizarMascota(int id, [FromBody] RAnimalInventario mascotaActualizada)
        {
            try
            {
                // Aquí debes implementar la lógica para actualizar la mascota en tu base de datos
                // Puedes utilizar un ORM como Entity Framework o tu lógica personalizada
                // mascotaActualizada contiene los datos actualizados de la mascota

                // Ejemplo de cómo actualizar una mascota en una lista ficticia de mascotas
                //var mascotaExistente = listaDeMascotas.FirstOrDefault(m => m.IdAnimalInventario == id);
                //if (mascotaExistente == null)
                //{
                //    return NotFound(); // Mascota no encontrada
                //}

                // Actualiza los campos relevantes de la mascota existente con los datos de mascotaActualizada
                //mascotaExistente.Nombre = mascotaActualizada.Nombre;
                //mascotaExistente.Telefono = mascotaActualizada.Telefono;
                // Actualiza otros campos según sea necesario

                return Ok(); // Respuesta exitosa
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }

    }
}
