using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace MundialApiPet.Modelo.AdministracionUsuario.ModeloRespuesta
{
    public class RUsuarioAdministracion
    {
 
        public bool EstadoActivo { get; set; }
            

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Correo { get; set; }

        public string Contrasenia { get; set; }
    }
}
