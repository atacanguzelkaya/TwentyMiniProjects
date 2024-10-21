using Project12_JwtToken.JWT;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project12_JwtToken
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}
		SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=Db12Project20; Integrated Security=true; TrustServerCertificate=True");
		private void btnLogin_Click(object sender, EventArgs e)
		{
			TokenGenerator tokenGenerator = new TokenGenerator();

			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select * From TblUser Where UserName=@username and Password=@password", sqlConnection);
			command.Parameters.AddWithValue("@username", txtUserName.Text);
			command.Parameters.AddWithValue("@password", txtPassword.Text);
			SqlDataReader sqlDataReader = command.ExecuteReader();
			if (sqlDataReader.Read())
			{
				string token = tokenGenerator.GenerateJwtToken2(txtUserName.Text);
				//MessageBox.Show(token);
				FrmEmployee frm = new FrmEmployee();
				frm.tokenGet = token;
				frm.Show();
			}
			else
			{
				MessageBox.Show("Incorrect username or password");
				txtUserName.Clear();
				txtPassword.Clear();
				txtUserName.Focus();
			}
			sqlConnection.Close();
		}
	}
}
