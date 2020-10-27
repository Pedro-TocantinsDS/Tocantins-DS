using System;

namespace acerte_o_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_digitado, num_gerado, conta_palpites;
            Console.WriteLine("O computrador gerou um número aleatório de 1 a 10.");
            num_gerado = Gera_numero();
            conta_palpites = 0;
            string exit = "sair";
            while (true)
            {

                Console.Write("Tente adivinhar: ");
                string numString = Console.ReadLine();
                if (numString == exit || numString == "Sair")
                {
                    Console.WriteLine("Finalizando...");
                    break;
                }
                else
                {
                    num_digitado = int.Parse(numString);
                }

                if (num_digitado < 1 || num_digitado > 10)
                {
                    Console.WriteLine("Número invalido.Tente Novamente.");
                }
                else if (num_digitado == num_gerado)
                {
                    Console.Clear();
                    conta_palpites += 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Você acertou.O número era {0}", num_gerado);
                    Console.WriteLine("Você acertou em {0} palpites.", conta_palpites);
                    ResetaCor();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    conta_palpites += 1;
                    Console.WriteLine("Vc errou.Continue tentando.");
                    Console.WriteLine("Você deu {0} palpites", conta_palpites);
                }
            }

        }
        static int Gera_numero()
        {
            return new Random().Next(1, 11);
        }
        static int soma_palpite(int palpite)
        {
            return palpite += 1;
        }
        static void ResetaCor()
        {
            Console.ResetColor();
        }
    }
}
