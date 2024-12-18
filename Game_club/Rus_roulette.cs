using System;
using System.Threading;

namespace Game_club
{
    internal class RusRoulette
    {
        public static void Launch()
        {
            PlayRusRoulette();
        }

        static void PlayRusRoulette()
        {
            const string text = "|нажать курок? " +
                                "\n|1 - да" +
                                "\n|2 - нет\n";
            var random = new Random();
            int bulletPosition = random.Next(1, 7);
            int attempt = 1;
            var isAlive = true;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("|добро пожаловать в русскую рулетку|");
            Thread.Sleep(1200);
            Console.ResetColor();

            while (isAlive)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(text);
                Console.ResetColor();
                var choice = Console.ReadLine();

                if (choice == "да" || choice == "1")
                {
                    Thread.Sleep(1200);

                    if (attempt == bulletPosition)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("*выстрел* \n[вы погибли]");
                        Console.ResetColor();
                        isAlive = false;
                    }
                    else
                    {
                        attempt++;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("*осечка*");
                        Thread.Sleep(1200);
                        Console.ResetColor();
                    }
                }
                else if (choice == "нет" || choice == "2")
                {
                    Thread.Sleep(1200);

                    if (bulletPosition - attempt <= 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("|ПОБЕДА|\n[вы выжили]");
                        Console.ResetColor();
                        Console.WriteLine("вы угадали, следующий выстрел был бы последним");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($"|вам оставалось {bulletPosition - attempt} выстрелов до смерти|\n[вы выжили]");
                        Console.ResetColor();
                    }
                    isAlive = false;
                }
                else if (choice == "log")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Console opening...");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("command...\n>>>");
                    var logCommand = Console.ReadLine();

                    if (logCommand == "bullet_loc")
                    {
                        Thread.Sleep(600);
                        Console.WriteLine("...");
                        Thread.Sleep(1400);
                        Console.WriteLine($"bullet {bulletPosition}th");
                    }
                }
            }
        }
    }
}
