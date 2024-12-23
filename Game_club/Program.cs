namespace Game_club
{
    internal class Program
    {
        public static void Main()
        {
            Greeting();
        }

        static void Greeting()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|вас приветствует игровой клуб NE_OBMAN_GAMES|");
            Thread.Sleep(1200);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|во что проиграешь?" +
                              "\n|1 - казино " +
                              "\n|2 - русская рулетка " +
                              "\n|3 - камень ножницы бумага" +
                              "\n|4 - выход\n");
            var choise = Console.ReadLine();
            while (true)
            {
                switch (choise)
                {
                    case "1":
                        Console.Clear();
                        Thread.Sleep(1200);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("|!ДОБРО ПОЖАЛОВАТЬ В КАЗИНО!|");
                        Console.ResetColor();
                        Thread.Sleep(1200);
                        Casino.Logic();
                        break;

                    case "2":
                        RusRoulette.Launch();
                        break;

                    case "3":
                        Rock_paper_scissors_Class.Rock_paper_scissors();
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Пока");
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("|нет такого действия|");
                        Console.ResetColor();
                        Console.WriteLine("|введите действие: ");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}