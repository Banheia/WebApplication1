using WebApplication1.Models;

namespace WebApplication1.Data.Repositorio.Interface
{
    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAluno();
        void InserirAluno(Aluno aluno);
        Aluno BuscarID(int id);
        void EditarAluno(Aluno aluno);
        void RemoverAluno(Aluno aluno);
    }
}
