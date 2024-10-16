using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundialApiPet.Modelo.Inventario.ModelosRespuesta;
using MundialApiPet.Modelo.Ventas.ModelosRespuesta;
using MundialApiPet.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundialApiPet.Controllers
{
    [Route("api/VentasController")]
    [ApiController]
    public class VentasController : ControllerBase
    {

        private readonly RepositorioVentas repositorio;

        public VentasController(RepositorioVentas repositorioConsulta)
        {
            repositorio = repositorioConsulta;
        }


        [Route("GetConsultarListaPurinas")]
        [HttpGet]
        public IActionResult GetConsultarListaPurinas()
        {
            try
            {
                List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> lista = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();

                lista = repositorio.ConsultarListaPurina();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }

        [Route("GetConsultarListaAccesoriosMedicamentos")]
        [HttpGet]
        public IActionResult GetConsultarListaAccesoriosMedicamentos()
        {
            try
            {
                List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> lista = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();

                lista = repositorio.ConsultarListaAccesoriosMedicamentos();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }

        [Route("GetConsultarListaTipoBaño")]
        [HttpGet]
        public IActionResult GetConsultarListaTipoBaño()
        {
            try
            {
                List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> lista = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();

                lista = repositorio.ConsultarListaTipoBaño();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }


        [Route("GetConsultarListaAnimales")]
        [HttpGet]
        public IActionResult GetConsultarListaAnimales()
        {
            try
            {
                List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> lista = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();

                lista = repositorio.ConsultarListaAnimales();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }



        [Route("PostregistrarVenta")]
        [HttpPost]
        public IActionResult PostregistrarVenta([FromBody] List<RVentaIngresar> ventasRegistradas)
        {
            try
            {

                bool validarInsert = repositorio.RegistrarVenta(ventasRegistradas);






                return Ok();
            }
            catch (Exception ex)
            {

                 throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }


        [Route("GetConsultarArticuloPorId")]

        [HttpGet]
        public IActionResult GetConsultarArticuloPorId(string idArticulo)
        {
            try
            {
                RArticuloInventario modeloArticulo = new RArticuloInventario();

                modeloArticulo = repositorio.ConsultarArticuloId(idArticulo);
                return Ok(modeloArticulo);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }


        [Route("GetConsultarVentas")]

        [HttpGet]
        public IActionResult GetConsultarVentas(DateTime? fechaInici, DateTime? fechaFin, string idArticulo)
        {
            try
            {




                List<RReporteIngresaVentaTH> modeloArticulo = new List<RReporteIngresaVentaTH>();

                modeloArticulo = repositorio.ConsultarVentas(fechaInici, fechaFin, idArticulo);
                return Ok(modeloArticulo);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }
    }
}
