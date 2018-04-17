using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int cur = arr.Length - 1;
            int position = arr.Length - 1;
            ConsoleKey key;
            do
            {
                Console.Clear();
                foreach (var item in arr)
                {
                    Console.Write(item);
                }
                Console.SetCursorPosition(position, 0);
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(arr.Length, 0);
                        if (cur == 0)
                            position = cur;
                        position++;
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(arr.Length, 0);
                        position--;
                        break;
                    case ConsoleKey.UpArrow:
                        arr[position]--;
                        if (arr[position] == 0)
                            arr[position] = 9;
                        break;
                    case ConsoleKey.DownArrow:
                        arr[position]++;
                        if (arr[position] == 9)
                            arr[position] = 0;
                        break;
                }

            } while (key != ConsoleKey.Enter);
        }
    }
}
