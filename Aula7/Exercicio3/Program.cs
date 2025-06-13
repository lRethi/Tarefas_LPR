using System;
using System.Reflection;

class Projeto
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Esse é um programa que armazena a distância entre as seguintes cidades:");
        Console.WriteLine("1 - Vitória");
        Console.WriteLine("2 - Belo Horizonte");
        Console.WriteLine("3 - Rio de Janeiro");
        Console.WriteLine("4 - São Paulo");
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
        Console.WriteLine($"A distância entre {cidade1} e {cidade2} é {cidades[num1][num2]} km.");
    }
}