using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

namespace Game_club
{
    class Casino
    {
        public static void Casino_Launch()
        {
            Logic();
        }


        static void Casino_2()
        {

        }
        static Random random = new Random();
        static void Logic()
        {
            bool prev_choise = false;
            int pls_mns_insult_chance = 5;
            int chance_friend = 5;
            int rand_drug = random.Next(1, chance_friend + 1);
            bool exit_y_n = false;
            int sum = 100;
            int record = sum;
            int win_additional_chance = 0;
            int op = record / 2;
            int insult_chance = 0;
            bool Lived_y_n = false;
            bool dom = true;
            bool knife = true;
            bool gun = true;
            bool lottery_money = true;
            bool car = true;
            bool friend = true;

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
                    System.Threading.Thread.Sleep(500);
                    prev_choise = false;
                    if (choise == "debug")
                    {
                        Debug(sum, prev_choise, exit_y_n, friend, dom, car, choise);
                    }
                    if (choise == "2" && friend)
                    {
                        prev_choise = true;
                        if (rand_drug != 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|друг сбежал от вас|");
                            friend = false;
                            System.Threading.Thread.Sleep(500);
                            Console.ResetColor();
                            Console.WriteLine($"|ваша сумма {sum}");
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            sum += 10000;
                            Console.WriteLine("|вы продали друга за 10000 ");
                            friend = false;
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine($"|ваша сумма {sum}");
                            Console.ResetColor();
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                        }
                    }
                    while (true)
                    {

                        if (choise == "7")
                        {
                            prev_choise = true;
                            Shop(sum, knife, gun, lottery_money, chance_friend);
                        }
                        else if (choise == "3" && car)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            prev_choise = true;
                            sum += 2000;
                            Console.WriteLine("|вы продали машину за 2000");
                            car = false;
                            Thread.Sleep(500);
                            Console.WriteLine($"|ваша сумма {sum}");
                            Console.ResetColor();
                            Console.WriteLine("|Ведите действие: ");
                            choise = Console.ReadLine();
                        }
                        else if (choise == "4")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            prev_choise = true;
                            Console.WriteLine($"|вы вышли из комы с {sum} на балансе");
                            exit_y_n = true;
                            if (dom) Console.WriteLine(" с домом");
                            else if (friend) Console.WriteLine(" с другом");
                            else if (car) Console.WriteLine(" с машиной");
                            break;
                        }
                        else if (choise == "6")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            prev_choise = true;
                            Console.WriteLine("|1 - [сумма]\n или \n|2 - всё ");
                            choise = Console.ReadLine();
                            if (choise == "2") choise = sum.ToString();
                            else Console.ResetColor(); Console.WriteLine("|введи ставку: "); choise = Console.ReadLine(); choise = int.Parse(choise).ToString();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine($"|{sum} ваша сумма");
                            insult_chance = random.Next(1, 26 - pls_mns_insult_chance);
                            pls_mns_insult_chance++;

                            while (dot_value != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(new string('.', dot_value));
                                System.Threading.Thread.Sleep(500);
                                dot_value--;
                                Console.ResetColor();
                            }

                            while (int.Parse(choise) > sum)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("|у тебя нет такой суммы|");
                                choise = Console.ReadLine();
                                continue;
                            }
                            if (win_additional_chance < -51)
                            {
                                win_additional_chance = 51;
                            }

                            if (win_rand < 51 + win_additional_chance)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                sum -= int.Parse(choise);
                                Console.WriteLine("|проиграл|");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"|{sum} ваша сумма");
                                Console.ResetColor();
                                Console.WriteLine("|Ведите действие ");
                                choise = Console.ReadLine();
                                win_additional_chance -= 8;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                sum += int.Parse(choise);
                                Console.WriteLine("|выиграл|");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"|{sum} ваша сумма");
                                Console.ResetColor();
                                Console.WriteLine("|Ведите действие ");
                                choise = Console.ReadLine();
                                win_additional_chance += 8;
                            }
                        }
                        else if (choise == "1" && dom)
                        {
                            prev_choise = true;
                            sum += 5000;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|вы продали дом за 5000");
                            dom = false;
                            Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"|ваша сумма {sum}");
                            Console.ResetColor();
                            Console.WriteLine("|Ведите действие ");
                            choise = Console.ReadLine();
                            continue;
                        }
                        else if (choise == "5" && dom && friend && car)
                        {
                            prev_choise = true;
                            sum += 17000;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|вы продали друга,тачку,дом за 17000");
                            Console.ResetColor();
                            dom = false;
                            friend = false;
                            car = false;
                            Thread.Sleep(500);
                            Console.WriteLine($"|ваша сумма {sum}");
                            Console.WriteLine("|Ведите действие ");
                            choise = Console.ReadLine();
                            continue;
                        }
                        else if (choise == "2" && friend)
                        {
                            prev_choise = true;
                            if (rand_drug != 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("|друг сбежал от вас");
                                Console.ResetColor();
                                friend = false;
                            }
                            else
                            {
                                sum += 10000;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("|вы продали друга за 10000 ");
                                friend = false;
                                Console.ResetColor();
                            }
                            Thread.Sleep(500);
                            Console.WriteLine($"|ваша сумма {sum}");
                            Console.WriteLine("|Ведите действие ");
                            choise = Console.ReadLine();
                            continue;
                        }


                        else
                        {
                            if (prev_choise)
                            {
                                continue;
                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("|нет такого действия ");
                            Console.ResetColor();
                            Console.WriteLine("|Ведите действие ");
                            Console.ResetColor();
                            choise = Console.ReadLine();
                        }
                    }


                    while (dot_value != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(new string('.', dot_value));
                        System.Threading.Thread.Sleep(500);
                        dot_value--;
                        Console.ResetColor();
                    }

                    if (exit_y_n)
                    {
                        Environment.Exit(0);
                    }

                    if (record < sum)
                    {
                        record = sum;
                    }
                    if (pls_mns_insult_chance > 20)
                    {
                        pls_mns_insult_chance = 20;
                    }
                    System.Threading.Thread.Sleep(500);
                    if (insult_chance == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("у вас инсульт, вы умерли");
                        Console.WriteLine($"ваша сумма = {op}");
                        Environment.Exit(0);
                    }
                }

                if (sum <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("вас избила жена потому что вы пришли без денег и без дома \n [вы не проснулись :)]");
                    Console.WriteLine($"{record / 2} ваш рекорд");
                    Lived_y_n = true;
                }

                if (Lived_y_n)
                {
                    System.Threading.Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{record} ваш рекорд + вы живы");
                    Environment.Exit(0);
                }
            }
        }

        static void Shop(int sum, bool knife, bool gun, bool lottery_money, int chance_friend)
        {
            Random random = new Random();
            Console.WriteLine("|что купить?\n |1 - нож [10$]\n |2 - пистолет [150$] \n |3 - лотерейный билет [1000$] ");
            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    sum -= 10;
                    knife = false;
                    chance_friend = 4;
                    break;
                case "2":
                    sum -= 150;
                    gun = false;
                    chance_friend = 2;
                    break;
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
                        sum -= 1000;
                        int money_rand = random.Next(0, 10001);
                        lottery_money = false;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"|ты получил {money_rand}|");
                        Console.ResetColor();
                        sum += money_rand;
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("|такого действия нет|");
                    Console.ResetColor();
                    return;
            }

            Thread.Sleep(500);
            Console.WriteLine($"|ваша сумма {sum}");
            Console.WriteLine("|Введите действие: ");
            choise = Console.ReadLine();

        }

        static void Debug(int sum, bool prev_choise, bool exit_y_n, bool friend, bool dom, bool car, string choise)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|opening debug...|");
            System.Threading.Thread.Sleep(1200);
            Console.WriteLine("|выберите действие... " +
                              "\n |1 - пополнить баланс " +
                              "\n |2 - вернуть вещь ");
            int console_choise = int.Parse(Console.ReadLine());
            switch (console_choise)
            {
                case 1:
                    prev_choise = true;
                    Console.WriteLine("сумма ");
                    console_choise = int.Parse(Console.ReadLine());
                    if (console_choise > 1500000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("no" +
                                        "\n |вас выгнали из казино|");
                        Console.ResetColor();
                        exit_y_n = true;
                    }
                    else
                    {
                        sum += console_choise;
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine($"|ваша сумма {sum}");
                        Console.WriteLine("|Введите действие: ");
                        choise = Console.ReadLine();
                    }
                    Console.ResetColor();
                    break;

                case 2:
                    prev_choise = true;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("|что хотите вернуть? " +
                            "\n|1 - Дом " +
                            "\n|2 - Машину " +
                            "\n|3 - Друга " +
                            "\n|4 - Все предметы ");
                    console_choise = int.Parse(Console.ReadLine());

                    switch(console_choise)
                    {
                        case 1:
                            dom = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|вы вернули дом|");
                            System.Threading.Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"|ваша сумма {sum}");
                            Console.ResetColor();
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                            break;

                        case 2:
                            prev_choise = true;
                            car = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("вы вернули машину");
                            System.Threading.Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"ваша сумма {sum}");
                            Console.ResetColor();
                            Console.WriteLine("Введите действие ");
                            choise = Console.ReadLine();
                            break;

                        case 3:
                            prev_choise = true;
                            friend = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|вы вернули друга");
                            System.Threading.Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"|ваша сумма {sum}");
                            Console.ResetColor();
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                            break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            prev_choise = true;
                            dom = true;
                            friend = true;
                            car = true;
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine($"|ваша сумма {sum}");
                            Console.ResetColor();
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                            break;
                    }
                    break;
            }
        
            
        }
    }
}
