using System;

namespace _11_print_diagonal
{
    public class Line
    {
        public static void PrintDiagonal(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write("\\");
            }
            Console.WriteLine();
        }
    }
}
