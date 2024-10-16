using MundialApiPet.Modelo.Inventario;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;


namespace MundialApiPet.Modelo.AdministracionUsuario
{
    public class UsuarioAdministracion
    {
        [Key]
        [Column(TypeName = "INT", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }


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
        [Display(Name = "Nombre usuario")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string Nombre { get; set; }
        
        
        [Column(TypeName = "NVARCHAR(255)", Order = 8)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Apellidos usuario")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string Apellidos { get; set; }
        
        
        [Column(TypeName = "NVARCHAR(155)", Order = 9)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Correo electronico")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string Correo { get; set; }
        
        
        [Column(TypeName = "NVARCHAR(500)", Order = 10)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Contraseña")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El campo {0} permite un mínimo de 3 caracteres y un máximo de 30")]
        public string Contraseña { get; set; }


    }
}
