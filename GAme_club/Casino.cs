using System;

namespace Game_club
{
    class Casino
    {
        public static void Casino_Launch()
        {
            Logic();
        }


        static int pls_mns_insult_chance;
        static Random random = new Random();
        static void Logic()
        {
            int chance_drug = 5;
            int rand_drug = random.Next(1, chance_drug + 1);
            int exit_y_n = 0;
            int sum = 100;
            int record = sum;
            int shot_chance = 0;
            int op = record / 2;
            pls_mns_insult_chance = 0;
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
                int c = random.Next(1, 101);
                int dot_value = 5;
                Console.WriteLine("доступные действия:" +
                                  "\n 1:продать дом " +
                                  "\n 2:продать друга " +
                                  "\n 3:продать машину" +
                                  "\n 4:выйти из комы" +
                                  "\n 5:продать всё" +
                                  "\n 6:ставка" +
                                  "\n 7:магазин" +
                                  "\n Введите действие: ");
                string choise = Console.ReadLine();

                while (true)
                {
                    System.Threading.Thread.Sleep(500);
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
                            Console.WriteLine("сумма ");
                            j = int.Parse(Console.ReadLine());
                            if (j > 15000)
                            {
                                Console.WriteLine("no" +
                                                  "\n *вас выгнали из казино*");
                                exit_y_n = 1;
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
                            Console.WriteLine("что хотите вернуть? 20:дом 21:тачку 22:друга 23:все ");
                            j = int.Parse(Console.ReadLine());
                            if (j == 20)
                            {
                                dom = true;
                                Console.WriteLine("вы вернули дом");
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine($"ваша сумма {sum}");
                                Console.WriteLine("Введите действие ");
                                choise = Console.ReadLine();
                            }
                            else if (j == 21)
                            {
                                car = true;
                                Console.WriteLine("вы вернули машину");
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine($"ваша сумма {sum}");
                                Console.WriteLine("Введите действие ");
                                choise = Console.ReadLine();
                            }
                            else if (j == 22)
                            {
                                friend = true;
                                Console.WriteLine("вы вернули друга");
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine($"ваша сумма {sum}");
                                Console.WriteLine("Введите действие ");
                                choise = Console.ReadLine();
                            }
                            else if (j == 23)
                            {
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
                    else if (choise == "sigma")
                    {
                        Console.WriteLine("opening sigma promocode...");
                        System.Threading.Thread.Sleep(1200);
                        sum += 2500000000000000000;
                        Console.WriteLine($"ваша сумма {sum}");
                        Console.WriteLine("Введите действие ");
                        choise = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("нет такого действия");
                        Console.WriteLine("Введите действие ");
                        choise = Console.ReadLine();
                    }

                    while (dot_value != 0)
                    {
                        Console.WriteLine(new string('.', dot_value));
                        System.Threading.Thread.Sleep(500);
                        dot_value--;
                    }

                    if (exit_y_n == 1)
                    {
                        break;
                    }

                    if (c < 51 + shot_chance)
                    {
                        sum -= int.Parse(choise);
                        Console.WriteLine("проиграл");
                        shot_chance -= 8;
                    }
                    else
                    {
                        sum += int.Parse(choise);
                        Console.WriteLine("выиграл");
                        shot_chance += 8;
                        if (shot_chance < -51)
                        {
                            shot_chance = -51;
                        }
                    }

                    if (record < sum)
                    {
                        record = sum;
                    }
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine($"{sum} ваша сумма");
                    int insult_chance = random.Next(1, 26 - pls_mns_insult_chance);
                    pls_mns_insult_chance++;
                    if (pls_mns_insult_chance > 20)
                    {
                        pls_mns_insult_chance = 20;
                    }
                    System.Threading.Thread.Sleep(500);
                    if (insult_chance == 3)
                    {
                        Console.WriteLine("у вас инсульт, вы умерли");
                        Console.WriteLine($"ваша сумма = {op}");
                        break;
                    }
                }

                if (sum <= 0)
                {
                    Console.WriteLine("вас избила жена/муж потому что вы пришли без денег и без дома, и вы не проснулись");
                    Console.WriteLine($"{record / 2} ваш рекорд");
                    Lived_y_n = true;
                }

                if (!Lived_y_n)
                {
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine($"{record} ваш рекорд + вы живы");
                }
            }
        }
    }
}