﻿namespace Project1_AdonetCustomer
{
	partial class FrmMap
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
			this.btnOpenCityForm = new System.Windows.Forms.Button();
			this.btnOpenCustomerForm = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOpenCityForm
			// 
			this.btnOpenCityForm.Location = new System.Drawing.Point(12, 12);
			this.btnOpenCityForm.Name = "btnOpenCityForm";
			this.btnOpenCityForm.Size = new System.Drawing.Size(139, 42);
			this.btnOpenCityForm.TabIndex = 0;
			this.btnOpenCityForm.Text = "City Process";
			this.btnOpenCityForm.UseVisualStyleBackColor = true;
			this.btnOpenCityForm.Click += new System.EventHandler(this.btnOpenCityForm_Click);
			// 
			// btnOpenCustomerForm
			// 
			this.btnOpenCustomerForm.Location = new System.Drawing.Point(13, 60);
			this.btnOpenCustomerForm.Name = "btnOpenCustomerForm";
			this.btnOpenCustomerForm.Size = new System.Drawing.Size(139, 42);
			this.btnOpenCustomerForm.TabIndex = 1;
			this.btnOpenCustomerForm.Text = "Customer Process";
			this.btnOpenCustomerForm.UseVisualStyleBackColor = true;
			this.btnOpenCustomerForm.Click += new System.EventHandler(this.btnOpenCustomerForm_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(13, 108);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(139, 42);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// FrmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(164, 163);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOpenCustomerForm);
			this.Controls.Add(this.btnOpenCityForm);
			this.Name = "FrmMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMap";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOpenCityForm;
		private System.Windows.Forms.Button btnOpenCustomerForm;
		private System.Windows.Forms.Button btnExit;
	}
}