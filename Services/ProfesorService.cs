using System.Collections.Generic;
using System.Linq;
using RegistroAlumnosYProfesoresAPI.Models;
using RegistroAlumnosYProfesoresAPI.Data;

namespace RegistroAlumnosYProfesoresAPI.Services
{
    public class ProfesorService
    {
        private readonly AppDbContext dbContext;

        public ProfesorService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IList<ProfesorModel> GetProfesores()
        {
            return dbContext.Profesores.ToList();
        }

        public void AddProfesor(ProfesorModel profesor)
        {
            dbContext.Add(profesor);
            dbContext.SaveChanges();
        }

        public ProfesorModel GetProfesor(string noEmpleado)
        {
            return dbContext.Profesores.FirstOrDefault(p => p.NoEmpleado == noEmpleado);
        }
    }
}