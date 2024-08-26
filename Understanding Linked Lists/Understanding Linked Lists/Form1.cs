using System.Collections.Generic;
using System.Xml.Linq;

namespace Understanding_Linked_Lists
{
    public partial class Form1 : Form
    {

        //Setup your constructor
        private class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
        }

        private Node head;//Setup your node
        // this will be used to represent your individual elements in your link list

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLinkList_Click(object sender, EventArgs e)
        {
            int newValue;

            if (int.TryParse(textBox1.Text, out newValue))
            //Attempting to pass the the value from the input textbox
            {// if successful then the value is stored in newValue
             //out keyword is used in a method parameter declaration
             //to indicate that the parameter is being used to return a value from the method

                Node newNode = new Node { Data = newValue, Next = head };
                //Creates a new instance of the Node class, setting its Data property to the parsed newValue
                //and its Next property to the current value of the head variable

                //So basically you inserting a new node at the beginning of a linked list
                head = newNode;

                UpdateListBox();
                textBox1.Clear();
                textBox1.Focus();

            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }


        }
        private void UpdateListBox()
        {
            listBox1.Items.Clear();

            Node current = head;// Start at the beginning of the linked list
            while (current != null)
            {
                listBox1.Items.Add(current.Data);// Add the current node's data to the ListBox
                current = current.Next;// Move to the next node
            }
        }

        private void btnLinkedListEx2_Click(object sender, EventArgs e)
        {
            // Create a linked list of integers
            LinkedList<int> linkedList = new LinkedList<int>();

            // Add elements to the linked list
            linkedList.AddLast(10);
            linkedList.AddLast(30);
            linkedList.AddLast(30);
            linkedList.AddLast(55);
            linkedList.AddLast(1);
            // Sort the linked list in ascending order
            var sortedList = linkedList.OrderBy(item => item).ToList();

            listBox1.Items.Clear();

            foreach (var item in sortedList)
            {
                listBox1.Items.Add(item);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int valueToDelete;

            if (int.TryParse(textBox2.Text, out valueToDelete))
            {
                DeleteNode(valueToDelete);
                textBox2.Clear();
                textBox2.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }


        }
        private void DeleteNode(int valueToDelete)
        {
            if (head == null)
            {
                MessageBox.Show("Linked list is empty.");
                return;
            }

            if (head.Data == valueToDelete)
            {
                head = head.Next;
                UpdateListBox();
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == valueToDelete)
                {
                    current.Next = current.Next.Next;
                    UpdateListBox();
                    return;
                }
                current = current.Next;
            }

            MessageBox.Show("Value not found in the linked list.");
        }

        private void BtnSortLinkList_Click(object sender, EventArgs e)
        {
            //Code this portion for sorting

            List<int> tempList = new List<int>();

            Node current = head;
            while (current != null)
            {
                tempList.Add(current.Data);
                current = current.Next;
            }

            tempList.Sort((x, y) => y.CompareTo(x));

            head = null;
            foreach (int value in tempList)
            {
                Node newNode = new Node { Data = value, Next = head };
                head = newNode;
            }

            UpdateListBox();

        }
    }

}