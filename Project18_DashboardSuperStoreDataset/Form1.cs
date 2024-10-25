using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project18_DashboardSuperStoreDataset
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=Db17Project20; Integrated Security=true; TrustServerCertificate=True");
		private void Form1_Load(object sender, EventArgs e)
		{
			#region Widgets

			connection.Open();
			SqlCommand command = new SqlCommand("Select Count(*) From superstore", connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				lblProductCount.Text = reader[0].ToString();
			}
			connection.Close();

			connection.Open();
			SqlCommand command2 = new SqlCommand("Select Count(Distinct(State)) From superstore", connection);
			SqlDataReader reader2 = command2.ExecuteReader();
			while (reader2.Read())
			{
				lblCityCount.Text = reader2[0].ToString();
			}
			connection.Close();

			connection.Open();
			SqlCommand command3 = new SqlCommand("Select Sum(Quantity) From superstore", connection);
			SqlDataReader reader3 = command3.ExecuteReader();
			while (reader3.Read())
			{
				lblOrderQuantity.Text = reader3[0].ToString();
			}
			connection.Close();

			connection.Open();
			SqlCommand command4 = new SqlCommand("Select Count(*) From superstore where Country='Turkey'", connection);
			SqlDataReader reader4 = command4.ExecuteReader();
			while (reader4.Read())
			{
				lblOrderbyTurkiye.Text = reader4[0].ToString();
			}
			connection.Close();

			#endregion

			#region Charts

			chart1.Series["Series1"].Points.AddXY("Milano", 53);
			chart1.Series["Series1"].Points.AddXY("Paris", 47);
			chart1.Series["Series1"].Points.AddXY("Roma", 66);

			chart2.Series["Series1"].Points.AddXY("Milano", 53);
			chart2.Series["Series1"].Points.AddXY("Paris", 47);
			chart2.Series["Series1"].Points.AddXY("Roma", 66);

			chart3.Series["Series1"].Points.AddXY("Milano", 53);
			chart3.Series["Series1"].Points.AddXY("Paris", 47);
			chart3.Series["Series1"].Points.AddXY("Roma", 66);

			#endregion
		}
	}
}
