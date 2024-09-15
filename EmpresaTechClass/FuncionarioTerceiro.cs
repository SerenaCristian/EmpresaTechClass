using System;

namespace EmpresaTechClass
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }


        public FuncionarioTerceirizado(string nome, double horasTrabalhadas, double valorPorHora, double despesaAdicional) : base(nome, horasTrabalhadas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento() => base.Pagamento() + 1.1 * DespesaAdicional;
       
    }
}