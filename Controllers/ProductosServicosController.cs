using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundialApiPet.Service;
using System.Collections.Generic;
using System;
using MundialApiPet.Modelo.ProductosServicios.ModeloRespuesta;

namespace MundialApiPet.Controllers
{
    [Route("api/ProductosServicosController")]
    [ApiController]
    public class ProductosServicosController : ControllerBase
    {
        private readonly RepositorioProductosServicos repositorio;

        public ProductosServicosController(RepositorioProductosServicos repositorioConsulta)
        {
            repositorio = repositorioConsulta;
        }

        /// <summary>
        /// Autor: Jean Pierre
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [Route("GetConsultarProductoServicoio")]
        [HttpGet]
        public IActionResult GetConsultarProductoServicoio(string category)
        {
            try
            {
                List<RProductoServicio> listaRProductoServicio = new List<RProductoServicio>();


                listaRProductoServicio = repositorio.ConsultarProductoServicoio(category);





                return Ok(listaRProductoServicio);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }
    }
}
