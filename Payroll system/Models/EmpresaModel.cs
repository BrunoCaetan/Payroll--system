using Microsoft.EntityFrameworkCore;
using Payroll_system.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_system.Models
{
    
    public class EmpresaModel

    {
        [Key]
        [Column("NomeEmpresa")]
        [Display(Name = "Nome")]
        public string NomeDaEmpresa { get; set; }

        [Column("Cnpj")]
        [Display(Name = "Cnpj")]
        public int Cnpj { get; set; }

        [Column("RazaoSocial")]
        [Display(Name = "RazaoSocial")]
        public string RazaoSocial { get; set; }

        [Column("InscricaoEstadual")]
        [Display(Name = "InscricaoEstadual")]
        public int InscricaoEstadual { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public int Telefone { get; set; }

        [Column("Endereco")]
        [Display(Name = "Endereco")]
        public string Endereco { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
