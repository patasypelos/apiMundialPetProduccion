using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundialApiPet.Modelo.Inventario.ModelosRespuesta
{
    public class RAnimalInventario
    {
     
        public int IdAnimalInventario { get; set; }
        public string Nombre { get; set; }


     
        public string Telefono { get; set; }

        public string TelefonoDos { get; set; }


        public string NombrePropietario { get; set; }


        public string NombrePropietarioDos { get; set; }

        public string Genero { get; set; }

        public string Edad { get; set; }

        public string PrecioBano { get; set; }

        public string IdTipoRazaInventario { get; set; }

        public string Observacion { get; set; }
    }
}
