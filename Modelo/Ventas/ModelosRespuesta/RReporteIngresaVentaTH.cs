using MundialApiPet.Modelo.Inventario;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.IO;

namespace MundialApiPet.Modelo.Ventas.ModelosRespuesta
{
    public class RReporteIngresaVentaTH
    {
    
        public int IdIngresaVenta { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public decimal Precio { get; set; }
        public string NombreArticulo { get; set; }
    }
}
