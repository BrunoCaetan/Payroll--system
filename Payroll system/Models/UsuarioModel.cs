using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using Payroll_system.Enums;

namespace Payroll_system.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login {  get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
