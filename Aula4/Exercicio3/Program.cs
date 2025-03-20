using System;

class Projeto
{
    int codigoClasse, codigoFinal;
    string? classe;

    public static void Main() 
    {
        Projeto p = new Projeto(); 
        Console.WriteLine("Bem-vindo, jogador! Agora que você terminou a sua criação de personagem só resta uma coisa!");
        Console.WriteLine("Todo grande aventureiro tem uma classe! As opções iniciais oferecidas são Guerreira, Maga e Arqueira!");
        Console.WriteLine("Escreva o número da classe para a verificar (1 - Guerreira, 2 - Maga, 3 - Arqueira)");
        p.escolhaClasse(); 
    }

    public void escolhaClasse()
    {
        codigoClasse = Convert.ToInt32(Console.ReadLine());
        switch (codigoClasse)
        {
            case 1:
                classe = "Guerreira";
                Console.WriteLine("A classe escolhida foi Guerreira!");
                Console.WriteLine("Suas habilidades são:");
                Console.WriteLine("= Ataque Pesado - Cause 1 dado de dano adicional no seu próximo golpe. - CUSTO: 1 SP");
                Console.WriteLine("= Defesa Total - Bloqueie completamente o próximo golpe que você vá receber. - CUSTO 1 SP");
                Console.WriteLine("Você tem certeza de sua escolha? (1 - Sim, 2 - Não)");
                confirmClasse(); 
            break;

            case 2:
                classe = "Maga";
                Console.WriteLine("A classe escolhida foi Maga!");
                Console.WriteLine("Suas habilidades são:");
                Console.WriteLine("= Bola de Fogo - Dispare uma bola de fogo e cause 3d6 de dano de fogo em todos os alvos à 5 metros da explosão. - CUSTO: 2 MP");
                Console.WriteLine("= Escudo de Gelo - Crie um escudo de gelo e reduza o próximo dano que tomar em 2d8. - CUSTO: 1 MP");
                Console.WriteLine("Você tem certeza de sua escolha? (1 - Sim, 2 - Não)");
                confirmClasse(); 
            break;

            case 3:
                classe = "Arqueira";
                Console.WriteLine("A classe escolhida foi Arqueira!");
                Console.WriteLine("Suas habilidades são:");
                Console.WriteLine("= Flecha Precisa - Dispare uma flecha potencializada, ela ganha Vantagem em sua rolagem. - CUSTO: 1 SP");
                Console.WriteLine("= Disparo Triplo - Dispare três flechas simultaneamente, faça uma rolagem de ataque pra cada. - CUSTO: 1 MP");
                Console.WriteLine("Você tem certeza de sua escolha? (1 - Sim, 2 - Não)");
                confirmClasse(); 
            break;

            default:
                Console.WriteLine("Valor inválido, tente novamente. (1 - Guerreira, 2 - Maga, 3 - Arqueira)");
                escolhaClasse();
            break;
        }
    }

    public void confirmClasse()
    {
        codigoFinal = Convert.ToInt32(Console.ReadLine());
        switch (codigoFinal)
        {
            case 1:
                Console.Write("Parabéns pela escolha, jogador! Você é uma ");
                Console.Write(classe);
                Console.Write("!");
                break;

            case 2:
                Console.WriteLine("Tudo bem, então, veja as opções novamente!");
                Console.WriteLine("Escreva o número da classe para a verificar (1 - Guerreira, 2 - Maga, 3 - Arqueira)");
                escolhaClasse(); 
                break;
            default:
                Console.WriteLine("Valor inválido, tente novamente. (1 - Sim, 2 - Não)");
                confirmClasse();
            break;
        }
    }
}
