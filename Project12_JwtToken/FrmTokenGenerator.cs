using Project12_JwtToken.JWT;
using System;
using System.Windows.Forms;

namespace Project12_JwtToken
{
	public partial class FrmTokenGenerator : Form
	{
		public FrmTokenGenerator()
		{
			InitializeComponent();
		}

		private void btnCreateToken_Click(object sender, EventArgs e)
		{

			string userName = txtUserName.Text;
			string email = txtEmail.Text;
			string name = txtName.Text;
			string surname = txtSurname.Text;
			TokenGenerator tokenGenerator = new TokenGenerator();
			string token = tokenGenerator.GenerateJWTToken(userName, email, name, surname);
			richTextBox1.Text = token;
		}
	}
}