using Microsoft.AspNetCore.Mvc;
using Payroll_system.Models;
using System.Collections.Generic;
using System.Linq;

namespace Payroll_system.Controllers
{
    public class HoleriteController : Controller
    {
        // Método fictício para obter funcionários do banco de dados
        private IEnumerable<FuncionarioModel> ObterFuncionariosDoBancoDeDados()
        {
            // Lógica para obter funcionários do banco de dados
            // Substitua isso pela lógica real de consulta ao banco de dados
            return new List<FuncionarioModel>
            {
                new FuncionarioModel { Id = 1, Name = "João", Email = "joao@email.com", Cargo = "Desenvolvedor", Departamento = "TI", SalarioBruto = 1200.00, HorasTrabalhadas = "40" },
                new FuncionarioModel { Id = 2, Name = "Maria", Email = "maria@email.com", Cargo = "Analista", Departamento = "Financeiro", SalarioBruto = 2300.00, HorasTrabalhadas = "38" },
                new FuncionarioModel { Id = 3, Name = "Pedro", Email = "pedro@email.com", Cargo = "Gerente", Departamento = "RH", SalarioBruto = 3500.00, HorasTrabalhadas = "40" },
                new FuncionarioModel { Id = 4, Name = "Ana", Email = "ana@email.com", Cargo = "Coordenador", Departamento = "Operações", SalarioBruto = 4900.00, HorasTrabalhadas = "42" },
                new FuncionarioModel { Id = 5, Name = "Carlos", Email = "carlos@email.com", Cargo = "Diretor", Departamento = "Executivo", SalarioBruto = 6000.00, HorasTrabalhadas = "40" }
            };
        }

        public IActionResult Index()
        {
            // Obtém dados do modelo (pode vir do banco de dados, por exemplo)
            var funcionarios = ObterFuncionariosDoBancoDeDados();

            // Passa os dados para a view
            return View(funcionarios);
        }

        [HttpGet]
        public IActionResult GerarHolerite(int id)
        {
            // Lógica para gerar o holerite e calcular os valores
            var funcionario = ObterFuncionariosDoBancoDeDados().FirstOrDefault(f => f.Id == id);

            if (funcionario == null)
            {
                // Retorne uma mensagem de erro ou redirecione para uma página de erro
                return RedirectToAction("Index");
            }

            var holerite = CalcularValores(funcionario);

            // Exemplo de notificação
            ViewBag.Notificacao = "Holerite gerado com sucesso!";

            // Pergunta sobre o envio por e-mail
            ViewBag.PerguntaEmail = "Deseja enviar o holerite por e-mail?";

            return View(holerite);
        }

        // ... Métodos de cálculo aqui ...
        private double CalcularSalarioLiquido(double salarioBruto)
        {
            // Lógica para calcular o salário líquido
            // Substitua isso pela lógica real
            return salarioBruto - CalcularInss(salarioBruto) - CalcularImpostoDeRenda(salarioBruto);
        }

        private double CalcularTaxasDePagamento(double salarioBruto)
        {
            // Lógica para calcular as taxas de pagamento
            // Substitua isso pela lógica real
            return salarioBruto * 0.1; // Exemplo: 10% do salário bruto
        }

        private double CalcularAdicionalPericulosidade(double salarioBruto)
        {
            // Lógica para calcular adicional de periculosidade
            // Substitua isso pela lógica real
            return salarioBruto * 0.05; // Exemplo: 5% do salário bruto
        }

        private double CalcularAdicionalInsalubridade(double salarioBruto)
        {
            // Lógica para calcular adicional de insalubridade
            // Substitua isso pela lógica real
            return salarioBruto * 0.1; // Exemplo: 10% do salário bruto
        }

        private double CalcularFgts(double salarioBruto)
        {
            // Lógica para calcular FGTS
            // Substitua isso pela lógica real
            return salarioBruto * 0.08; // Exemplo: 8% do salário bruto
        }

        private double CalcularInss(double salarioBruto)
        {
            // Lógica para calcular INSS com exceções
            // Substitua isso pela lógica real

            if (salarioBruto <= 1302.00)
            {
                return salarioBruto * 0.075;
            }
            else if (salarioBruto <= 2571.29)
            {
                return salarioBruto * 0.09;
            }
            else if (salarioBruto <= 3856.94)
            {
                return salarioBruto * 0.12;
            }
            else if (salarioBruto <= 7507.29)
            {
                return salarioBruto * 0.14;
            }
            else
            {
                return 7507.29 * 0.14;
            }
        }

        private double CalcularImpostoDeRenda(double salarioBruto)
        {
            // Lógica para calcular Imposto de Renda com exceções
            // Substitua isso pela lógica real

            // Exemplo simplificado: Dedução fixa de 5%
            double deducao = salarioBruto * 0.05;

            if (salarioBruto <= 2826.65)
            {
                return salarioBruto * 0.075 - deducao;
            }
            else if (salarioBruto <= 3751.05)
            {
                return salarioBruto * 0.15 - deducao;
            }
            else if (salarioBruto <= 4664.68)
            {
                return salarioBruto * 0.225 - deducao;
            }
            else
            {
                return salarioBruto * 0.275 - deducao;
            }
        }
        private HoleriteModel CalcularValores(FuncionarioModel funcionario)
        {
            var holerite = new HoleriteModel
            {
                // Valores fictícios, substitua pelos valores reais
                HorasTrabalhadas = funcionario.HorasTrabalhadas,
                AtrasosEFaltas = 0,
                SalarioBruto = funcionario.SalarioBruto
            };

            // Lógica para calcular outros valores
            holerite.SalarioLiquido = CalcularSalarioLiquido(holerite.SalarioBruto);
            holerite.TaxasDePagamento = CalcularTaxasDePagamento(holerite.SalarioBruto);
            holerite.AdicionalPericulosidade = CalcularAdicionalPericulosidade(holerite.SalarioBruto);
            holerite.AdicionalInsalubridade = CalcularAdicionalInsalubridade(holerite.SalarioBruto);
            holerite.Fgts = CalcularFgts(holerite.SalarioBruto);

            // Calcular INSS e Imposto de Renda com as exceções especificadas
            holerite.Inss = CalcularInss(holerite.SalarioBruto);
            holerite.ImpostoDeRenda = CalcularImpostoDeRenda(holerite.SalarioBruto);

            return holerite;
        }

        // ... Métodos de cálculo aqui ...

        public IActionResult EscolherSalario()
        {
            // Salários predefinidos
            var salarios = new List<double> { 1200.00, 2300.00, 3500.00, 4900.00, 6000.00 };

            ViewBag.Salarios = salarios;

            return View();
        }

        [HttpPost]
        public IActionResult EscolherSalario(int id)
        {
            // Redireciona para a ação de gerar holerite com o ID do funcionário
            return RedirectToAction("GerarHolerite", new { id = id });
        }

    
       
            // ... outros métodos

            [HttpPost]
            public IActionResult HoleriteEnviadoComSucesso()
            {
                // Página com a mensagem "Holerite enviado com sucesso"
                ViewBag.MensagemSucesso = "Holerite enviado com sucesso";
                return View();
            }
        }
    }


