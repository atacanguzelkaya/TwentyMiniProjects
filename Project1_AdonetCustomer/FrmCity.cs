using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_AdonetCustomer
{
	public partial class FrmCity : Form
	{
		public FrmCity()
		{
			InitializeComponent();
		}
		SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=DbCustomer; Integrated Security=true; TrustServerCertificate=True");
		private void btnList_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();

			SqlCommand sqlCommand = new SqlCommand("Select * from TblCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;

			sqlConnection.Close();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();

			SqlCommand sqlCommand = new SqlCommand("insert into TblCity (CityName,CityCountry) values (@cityName, @cityCountry)", sqlConnection);
			sqlCommand.Parameters.AddWithValue("@cityName", txtCityName.Text);
			sqlCommand.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("City is created successfully");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();

			SqlCommand sqlCommand = new SqlCommand("Delete from TblCity Where CityId=@cityId", sqlConnection);
			sqlCommand.Parameters.AddWithValue("@cityId", txtCityId.Text);
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("City is deleted successfully","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();

			SqlCommand sqlCommand = new SqlCommand("Update TblCity Set CityName=@cityName, CityCountry=@cityCountry Where CityId=@cityId", sqlConnection);
			sqlCommand.Parameters.AddWithValue("@cityId", txtCityId.Text);
			sqlCommand.Parameters.AddWithValue("@cityName", txtCityName.Text);
			sqlCommand.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("City is updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();

			SqlCommand sqlCommand = new SqlCommand("Select * From TblCity Where CityName=@cityName", sqlConnection);
			sqlCommand.Parameters.AddWithValue("@cityName", txtCityName.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;

			sqlConnection.Close();
		}
	}
}
