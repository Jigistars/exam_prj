using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_club
{
    internal class Debug
    {
        public static void Debug_enter(int sum, bool prev_choise, bool exit_y_n, bool friend, bool dom, bool car, string choise)
        {
            debug(sum, prev_choise, exit_y_n, friend, dom, car, choise);
        }
        static void debug(int sum, bool prev_choise, bool exit_y_n, bool friend, bool dom, bool car, string choise)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            bool in_debug = true;
            Console.WriteLine("\n|console opening...|");
            System.Threading.Thread.Sleep(1200);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|выберите действие:" +
                              "\n |1 - пополнить баланс" +
                              "\n |2 - вернуть вещь" +
                              "\n |3 - выход");
            int console_choise = int.Parse(Console.ReadLine());
            while (in_debug)
            {
                switch (console_choise)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        prev_choise = true;
                        Console.WriteLine("сумма: ");
                        console_choise = int.Parse(Console.ReadLine());
                        sum += console_choise;
                        System.Threading.Thread.Sleep(500);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"|ваша сумма {sum}");
                        Console.WriteLine("|Введите действие: ");
                        console_choise = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                        break;

                    case 2:
                        prev_choise = true;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        string actions = "|что хотите вернуть? " +
                                "\n|1 - Дом " +
                                "\n|2 - Машину " +
                                "\n|3 - Друга " +
                                "\n|4 - Все предметы ";
                        Console.WriteLine(actions);
                        console_choise = int.Parse(Console.ReadLine());

                        switch (console_choise)
                        {
                            case 1:
                                dom = true;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("|вы вернули дом|");
                                System.Threading.Thread.Sleep(500);
                                break;

                            case 2:
                                prev_choise = true;
                                car = true;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("|вы вернули машину|");
                                System.Threading.Thread.Sleep(500);
                                break;

                            case 3:
                                prev_choise = true;
                                friend = true;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("|вы вернули друга");
                                System.Threading.Thread.Sleep(500);
                                break;

                            case 4:
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                prev_choise = true;
                                dom = true;
                                friend = true;
                                car = true;
                                System.Threading.Thread.Sleep(500);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("|такого действия нет|\n|введите цифру для того или иного действия|");
                                Console.ResetColor();
                                choise = Console.ReadLine();
                                return;
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"|ваша сумма {sum}");
                        Console.WriteLine("|Введите действие: ");
                        console_choise = int.Parse(Console.ReadLine());
                        Console.WriteLine(actions);
                        break;

                    case 3:
                        in_debug = false;
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
