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

        public static void Casino_Launch()
        {
            Logic();
        }

        public static void Logic()
        {
            int rand_drug = random.Next(1, chance_friend + 1);
            Console.WriteLine($"{sum} ваша сумма");

            while (sum > 0 || car || dom || friend)
            {
                int win_rand = random.Next(1, 101);
                int dot_value = 5;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("доступные действия:" +
                                  "\n|1 - продать дом " +
                                  "\n|2 - продать друга " +
                                  "\n|3 - продать машину" +
                                  "\n|4 - выйти из комы" +
                                  "\n|5 - продать всё" +
                                  "\n|6 - ставка" +
                                  "\n|7 - магазин");
                Console.ResetColor();
                Console.WriteLine("\n|Введите действие... \n");
                string choise = Console.ReadLine();

                while (true)
                {
                    switch (choise)
                    {
                        case "1":
                            if (dom)
                            {
                                choise_yn = true;
                                sum += 5000;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("|вы продали дом за 5000");
                                dom = false;
                                Thread.Sleep(500);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"|ваша сумма {sum}|");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("|Ты не можешь продать дом, у тебя его уже нет|");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"|ваша сумма {sum}|");
                                Console.ResetColor();
                                Console.WriteLine("Введите действие: ");
                                Console.ReadLine();
                                break;
                            }

                        case "2":
                            if (friend)
                            {
                                choise_yn = true;
                                if (rand_drug != 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("|друг сбежал от вас|");
                                    friend = false;
                                }
                                else
                                {
                                    sum += 10000;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("|вы продали друга за 10000|");
                                    friend = false;
                                }
                                Thread.Sleep(500);
                                Console.WriteLine($"|ваша сумма {sum}|");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("|Ты не можешь продать друга, у тебя его уже нет|");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"|ваша сумма {sum}|");
                                Console.ResetColor();
                                Console.WriteLine("Введите действие: ");
                                Console.ReadLine();
                                break;
                            }

                        case "3":
                            if (car)
                            {
                                choise_yn = true;
                                sum += 2000;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("|вы продали машину за 2000|");
                                car = false;
                                Thread.Sleep(500);
                                Console.WriteLine($"|ваша сумма {sum}|");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("|Ты не можешь продать машину, у тебя её уже нет|");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"|ваша сумма {sum}|");
                                Console.ResetColor();
                                Console.WriteLine("Введите действие: ");
                                Console.ReadLine();
                                break;
                            }
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

                        case "5":
                            if (dom || car || friend)
                            {
                                if (dom && car && friend)
                                {
                                    sum += 17000;
                                }
                                else if (!dom && car && friend)
                                {
                                    sum += 12000;
                                }
                                else if (dom && !car && friend)
                                {
                                    sum += 15000;
                                }
                                else if (!dom && car && !friend)
                                {
                                    sum += 7000;
                                }
                                else if (!dom && !car && friend)
                                {
                                    sum += 10000;
                                }
                                else if (dom && !car && !friend)
                                {
                                    sum += 5000;
                                }
                                else if (!dom && car && !friend)
                                {
                                    sum += 2000;
                                }

                                choise_yn = true;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"|вы продали все что у вас есть за {sum}|");
                                dom = false;
                                car = false;
                                friend = false;
                                Thread.Sleep(500);
                                Console.WriteLine($"|ваша сумма {sum}|");
                                Console.ResetColor();
                            }
                            break;

                        case "6":
                            choise_yn = true;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("|1 - [сумма]\n|2 - всё ");
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
                            Console.WriteLine($"|{sum} ваша сумма|\n");
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

                            while (int.Parse(choise) > sum)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n|у тебя нет такой суммы|");
                                choise = Console.ReadLine();
                            }

                            if (win_additional_chance < -51)
                            {
                                win_additional_chance = 51;
                            }

                            if (win_rand < 51 + win_additional_chance)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                sum -= int.Parse(choise);
                                Console.WriteLine("\n|проиграл|");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"|{sum} ваша сумма|");
                                win_additional_chance -= 8;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                sum += int.Parse(choise);
                                Console.WriteLine("|выиграл|");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"|{sum} ваша сумма|");
                                win_additional_chance += 8;
                            }
                            Console.ResetColor();
                            break;

                        case "7":
                            choise_yn = true;
                            ShopClass.Shop(ref sum, ref knife, ref gun, ref lottery_money, ref chance_friend);
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
                    Console.WriteLine("|Введите действие: ");
                    choise = Console.ReadLine();
                }
            }

        }
    }
}