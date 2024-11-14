using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data.Repositorio.Interface;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILoginRepositorio _LoginRepositorio;
        public HomeController(ILogger<HomeController> logger, ILoginRepositorio LoginRepositorio)
        {
            _logger = logger;
            _LoginRepositorio = LoginRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login() 
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CheckLogin(Admin admin)
        {
            if (_LoginRepositorio.CheckLogin(admin.Usuario,admin.Senha) != null) {
            return RedirectToAction("Index"); }
            return RedirectToAction("Login");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}