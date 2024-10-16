using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundialApiPet.Modelo.Inventario.ModelosRespuesta
{
    public class RArticuloInventario
    {
        public string IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Precio { get; set; }
        public string CantidadDisponible { get; set; }
        public string TipoArticulo { get; set; }
        public string TipoMarca { get; set; }
        public string ArchivoImagen { get; set; }
    }
}
