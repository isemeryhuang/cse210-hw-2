using System;

namespace DJ
{
    class Journal
    {
        public List<Choose> entries;

        public Journal()
        {
            entries = new List<Choose>();
        }

        public void AddChoose(string prompt)
        {
            Console.Write(prompt + " ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            entries.Add(new Choose(prompt, response, date));
        }

        public void DisplayEntries()
        {
            foreach (Choose entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
        public void SaveFile()
        {
            Console.Write("Enter Filename: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename)) 
            {
                writer.WriteLine("Date,Prompt,Response");

                foreach (Choose entry in entries) // It create the file name and save it
                {
                    writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt().Replace(",", ",,")},{entry.GetResponse().Replace(",", ",,")}");
                }
            }

            Console.WriteLine("Saving...");
        }

        public void LoadFile()
        {
            Console.Write("Enter your filename: ");
            string filename = Console.ReadLine();
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string headerLine = reader.ReadLine();

                while (!reader.EndOfStream) // It load the saved files from data
                {
                    string entryLine = reader.ReadLine();
                    string[] fields = entryLine.Split(',');

                    string date = fields[0];
                    string prompt = fields[1].Replace(",,", ",");
                    string response = fields[2].Replace(",,", ",");

                    entries.Add(new Choose(prompt, response, date));
                }
            }

            Console.WriteLine("Loading...");
        }
    }
}
