using System;

// Classe principal do programa
class Aula8
{
    // Estrutura que representa um herói
    public struct Hero
    {
        public string Nome, Poder; // Nome e poder do herói
        public int Pts;            // Pontuação do herói
    }

    // Vetor para armazenar até 5 heróis cadastrados
    static Hero[] herois = new Hero[5];
    // Vetor para armazenar a equipe selecionada (até 3 heróis)
    static Hero[] equipe = new Hero[3];

    // Função principal do programa
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo, jogador!");
        Console.WriteLine("Esse programa permite que você monte a sua equipe perfeita de heróis da Marvel! Vamos iniciar!");
        MenuPrincipal(); // Chama o menu principal
    }

    // Função para cadastrar heróis
    static void CadastrarHeroi()
    {
        Console.WriteLine("");
        int init;
        Console.WriteLine("- Deseja cadastrar qual herói? (1 à 5 - Herói X, 6 - Nenhum)");
        init = Convert.ToInt32(Console.ReadLine());
        if (init < 6 && init > 0)
        {
            // Solicita os dados do herói e armazena no vetor
            Console.WriteLine($"- Entre com o nome do herói {init}.");
            herois[init - 1].Nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"- Entre com o poder do herói {init}.");
            herois[init - 1].Poder = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"- Entre com a pontuação do héroi {init}.");
            herois[init - 1].Pts = int.Parse(Console.ReadLine());
            CadastrarHeroi(); // Permite cadastrar outro herói
        }
        else if (init == 6)
        {
            // Retorna ao menu principal
            MenuPrincipal();
        }
        else
        {
            // Caso o usuário digite um valor inválido
            Console.WriteLine("Você entrou com um valor inválido, tente novamente.");
            CadastrarHeroi();
        }
    }

    // Função para selecionar a equipe de heróis
    static void SelecionarEquipe()
    {
        Console.WriteLine("- Para montar sua equipe, escolha até 3 dos heróis abaixo, digitando seus números.");

        // Exibe todos os heróis cadastrados
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{i+1}  - {herois[i].Nome} | Poder: {herois[i].Poder} | Pontuação: {herois[i].Pts}");   
        }

        // Permite ao usuário escolher 3 heróis para a equipe
        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine($"- Escolha o herói {j + 1}");
            int numHero = int.Parse(Console.ReadLine());
            equipe[j] = herois[numHero - 1];
        }
        Console.WriteLine("");
        CalcularPontuacaoTotal(); // Calcula a pontuação total da equipe
        MenuPrincipal();          // Retorna ao menu principal
    }

    // Função que calcula a pontuação total da equipe
    static int CalcularPontuacaoTotal()
    {
        return equipe[0].Pts + equipe[1].Pts + equipe[2].Pts;
    }

    // Função para exibir a equipe atual e sua pontuação total
    static void ExibirEquipe()
    {
        Console.WriteLine("- A equipe atual é: ");

        // Exibe os membros da equipe
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i + 1}  - {equipe[i].Nome} | Poder: {equipe[i].Poder} | Pontuação: {equipe[i].Pts}");
        }
        // Exibe a pontuação total da equipe
        Console.WriteLine($"- A pontuação total da equipe é de {CalcularPontuacaoTotal()}!");
        MenuPrincipal(); // Retorna ao menu principal
    }

    // Função para encerrar o programa
    static int FecharPrograma()
    {
        Console.WriteLine("Obrigado por usar!");
        return 0;
    }

    // Função que exibe o menu principal e direciona para as opções escolhidas
    static void MenuPrincipal()
    {
        int init;
        Console.WriteLine("");
        Console.WriteLine("Entre com a opção do menu que desejar visitar.");
        Console.WriteLine(" 1 - Cadastrar Heróis");
        Console.WriteLine(" 2 - Selecionar Equipe");
        Console.WriteLine(" 3 - Exibir Equipe");
        Console.WriteLine(" 4 - Sair do Programa");
        init = Convert.ToInt32(Console.ReadLine());
        switch (init)
        {
            case 1:
                Console.Clear();
                CadastrarHeroi();
                break;
            case 2:
                Console.Clear();
                SelecionarEquipe();
                break;
            case 3:
                Console.Clear();
                ExibirEquipe();
                break;
            case 4:
                Console.Clear();
                FecharPrograma();
                break;
            default:
                Console.WriteLine("Você entrou com um valor inválido, tente novamente!");
                MenuPrincipal();
                break;
        }
    }
}