using WebApplication1.Models;

namespace WebApplication1.Data.Repositorio.Interface
{
    public interface ILoginRepositorio
    {
        public Admin CheckLogin(string usuario,string senha);
    }
}
