namespace Project5_DapperNorthwind
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
			this.btnCategoryList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtCategoryDescription = new System.Windows.Forms.TextBox();
			this.btnCreateCategory = new System.Windows.Forms.Button();
			this.btnUpdateCategory = new System.Windows.Forms.Button();
			this.btnDeleteCategory = new System.Windows.Forms.Button();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.lblCategoryCount = new System.Windows.Forms.Label();
			this.lblProductCount = new System.Windows.Forms.Label();
			this.lblSeafoodProductTotalPrice = new System.Windows.Forms.Label();
			this.lblAvgProductStock = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCategoryList
			// 
			this.btnCategoryList.Location = new System.Drawing.Point(241, 6);
			this.btnCategoryList.Name = "btnCategoryList";
			this.btnCategoryList.Size = new System.Drawing.Size(75, 23);
			this.btnCategoryList.TabIndex = 0;
			this.btnCategoryList.Text = "List";
			this.btnCategoryList.UseVisualStyleBackColor = true;
			this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(12, 131);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(541, 201);
			this.dataGridView1.TabIndex = 0;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(101, 35);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(113, 20);
			this.txtCategoryName.TabIndex = 1;
			// 
			// txtCategoryDescription
			// 
			this.txtCategoryDescription.Location = new System.Drawing.Point(101, 61);
			this.txtCategoryDescription.Multiline = true;
			this.txtCategoryDescription.Name = "txtCategoryDescription";
			this.txtCategoryDescription.Size = new System.Drawing.Size(113, 50);
			this.txtCategoryDescription.TabIndex = 2;
			// 
			// btnCreateCategory
			// 
			this.btnCreateCategory.Location = new System.Drawing.Point(241, 33);
			this.btnCreateCategory.Name = "btnCreateCategory";
			this.btnCreateCategory.Size = new System.Drawing.Size(75, 23);
			this.btnCreateCategory.TabIndex = 3;
			this.btnCreateCategory.Text = "Create";
			this.btnCreateCategory.UseVisualStyleBackColor = true;
			this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
			// 
			// btnUpdateCategory
			// 
			this.btnUpdateCategory.Location = new System.Drawing.Point(241, 59);
			this.btnUpdateCategory.Name = "btnUpdateCategory";
			this.btnUpdateCategory.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateCategory.TabIndex = 5;
			this.btnUpdateCategory.Text = "Update";
			this.btnUpdateCategory.UseVisualStyleBackColor = true;
			this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
			// 
			// btnDeleteCategory
			// 
			this.btnDeleteCategory.Location = new System.Drawing.Point(241, 88);
			this.btnDeleteCategory.Name = "btnDeleteCategory";
			this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteCategory.TabIndex = 4;
			this.btnDeleteCategory.Text = "Delete";
			this.btnDeleteCategory.UseVisualStyleBackColor = true;
			this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(101, 9);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(113, 20);
			this.txtCategoryId.TabIndex = 6;
			// 
			// lblCategoryCount
			// 
			this.lblCategoryCount.AutoSize = true;
			this.lblCategoryCount.Location = new System.Drawing.Point(6, 16);
			this.lblCategoryCount.Name = "lblCategoryCount";
			this.lblCategoryCount.Size = new System.Drawing.Size(77, 13);
			this.lblCategoryCount.TabIndex = 7;
			this.lblCategoryCount.Text = "CategoryCount";
			// 
			// lblProductCount
			// 
			this.lblProductCount.AutoSize = true;
			this.lblProductCount.Location = new System.Drawing.Point(6, 39);
			this.lblProductCount.Name = "lblProductCount";
			this.lblProductCount.Size = new System.Drawing.Size(72, 13);
			this.lblProductCount.TabIndex = 8;
			this.lblProductCount.Text = "ProductCount";
			// 
			// lblSeafoodProductTotalPrice
			// 
			this.lblSeafoodProductTotalPrice.AutoSize = true;
			this.lblSeafoodProductTotalPrice.Location = new System.Drawing.Point(6, 86);
			this.lblSeafoodProductTotalPrice.Name = "lblSeafoodProductTotalPrice";
			this.lblSeafoodProductTotalPrice.Size = new System.Drawing.Size(132, 13);
			this.lblSeafoodProductTotalPrice.TabIndex = 10;
			this.lblSeafoodProductTotalPrice.Text = "SeafoodProductTotalPrice";
			// 
			// lblAvgProductStock
			// 
			this.lblAvgProductStock.AutoSize = true;
			this.lblAvgProductStock.Location = new System.Drawing.Point(6, 62);
			this.lblAvgProductStock.Name = "lblAvgProductStock";
			this.lblAvgProductStock.Size = new System.Drawing.Size(91, 13);
			this.lblAvgProductStock.TabIndex = 9;
			this.lblAvgProductStock.Text = "AvgProductStock";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Category ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Category Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Description:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblCategoryCount);
			this.groupBox1.Controls.Add(this.lblProductCount);
			this.groupBox1.Controls.Add(this.lblAvgProductStock);
			this.groupBox1.Controls.Add(this.lblSeafoodProductTotalPrice);
			this.groupBox1.Location = new System.Drawing.Point(335, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(218, 105);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dapper Statistics";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 350);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.btnUpdateCategory);
			this.Controls.Add(this.btnDeleteCategory);
			this.Controls.Add(this.btnCreateCategory);
			this.Controls.Add(this.txtCategoryDescription);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCategoryList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCategoryList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtCategoryDescription;
		private System.Windows.Forms.Button btnCreateCategory;
		private System.Windows.Forms.Button btnUpdateCategory;
		private System.Windows.Forms.Button btnDeleteCategory;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Label lblCategoryCount;
		private System.Windows.Forms.Label lblProductCount;
		private System.Windows.Forms.Label lblSeafoodProductTotalPrice;
		private System.Windows.Forms.Label lblAvgProductStock;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

