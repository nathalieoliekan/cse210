using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select a mindfulness activity:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Seelct a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity(); // Create Instance of BreathingActivity
                    break;
                case "2":
                    activity = new ReflectionActivity(); // Create Instance of ReflectionActivity
                    break;
                case "3":
                    activity = new ListingActivity(); // Create Instance of ListingActivity
                    break;
                case "4":
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    continue; // Go back to the start of the loop
            }

            if (activity != null)
            {
                activity.Run(); // Call Run() on the selected activity
            }
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
    }
}
