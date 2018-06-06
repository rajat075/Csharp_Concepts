using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Programs.Extensions
{
    public  static class CharExtension
    {
        public static int  GetASCII(this char ch)
        {
            return Convert.ToInt32(ch);
        }
    }
}
