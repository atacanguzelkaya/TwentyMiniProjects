using Dapper;
using Project5_DapperNorthwind.Dtos.CategoryDtos;
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

namespace Project5_DapperNorthwind
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=Db5Project20; Integrated Security=true; TrustServerCertificate=True");
		private async void btnCategoryList_Click(object sender, EventArgs e)
		{
			string query = "Select * From Categories";
			var values = await sqlConnection.QueryAsync<ResultCategoryDto>(query);
			dataGridView1.DataSource = values;
		}

		private async void btnCreateCategory_Click(object sender, EventArgs e)
		{
			string query = "insert into Categories (CategoryName,Description) Values (@p1,@p2)";
			var parameteres = new DynamicParameters();
			parameteres.Add("@p1", txtCategoryName.Text);
			parameteres.Add("@p2", txtCategoryDescription.Text);
			await sqlConnection.ExecuteAsync(query, parameteres);
		}

		private async void btnUpdateCategory_Click(object sender, EventArgs e)
		{
			string query = "Update Categories Set CategoryName=@categoryName,Description=@description Where CategoryId=@categoryId";
			var parameteres = new DynamicParameters();
			parameteres.Add("@categoryName", txtCategoryName.Text);
			parameteres.Add("@description", txtCategoryDescription.Text);
			parameteres.Add("@categoryId", txtCategoryId.Text);
			await sqlConnection.ExecuteAsync(query, parameteres);
		}

		private async void btnDeleteCategory_Click(object sender, EventArgs e)
		{
			string query = "Delete From Categories Where CategoryId=@categoryId";
			var parameteres = new DynamicParameters();
			parameteres.Add("@categoryId", txtCategoryId.Text);
			await sqlConnection.ExecuteAsync(query, parameteres);
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			//Category Count
			string query = "Select Count(*) From Categories";
			var categoryCount = await sqlConnection.ExecuteScalarAsync<int>(query);
			lblCategoryCount.Text = "Total Category Count: " + categoryCount;

			//Product Count
			string query2 = "Select Count(*) From Products";
			var productCount = await sqlConnection.ExecuteScalarAsync<int>(query2);
			lblProductCount.Text = "Total Product Count: " + productCount;

			//Average Product Stock Count
			string query3 = "Select Avg(UnitsInStock) From products";
			var avgProductStock = await sqlConnection.ExecuteScalarAsync<int>(query3);
			lblAvgProductStock.Text = "Average Product Count: " + avgProductStock;

			//Total Price of Seafood
			string query4 = "Select Sum(UnitPrice) From Products Where CategoryId=(Select CategoryId From Categories Where CategoryName='SeaFood')";
			var totalSeaFoodPrice = await sqlConnection.ExecuteScalarAsync<decimal>(query4);
			lblSeafoodProductTotalPrice.Text = "Total Price of Seafood: " + totalSeaFoodPrice;
		}
	}
}
