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
            Console.WriteLine("добро пожаловать на русскую рулетку");
            Thread.Sleep(1200);
            Console.Write("нажать курок? да(1)/нет(2) ");
            string choise1 = Console.ReadLine();

            while (true)
            {
                if ((choise1 == "да" || choise1 == "1") && choise >= live)
                {
                    Thread.Sleep(1200);
                    Console.WriteLine("*выстрел* \n[вы погибли]");
                    break;
                }
                else if ((choise1 == "да" || choise1 == "1") && choise != live)
                {
                    choise++;
                    Thread.Sleep(1200);
                    Console.WriteLine("*осечка*");
                    Thread.Sleep(1200);
                    Console.Write("нажать курок? да(1)/нет(2) ");
                    choise1 = Console.ReadLine();
                }
                else if ((choise1 == "нет" || choise1 == "2") && (live - choise == 1 || live - choise == 0))
                {
                    Thread.Sleep(1200);
                    Console.WriteLine("ПОБЕДА\n[вы выжили]");
                    Console.WriteLine($"вы угадали, следующий выстрел был бы последним");
                    break;
                }
                else if ((choise1 == "нет" || choise1 == "2") && (live - choise != 1 && live - choise != 0))
                {
                    Thread.Sleep(1200);
                    Console.WriteLine($"вам оставалось {live - choise} выстрелов до смерти\n[вы выжили]");
                    break;
                }
                else if (choise1 == "log")
                {
                    Console.WriteLine("opening debug...");
                    Thread.Sleep(1500);
                    Console.Write("command... \n >>>");
                    string ls = Console.ReadLine();
                    if (ls == "bullet_loc")
                    {
                        Thread.Sleep(600);
                        Console.WriteLine("...");
                        Thread.Sleep(1400);
                        Console.WriteLine($"bullet {live}th");
                        Thread.Sleep(1000);
                        Console.Write("нажать курок? да(1)/нет(2) ");
                        choise1 = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("нажать курок? да(1)/нет(2) ");
                        choise1 = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("нажать курок? да(1)/нет(2) ");
                    choise1 = Console.ReadLine();
                }
            }
        }
    }
}
