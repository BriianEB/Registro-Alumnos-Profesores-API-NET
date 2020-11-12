using System.Linq;
using System.Collections.Generic;
using RegistroAlumnosYProfesoresAPI.Data;
using RegistroAlumnosYProfesoresAPI.Models;

namespace RegistroAlumnosYProfesoresAPI.Services
{
    public class AlumnoService
    {
        private readonly AppDbContext dbContext;

        public AlumnoService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IList<AlumnoModel> GetAlumnos()
        {
            return dbContext.Alumnos.ToList();
        }

        public void AddAlumno(AlumnoModel alumno)
        {
            dbContext.Add(alumno);
            dbContext.SaveChanges();
        }

        public AlumnoModel GetAlumno(string matricula)
        {
            return dbContext.Alumnos.FirstOrDefault(a => a.Matricula == matricula);
        }
    }
}