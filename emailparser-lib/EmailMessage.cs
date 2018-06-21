using System;

namespace EmailParser
{
    public class EmailMessage
    {

        public static string makeAllUppercase(string inputString) => inputString.ToUpper();

        public static string makeReverse(string inputString){
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }        
    }
}
