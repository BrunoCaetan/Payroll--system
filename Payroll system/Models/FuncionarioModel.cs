using Payroll_system.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_system.Models
{
    public class FuncionarioModel
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Login")]
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        [EmailAddress(ErrorMessage = "Email valido!")]

        [Column("Cpf")]
        [Display(Name = "Cpf")]
        public int Cpf { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("DataDeNascimento")]
        [Display(Name = "DataDeNascimento")]
        public int DataDeNascimento { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Rg")]
        [Display(Name = "Rg")]
        public int Rg { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("EstadoCivil")]
        [Display(Name = "EstadoCivil")]
        public string EstadoCivil { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Endereco")]
        [Display(Name = "Endereco")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public int Telefone { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]
        [Phone(ErrorMessage = "Numero invalido!")]

        [Column("Pis")]
        [Display(Name = "Pis")]
        public int Pis { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Cargo")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Departamento")]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("SalarioContratual")]
        [Display(Name = "SalarioContratual")]
        public double SalarioContratual { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("DataDeAdmissão")]
        [Display(Name = "DataDeAdmissão")]
        public int DataDeAdmissão { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Nacionalidade")]
        [Display(Name = "Nacionalidade")]
        public string Nacionalidade { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("HorasTrabalhadas")]
        [Display(Name = "HorasTrabalhadas")]
        public string HorasTrabalhadas { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("NomeDoBanco")]
        [Display(Name = "NomeDoBanco")]
        public string NomeDoBanco { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Agencia")]
        [Display(Name = "Agencia")]
        public int Agencia { get; set; }
        [Required(ErrorMessage = "Preecha o campo")]

        [Column("Conta")]
        [Display(Name = "Conta")]
        public int Conta { get; set; }

        [Column("TipoDeConta")]
        [Display(Name = "TipoDeConta")]
        public string TipoDeConta { get; set; }

        [Column("Perfil")]
        [Display(Name = "Perfil")]
        public PerfilEnum Perfil { get; set; }

        [Column("DataAtualizacao")]
        [Display(Name = "DataAtualizacao")]
        public DateTime? DataAtualizacao { get; set; }
    
    }
}
