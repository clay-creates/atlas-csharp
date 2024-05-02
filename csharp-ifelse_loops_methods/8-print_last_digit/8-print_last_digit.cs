using System;

namespace _8_print_last_digit
{
    public class Number
    {
        public static int PrintLastDigit(int number)
        {
            int lastDigit = number % 10;
            return lastDigit;
        }
    }
}
