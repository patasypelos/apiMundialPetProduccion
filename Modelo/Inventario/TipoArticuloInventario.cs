using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MundialApiPet.Modelo.Inventario
{
    [Table("TipoArticulo")]

    public class TipoArticuloInventario
    {
        [Key]
        [Column(TypeName = "INT", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoArticulo { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 2)]
        [Display(Name = "Código tipo articulo")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 300")]
        public string Codigo { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 3)]
        [Display(Name = "Nombre tipo articulo")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 300")]
        public string Nombre { get; set; }


        [Column(TypeName = "BIT", Order = 4)]
        [Display(Name = "Estado activo")]
        public bool EstadoActivo { get; set; }
    }
}
