using System;

namespace _10_print_line
{
    public class Line
    {
        public static void PrintLine(int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (length <= 0)
                {
                    Console.WriteLine();
                    return;
                }
                Console.Write("_");
            }
        }
    }
}
