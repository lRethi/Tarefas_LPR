using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

class Aula9
{
    // Exibe as pessoas cuja idade está acima da média
    static void MostrarIdadeAcimaDaMedia(int varMediaIdade, Dictionary<string, int> idadePessoas)
    {
        Console.WriteLine($"A média de idade é de {varMediaIdade}, e as pessoas com idade acima da média são ");
        foreach (var pessoa in idadePessoas)
        {
            if (pessoa.Value > varMediaIdade)
            {
                Console.Write($"{pessoa.Key}, ");
            }
        }
        Console.WriteLine(".");
        return;
    }

    // Mostra a pessoa com a maior e a menor idade
    static void PessoaMaiorMenorIdade(Dictionary<string, int> idadePessoas)
    {
        int varMaiorIdade = idadePessoas.Max(x => x.Value); // Maior idade
        int varMenorIdade = idadePessoas.Min(x => x.Value); // Menor idade
        foreach (var pessoa in idadePessoas)
        {
            if (pessoa.Value == varMenorIdade)
            {
                Console.WriteLine($"A pessoa com a menor idade é {pessoa.Key} e ela tem {pessoa.Value} anos.");
            }
            if (pessoa.Value == varMaiorIdade)
            {
                Console.WriteLine($"A pessoa com a maior idade é {pessoa.Key} e ela tem {pessoa.Value} anos.");
            }
        }
    }

    // Remove todas as pessoas com uma idade específica informada pelo usuário
    static void RemoverPessoasDeValorY(Dictionary<string, int> idadePessoas)
    {
        Console.WriteLine("Entre com o valor de idade que você deseja remover.");
        var varIdadeRemover = int.Parse(Console.ReadLine());
        // Cria uma lista temporária para evitar modificar o dicionário durante a iteração
        var chavesParaRemover = idadePessoas.Where(p => p.Value == varIdadeRemover).Select(p => p.Key).ToList();
        foreach (var chave in chavesParaRemover)
        {
            idadePessoas.Remove(chave);
        }
        Console.WriteLine($"As pessoas que restaram após as com {varIdadeRemover} serem removidas são:");
        foreach (var pessoa in idadePessoas)
        {
            Console.WriteLine($"Pessoa: {pessoa.Key}, Idade: {pessoa.Value}");
        }
    }

    static void Main()
    {
        Dictionary<string, int> idadePessoas = new(); // Dicionário para armazenar nome e idade
        Console.WriteLine("Entre com quantas pessoas você vai adicionar.");
        int numPessoas = int.Parse(Console.ReadLine());
        // Lê os dados das pessoas
        for (var i = 0; i < numPessoas; i++)
        {
            Console.WriteLine($"Entre com o nome e idade da pessoa {i + 1}");
            var varNome = Console.ReadLine();
            var varIdade = int.Parse(Console.ReadLine());
            idadePessoas.Add(varNome, varIdade);
        }
        // Calcula a média das idades
        var varMediaIdade = idadePessoas.Sum(x => x.Value) / numPessoas;
        MostrarIdadeAcimaDaMedia(varMediaIdade, idadePessoas); // Exibe pessoas acima da média
        PessoaMaiorMenorIdade(idadePessoas); // Exibe maior e menor idade
        RemoverPessoasDeValorY(idadePessoas); // Remove pessoas com idade informada
    }
}