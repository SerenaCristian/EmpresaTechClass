using EmpresaTechClass;

string sep = new string('-', 50);
Console.WriteLine("Sistema Empresa Tech Class");
Console.WriteLine(sep);

const int maxFuncionarios = 10;
Funcionario[] funcionarios = new Funcionario[maxFuncionarios]; 

Console.Write("Quantos funcionários deseja incluir (máximo 10)?: ");
int numFuncionarios = int.Parse(Console.ReadLine());

if (numFuncionarios > maxFuncionarios)
{
    Console.WriteLine("Você só pode adicionar até 10 funcionários.");
    
}
Console.WriteLine(sep);
for (int i = 0; i < numFuncionarios; i++)
{
    Console.WriteLine($"Funcionário #{i + 1}:");
   

    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Horas Trabalhadas: ");
    double horasTrabalhadas = double.Parse(Console.ReadLine());

    Console.Write("Valor por Hora: ");
    double valorPorHora = double.Parse(Console.ReadLine());

    Console.Write("O funcionário é terceirizado? (s/n): ");
    string terceirizado = Console.ReadLine().ToLower();

    if (terceirizado == "s")
    {
        Console.Write("Despesa Adicional: ");
        double despesaAdicional = double.Parse(Console.ReadLine());

        funcionarios[i] = new FuncionarioTerceirizado(nome, horasTrabalhadas, valorPorHora, despesaAdicional);
    }
    else
    {
        funcionarios[i] = new Funcionario(nome, horasTrabalhadas, valorPorHora);
    }
}

Console.WriteLine(sep);

Console.WriteLine("Pagamentos: ");
for (int i = 0; i < numFuncionarios; i++)
{
    Console.WriteLine($"{funcionarios[i].Nome}: R${funcionarios[i].Pagamento():F2}");
}


Console.WriteLine(sep);
