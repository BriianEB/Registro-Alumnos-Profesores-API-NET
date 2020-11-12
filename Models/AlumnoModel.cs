using System.ComponentModel.DataAnnotations;

namespace RegistroAlumnosYProfesoresAPI.Models
{
    public class AlumnoModel {
        [Key]
        public string Matricula { get; set; }

        public string Nombre { get; set; }

        public string Carrera { get; set; }

        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}