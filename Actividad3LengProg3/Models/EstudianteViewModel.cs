using System.ComponentModel.DataAnnotations;

namespace Actividad3LengProg3.Models
{
    public class EstudianteViewModel
    {
        [Required]
        public string Matricula { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Range(1, 12)]
        public int Semestre { get; set; }

        [Required]
        public string Carrera { get; set; }
    }
}