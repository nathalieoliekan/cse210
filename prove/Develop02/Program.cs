using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal(); // create a new instance of the Journal Class
        Console.WriteLine("Welcome to the Journal Program!"); // Display Welcome Message
        string user_choice = ""; // Define a new variable called userchoice

        void menu() // Create a menu for the user as a void method
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
        }

        do // start a do-while loop that runs until the user selects "5. Quit"
        {
            menu(); // display men
            user_choice = Console.ReadLine(); // read user input
            if (user_choice == "1") // if user selects write in journal
            {
                Entry anEntry = new Entry();
                PromptGenerator aPrompt = new PromptGenerator(); // Create new instance of Prompt
                anEntry._promptText = aPrompt.GetRandomPrompt(); // call getrandomprompt method to give a prompt - save as Entry Prompt Variable
                Console.WriteLine(anEntry._promptText); // write prompt to console
                anEntry._entryText = Console.ReadLine(); // read user text - save as Entry Entrytext variable
                DateTime theCurrentTime = DateTime.Now; // get datetime
                anEntry._date = theCurrentTime.ToShortDateString(); // save as Entry date variable
                theJournal.AddEntry(anEntry); 
            }
            else if (user_choice == "2") // if user selects Display Journal
            {
                theJournal.DisplayAll();
            }
            else if (user_choice == "3") // if user selects Save
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine(); // Read filename
                theJournal.SaveToFile(filename);
            }
            else if (user_choice == "4") // if user selects Read from File
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine(); // Read filename
                theJournal.LoadFromFile(filename);
            }
            else
            {
                Console.WriteLine("Please select a valid option: ");
                continue;
            }

        }while (user_choice != "5"); // Quit the program
    }
}

// Exceeds Requirements. I added more questions to the prompt generator. I also added
// an "else" option in the main code loop to force the user to select one of the options
// provided (1-5), until they make a correct entry. 
//I also wanted to add something that would not allow the same prompt mulitple 
// times on the same day, but could not figure out how to get it working properly. 