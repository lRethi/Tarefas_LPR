using System;
using System.Reflection;

class Projeto
{
    static void Main()
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
                Distancia();
                break;
            case 2:
                Console.WriteLine("Eeeh..? Ok?");
                break;
            default:
                Console.WriteLine("Valor inválido, tente novamente!");
                Main();
                break;
        }
        FecharPrograma();
    }
    static int FecharPrograma()
    {
        return 0;
    }
    static void Distancia()
    {
        int[] cidade = new int[2];
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Entre com o número da cidade {i + 1}. (1 - Vitória, 2 - Belo Horizonte, 3 - Rio de Janeiro, 4 - São Paulo)");
            cidade[i] = int.Parse(Console.ReadLine()) - 1;
        }

        int[,] cidades ={
            { 0, 520, 850, 800 }, // Vitória
            { 520, 0, 430, 590 }, // Belo Horizonte
            { 850, 430, 0, 360 }, // Rio de Janeiro
            { 800, 590, 360, 0 }  // São Paulo
        };
        if (cidade[0] < 0 || cidade[0] > 3 || cidade[1] < 0 || cidade[1] > 3)
        {
            Console.WriteLine("Uma ou ambas as cidades inseridas são inválidas.");
            return; // Retorna sem fazer nada
        }
        Console.WriteLine($"A distância entre as duas cidades é de {cidades[cidade[0], cidade[1]]} km.");
        if (cidades[cidade[0], cidade[1]] != 0)
        {
            Distancia();
        }
    }
}