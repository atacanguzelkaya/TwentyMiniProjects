namespace Project8_RapidApiCurrency
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblDollar = new System.Windows.Forms.Label();
			this.lblEuro = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rdbDollar = new System.Windows.Forms.RadioButton();
			this.rdbEuro = new System.Windows.Forms.RadioButton();
			this.btnProcess = new System.Windows.Forms.Button();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblPound = new System.Windows.Forms.Label();
			this.rdbPound = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// lblDollar
			// 
			this.lblDollar.AutoSize = true;
			this.lblDollar.Location = new System.Drawing.Point(12, 9);
			this.lblDollar.Name = "lblDollar";
			this.lblDollar.Size = new System.Drawing.Size(35, 13);
			this.lblDollar.TabIndex = 0;
			this.lblDollar.Text = "label1";
			// 
			// lblEuro
			// 
			this.lblEuro.AutoSize = true;
			this.lblEuro.Location = new System.Drawing.Point(113, 9);
			this.lblEuro.Name = "lblEuro";
			this.lblEuro.Size = new System.Drawing.Size(35, 13);
			this.lblEuro.TabIndex = 1;
			this.lblEuro.Text = "label2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Unit Amount:";
			// 
			// rdbDollar
			// 
			this.rdbDollar.AutoSize = true;
			this.rdbDollar.Location = new System.Drawing.Point(12, 49);
			this.rdbDollar.Name = "rdbDollar";
			this.rdbDollar.Size = new System.Drawing.Size(52, 17);
			this.rdbDollar.TabIndex = 5;
			this.rdbDollar.TabStop = true;
			this.rdbDollar.Text = "Dollar";
			this.rdbDollar.UseVisualStyleBackColor = true;
			// 
			// rdbEuro
			// 
			this.rdbEuro.AutoSize = true;
			this.rdbEuro.Location = new System.Drawing.Point(116, 49);
			this.rdbEuro.Name = "rdbEuro";
			this.rdbEuro.Size = new System.Drawing.Size(47, 17);
			this.rdbEuro.TabIndex = 6;
			this.rdbEuro.TabStop = true;
			this.rdbEuro.Text = "Euro";
			this.rdbEuro.UseVisualStyleBackColor = true;
			// 
			// btnProcess
			// 
			this.btnProcess.Location = new System.Drawing.Point(116, 137);
			this.btnProcess.Name = "btnProcess";
			this.btnProcess.Size = new System.Drawing.Size(100, 23);
			this.btnProcess.TabIndex = 8;
			this.btnProcess.Text = "Process";
			this.btnProcess.UseVisualStyleBackColor = true;
			this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.Location = new System.Drawing.Point(116, 85);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
			this.txtUnitPrice.TabIndex = 9;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Location = new System.Drawing.Point(116, 111);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
			this.txtTotalPrice.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 118);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Amount Payable:";
			// 
			// lblPound
			// 
			this.lblPound.AutoSize = true;
			this.lblPound.Location = new System.Drawing.Point(214, 9);
			this.lblPound.Name = "lblPound";
			this.lblPound.Size = new System.Drawing.Size(35, 13);
			this.lblPound.TabIndex = 12;
			this.lblPound.Text = "label2";
			// 
			// rdbPound
			// 
			this.rdbPound.AutoSize = true;
			this.rdbPound.Location = new System.Drawing.Point(217, 49);
			this.rdbPound.Name = "rdbPound";
			this.rdbPound.Size = new System.Drawing.Size(56, 17);
			this.rdbPound.TabIndex = 13;
			this.rdbPound.TabStop = true;
			this.rdbPound.Text = "Pound";
			this.rdbPound.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 182);
			this.Controls.Add(this.rdbPound);
			this.Controls.Add(this.lblPound);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtUnitPrice);
			this.Controls.Add(this.btnProcess);
			this.Controls.Add(this.rdbEuro);
			this.Controls.Add(this.rdbDollar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblEuro);
			this.Controls.Add(this.lblDollar);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDollar;
		private System.Windows.Forms.Label lblEuro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rdbDollar;
		private System.Windows.Forms.RadioButton rdbEuro;
		private System.Windows.Forms.Button btnProcess;
		private System.Windows.Forms.TextBox txtUnitPrice;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblPound;
		private System.Windows.Forms.RadioButton rdbPound;
	}
}

