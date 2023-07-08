using System;
using System.Collections.Generic;

namespace ScriptureMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Scripture> scriptures = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.")
            };

            Random random = new Random();
            Scripture scripture = scriptures[random.Next(scriptures.Count)]; // Picks a random scripture from what is provided above. 

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture);

                if (scripture.AllWordsHidden)
                {
                    break;
                }

                Console.Write("\nPress enter to hide a word or type 'quit' to exit: ");//Hides the words in the scriptures
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }

                scripture.HideRandomWord();
            }
        }
    }
}
