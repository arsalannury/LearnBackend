namespace BackApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hi friend! you can have a new llm in your devices. just pick one then pay it to activate");
                Console.WriteLine("");

                var packageOne = new LlmPlans();
                List<LLMs> llmList = packageOne.GetLlms("asc");

                for (int i = 0; i < llmList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {llmList[i].Name} - {llmList[i].Price} $");
                }

                string userInput = Console.ReadLine() ?? string.Empty;

                var isUserInputValidNumber = int.TryParse(userInput, out var parsedNumber);

                if (!isUserInputValidNumber && parsedNumber == 0)
                {
                    Console.WriteLine($"Please enter a valid number between 1 and {llmList.Count}");
                    continue;
                }

                Console.WriteLine($"you selected {llmList[parsedNumber].Name}, should pay {llmList[parsedNumber].Price}");
                Console.WriteLine("");
                Console.WriteLine("Tab Y if you are agree and want to pay. otherwise, tab N for restart application");

                ConsoleKeyInfo keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.WriteLine($"This is your bill key -> {new Random().NextInt64()}. Please open this url and complete your payment: kiir");
                    Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                }
                else if (keyPressed.Key == ConsoleKey.N)
                {
                    Console.Clear();

                }

            }
        }
    }


    class LlmPlans
    {
        LLMs _chatGpt = new LLMs("Chat GPT", 25);
        LLMs _claude = new LLMs("Claude", 28);
        LLMs _gemini = new LLMs("Gemini", 23);
        LLMs _grok = new LLMs("Grok", 32);
        LLMs _deepSeek = new LLMs("DeepSeek", 19);
        LLMs _noteBookLlm = new LLMs("Notebook LLM", 31);

        public List<LLMs> GetLlms(string order)
        {
            if (order != "asc" && order != "desc")
            {
                return [];
            }

            var result = order == "desc" ? AllModels().OrderByDescending(m => m.Price) : AllModels().OrderBy(m => m.Price);
            return result.ToList();
        }

        public List<LLMs> AllModels()
        {
            return new List<LLMs>
        {
            _chatGpt,
            _claude,
            _gemini,
            _grok,
            _deepSeek,
            _noteBookLlm
        };
        }

    }
    class LLMs
    {
        public string Name;
        public int Price;

        public LLMs(string name, int price)
        {
            Name = name;
            Price = price;
        }


        public string ToString()
        {
            return $"{Name} - {Price}";
        }

    }

}