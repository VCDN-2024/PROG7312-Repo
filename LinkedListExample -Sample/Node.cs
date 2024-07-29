using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    public class Node
    {
        //Nodes are connected in sequence, where each node points to the next node.
        //This class provides the basic structure to create and link nodes together.
       
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

}
