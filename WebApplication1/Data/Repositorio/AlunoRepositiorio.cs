
using WebApplication1.Data.Repositorio.Interface;
using WebApplication1.Models;

namespace WebApplication1.Data.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Aluno> BuscarAluno()
        {
            return _bancoContexto.aluno.ToList();
        }
        public void InserirAluno(Aluno aluno) 
        {
            _bancoContexto.aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }
        public Aluno BuscarID(int id) 
        {
            return _bancoContexto.aluno.FirstOrDefault(x => x.Id == id);
        }
        public void EditarAluno(Aluno aluno) 
        {
            _bancoContexto.aluno.Update(aluno);
            _bancoContexto.SaveChanges();
        }
        public void RemoverAluno(Aluno aluno) 
        {
            _bancoContexto.aluno.Remove(aluno);
            _bancoContexto.SaveChanges();
        }
    }
}
