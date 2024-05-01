using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastDigit = Math.Abs(number) % 10;
        string condition;
        if (lastDigit > 5)
        {
            condition = "greater than 5";
        }
        else if (lastDigit == 0)
        {
            condition = "0";
        }
        else
        {
            condition = "less than 6 and not 0";
        }
        Console.WriteLine($"The last digit of {number} is {lastDigit} and is {condition}");
    }
}