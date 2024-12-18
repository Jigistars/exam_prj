using System;

public static class ShopClass
{
    static Random random = new Random();

    public static void Shop(ref int sum, ref bool knife, ref bool gun, ref bool lottery_money, ref int chance_friend)
    {
        string choise;
        do
        {
            Console.WriteLine("|что купить?\n|1 - нож [10$]" +
                              "\n|2 - пистолет [150$]" +
                              "\n|3 - лотерейный билет [1000$]" +
                              "\n|4 - выход");
            choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    if (sum < 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("|не хватает средств|");
                        Console.ResetColor();
                    }
                    else
                    {
                        sum -= 10;
                        knife = false;
                        chance_friend = 4;
                    }
                    break;

                case "2":
                    if (sum < 150)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("|не хватает средств|");
                        Console.ResetColor();
                    }
                    else
                    {
                        sum -= 150;
                        gun = false;
                        chance_friend = 2;
                    }
                    break;

                case "3":
                    if (sum < 1000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("|не хватает средств|");
                        Console.ResetColor();
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

                case "4":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("|выход из магазина|");
                    Console.ResetColor();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("|такого действия нет|");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine($"|ваша сумма {sum}|");
        } while (choise != "4");
    }
}
