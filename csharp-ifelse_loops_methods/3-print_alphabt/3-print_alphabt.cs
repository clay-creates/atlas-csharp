﻿using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (c == 'q' || c == 'e')
                {
                    continue;
                }
                Console.Write(c);
            }
        }
    }
}
