using System;
using System.Reflection;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter web addres: ");
            string url = Console.ReadLine();
            var uri = new Uri(url);
            Console.WriteLine(uri.Scheme);
            Console.WriteLine(uri.Port);
            Console.WriteLine(uri.Host);
        }
    }
}