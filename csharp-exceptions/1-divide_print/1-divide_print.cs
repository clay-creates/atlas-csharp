using System;
using System.Collections.Generic;

class Int
{
    public static void divide(int a, int b)
    {
        double result = 0;
        try
        {
            result = (double)a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero");
        }
        finally
        {
            if (a == 0 || b == 0)
            {
                result = 0;
                Console.WriteLine("Cannot divide by zero");
                Console.WriteLine($"{a} / {b} = {result}");
            }
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}
