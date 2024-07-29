using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListExample
{
    public class LinkedList
    {
        private Node head;// Keeps track of the first node in the list.

        // Add a node at the end of the list
        public void Add(int data)
        {
            Node newNode = new Node(data);//create an instance with the given data

            if (head == null)//if list is empty, set head to the new node
            {
                head = newNode;
            }
            else//If the list is not empty then add
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Print all nodes in the list
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

    
        

       
        
    }

}
