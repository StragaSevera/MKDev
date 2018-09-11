using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05_Graph
{
    internal class SalesmanNearestFriend
    {
        private readonly Graph<string, double> _graph;
        private readonly List<(Vertex<string, double>, Vector2)> _towns;

        public SalesmanNearestFriend(Graph<string, double> graph,
            List<(Vertex<string, double>, Vector2)> towns)
        {
            _graph = graph;
            _towns = towns;
        }

        public void AddEdgesByTown()
        {
            for (int i = 0; i < _towns.Count; i++)
            {
                for (int j = i + 1; j < _towns.Count; j++)
                {
                    double distance = Vector2.Distance(_towns[i].Item2, _towns[j].Item2);
                    _graph[i].AddEdgeToBidirectional(_graph[j], distance);
                }
            }
        }

        public IEnumerable<Vertex<string, double>> Travel(Vertex<string, double> start)
        {
            var result = new List<Vertex<string, double>> {start};
            while (result.Count < _graph.Vertices.Count)
            {
                var lastVertex = result.Last();
                var edges = lastVertex.Edges.Where(e => !result.Contains(e.EndVertex));
                var nearestEdge = edges.OrderBy(e => e.Value).First();
                result.Add(nearestEdge.EndVertex);
            }

            return result;
        }
    }
}
