using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson9
{
    public static class MyExtension
    {
        public static bool IsValidEmailAddress(this string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }
        public static int CountChar(this string s,char ch) 
        {
            int count = 0;
            for(int i = 0; i < s.Length; i++) 
            {
                if (ch == s[i]) count++;
            }
            return count;
        }
    }
}
