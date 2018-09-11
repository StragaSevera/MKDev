using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Graph
{
    internal class Vertex<T>
    {
        public T Value { get; set; }
        public IList<Edge<T>> Edges { get; }

        public Vertex(T value = default(T))
        {
            Value = value;
            Edges = new List<Edge<T>>();
        }

        public void AddEdge(Vertex<T> target, T edgeValue = default(T))
        {
            var edge = new Edge<T>(this, target, edgeValue);
            Edges.Add(edge);
        }

        public void AddEdgeBidirectional(Vertex<T> target, T edgeValue = default(T))
        {
            AddEdge(target, edgeValue);
            target.AddEdge(this, edgeValue);
        }

        public void RemoveEdge(Vertex<T> target)
        {
            var edge = Edges.FirstOrDefault(e => e.EndVertex == target);
            if (edge == null)
            {
                throw new ArgumentException("Trying to remove an edge which do not exist");
            }

            Edges.Remove(edge);
        }

        public void RemoveEdgeBidirectional(Vertex<T> target)
        {
            RemoveEdge(target);
            target.RemoveEdge(this);
        }
    }
}
