using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListExample
{
    public class Node
    {
        public int Data;   // Holds the data of the node
        public Node Next;  // Points to the next node in the list

        // Constructor to initialize the node with data
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
