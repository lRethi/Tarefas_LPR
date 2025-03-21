using System;
using System.Reflection;

class Projeto
{
    public static void Main() 
    {
        Projeto p = new Projeto(); 
        Console.WriteLine("= INICIANDO SIMULADOR DE TREINO PADAWAN - 1000 HORAS =");
        Console.WriteLine("- Bem-vindo, Mestre Jedi.");
        Console.WriteLine("- Esse algoritmo é utilizado para calcular quanto tempo será necessário para que seu padawan termine o treinamento escolhido de 1000 horas.");
        p.ContTreino();
    }
    public void ContTreino(){
        int d = 0, s = 0, m = 0, hd, ht = 0, hs = 0;
        Console.WriteLine("- Primeiro, entre com quantas horas seu padawan treinará por dia.");
        hd = Convert.ToInt32(Console.ReadLine());
        do{
            ht+=hd;
            d++;
        }while(ht<1000);
        hs = hd*5;
        s = d/5;
        m = (int)(s/4.5);
        if(m!= 1){
            Console.WriteLine($"- Serão necessários {d} dias, {s} semanas e {m} meses para alcançar as 1000 horas de treinamento, sabendo que ele fará {hs} horas de treinamento por semana, com o ritmo de {hd} horas por dia, com sábados e domingos livres.");
        }else{
            Console.WriteLine($"- Serão necessários {d} dias, {s} semanas e {m} mês para alcançar as 1000 horas de treinamento, sabendo que ele fará {hs} horas de treinamento por semana, com o ritmo de {hd} horas por dia, com sábados e domingos livres.");
        }
        TreinoEnd();
    }
    public void TreinoEnd(){
        Console.WriteLine("- Deseja calcular o tempo de treinamento novamente? (1 - Sim, 2 - Não)");
        int init;
        init = Convert.ToInt32(Console.ReadLine());
        switch (init){
            case 1:
                 ContTreino();
            break;
            case 2:
                 Console.WriteLine("- Que a força esteja com você, Mestre Jedi.");
                 Console.WriteLine("= FINALIZANDO SIMULADOR DE TREINO PADAWAN =");
            break;
            default:
                 Console.WriteLine("- Você entrou com um número inválido, tente novamente.");
                 TreinoEnd();
            break;
        }
    }
}