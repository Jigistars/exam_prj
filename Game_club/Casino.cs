using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

namespace Game_club
{
    class Casino
    {
        static Random random = new Random();
        static bool choise_yn = false;
        static int pls_mns_insult_chance = 5;
        static int chance_friend = 5;
        static int sum = 100;
        static int record = sum;
        static int win_additional_chance = 0;
        static int op = record / 2;
        static int insult_chance = 0;
        static bool Lived_y_n = false;
        static bool dom = true;
        static bool knife = true;
        static bool gun = true;
        static bool lottery_money = true;
        static bool car = true;
        static bool friend = true;
        static bool exit_y_n = false;
        public static void Logic()
        {
            int rand_drug = random.Next(1, chance_friend + 1);
            Console.WriteLine($"{sum} ваша сумма");
            string text = "доступные действия:" +
                          "\n|1 - ставка" +
                          "\n|2 - рынок" +
                          "\n|3 - магазин" +
                          "\n|4 - выйти из комы";
                int win_rand = random.Next(1, 101);
                int dot_value = 5;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(text);
                Console.ResetColor();
                Console.WriteLine("|Введите действие...");
                string choise = Console.ReadLine();

            while (true)
            {
                switch (choise)
                {

                    case "1":
                        if (pls_mns_insult_chance > 20)
                        {
                            pls_mns_insult_chance = 20;
                        }
                        choise_yn = true;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("|1 - [сумма]" +
                                          "\n|2 - всё ");
                        choise = Console.ReadLine();
                        if (choise == "2")
                        {
                            choise = sum.ToString();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.WriteLine("|введи ставку: ");
                            choise = Console.ReadLine();
                            choise = int.Parse(choise).ToString();
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Thread.Sleep(500);
                        Console.WriteLine($"|{sum} ваша сумма|");
                        insult_chance = random.Next(1, 26 - pls_mns_insult_chance);
                        pls_mns_insult_chance++;

                        while (dot_value != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(new string('.', dot_value));
                            Thread.Sleep(500);
                            dot_value--;
                            Console.ResetColor();
                        }

                        if (int.Parse(choise) > sum)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|у тебя нет такой суммы|");
                            choise = Console.ReadLine();
                        }

                        else if (win_additional_chance < -51)
                        {
                            win_additional_chance = 51;
                        }

                        else if (win_rand < 51 + win_additional_chance)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            sum -= int.Parse(choise);
                            Console.WriteLine("|проиграл|");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"|{sum} ваша сумма|");
                            win_additional_chance -= 8;
                            pls_mns_insult_chance++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            sum += int.Parse(choise);
                            Console.WriteLine("|выиграл|");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"|{sum} ваша сумма|");
                            win_additional_chance += 8;
                            pls_mns_insult_chance--;
                        }
                        Console.ResetColor();
                        break;

                    case "2":
                        MarketClass.Market(ref friend, ref car, ref dom, ref choise_yn, ref rand_drug, ref sum);
                        break;

                    case "3":
                        choise_yn = true;
                        ShopClass.Shop(ref sum, ref knife, ref gun, ref lottery_money, ref chance_friend);
                        break;

                    case "4":
                        choise_yn = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"|вы вышли из комы с {sum} на балансе|");
                        exit_y_n = true;
                        if (dom) Console.WriteLine(" с домом");
                        else if (friend) Console.WriteLine(" с другом");
                        else if (car) Console.WriteLine(" с машиной");
                        Environment.Exit(0);
                        break;

                    case "debug":
                        DebugClass.Debug(ref sum, ref choise_yn, ref exit_y_n, ref friend, ref dom, ref car, ref choise);
                        break;

                    default:
                        if (!choise_yn)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("|нет такого действия|");
                            Console.ResetColor();
                        }
                        break;
                }
                if (sum <= 0 & !car & !friend & !dom)
                {
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("вас избила жена потому что вы пришли без денег и без имущества,  вы не проснулись");
                    Console.WriteLine($"{record / 2} ваш рекорд");
                    Console.ResetColor();
                    Environment.Exit(0);

                }
                if (insult_chance == 3)
                {
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("у вас инсульт, вы умерли");
                    Console.WriteLine($"ваша сумма = {op}");
                    Console.ResetColor();
                    Environment.Exit(0);

                }
            }


        }
    }
}