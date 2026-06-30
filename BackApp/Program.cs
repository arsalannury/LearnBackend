// Hang Man Game

namespace BackApp
{
    internal class Program
    {
        static string[] _wordsToGuess = new string[] { "America", "Visual", "Tehran", "Stomatch", "Notebook", "NewsPaper", "Monitor" };
        static string _appStarterTitle = "Welcome to the hangMan game!. we will select a word and we will tell you the first letter, what should you do?" +
            "you only need to guess other charachters one after one until the word be complete! Good Luck my friend ";

        static string randomWord;
        static List<string> guessedWordChars = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine(_appStarterTitle);
            Console.WriteLine("Please press Enter to start the game");

            ConsoleKeyInfo currentKey = Console.ReadKey();

            if (currentKey.Key == ConsoleKey.Enter)
            {
                while (true)
                {

                    Random randomIndex = new Random();
                    randomWord = _wordsToGuess[randomIndex.Next(0, _wordsToGuess.Length)];
                    guessedWordChars.Add(randomWord[0].ToString());

                    Console.WriteLine($"The first letter of what you must guess is {randomWord[0]}");
                    Console.WriteLine("Start to guess then you will win the match !!!");
                    Console.WriteLine("");

                    while (true)
                    {

                        string userInput = Console.ReadLine() ?? string.Empty;
                        bool calculateCondtionBaseLetters = char.Parse(userInput) == (guessedWordChars.Count == 1 ? randomWord[1] : randomWord[guessedWordChars.Count]);

                        if (userInput.Replace(" ", "").Length == 1 && calculateCondtionBaseLetters)
                        {

                            guessedWordChars.Add(userInput.Replace(" ", "").ToUpper());
                            bool isWordCompleted = string.Join("", guessedWordChars).Length == randomWord.Length;

                            Console.WriteLine($"{string.Join("", guessedWordChars).Length} - {string.Join("", guessedWordChars)}");
                            Console.WriteLine($"{randomWord.Length} - {randomWord}");

                            if (isWordCompleted)
                            {
                                Console.WriteLine($"Congradulation User ! you won , the complete word is - {randomWord} -");
                                guessedWordChars.Clear();
                                break;

                            }

                            Console.WriteLine("Good Job! let's guess another word :)");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Something Went Wrong !!");
                            guessedWordChars.Clear();
                            break;
                        }

                    }
                }

            }

        }

    }
}