using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using _05_Graph.TraversingStrategies;

namespace _05_Graph
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var graph = new Graph<string, int>();
            graph.AddVertex("First");
            graph.AddVertex("Second");
            graph.AddVertex("Third");
            graph.AddVertex("Fourth");
            graph.AddVertex("Fifth");
            graph[0].AddEdgeToBidirectional(graph[1], 1);
            graph[0].AddEdgeToBidirectional(graph[2], 2);
            graph[1].AddEdgeTo(graph[3], 3);
            graph[3].AddEdgeTo(graph[4], 4);
            graph[4].AddEdgeTo(graph[2], 5);

            Console.WriteLine($"First vertex: {graph[0]}");
            Console.WriteLine($"Second vertex: {graph[1]}");
            Console.WriteLine($"First edge: {graph[0][0]}");
            Console.WriteLine($"Second edge: {graph[1][0]}");

            Console.WriteLine("\nUsing depth first strategy:");
            TraversingStrategy<string, int> strategy =
                new DepthFirstTraversingStrategy<string, int>();
            strategy.VertexEnter += (o, i) =>
                Console.WriteLine($"Reached vertex {i.Vertex} by #{i.Edge} edge");

            Console.WriteLine("Traversing from first vertex:");
            graph.Traverse(strategy, graph[0]);

            Console.WriteLine("Traversing from second vertex:");
            graph.Traverse(strategy, graph[1]);

            Console.WriteLine("\nUsing breadth first strategy:");
            strategy = new BreadthFirstTraversingStrategy<string, int>();
            strategy.VertexEnter += (o, i) =>
                Console.WriteLine($"Reached vertex {i.Vertex} by #{i.Edge} edge");

            Console.WriteLine("Traversing from first vertex:");
            graph.Traverse(strategy, graph[0]);

            Console.WriteLine("Traversing from second vertex:");
            graph.Traverse(strategy, graph[1]);

            var salesmanGraph = new Graph<string, double>();
            var towns = new List<(Vertex<string, double>, Vector2)>
            {
                (salesmanGraph.AddVertex("A"), new Vector2(0, 0)),
                (salesmanGraph.AddVertex("B"), new Vector2(1, 2)),
                (salesmanGraph.AddVertex("C"), new Vector2(3, 5)),
                (salesmanGraph.AddVertex("D"), new Vector2(5, 1)),
                (salesmanGraph.AddVertex("E"), new Vector2(-1, 3))
            };
            var salesmanStrategy = new SalesmanNearestFriend(salesmanGraph, towns);
            salesmanStrategy.AddEdgesByTown();
            var salesmanResult = salesmanStrategy.Travel(towns[0].Item1).ToList();
            double length = 0d;
            for (int i = 0; i < salesmanResult.Count; i++)
            {
                var vertex = salesmanResult[i];
                var nextVertex = i < salesmanResult.Count - 1
                    ? salesmanResult[i + 1]
                    : salesmanResult[0];
                var edge = vertex.GetEdgeTo(nextVertex);
                length += edge.Value;
                Console.WriteLine($"From {vertex.Value} to {nextVertex.Value}: {edge.Value} " +
                                  $"({length})");
            }

            Console.ReadLine();
        }
    }
}
