using System;
using System.ComponentModel.DataAnnotations;

namespace Actividad3LengProg3.Models
{
    public class EstudianteViewModel
    {
        [Required(ErrorMessage = "Es obligado llenar este campo")]
        [StringLength(100)]
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "Es obligado llenar este campo")]
        [StringLength(15, MinimumLength = 6)]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Es obligado elegir una carrera")]
        public string Carrera { get; set; }

        [Required(ErrorMessage = "Es obligado llenar este campo")]
        [EmailAddress]
        [Display(Name = "Correo institucional")]
        public string CorreoInstitucional { get; set; }

        [Phone(ErrorMessage = "Es obligado llenar este campo")]
        [MinLength(10)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Es obligado seleccionar la fecha de nacimiento")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Es obligado llenar este campo")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Es obligado elegir un turno")]
        public string Turno { get; set; }

        [Required(ErrorMessage = "Es obligado elegir un elemento de este campo")]
        [Display(Name = "Tipo de ingreso")]
        public string TipoIngreso { get; set; }

        [Display(Name = "¿Estás becado?")]
        public bool EstaBecado { get; set; }

        [Range(0, 100)]
        [Display(Name = "Porcentaje de la beca")]
        public int? PorcentajeBeca { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Debe aceptar los términos")]
        public bool AceptaTerminos { get; set; }
    }
}
