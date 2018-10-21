using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSearch
{
    class ProgramSearch
    {
        static void Main(string[] args)
        { 
            int count;

            Console.WriteLine("Array:");
            int[] arr = Console.ReadLine().Trim().Split().Select(w => int.Parse(w)).ToArray();

            Console.WriteLine("Find an item:");
            int search = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the way of searching: \r\n 0 - Linear search \r\n 1 - Binary search");
            int search_variant = int.Parse(Console.ReadLine());

            switch (search_variant)
            {
                case 0: 
                    {
                        int? index = Search(arr, search, out count);
                        string s = index == null ? "Item not found " + count : "Item " + search + " found at " + (index + 1) + " place in " + count + " steps";

                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                    break;

                case 1: 
                    {
                        int? index = BinarySearch(arr, search, out count);
                        string s = index == null ? "item not found " + count : "Item " + search + " found at " + (index + 1) + " place in " + count + " steps";

                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("The character inserted does not match the given search methods.");
                        Console.ReadKey();
                    }
                    break;
            }
        }

        private static int? Search(int[] a, int x, out int count)
        {
            count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                count++;
                if (a[i] == x)
                {
                    return i;
                }
            }
            return null;
        }

        private static int? BinarySearch(int[] a, int x, out int count)
        {
            count = 0;
            if ((a.Length == 0) || (x < a[0]) || (x > a[a.Length - 1]))
                return null;

            int first = 0;
            int last = a.Length - 1;

            while (first <= last)
            {
                int mid = (last + first) / 2;

                count++;
                if (x < a[mid])
                    last = mid - 1;
                else
                if (x > a[mid])
                    first = mid + 1;
                else
                    return mid;
            }

            if (a[last] == x)
                return last;
            else
                return null;
        }
    }
}
