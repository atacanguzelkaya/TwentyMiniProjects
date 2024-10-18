using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project10_PostgreSQLToDoList
{
	public partial class FrmToDoList : Form
	{
		public FrmToDoList()
		{
			InitializeComponent();
		}
		string connectionString = "Server=localHost;port=5432;Database=Db10Project20;user ID=postgres;Password=PasswordPS";
		private void FrmToDoList_Load(object sender, EventArgs e)
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
	}
}
