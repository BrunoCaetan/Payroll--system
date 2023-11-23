﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Payroll_system.Data;

#nullable disable

namespace Payroll_system.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20231123185024_Initial-criacao")]
    partial class Initialcriacao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Payroll_system.Models.EmpresaModel", b =>
                {
                    b.Property<string>("NomeDaEmpresa")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("NomeEmpresa");

                    b.Property<int>("Cnpj")
                        .HasColumnType("int")
                        .HasColumnName("Cnpj");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Endereco");

                    b.Property<int>("InscricaoEstadual")
                        .HasColumnType("int")
                        .HasColumnName("InscricaoEstadual");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RazaoSocial");

                    b.Property<int>("Telefone")
                        .HasColumnType("int")
                        .HasColumnName("Telefone");

                    b.HasKey("NomeDaEmpresa");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Payroll_system.Models.FeriasModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DataFerias")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ferias");
                });

            modelBuilder.Entity("Payroll_system.Models.FuncionarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Agencia")
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Conta")
                        .HasColumnType("int");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataDeAdmissão")
                        .HasColumnType("int");

                    b.Property<int>("DataDeNascimento")
                        .HasColumnType("int");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorasTrabalhadas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDoBanco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<int>("Pis")
                        .HasColumnType("int");

                    b.Property<int>("Rg")
                        .HasColumnType("int");

                    b.Property<double>("SalarioContratual")
                        .HasColumnType("float");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.Property<string>("TipoDeConta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Payroll_system.Models.HoleriteModel", b =>
                {
                    b.Property<string>("HorasTrabalhadas")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("AdicionalInsalubridade")
                        .HasColumnType("float");

                    b.Property<double>("AdicionalNoturno")
                        .HasColumnType("float");

                    b.Property<double>("AdicionalPericulosidade")
                        .HasColumnType("float");

                    b.Property<double>("AtrasosEFaltas")
                        .HasColumnType("float");

                    b.Property<double>("Fgts")
                        .HasColumnType("float");

                    b.Property<double>("HorasExtras")
                        .HasColumnType("float");

                    b.Property<double>("ImpostoDeRenda")
                        .HasColumnType("float");

                    b.Property<double>("Inss")
                        .HasColumnType("float");

                    b.Property<double>("SalarioBruto")
                        .HasColumnType("float");

                    b.Property<double>("SalarioLiquido")
                        .HasColumnType("float");

                    b.Property<double>("TaxasDePagamento")
                        .HasColumnType("float");

                    b.HasKey("HorasTrabalhadas");

                    b.ToTable("Salario");
                });

            modelBuilder.Entity("Payroll_system.Models.LicencasModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DataLicenca")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("licenca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Licencas");
                });

            modelBuilder.Entity("Payroll_system.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
