using Microsoft.EntityFrameworkCore;
using Payroll_system.Models;

namespace Payroll_system.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        { 
        }
        public DbSet<CadastrarFuncionarioModel> Funcionario { get; set; }
     
    
    }
}
//   public DbSet<AdministrarLicençasModel> Licenças {  get; set; }public DbSet<CadastrarEmpresaModel> Empresa { get; set; }public DbSet<CalcularBeneficiosModel> Beneficios { get; set; }public DbSet<CalculoSalarioModel> Salario { get; set; }public DbSet<FeriasModel> ferias { get; set; }