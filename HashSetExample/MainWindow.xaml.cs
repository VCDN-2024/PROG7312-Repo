using System.Collections.Generic;
using System.Windows;

namespace StudentRosterApp
{
    public partial class MainWindow : Window
    {
        private HashSet<string> studentSet = new HashSet<string>();
        //HashSet: Efficiently manages a collection of unique elements.
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            string studentName = StudentNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Please enter a valid student name.");
                return;
            }

    
            if (studentSet.Add(studentName))
            {
                MessageBox.Show($"Student '{studentName}' added successfully.");
            }
            else
            {
                MessageBox.Show($"Student '{studentName}' is already in the roster.");
            }

            StudentNameTextBox.Clear();
        }

        private void RemoveStudentButton_Click(object sender, RoutedEventArgs e)
        {
            string studentName = StudentNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Please enter a valid student name.");
                return;
            }

            if (studentSet.Remove(studentName))
            {
                MessageBox.Show($"Student '{studentName}' removed successfully.");
            }
            else
            {
                MessageBox.Show($"Student '{studentName}' not found in the roster.");
            }

            StudentNameTextBox.Clear();
        }

        private void DisplayStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            StudentListBox.Items.Clear();

            if (studentSet.Count == 0)
            {
                MessageBox.Show("No students in the roster.");
                return;
            }

     
            foreach (string student in studentSet)
            {
                StudentListBox.Items.Add(student);
            }
        }

        private void ClearListButton_Click(object sender, RoutedEventArgs e)
        {
            studentSet.Clear(); 
            StudentListBox.Items.Clear(); 
            MessageBox.Show("Student roster cleared.");
        }
    }
}
