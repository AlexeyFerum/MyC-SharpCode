using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBSecond
{
    public class MyFile
    {
        public static string ReadFromFile(string filename1)
        { 
            FileStream Fs = new FileStream(filename1, FileMode.Open);
            StreamReader sr = new StreamReader(Fs, Encoding.GetEncoding(1251));

            string text = "";

            while (!sr.EndOfStream)
            {
                var s = sr.ReadLine();
                text += s;
            }

            sr.Close();
            Fs.Close();

            return text;
        }
        
        public static void WriteInFile(string filename2, List<string> Result)
        {
            FileStream Fs = new FileStream(filename2, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(Fs);

            foreach(string result in Result)
            {
                sw.WriteLine(result);
                sw.WriteLine();
            }

            sw.Close();
            Fs.Close();
        }
    }
}
