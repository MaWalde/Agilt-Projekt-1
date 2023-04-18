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
                    else if (y == 10 && x == 25) Console.Write(">");
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

            List<List<string>> list = new List<List<string>>();
            string[] arr1 = { "Score", "Namn", "Date" };
            string[] arr2 = { "123", "Något", DateTime.Now.ToString("yyyy-MM-dd HH:mm") };
            string[] arr3 = { "321", "Togån", new DateTime(2008, 11, 1, 12, 11, 03).ToString("yyyy-MM-dd HH:mm") };
            list.Add(arr1.ToList());
            list.Add(arr2.ToList());
            list.Add(arr3.ToList());

            Console.WriteLine();

            int spacing = 3;

            int[] maxColumnWidths = CulcColumnWidths(list);
            foreach (List<string> str in list)
            {
                for (int i = 0; i < str.Count; i++)
                {
                    Console.Write("{0, -" + (maxColumnWidths[i] + spacing) + "}", str[i]);
                }
                Console.WriteLine();
            }
        }

        static int[] CulcColumnWidths(List<List<string>> table)
        {
            int[] maxColumnWidths = new int[table[0].Count];

            foreach (List<string> row in table)
            {
                for (int i = 0; i < row.Count; i++)
                {
                    int columnWidth = row[i].Length;
                    if (columnWidth > maxColumnWidths[i])
                    {
                        maxColumnWidths[i] = columnWidth;
                    }
                }
            }
            return maxColumnWidths;
        }
    }
}