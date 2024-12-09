namespace Game_club
{
    internal class Program
    {
        static void Greeting()
        {
            Console.WriteLine("|вас приветствует игровой клуб [ПРИДУМАТЬ ИМЯ]|");
            Thread.Sleep(1200);
            Console.WriteLine("|во что проиграешь?\n |1 - казино \n |2 - русская рулетка \n |3 - выход\n");
            var choise = Console.ReadLine();
            if(choise == "1")
            {
                Thread.Sleep(1200);
                Console.WriteLine("|добро пожаловать в казино|");
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