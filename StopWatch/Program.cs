using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("S = Segundo => 10s = 10 Segundos");
                Console.WriteLine("M = Minuto => 1m = 1 Minuto");
                Console.WriteLine("0 = Sair");
                Console.WriteLine("Quanto tempo deseja contar?");

                string data = Console.ReadLine()?.ToLower();

                if (data == "0")
                    Environment.Exit(0);

                if (string.IsNullOrWhiteSpace(data) || data.Length < 2)
                {
                    Console.WriteLine("Entrada inválida! Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    continue;
                }

                char type = data[^1];
                string numberPart = data[..^1];

                if (!int.TryParse(numberPart, out int time) || time <= 0)
                {
                    Console.WriteLine("Erro: Digite um valor numérico válido maior que zero.");
                    Console.ReadKey();
                    continue;
                }

                int multiplier = type switch
                {
                    'm' => 60,
                    's' => 1,
                    _ => -1 // Indica erro
                };

                if (multiplier == -1)
                {
                    Console.WriteLine("Erro: Unidade de tempo inválida! Use 's' para segundos ou 'm' para minutos.");
                    Console.ReadKey();
                    continue;
                }

                PreStart(time * multiplier);
            }
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            for (int i = time; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Tempo restante: {i} segundos");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado!");
            Thread.Sleep(2500);
        }
    }
}
