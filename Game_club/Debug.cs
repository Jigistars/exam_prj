using Game_club;
using System;
using System.Threading;

public static class DebugClass
{
    public static void Debug(ref int sum, ref bool prev_choise, ref bool exit_y_n, ref bool friend, ref bool dom, ref bool car, ref string choise)
    {
        Console.Clear();
        bool there = true;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("|opening debug...|");
        Thread.Sleep(1200);
        Console.WriteLine("|выберите действие:" +
                          "\n |1 - пополнить баланс" +
                          "\n |2 - вернуть вещь" +
                          "\n |3 - выход");
        int console_choise = int.Parse(Console.ReadLine());
        while (there)
        {
            switch (console_choise)
            {
                case 1:
                    prev_choise = true;
                    Console.WriteLine("сумма: ");
                    console_choise = int.Parse(Console.ReadLine());
                    sum += console_choise;
                    Thread.Sleep(500);
                    Console.WriteLine($"|ваша сумма {sum}");
                    Console.WriteLine("|Введите действие: ");
                    choise = Console.ReadLine();
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

                    switch (console_choise)
                    {
                        case 1:
                            dom = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("|вы вернули дом|");
                            Thread.Sleep(500);
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
                            Thread.Sleep(500);
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
                            Thread.Sleep(500);
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
                            Thread.Sleep(500);
                            Console.WriteLine($"|ваша сумма {sum}");
                            Console.ResetColor();
                            Console.WriteLine("|Введите действие: ");
                            choise = Console.ReadLine();
                            break;
                    }
                    break;

                case 3:
                    there = false;
                    break;
            }
            Casino.Logic();
        }

    }
}
