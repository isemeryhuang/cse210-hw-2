using System;


namespace DJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
                "What happened today?",
                "What was the best thing that happened today?",
                "What was the worst thing that happened today?",
                "What was the most interesting thing I saw or heard today?",
                "What was the most challenging thing I faced today?",
                "What am I grateful for today?",
                "What did I learn today?",
                "What was the most fun thing I did today?",
                "What was the most surprising thing that happened today?",
                "What did I do today that I am proud of?",

            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("Welcome to Journal Program! ");
                Console.WriteLine("Please Choose one from below:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("Choose what you would like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = RandomPrompt(prompts);
                        journal.AddChoose(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveFile();
                        break;
                    case "4":
                        journal.LoadFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("See you soon, keep on making the memories!");
        }

        static string RandomPrompt(List<string> prompts) // Where users can get a rendom questions 
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}