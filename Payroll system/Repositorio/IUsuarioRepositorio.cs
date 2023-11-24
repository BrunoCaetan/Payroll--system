using Payroll_system.Models;

namespace Payroll_system.Repositorio
{
    public interface IUsuarioRepositorio
    {
      
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
