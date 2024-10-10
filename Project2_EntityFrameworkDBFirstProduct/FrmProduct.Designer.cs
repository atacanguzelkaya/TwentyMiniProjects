﻿namespace Project2_EntityFrameworkDBFirstProduct
{
	partial class FrmProduct
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
			this.cmbProductCategory = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.btnListWithCategory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbProductCategory
			// 
			this.cmbProductCategory.FormattingEnabled = true;
			this.cmbProductCategory.Location = new System.Drawing.Point(100, 123);
			this.cmbProductCategory.Name = "cmbProductCategory";
			this.cmbProductCategory.Size = new System.Drawing.Size(123, 21);
			this.cmbProductCategory.TabIndex = 51;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(38, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 49;
			this.label5.Text = "Category:";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(100, 96);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(123, 20);
			this.txtProductPrice.TabIndex = 48;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 47;
			this.label4.Text = "Product Price:";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(100, 307);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(123, 23);
			this.btnSearch.TabIndex = 46;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(100, 278);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(123, 23);
			this.btnUpdate.TabIndex = 45;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(100, 249);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(123, 23);
			this.btnDelete.TabIndex = 44;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(100, 220);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(123, 23);
			this.btnCreate.TabIndex = 43;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(100, 68);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(123, 20);
			this.txtProductStock.TabIndex = 42;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 41;
			this.label3.Text = "Product Stock:";
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(100, 42);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(123, 20);
			this.txtProductName.TabIndex = 40;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 39;
			this.label2.Text = "Product Name:";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(100, 16);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(123, 20);
			this.txtProductId.TabIndex = 38;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(253, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(535, 318);
			this.dataGridView1.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "Product Id:";
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(100, 191);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(55, 23);
			this.btnList.TabIndex = 35;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnListWithCategory
			// 
			this.btnListWithCategory.Location = new System.Drawing.Point(168, 191);
			this.btnListWithCategory.Name = "btnListWithCategory";
			this.btnListWithCategory.Size = new System.Drawing.Size(55, 23);
			this.btnListWithCategory.TabIndex = 52;
			this.btnListWithCategory.Text = "List";
			this.btnListWithCategory.UseVisualStyleBackColor = true;
			this.btnListWithCategory.Click += new System.EventHandler(this.btnListWithCategory_Click);
			// 
			// FrmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 353);
			this.Controls.Add(this.btnListWithCategory);
			this.Controls.Add(this.cmbProductCategory);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtProductStock);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnList);
			this.Name = "FrmProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Product Process";
			this.Load += new System.EventHandler(this.FrmProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox cmbProductCategory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnListWithCategory;
	}
}