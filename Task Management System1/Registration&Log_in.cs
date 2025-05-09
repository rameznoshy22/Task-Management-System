using System.Text;
using Task_Management_System1.Models;
using System.Security.Cryptography;
using System.Text;


namespace Task_Management_System1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            emaillogintxt = new TextBox();
            passlogintxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loginbutton = new Button();
            clearloginbutton = new Button();
            reginloginbutton = new Button();
            checkBoxpass = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(340, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 381);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // emaillogintxt
            // 
            emaillogintxt.Location = new Point(111, 146);
            emaillogintxt.Name = "emaillogintxt";
            emaillogintxt.Size = new Size(184, 23);
            emaillogintxt.TabIndex = 1;
            // 
            // passlogintxt
            // 
            passlogintxt.Location = new Point(111, 213);
            passlogintxt.Name = "passlogintxt";
            passlogintxt.Size = new Size(184, 23);
            passlogintxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 146);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(12, 213);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(111, 41);
            label3.Name = "label3";
            label3.Size = new Size(111, 90);
            label3.TabIndex = 5;
            label3.Text = "Log in\r\n\r\n";
            // 
            // loginbutton
            // 
            loginbutton.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            loginbutton.ForeColor = Color.Green;
            loginbutton.ImageAlign = ContentAlignment.MiddleRight;
            loginbutton.Location = new Point(28, 288);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(267, 43);
            loginbutton.TabIndex = 7;
            loginbutton.Text = "Log in ";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // clearloginbutton
            // 
            clearloginbutton.FlatStyle = FlatStyle.Flat;
            clearloginbutton.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            clearloginbutton.ForeColor = SystemColors.Highlight;
            clearloginbutton.ImageAlign = ContentAlignment.MiddleRight;
            clearloginbutton.Location = new Point(28, 350);
            clearloginbutton.Name = "clearloginbutton";
            clearloginbutton.Size = new Size(267, 38);
            clearloginbutton.TabIndex = 10;
            clearloginbutton.Text = "Clear";
            clearloginbutton.UseVisualStyleBackColor = true;
            clearloginbutton.Click += clearloginbutton_Click_1;
            // 
            // reginloginbutton
            // 
            reginloginbutton.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            reginloginbutton.ForeColor = SystemColors.HotTrack;
            reginloginbutton.Location = new Point(12, 425);
            reginloginbutton.Name = "reginloginbutton";
            reginloginbutton.Size = new Size(171, 38);
            reginloginbutton.TabIndex = 11;
            reginloginbutton.Text = "Register Now";
            reginloginbutton.UseVisualStyleBackColor = true;
            reginloginbutton.Click += button3_Click;
            // 
            // checkBoxpass
            // 
            checkBoxpass.AutoSize = true;
            checkBoxpass.Cursor = Cursors.Hand;
            checkBoxpass.Font = new Font("Monotype Corsiva", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBoxpass.Location = new Point(180, 242);
            checkBoxpass.Name = "checkBoxpass";
            checkBoxpass.RightToLeft = RightToLeft.Yes;
            checkBoxpass.Size = new Size(115, 19);
            checkBoxpass.TabIndex = 18;
            checkBoxpass.Text = "Show Password";
            checkBoxpass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            BackColor = SystemColors.Window;
            ClientSize = new Size(623, 493);
            Controls.Add(checkBoxpass);
            Controls.Add(reginloginbutton);
            Controls.Add(clearloginbutton);
            Controls.Add(loginbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passlogintxt);
            Controls.Add(emaillogintxt);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration&Log_in";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // Set the PasswordChar property to '*' by default
            passlogintxt.PasswordChar = '*';

            // Add event handler for the "Show Password" checkbox
            checkBoxpass.CheckedChanged += checkBoxpass_CheckedChanged;
        }

        private PictureBox pictureBox1;
        private TextBox emaillogintxt;
        private TextBox passlogintxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button clearloginbutton;
        private Button reginloginbutton;
        private CheckBox checkBoxpass;
        private Button loginbutton;

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string email = emaillogintxt.Text;
            string password = passlogintxt.Text;

            // Validate email and password
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the email and password exist in the database using EF Code First
            int userId = ValidateUser(email, password);

            if (userId > 0)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the main application form (Form3) and pass the user ID
                Form3 mainForm = new Form3(userId);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to validate user credentials using EF Code First
        private int ValidateUser(string email, string password)
        {
            using (var context = new TaskManagementContext())
            {
                try
                {
                    // Query the database to check if the user exists
                    var user = context.Users
                        .FirstOrDefault(u => u.Email == email && u.Password == password);

                    // If user is found, return their UserId
                    return user?.Id ?? 0;
                }
                catch (Exception ex)
                {
                    // Handle any errors (e.g., log the error or show a message)
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }

        // Method to hash passwords (if needed)
        //public static string HashPassword(string password)
        //{
        //    using (SHA256 sha256 = SHA256.Create())
        //    {
        //        byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        //        return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        //    }
        //}

        // Event handler for the "Clear" button
        //private void clearloginbutton_Click(object sender, EventArgs e)
        //{
        //    // Clear the email and password fields
        //    emaillogintxt.Clear();
        //    passlogintxt.Clear();
        //}

        // Event handler for the "Register Now" button
        private void reginloginbutton_Click(object sender, EventArgs e)
        {
            // Open the registration form (Form2)
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        // Event handler for the "Show Password" checkbox
        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (checkBoxpass.Checked)
            {
                // Show password
                passlogintxt.PasswordChar = '\0'; // Null character (no masking)
            }
            else
            {
                // Hide password
                passlogintxt.PasswordChar = '*';
            }
        }

        private void clearloginbutton_Click_1(object sender, EventArgs e)
        {
            emaillogintxt.Clear();
            passlogintxt.Clear();
        }
        
    }
}
