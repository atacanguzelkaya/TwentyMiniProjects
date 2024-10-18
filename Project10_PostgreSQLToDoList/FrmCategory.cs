using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project10_PostgreSQLToDoList
{
	public partial class FrmCategory : Form
	{
		public FrmCategory()
		{
			InitializeComponent();
		}
		string connectionString = "Server=localHost;port=5432;Database=Db10Project20;user ID=postgres;Password=PasswordPS";

		void CategoryList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * From categories";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		private void FrmCategory_Load(object sender, EventArgs e)
		{
			CategoryList();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			CategoryList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = ("insert into categories (CategoryName) values (@categoryName)");
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@categoryName", txtCategoryName.Text);
				command.ExecuteNonQuery();
				MessageBox.Show("Category is created successfully");
				CategoryList();
			}
			connection.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = ("delete from categories where CategoryId=@categoryId");
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@categoryId", id);
				command.ExecuteNonQuery();
				MessageBox.Show("Category is deleted successfully");
				CategoryList();
			}
			connection.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			string categoryName = txtCategoryName.Text;
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Update Categories Set CategoryName=@categoryName where CategoryId=@categoryId";
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@categoryId", id);
				command.Parameters.AddWithValue("@categoryName", categoryName);
				command.ExecuteNonQuery();
				MessageBox.Show("Category is updated successfully");
				CategoryList();
			}
			connection.Close();
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			using (var connection = new NpgsqlConnection(connectionString))
			{
				connection.Open();
				string query = "Select * From Categories Where CategoryId=@categoryId";
				using (var command = new NpgsqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@categoryId", id);
					using (var adapter = new NpgsqlDataAdapter(command))
					{
						DataTable dataTable = new DataTable();
						adapter.Fill(dataTable);
						dataGridView1.DataSource = dataTable;
					}
				}
			}
		}
	}
}