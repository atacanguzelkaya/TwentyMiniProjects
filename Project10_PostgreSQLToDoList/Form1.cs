using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project10_PostgreSQLToDoList
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string connectionString = "Server=localHost;port=5432;Database=Db10Project20;user ID=postgres;Password=PasswordPS";
		void ToDoList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * From todolists";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}
		void CategoryList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * From Categories";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			cmbCategory.DisplayMember = "CategoryName";
			cmbCategory.ValueMember = "CategoryId";
			cmbCategory.DataSource = dataTable;
			connection.Close();
		}
		private void btnCategoryList_Click(object sender, EventArgs e)
		{
			FrmCategory frmCategory = new FrmCategory();
			frmCategory.Show();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			ToDoList();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			ToDoList();
			CategoryList();
		}

		private void btnAllList_Click(object sender, EventArgs e)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select todolistid,title,description,status,priority,categoryname from todolists inner join categories on todolists.categoryid=categories.categoryid";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
			string title = txtTitle.Text;
			string priority = txtPriority.Text;
			string description = txtDescription.Text;
			bool status = false;
			if (rdbCompleted.Checked) { status = true; }
			if (rdbContinue.Checked) { status = false; }
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "insert into ToDoLists (title, description, status, priority, categoryid) values (@title, @description, @status, @priority, @categoryid)";

			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@title", title);
				command.Parameters.AddWithValue("@description", description);
				command.Parameters.AddWithValue("@status", status).NpgsqlDbType = NpgsqlDbType.Bit;
				command.Parameters.AddWithValue("@priority", priority);
				command.Parameters.AddWithValue("@categoryid", categoryId);
				command.ExecuteNonQuery();
				MessageBox.Show("Added To Do List Successfully");
				ToDoList();
			}
			connection.Close();
		}



		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Delete From ToDoLists Where todolistid=@todolistid";
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@todolistid", id);
				command.ExecuteNonQuery();
				MessageBox.Show("Deleted To Do List Successfuly");
				ToDoList();
			}
			connection.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
			string title = txtTitle.Text;
			string priority = txtPriority.Text;
			string description = txtDescription.Text;
			bool status = false;
			if (rdbCompleted.Checked) { status = true; }
			if (rdbContinue.Checked) { status = false; }
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Update ToDoLists Set Title=@title,Description=@description,status=@status,priority=@priority,categoryid=@categoryid where todolistid=@todolistid";
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@todolistid", id);
				command.Parameters.AddWithValue("@title", title);
				command.Parameters.AddWithValue("@description", description);
				command.Parameters.AddWithValue("@status", status).NpgsqlDbType = NpgsqlDbType.Bit;
				command.Parameters.AddWithValue("@priority", priority);
				command.Parameters.AddWithValue("@categoryid", categoryId);
				command.ExecuteNonQuery();
				MessageBox.Show("Updated To Do List Successfuly");
				ToDoList();
			}
			connection.Close();
		}

		private void btnCompletedList_Click(object sender, EventArgs e)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * From ToDoLists Where Status='1'";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		private void btnContinueList_Click(object sender, EventArgs e)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * From ToDoLists Where Status='0'";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}
	}
}
