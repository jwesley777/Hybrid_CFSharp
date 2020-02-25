using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FTools;
using Deedle;

namespace Hybrid_CFSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SeriesImpl(args);

            

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void SeriesImpl(string[] args)
        {
            string path = args[0];
            int dateColNum = Convert.ToInt32(args[1]);
            int valsColNum = Convert.ToInt32(args[2]);
            if (File.Exists(path))
            {
                Series<DateTime, Double> series;
                string[] lines = File.ReadAllLines(path);
                DateTime[] dates = lines.Skip(1)
                    .Select(a => DateTime.Parse(a.Split(',')[dateColNum]))
                    .ToArray();
                double[] values = lines.Skip(1)
                    .Select(a => Double.Parse(a.Split(',')[valsColNum]))
                    .ToArray();
                series = new Series<DateTime, double>(dates, values);
                Console.WriteLine(ExampleFunctions.AverageOfSeries(series));

            }
            else
                Console.WriteLine("path not found");
            Console.ReadLine();
        }

        static void ArrayImpl(string[] args)
        {
            string path = args[0];
            int colNum = Convert.ToInt32(args[1]);
            if (File.Exists(path))
            {

                double[] series = File.ReadAllLines(path)
                    .Skip(1)
                    .Select(a => Convert.ToDouble(a.Split(',')[colNum]))
                    .ToArray();
                Console.WriteLine(ExampleFunctions.AverageOfArray(series));
            }
            else
                Console.WriteLine("path not found");
            Console.ReadLine();
        }
    }
}
