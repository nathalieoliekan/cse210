using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        int a_var = 90;
        int b_var = 80;
        int c_var = 70;
        int d_var = 60;

        string letter = "";

        if (percent >= a_var)
        {
            letter = "A";
        }
        else if (percent >= b_var)
        {
            letter = "B";
        }
        else if (percent >= c_var)
        {
            letter = "C";
        }
        else if (percent >= d_var)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= c_var)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}