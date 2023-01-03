using System;
namespace Question2;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        string [] city=new string[8];
        Console.WriteLine("Enter the cities: ");

        for(int i=0; i<=city.Length-1; i++)
        {
            city[i]=Console.ReadLine().ToUpper();
        }
        Console.WriteLine("The sorted orders are ");
        IEnumerable<string> cityOrder=city.OrderBy(str=>str.Length).ThenBy(str=>str);

        foreach(string cities in cityOrder)
        {
            Console.WriteLine(cities);
        }
    
    }
}