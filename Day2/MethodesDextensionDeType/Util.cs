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
    }
}
