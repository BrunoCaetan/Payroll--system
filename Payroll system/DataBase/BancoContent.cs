using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll_system.Data
{
    public class BancoContent : DbContext
    {
        public BancoContent(DbContextoptions<BancoContent> options) : base(options) 
        { 
        }
        public DbSet<UsuarioFuncionario> Funcionario { get; set; }
    
    }
}
