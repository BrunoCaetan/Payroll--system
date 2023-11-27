using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_system.Models
{
    public class FuncionarioModel
    {

        [Column("Id")]
        [Display(Name = "Id")]
        [Required(ErrorMessage = "Preecha o campo")]
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string Name { get; set; }

        [Column("Login")]
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string Login { get; set; }

        [Column("Senha")]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string Senha { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Preecha o campo")]
        [EmailAddress(ErrorMessage = "Email valido!")]
        public string Email { get; set; }

        [Column("Cpf")]
        [Display(Name = "Cpf")]
        [Required(ErrorMessage = "Preecha o campo")]
        public int Cpf { get; set; }

        [Column("DataDeNascimento")]
        [Display(Name = "DataDeNascimento")]
        [Required(ErrorMessage = "Preecha o campo")]
        public int DataDeNascimento { get; set; }

        [Column("Rg")]
        [Display(Name = "Rg")]
        [Required(ErrorMessage = "Preecha o campo")]
        public int Rg { get; set; }

        [Column("EstadoCivil")]
        [Display(Name = "EstadoCivil")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string EstadoCivil { get; set; }

        [Column("Endereco")]
        [Display(Name = "Endereco")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string Endereco { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Preecha o campo")]
        [Phone(ErrorMessage = "Numero invalido!")]
        public int Telefone { get; set; }
        
        [Column("Pis")]
        [Display(Name = "Pis")]
        [Required(ErrorMessage = "Preecha o campo")]
        public int Pis { get; set; }

        [Column("Cargo")]
        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string Cargo { get; set; }

        [Column("Departamento")]
        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string Departamento { get; set; }

        [Column("SalarioContratual")]
        [Display(Name = "SalarioContratual")]
        [Required(ErrorMessage = "Preecha o campo")]
        public double SalarioBruto { get; set; }

        [Column("DataDeAdmissão")]
        [Display(Name = "DataDeAdmissão")]
        [Required(ErrorMessage = "Preecha o campo")]
        public int DataDeAdmissão { get; set; }

        [Column("Nacionalidade")]
        [Display(Name = "Nacionalidade")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string Nacionalidade { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string Sexo { get; set; }

        [Column("HorasTrabalhadas")]
        [Display(Name = "HorasTrabalhadas")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string HorasTrabalhadas { get; set; }

        [Column("NomeDoBanco")]
        [Display(Name = "NomeDoBanco")]
        [Required(ErrorMessage = "Preecha o campo")]
        public string NomeDoBanco { get; set; }

        [Column("Agencia")]
        [Display(Name = "Agencia")]
        [Required(ErrorMessage = "Preecha o campo")]
        public int Agencia { get; set; }

        [Column("Conta")]
        [Display(Name = "Conta")]
        public int Conta { get; set; }

        [Column("TipoDeConta")]
        [Display(Name = "TipoDeConta")]
        public string TipoDeConta { get; set; }

        [Column("DataAtualizacao")]
        [Display(Name = "DataAtualizacao")]
        public DateTime? DataAtualizacao { get; set; }

    }
}
