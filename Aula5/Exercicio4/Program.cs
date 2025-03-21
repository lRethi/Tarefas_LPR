using System;
using System.Reflection;

class Projeto
{
    public static void Main() 
    {
        Projeto p = new Projeto(); 
        Console.WriteLine("Este é um programa que calcula a soma dos dígitos do quadrado de um número digitado.");
        p.CalcBase();
    }
    public void CalcBase(){
        Console.WriteLine("Entre com o valor à ser calculado.");
        int num = Convert.ToInt32(Console.ReadLine());
        int quad = num*num;
        int sum = 0;
        for (int i = quad; i > 0; i /= 10){
            sum += i%10;
        }
        Console.WriteLine($"A soma dos digitos de {quad} é {sum}.");
        Console.WriteLine("Deseja calcular a soma dos digitos do quadrado de outro número? (1 - Sim, 2 - Não)");
        CalcInit();
    }
    public void CalcInit(){
        int init;
        init = Convert.ToInt32(Console.ReadLine());
        switch (init){
            case 1:
                 CalcBase();
            break;
            case 2:
                 Console.WriteLine("Bom, obrigado por usar!");
            break;
            default:
                 Console.WriteLine("Você entrou com um número inválido, tente novamente.");
                 CalcInit();
            break;
        }
    }
}