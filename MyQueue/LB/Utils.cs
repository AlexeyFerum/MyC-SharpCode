using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB
{
    public class Utils
    {
        MyQueue<string> q = new MyQueue<string>();

        public MyQueue<string> ReadFromFile(string filename)
        {
            FileStream FS = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(FS);

            foreach(string word in sr.ReadToEnd().Split(null))
            {
                q.Enqueue(word);
            }

            sr.Close();
            FS.Close();

            return q;
        }

        public void WriteInFile(string filename, MyQueue<string> result)
        {
            FileStream FS = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(FS);

            foreach(string element in result)
            {
                sw.Write(element + " ");
            }

            sw.Close();
            FS.Close();
        }
    }
}
