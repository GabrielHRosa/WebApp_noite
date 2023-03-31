using Microsoft.AspNetCore.Mvc;

namespace WebApp_noite.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
