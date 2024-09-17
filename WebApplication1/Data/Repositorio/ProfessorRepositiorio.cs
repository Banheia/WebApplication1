
using WebApplication1.Data.Repositorio.Interface;
using WebApplication1.Models;

namespace WebApplication1.Data.Repositorio
{
    public class ProfessorRepositorio : IProfessorRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public ProfessorRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Professor> BuscarProfessor()
        {
            return _bancoContexto.Professor.ToList();
        }
        public void InserirProfessor(Professor aluno) 
        {
            _bancoContexto.Professor.Add(aluno);
            _bancoContexto.SaveChanges();
        }
        public Professor BuscarID(int id) 
        {
            return _bancoContexto.Professor.FirstOrDefault(x => x.Id == id);
        }
        public void EditarProfessor(Professor aluno) 
        {
            _bancoContexto.Professor.Update(aluno);
            _bancoContexto.SaveChanges();
        }
        public void RemoverProfessor(Professor aluno) 
        {
            _bancoContexto.Professor.Remove(aluno);
            _bancoContexto.SaveChanges();
        }
    }
}
