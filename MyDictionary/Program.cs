using System;
using System.Collections.Generic;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cities = new Dictionary<string, string>();

            cities.Add("UK", "London, Manchester, Birmingham");
            cities.Add("USA", "New York, Chicago, Washington");
            cities.Add("Turkey", "İstanbul, Ankara, İzmir");

            Console.WriteLine(cities.Count);
            Console.WriteLine(cities["USA"] + "/" + cities["UK"] + "/" + cities["Turkey"]);

            MyDictionary<string, string> cities2 = new MyDictionary<string, string>();

            cities2.Add("UK", "London, Manchester, Birmingham");
            cities2.Add("USA", "New York, Chicago, Washington");
            cities2.Add("Turkey", "İstanbul, Ankara, İzmir");

            Console.WriteLine(cities2.Count);
            Console.WriteLine(cities["USA"] + "/" + cities["UK"] + "/" + cities["Turkey"]);
        }
    }
}