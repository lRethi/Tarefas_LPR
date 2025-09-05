using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

class Aula10
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double CalcArea() { return Altura * Largura; }
        public double CalcPerimetro() { return 2 * (Altura + Largura); }
    }

    static void Main()
    {
        Retangulo ret = new Retangulo();

        Console.WriteLine("O retângulo que você deseja calcular terá qual medida? ( 1 - cm, 2 - m, 3 - mm )");
        int varUnidade = int.Parse(Console.ReadLine());
        switch (varUnidade)
        {
            case 1:
                Console.WriteLine("As medidas do retângulo serão em centímetros.");
                break;
            case 2:
                Console.WriteLine("As medidas do retângulo serão em metros.");
                break;
            case 3:
                Console.WriteLine("As medidas do retângulo serão em milímetros.");
                break;
            default:
                Console.WriteLine("Opção inválida, as medidas do retângulo serão em centímetros.");
                break;
        }

        Console.WriteLine("Entre com a altura do retângulo:");
        ret.Altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre com a largura do retângulo:");
        ret.Largura = double.Parse(Console.ReadLine());

        Console.WriteLine($"A área do retângulo é {ret.CalcArea()}{MedidaRetangulo(varUnidade)}²");
        Console.WriteLine($"O perímetro do retângulo é {ret.CalcPerimetro()}{MedidaRetangulo(varUnidade)}");
    }
    public static string MedidaRetangulo(int varUnidade)
        { 
            if (varUnidade == 1)
            {
                return "cm";
            }
            else if (varUnidade == 2)
            {
                return "m";
            }
            else if (varUnidade == 3)
            {
                return "mm";
            }
            else
            {
                return "cm";
            }
        }
}