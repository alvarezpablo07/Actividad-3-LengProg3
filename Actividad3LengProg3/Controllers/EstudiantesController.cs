using Actividad3LengProg3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad3LengProg3.Controllers
{
    public class EstudiantesController : Controller
    {
        private static List<EstudianteViewModel> estudiantes = new List<EstudianteViewModel>();

        public ActionResult Index()
        {
            return View(new EstudianteViewModel());
        }

        [HttpPost]
        public ActionResult Registrar(EstudianteViewModel estudiante)
        {
            if (ModelState.IsValid)
            {
                estudiantes.Add(estudiante);
                return RedirectToAction("Lista");
            }
            return View("Index", estudiante);
        }

        public ActionResult Lista()
        {
            return View(estudiantes);
        }

        public ActionResult Editar(string matricula)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matricula == matricula);
            return View(estudiante);
        }

        [HttpPost]
        public ActionResult Editar(EstudianteViewModel estudiante)
        {
            var index = estudiantes.FindIndex(e => e.Matricula == estudiante.Matricula);
            if (index >= 0 && ModelState.IsValid)
            {
                estudiantes[index] = estudiante;
                return RedirectToAction("Lista");
            }
            return View(estudiante);
        }

        public ActionResult Eliminar(string matricula)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matricula == matricula);
            if (estudiante != null)
            {
                estudiantes.Remove(estudiante);
            }
            return RedirectToAction("Lista");
        }
    }
}
