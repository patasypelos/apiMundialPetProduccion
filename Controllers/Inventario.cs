using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundialApiPet.Modelo.Inventario.ModelosRespuesta;
using MundialApiPet.Modelo.ProductosServicios;
using MundialApiPet.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MundialApiPet.Controllers
{
    /// <summary>
    /// Autor: Jean Pierre
    /// Controlador que contiene la logica para los articulos
    /// </summary>
    [Route("api/Inventario")]
    [ApiController]

    public class Inventario : ControllerBase
    {
        private readonly RepositorioInventario repositorio;

        public Inventario(RepositorioInventario repositorioConsulta)
        {
            repositorio = repositorioConsulta;
        }

        /// <summary>
        /// Autor: Jean Pierre
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [Route("GetConsultarListaTipoMarca")]
        [HttpGet]
        public IActionResult GetConsultarListaTipoMarca()
        {
            try
            {




                List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> lista = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();

                lista = repositorio.ConsultarListaTipoMarca();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }

        /// <summary>
        /// Autor: Jean Pierre
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [Route("GetConsultarListaTipoArticulo")]

        [HttpGet]
        public IActionResult GetConsultarListaTipoArticulo()
        {
            try
            {
                List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> lista = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();

                lista = repositorio.ConsultarListaTipoArticulo();
                return Ok(lista);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }


        /// <summary>
        /// Autor: Jean Pierre
        /// </summary>
        /// <param name="tipoArticulo"></param>
        /// <param name="tipoMarca"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        //[Route("PostAgregarArticuloInventario")]

        //[HttpPost]
        //public IActionResult PostAgregarArticuloInventario(string tipoArticulo, string tipoMarca, string cantidad, string precio)
        //{
        //    try
        //    {

        //        bool verifircarAddInversion = false;
        //        verifircarAddInversion = repositorio.AddAgregarArticuloInventario(tipoArticulo, tipoMarca, cantidad,precio);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

        //    }


        //    // Devuelve la lista actualizada como respuesta.
        //    return Ok();
        //}

    

        [HttpPost]
        [Route("PostAgregarArticuloInventario")]
        public async Task<IActionResult> PostAgregarArticuloInventario([FromForm] RArticuloRegistro articulo, IFormFile imagen)
        {
            try
            {
                int idArticulo = 0;

                bool verificarAddInversion = repositorio.AddAgregarArticuloInventario(articulo.TipoArticulo, articulo.TipoMarca, articulo.Cantidad, articulo.Precio, ref idArticulo);


                if (imagen != null)
                {
                    // Definir la carpeta donde se guardará la imagen
                    var carpetaDocumentos = Path.Combine(Directory.GetCurrentDirectory(), "Documentos", "DocumentosArticulos");

                    // Crear la carpeta si no existe
                    if (!Directory.Exists(carpetaDocumentos))
                    {
                        Directory.CreateDirectory(carpetaDocumentos);
                    }

                    // Definir el nombre completo de la imagen
                    var nombreImagen = $"{Guid.NewGuid()}_{Path.GetFileName(imagen.FileName)}";
                    var rutaImagen = Path.Combine(carpetaDocumentos, nombreImagen);

                    // Guardar la imagen en la carpeta
                    using (var stream = new FileStream(rutaImagen, FileMode.Create))
                    {
                        await imagen.CopyToAsync(stream);
                    }

                    bool verificarAdjunto = repositorio.AddAgregarDocumentoArticuloInventario(nombreImagen, idArticulo);


                  

                }





            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información: " + ex.Message);
            }

            // Devuelve la lista actualizada como respuesta.
            return Ok();
        }


        /// <summary>
        /// Autor: Jean Pierre
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [Route("GetConsultarListaArticulos")]

        [HttpGet]
        public IActionResult GetConsultarListaArticulos()
        {
            try
            {
                List<RArticuloInventario> listaarticulo = new List<RArticuloInventario>();

                listaarticulo = repositorio.ConsultarListaArticulo();
                return Ok(listaarticulo);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }


        /// <summary>
        /// Autor: Jean Pierre
        /// </summary>
        /// <param name="idArticulo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [Route("GetConsultarArticuloPorId")]

        [HttpGet]
        public IActionResult GetConsultarArticuloPorId(int idArticulo)
        {
            try
            {
                RArticuloInventario listaarticulo = new RArticuloInventario();

                listaarticulo = repositorio.ConsultarArticuloPorId(idArticulo);
                return Ok(listaarticulo);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }
        /// <summary>
        /// Autor: Jean Pierre
        /// </summary>
        /// <param name="modeloArticuloInventario"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [Route("PutActualizarArticuloInventario")]
        [HttpPost]
        public IActionResult PutActualizarArticuloInventario([FromBody] RArticuloInventario modeloArticuloInventario)
        {
            try
            {

                bool validarInsert = repositorio.ActualizarArticuloInventario(modeloArticuloInventario);



                return Ok();
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }


        /// <summary>
        /// Autor: Jean Pierre
        /// </summary>
        /// <param name="RModelMarca"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [Route("PostCrearMarcaInventario")]
        [HttpPost]
        public IActionResult PostCrearMarcaInventario([FromBody] RMarca RModelMarca)
        {
            try
            {

                bool validarInsert = repositorio.CrearMarcaInventario(RModelMarca);



                return Ok();
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }

        /// <summary>
        /// Autor: Jean Pierre
        /// </summary>
        /// <param name="RmodeloArticulo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [Route("PostCrearTipoArticuloInventario")]
        [HttpPost]
        public IActionResult PostCrearTipoArticuloInventario([FromBody] RArticulo RmodeloArticulo)
        {
            try
            {

                bool validarInsert = repositorio.CrearTipoArticuloInventario(RmodeloArticulo);



                return Ok();
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }
    }
}
