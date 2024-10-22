using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        UndirectedGraph graph = new UndirectedGraph();
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.PrintGraph();
    }
}
