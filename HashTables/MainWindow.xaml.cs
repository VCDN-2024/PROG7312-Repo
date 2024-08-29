using System;
using System.Collections.Generic;
using System.Windows;

namespace PhonebookApp
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> phonebook = new Dictionary<string, string>(); 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddContactButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            string phoneNumber = PhoneNumberTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter a valid name and phone number.");
                return;
            }

         
            if (phonebook.TryAdd(name, phoneNumber))
            {
                MessageBox.Show($"Contact '{name}' added successfully.");
            }
            else
            {
                MessageBox.Show($"Contact '{name}' already exists. Updating the phone number.");
                phonebook[name] = phoneNumber;
            }

            NameTextBox.Clear();
            PhoneNumberTextBox.Clear();
        }

        private void RemoveContactButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }

   
            if (phonebook.Remove(name))
            {
                MessageBox.Show($"Contact '{name}' removed successfully.");
            }
            else
            {
                MessageBox.Show($"Contact '{name}' not found in the phonebook.");
            }

            NameTextBox.Clear();
        }

        private void SearchContactButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }

   
            if (phonebook.TryGetValue(name, out string phoneNumber))
            {
                MessageBox.Show($"Contact '{name}' found: {phoneNumber}");
            }
            else
            {
                MessageBox.Show($"Contact '{name}' not found in the phonebook.");
            }

            NameTextBox.Clear();
        }

        private void DisplayAllContactsButton_Click(object sender, RoutedEventArgs e)
        {
            ContactListBox.Items.Clear(); 

            if (phonebook.Count == 0)
            {
                MessageBox.Show("No contacts in the phonebook.");
                return;
            }

       
            foreach (var contact in phonebook)
            {
                ContactListBox.Items.Add($"{contact.Key}: {contact.Value}");
            }
        }

        private void ClearListButton_Click(object sender, RoutedEventArgs e)
        {
            phonebook.Clear(); 
            ContactListBox.Items.Clear(); 
            MessageBox.Show("Phonebook cleared.");
        }
    }
}
