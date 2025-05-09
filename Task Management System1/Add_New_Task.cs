using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System;
using Task_Management_System1.Models;

namespace Task_Management_System1
{
    public partial class Add_New_Task : Form
    {
        private int _userId; // Store the logged-in user's ID

        public Add_New_Task(int userId)
        {
            InitializeComponent();
            _userId = userId; // Set the user ID
            LoadCategories(); // Load categories for the user
        }

        //public Add_New_Task()
        //{
        //}

        private void LoadCategories()
        {
            using (var context = new TaskManagementContext())
            {
                // Fetch all categories
                var categories = context.Categories
                    .Select(c => c.Name)
                    .ToList();

                // Add categories to the combo box
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Select Category"); // Default option
                comboBox3.Items.AddRange(categories.ToArray());
                comboBox3.SelectedIndex = 0; // Set default selection
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { // Get the input values from the form
            string title = textBox1.Text;
            string description = textBox2.Text;
            DateTime dueDate = dateTimePicker1.Value;
            string priority = comboBox1.SelectedItem?.ToString();
            TaskStatus status = (TaskStatus)comboBox2.SelectedItem; // Cast to enum
            string categoryName = comboBox3.SelectedItem?.ToString();

            // Validate inputs
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) ||
                string.IsNullOrEmpty(priority) || string.IsNullOrEmpty(categoryName) ||
                categoryName == "Select Category")
            {
                MessageBox.Show("Please fill in all fields and select a valid category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save the new task to the database
            try
            {
                using (var context = new TaskManagementContext())
                {
                    try
                    {
                        //var categories = context.Categories
                        //                    .Where(c => c.Name == categoryName)
                        //                    .ToList();

                        //var category = categories.FirstOrDefault();


                        //if (category == null)
                        //{
                        //    MessageBox.Show("Invalid category selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}

                        var category = context.Categories
                                      .SingleOrDefault(c => c.Name == categoryName);

                        if (category == null)
                        {
                            MessageBox.Show("Invalid category selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var task = new TaskItem
                        {
                            Title = title,
                            Description = description,
                            DueDate = dueDate,
                            Priority = priority,
                            Status = status,
                            UserId = _userId, // Associate the task with the logged-in user
                            CategoryId = category.Id // Associate the task with the selected category
                        };

                        // Add the task to the database
                        context.Tasks.Add(task);
                        context.SaveChanges();

                        MessageBox.Show("Task created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors (e.g., database connection issues)
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //  MessageBox.Show("Task saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the form after saving
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the task: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_New_Task_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            textBox1.Clear();
            textBox2.Clear();

            // Reset combo boxes to default values
            comboBox1.SelectedIndex = -1; // No selection
            comboBox2.SelectedIndex = -1;  // No selection
            comboBox3.SelectedIndex = -1; // No selection

            // Reset the date picker to today's date
            dateTimePicker1.Value = DateTime.Today;

            // Optionally, set focus to the first input field
            textBox1.Focus();
        }
    }
}
