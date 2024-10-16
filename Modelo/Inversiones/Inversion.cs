using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MundialApiPet.Modelo.Inversiones
{
    [Table("InversionTienda")]
    public class Inversion
    {
        [Key]
        [Column(TypeName = "INT")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInversionTienda { get; set; }

        [Column(TypeName = "DATETIME")]
        [Display(Name = "Fecha registro")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }

        [Column(TypeName = "DECIMAL")]
        [Display(Name = "Valor")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal? Valor { get; set; }

        [Column(TypeName = "nvarchar(MAX)")] // Cambia la longitud máxima según tus necesidades
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}
