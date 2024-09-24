using listar_guardar.Datos;
using listar_guardar.Models;
using Microsoft.AspNetCore.Mvc;

namespace listar_guardar.Controllers
{
    public class ReporteController : Controller
    {
        reporetedatos _reporetedatos = new reporetedatos();
        public IActionResult reporte()
        {
            var olista = _reporetedatos.Listar();
            return View(olista);
        }
        public IActionResult Guardar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Guardar(reportes oreportes)
        {
            /*
            if (!ModelState.IsValid)
                return View();
            */

            var respuesta = _reporetedatos.Guardar(oreportes);

            if (respuesta)
                return RedirectToAction("Listar", "Equipos");
            else
                return View(oreportes);

        }

    }
}
