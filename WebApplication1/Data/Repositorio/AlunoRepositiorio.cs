
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
            return _bancoContexto.Aluno.ToList();
        }
    }
}
