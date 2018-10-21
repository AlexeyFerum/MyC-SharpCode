using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tools
{
    public static class FileTree
    {
        public static void SaveTree(string Path, Tree tree)
        {
            FileStream file = new FileStream(Path, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(file);
            SaveNode(tree.Root, writer);
            writer.Close();
            file.Close();
        }

        private static void SaveNode(Node node, BinaryWriter writer)
        {
            writer.Write(node.Value);
            writer.Write(node.Nodes.Count);

            foreach (var item in node.Nodes)
            {
                SaveNode(item, writer);
            }
        }

        public static Tree OpenTree(string Path)
        {
            FileStream file = new FileStream(Path, FileMode.Open);
            BinaryReader reader = new BinaryReader(file);
            Tree tree = new Tree();
            tree.Root = OpenNode(null, reader);
            reader.Close();
            file.Close();

            return tree;
        }

        private static Node OpenNode(Node Parent,BinaryReader reader)
        {
            int value = reader.ReadInt32();
            Node node = new Node(value, Parent);
            int N = reader.ReadInt32();

            for (int i = 0; i < N; i++)
            {
                node.Nodes.Add(OpenNode(node, reader));
            }

            return node;
        }
    }
}
