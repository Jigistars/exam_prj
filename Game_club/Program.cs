namespace Game_club
{
    internal class Program
    {
       static int sum = 150;
        static void Greeting()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|вас приветствует игровой клуб [ПРИДУМАТЬ ИМЯ]|");
            Thread.Sleep(1200);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|во что проиграешь?" +
                              "\n|1 - казино " +
                              "\n|2 - русская рулетка " +
                              "\n|3 - выход\n");
            var choise = Console.ReadLine();
            if(choise == "1")
            {
                Thread.Sleep(1200);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("|!ДОБРО ПОЖАЛОВАТЬВ КАЗИНО!|");
                Console.ResetColor();
                Thread.Sleep(1200);
                Casino.Casino_Launch();
            }
            if(choise == "2")
            {
                RusRoulette.Launch();
            }
        }
         
        static void Main(string[] args)
        {
            Greeting();
        }
    }
}