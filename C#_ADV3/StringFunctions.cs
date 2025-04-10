using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV3
{
    internal class StringFunctions
    {
        public static int GetCountOfUpperCaseChar(string Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word)){
                for(int i = 0; i < Word.Length; i++)
                {
                    if (char.IsUpper(Word[i])){
                        count++;
                    }
                }
               
            }
            return count;
        }

        public static int GetCountOfLowerCaseChar(string Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (char.IsLower(Word[i]))
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
