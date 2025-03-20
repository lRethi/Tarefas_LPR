using System;
class Projeto
  {
    static void Main()
    {
        Console.WriteLine("Esse programa serve para verificar se um número inteiro é par ou não.");
        Console.WriteLine("Entre com o seu número inteiro.");
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1%2 == 0){
            Console.Write("O número ");
            Console.Write(num1);
            Console.Write(" é par.");
        } else{
            Console.Write("O número ");
            Console.Write(num1);
            Console.Write(" é impar.");
        }
    }
  }