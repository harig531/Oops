using System;
using System.Collections.Generic;
using System.Text;

namespace Access
{
    static class  ExtenionClass
    {
        public static string FirstCharLetterChange(this string inputstring)
        {
            if(inputstring.Length>0)
            {
                char[] sCharArry = inputstring.ToCharArray();
                sCharArry[0] = Char.IsUpper(sCharArry[0]) ? char.ToLower(sCharArry[0]) : char.ToUpper(sCharArry[0]);
                return new string(sCharArry);
            }

            return inputstring;
        }
    }
}
