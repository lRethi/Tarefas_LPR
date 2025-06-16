using System;

class Aula8
{
    // Define uma estrutura para armazenar informações de um produto
    public struct Produto
    {
        public string Nome, Cod; // Nome e código do produto
        public int Qnt;          // Quantidade em estoque
        public float Prc;        // Preço unitário
    }
    static void Main()
    {
        Produto[] produtos = new Produto[3]; // Cria um array para armazenar 3 produtos

        // Loop para ler os dados de cada produto
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Entre com o nome do produto {i + 1}.");
            produtos[i].Nome = Console.ReadLine(); // Lê o nome do produto

            Console.WriteLine($"Entre com a quantidade do produto {i + 1}.");
            produtos[i].Qnt = int.Parse(Console.ReadLine()); // Lê a quantidade

            Console.WriteLine($"Entre com o código do produto {i + 1}.");
            produtos[i].Cod = Console.ReadLine(); // Lê o código

            Console.WriteLine($"Entre com o preço do produto {i + 1}.");
            produtos[i].Prc = float.Parse(Console.ReadLine()); // Lê o preço 

            Console.WriteLine();
        }

        // Exibe o valor total em estoque para cada produto
        Console.WriteLine($"{produtos[0].Nome}({produtos[0].Cod}) = R${produtos[0].Prc * produtos[0].Qnt} em estoque.");
        Console.WriteLine($"{produtos[1].Nome}({produtos[1].Cod}) = R${produtos[1].Prc * produtos[1].Qnt} em estoque.");
        Console.WriteLine($"{produtos[2].Nome}({produtos[2].Cod}) = R${produtos[2].Prc * produtos[2].Qnt} em estoque.");
    }
}