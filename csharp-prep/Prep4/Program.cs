using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers_list = new List<int>();
        int number = 1; // Doesn't matter what number is as long as it is defined. Code will run at least once and get user input
        do
        {
            Console.Write("Enter a number (0 to quit): ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number != 0)
            {
                numbers_list.Add(number);
            }

        }while (number != 0);

        int sum = 0;
        foreach (int num in numbers_list)
        {
            sum += num; // add each item in list together to get sum
        }
        Console.WriteLine($"The sum is: {sum}");

        float total = sum; // convert sum to float for average calculation

        float average = total / numbers_list.Count; // Calculate the average
        Console.WriteLine($"The average is: {average}");

        int max = 0;
        foreach(int num in numbers_list)
        {
            if (num > max)
            {
                max = num; 
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}