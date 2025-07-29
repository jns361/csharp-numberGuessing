namespace numberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string play = "yes";
            while (play == "yes")
            {
                Console.WriteLine("\nWelcome! Choose your difficulty" +
                    "But remember: Only a max. of 10 tries no matter your choice!");

                Console.WriteLine("\n1 - Easy -> Numbers 1 - 50");
                Console.WriteLine("2 - Medium -> Numbers 1 - 150");
                Console.WriteLine("3 - Hard -> Numbers 1 - 400");
                Console.WriteLine("4 - Literally Impossible -> Numbers 1 - 1.000.000\n");
                
                int difficultySelect = int.Parse(Console.ReadLine());

                if (difficultySelect == 1) 
                {
                    play = playEasy();
                }
                if (difficultySelect == 2)
                {
                    play = playMedium();
                }
                if (difficultySelect == 3)
                {
                    play = playHard();
                }
                if (difficultySelect == 4)
                {
                    play = playImpossible();
                }


            }
        }

        static string GameLoop(int GameNumber, string difficulty)
        {
            int tries = 0;
            Console.WriteLine($"You've chosen {difficulty}! Let's start now.\n");
            var userInput = 0;
            while (userInput != GameNumber)
            {
                tries += 1;
                if (tries == 10)
                {
                    Console.WriteLine("Last guess now!");
                }

                Console.Write("\nTake a guess: ");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < GameNumber)
                {
                    Console.WriteLine("Your guess is lower than the number we are looking for!");
                }
                else if (userInput > GameNumber)
                {
                    Console.WriteLine("Your guess is higher than the number we are looking for!");
                }
                else if (userInput == GameNumber)
                {
                    Console.WriteLine("You've guessed correctly! Nicely done!");
                }

                if (tries > 10) 
                {
                    Console.WriteLine("All tries used! \nPress Enter to continue");
                    userInput = GameNumber;           
                    Console.ReadLine();
                }

            }

            Console.WriteLine("Wanna play again? (yes/no)");
            string playUpdate = Console.ReadLine();
            while (playUpdate != "yes" &&  playUpdate != "no")
            {
                Console.WriteLine("Wanna play again? (yes/no)");
                playUpdate = Console.ReadLine();
            }

            return playUpdate;
        }

        static string playEasy()
        {
            var difficulty = "Easy";
            Random generator = new Random();
            var GameNumber = generator.Next(1, 50);
            string playUpdate = GameLoop(GameNumber, difficulty);



            return playUpdate;
        }
        static string playMedium()
        {
            var difficulty = "Medium";
            Random generator = new Random();
            var GameNumber = generator.Next(1, 150);
            string playUpdate = GameLoop(GameNumber, difficulty);



            return playUpdate;
        }
        static string playHard()
        {
            var difficulty = "Hard";
            Random generator = new Random();
            var GameNumber = generator.Next(1, 400);
            string playUpdate = GameLoop(GameNumber, difficulty);



            return playUpdate;
        }
        static string playImpossible()
        {
            var difficulty = "Impossible";
            Random generator = new Random();
            var GameNumber = generator.Next(1, 1000000);
            string playUpdate = GameLoop(GameNumber, difficulty);



            return playUpdate;
        }
    }
}
