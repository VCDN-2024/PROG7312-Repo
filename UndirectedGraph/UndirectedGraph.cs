using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class UndirectedGraph
    {
        private Dictionary<int, List<int>> adjacencyList;

        public UndirectedGraph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int vertex)
        {
            adjacencyList[vertex] = new List<int>();
        }

        public void AddEdge(int vertex1, int vertex2)
        {
            if (!adjacencyList.ContainsKey(vertex1))
                AddVertex(vertex1);

            if (!adjacencyList.ContainsKey(vertex2))
                AddVertex(vertex2);

            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1);
        }

        public void PrintGraph()
        {
            foreach (var vertex in adjacencyList)
            {
                Console.Write(vertex.Key + ": ");
                foreach (var edge in vertex.Value)
                {
                    Console.Write(edge + " ");
                }
                Console.WriteLine();
            }
        }
    }

