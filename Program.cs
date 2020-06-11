using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarGraphDemo
{
    class GraphBars
    {
        /*given an array of N positive integers
         *plot a graph of pip "|" on the console
         *
         */
        static void Main(string[] args)
        {
            int[] bars = new int[] { 8, 4, 5, 3, 9, 2, 1 };
            var maxValue = FindMax(bars);
            while (maxValue >= 0)
            {
                Console.WriteLine(PlotGraph(bars, maxValue));
                maxValue--;
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();

        }

        public static int FindMax(int[] values)
        {
            int max = values[0];
            foreach (int value in values)
            {
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }

        public static string PlotGraph(int[] barValue, int max)
        {
            string graph = null;
            if (max != 0)
            {
                foreach (int value in barValue)
                {
                    if (max > value)
                    {
                        graph += "     ";
                    }
                    else if (max <= value)
                    {
                        graph += " |   ";
                    }
                }
            }
            else
            {
                int n = 0;
                while (n < barValue.Length)
                {
                    graph += "-----";
                    n++;
                }
                graph += "\n";
                foreach (int value in barValue)
                {
                    graph += " " + value + "   ";
                }
            }

            return graph;
        }
    }
}
