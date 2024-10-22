using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        DirectedGraph graph = new DirectedGraph();
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.PrintGraph();
    }
}
