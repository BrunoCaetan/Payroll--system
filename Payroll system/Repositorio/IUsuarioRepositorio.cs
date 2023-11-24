using Payroll_system.Models;

namespace Payroll_system.Repositorio
{
    public interface IUsuarioRepositorio
    {
        List<UsuarioModel> BuscarTodos();
        UsuarioModel BuscarPorID(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
