using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_club
{
    internal class RusRoulette
    {
        public static void Launch()
        {
            RusRoulet();
        }

        static void RusRoulet()
        {
            Random random = new Random();
            int live = random.Next(1, 7);
            int choise = 1;
            Thread.Sleep(1200);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("|добро пожаловать в русскую рулетку|");
            Thread.Sleep(1200);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("|нажать курок? " +
                          "\n|1 - да" +
                          "\n|2 - нет\n");
            Console.ResetColor();
            string choise1 = Console.ReadLine();

            while (true)
            {
                if ((choise1 == "да" || choise1 == "1") && choise >= live)
                {
                    Thread.Sleep(1200);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*выстрел* " +
                                      "\n[вы погибли]");
                    Console.ResetColor();
                    break;
                }
                else if ((choise1 == "да" || choise1 == "1") && choise != live)
                {
                    choise++;
                    Thread.Sleep(1200);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("*осечка*");
                    Thread.Sleep(1200);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("|нажать курок? " +
                                  "\n|1 - да" +
                                  "\n|2 - нет\n");
                    choise1 = Console.ReadLine();
                }
                else if ((choise1 == "нет" || choise1 == "2") && (live - choise == 1 || live - choise == 0))
                {
                    Thread.Sleep(1200);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("|ПОБЕДА|" +
                                      "\n[вы выжили]");
                    Console.ResetColor();
                    Console.WriteLine($"вы угадали, следующий выстрел был бы последним");
                    break;
                }
                else if ((choise1 == "нет" || choise1 == "2") && (live - choise != 1 && live - choise != 0))
                {
                    Thread.Sleep(1200);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"|вам оставалось {live - choise} выстрелов до смерти|" +
                                      $"\n[вы выжили]");
                    Console.ResetColor();
                    break;
                }
                else if (choise1 == "log")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Console opening...");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("command... \n>>>");
                    string ls = Console.ReadLine();
                    if (ls == "bullet_loc")
                    {
                        Thread.Sleep(600);
                        Console.WriteLine("...");
                        Thread.Sleep(1400);

                        Console.WriteLine($"bullet {live}th");
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("|нажать курок? " +
                                      "\n|1 - да" +
                                      "\n|2 - нет\n");
                        choise1 = Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("|нажать курок? " +
                                      "\n|1 - да" +
                                      "\n|2 - нет\n");
                        choise1 = Console.ReadLine();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("|нажать курок? " +
                                  "\n|1 - да" +
                                  "\n|2 - нет\n");
                    choise1 = Console.ReadLine();
                }
            }
        }
    }
}
