using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordClassLibrary
{
    public class Wordtext
    {
        public static int WordCount(string textString, string word)
        {
            if (string.IsNullOrWhiteSpace(textString))
            {
                throw new Exception("Пустая строка");
            }
            int count = 0;
            textString = textString.ToLower();
            word = word.ToLower();
            string[] words = textString.Split();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    count++;
                }

            }

            return count;
        }
    }
}
