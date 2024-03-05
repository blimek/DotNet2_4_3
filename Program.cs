using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_4_3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Podaj długość podstawy: ");
            double x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość boku:");
            double y = Int32.Parse(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow( x, 2) + Math.Pow(y, 2));

            Console.WriteLine($"Przekątna tego prostokąta wynosi : {result};");
            Console.ReadLine();
            




            
        }
    }
}
