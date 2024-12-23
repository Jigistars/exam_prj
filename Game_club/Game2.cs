using Game_club;
using System;

class Rock_paper_scissors_Class
{
    public static void Rock_paper_scissors()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("|Выберите режим:");
            Console.WriteLine("|1 - Обычный режим");
            Console.WriteLine("|2 - Турнирный режим");
            Console.WriteLine("|3 - Выход");
            Console.Write("|Ваш выбор: ");
            int userChoice = int.Parse(Console.ReadLine());
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                PlayNormalMode();
            }
            else if (choice == "2")
            {
                PlayTournamentMode();
            }
            else if (choice == "3")
            {
                Program.Main();
            }
            else
            {
                Console.WriteLine("|Неверный выбор. Попробуйте еще раз|");
                Console.ReadLine();
            }
        }
    }

    static void PlayNormalMode()
    {
        Random random = new Random();
        string[] options = { "Камень", "Ножницы", "Бумага" };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("|Выберите: " +
                              "\n|1 - Камень, " +
                              "\n|2 - Ножницы, " +
                              "\n|3 - Бумага, " +
                              "\n|4 - Выход");
            Console.Write("Ваш выбор: ");

            string userInput = Console.ReadLine();

            if (userInput == "4")
            {
                break;
            }

            int userChoice;
            if (!int.TryParse(userInput, out userChoice) || userChoice < 1 || userChoice > 3)
            {
                Console.WriteLine("|Неверный выбор. Попробуйте еще раз|");
                Console.ReadLine();
                continue;
            }


            userChoice -= 1;

            int botChoice = random.Next(0, 3);
            Console.WriteLine($"|Вы выбрали: {options[userChoice]}|");
            Console.WriteLine($"|Бот выбрал: {options[botChoice]}|");

            if (userChoice == botChoice)
            {
                Console.WriteLine("|Ничья!|");
            }
            else if ((userChoice == 0 && botChoice == 1) ||
                     (userChoice == 1 && botChoice == 2) ||
                     (userChoice == 2 && botChoice == 0))
            {
                Console.WriteLine("|Вы выиграли!|");
            }
            else
            {
                Console.WriteLine("|Вы проиграли!|");
            }

            Console.WriteLine("|Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }

    static void PlayTournamentMode()
    {
        Random random = new Random();
        int playerScore = 0;
        int rank = 1;

        while (rank <= 2)
        {
            Console.Clear();
            string[] options = { "Камень", "Ножницы", "Бумага" };

            while (playerScore < 10)
            {
                Console.Clear();
                Console.WriteLine($"Текущий ранг: {rank}, Очки: {playerScore}/10");
                Console.WriteLine("Выберите: 1 - Камень, 2 - Ножницы, 3 - Бумага, 4 - Выход");
                Console.Write("Ваш выбор: ");

                string userInput = Console.ReadLine();

                if (userInput == "4")
                {
                    return;
                }

                int userChoice;
                if (!int.TryParse(userInput, out userChoice) || userChoice < 1 || userChoice > 3)
                {
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    Console.ReadLine();
                    continue;
                }
                userChoice -= 1;

                int botChoice = random.Next(0, 3);
                Console.WriteLine($"Вы выбрали: {options[userChoice]}");
                Console.WriteLine($"Бот выбрал: {options[botChoice]}");

                if (userChoice == botChoice)
                {
                    Console.WriteLine("Ничья!");
                }
                else if ((userChoice == 0 && botChoice == 1) ||
                         (userChoice == 1 && botChoice == 2) ||
                         (userChoice == 2 && botChoice == 0))
                {
                    int pointsEarned = random.Next(1, 4);
                    playerScore += pointsEarned;
                    Console.WriteLine($"Вы выиграли! Вы получили {pointsEarned} очков.");
                }
                else
                {
                    int pointsLost = random.Next(1, 3);
                    playerScore -= pointsLost;
                    playerScore = Math.Max(playerScore, 0);
                    Console.WriteLine($"Вы проиграли! Вы потеряли {pointsLost} очков.");
                }

                if (playerScore >= 10 && rank == 1)
                {
                    rank++;
                    playerScore = 0;
                    Console.WriteLine("Поздравляем! Вы перешли во второй ранг. Coming Soon!");
                    Console.ReadLine();
                }

                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }

            if (rank > 2)
            {
                Console.WriteLine("Вы стали чемпионом турнира!");
                break;
            }
        }
    }
}