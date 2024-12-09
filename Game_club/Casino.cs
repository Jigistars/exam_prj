using System;

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
            int chance_drug = 5;
            int rand_drug = random.Next(1, chance_drug + 1);
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
                Console.WriteLine("доступные действия:" +
                                  "\n|1 - продать дом " +
                                  "\n|2 - продать друга " +
                                  "\n|3 - продать машину" +
                                  "\n|4 - выйти из комы" +
                                  "\n|5 - продать всё" +
                                  "\n|6 - ставка" +
                                  "\n|7 - магазин" +
                                  "\n|Введите действие... \n");

                string choise = Console.ReadLine();

                while (true)
                {
                    System.Threading.Thread.Sleep(500);
                    prev_choise = false;
                    if (choise == "debug")
                    {
                        Console.WriteLine("opening debug...");
                        System.Threading.Thread.Sleep(1200);
                        Console.WriteLine("выберите действие... " +
                                          "\n 15:пополнить баланс " +
                                          "\n 16:вернуть вещь ");
                        int j = int.Parse(Console.ReadLine());
                        if (j == 15)
                        {
                            prev_choise = true;
                            Console.WriteLine("сумма ");
                            j = int.Parse(Console.ReadLine());
                            if (j > 15000)
                            {
                                Console.WriteLine("no" +
                                                  "\n *вас выгнали из казино*");
                                exit_y_n = true;
                                break;
                            }
                            else
                            {
                                sum += j;
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine($"ваша сумма {sum}");
                                Console.WriteLine("Введите действие ");
                                choise = Console.ReadLine();
                            }
                        }
                        else if (j == 16)
                        {
                            prev_choise = true;
                            Console.WriteLine("что хотите вернуть? 1:дом 2:тачку 3:друга 4:все ");
                            j = int.Parse(Console.ReadLine());
                            if (j == 1)
                            {
                                dom = true;
                                Console.WriteLine("вы вернули дом");
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine($"ваша сумма {sum}");
                                Console.WriteLine("Введите действие ");
                                choise = Console.ReadLine();
                            }
                            else if (j == 2)
                            {
                                prev_choise = true;
                                car = true;
                                Console.WriteLine("вы вернули машину");
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine($"ваша сумма {sum}");
                                Console.WriteLine("Введите действие ");
                                choise = Console.ReadLine();
                            }
                            else if (j == 3)
                            {
                                prev_choise = true;
                                friend = true;
                                Console.WriteLine("вы вернули друга");
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine($"ваша сумма {sum}");
                                Console.WriteLine("Введите действие ");
                                choise = Console.ReadLine();
                            }
                            else if (j == 4)
                            {
                                prev_choise = true;
                                dom = true;
                                friend = true;
                                car = true;
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine($"ваша сумма {sum}");
                                Console.WriteLine("Введите действие ");
                                choise = Console.ReadLine();
                            }
                        }
                    }
                    else if (choise == "2" && friend)
                    {
                        prev_choise = true;
                        if (rand_drug != 1)
                        {
                            Console.WriteLine("друг сбежал от вас");
                            friend = false;
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine($"ваша сумма {sum}");
                            Console.WriteLine("Введите действие ");
                            choise = Console.ReadLine();
                        }
                        else
                        {
                            sum += 10000;
                            Console.WriteLine("вы продали друга за 10000 ");
                            friend = false;
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine($"ваша сумма {sum}");
                            Console.WriteLine("Введите действие ");
                            choise = Console.ReadLine();
                        }
                    }
                    while (true)
                    {
                        if (choise == "7")
                        {
                            prev_choise = true;
                            Console.WriteLine("в процессе конвертации...");
                        }
                        else if (choise == "3" && car)
                        {
                            prev_choise = true;
                            sum += 2000;
                            Console.WriteLine("вы продали машину за 2000");
                            car = false;
                            Thread.Sleep(500);
                            Console.WriteLine($"ваша сумма {sum}");
                            Console.WriteLine("Ведите действие ");
                            choise = Console.ReadLine();
                        }
                        else if (choise == "4")
                        {
                            prev_choise = true;
                            Console.WriteLine($"вы вышли из комы с {sum} на балансе");
                            exit_y_n = true;
                            if (dom) Console.WriteLine(" с домом");
                            else if (friend) Console.WriteLine(" с другом");
                            else if (car) Console.WriteLine(" с машиной");
                            break;
                        }
                        else if (choise == "6")
                        {
                            prev_choise = true;
                            Console.WriteLine("|1 - [сумма]\n или \n|2 - всё ");
                            choise = Console.ReadLine();
                            if (choise == "2") choise = sum.ToString();
                            else Console.WriteLine("введи ставку"); choise = Console.ReadLine(); choise = int.Parse(choise).ToString() ;

                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine($"{sum} ваша сумма");
                            insult_chance = random.Next(1, 26 - pls_mns_insult_chance);
                            pls_mns_insult_chance++;

                            while (dot_value != 0)
                            {
                                Console.WriteLine(new string('.', dot_value));
                                System.Threading.Thread.Sleep(500);
                                dot_value--;
                            }

                            while (int.Parse(choise) > sum)
                            {
                                Console.WriteLine("у тебя нет такой суммы");
                                choise = Console.ReadLine();
                                continue;
                            }
                            if (win_additional_chance < -51)
                            {
                                win_additional_chance = 51;
                            }

                            if (win_rand < 51 + win_additional_chance)
                            {
                                sum -= int.Parse(choise);
                                Console.WriteLine("проиграл");
                                Console.WriteLine($"{sum} ваша сумма");
                                Console.WriteLine("Ведите действие ");
                                choise = Console.ReadLine();
                                win_additional_chance -= 8;
                            }
                            else
                            {
                                sum += int.Parse(choise);
                                Console.WriteLine("выиграл");
                                Console.WriteLine($"{sum} ваша сумма");
                                Console.WriteLine("Ведите действие ");
                                choise = Console.ReadLine();
                                win_additional_chance += 8;
                            }
                        }
                        else if (choise == "1" && dom)
                        {
                            prev_choise = true;
                            sum += 5000;
                            Console.WriteLine("вы продали дом за 5000");
                            dom = false;
                            Thread.Sleep(500);
                            Console.WriteLine($"ваша сумма {sum}");
                            Console.WriteLine("Ведите действие ");
                            choise = Console.ReadLine();
                            continue;
                        }
                        else if (choise == "5" && dom && friend && car)
                        {
                            prev_choise = true;
                            sum += 0;
                            Console.WriteLine("вы продали друга,тачку,дом за 17000 \n [комисия 17000$]");
                            dom = false;
                            friend = false;
                            car = false;
                            Thread.Sleep(500);
                            Console.WriteLine($"ваша сумма {sum}");
                            Console.WriteLine("Ведите действие ");
                            choise = Console.ReadLine();
                            continue;
                        }
                        else if (choise == "2" && friend)
                        {
                            prev_choise = true;
                            if (rand_drug != 1)
                            {
                                Console.WriteLine("друг сбежал от вас");
                                friend = false;
                            }
                            else
                            {
                                sum += 10000;
                                Console.WriteLine("вы продали друга за 10000 ");
                                friend = false;
                            }
                            Thread.Sleep(500);
                            Console.WriteLine($"ваша сумма {sum}");
                            Console.WriteLine("Ведите действие ");
                            choise = Console.ReadLine();
                            continue;
                        }

                        
                        else
                        {
                            if (prev_choise)
                            {
                                continue;
                            }
                            Console.WriteLine(" нет такого действия ");
                            Console.WriteLine("Ведите действие ");
                            choise = Console.ReadLine();
                        }
                    }


                    while (dot_value != 0)
                    {
                        Console.WriteLine(new string('.', dot_value));
                        System.Threading.Thread.Sleep(500);
                        dot_value--;
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
                        Console.WriteLine("у вас инсульт, вы умерли");
                        Console.WriteLine($"ваша сумма = {op}");
                        Environment.Exit(0);
                    }
                }

                if (sum <= 0)
                {
                    Console.WriteLine("вас избила жена/муж потому что вы пришли без денег и без дома, и вы не проснулись");
                    Console.WriteLine($"{record / 2} ваш рекорд");
                    Lived_y_n = true;
                }

                if (Lived_y_n)
                {
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine($"{record} ваш рекорд + вы живы");
                    Environment.Exit(0);
                }
            }
        }
    }
}