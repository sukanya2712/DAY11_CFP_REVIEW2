using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review2
{
    internal class ConvertString
    {
        string word = "Happy BirthDay";
        string answord = string.Empty;
        //char.IsUpper('a')-> false

        /*for (int i=0; i<word.Length; i++)
        {
            if (char.IsUpper(word[i]))
            {
                answord += char.ToLower(word[i]);
            }
            else 
            {
                answord += char.ToUpper(word[i]);
            }

        }

        Console.WriteLine(answord);*/

        public static string Method2(string word)
        {
            
            string answord = string.Empty;

            

            

                for (int i=0; i<word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        answord += char.ToLower(word[i]);
                    }
                    else 
                    {
                        answord += char.ToUpper(word[i]);
                    }

                }

            return answord;

            

        }
    }
}
