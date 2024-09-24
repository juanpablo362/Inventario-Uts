using listar_guardar.Datos;
using Microsoft.AspNetCore.Mvc;

namespace listar_guardar.Controllers
{
    public class EquiposController : Controller
    {
        equipos _equipos = new equipos();


        /*
            public EquiposController(IRepositorioEquipos repositorioEquipos)
            {
                _repositorioEquipos = repositorioEquipos;
            }
        */

        public IActionResult Listar()
        {
            var olista = _equipos.ListarEquipos();
            return View(olista);
        }

        public IActionResult Microsoft()
        {
            var olista = _equipos.ListarEquipos();
            return View(olista);
        }

        public IActionResult CDS()
        {
            var olista = _equipos.ListarEquipos();
            return View(olista);
        }

        public IActionResult Lab1101()
        {
            var olista = _equipos.ListarEquipos();
            return View(olista);
        }
        /*
            public IActionResult Index()
            {
                var equipos = _repositorioEquipos.ObtenerTodos();
                return View(equipos);
            }

            public IActionResult Details(int id)
            {
                var equipo = _repositorioEquipos.ObtenerPorId(id);
                return View(equipo);
            }
        */


    }
}