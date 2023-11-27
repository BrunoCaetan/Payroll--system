using Microsoft.EntityFrameworkCore;
using Payroll_system.Models;

namespace Payroll_system.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        { 
        }
        public DbSet<FuncionarioModel> Funcionario { get; set; }
        public DbSet<LicencasModel> Licencas { get; set; }
        public DbSet<EmpresaModel> Empresa { get; set; }
        public DbSet<HoleriteModel> Salario { get; set; }
        public DbSet<FeriasModel> ferias { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}

