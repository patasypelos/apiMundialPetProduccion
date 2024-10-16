using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundialApiPet.Modelo.AdministracionUsuario;
using MundialApiPet.Modelo.AdministracionUsuario.ModeloRespuesta;
using MundialApiPet.Modelo.Inventario.ModelosRespuesta;
using MundialApiPet.Modelo.Respuesta;
using MundialApiPet.Service;
using System;
using System.Collections.Generic;

namespace MundialApiPet.Controllers
{
    [Route("api/UsuarioAdministracionController")]
    [ApiController]


    public class UsuarioAdministracionController : ControllerBase
    {
        private readonly RepositorioUsuarioAdministracion repositorio;

        public UsuarioAdministracionController(RepositorioUsuarioAdministracion repositorioAdministracion)
        {
            repositorio = repositorioAdministracion;
        }

        [HttpPost]
        [Route("PostAddAgregarUsuario")]
        public IActionResult PostAddAgregarUsuario([FromBody] RUsuarioAdministracion usuarioModel)
        {

            Response response = new Response();
            try
            {

              

                bool agregarUsuario = false;

                agregarUsuario = repositorio.AddAgregarUsuario(usuarioModel);

                if (agregarUsuario)
                {
                    response.Message = "Usuario puede ingresar";
                    response.Code = 200;
                    response.Count = 1;
                }
                else
                {
                    response.Message = "El correo ingresado ya se encuentra registrado.";
                    response.Code = 204;
                    response.Count = 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información: " + ex.Message);
            }

            return Ok(response);
        }


        [Route("GetConsultarUsuarioRegistrado")]

        [HttpGet]
        public IActionResult GetConsultarUsuarioRegistrado(string Correo, string Contrasenia)
        {
            try
            {
                Response response = new Response();

                bool verificar = false;
                bool verificarRegistro = false;
                verificar = repositorio.ConsultarUsuarioRegistrado(Correo, Contrasenia, ref verificarRegistro);

                if (verificar)
                {

                    if (verificarRegistro)
                    {
                        response.Message = "Usuario puede ingresar";
                        response.Code = 200;
                        response.Count = 1;
                    }
                    else
                    {
                        response.Message = "La contraseña es incorrecta";
                        response.Code = 204;
                        response.Count = 1;
                    }
                }
                else
                {
                    response.Message = "Usuario no se encuentra registrado";
                    response.Code = 204;
                    response.Count = 0;

                }

                return Ok(response);
            }
            catch (Exception ex)
            {

                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);
            }

        }

    }
}
