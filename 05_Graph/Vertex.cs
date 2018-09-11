using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Graph
{
    internal class Vertex<TVertex, TEdge>
    {
        public TVertex Value { get; set; }
        public List<Edge<TVertex, TEdge>> Edges { get; }

        public Vertex(TVertex value = default(TVertex))
        {
            Value = value;
            Edges = new List<Edge<TVertex, TEdge>>();
        }

        public Edge<TVertex, TEdge> this[int i] => Edges[i];

        public void AddEdgeTo(Vertex<TVertex, TEdge> target, TEdge edgeValue = default(TEdge))
        {
            var edge = new Edge<TVertex, TEdge>(this, target, edgeValue);
            Edges.Add(edge);
        }

        public void AddEdgeToBidirectional(Vertex<TVertex, TEdge> target, 
            TEdge edgeValue = default(TEdge))
        {
            AddEdgeTo(target, edgeValue);
            target.AddEdgeTo(this, edgeValue);
        }

        public IEnumerable<Edge<TVertex, TEdge>> GetAllEdgesTo(Vertex<TVertex, TEdge> target)
        {
            return Edges.Where(e => e.EndVertex == target);
        }

        public Edge<TVertex, TEdge> GetEdgeTo(Vertex<TVertex, TEdge> target)
        {
            return GetAllEdgesTo(target).FirstOrDefault(e => e.EndVertex == target);
        }


        public bool HasEdgeTo(Vertex<TVertex, TEdge> target)
        {
            return GetEdgeTo(target) != null;
        }

        public void RemoveEdge(Edge<TVertex, TEdge> targetEdge)
        {
            Edges.Remove(targetEdge);
        }

        public void RemoveEdgeTo(Vertex<TVertex, TEdge> target)
        {
            var edge = GetEdgeTo(target);
            if (edge == null)
            {
                throw new ArgumentException("Trying to remove an edge which do not exist in graph!");
            }

            RemoveEdge(edge);
        }

        public void RemoveEdgeToBidirectional(Vertex<TVertex, TEdge> target)
        {
            RemoveEdgeTo(target);
            target.RemoveEdgeTo(this);
        }

        public void RemoveAllEdgesTo(Vertex<TVertex, TEdge> target)
        {
            var targetEdges = GetAllEdgesTo(target);
            Edges.RemoveAll(targetEdges.Contains);
        }

        public void ClearEdges()
        {
            Edges.Clear();
        }
    }
}
