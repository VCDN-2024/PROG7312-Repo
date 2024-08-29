using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PrintJobQueueExample
{
    public partial class MainWindow : Window
    {
       
        private PriorityQueue<PrintJob, int> printQueue = new PriorityQueue<PrintJob, int>();

        public MainWindow()
        {
            InitializeComponent();
        }

     
        private void AddPrintJobButton_Click(object sender, RoutedEventArgs e)
        {
            string documentName = DocumentNameTextBox.Text;
            string jobPriority = ((ComboBoxItem)JobPriorityComboBox.SelectedItem)?.Content.ToString();

            if (string.IsNullOrWhiteSpace(documentName) || string.IsNullOrWhiteSpace(jobPriority))
            {
                MessageBox.Show("Please enter a valid document name and select a job priority.");
                return;
            }

            int priority = GetPriorityFromJobType(jobPriority);

            PrintJob newJob = new PrintJob(documentName, jobPriority);
            printQueue.Enqueue(newJob, priority);

         
            DocumentNameTextBox.Clear();
            JobPriorityComboBox.SelectedIndex = -1;
            UpdatePrintQueueDisplay();
        }

        // Determine priority based on job type
        private int GetPriorityFromJobType(string jobType)
        {
            return jobType switch
            {
                "Urgent" => 1,  // Highest priority
                "High" => 2,
                "Normal" => 3,
                "Low" => 4,      // Lowest priority
                _ => 5
            };
        }

     
        private void ProcessNextPrintJobButton_Click(object sender, RoutedEventArgs e)
        {
            if (printQueue.TryDequeue(out PrintJob nextJob, out int priority))
            {
                MessageBox.Show($"Processing print job: {nextJob.DocumentName} ({nextJob.JobType})");
                UpdatePrintQueueDisplay();
            }
            else
            {
                MessageBox.Show("No print jobs in the queue.");
            }
        }

        // Update the display of the print queue in the ListBox
        private void UpdatePrintQueueDisplay()
        {
            PrintQueueListBox.Items.Clear();
            foreach (var job in printQueue.UnorderedItems)
            {
                PrintQueueListBox.Items.Add($"{job.Element.DocumentName} ({job.Element.JobType}) - Priority: {job.Priority}");
            }
        }
    }

    // PrintJob class to store print job information
    public class PrintJob
    {
        public string DocumentName { get; set; }
        public string JobType { get; set; }

        public PrintJob(string documentName, string jobType)
        {
            DocumentName = documentName;
            JobType = jobType;
        }
    }
}
