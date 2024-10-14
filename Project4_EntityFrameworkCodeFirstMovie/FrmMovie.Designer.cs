namespace Project4_EntityFrameworkCodeFirstMovie
{
	partial class FrmMovie
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.txtDuration = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.mskDate = new System.Windows.Forms.MaskedTextBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.btnMovieWithCategory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(372, 74);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(133, 23);
			this.btnSearch.TabIndex = 44;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(511, 45);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(133, 23);
			this.btnUpdate.TabIndex = 43;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(511, 74);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(133, 23);
			this.btnDelete.TabIndex = 42;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(372, 45);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(133, 23);
			this.btnCreate.TabIndex = 41;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(97, 42);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(203, 20);
			this.txtName.TabIndex = 40;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 39;
			this.label2.Text = "Movie Title:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(97, 16);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(203, 20);
			this.txtId.TabIndex = 38;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 202);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(643, 236);
			this.dataGridView1.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "Movie Id:";
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(372, 16);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(133, 23);
			this.btnList.TabIndex = 35;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtDuration
			// 
			this.txtDuration.Location = new System.Drawing.Point(97, 68);
			this.txtDuration.Name = "txtDuration";
			this.txtDuration.Size = new System.Drawing.Size(203, 20);
			this.txtDuration.TabIndex = 46;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 45;
			this.label3.Text = "Duration:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(97, 94);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(203, 20);
			this.txtDescription.TabIndex = 48;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 47;
			this.label4.Text = "Description:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 49;
			this.label5.Text = "Created Date:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(33, 149);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 51;
			this.label6.Text = "Category:";
			// 
			// mskDate
			// 
			this.mskDate.Location = new System.Drawing.Point(97, 120);
			this.mskDate.Mask = "00/00/0000";
			this.mskDate.Name = "mskDate";
			this.mskDate.Size = new System.Drawing.Size(203, 20);
			this.mskDate.TabIndex = 53;
			this.mskDate.ValidatingType = typeof(System.DateTime);
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(97, 146);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(203, 21);
			this.cmbCategory.TabIndex = 54;
			// 
			// btnMovieWithCategory
			// 
			this.btnMovieWithCategory.Location = new System.Drawing.Point(511, 16);
			this.btnMovieWithCategory.Name = "btnMovieWithCategory";
			this.btnMovieWithCategory.Size = new System.Drawing.Size(133, 23);
			this.btnMovieWithCategory.TabIndex = 55;
			this.btnMovieWithCategory.Text = "List With Category";
			this.btnMovieWithCategory.UseVisualStyleBackColor = true;
			this.btnMovieWithCategory.Click += new System.EventHandler(this.btnMovieWithCategory_Click);
			// 
			// FrmMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(667, 450);
			this.Controls.Add(this.btnMovieWithCategory);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.mskDate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDuration);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnList);
			this.Name = "FrmMovie";
			this.Text = "FrmMovie";
			this.Load += new System.EventHandler(this.FrmMovie_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtDuration;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox mskDate;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Button btnMovieWithCategory;
	}
}