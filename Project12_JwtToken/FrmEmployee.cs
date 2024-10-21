using Project12_JwtToken.JWT;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Windows.Forms;

namespace Project12_JwtToken
{
	public partial class FrmEmployee : Form
	{
		public FrmEmployee()
		{
			InitializeComponent();
		}
		public string tokenGet;
		SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=Db12Project20; Integrated Security=true; TrustServerCertificate=True");
		private void FrmEmployee_Load(object sender, EventArgs e)
		{
			TokenValidator tokenValidator = new TokenValidator();
			var principal = tokenValidator.ValidateJwtToken(tokenGet);

			if (principal != null)
			{
				string username = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
				MessageBox.Show("Welcome: " + username);

				sqlConnection.Open();
				SqlCommand command = new SqlCommand("Select * From TblEmployee", sqlConnection);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				dataGridView1.DataSource = dataTable;
				sqlConnection.Close();
			}

			else
			{
				MessageBox.Show("Invalid Token!");
			}
		}
	}
}
