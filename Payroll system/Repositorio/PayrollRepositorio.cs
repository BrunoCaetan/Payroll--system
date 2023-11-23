using Payroll_system.Data;
using Payroll_system.Models;

namespace Payroll_system.Repositorio
{
    public class PayrollRepositorio : IPayrollRepositorio
    {
        private readonly BancoContext _bancoContext;
        public PayrollRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public EmpresaModel Adicionar(EmpresaModel payroll)
        {
            _bancoContext.Empresa.Add(payroll);
            _bancoContext.SaveChanges();
            return payroll;
        }
    }
}
