using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_07
{
    public static class Extenstion
    {
        public static string ToTitleCase(this string str)
        {
            string[] words = str.Split(" ");

            string titleCaseSen="";

            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    titleCaseSen += char.ToUpper(word[0]);
                    if (word.Length > 1)
                        titleCaseSen += word.Substring(1).ToLower();
                    titleCaseSen += " ";
                }
            }

            return titleCaseSen.Trim();
        }

    }
}
