using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Graph.TraversingStrategies
{
    internal class TraversalEventArgs<TVertex, TEdge>
    {
        public Vertex<TVertex, TEdge> Vertex { get; set; }
        public Edge<TVertex, TEdge> Edge { get; set; }

        public TraversalEventArgs(Vertex<TVertex, TEdge> vertex, Edge<TVertex, TEdge> edge)
        {
            Vertex = vertex;
            Edge = edge;
        }
    }
}
