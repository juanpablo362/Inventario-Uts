using Microsoft.AspNetCore.Mvc;

namespace listar_guardar.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }

    }
}
