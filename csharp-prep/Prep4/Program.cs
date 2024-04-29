using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        do
        {
            Console.WriteLine("Enter number (0 to quit): ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            } 
        } while (number != 0);

        int sum = 0;
        int largest = 0;
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }

        }

        float ave = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {ave}");
        Console.WriteLine($"The largest number is {largest}");
    }
}