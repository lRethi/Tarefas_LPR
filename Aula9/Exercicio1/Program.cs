using System;
using System.Collections.Generic;
using System.Linq;

class Aula9
{
    static void Main()
    {
        int qntDeNomes;
        List<string> listaDeNomes = new();
        Console.WriteLine("Entre com quantos nomes você deseja adicionar.");
        qntDeNomes = int.Parse(Console.ReadLine());
        for (int i = 0; i < qntDeNomes; i++)
        {
            Console.WriteLine($"Entre com o nome {i + 1}");
            string? nomeAdicionado = Convert.ToString(Console.ReadLine());
            listaDeNomes.Add(nomeAdicionado);
        }
        foreach (var varNome in listaDeNomes)
        {
            
        }
    }
}