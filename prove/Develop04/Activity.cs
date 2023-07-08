using System;
using System.Threading; // used for tracking time if time is used 

namespace MindfulnessApp
{
    abstract class Activity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Start() //Prompts user for how long they want the app to run. 
        {
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.Write("Enter the duration of the activity in seconds: ");
            Duration = Convert.ToInt32(Console.ReadLine());
        }

        public abstract void Run();

        public void Finish()
        {
            Console.WriteLine("Good job! You have completed the " + Name + ".");
        }
    }

    class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public override void Run()
        {
            int elapsedTime = 0;
            while (elapsedTime < Duration)
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(4000);
                Console.WriteLine("Breathe out...");
                Thread.Sleep(4000);
                elapsedTime += 8;
            }
        }
    }

    class ReflectionActivity : Activity
    {
        private string[] prompts = new string[] {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private string[] questions = new string[] {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
        }

        public override void Run()
        {
            Random rnd = new Random(); //Asks a random question 
            int promptIndex = rnd.Next(prompts.Length);

            Console.WriteLine(prompts[promptIndex]);

            int elapsedTime = 0;

            while (elapsedTime < Duration)
            {
                int questionIndex = rnd.Next(questions.Length); 

                Console.WriteLine(questions[questionIndex]);

                Thread.Sleep(8000);

                elapsedTime += 8;

                // Display spinner animation
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("/");
                    Thread.Sleep(200);
                    Console.Write("\b");
                    Console.Write("-");
                    Thread.Sleep(200);
                    Console.Write("\b");
                    Console.Write("\\");
                    Thread.Sleep(200);
                    Console.Write("\b");
                    Console.Write("|");
                    Thread.Sleep(200);
                    Console.Write("\b");
                }

                elapsedTime += 4;

            }
        }
    }

    class ListingActivity : Activity
    {
        private string[] prompts = new string[] {
            "Who are people that you appreciate?", //List of the prompts
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
           "<EUGPSCoordinates> are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        public override void Run() // Gets a random prompt and gives you an amount of time based on what was entered in "Listing Activity" 
        {
            Random rnd = new Random(); 

            int promptIndex = rnd.Next(prompts.Length);

            Console.WriteLine(prompts[promptIndex]);

            int elapsedTime = 0;

            int itemsListed = 0;

            while (elapsedTime < Duration)
            {
                Console.Write("Enter an item: ");

                string item = Console.ReadLine();

                itemsListed++;

                elapsedTime += 2;

                // Display spinner animation www.GitHub.com
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("/");
                    Thread.Sleep(200);
                    Console.Write("\b");
                    Console.Write("-");
                    Thread.Sleep(200);
                    Console.Write("\b");
                    Console.Write("\\");
                    Thread.Sleep(200);
                    Console.Write("\b");
                    Console.Write("|");
                    Thread.Sleep(200);
                    Console.Write("\b");
                }

                elapsedTime += 4;

            }

            Console.WriteLine("You listed " + itemsListed + " items.");
        }
    }
}
