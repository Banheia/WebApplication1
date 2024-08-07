using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class alunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
