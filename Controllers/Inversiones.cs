using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundialApiPet.Modelo.Inversiones;
using MundialApiPet.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundialApiPet.Controllers
{
    [Route("api/Inversiones")]
    [ApiController]
    public class Inversiones : ControllerBase
    {
        private readonly RepositorioInversiones repositorio;

        public Inversiones(RepositorioInversiones repositorioConsulta)
        {
            repositorio = repositorioConsulta;
        }

        [HttpGet]
        public IActionResult GetConsultarInversiones()
        {
            try
            {
                List<Inversion> lista = new List<Inversion>();

                lista = repositorio.ConsultarListaInversion();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }

        [HttpPost]
        public IActionResult AgregarInversion(string fechaRegistro, string valor, string descripcion)
        {
            try
            {
                // Consulta la lista actualizada de inversiones.
                bool verifircarAddInversion = false;
                verifircarAddInversion = repositorio.AddAgregarInversion(fechaRegistro, valor, descripcion);


            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }


            // Devuelve la lista actualizada como respuesta.
            return Ok();
        }
    }
}
