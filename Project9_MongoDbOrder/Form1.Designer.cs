namespace Project9_MongoDbOrder
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.txtDistrict = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnGetById = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Order Id:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "District:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "City:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Total Price:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(79, 6);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 5;
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(79, 39);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerName.TabIndex = 6;
			// 
			// txtDistrict
			// 
			this.txtDistrict.Location = new System.Drawing.Point(79, 72);
			this.txtDistrict.Name = "txtDistrict";
			this.txtDistrict.Size = new System.Drawing.Size(100, 20);
			this.txtDistrict.TabIndex = 7;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(79, 105);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(100, 20);
			this.txtCity.TabIndex = 8;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Location = new System.Drawing.Point(79, 138);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
			this.txtTotalPrice.TabIndex = 9;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 185);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(521, 192);
			this.dataGridView1.TabIndex = 10;
			// 
			// btnGetById
			// 
			this.btnGetById.Location = new System.Drawing.Point(205, 135);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(123, 23);
			this.btnGetById.TabIndex = 39;
			this.btnGetById.Text = "Get";
			this.btnGetById.UseVisualStyleBackColor = true;
			this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(205, 103);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(123, 23);
			this.btnUpdate.TabIndex = 38;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(205, 70);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(123, 23);
			this.btnDelete.TabIndex = 37;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(205, 37);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(123, 23);
			this.btnCreate.TabIndex = 36;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(205, 4);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(123, 23);
			this.btnList.TabIndex = 35;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Project9_MongoDbOrder.Properties.Resources.shopping;
			this.pictureBox1.Location = new System.Drawing.Point(354, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(180, 148);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 40;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 396);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtDistrict);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.TextBox txtDistrict;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

