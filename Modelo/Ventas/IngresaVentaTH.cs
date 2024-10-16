using MundialApiPet.Modelo.Inventario;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MundialApiPet.Modelo.Ventas
{
    [Table("IngresaVenta")]

    public class IngresaVentaTH
    {
        [Key]
        [Column(TypeName = "INT", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdIngresaVenta { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 2)]
        [Display(Name = "Código")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 300")]
        public string Codigo { get; set; }


        [Display(Name = "Fecha creación", Order = 3)]
        [Column(Order = 3)]
        public DateTime? FechaCreacion { get; set; }


        [Display(Name = "Fecha actualización", Order = 4)]
        [Column(Order = 4)]
        public DateTime? FechaActualizacion { get; set; }


        [Display(Name = "Fecha desactivación", Order = 5)]
        [Column(Order = 5)]
        public DateTime? FechaDesactivacion { get; set; }




        [Column(TypeName = "BIT", Order = 6)]
        [Display(Name = "Estado")]
        public bool EstadoActivo { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }


        [Column(TypeName = "INT", Order = 7)]
        [ForeignKey("FK_ArticuloInventarioConIngresaVenta")]
        [Display(Name = "Articulo")]
        public int? IdArticulo { get; set; }
        public ArticuloInventario FK_ArticuloInventarioConIngresaVenta { get; set; }
    }
}
