using System;

using EmailParser;

namespace EmailParser.Runner
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(EmailMessage.makeAllUppercase("Hello World!"));
            Console.WriteLine(EmailMessage.makeReverse("Hello World!"));        
        }
    }
}
