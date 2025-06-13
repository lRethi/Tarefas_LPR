using System;

class Aula8
{
    public struct Produto
    {
        public string Nome, Cod;
        public int Qnt;
        public float Prc;
    }
    static void Main()
    {
        Produto[] produtos = new Produto[3];
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Entre com o nome do produto {i + 1}.");
            produtos[i].Nome = Console.ReadLine();
            Console.WriteLine($"Entre com a quantidade do produto {i + 1}.");
            produtos[i].Qnt = int.Parse(Console.ReadLine());
            Console.WriteLine($"Entre com o código do produto {i + 1}.");
            produtos[i].Cod = Console.ReadLine();
            Console.WriteLine($"Entre com o preço do produto {i + 1}.");
            produtos[i].Prc = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        Console.WriteLine($"{produtos[0].Nome}({produtos[0].Cod}) = R${produtos[0].Prc * produtos[0].Qnt} em estoque.");
        Console.WriteLine($"{produtos[1].Nome}({produtos[1].Cod}) = R${produtos[1].Prc * produtos[1].Qnt} em estoque.");
        Console.WriteLine($"{produtos[2].Nome}({produtos[2].Cod}) = R${produtos[2].Prc * produtos[2].Qnt} em estoque.");
    }
}