using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodesDextensionDeType
{
   static class Util
    {
        public static int wordCount(this string str)
        {
            return str.Split(" ").Length;
        }

        public static string FirstLetterUpperCase(this string str)
        {
            char first_letter = char.ToUpper(str[0]); // mettre la première lettre en majuscule
            string result = first_letter + str.Substring(1);
            return result;
        }

        public static string addDrFirst(this string name)
        {
            return ("Dr. " + name);
        }


    }
}
