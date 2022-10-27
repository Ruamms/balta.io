using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção para a contagem");
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto  =>  1m =  1 Minuto");
            Console.WriteLine("0s = Sair");
            Console.WriteLine("Quanto tempo deseja Contar?");
            String data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;
            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready ...");
            Thread.Sleep(1000);
            Console.WriteLine("Set ...");
            Thread.Sleep(1000);
            Console.WriteLine("Go ...");
            Thread.Sleep(1000);

            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch Finaliado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}