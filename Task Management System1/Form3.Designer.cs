namespace Task_Management_System1
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            dataGridView1 = new DataGridView();
            newtaskbutton = new Button();
            statuscombobox = new ComboBox();
            label1 = new Label();
            prioritybutton = new Button();
            search = new TextBox();
            label2 = new Label();
            label3 = new Label();
            nextbutton = new Button();
            previousbutton = new Button();
            totaltasks = new Label();
            numberoftasks = new Label();
            page = new Label();
            currentpage = new Label();
            label8 = new Label();
            totalpages = new Label();
            newcategorybutton = new Button();
            logoutbutton = new Button();
            No_filter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(750, 234);
            dataGridView1.TabIndex = 0;
            // 
            // newtaskbutton
            // 
            newtaskbutton.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            newtaskbutton.ForeColor = Color.Green;
            newtaskbutton.Location = new Point(198, 521);
            newtaskbutton.Name = "newtaskbutton";
            newtaskbutton.Size = new Size(149, 38);
            newtaskbutton.TabIndex = 1;
            newtaskbutton.Text = "Add New Task ";
            newtaskbutton.UseVisualStyleBackColor = true;
            newtaskbutton.Click += newtaskbutton_Click;
            // 
            // statuscombobox
            // 
            statuscombobox.FormattingEnabled = true;
            statuscombobox.Location = new Point(410, 425);
            statuscombobox.Name = "statuscombobox";
            statuscombobox.Size = new Size(160, 23);
            statuscombobox.TabIndex = 2;
            statuscombobox.SelectedIndexChanged += statuscombobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(410, 387);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 4;
            label1.Text = "Filter By Status";
            // 
            // prioritybutton
            // 
            prioritybutton.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            prioritybutton.ForeColor = SystemColors.Highlight;
            prioritybutton.Location = new Point(19, 399);
            prioritybutton.Name = "prioritybutton";
            prioritybutton.Size = new Size(117, 61);
            prioritybutton.TabIndex = 5;
            prioritybutton.Text = "Group By Priority";
            prioritybutton.UseVisualStyleBackColor = true;
            prioritybutton.Click += prioritybutton_Click;
            // 
            // search
            // 
            search.Location = new Point(147, 425);
            search.Name = "search";
            search.Size = new Size(239, 23);
            search.TabIndex = 7;
            search.TextChanged += search_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(171, 387);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 8;
            label2.Text = "Search By Task Title";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 21;
            // 
            // nextbutton
            // 
            nextbutton.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            nextbutton.ForeColor = SystemColors.MenuText;
            nextbutton.Image = (Image)resources.GetObject("nextbutton.Image");
            nextbutton.ImageAlign = ContentAlignment.MiddleRight;
            nextbutton.Location = new Point(410, 311);
            nextbutton.Name = "nextbutton";
            nextbutton.Size = new Size(134, 38);
            nextbutton.TabIndex = 11;
            nextbutton.Text = "Next";
            nextbutton.TextAlign = ContentAlignment.MiddleLeft;
            nextbutton.UseVisualStyleBackColor = true;
            nextbutton.Click += nextbutton_Click;
            // 
            // previousbutton
            // 
            previousbutton.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            previousbutton.ForeColor = SystemColors.MenuText;
            previousbutton.Image = (Image)resources.GetObject("previousbutton.Image");
            previousbutton.ImageAlign = ContentAlignment.MiddleLeft;
            previousbutton.Location = new Point(221, 311);
            previousbutton.Name = "previousbutton";
            previousbutton.Size = new Size(134, 38);
            previousbutton.TabIndex = 12;
            previousbutton.Text = "Previous";
            previousbutton.TextAlign = ContentAlignment.MiddleRight;
            previousbutton.UseVisualStyleBackColor = true;
            previousbutton.Click += previousbutton_Click;
            // 
            // totaltasks
            // 
            totaltasks.AutoSize = true;
            totaltasks.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            totaltasks.ForeColor = Color.Black;
            totaltasks.Location = new Point(69, 23);
            totaltasks.Name = "totaltasks";
            totaltasks.Size = new Size(123, 25);
            totaltasks.TabIndex = 13;
            totaltasks.Text = "Total Tasks :";
            // 
            // numberoftasks
            // 
            numberoftasks.AutoSize = true;
            numberoftasks.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            numberoftasks.ForeColor = Color.Black;
            numberoftasks.Location = new Point(198, 23);
            numberoftasks.Name = "numberoftasks";
            numberoftasks.Size = new Size(22, 25);
            numberoftasks.TabIndex = 14;
            numberoftasks.Text = "0";
            // 
            // page
            // 
            page.AutoSize = true;
            page.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            page.ForeColor = Color.Black;
            page.Location = new Point(525, 23);
            page.Name = "page";
            page.Size = new Size(64, 25);
            page.TabIndex = 15;
            page.Text = "Page :";
            // 
            // currentpage
            // 
            currentpage.AutoSize = true;
            currentpage.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            currentpage.ForeColor = Color.Black;
            currentpage.Location = new Point(595, 23);
            currentpage.Name = "currentpage";
            currentpage.Size = new Size(22, 25);
            currentpage.TabIndex = 16;
            currentpage.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(632, 23);
            label8.Name = "label8";
            label8.Size = new Size(39, 25);
            label8.TabIndex = 17;
            label8.Text = "OF";
            // 
            // totalpages
            // 
            totalpages.AutoSize = true;
            totalpages.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            totalpages.ForeColor = Color.Black;
            totalpages.Location = new Point(699, 23);
            totalpages.Name = "totalpages";
            totalpages.Size = new Size(22, 25);
            totalpages.TabIndex = 18;
            totalpages.Text = "0";
            // 
            // newcategorybutton
            // 
            newcategorybutton.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            newcategorybutton.ForeColor = Color.Indigo;
            newcategorybutton.Location = new Point(410, 521);
            newcategorybutton.Name = "newcategorybutton";
            newcategorybutton.Size = new Size(148, 38);
            newcategorybutton.TabIndex = 19;
            newcategorybutton.Text = "Add Category";
            newcategorybutton.UseVisualStyleBackColor = true;
            newcategorybutton.Click += newcategorybutton_Click;
            // 
            // logoutbutton
            // 
            logoutbutton.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            logoutbutton.ForeColor = Color.Red;
            logoutbutton.Location = new Point(19, 510);
            logoutbutton.Name = "logoutbutton";
            logoutbutton.Size = new Size(117, 61);
            logoutbutton.TabIndex = 20;
            logoutbutton.Text = "LogOut";
            logoutbutton.UseVisualStyleBackColor = true;
            logoutbutton.Click += logoutbutton_Click;
            // 
            // No_filter
            // 
            No_filter.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Bold | FontStyle.Italic);
            No_filter.ForeColor = Color.MediumBlue;
            No_filter.Location = new Point(632, 410);
            No_filter.Name = "No_filter";
            No_filter.Size = new Size(149, 38);
            No_filter.TabIndex = 22;
            No_filter.Text = "No Filters";
            No_filter.UseVisualStyleBackColor = true;
            No_filter.Click += No_filter_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(780, 594);
            Controls.Add(No_filter);
            Controls.Add(logoutbutton);
            Controls.Add(newcategorybutton);
            Controls.Add(totalpages);
            Controls.Add(label8);
            Controls.Add(currentpage);
            Controls.Add(page);
            Controls.Add(numberoftasks);
            Controls.Add(totaltasks);
            Controls.Add(previousbutton);
            Controls.Add(nextbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(search);
            Controls.Add(prioritybutton);
            Controls.Add(label1);
            Controls.Add(statuscombobox);
            Controls.Add(newtaskbutton);
            Controls.Add(dataGridView1);
            ForeColor = Color.IndianRed;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Tasks";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button newtaskbutton;
        private ComboBox statuscombobox;
        private Label label1;
        private Button prioritybutton;
        private TextBox search;
        private Label label2;
        private Label label3;
        private Button nextbutton;
        private Button previousbutton;
        private Label totaltasks;
        private Label numberoftasks;
        private Label page;
        private Label currentpage;
        private Label label8;
        private Label totalpages;
        private Button newcategorybutton;
        private Button logoutbutton;
        private Button No_filter;
    }
}