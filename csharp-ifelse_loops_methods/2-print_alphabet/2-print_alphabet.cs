using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "abcdefghijklmnopqrstuvwxyz";
            foreach (char c in inputString)
            {
                Console.WriteLine($"{c}\n");
            }
        }
    }
}
