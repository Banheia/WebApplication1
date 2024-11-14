
using WebApplication1.Data.Repositorio.Interface;
using WebApplication1.Models;

namespace WebApplication1.Data.Repositorio
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public LoginRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public Admin CheckLogin(string usuario,string senha) 
        {
            return _bancoContexto.Admin.FirstOrDefault(x=> x.Usuario == usuario  && x.Senha == senha);
        }
    }
}
