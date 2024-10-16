using MundialApiPet.Modelo.AdministracionUsuario;
using MundialApiPet.Modelo.Inventario;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using MundialApiPet.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Drawing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using MundialApiPet.Modelo.AdministracionUsuario.ModeloRespuesta;
using MundialApiPet.Modelo.Respuesta;


namespace MundialApiPet.Service
{
    public class RepositorioUsuarioAdministracion
    {

        private readonly Context db;

        public RepositorioUsuarioAdministracion(Context context)
        {
            db = context;
        }
        public bool AddAgregarUsuario(RUsuarioAdministracion usuarioModel)
        {
            try
            {
                Response response = new Response();


                UsuarioAdministracion modeloUsuarioAdministracion = new UsuarioAdministracion();


                bool verificarExistencia = db.UsuariosAdministraciones.Where(modeloUsua => modeloUsua.EstadoActivo == true
                                                                           && modeloUsua.Correo == usuarioModel.Correo)
                                                                      .Any();


                if(verificarExistencia == false)
                {
                    int count = db.UsuariosAdministraciones.Count();
                    int numeroContador = count + 1;

                    string contraseñaqEncryp = Encrypt(usuarioModel.Contrasenia);

                    modeloUsuarioAdministracion.FechaCreacion = DateTime.Now;
                    modeloUsuarioAdministracion.EstadoActivo = true;
                    modeloUsuarioAdministracion.Nombre = usuarioModel.Nombre;
                    modeloUsuarioAdministracion.Apellidos = usuarioModel.Apellidos;
                    modeloUsuarioAdministracion.Codigo = usuarioModel.Nombre + "_" + usuarioModel.Apellidos + numeroContador;
                    modeloUsuarioAdministracion.Contraseña = contraseñaqEncryp;
                    modeloUsuarioAdministracion.Correo = usuarioModel.Correo;



                    db.UsuariosAdministraciones.Add(modeloUsuarioAdministracion);
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }





            }
            catch (Exception ex)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información" + ex.Message);

            }
        }

        private static readonly string key = "claveSuperSegura";
        public static string Encrypt(string plainText)
        {
            byte[] iv = new byte[16];
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (var sw = new StreamWriter(cs))
                            {
                                sw.Write(plainText);
                            }
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            }
        }


        public bool ConsultarUsuarioRegistrado(string Correo, string Contrasenia, ref bool verificarRegistro)
        {
            try
            {


                bool validarCorreo = db.UsuariosAdministraciones.Where(modeloUsu => modeloUsu.EstadoActivo == true
                                                                     && modeloUsu.Correo ==  Correo)
                                                                .Any();

                if (validarCorreo) 
                {
                    string contraseñaqEncryp = Encrypt(Contrasenia);

                    bool validarContraseña = db.UsuariosAdministraciones.Where(modeloUsu => modeloUsu.EstadoActivo == true
                                                                    && modeloUsu.Contraseña == contraseñaqEncryp)
                                                               .Any();
                    verificarRegistro = validarContraseña;
                    return true;
                }
                else
                {
                    return false;
                }




                
            }
            catch (Exception e)
            {
                throw new Exception("Comuníquese con el administrador del sistema de información. " + e.Message);
            }
        }
    }
}
