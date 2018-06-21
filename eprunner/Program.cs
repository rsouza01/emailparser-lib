using System;

using emaiparser_lib;

namespace eprunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(EmailMessage.makeAllUppercase("Hello World!"));
            Console.WriteLine(EmailMessage.makeReverse("Hello World!"));        
        }
    }
}
