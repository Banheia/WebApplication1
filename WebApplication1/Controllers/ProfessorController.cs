using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Repositorio.Interface;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepositorio _professorRepositorio;
        public ProfessorController(IProfessorRepositorio professorRepositorio)
        {
            _professorRepositorio = professorRepositorio;
        }

        public IActionResult Index()
        {
            var professor = _professorRepositorio.BuscarProfessor();

            return View(professor);
        }
        public IActionResult AdicionarProfessor()
        {

            return View();
        }

        public IActionResult InserirProfessor(Professor professor)
        {
            try
            {
                _professorRepositorio.InserirProfessor(professor);
            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Editar(int Id)
        {
            var professor = _professorRepositorio.BuscarID(Id);
            return View(professor);
        }
        public IActionResult EditarProfessor(Professor professor)
        {
            _professorRepositorio.EditarProfessor(professor);
            return RedirectToAction("Index");
        }
        public IActionResult RemoverProfessor(Professor professor)
        {
            _professorRepositorio.RemoverProfessor(professor);
            return RedirectToAction("Index");
        }
    }
}
