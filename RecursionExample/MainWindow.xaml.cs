using System;
using System.Windows;

namespace RecursiveFactorialApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
        
            if (int.TryParse(InputTextBox.Text, out int number) && number >= 0)
            {
                long result = Factorial(number);
                ResultTextBlock.Text = $"Factorial of {number} is {result}.";
            }
            else
            {
                ResultTextBlock.Text = "Please enter a valid non-negative integer.";
            }
        }

        // Recursive method to calculate factorial
        private long Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //Title: Program for factorial of a number
        //Author:geeksforgeeks
        //Date: 30 july 2024
        //Version:01
        //Availability: https://www.geeksforgeeks.org/program-for-factorial-of-a-number/

        private void InputTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        
            PlaceholderTextBlock.Visibility = string.IsNullOrEmpty(InputTextBox.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
