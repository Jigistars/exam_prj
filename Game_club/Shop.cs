using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_club
{
    internal class Shop
    {
        public static void Shop_enter(int sum, bool knife, bool gun, bool lottery_money, int chance_friend)
        {
            shop(sum, knife, gun, lottery_money, chance_friend);
        }
        static void shop(int sum, bool knife, bool gun, bool lottery_money, int chance_friend)
        {
            bool there = true;
            Random random = new Random();
            Console.WriteLine("|что купить?" +
                              "\n|1 - нож [10$]" +
                              "\n|2 - пистолет [150$]" +
                              "\n|3 - лотерейный билет [1000$]" +
                              "\n|4 - выход");
            string choise = Console.ReadLine();
            while (there)
            {
                switch (choise)
                {
                    case "1":
                        if (sum < 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|не хватает средств|");
                            Console.ResetColor();
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|вы приобрели нож, теперь шанс на продажу друга увеличен|");
                            Console.ResetColor();
                            sum -= 10;
                            knife = false;
                            chance_friend = 4;
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                            break;
                        }
                    case "2":
                        if (sum < 150)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|не хватает средств|");
                            Console.ResetColor();
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|вы приобрели пистолет, теперь шанс на продажу друга увеличен|");
                            Console.ResetColor();
                            sum -= 150;
                            gun = false;
                            chance_friend = 2;
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                            break;
                        }
                    case "3":
                        if (sum < 1000)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|не хватает средств|");
                            Console.ResetColor();
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|вы приобрели лотерейный билет|");
                            Console.ResetColor();
                            sum -= 1000;
                            int money_rand = random.Next(0, 10001);
                            lottery_money = false;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"|ты получил {money_rand}|");
                            Console.ResetColor();
                            sum += money_rand;
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                            break;
                        }
                    case "4":
                        there = false;
                        break;


                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("|такого действия нет|\n|введите цифру для того или иного действия|");
                        Console.ResetColor();
                        choise = Console.ReadLine();
                        return;
                }
            }
            Casino.Casino_Launch(sum);
        }
    }
}
