﻿using static System.Console;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri info = new Uri("http://www.domain.com:80/info?id=123#fragment");
            Uri page = new Uri("http://www.domain.com/info/page.html");
            WriteLine($"Host: {info.Host}");
            WriteLine($"Port: {info.Port}");
            WriteLine($"PathAndQuery: {info.PathAndQuery}");
            WriteLine($"Query: {info.Query}");
            WriteLine($"Fragment: {info.Fragment}");
            WriteLine($"Default HTTP port: {page.Port}");
            WriteLine($"IsBaseOf: {info.IsBaseOf(page)}");
            Uri relative = info.MakeRelativeUri( page );
            WriteLine($"IsBaseOf: {info.IsAbsoluteUri}");
            WriteLine($"RelativeUri: {relative.ToString()}");
            ReadLine();

        }
    }
}
