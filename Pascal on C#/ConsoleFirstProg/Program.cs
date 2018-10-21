using LBFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFirstProg
{
    [Serializable]
    public class Coord
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TypedFile<Coord> p = new TypedFile<Coord>();
            p.Assign("File1.txt");
            p.Rewrite();
            p.Write(new Coord() { X = 10, Y = 132 });
            p.Close();

            p.Reset();
            var c = p.Read();
            p.Close();

            //TypedFile<string> p = new TypedFile<string>();
            //p.Assign("File1.txt");
            //p.Rewrite();
            //p.Write("Ferum");
            //p.Close();

            //p.Assign("File1.txt");
            //p.Reset();
            //Console.WriteLine(p.Read());
            //Console.ReadKey();
            //p.Close();


            //TypedFile<string> p = new TypedFile<string>();
            //p.Assign("File1.txt");
            //p.Reset();
            //Console.WriteLine(p.Read());
            //Console.ReadKey();
            //p.Close();


            //TypedFile<string> p = new TypedFile<string>();
            //p.Assign("File1.txt");
            //p.Reset();
            //p.Seek(3);
            //p.Truncate();
            //p.Close();
        }
    }
}
