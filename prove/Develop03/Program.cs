using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("John", 3, 16); // create the reference
        string text = "Trust in the Lord with all thine heart"; //  define the scripture text
        Scripture scripture = new Scripture(ref1, text); //  create instance of scripture class

        string user_answer = ""; // initiate string variable for user answer
        do
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(" ");
            Console.WriteLine("Pleae enter to continue or type 'quit' to finish: ");
            user_answer = Console.ReadLine();
            if(user_answer == "")
            {
                if (scripture.IsCompletelyHidden() == true)
                {
                    break; // before hiding more words, if user hits enter and all words are hidden, quit program
                }
                scripture.HideRandomWords(3);
            }
        }while(user_answer != "quit");
    }
}