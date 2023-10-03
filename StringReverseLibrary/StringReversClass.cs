using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseLibrary
{
    public class StringReversClass
    {
        public string ReverseString(string textString)
        {
            if (String.IsNullOrEmpty(textString))
            {
                throw new Exception();
            }
            textString = textString.ToLower();
            char[] chars = textString.ToCharArray();
            Array.Reverse(chars);
            

            return new string(chars);
        }


        public bool IsPalindrome(string str)
        {
            string str2 = new StringReversClass().ReverseString(str);
            if (str!=str2)
            {
                return false;
            }

            return true;
        }
    }


}
