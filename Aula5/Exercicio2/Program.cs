using System;
using System.Reflection;

class Projeto
{
    int valorInteiro;
    public static void Main() 
    {
        Projeto p = new Projeto(); 
        Console.WriteLine("Bem vindo!");
        Console.WriteLine("Esse é um jogo simples, onde um número aleatório de 1 à 100 é gerado, e você deve descobrir o número.");
        Console.WriteLine("Boa sorte!");
        p.RndJogo();
    }
    public void RndJogo(){
        RndBase();
        int cont = 0, num;
        do{
            Console.WriteLine("A quantidade atual de tentativas é " + cont + ".");
            Console.WriteLine("Entre com o seu próximo valor.");
            num = Convert.ToInt32(Console.ReadLine());
            cont++;
            if (num!= valorInteiro){
                Console.WriteLine("Errou!");
                if(num>valorInteiro){
                    Console.WriteLine("Chutou acima do valor!");
                }else{
                    Console.WriteLine("Chutou abaixo do valor!");
                }
            }
        }while (num != valorInteiro);
        Console.WriteLine("Parabéns, jogador!");
        Console.WriteLine("Você acertou! O número era " + valorInteiro + "!");
        Console.WriteLine("Deseja continuar jogando? (1 - Sim, 2 - Não)");
        RndInit();
    }
    public void RndBase(){
        Random numAleatorio = new Random();
        valorInteiro = numAleatorio.Next(1,100);
    }
    public void RndInit(){
        int init;
        init = Convert.ToInt32(Console.ReadLine());
        switch (init){
            case 1:
                 Console.WriteLine("Ótimo! Um novo número acabou de ser gerado, tente-o descobrir de novo!");
                 RndJogo();
            break;
            case 2:
                 Console.WriteLine("Uma pena, mas obrigado por jogar!");
            break;
            default:
                 Console.WriteLine("Você entrou com um número inválido, tente novamente.");
                 RndInit();
            break;
        }
    }
}