using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBSecond
{
    public class Main
    {
        static Dictionary<string, int> CountWords(string text) 
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();

            string[] words = text.Split(' ', '.', ',', '?', '!', ':', ';');

            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }
            return frequencies;
        }
        
        public static List<string> toList(string text)
        {
            List<string> Words = new List<string>();
            Dictionary<string, int> frequencies = CountWords(text);
            foreach (KeyValuePair<string, int> entry in frequencies.Where(n => n.Value == 1))
            {
                string word = entry.Key;
                Words.Add(word);
            }

            return Words;
        }
    }
}
