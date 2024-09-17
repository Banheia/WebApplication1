using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Repositorio.Interface;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public IActionResult Index()
        {
            var aluno = _alunoRepositorio.BuscarAluno();

            return View(aluno);
        }
        public IActionResult AdicionarAluno()
        {

            return View();
        }

        public IActionResult InserirAluno(Aluno aluno)
        {
            try
            {
                _alunoRepositorio.InserirAluno(aluno);
            }
            catch(Exception) 
            { 
                throw;
            }
            return  RedirectToAction("Index");
        }
        public IActionResult Editar(int Id) 
        {
            var aluno = _alunoRepositorio.BuscarID(Id);
            return  View(aluno);
        }
        public IActionResult EditarAluno(Aluno aluno)
        {
                _alunoRepositorio.EditarAluno(aluno);
                return RedirectToAction("Index");
        }
        public IActionResult RemoverAluno(Aluno aluno) 
        {
            _alunoRepositorio.RemoverAluno(aluno);
            return RedirectToAction("Index");
        }
    }
}
