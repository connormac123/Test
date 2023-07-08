using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness App!"); //Menu
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            int choice = Convert.ToInt32(Console.ReadLine());

            Activity activity = null;

            if (choice == 1) //Lists and runs all of the tasks here based on the choice givin. 
            {
                activity = new BreathingActivity();
            }
            else if (choice == 2)
            {
                activity = new ReflectionActivity();
            }
            else if (choice == 3)
            {
                activity = new ListingActivity();
            }

            if (activity != null)
            {
                activity.Start();
                activity.Run();
                activity.Finish();
            }
        }
    }
}
