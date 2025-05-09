using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System1.Models;
using Task_Management_System;
using User = Task_Management_System.User;

namespace Task_Management_System1
{
    public partial class Form2 : Form
    {
        private Form1 form1; // Reference to Form1

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            // Set PasswordChar for password fields
            passwordregister.PasswordChar = '*';
            confirmpassregister.PasswordChar = '*';

            // Add event handlers for buttons
             registerbutton.Click += registerbutton_Click;
            //this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            clearbutton.Click += clearbutton_Click;
            backtologinbutton.Click += button3_Click;

            // Add event handler for "Show Password" checkbox
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void button3_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            string username = usernameregister.Text;
            string email = emailregister.Text;
            string password = passwordregister.Text;
            string confirmPassword = confirmpassregister.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save the user to the database
            try
            {
                using (var context = new TaskManagementContext())
                {
                    // Create a new user object
                    var user = new User
                    {
                        Name = username,
                        Email = email,
                        Password = password // Save the password as plain text (not recommended for production)
                    };

                    // Add the user to the database
                    context.Users.Add(user);
                    context.SaveChanges();
                }

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form after successful registration
               clearbutton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            usernameregister.Clear();
            emailregister.Clear();
            passwordregister.Clear();
            confirmpassregister.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (checkBox1.Checked)
            {
                passwordregister.PasswordChar = '\0'; // Show password
                confirmpassregister.PasswordChar = '\0';
            }
            else
            {
                passwordregister.PasswordChar = '*'; // Hide password
                confirmpassregister.PasswordChar = '*';
            }
        }
    }
}
