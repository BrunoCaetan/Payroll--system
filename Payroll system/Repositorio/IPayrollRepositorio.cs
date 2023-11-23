using Payroll_system.Models;

namespace Payroll_system.Repositorio
{
    public interface IPayrollRepositorio
    {
        EmpresaModel Adicionar(EmpresaModel payroll);
    }
}
