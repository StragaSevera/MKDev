using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Graph
{
    internal class Graph<TVertex, TEdge>
    {
        public List<Vertex<TVertex, TEdge>> Vertices { get; }

        public Graph()
        {
            Vertices = new List<Vertex<TVertex, TEdge>>();
        }

        public Vertex<TVertex, TEdge> this[int i] => Vertices[i];

        public Vertex<TVertex, TEdge> AddVertex(TVertex value = default(TVertex))
        {
            var vertex = new Vertex<TVertex, TEdge>(value);
            Vertices.Add(vertex);
            return vertex;
        }

        public void RemoveVertex(Vertex<TVertex, TEdge> vertex)
        {
            if (!Vertices.Contains(vertex))
            {
                throw new ArgumentException("Trying to remove an edge which do not exist in graph!");
            }

            foreach (var targetVertex in Vertices.Where(v => v.HasEdgeTo(vertex)))
            {
                targetVertex.RemoveAllEdgesTo(vertex);
            }

            vertex.ClearEdges();
            Vertices.Remove(vertex);
        }

    }
}
