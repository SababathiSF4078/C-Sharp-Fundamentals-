using System;
namespace Question1;
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

        Console.WriteLine("Enter the first letter: ");
        string first=Console.ReadLine().ToUpper();

        Console.WriteLine("Enter the last letter: ");
        string last=Console.ReadLine().ToUpper();

        int check=0;
        for(int j=0; j<=city.Length-1; j++)
        {
            if(city[j].StartsWith(first) && city[j].EndsWith(last))
            {
                check=1;
                Console.WriteLine($"The city starts with {first} and ends with {last} is {city[j]}");
            }
        }
        if(check==0)
        {
            Console.WriteLine($"There is no city starts with {first} and ends with {last} ");
        }


        
    
    }
}
