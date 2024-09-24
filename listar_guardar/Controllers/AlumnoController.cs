using listar_guardar.Datos;
using listar_guardar.Models;
using Microsoft.AspNetCore.Mvc;

namespace listar_guardar.Controllers
{
    public class AlumnoController : Controller
    {
        laboratorioDatos _laboratorioDatos = new laboratorioDatos();
        public IActionResult Listar()
        {
            var olista = _laboratorioDatos.Listar();
            return View(olista);
        }
        public IActionResult Microsoft()
        {
            var olista = _laboratorioDatos.Listar();
            return View(olista);
        }
        public IActionResult CDS()
        {
            var olista = _laboratorioDatos.Listar();
            return View(olista);
        }
        public IActionResult Lab1101()
        {
            var olista = _laboratorioDatos.Listar();
            return View(olista);
        }

        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(conexcion oalumno)
        {
            if (!ModelState.IsValid)
                return View();

            var respuesta = _laboratorioDatos.Guardar(oalumno);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
        public IActionResult Editar(int idEquipo)
        {
            var oalumno = _laboratorioDatos.obtener(idEquipo);
            return View(oalumno);
        }
        [HttpPost]
        public IActionResult Editar(conexcion oalumno)
        {
            if (!ModelState.IsValid)
                return View();

            var respuesta = _laboratorioDatos.Editar(oalumno);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
        public IActionResult Eliminar(int idEquipo)
        {
            var oalumno = _laboratorioDatos.obtener(idEquipo);
            return View(oalumno);
        }
        [HttpPost]
        public IActionResult Eliminar(conexcion oalumno)
        {

            var respuesta = _laboratorioDatos.Eliminar(oalumno.idEquipo);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

    }
}
