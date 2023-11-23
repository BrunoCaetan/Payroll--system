using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Payroll_system.Migrations
{
    /// <inheritdoc />
    public partial class Initialcriacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    NomeEmpresa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cnpj = table.Column<int>(type: "int", nullable: false),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InscricaoEstadual = table.Column<int>(type: "int", nullable: false),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.NomeEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "ferias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFerias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ferias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Licencas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    licenca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataLicenca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licencas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salario",
                columns: table => new
                {
                    HorasTrabalhadas = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AtrasosEFaltas = table.Column<double>(type: "float", nullable: false),
                    SalarioBruto = table.Column<double>(type: "float", nullable: false),
                    SalarioLiquido = table.Column<double>(type: "float", nullable: false),
                    TaxasDePagamento = table.Column<double>(type: "float", nullable: false),
                    ImpostoDeRenda = table.Column<double>(type: "float", nullable: false),
                    Inss = table.Column<double>(type: "float", nullable: false),
                    HorasExtras = table.Column<double>(type: "float", nullable: false),
                    AdicionalNoturno = table.Column<double>(type: "float", nullable: false),
                    AdicionalPericulosidade = table.Column<double>(type: "float", nullable: false),
                    AdicionalInsalubridade = table.Column<double>(type: "float", nullable: false),
                    Fgts = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salario", x => x.HorasTrabalhadas);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "ferias");

            migrationBuilder.DropTable(
                name: "Licencas");

            migrationBuilder.DropTable(
                name: "Salario");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
