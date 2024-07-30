using System.Collections.Generic;
using System.Data;

namespace DlinkList
{
    public partial class Form1 : Form
    {
        private DoublyLinkedList linkedList = new DoublyLinkedList();
        private DoublyLinkedListNode current = null;

        public Form1()
        {
            InitializeComponent();

        }
        private void UpdateListBox()
        {
            listBox1.Items.Clear();

            DoublyLinkedListNode node = linkedList.Head;
            while (node != null)
            {
               listBox1.Items.Add(node.Data);
                node = node.Next;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int data = Convert.ToInt32(textBox1.Text);
            linkedList.Insert(data);
        
            UpdateListBox();

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (current == null)
            {
                current = linkedList.Head;
            }
            else
            {
                current = current.Next;
            }
          
            UpdateDataLabel();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current = current.Previous;
                 UpdateDataLabel();
             
            }
        }

        private void UpdateDataLabel()
        {
            if (current != null)
            {
                label1.Text = current.Data.ToString();
            }
            else
            {
                label1.Text = "No data";
            }
        }

       

      
    }

}
