using System.ComponentModel.DataAnnotations;

namespace RegistroAlumnosYProfesoresAPI.Models
{
    public class ProfesorModel
    {
        [Key]
        public string NoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string Telefono { get; set; }
    }
}