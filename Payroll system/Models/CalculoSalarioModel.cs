namespace Payroll_system.Models
{
    public class CalculoSalarioModel
    {
        public string HorasTrabalhadas { get; set; }
        public double AtrasosEFaltas { get; set; }
        public double SalarioBruto { get; set; }
        public double SalarioLiquido { get; set; }
        public double TaxasDePagamento { get; set; }
        public double ImpostoDeRenda { get; set; }
        public double Inss {  get; set; }
        public double HorasExtras { get; set; }
        public double AdicionalNoturno { get; set; }
        public double AdicionalPericulosidade { get; set; }
        public double AdicionalInsalubridade { get; set; }
        public double Fgts { get; set; }

    }
}
