using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    public class ArrayReverseHihellow
    {
        
       public void Methodarray()
       {
                string originalString = "Hi hello how are you";
                string reversedString = ReverseString(originalString);
                Console.WriteLine(reversedString);
       }

            static string ReverseString(string originalString)
            {
                string[] words = originalString.Split(' ');
                StringBuilder reversedString = new StringBuilder();
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    char[] letters = words[i].ToCharArray();
                    for (int j = letters.Length - 1; j >= 0; j--)
                    {
                        reversedString.Append(letters[j]);
                    }
                    if (i != 0)
                    {
                        reversedString.Append(' ');
                    }
                }
                return reversedString.ToString();
            }
    }
}
