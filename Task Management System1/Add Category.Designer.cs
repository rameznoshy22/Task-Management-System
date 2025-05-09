namespace Task_Management_System1
{
    partial class Add_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Category));
            label1 = new Label();
            Registerandlogin = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 69);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 5;
            label1.Text = "Category Name";
            // 
            // Registerandlogin
            // 
            Registerandlogin.Location = new Point(204, 69);
            Registerandlogin.Name = "Registerandlogin";
            Registerandlogin.Size = new Size(184, 23);
            Registerandlogin.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.Green;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(204, 112);
            button2.Name = "button2";
            button2.Size = new Size(184, 43);
            button2.TabIndex = 8;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
           button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.Highlight;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(28, 229);
            button1.Name = "button1";
            button1.Size = new Size(154, 43);
            button1.TabIndex = 9;
            button1.Text = "Back to Tasks";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = SystemColors.Highlight;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(204, 175);
            button3.Name = "button3";
            button3.Size = new Size(184, 38);
            button3.TabIndex = 10;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Add_Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(468, 284);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(Registerandlogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_Category";
            Text = "Add_Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Registerandlogin;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}