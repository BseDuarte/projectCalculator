using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            bool repetir;
            do
            {
                Console.Clear();


                Console.WriteLine("O que irá fazer?");
                Console.WriteLine("Digite 1 para multiplicar");
                Console.WriteLine("Digite 2 para dividir");
                Console.WriteLine("Digite 3 para calcular a porcentagem");
                int decisao = int.Parse(Console.ReadLine());
                switch (decisao)
                {
                    case 1: multiplicar(); break;
                    case 2: dividir(); break;
                    case 3: porcentagem(); break;


                    default:
                        break;
                }


                Console.WriteLine("Deseja executar o programa novamente? (sim/não)");       
                string resposta = Console.ReadLine().ToLower();
                repetir = resposta == "sim";

            } while (repetir);


            static void multiplicar()
            {
                Console.WriteLine("Calculadora de multiplicação");
                Console.WriteLine("Insira um número inteiro para multiplicar:");
                int multi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira outro número:");
                int multi2 = int.Parse(Console.ReadLine());

                int multiplicacao = multi1 * multi2;
                Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);
            }

            static void dividir()
            {
                Console.WriteLine("Calculadora de divisão");
                Console.WriteLine("Insira um valor para dividir");
                double div1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira outro valor para dividir");
                double div2 = double.Parse(Console.ReadLine());

                double divisao = div1 / div2;

                Console.WriteLine("O resultado da divisão é: " + divisao);
            }

            static void porcentagem()
            {
                Console.WriteLine("Calculadora de porcentagem");
                Console.WriteLine("Insira o primeiro valor");
                double porc1 = double.Parse(Console.ReadLine());    
                Console.WriteLine("Insira o segundo valor");
                double porc2 = double.Parse(Console.ReadLine());

                double porcento = porc1 * porc2 / 100;

                Console.WriteLine($"Se {porc1} é 100%, logo {porc2}% de {porc1} é " + porcento);
            }
        }


    }
}
