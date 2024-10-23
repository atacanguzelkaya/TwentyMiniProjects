namespace Project15_GasPriceSimulation
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtGasAmount = new System.Windows.Forms.TextBox();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnStart = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtGasolinePrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDieselPrice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtLpgPrice = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdbGasoline = new System.Windows.Forms.RadioButton();
			this.rdbDiesel = new System.Windows.Forms.RadioButton();
			this.rdbLpg = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(167, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gas Price Simulation";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(12, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Gas Amount:";
			// 
			// txtGasAmount
			// 
			this.txtGasAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtGasAmount.Location = new System.Drawing.Point(125, 131);
			this.txtGasAmount.Name = "txtGasAmount";
			this.txtGasAmount.Size = new System.Drawing.Size(144, 26);
			this.txtGasAmount.TabIndex = 2;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTotalPrice.Location = new System.Drawing.Point(125, 163);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(144, 26);
			this.txtTotalPrice.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(12, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Total Price:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(12, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Filling Status:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(125, 195);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(290, 26);
			this.progressBar1.TabIndex = 6;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(203, 244);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(134, 37);
			this.btnStart.TabIndex = 7;
			this.btnStart.Text = "Start Process";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLpgPrice);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtDieselPrice);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtGasolinePrice);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(465, 68);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(219, 150);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Prices";
			// 
			// txtGasolinePrice
			// 
			this.txtGasolinePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtGasolinePrice.Location = new System.Drawing.Point(88, 29);
			this.txtGasolinePrice.Name = "txtGasolinePrice";
			this.txtGasolinePrice.Size = new System.Drawing.Size(115, 26);
			this.txtGasolinePrice.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(6, 97);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Lpg:";
			// 
			// txtDieselPrice
			// 
			this.txtDieselPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDieselPrice.Location = new System.Drawing.Point(88, 61);
			this.txtDieselPrice.Name = "txtDieselPrice";
			this.txtDieselPrice.Size = new System.Drawing.Size(115, 26);
			this.txtDieselPrice.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(6, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Diesel:";
			// 
			// txtLpgPrice
			// 
			this.txtLpgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtLpgPrice.Location = new System.Drawing.Point(88, 94);
			this.txtLpgPrice.Name = "txtLpgPrice";
			this.txtLpgPrice.Size = new System.Drawing.Size(115, 26);
			this.txtLpgPrice.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(6, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "Gasoline:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdbLpg);
			this.groupBox2.Controls.Add(this.rdbDiesel);
			this.groupBox2.Controls.Add(this.rdbGasoline);
			this.groupBox2.Location = new System.Drawing.Point(12, 68);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(403, 52);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fuel Type";
			// 
			// rdbGasoline
			// 
			this.rdbGasoline.AutoSize = true;
			this.rdbGasoline.Location = new System.Drawing.Point(19, 29);
			this.rdbGasoline.Name = "rdbGasoline";
			this.rdbGasoline.Size = new System.Drawing.Size(66, 17);
			this.rdbGasoline.TabIndex = 0;
			this.rdbGasoline.TabStop = true;
			this.rdbGasoline.Text = "Gasoline";
			this.rdbGasoline.UseVisualStyleBackColor = true;
			// 
			// rdbDiesel
			// 
			this.rdbDiesel.AutoSize = true;
			this.rdbDiesel.Location = new System.Drawing.Point(132, 29);
			this.rdbDiesel.Name = "rdbDiesel";
			this.rdbDiesel.Size = new System.Drawing.Size(54, 17);
			this.rdbDiesel.TabIndex = 1;
			this.rdbDiesel.TabStop = true;
			this.rdbDiesel.Text = "Diesel";
			this.rdbDiesel.UseVisualStyleBackColor = true;
			// 
			// rdbLpg
			// 
			this.rdbLpg.AutoSize = true;
			this.rdbLpg.Location = new System.Drawing.Point(259, 29);
			this.rdbLpg.Name = "rdbLpg";
			this.rdbLpg.Size = new System.Drawing.Size(43, 17);
			this.rdbLpg.TabIndex = 2;
			this.rdbLpg.TabStop = true;
			this.rdbLpg.Text = "Lpg";
			this.rdbLpg.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gold;
			this.ClientSize = new System.Drawing.Size(705, 302);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtGasAmount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGasAmount;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtLpgPrice;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDieselPrice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtGasolinePrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdbLpg;
		private System.Windows.Forms.RadioButton rdbDiesel;
		private System.Windows.Forms.RadioButton rdbGasoline;
	}
}

