using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
 
            Console.WriteLine("Você digitou: " + v1);

            if (v1 >= 5)
            { Console.WriteLine("Excelente!!!");
                
        }else
            {
                Console.WriteLine("Só isso?");
            }
        }
    }
}