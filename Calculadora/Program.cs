using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1;
            int n2;
            string escolha;


            Console.Write("Digite um numero:");
            n1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Digite outro numero:");
            n2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Escolha um operação:");
            Console.WriteLine("A soma");
            Console.WriteLine("B subtração");
            Console.WriteLine("C multiplicação");
            Console.WriteLine("D divisão");
            Console.WriteLine("");

            escolha = Console.ReadLine();

            //if (escolha.Length == 1)
            //{
            //    if (escolha.ToUpper() == "A")
            //    {
            //        Console.WriteLine($"A soma dos dois numeros é : { n1 + n2}");
            //    }
            //    else if (escolha.ToUpper() == "B")
            //    {
            //        Console.WriteLine($"A subtração dos dois numeros é : { n1 - n2}");
            //    }
            //    else if (escolha.ToUpper() == "C")
            //    {
            //        Console.WriteLine($"A multiplicação dos dois numeros é : { n1 * n2}");
            //    }
            //    else if (escolha.ToUpper() == "D")
            //    {
            //        Console.WriteLine($"A divisão dos dois numeros é : { n1 / n2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("ERROR vc digitou uma opção invalida.");


            //    }

            //}
            //else
            //{
            //    Console.WriteLine("ERROR.");
            //}

            //Condição SWtich
            if (escolha.Length == 1)
            {
                switch (escolha.ToUpper())
                {
                    case "A":
                        Console.WriteLine($"A soma dos dois numeros é : { n1 + n2}");
                        break;
                    case "B":
                        Console.WriteLine($"A soma dos dois numeros é : { n1 - n2}");
                        break;
                    case "C":
                        Console.WriteLine($"A soma dos dois numeros é : { n1 * n2}");
                        break;
                    case "D":
                        Console.WriteLine($"A soma dos dois numeros é : { n1 / n2}");
                        break;

                    default:
                        Console.WriteLine("FATAL ERROR! : Você escolheu uma opção invalida! Tente novamente");
                        break;


                }
            }
            else
            {
                Console.WriteLine("ERROR.");
            }



            Console.WriteLine("");
            Console.WriteLine("Digite uma tecla para sair.");
            Console.ReadKey();
        }
    }
}
