namespace _05_Graph
{
    internal class Edge<TVertex, TEdge>
    {
        public TEdge Value { get; set; }
        public Vertex<TVertex, TEdge> StartVertex { get; }
        public Vertex<TVertex, TEdge> EndVertex { get; }

        public Edge(Vertex<TVertex, TEdge> startVertex, Vertex<TVertex, TEdge> endVertex,
            TEdge value = default(TEdge))
        {
            Value = value;
            StartVertex = startVertex;
            EndVertex = endVertex;
        }
    }
}
