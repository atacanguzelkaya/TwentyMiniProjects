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
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}

		SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=DbCustomer; Integrated Security=true; TrustServerCertificate=True");
		private void btnList_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();

			SqlCommand sqlCommand = new SqlCommand("select CustomerId, CustomerName, CustomerSurname, CustomerBalance, CityName, CustomerStatus from TblCustomer inner join TblCity on TblCity.CityId = TblCustomer.CustomerCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;

			sqlConnection.Close();
		}
		private void btnProcedure_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("Execute CustomerListWithCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}
		private void FrmCustomer_Load(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand("Select * From TblCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			cmbCity.ValueMember = "CityId";
			cmbCity.DisplayMember = "CityName";
			cmbCity.DataSource = dataTable;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("insert into TblCustomer (CustomerName,CustomerSurname,CustomerBalance,CustomerCity,CustomerStatus) values (@customerName, @customerSurname, @customerBalance, @customerCity, @customerStatus)", sqlConnection);
			sqlCommand.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			sqlCommand.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
			sqlCommand.Parameters.AddWithValue("@customerBalance", txtCustomerBalance.Text);
			sqlCommand.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
			if (rdbActive.Checked)
			{
				sqlCommand.Parameters.AddWithValue("@customerStatus", true);
			}
			if (rdbPassive.Checked)
			{
				sqlCommand.Parameters.AddWithValue("@customerStatus", false);
			}
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Customer is created successfully");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("Delete From TblCustomer Where CustomerId=@customerId", sqlConnection);
			sqlCommand.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Customer is deleted successfully", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("Update TblCustomer Set CustomerName=@customerName, CustomerSurname=@customerSurname, CustomerCity=@customerCity, CustomerBalance=@customerBalance, CustomerStatus=@customerStatus where CustomerId=@customerId", sqlConnection);
			sqlCommand.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
			sqlCommand.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			sqlCommand.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
			sqlCommand.Parameters.AddWithValue("@customerBalance", txtCustomerBalance.Text);
			sqlCommand.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
			if (rdbActive.Checked)
			{
				sqlCommand.Parameters.AddWithValue("@customerStatus", true);
			}
			if (rdbPassive.Checked)
				sqlCommand.Parameters.AddWithValue("@customerStatus", false);

			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Customer is updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("Select * From TblCustomer Where CustomerName=@customerName", sqlConnection);
			sqlCommand.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}
	}
}
