using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSort
{
    class ProgramSort
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select option: \r\n 0 - InsertSort \r\n 1 - BinInsert \r\n 2 - ShellSort \r\n 3 - MergeSort \r\n 4 - QuickSort");
                int t = Convert.ToInt32(Console.ReadLine());
                switch (t)
                {
                    case 0:
                        ClassInsertSort inser;
                        Console.WriteLine("Select option: \r\n 0 - B(N) \r\n 1 - W(N) \r\n 2 - A(N) ");
                        int type = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Insert number of items:");
                        int count = Convert.ToInt32(Console.ReadLine());
                        switch (type)
                        {
                            case 0:
                                inser = new ClassInsertSort(count, 'B');
                                inser.Sort();
                                break;
                            case 1:
                                inser = new ClassInsertSort(count, 'W');
                                inser.Sort();
                                break;
                            case 2:
                                inser = new ClassInsertSort(count, 'A');
                                inser.Sort();
                                break;
                        }
                        Console.WriteLine(Environment.NewLine);
                        break;

                    case 1:
                        ClassBinInsertSort inserb;
                        Console.WriteLine("Select option: \r\n 0 - B(N) \r\n 1 - W(N) \r\n 2 - A(N) ");
                        type = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Insert number of items:");
                        count = Convert.ToInt32(Console.ReadLine());
                        switch (type)
                        {
                            case 0:
                                inserb = new ClassBinInsertSort(count, 'B');
                                inserb.Sort();
                                break;
                            case 1:
                                inserb = new ClassBinInsertSort(count, 'W');
                                inserb.Sort();
                                break;
                            case 2:
                                inserb = new ClassBinInsertSort(count, 'A');
                                inserb.Sort();
                                break;
                        }
                        Console.WriteLine(Environment.NewLine);
                        break;

                    case 2:
                        ClassShellSort shell;
                        Console.WriteLine("Select option: \r\n 0 - B(N) \r\n 1 - W(N) \r\n 2 - A(N) ");
                        type = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Insert number of items:");
                        count = Convert.ToInt32(Console.ReadLine());
                        switch (type)
                        {
                            case 0:
                                shell = new ClassShellSort(count, 'B');
                                shell.Sort();
                                break;
                            case 1:
                                shell = new ClassShellSort(count, 'W');
                                shell.Sort();
                                break;
                            case 2:
                                shell = new ClassShellSort(count, 'A');
                                shell.Sort();
                                break;
                        }
                        Console.WriteLine(Environment.NewLine);
                        break;

                    case 3:
                        Console.WriteLine("Select option: \r\n 0 - B(N) \r\n 1 - W(N) \r\n 2 - A(N) ");
                        type = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Insert number os items:");
                        count = Convert.ToInt32(Console.ReadLine());
                        int[] arr = new int[count];
                        switch (type)
                        {
                            case 0:
                                arr = ClassMergeSort.MakeArray(count, 'B');
                                ClassMergeSort.Sort(arr);
                                break;
                            case 1:
                                arr = ClassMergeSort.MakeArray(count, 'W');
                                ClassMergeSort.Sort(arr);
                                break;
                            case 2:
                                arr = ClassMergeSort.MakeArray(count, 'A');
                                ClassMergeSort.Sort(arr);
                                break;
                        }
                        Console.WriteLine(Environment.NewLine);
                        break;

                    case 4:
                        Console.WriteLine("Select option: \r\n 0 - B(N) \r\n 1 - W(N) \r\n 2 - A(N) ");
                        type = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Insert number of items:");
                        count = Convert.ToInt32(Console.ReadLine());
                        arr = new int[count];
                        switch (type)
                        {
                            case 0:
                                arr = ConsoleSort.ClassQuickSort.MakeArray(count, 'B');
                                ConsoleSort.ClassQuickSort.Sort(arr);
                                break;
                            case 1:
                                arr = ConsoleSort.ClassQuickSort.MakeArray(count, 'W');
                                ConsoleSort.ClassQuickSort.Sort(arr);
                                break;
                            case 2:
                                arr = ConsoleSort.ClassQuickSort.MakeArray(count, 'A');
                                ConsoleSort.ClassQuickSort.Sort(arr);
                                break;
                        }
                        Console.WriteLine(Environment.NewLine);
                        break;
                }
            }
        }
    }
}
