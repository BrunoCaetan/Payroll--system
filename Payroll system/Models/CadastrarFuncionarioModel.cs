using Payroll_system.Enums;

namespace Payroll_system.Models
{
    public class CadastrarFuncionarioModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login {  get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int Cpf {  get; set; }
        public int DataDeNascimento{ get; set; }
        public int Rg { get; set; }
        public string EstadoCivil { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public int Pis { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public double SalarioContratual { get; set; }
        public int DataDeAdmissão { get; set; }
        public string Nacionalidade { get; set; }
        public string Sexo { get; set; }
        public string HorasTrabalhadas { get; set; }
        public string NomeDoBanco { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public string TipoDeConta { get; set; }
        public PerfilEnum Perfil { get; set; }
        public DateTime? DataAtualizacao { get; set; }

    }
}
