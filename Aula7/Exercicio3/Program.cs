using System;
using System.Reflection;

class Projeto
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Esse é um programa que armazena a distância entre as seguintes cidades:");
        Console.WriteLine("- Vitória");
        Console.WriteLine("- Belo Horizonte");
        Console.WriteLine("- Rio de Janeiro");
        Console.WriteLine("- São Paulo");
        Console.WriteLine("Deseja verificar a distância entre alguma delas? (1 - Sim, 2 - Não)");
        int init = Convert.ToInt32(Console.ReadLine());
        switch (init)
        {
            case 1:
                break;
            case 2:
                break;
            default:
                break;
        }
    }
    public void Distancia()
    {
        Console.WriteLine("Entre com o nome da primeira cidade:");
        string cidade1 = Console.ReadLine();
        Console.WriteLine("Entre com o nome da segunda cidade:");
        string cidade2 = Console.ReadLine();

        int[,] cidades ={
            { 0, 520, 850, 800 }, // Vitória
            { 520, 0, 430, 590 }, // Belo Horizonte
            { 850, 430, 0, 360 }, // Rio de Janeiro
            { 800, 590, 360, 0 }  // São Paulo
        };
        if (cidade1 != cidade2)
        {
            if (cidade1 == "Vitória" || cidade1 == "Vitoria" || cidade1 == "vitória" || cidade1 == "vitoria")
            {
                int num1 = 0;
            }
            else if (cidade1 == "Belo Horizonte" || cidade1 == "belo horizonte")
            {
                int num1 = 1;
            }
            else if (cidade1 == "Rio de Janeiro" || cidade1 == "rio de janeiro")
            {
                int num1 = 2;
            }
            else if (cidade1 == "São Paulo" || cidade1 == "Sao Paulo" || cidade1 == "sao paulo" || cidade1 == "são paulo")
            {
                int num1 = 3;
            }
            else
            {
                Console.WriteLine("Cidade 1 inválida. Tente novamente.");
                return;
            }
            if (cidade2 == "Vitória" || cidade2 == "Vitoria" || cidade2 == "vitória" || cidade2 == "vitoria")
            {
                int num2 = 0;
            }
            else if (cidade2 == "Belo Horizonte" || cidade2 == "belo horizonte")
            {
                int num2 = 1;
            }
            else if (cidade2 == "Rio de Janeiro" || cidade2 == "rio de janeiro")
            {
                int num2 = 2;
            }
            else if (cidade2 == "São Paulo" || cidade2 == "Sao Paulo" || cidade2 == "sao paulo" || cidade2 == "são paulo")
            {
                int num2 = 3;
            }
            else
            {
                Console.WriteLine("Cidade 1 inválida. Tente novamente.");
                return;
            }
        }
        Console.WriteLine($"A distância entre {cidade1} e {cidade2} é {cidades[num1][num2]} km.");
    }
}