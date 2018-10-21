using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB
{
    public class forBinaryTree
    {
        static public bool StartCompare(string s1, string s2)
        {
            return Compare(s1, s2, 0);
        }

        static private bool Compare(string s1, string s2, int index)
        {
            if (s1.Length <= index)
                return true;
            if (s2.Length <= index)
                return false;
            if (s1[index] == s2[index])
                return Compare(s1, s2, index + 1);
            return s1[index] < s2[index];
        }

        static List<string> DoOpertion(List<string> A, BinaryTree B)
        {
            List<string> res = new List<string>();
            foreach (string el in A)
            {
                if (!B.Contains(el))
                    res.Add(el);
            }
            return res;
        }

        public static string[] ReadFromFile(string filename1)
        {
            List<string> a = new List<string>();

            FileStream Fs = new FileStream(filename1, FileMode.Open);
            StreamReader sr = new StreamReader(Fs);

            while (!sr.EndOfStream)
            {
                var s = sr.ReadLine();

                if (s.Length > 20)
                    throw new Exception("The maximum word size is exceeded");
                a.Add(s);
            }
            return a.ToArray();
        }
    }
}