using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using RegistroAlumnosYProfesoresAPI.Models;
using RegistroAlumnosYProfesoresAPI.Services;

namespace RegistroAlumnosYProfesoresAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProfesoresController : ControllerBase
    {
        private readonly ProfesorService profesorService;

        public ProfesoresController(ProfesorService profesorService)
        {
            this.profesorService = profesorService;
        }

        [Route("")]
        public IActionResult GetProfesores()
        {
            return Content(JsonSerializer.Serialize(profesorService.GetProfesores()), "text/json");
        }

        [Route("{id}")]
        public IActionResult GetProfesor(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesor = profesorService.GetProfesor(id);

            if (profesor == null)
            {
                return NotFound();
            }

            return Content(JsonSerializer.Serialize(profesor));
        }

        [Route("Create")]
        public IActionResult CreateProfesor(ProfesorModel profesor)
        {
            profesorService.AddProfesor(profesor);

            return NoContent();
        }
    }
}