using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DlinkList.Form1;

namespace DlinkList
{
    public class DoublyLinkedList
    {
        public DoublyLinkedListNode Head { get; private set; }
        //The private set accessor means that the Head property can only be modified within the DoublyLinkedList class.
        //Other classes can read its value but cannot change it directly.
        public void Insert(int data)
        {
            DoublyLinkedListNode newNode = new DoublyLinkedListNode { Data = data };

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
        }
    }
}
