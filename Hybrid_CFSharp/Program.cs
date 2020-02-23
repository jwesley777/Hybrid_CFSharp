using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FTools;

namespace Hybrid_CFSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            string path = args[0];
            int colNum = Convert.ToInt32(args[1]);
            if (File.Exists(path))
            {
                
                List<double> series = File.ReadAllLines(path)
                    .Skip(1)
                    .Select(a => Convert.ToDouble(a.Split(',')[colNum]))
                    .ToList();
                Console.WriteLine(ExampleFunctions.Average(series.ToArray()));
            }
            else
                Console.WriteLine("path not found");
            Console.ReadLine();
            

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
