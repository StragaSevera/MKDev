using System;

namespace _05_Graph.TraversingStrategies
{
    internal abstract class TraversingStrategy<TVertex, TEdge> // Надоело таскать за собой эти типы, 
                                                      // есть ли какой-то способ сделать покрасивее?
    {
        public event EventHandler<TraversalEventArgs<TVertex, TEdge>> VertexEnter;
        public abstract void Traverse(Graph<TVertex, TEdge> graph, Vertex<TVertex, TEdge> start);

        protected virtual void OnVertexEnter(Vertex<TVertex, TEdge> vertex,
            Edge<TVertex, TEdge> edge)
        {
            var eventArgs = new TraversalEventArgs<TVertex, TEdge>(vertex, edge);
            VertexEnter?.Invoke(this, eventArgs);
        }
    }
}
