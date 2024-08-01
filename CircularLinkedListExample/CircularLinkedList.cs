using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CircularLinkedListExample
{
    public class CircularLinkedList
    {
        private Node tail;  // Points to the last node in the list

        // Constructor to initialize an empty list
        public CircularLinkedList()
        {
            tail = null;
        }

        // Adds a node to an empty list
        public void AddToEmpty(int data)
        {
            if (tail != null)
                return;

            Node newNode = new Node(data);
            tail = newNode;
            tail.Next = tail;  // Point to itself to form a circle
        }

        // Adds a new node at the end of the list
        public void AddToEnd(int data)
        {
            if (tail == null)
            {
                AddToEmpty(data);
                return;
            }

            Node newNode = new Node(data);
            newNode.Next = tail.Next;  // Point the new node to the head
            tail.Next = newNode;       // Update the old tail to point to the new node
            tail = newNode;            // Update the tail to be the new node
        }

        // Prints the list starting from the head
        public void PrintList()
        {
            if (tail == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node temp = tail.Next;  // Start from the head
            do
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            } while (temp != tail.Next);  // Loop until we reach the head again
            Console.WriteLine();
        }

        // Deletes a node with the specified key
        public void DeleteNode(int key)
        {
            if (tail == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            // If the list contains only one node
            if (tail.Next == tail && tail.Data == key)
            {
                tail = null;
                return;
            }

            Node current = tail;
            Node prev = null;
            do
            {
                prev = current;
                current = current.Next;
                if (current.Data == key)
                    break;
            } while (current != tail);

            // If the key is not found
            if (current == tail && current.Data != key)
            {
                Console.WriteLine("Key not found in the list.");
                return;
            }

            prev.Next = current.Next;  // Remove the node by adjusting pointers

            // If the node to be deleted is the tail node
            if (current == tail)
            {
                if (tail.Next == tail)  // Single node case
                    tail = null;
                else
                    tail = prev;  // Update tail if it's not the only node
            }
        }
    }


}
