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
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}
