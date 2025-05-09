using Microsoft.EntityFrameworkCore;
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
    public partial class Add_Category : Form
    {
        private TaskManagementContext _context;
        public Add_Category()
        {
            InitializeComponent();
            _context = new TaskManagementContext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string categoryName = Registerandlogin.Text.Trim();
            if (!string.IsNullOrEmpty(categoryName))
            {
                var category = new Category { Name = categoryName };

                _context.Categories.Add(category);
                _context.SaveChanges(); // Save to database

                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Registerandlogin.Clear(); // Clear text field after saving
            }
            else
            {
                MessageBox.Show("Please enter a category name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registerandlogin.Clear();// Clears the text field
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close this form
        }
    }
}
