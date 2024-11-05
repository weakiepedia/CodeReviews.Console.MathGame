namespace MathGame;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> previousGames = new();
        Random random = new Random();
        string userInput = "";
        int gameNumber = 0;
        int score = 0;
        string checkAnswer = "";
        string currentGameInfo = "";
        string difficulty = "";
        int maxValue = 0;

        while (true)
        {
            ShowMenu();
            do
            {
                userInput = Console.ReadLine();
                Console.WriteLine();
                switch (userInput)
                {
                    case "1":
                        AdditionGame();
                        break;
                    case "2":
                        SubtractionGame();
                        break;
                    case "3":
                        MultiplicationGame();
                        break;
                    case "4":
                        DivisionGame();
                        break;
                    case "5":
                        Console.Clear();
                        foreach (string game in previousGames)
                        {
                            Console.WriteLine(game + "\n");
                        }
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "6":
                        break;
                }
            } while (userInput == "");
        }

        void ShowMenu()
        {
            Console.WriteLine("Welcome to the math game!" +
                "\n 1. Addition" +
                "\n 2. Subtraction" +
                "\n 3. Multiplication" +
                "\n 4. Division" +
                "\n 5. Show previous games" +
                "\n " +
                "\n 6. QUIT \n");
        }

        void AdditionGame()
        {
            ChooseDifficulty();
            gameNumber++;
            Console.Clear();
            Console.WriteLine("Starting the addition game, have fun! :)");
            score = 0;
            currentGameInfo = "";
            for (int i = 0; i < 10; i++)
            {
                userInput = "";
                int firstNumber = random.Next(1, maxValue);
                int secondNumber = random.Next(1, maxValue);
                Console.Write($"{firstNumber} + {secondNumber} = ");
                do
                {
                    userInput = Console.ReadLine();
                    try
                    {
                        int userAnswer = Convert.ToInt32(userInput);
                        if (userAnswer == (firstNumber + secondNumber))
                        {
                            score++;
                            checkAnswer = "good";
                        }
                        else
                        {
                            checkAnswer = "wrong";
                        }
                        currentGameInfo += $"{i + 1}: {firstNumber} + {secondNumber} = {userAnswer} ({checkAnswer})\n"; ;
                    }
                    catch
                    {
                        Console.Write("Wrong input! type a number: ");
                    }
                } while (userInput == "");
            }
            currentGameInfo += $"Score: {score}/10";
            Console.WriteLine();
            Console.WriteLine(currentGameInfo);
            Console.WriteLine();
            previousGames.Add($"GAME #{gameNumber} DIFFICULTY: {difficulty} (ADDITION):\n{currentGameInfo}");
        }

        void SubtractionGame()
        {
            ChooseDifficulty();
            gameNumber++;
            Console.Clear();
            Console.WriteLine("Starting the subtraction game, have fun! :)");
            score = 0;
            currentGameInfo = "";
            for (int i = 0; i < 10; i++)
            {
                userInput = "";
                int firstNumber = random.Next(1, maxValue);
                int secondNumber = random.Next(1, maxValue);
                Console.Write($"{firstNumber} - {secondNumber} = ");
                do
                {
                    userInput = Console.ReadLine();
                    try
                    {
                        int userAnswer = Convert.ToInt32(userInput);
                        if (userAnswer == (firstNumber - secondNumber))
                        {
                            score++;
                            checkAnswer = "good";
                        }
                        else
                        {
                            checkAnswer = "wrong";
                        }
                        currentGameInfo += $"{i + 1}: {firstNumber} - {secondNumber} = {userAnswer} ({checkAnswer})\n"; ;
                    }
                    catch
                    {
                        Console.Write("Wrong input! type a number: ");
                    }
                } while (userInput == "");
            }
            currentGameInfo += $"Score: {score}/10";
            Console.WriteLine();
            Console.WriteLine(currentGameInfo);
            Console.WriteLine();
            previousGames.Add($"GAME #{gameNumber} DIFFICULTY: {difficulty} (SUBTRACTION):\n{currentGameInfo}");


        }

        void MultiplicationGame()
        {
            ChooseDifficulty();
            gameNumber++;
            Console.Clear();
            Console.WriteLine("Starting the multiplication game, have fun! :)");
            score = 0;
            currentGameInfo = "";
            for (int i = 0; i < 10; i++)
            {
                userInput = "";
                int firstNumber = random.Next(1, maxValue);
                int secondNumber = random.Next(1, maxValue);
                Console.Write($"{firstNumber} * {secondNumber} = ");
                do
                {
                    userInput = Console.ReadLine();
                    try
                    {
                        int userAnswer = Convert.ToInt32(userInput);
                        if (userAnswer == (firstNumber * secondNumber))
                        {
                            score++;
                            checkAnswer = "good";
                        }
                        else
                        {
                            checkAnswer = "wrong";
                        }
                        currentGameInfo += $"{i + 1}: {firstNumber} * {secondNumber} = {userAnswer} ({checkAnswer})\n"; ;
                    }
                    catch
                    {
                        Console.Write("Wrong input! type a number: ");
                    }
                } while (userInput == "");
            }
            currentGameInfo += $"Score: {score}/10";
            Console.WriteLine();
            Console.WriteLine(currentGameInfo);
            Console.WriteLine();
            previousGames.Add($"GAME #{gameNumber} DIFFICULTY: {difficulty} (MULTIPLICATION):\n{currentGameInfo}");
        }

        void DivisionGame()
        {
            ChooseDifficulty();
            gameNumber++;
            Console.Clear();
            Console.WriteLine("Starting the division game, have fun! :)");
            score = 0;
            currentGameInfo = "";
            for (int i = 0; i < 10; i++)
            {
                userInput = "";
                int firstNumber = random.Next(1, maxValue);
                int secondNumber = random.Next(1, maxValue);
                while (firstNumber % secondNumber != 0)
                {
                    firstNumber = random.Next(1, maxValue);
                    secondNumber = random.Next(1, maxValue);
                }
                Console.Write($"{firstNumber} / {secondNumber} = ");
                do
                {
                    userInput = Console.ReadLine();
                    try
                    {
                        int userAnswer = Convert.ToInt32(userInput);
                        if (userAnswer == (firstNumber / secondNumber))
                        {
                            score++;
                            checkAnswer = "good";
                        }
                        else
                        {
                            checkAnswer = "wrong";
                        }
                        currentGameInfo += $"{i + 1}: {firstNumber} / {secondNumber} = {userAnswer} ({checkAnswer})\n"; ;
                    }
                    catch
                    {
                        Console.Write("Wrong input! type a number: ");
                    }
                } while (userInput == "");
            }
            currentGameInfo += $"Score: {score}/10";
            Console.WriteLine();
            Console.WriteLine(currentGameInfo);
            Console.WriteLine();
            previousGames.Add($"GAME #{gameNumber} DIFFICULTY: {difficulty} (DIVISION):\n{currentGameInfo}");
        }

        void ChooseDifficulty()
        {
            Console.WriteLine("Select difficulty:" +
                "\n1. Easy" +
                "\n2. Medium" +
                "\n3. Hard");
            do
            {
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        difficulty = "Easy";
                        maxValue = 19;
                        break;
                    case "2":
                        difficulty = "Medium";
                        maxValue = 99;
                        break;
                    case "3":
                        difficulty = "Hard";
                        maxValue = 499;
                        break;
                    default:
                        break;
                }
            } while (userInput == "" );
            Console.Clear();
        }
    }
}
