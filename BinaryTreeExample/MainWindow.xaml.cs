using BinaryTreeExample;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LibraryBinaryTree
{
    public partial class MainWindow : Window
    {
        // Binary tree root
        private BookNode root;

        public MainWindow()
        {
            InitializeComponent();

            // Set initial placeholder text
            AddPlaceholderText(BookTitleTextBox, null);
            AddPlaceholderText(AuthorTextBox, null);
            AddPlaceholderText(YearTextBox, null);
            BookTitleTextBox.Text = "Enter Book Title";
            AuthorTextBox.Text = "Enter Author";
            YearTextBox.Text = "Enter Year";
            BookTitleTextBox.Foreground = Brushes.Gray;
            AuthorTextBox.Foreground = Brushes.Gray;
            YearTextBox.Foreground = Brushes.Gray;
        }

        // Event handler for Add Book button click
        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            string title = BookTitleTextBox.Text;
            string author = AuthorTextBox.Text;
            int year;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || !int.TryParse(YearTextBox.Text, out year))
            {
                MessageBox.Show("Please enter valid book details.");
                return;
            }

            // Add book to the binary tree
            root = AddBookToTree(root, title, author, year);
            MessageBox.Show($"Book '{title}' added to the library!");

            // Clear text fields
            BookTitleTextBox.Text = "Enter Book Title";
            AuthorTextBox.Text = "Enter Author";
            YearTextBox.Text = "Enter Year";
            BookTitleTextBox.Foreground = Brushes.Gray;
            AuthorTextBox.Foreground = Brushes.Gray;
            YearTextBox.Foreground = Brushes.Gray;

            // Display the updated tree (optional, if you're rendering it visually)
            DisplayTree();
        }

        private BookNode AddBookToTree(BookNode node, string title, string author, int year)
        {
            if (node == null)
            {
                return new BookNode(title, author, year);
            }

            if (string.Compare(title, node.Title, StringComparison.OrdinalIgnoreCase) < 0)
            {
                node.Left = AddBookToTree(node.Left, title, author, year);
            }
            else
            {
                node.Right = AddBookToTree(node.Right, title, author, year);
            }

            return node;
        }

        // Placeholder methods
        private void AddPlaceholderText(object sender, RoutedEventArgs e) { /* As defined before */ }
        private void RemovePlaceholderText(object sender, RoutedEventArgs e) { /* As defined before */ }

       

       
        private void SearchBook_Click(object sender, RoutedEventArgs e)
        {
            string title = BookTitleTextBox.Text;

            if (string.IsNullOrWhiteSpace(title) || title == "Enter Book Title")
            {
                MessageBox.Show("Please enter a valid book title to search.");
                return;
            }

            // Search for the book in the binary tree
            BookNode result = SearchBookInTree(root, title);

            if (result != null)
            {
                MessageBox.Show($"Book found: {result.Title} by {result.Author}, published in {result.Year}");
            }
            else
            {
                MessageBox.Show("Book not found.");
            }
        }

        private BookNode SearchBookInTree(BookNode node, string title)
        {
            if (node == null)
            {
                return null; // Book not found
            }

            if (string.Compare(title, node.Title, System.StringComparison.OrdinalIgnoreCase) == 0)
            {
                return node; // Book found
            }

            if (string.Compare(title, node.Title, System.StringComparison.OrdinalIgnoreCase) < 0)
            {
                return SearchBookInTree(node.Left, title); // Search in the left subtree
            }
            else
            {
                return SearchBookInTree(node.Right, title); // Search in the right subtree
            }
        }
        //Title: Canvas Class
        //Author: Microsoft Learn
        //Date:n.d
        //Version:01
        //Availability: https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.canvas?view=windowsdesktop-8.0
        private void DisplayTree()
        {
            // Clear the canvas before redrawing
            TreeCanvas.Children.Clear();

            if (root != null)
            {
                // Start drawing the tree from the root node, positioned in the middle at the top
                DrawNode(root, TreeCanvas.ActualWidth / 2, 20, TreeCanvas.ActualWidth / 4);
            }
        }

        private void DrawNode(BookNode node, double x, double y, double offset)
        {
            if (node == null) return;

            // Draw the node (a rectangle with the book title inside)
            DrawBookNode(node, x, y);

            // Draw lines connecting to the left and right children
            if (node.Left != null)
            {
                DrawLine(x, y, x - offset, y + 50);
                DrawNode(node.Left, x - offset, y + 50, offset / 2);
            }

            if (node.Right != null)
            {
                DrawLine(x, y, x + offset, y + 50);
                DrawNode(node.Right, x + offset, y + 50, offset / 2);
            }
        }

        private void DrawBookNode(BookNode node, double x, double y)
        {
            // Create a rectangle to represent the node
            Rectangle rect = new Rectangle
            {
                Width = 100,
                Height = 40,
                Stroke = Brushes.Black,
                Fill = Brushes.LightBlue
            };

            // Position the rectangle on the canvas
            Canvas.SetLeft(rect, x - rect.Width / 2);
            Canvas.SetTop(rect, y);

            // Add the rectangle to the canvas
            TreeCanvas.Children.Add(rect);

            // Create a text block to display the book's title
            TextBlock textBlock = new TextBlock
            {
                Text = node.Title,
                Width = 100,
                TextAlignment = TextAlignment.Center
            };

            // Position the text block inside the rectangle
            Canvas.SetLeft(textBlock, x - rect.Width / 2);
            Canvas.SetTop(textBlock, y + 10);

            // Add the text block to the canvas
            TreeCanvas.Children.Add(textBlock);
        }

        private void DrawLine(double x1, double y1, double x2, double y2)
        {
            // Create a line connecting the parent node to the child node
            Line line = new Line
            {
                X1 = x1,
                Y1 = y1 + 20, // Start the line from the bottom of the node's rectangle
                X2 = x2,
                Y2 = y2,
                Stroke = Brushes.Black
            };

            // Add the line to the canvas
            TreeCanvas.Children.Add(line);
        }

    }



}
