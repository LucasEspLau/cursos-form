using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using curso_form.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace curso_form.Controllers
{
    public class CursoController : Controller
    {
        private readonly ILogger<CursoController> _logger;

        public CursoController(ILogger<CursoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Nombre,Categoria,Creditos,Remoto,Material,Videos,HoraInicio,HoraFin")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                // Aquí podrías agregar la lógica para guardar el curso en la base de datos u otro procesamiento necesario.
                // Por ejemplo, podrías llamar a un servicio o repositorio para guardar el curso.

                ViewData["Message"] = "El curso se ha registrado exitosamente.\nCurso: " +
                curso.Nombre + " con un costo total del " + curso.Creditos * 100 + " soles.";
                
                // Redirigir al Index del HomeController
                return View("Index", curso);
            }

            // Si el modelo no es válido, regresa a la vista Index con los errores de validación.
            return View("Index", curso);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
