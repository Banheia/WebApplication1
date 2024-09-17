using WebApplication1.Models;

namespace WebApplication1.Data.Repositorio.Interface
{
    public interface IProfessorRepositorio
    {
        List<Professor> BuscarProfessor();
        void InserirProfessor(Professor professor);
        Professor BuscarID(int id);
        void EditarProfessor(Professor professor);
        void RemoverProfessor(Professor professor);
    }
}
