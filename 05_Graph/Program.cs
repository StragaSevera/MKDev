using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Graph
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var graph = new Graph<string, int>();
            graph.AddVertex("First!");
            graph.AddVertex("Second!");
            graph[0].AddEdgeTo(graph[1], 5);
            graph[1].AddEdgeTo(graph[0]);

            Console.WriteLine($"First vertex: {graph[0].Value}");
            Console.WriteLine($"Second vertex: {graph[1].Value}");
            Console.WriteLine($"First edge: {graph[0][0].Value}");
            Console.WriteLine($"Second edge: {graph[1][0].Value}");

            Console.ReadLine();
        }
    }
}
