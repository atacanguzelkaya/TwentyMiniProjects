namespace Project2_EntityFrameworkDBFirstProduct
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
			this.btnExit = new System.Windows.Forms.Button();
			this.btnOpenProductForm = new System.Windows.Forms.Button();
			this.btnOpenCategoryForm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(13, 108);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(139, 42);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnOpenProductForm
			// 
			this.btnOpenProductForm.Location = new System.Drawing.Point(13, 60);
			this.btnOpenProductForm.Name = "btnOpenProductForm";
			this.btnOpenProductForm.Size = new System.Drawing.Size(139, 42);
			this.btnOpenProductForm.TabIndex = 4;
			this.btnOpenProductForm.Text = "Product Process";
			this.btnOpenProductForm.UseVisualStyleBackColor = true;
			this.btnOpenProductForm.Click += new System.EventHandler(this.btnOpenProductForm_Click);
			// 
			// btnOpenCategoryForm
			// 
			this.btnOpenCategoryForm.Location = new System.Drawing.Point(12, 12);
			this.btnOpenCategoryForm.Name = "btnOpenCategoryForm";
			this.btnOpenCategoryForm.Size = new System.Drawing.Size(139, 42);
			this.btnOpenCategoryForm.TabIndex = 3;
			this.btnOpenCategoryForm.Text = "Category Process";
			this.btnOpenCategoryForm.UseVisualStyleBackColor = true;
			this.btnOpenCategoryForm.Click += new System.EventHandler(this.btnOpenCategoryForm_Click);
			// 
			// FrmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(166, 159);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOpenProductForm);
			this.Controls.Add(this.btnOpenCategoryForm);
			this.Name = "FrmMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMap";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnOpenProductForm;
		private System.Windows.Forms.Button btnOpenCategoryForm;
	}
}