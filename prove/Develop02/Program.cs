using System;
using System.Collections.Generic;
using System.IO;  //Used for "StreamReader and StreamWriter" 

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); //Making journal object

        while (true)
        { // menu 
            Console.WriteLine("1. Add entry"); 
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Delete file");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
          
            switch (choice)
            {
                case "1":
                    // List of prompts
                    List<string> prompts = new List<string>();
                    prompts.Add("Who was the most interesting person I interacted with today?");
                    prompts.Add("What was the best part of my day?");
                    prompts.Add("How did I see the hand of the Lord in my life today?");
                    prompts.Add("What was the strongest emotion I felt today?");
                    prompts.Add("If I had one thing I could do over today, what would it be?");

                    // Show a random prompt and get user response
                    Random random = new Random();
                    int index = random.Next(prompts.Count);
                    string prompt = prompts[index];
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    // Add entry to journal
                    journal.AddEntry(prompt, response);
                    break;

                case "2":
                    // Display all entries in journal
                    journal.DisplayEntries();
                    break;

                case "3":
                    // Save journal to file
                    Console.Write("Enter filename to save journal: ");
                    string filenameToSaveJournalTo = Console.ReadLine();
                    journal.SaveToFile(filenameToSaveJournalTo);
                    break;

                case "4":
                    // Load journal from file
                    Console.Write("Enter filename to load journal from: ");
                    string filenameToLoadJournalFrom = Console.ReadLine();
                    journal.LoadFromFile(filenameToLoadJournalFrom);
                    break;
               
                case "5":
                    // Delete file
                    Console.Write("Enter filename to delete: ");
                    string filenameToDelete = Console.ReadLine();
                    File.Delete(filenameToDelete);
                    break;

                case "6":
                    // Exit the program
                    return;
            }

            Console.WriteLine();
        }
    }
}