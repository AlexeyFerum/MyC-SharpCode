using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task16._18
{
    class Read
    {
        private static Random rnd = new Random();
        public static int[] Readme(string name)
        {
            StreamReader file = new StreamReader(name);
            string[] c = { ",", ".", "!", "?", ";", ":", " " };
            string str = file.ReadLine();
            string[] result = str.Split(c, name.Length, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[result.Length];
            do
            {
                for (int i = 0; i < result.Length; i++)
                {
                    arr[i] = Convert.ToInt32(result[i]);
                }
            }
            while (!file.EndOfStream);
            file.Close();
            return arr;
        }

        public static int[] Rand()
        {
            int[] arr = new int[rnd.Next(6,12)];
            for (int i = 0; i<arr.Length; i++) 
            {
                arr[i] = rnd.Next(0, 50);
            }
            return arr;
        }
}
}
