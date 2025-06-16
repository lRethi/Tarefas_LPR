using System;
using System.Reflection;

class Projeto
{
    static void Main()
    {
        Console.Clear();
        // Exibe informações iniciais sobre o programa e as cidades disponíveis
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
                Distancia(); // Chama o método para calcular a distância
                break;
            case 2:
                Console.WriteLine("Eeeh..? Ok?");
                break;
            default:
                Console.WriteLine("Valor inválido, tente novamente!");
                Main(); // Reinicia o programa em caso de valor inválido
                break;
        }
        FecharPrograma(); // Finaliza o programa
    }
    static int FecharPrograma()
    {
        return 0; // Método de encerramento
    }
    static void Distancia()
    {
        int[] cidade = new int[2];
        // Solicita ao usuário que informe as duas cidades
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Entre com o número da cidade {i + 1}. (1 - Vitória, 2 - Belo Horizonte, 3 - Rio de Janeiro, 4 - São Paulo)");
            cidade[i] = int.Parse(Console.ReadLine()) - 1; // Ajusta para índice do array (0 a 3)
        }

        // Matriz de distâncias entre as cidades
        int[,] cidades ={
            { 0, 520, 850, 800 }, // Vitória
            { 520, 0, 430, 590 }, // Belo Horizonte
            { 850, 430, 0, 360 }, // Rio de Janeiro
            { 800, 590, 360, 0 }  // São Paulo
        };
        // Verifica se as cidades informadas são válidas
        if (cidade[0] < 0 || cidade[0] > 3 || cidade[1] < 0 || cidade[1] > 3)
        {
            Console.WriteLine("Uma ou ambas as cidades inseridas são inválidas.");
            return; // Retorna sem fazer nada
        }
        // Exibe a distância entre as cidades escolhidas
        Console.WriteLine($"A distância entre as duas cidades é de {cidades[cidade[0], cidade[1]]} km.");
        // Se a distância não for zero (ou seja, cidades diferentes), permite nova consulta
        if (cidades[cidade[0], cidade[1]] != 0)
        {
            Distancia();
        }
    }
}