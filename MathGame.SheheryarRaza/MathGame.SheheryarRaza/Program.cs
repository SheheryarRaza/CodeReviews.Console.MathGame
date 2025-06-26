

using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;




public class GameRecord
{
    public DateTime DatePlayed { get; set; }
    public int Score { get; set; }
    public string GameType { get; set; }
    public TimeSpan Duration { get; set; }
}
public class Game
{
    private static List<GameRecord> gameHistory = new List<GameRecord>();

    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Math Game!");

        while (true)
        {
            Console.WriteLine("Welcome to the Math Game!");
            Console.WriteLine("Choose a game mode:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Play A Random Game");
            Console.WriteLine("6. View Record");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();
            Console.WriteLine("\nChoose a game mode");
            bool shouldExit = HandleUserChoice(choice);

            if (shouldExit)
            {
                break; // Exit the game loop
            }

        }

    }

    private static bool HandleUserChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                PlayAdditionGame();
                return false;
            case "2":
                PlaySubtractionGame();
                return false;
            case "3":
                PlayMultiplicationGame();
                return false;
            case "4":
                PlayDivisionGame();
                return false;
            case "5":
                Random random = new Random();
                random.Next(1, 5);
                switch (random.Next(1, 5))
                {
                    case 1:
                        PlayAdditionGame();
                        break;
                    case 2:
                        PlaySubtractionGame();
                        break;
                    case 3:
                        PlayMultiplicationGame();
                        break;
                    case 4:
                        PlayDivisionGame();
                        break;
                }
                return false;
            case "6":
                DisplayGameHistory();
                return false;
            case "7":
                Console.WriteLine("Thanks for playing!");
                return true;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                return false;
        }
    }

    private static void PlayDivisionGame()
    {
        Random random = new Random();

        int score = 0;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Division Game \n");

            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);
            int dividend = number1;
            int divisor = number2;
            do
            {
                number1 = random.Next(1, 100);
                number2 = random.Next(1, 100);

                if (number1 % number2 == 0 && number2 != 0)
                {
                    dividend = number1;
                    divisor = number2;
                }
                else if (number2 % number1 == 0 && number1 != 0)
                {
                    dividend = number2;
                    divisor = number1;
                }
                else
                {

                    continue;
                }

            } while (divisor == 1 || dividend % divisor != 0 || divisor == 0);

            Console.WriteLine($"What is {dividend} divided by {divisor}?");

            var answer = Console.ReadLine();
            if (int.TryParse(answer, out int userAnswer))
            {
                if (userAnswer == dividend / divisor)
                {
                    Console.WriteLine("Your answer is Correct!");
                    score ++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer was {dividend / divisor}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("Press 'q' to quit or any other key to continue.");
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                stopwatch.Stop();

                gameHistory.Add(new GameRecord
                {
                    DatePlayed = DateTime.Now,
                    Score = score,
                    GameType = "Division",
                    Duration = stopwatch.Elapsed

                });
                Console.Clear();
                break;
            }
        }
    }

    private static void PlayMultiplicationGame()
    {
        Random random = new Random();

        int score = 0;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Multiplication Game \n");
            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);

            Console.WriteLine($"What is {number1} Multiplied with {number2}?");
            var answer = Console.ReadLine();
            if (int.TryParse(answer, out int userAnswer))
            {
                if (userAnswer == number1 * number2)
                {
                    Console.WriteLine("Your answer is Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer was {number1 * number2}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("Press 'q' to quit or any other key to continue.");
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                stopwatch.Stop();
                gameHistory.Add(new GameRecord
                {
                    DatePlayed = DateTime.Now,
                    Score = score,
                    GameType = "Multiplication",
                    Duration = stopwatch.Elapsed
                });
                Console.Clear();
                break;
            }
        }
    }

    private static void PlaySubtractionGame()
    {

        Random random = new Random();

        int score = 0;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Subtraction Game \n");

            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);

            Console.WriteLine($"What is {number1} subtracted from {number2}?");
            var answer = Console.ReadLine();
            if (int.TryParse(answer, out int userAnswer))
            {
                if (userAnswer == number1 - number2)
                {
                    Console.WriteLine("Your answer is Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer was {number1 - number2}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("Press 'q' to quit or any other key to continue.");
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                stopwatch.Stop();
                gameHistory.Add(new GameRecord
                {
                    DatePlayed = DateTime.Now,
                    Score = score,
                    GameType = "Subtraction",
                    Duration = stopwatch.Elapsed
                });
                Console.Clear();
                break;
            }
        }
    }

    private static void PlayAdditionGame()
    {

        Random random = new Random();

        int score = 0;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Addition Game \n");
            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);

            Console.WriteLine($"What is {number1} added into {number2}?");
            var answer = Console.ReadLine();
            if (int.TryParse(answer, out int userAnswer))
            {
                if (userAnswer == number1 + number2)
                {
                    Console.WriteLine("Your answer is Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer was {number1 + number2}. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("Press 'q' to quit or any other key to continue.");
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                stopwatch.Stop();
                gameHistory.Add(new GameRecord
                {
                    DatePlayed = DateTime.Now,
                    Score = score,
                    GameType = "Addition",
                    Duration = stopwatch.Elapsed
                });

                Console.Clear();
                break;
            }
        }
    }

    public static void DisplayGameHistory()
    {
        Console.Clear();
        Console.WriteLine("\n--- Game History ---");

        if (!gameHistory.Any())
        {
            Console.WriteLine("No games played yet. Go play some math games!");
            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine($"You have played {gameHistory.Count} game sessions.\n");

        foreach (var record in gameHistory)
        {
            Console.WriteLine($"Date: {record.DatePlayed}");
            Console.WriteLine($"Game Type: {record.GameType}");
            Console.WriteLine($"Score: {record.Score} correct answers");
            Console.WriteLine($"Duration: {record.Duration.Minutes:00}:{record.Duration.Seconds:00}");
            Console.WriteLine("--------------------");
        }

        Console.WriteLine("\nPress any key to return to the main menu.");
        Console.ReadKey();
        Console.Clear();

    }
}

