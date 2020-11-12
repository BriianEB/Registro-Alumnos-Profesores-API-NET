using System.Collections.Generic;

namespace RegistroAlumnosYProfesoresAPI.Models
{
    public class HomeIndexDataModel
    {
        public IList<AlumnoModel> Alumnos { get; set; }
        public IList<ProfesorModel> Profesores { get; set; }
    }
}