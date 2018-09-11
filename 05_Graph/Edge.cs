namespace _05_Graph
{
    internal class Edge<T>
    {
        public T Value { get; set; }
        public Vertex<T> StartVertex { get; }
        public Vertex<T> EndVertex { get; }

        public Edge(Vertex<T> startVertex, Vertex<T> endVertex, T value = default(T))
        {
            Value = value;
            StartVertex = startVertex;
            EndVertex = endVertex;
        }
    }
}