using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

class Aula10
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido;
        public void AumentoSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100.0;
            SalarioLiquido = SalarioBruto - (SalarioBruto * Imposto / 100.0);
        }
        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
            SalarioLiquido = salarioBruto - (salarioBruto * imposto / 100.0);
        }
    }
    static void Main()
    {
        var (nome, salarioBruto, imposto) = CriarFuncionario();
        Funcionario func = new(nome, salarioBruto, imposto);

        Console.WriteLine($"- Funcionário: {func.Nome}, ${func.SalarioLiquido.ToString("F2")}");

        Console.WriteLine("- Você deseja aumentar o salário do funcionário? (s/n)");
        string resposta = Console.ReadLine() ?? "n";
        if (resposta.ToLower() == "s")
        {
            AumentarSalario(func);
        }
        else
        {
            Console.WriteLine("- Nenhum aumento aplicado.");
        }
    }

    static void AumentarSalario(Funcionario func)
    {
        Console.WriteLine("- Digite a porcentagem para aumentar o salário:");
        double porcentagem = double.Parse(Console.ReadLine() ?? "0");
        func.AumentoSalario(porcentagem);
        Console.WriteLine($"- Dados atualizados: {func.Nome}, ${func.SalarioLiquido.ToString("F2")}");
        return;
    }
    static (string, double, double) CriarFuncionario()
    {
        Console.WriteLine("- Entre com o nome do funcionário:");
        string nome = Console.ReadLine() ?? "";
        Console.WriteLine("- Entre com o salário bruto do funcionário:");
        double salarioBruto = double.Parse(Console.ReadLine());
        double imposto;
        if (salarioBruto < 2000)
        {
            imposto = 10.0;
        }
        else if (salarioBruto >= 2000 && salarioBruto < 3000)
        {
            imposto = 20.0;
        }
        else
        {
            imposto = 30.0;
        }
        Console.WriteLine($"- Ele será taxado em {imposto}% de imposto.");
        return (nome, salarioBruto, imposto);
    }
}