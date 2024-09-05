using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeExample
{
    public class BookNode
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public BookNode Left { get; set; }
        public BookNode Right { get; set; }

        public BookNode(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            Left = null;
            Right = null;
        }
    }
}
