namespace Task_Management_System1
{
    partial class Add_New_Task
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Task));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(71, 87);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(14, 130);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(175, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(34, 180);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 5;
            label3.Text = "DueDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 27.75F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(95, 9);
            label4.Name = "label4";
            label4.Size = new Size(246, 45);
            label4.TabIndex = 6;
            label4.Text = "New Task Data";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(46, 232);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 7;
            label5.Text = "Priority";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Low", "Medium", "High" });
            comboBox1.Location = new Point(175, 232);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.DataSource = new TaskStatus[]
    {
    TaskStatus.Pending,
    TaskStatus.InProgress,
    TaskStatus.Completed
    };
            comboBox2.FormattingEnabled = true;
           // comboBox2.Items.AddRange(new object[] { TaskStatus.Pending, TaskStatus.InProgress, TaskStatus.Completed });

            comboBox2.Location = new Point(175, 287);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(46, 287);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 9;
            label6.Text = "Status";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Select Category" });
            comboBox3.Location = new Point(175, 345);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 23);
            comboBox3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(46, 345);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 11;
            label7.Text = "Category";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(439, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 429);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.Highlight;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(108, 448);
            button1.Name = "button1";
            button1.Size = new Size(267, 38);
            button1.TabIndex = 15;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.Green;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(108, 386);
            button2.Name = "button2";
            button2.Size = new Size(267, 43);
            button2.TabIndex = 14;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Add_New_Task
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(813, 510);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_New_Task";
            Text = "Add New Task";
            Load += Add_New_Task_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox3;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}