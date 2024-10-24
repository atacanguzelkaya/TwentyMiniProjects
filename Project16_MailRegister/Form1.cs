using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Windows.Forms;

namespace Project16_MailRegister
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Db16Project20Entities context = new Db16Project20Entities();
		private void btnRegister_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			int confirmCode = random.Next(100000, 1000000);

			TblUser user = new TblUser();
			user.Name = txtName.Text;
			user.Surname = txtSurname.Text;
			user.Email = txtEmail.Text;
			user.Password = txtPassword.Text;
			user.IsConfirm = false;
			user.ConfirmCode = confirmCode.ToString();

			context.TblUser.Add(user);
			context.SaveChanges();

			#region Mail Codes

			MimeMessage mimeMessage = new MimeMessage();

			MailboxAddress mailboxAddressFrom = new MailboxAddress("AdminRegister", "atacanadminatacan@gmail.com");
			mimeMessage.From.Add(mailboxAddressFrom);

			MailboxAddress mailboxAddressTo = new MailboxAddress("User", txtEmail.Text);
			mimeMessage.To.Add(mailboxAddressTo);

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody = "Confirmation Code of Your Email Address: " + confirmCode;
			mimeMessage.Body = bodyBuilder.ToMessageBody();

			mimeMessage.Subject = "Email Confirmation Code";

			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Connect("smtp.gmail.com", 587, false);
			smtpClient.Authenticate("atacanadminatacan@gmail.com", "atamyatargataqat");
			smtpClient.Send(mimeMessage);
			smtpClient.Disconnect(true);

			MessageBox.Show("A verification code has been sent to your e-mail address.");

			FrmMailConfirm frm = new FrmMailConfirm();
			frm.email = txtEmail.Text;
			frm.Show();

			#endregion
		}
	}
}
