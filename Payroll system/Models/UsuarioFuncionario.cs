using Payroll_system.Enums;

namespace Payroll_system.Models
{
    public class UsuarioFuncionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login {  get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int Cpf {  get; set; }
        public int Data_de_nascimento{ get; set; }
        public int Rg { get; set; }
        public string Estado_Civil { get; set; }
        public string Endereço { get; set; }
        public int Telefone { get; set; }
        public int Pis { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public double Salario_contratual { get; set; }
        public int Data_de_admissão { get; set; }
        public string Nacionalidade { get; set; }
        public string Sexo { get; set; }
        public string Horas_trabalhadas { get; set; }
        public PerfilEnum Perfil { get; set; }
        public DateTime? DataAtualizacao { get; set; }

    }
}
