using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBSecond
{     
    public class Sorting
    {
        public static List<string> ConsonantOrVowel(List<string> Words)
        {
            List<string> Vowel = new List<string>();

            for (int i = 0; i < Words.Count; i++)
            {
                if (Words[i].StartsWith("а") ||
                            Words[i].StartsWith("е") ||
                            Words[i].StartsWith("ё") ||
                            Words[i].StartsWith("и") ||
                            Words[i].StartsWith("о") ||
                            Words[i].StartsWith("у") ||
                            Words[i].StartsWith("э") ||
                            Words[i].StartsWith("ю") ||
                            Words[i].StartsWith("я") ||
                            Words[i].StartsWith("А") ||
                            Words[i].StartsWith("Е") ||
                            Words[i].StartsWith("Ё") ||
                            Words[i].StartsWith("И") ||
                            Words[i].StartsWith("О") ||
                            Words[i].StartsWith("У") ||
                            Words[i].StartsWith("Э") ||
                            Words[i].StartsWith("Ю") ||
                            Words[i].StartsWith("Я"))
                {
                    Vowel.Add(Words[i]);
                    Words.Remove(Words[i]);
                }
            }

            Words.Sort();
            Vowel.Sort();
            
            foreach(string word in Words)
            {
                Vowel.Add(word);
            }

            return Vowel;
        }
    }
}
