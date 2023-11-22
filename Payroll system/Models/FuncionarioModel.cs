using Payroll_system.Enums;
using System.ComponentModel.DataAnnotations;

namespace Payroll_system.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        [EmailAddress(ErrorMessage = "Email valido!")]
        public int Cpf { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public int DataDeNascimento { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public int Rg { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string EstadoCivil { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public int Telefone { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        [Phone(ErrorMessage = "Numero invalido!")]
        public int Pis { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string Departamento { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public double SalarioContratual { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public int DataDeAdmissão { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string Nacionalidade { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string HorasTrabalhadas { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public string NomeDoBanco { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public int Agencia { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        public int Conta { get; set; }
        public string TipoDeConta { get; set; }
        public PerfilEnum Perfil { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    
    }
}
