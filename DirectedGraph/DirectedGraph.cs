using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DirectedGraph
{
    private Dictionary<int, List<int>> adjacencyList;

    public DirectedGraph()
    {
        adjacencyList = new Dictionary<int, List<int>>();
    }

    public void AddVertex(int vertex)
    {
        adjacencyList[vertex] = new List<int>();
    }

    public void AddEdge(int startVertex, int endVertex)
    {
        if (!adjacencyList.ContainsKey(startVertex))
            AddVertex(startVertex);

        if (!adjacencyList.ContainsKey(endVertex))
            AddVertex(endVertex);

        adjacencyList[startVertex].Add(endVertex);
    }

    public void PrintGraph()
    {
        foreach (var vertex in adjacencyList)
        {
            Console.Write(vertex.Key + " -> ");
            foreach (var edge in vertex.Value)
            {
                Console.Write(edge + " ");
            }
            Console.WriteLine();
        }
    }
}
