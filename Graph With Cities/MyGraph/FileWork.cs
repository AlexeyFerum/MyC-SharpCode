using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyGraph
{
    public class FileWork
    {
        public string FileName { get; set; }
        public void Write(CityGraph graph) 
        {
            FileStream stream = new FileStream(FileName, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);
            int Count = graph.Nodes.Count;
            writer.Write(Count);
            List<Node> nodes = graph.Nodes;

            foreach (Node item in nodes)
            {
                WriteString(item.Name, writer);
                writer.Write(item.X);
                writer.Write(item.Y);
            }

            for (int i = 0; i < Count; i++)
                for (int j = i + 1; j < Count; j++)
                {
                    bool t = true;
                    foreach (Edge item in nodes[i].Edges)
                    {
                        if(item.B == nodes[j])
                        {
                            writer.Write(true);
                            writer.Write(item.Value);
                            t = false;
                            break;
                        }
                    }
                    if (t) writer.Write(false);
                }
            writer.Close();
            stream.Close();
        }

        public CityGraph Read()
        {
            FileStream stream = new FileStream(FileName, FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);
            CityGraph graph = new CityGraph();
            int Count = reader.ReadInt32();

            for (int i = 0; i < Count; i++)
            {
                string s = ReadString(reader);
                int X = reader.ReadInt32();
                int Y = reader.ReadInt32();
                graph.AddNode(s, X, Y);
            }

            for (int i = 0; i < Count; i++)
                for (int j = i + 1; j < Count; j++)
                    if (reader.ReadBoolean())
                    {
                        int value = reader.ReadInt32();
                        graph.Nodes[i].AddEdge(graph.Nodes[j],value);
                    }

            reader.Close();
            stream.Close();

            return graph;
        }

        private void WriteString(string s, BinaryWriter writer)
        { 
            writer.Write(s.Length);
            Encoder enc = Encoding.Unicode.GetEncoder();
            byte[] bytes = new byte[s.Length * 2];
            enc.GetBytes(s.ToCharArray(), 0, s.Length, bytes, 0, true);
            writer.Write(bytes);
        }

        private string ReadString(BinaryReader reader)
        { 
            int Length = reader.ReadInt32();
            byte[] bytes = reader.ReadBytes(Length * 2);
            Decoder dec = Encoding.Unicode.GetDecoder();
            char[] data = new char[Length];
            dec.GetChars(bytes, 0, Length * 2, data, 0);

            return new string(data);
        }

        public FileWork(string fileName) => FileName = fileName;
    }
}
