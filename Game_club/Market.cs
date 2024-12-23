using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Game_club
{
    internal class MarketClass
    {
        public static void Market(ref bool friend, ref bool car, ref bool dom, ref bool choise_yn, ref int rand_drug, ref int sum)
        {
            Console.Clear();
            bool there = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("выберите действие: " +
                              "\n|1 - продать дом" +
                              "\n|2 - продать друга" +
                              "\n|3 - продать машину" +
                              "\n|4 - продать всё" +
                              "\n|5 - выход");
            Console.ResetColor();
            var choise = Console.ReadLine();
            while (there)
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
                            Console.WriteLine("введите действие: ");
                            Console.ReadLine();
                        }
                        break;

                    case "5":
                        there = false;
                        break;
                }
                Casino.Logic();
            }


        }
    }
}
