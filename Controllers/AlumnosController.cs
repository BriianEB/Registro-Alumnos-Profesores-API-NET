using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using RegistroAlumnosYProfesoresAPI.Models;
using RegistroAlumnosYProfesoresAPI.Services;

namespace RegistroAlumnosYProfesoresAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AlumnosController : ControllerBase
    {
        private AlumnoService alumnoService;

        public AlumnosController(AlumnoService alumnoService)
        {
            this.alumnoService = alumnoService;
        }

        [Route("")]
        public IActionResult GetAlumnos()
        {
            return Content(JsonSerializer.Serialize(alumnoService.GetAlumnos()), "text/json");
        }

        [Route("{matricula}")]
        public IActionResult GetAlumno(string matricula)
        {
            if (matricula == null)
            {
                return NotFound();
            }

            var alumno = alumnoService.GetAlumno(matricula);

            if (alumno == null)
            {
                return NotFound();
            }

            return Content(JsonSerializer.Serialize(alumno), "text/json");
        }

        [Route("Create")]
        public IActionResult CreateAlumno(AlumnoModel alumno)
        {
            alumnoService.AddAlumno(alumno);

            return NoContent();
        }
    }
}