using System;
using System.Xml;

namespace MyApplication
{
    class Programm
    {
        static void Main()
        {
            string rawTopic = "  Learn C#  ";

            System.Console.WriteLine(rawTopic);
            System.Console.WriteLine(rawTopic.Length);
            rawTopic = rawTopic.Trim();
            System.Console.WriteLine(rawTopic);
            System.Console.WriteLine(rawTopic.Length);

            System.Console.WriteLine(rawTopic.Contains("C#"));
            System.Console.WriteLine(rawTopic.Replace("C#", ".NET"));
            rawTopic = "  ";
            System.Console.WriteLine(String.IsNullOrWhiteSpace(rawTopic));
        }
    }
}