﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Graph.TraversingStrategies
{
    internal class BreadthFirstTraversingStrategy<TVertex, TEdge> : TraversingStrategy<TVertex, TEdge>
    {
        public override void Traverse(Graph<TVertex, TEdge> graph, Vertex<TVertex, TEdge> start)
        {
            var vertexTuples = new Queue<(Vertex<TVertex, TEdge>, Edge<TVertex, TEdge>)>();
            var processedVertexes = new List<Vertex<TVertex, TEdge>>();

            OnVertexEnter(start, null);
            processedVertexes.Add(start);
            foreach (var edge in start.Edges)
            {
                vertexTuples.Enqueue((edge.EndVertex, edge));
            }

            while (vertexTuples.Count > 0)
            {
                var (vertex, edge) = vertexTuples.Dequeue();
                if (processedVertexes.Contains(vertex)) continue;

                OnVertexEnter(vertex, edge);
                processedVertexes.Add(vertex);
                foreach (var newEdge in vertex.Edges)
                {
                    var newVertex = newEdge.EndVertex;
                    if (processedVertexes.Contains(newVertex)) continue;
                    vertexTuples.Enqueue((newVertex, newEdge));
                }
            }
        }
    }
}
