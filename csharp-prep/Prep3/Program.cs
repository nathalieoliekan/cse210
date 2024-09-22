using System;

class Program
{
    static void Main(string[] args)
    {
         Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        do 
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);
    }
}