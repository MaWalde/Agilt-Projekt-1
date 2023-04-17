using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int y = 0; y < 25; y++)
            {
                for (int x = 0; x < 90; x++)
                {
                    if (y == 0 || y == 24 || x == 0 || x == 89)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write("X");
                    }
                    else if (y == 10 && x > 20 && x < 25)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write("#");
                    }
                    else
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                    }
                }
            }
        }

    }
}