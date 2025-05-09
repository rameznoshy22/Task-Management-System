using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Task_Management_System1
{
    public partial class Form3 : Form
    {
        //private const int pagesize = 10;
        //private int currentpageindex = 1;
        //private int totalpagesindex = 0;
        //private int totalrows = 0;
        private int currentPage = 1;
        private int pageSize = 5; // Adjust as needed
        private int totalPages = 1;
        private int totalTasks = 0;
        //private int _userId = 1; // 

        private int _userId; // Store the logged-in user's ID

        public Form3(int userId)
        {
            InitializeComponent();
            _userId = userId; // Set the user ID
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadUserTasks(); // Load tasks for the user when the form loads
            //currentpageindex = 1;
            //currentpage.Text=currentpageindex.ToString();
            // Customize DataGridView columns
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Add TaskNumber column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TaskNumber",
                HeaderText = "Task #",
                Width = 50
            });

            // Add other columns
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Title",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Width = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DueDate",
                HeaderText = "Due Date",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Priority",
                HeaderText = "Priority",
                Width = 100
            });

            //using (var db = new TaskManagementContext())
            //{
            //    var categories = db.Categories
            //        .Where(c => db.Tasks.Any(t => t.UserId == _userId && t.CategoryId == c.Id))
            //        .Select(c => new { c.Id, c.Name }) // Assuming Category has Id and Name
            //        .ToList();

            //    categorycombobox.DataSource = categories;
            //    categorycombobox.DisplayMember = "Name";
            //    categorycombobox.ValueMember = "Id";
            //}


            // Populate Status ComboBox with Enum values
            statuscombobox.DataSource = Enum.GetValues(typeof(TaskStatus));
            // statusComboBox.DataSource = Enum.GetValues(typeof(TaskStatus));

            // 🛑 Load all tasks initially (No filtering by status)
            //  LoadAllTasks();

            LoadUserTasks(); // Load tasks for the user when the form loads

            // Customize DataGridView columns
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Add TaskNumber column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TaskNumber",
                HeaderText = "Task #",
                Width = 50
            });

            // Add other columns
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Title",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Width = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DueDate",
                HeaderText = "Due Date",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Priority",
                HeaderText = "Priority",
                Width = 100
            });



        }
        // Load all tasks without filtering
        //private void LoadAllTasks()
        //{
        //    using (var db = new TaskManagementContext())
        //    {
        //        var allTasks = db.Tasks
        //            .Where(t => t.UserId == _userId) // Load only user's tasks
        //            .ToList();

        //        dataGridView1.DataSource = allTasks;
        //    }
        //}

        //private void LoadUserTasks()
        //{
        //    using (var context = new TaskManagementContext())
        //    {

        //        // Fetch tasks for the logged-in user, ordered by TaskId (or any other criteria)
        //        var tasks = context.Tasks
        //            .Where(t => t.UserId == _userId)
        //            .OrderBy(t => t.Id) // Order by TaskId or another field
        //            .Select(t => new
        //            {
        //                TaskNumber = 0, // Placeholder, will be updated below
        //                t.Id,
        //                t.Title,
        //                t.Description,
        //                t.DueDate,
        //                t.Status,
        //                t.Priority
        //            })
        //            .ToList();

        //        // Assign user-specific task numbers starting from 1

        //        for (int i = 0; i < tasks.Count; i++)
        //        {
        //            tasks[i] = new
        //            {
        //                TaskNumber = i + 1, // Assign sequential numbers starting from 1
        //                tasks[i].Id,
        //                tasks[i].Title,
        //                tasks[i].Description,
        //                tasks[i].DueDate,
        //                tasks[i].Status,
        //                tasks[i].Priority
        //            };
        //        }
        //        //totalrows = tasks.Count;
        //        //numberoftasks.Text=totalrows.ToString();
        //        //totalpagesindex=(int)Math.Ceiling((double)totalrows/pagesize);
        //        //totalpages.Text=totalpagesindex.ToString();

        //        // Bind the tasks to the DataGridView
        //        //dataGridView1.DataSource = tasks;
        //        // Convert List to DataTable
        //        DataTable taskTable = ConvertToDataTable(tasks);

        //        // Create DataView and assign to DataGridView
        //        DataView dataView = new DataView(taskTable);
        //        dataGridView1.DataSource = dataView;

        //    }
        //}
        private void LoadUserTasks()
        {
            using (var context = new TaskManagementContext())
            {
                // Get total number of user tasks
                totalTasks = context.Tasks.Count(t => t.UserId == _userId);
                totalPages = (int)Math.Ceiling((double)totalTasks / pageSize);

                // Fetch paginated tasks
                var tasks = context.Tasks
                    .Where(t => t.UserId == _userId)
                    .OrderBy(t => t.Id) // Adjust sorting as needed
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                // Convert tasks to anonymous object list with task numbers
                var paginatedTasks = tasks.Select((t, index) => new
                {
                    TaskNumber = ((currentPage - 1) * pageSize) + index + 1, // Sequential numbering per page
                    t.Id,
                    t.Title,
                    t.Description,
                    t.DueDate,
                    t.Status,
                    t.Priority
                }).ToList();

                // Convert to DataTable and bind to DataGridView
                DataTable taskTable = ConvertToDataTable(paginatedTasks);
                dataGridView1.DataSource = new DataView(taskTable);

                // Update pagination UI
                numberoftasks.Text = totalTasks.ToString();
                currentpage.Text = currentPage.ToString();
                totalpages.Text = totalPages.ToString();
                previousbutton.Enabled = currentPage > 1;
                nextbutton.Enabled = currentPage < totalPages;
            }
        }


        private void newtaskbutton_Click(object sender, EventArgs e)
        {
            // Open the Add_New_Task form without closing the current form
            Add_New_Task addNewTaskForm = new Add_New_Task(_userId);

            // Refresh the task list when the Add_New_Task form is closed
            addNewTaskForm.FormClosed += (s, args) => LoadUserTasks();

            addNewTaskForm.Show();
        }

        private void newcategorybutton_Click(object sender, EventArgs e)
        {
            Add_Category addCategoryForm = new Add_Category();
            addCategoryForm.ShowDialog(); // Open as a modal dialog
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            // Open the login form
            Form1 loginForm = new Form1();
            loginForm.Show();

            // Close the current form
            this.Close();
        }

        private DataTable ConvertToDataTable<T>(List<T> data)
        {
            DataTable table = new DataTable();
            var properties = typeof(T).GetProperties();

            // Add columns
            foreach (var prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            // Add rows
            foreach (var item in data)
            {
                DataRow row = table.NewRow();
                foreach (var prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }
        // TaskManagementContext context = new TaskManagementContext();
        // Button Click Event to Sort Tasks by Priority
        private void prioritybutton_Click(object sender, EventArgs e)
        {

            using (var context = new TaskManagementContext())
            {
                // Fetch tasks for the logged-in user, ordered by TaskId (or any other criteria)
                var tasks = context.Tasks
                    .Where(t => t.UserId == _userId)
                    .OrderBy(task => task.Priority == "Low" ? 1
                  : task.Priority == "Medium" ? 2
                  : 3) // Default: "High" is highest // Sort by Priority
                    .Select(t => new
                    {
                        TaskNumber = 0, // Placeholder, will be updated below
                        t.Id,
                        t.Title,
                        t.Description,
                        t.DueDate,
                        t.Status,
                        t.Priority
                    })
                    .ToList();

                for (int i = 0; i < tasks.Count; i++)
                {
                    tasks[i] = new
                    {
                        TaskNumber = i + 1, // Assign sequential numbers starting from 1
                        tasks[i].Id,
                        tasks[i].Title,
                        tasks[i].Description,
                        tasks[i].DueDate,
                        tasks[i].Status,
                        tasks[i].Priority
                    };
                }
                totalTasks = tasks.Count;
                numberoftasks.Text = totalTasks.ToString();
                totalPages = (int)Math.Ceiling((double)totalTasks / pageSize);
                totalpages.Text = totalPages.ToString();

                // Convert List to DataTable
                DataTable taskTable = ConvertToDataTable(tasks);

                // Create DataView and assign to DataGridView
                DataView dataView = new DataView(taskTable);
                dataGridView1.DataSource = dataView;

            }

        }

        private void statuscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statuscombobox.SelectedItem != null)
            {
                TaskStatus selectedStatus = (TaskStatus)statuscombobox.SelectedItem;

                using (var db = new TaskManagementContext())
                {
                    var filteredTasks = db.Tasks
                        .Where(t => t.UserId == _userId && t.Status == selectedStatus)
                         .Select(t => new
                         {
                             TaskNumber = 0, // Placeholder, will be updated below
                             t.Id,
                             t.Title,
                             t.Description,
                             t.DueDate,
                             t.Status,
                             t.Priority
                         })
                        .ToList();

                    for (int i = 0; i < filteredTasks.Count; i++)
                    {
                        filteredTasks[i] = new
                        {
                            TaskNumber = i + 1, // Assign sequential numbers starting from 1
                            filteredTasks[i].Id,
                            filteredTasks[i].Title,
                            filteredTasks[i].Description,
                            filteredTasks[i].DueDate,
                            filteredTasks[i].Status,
                            filteredTasks[i].Priority
                        };
                    }
                    //totalrows = filteredTasks.Count;
                    //numberoftasks.Text = totalrows.ToString();
                    //totalpagesindex = (int)Math.Ceiling((double)totalrows / pagesize);
                    //totalpages.Text = totalpagesindex.ToString();
                    totalTasks = filteredTasks.Count;
                    numberoftasks.Text = totalTasks.ToString();
                    totalPages = (int)Math.Ceiling((double)totalTasks / pageSize);
                    totalpages.Text = totalPages.ToString();

                    // Convert List to DataTable
                    DataTable taskTable = ConvertToDataTable(filteredTasks);

                    // Create DataView and assign to DataGridView
                    DataView dataView = new DataView(taskTable);
                    dataGridView1.DataSource = dataView;
                    //  dataGridView1.DataSource = filteredTasks;
                }
            }

        }

        private void No_filter_Click(object sender, EventArgs e)
        {
            LoadUserTasks(); // Load tasks for the user when the form loads

            // Customize DataGridView columns
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Add TaskNumber column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TaskNumber",
                HeaderText = "Task #",
                Width = 50
            });

            // Add other columns
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Title",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Width = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DueDate",
                HeaderText = "Due Date",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Priority",
                HeaderText = "Priority",
                Width = 100
            });


        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchText = search.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadUserTasks(); // Load tasks for the user when the form loads

                // Customize DataGridView columns
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

                // Add TaskNumber column
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TaskNumber",
                    HeaderText = "Task #",
                    Width = 50
                });

                // Add other columns
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Title",
                    HeaderText = "Title",
                    Width = 150
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Description",
                    HeaderText = "Description",
                    Width = 200
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "DueDate",
                    HeaderText = "Due Date",
                    Width = 100
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Status",
                    HeaderText = "Status",
                    Width = 100
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Priority",
                    HeaderText = "Priority",
                    Width = 100
                });



            }
            else
            {
                using (var db = new TaskManagementContext())
                {

                    // Filter tasks where the title starts with the search text
                    var filteredTasks = db.Tasks
                    .Where(t => t.Title.ToLower().StartsWith(searchText))
                    .Select(t => new
                    {
                        TaskNumber = 0, // Placeholder, will be updated below
                        t.Id,
                        t.Title,
                        t.Description,
                        t.DueDate,
                        t.Status,
                        t.Priority
                    })
                    .ToList();

                    for (int i = 0; i < filteredTasks.Count; i++)
                    {
                        filteredTasks[i] = new
                        {
                            TaskNumber = i + 1, // Assign sequential numbers starting from 1
                            filteredTasks[i].Id,
                            filteredTasks[i].Title,
                            filteredTasks[i].Description,
                            filteredTasks[i].DueDate,
                            filteredTasks[i].Status,
                            filteredTasks[i].Priority
                        };
                    }
                    //totalrows = filteredTasks.Count;
                    //numberoftasks.Text = totalrows.ToString();
                    //totalpagesindex = (int)Math.Ceiling((double)totalrows / pagesize);
                    //totalpages.Text = totalpagesindex.ToString();

                    // Convert List to DataTable
                    DataTable taskTable = ConvertToDataTable(filteredTasks);

                    // Create DataView and assign to DataGridView
                    DataView dataView = new DataView(taskTable);
                    dataGridView1.DataSource = dataView;
                    //  dataGridView1.DataSource = filteredTasks;

                }
            }
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {

            if (currentPage < totalPages)
            {
                currentPage++;
                LoadUserTasks();
            }
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadUserTasks();
            }
        }

        //private int selectedTaskId = -1; // Store the selected task ID

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0) // Ensure a valid row is clicked
        //    {
        //        selectedTaskId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
        //    }
        //}

        //private void deletebutton_Click(object sender, EventArgs e)
        //{

        //    if (selectedTaskId == -1)
        //    {
        //        MessageBox.Show("Please select a task first!");
        //        return;
        //    }

        //    DialogResult result = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo);
        //    if (result == DialogResult.Yes)
        //    {
        //        using (var context = new TaskManagementContext())
        //        {
        //            var task = context.Tasks.Find(selectedTaskId);
        //            if (task != null)
        //            {
        //                context.Tasks.Remove(task);
        //                context.SaveChanges();
        //                MessageBox.Show("Task deleted successfully!");
        //                LoadUserTasks(); // Refresh the grid
        //            }
        //        }
        //    }
        //}

        //private void updatebutton_Click(object sender, EventArgs e)
        //{
        //    if (selectedTaskId == -1)
        //    {
        //        MessageBox.Show("Please select a task first!");
        //        return;
        //    }

        //    using (var context = new TaskManagementContext())
        //    {
        //        var task = context.Tasks.Find(selectedTaskId);
        //        if (task != null)
        //        {
        //            // Example: Update task title (you can modify this)
        //            task.Title = "Updated Task Title";
        //            task.Status = TaskStatus.InProgress; // Change status

        //            context.SaveChanges();
        //            MessageBox.Show("Task updated successfully!");
        //            LoadUserTasks(); // Refresh the grid
        //        }
        //    }
        //}
        //private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.RowIndex >= 0) // Ensure a valid row is clicked
        //    {
        //        // Get task details from selected row
        //        int selectedTaskId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
        //        string title = dataGridView1.Rows[e.RowIndex].Cells["Title"].Value.ToString();
        //        string description = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
        //        DateTime dueDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["DueDate"].Value);
        //        string priority = dataGridView1.Rows[e.RowIndex].Cells["Priority"].Value.ToString();
        //        string status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
        //        string category = dataGridView1.Rows[e.RowIndex].Cells["Category"].Value.ToString();

        //        // Open TaskEditForm and pass the task details
        //        TaskEditForm editForm = new TaskEditForm(selectedTaskId, title, description, dueDate, priority, status, category);
        //        editForm.TaskUpdated += LoadUserTasks; // Refresh after update
        //        editForm.ShowDialog();
        //    }
        //}

        //private void updatebutton_Click(object sender, EventArgs e)
        //{
        //    DataGridView row=new DataGridView();
        //    row = dataGridView1.Rows[selectedRowIndex];

        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        // Get selected task details from DataGridView
        //        int taskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
        //        string title = dataGridView1.SelectedRows[0].Cells["Title"].Value.ToString();
        //        string description = dataGridView1.SelectedRows[0].Cells["Description"].Value.ToString();
        //        DateTime dueDate = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DueDate"].Value);
        //        string priority = dataGridView1.SelectedRows[0].Cells["Priority"].Value.ToString();
        //        string status = dataGridView1.SelectedRows[0].Cells["Status"].Value.ToString();
        //        string category = dataGridView1.SelectedRows[0].Cells["Category"].Value.ToString();

        //        // Open the TaskEditForm with selected task details
        //        TaskEditForm editForm = new TaskEditForm(taskId, title, description, dueDate, priority, status, category);
        //        editForm.Owner = this; // Set owner to allow refreshing after update
        //        editForm.ShowDialog(); // Show the edit form as a modal dialog
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a task to update.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}



        //private void categorycombobox_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}


        //private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (categorycombobox.SelectedValue is int selectedCategoryId)
        //    {
        //        using (var db = new TaskManagementContext())
        //        {
        //            var filteredTasks = db.Tasks
        //                .Where(t => t.UserId == _userId && t.CategoryId == selectedCategoryId)
        //                .ToList();

        //            dataGridView1.DataSource = filteredTasks;
        //        }
        //    }
        //}


    }
}
