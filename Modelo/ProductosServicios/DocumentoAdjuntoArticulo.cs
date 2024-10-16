using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MundialApiPet.Modelo.Inventario;

namespace MundialApiPet.Modelo.ProductosServicios
{
    [Table("DocumentoAdjuntoArticuloTH")]

    public class DocumentoAdjuntoArticulo
    {
        [Key]
        [Column(TypeName = "INT", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDocumentoAdjuntoArticulo { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 2)]
        [Display(Name = "Código imagen")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 300")]
        public string Codigo { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 3)]
        [Display(Name = "Archivo imagen")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 300")]
        public string Archivo { get; set; }


        [Column(TypeName = "BIT", Order = 4)]
        [Display(Name = "Estado activo")]
        public bool EstadoActivo { get; set; }


        [Column(TypeName = "INT", Order = 5)]
        [ForeignKey("FK_DocumentoAdjuntoArticuloConArticuloInventario")]
        [Display(Name = "Articulo")]
        public int? IdArticulo { get; set; }
        public ArticuloInventario FK_DocumentoAdjuntoArticuloConArticuloInventario { get; set; }
    }
}
