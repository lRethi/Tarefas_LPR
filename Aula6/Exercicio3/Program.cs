using System;
using System.Reflection;

class Projeto
{
    static string? nome1 = "", poder1 = "";
    static int pontuacao1 = 0;

    static string? nome2 = "", poder2 = "";
    static int pontuacao2 = 0;

    static string? nome3 = "", poder3 = "";
    static int pontuacao3 = 0;

    static string? nome4 = "", poder4 = "";
    static int pontuacao4 = 0;

    static string? nome5 = "", poder5 = "";
    static int pontuacao5 = 0;

    static int equipe1 = 0, equipe2 = 0, equipe3 = 0;
    static void Main() 
    {
        Console.Clear();
        Console.WriteLine("Bem vindo, jogador!");
        Console.WriteLine("Esse programa permite que você monte a sua equipe perfeita de heróis da Marvel! Vamos iniciar!");
        MenuPrincipal();
    }

    static void CadastrarHeroi(){
        Console.WriteLine("");
        int init;
        Console.WriteLine("- Deseja cadastrar qual herói? (1 à 5 - Herói X, 6 - Nenhum)");
        init = Convert.ToInt32(Console.ReadLine());
        switch (init){
            case 1:
                Console.WriteLine("- Entre com o nome do herói.");
                nome1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("- Entre com o poder do herói.");
                poder1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("- Entre com a pontuação do héroi.");
                pontuacao1 = int.Parse(Console.ReadLine());
                CadastrarHeroi();
            break;
            case 2:
                Console.WriteLine("- Entre com o nome do herói.");
                nome2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("- Entre com o poder do herói.");
                poder2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("- Entre com a pontuação do héroi.");
                pontuacao2 = int.Parse(Console.ReadLine());
                CadastrarHeroi();
            break;
            case 3:
                Console.WriteLine("- Entre com o nome do herói.");
                nome3 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("- Entre com o poder do herói.");
                poder3 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("- Entre com a pontuação do héroi.");
                pontuacao3 = int.Parse(Console.ReadLine());
                CadastrarHeroi();
            break;
            case 4:
                Console.WriteLine("- Entre com o nome do herói.");
                nome4 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("- Entre com o poder do herói.");
                poder4 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("- Entre com a pontuação do héroi.");
                pontuacao4 = int.Parse(Console.ReadLine());
                CadastrarHeroi();
            break;
            case 5:
                Console.WriteLine("- Entre com o nome do herói.");
                nome5 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("- Entre com o poder do herói.");
                poder5 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("- Entre com a pontuação do héroi.");
                pontuacao5 = int.Parse(Console.ReadLine());
                CadastrarHeroi();
            break;
            case 6:
            MenuPrincipal();
            break;
            default:
                Console.WriteLine("- Você entrou com um número inválido, tente novamente!");
                CadastrarHeroi();
            break;
        }
    }
    static void SelecionarEquipe()
    {
        Console.WriteLine("- Para montar sua equipe, escolha até 3 dos heróis abaixo, digitando seus números.");

        Console.WriteLine($"1 - {nome1} | Poder: {poder1} | Pontuação: {pontuacao1}");
        Console.WriteLine($"2 - {nome2} | Poder: {poder2} | Pontuação: {pontuacao2}");
        Console.WriteLine($"3 - {nome3} | Poder: {poder3} | Pontuação: {pontuacao3}");
        Console.WriteLine($"4 - {nome4} | Poder: {poder4} | Pontuação: {pontuacao4}");
        Console.WriteLine($"5 - {nome5} | Poder: {poder5} | Pontuação: {pontuacao5}");

        Console.WriteLine("- Escolha o primeiro herói.");
        equipe1 = int.Parse(Console.ReadLine());
        Console.WriteLine("- Escolha o segundo herói.");
        equipe2 = int.Parse(Console.ReadLine());
        Console.WriteLine("- Escolha o terceiro herói.");
        equipe3 = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        MenuPrincipal();
    }
    static int PontuacaoTotal()
    {
        return Pontuacao(equipe1) + Pontuacao(equipe2) + Pontuacao(equipe3);
    }
     static void ExibirEquipe()
    {
        Console.Clear();
        Console.WriteLine("- A equipe atual é: ");

        MostrarHeroi(equipe1);
        MostrarHeroi(equipe2);
        MostrarHeroi(equipe3);

        Console.WriteLine($"- A pontuação total da equipe é de {PontuacaoTotal()}!");
        MenuPrincipal();
    }

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
        switch (init){
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
    static int Pontuacao(int numero)
    {
        switch (numero)
        {
            case 1: 
            return pontuacao1;
            case 2: 
            return pontuacao2;
            case 3: 
            return pontuacao3;
            case 4: 
            return pontuacao4;
            case 5: 
            return pontuacao5;
            default: return 0;
        }
    }
    static void MostrarHeroi(int numero)
    {
        switch (numero)
        {
            case 1: 
            Console.WriteLine($"{nome1} | Poder: {poder1} | Pontuação: {pontuacao1}"); 
            break;
            case 2: 
            Console.WriteLine($"{nome2} | Poder: {poder2} | Pontuação: {pontuacao2}"); 
            break;
            case 3: 
            Console.WriteLine($"{nome3} | Poder: {poder3} | Pontuação: {pontuacao3}"); 
            break;
            case 4: 
            Console.WriteLine($"{nome4} | Poder: {poder4} | Pontuação: {pontuacao4}"); 
            break;
            case 5: 
            Console.WriteLine($"{nome5} | Poder: {poder5} | Pontuação: {pontuacao5}"); 
            break;
            default: 
            Console.WriteLine("Herói inválido."); 
            break;
        }
    }
    static int FecharPrograma(){
        Console.WriteLine("Obrigado por usar!");
        return 0;
    }
}