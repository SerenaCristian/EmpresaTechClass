using System;


namespace EmpresaTechClass
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double HorasTrabalhadas { get; set; }
        public double ValorHorasTrabalhas { get; set; }

        public Funcionario(string nome, double horas, double horasTrabalhadas)
        {
            Nome = nome;
            HorasTrabalhadas = horas;
            ValorHorasTrabalhas = horasTrabalhadas;
        }


        public virtual double Pagamento() => HorasTrabalhadas * ValorHorasTrabalhas;

    }
}
