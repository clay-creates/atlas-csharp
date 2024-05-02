﻿using System;

namespace _12_fizzbuzz
{
    public class FizzBuzz
    {
        public static FizzBuzz(int i)
        {
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write($"{i}");
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
