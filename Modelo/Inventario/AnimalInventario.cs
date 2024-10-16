using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MundialApiPet.Modelo.Inventario
{
    [Table("Animal")]
    public class AnimalInventario
    {
        [Key]
        [Column(TypeName = "INT", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAnimalInventario { get; set; }

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


        [Column(TypeName = "NVARCHAR(255)", Order = 7)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre animal")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string Nombre { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 8)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Telefono animal")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string Telefono { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 9)]
        [Display(Name = "Telefono animal dos")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string TelefonoDos { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 10)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre propietario")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string NombrePropietario { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 11)]
        [Display(Name = "Nombre propietario dos")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string NombrePropietarioDos { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 12)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Genero animal")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string Genero { get; set; }


        [Column(TypeName = "NVARCHAR(255)", Order = 13)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Edad animal")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string Edad { get; set; }

        [Column(TypeName = "decimal(18, 2)", Order = 14)]
        [Display(Name = "Precio del baño")]
        public decimal PrecioBano { get; set; }


        [Column(TypeName = "INT", Order = 15)]
        [ForeignKey("FK_TipoRazaInventarioConAnimalInventario")]
        [Display(Name = "Tipo raza")]
        public int? IdTipoRazaInventario { get; set; }
        public TipoRazaInventario FK_TipoRazaInventarioConAnimalInventario { get; set; }

        [Column(TypeName = "NVARCHAR(255)")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Observación animal")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string Observacion { get; set; }


        [Column(TypeName = "BIT")]
        [Display(Name = "Estado baño animal")]
        public bool BanderaAnimalBañoActivo { get; set; }
    }
}
