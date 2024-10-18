namespace Project10_PostgreSQLToDoList
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
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.rdbCompleted = new System.Windows.Forms.RadioButton();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPriority = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnAllList = new System.Windows.Forms.Button();
			this.btnCompletedList = new System.Windows.Forms.Button();
			this.btnContinueList = new System.Windows.Forms.Button();
			this.rdbContinue = new System.Windows.Forms.RadioButton();
			this.btnCategoryList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtId.Location = new System.Drawing.Point(104, 6);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(117, 22);
			this.txtId.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Process Id:";
			// 
			// cmbCategory
			// 
			this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(104, 72);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(117, 24);
			this.cmbCategory.TabIndex = 2;
			// 
			// rdbCompleted
			// 
			this.rdbCompleted.AutoSize = true;
			this.rdbCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdbCompleted.Location = new System.Drawing.Point(104, 169);
			this.rdbCompleted.Name = "rdbCompleted";
			this.rdbCompleted.Size = new System.Drawing.Size(91, 20);
			this.rdbCompleted.TabIndex = 3;
			this.rdbCompleted.TabStop = true;
			this.rdbCompleted.Text = "Completed";
			this.rdbCompleted.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(237, 102);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(123, 23);
			this.btnUpdate.TabIndex = 43;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(237, 70);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(123, 23);
			this.btnDelete.TabIndex = 42;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreate.Location = new System.Drawing.Point(237, 38);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(123, 23);
			this.btnCreate.TabIndex = 41;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(237, 6);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(123, 23);
			this.btnList.TabIndex = 40;
			this.btnList.Text = "List";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 16);
			this.label2.TabIndex = 46;
			this.label2.Text = "Title:";
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTitle.Location = new System.Drawing.Point(104, 39);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(117, 22);
			this.txtTitle.TabIndex = 45;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(12, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 48;
			this.label3.Text = "Category:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(12, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 16);
			this.label4.TabIndex = 50;
			this.label4.Text = "Priority:";
			// 
			// txtPriority
			// 
			this.txtPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPriority.Location = new System.Drawing.Point(104, 107);
			this.txtPriority.Name = "txtPriority";
			this.txtPriority.Size = new System.Drawing.Size(117, 22);
			this.txtPriority.TabIndex = 49;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(12, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 16);
			this.label5.TabIndex = 52;
			this.label5.Text = "Description:";
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDescription.Location = new System.Drawing.Point(104, 140);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(117, 22);
			this.txtDescription.TabIndex = 51;
			// 
			// btnAllList
			// 
			this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAllList.Location = new System.Drawing.Point(237, 134);
			this.btnAllList.Name = "btnAllList";
			this.btnAllList.Size = new System.Drawing.Size(123, 23);
			this.btnAllList.TabIndex = 53;
			this.btnAllList.Text = "All List";
			this.btnAllList.UseVisualStyleBackColor = true;
			this.btnAllList.Click += new System.EventHandler(this.btnAllList_Click);
			// 
			// btnCompletedList
			// 
			this.btnCompletedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCompletedList.Location = new System.Drawing.Point(237, 166);
			this.btnCompletedList.Name = "btnCompletedList";
			this.btnCompletedList.Size = new System.Drawing.Size(123, 23);
			this.btnCompletedList.TabIndex = 54;
			this.btnCompletedList.Text = "Completed List";
			this.btnCompletedList.UseVisualStyleBackColor = true;
			this.btnCompletedList.Click += new System.EventHandler(this.btnCompletedList_Click);
			// 
			// btnContinueList
			// 
			this.btnContinueList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnContinueList.Location = new System.Drawing.Point(237, 198);
			this.btnContinueList.Name = "btnContinueList";
			this.btnContinueList.Size = new System.Drawing.Size(123, 23);
			this.btnContinueList.TabIndex = 55;
			this.btnContinueList.Text = "Continue List";
			this.btnContinueList.UseVisualStyleBackColor = true;
			this.btnContinueList.Click += new System.EventHandler(this.btnContinueList_Click);
			// 
			// rdbContinue
			// 
			this.rdbContinue.AutoSize = true;
			this.rdbContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdbContinue.Location = new System.Drawing.Point(104, 201);
			this.rdbContinue.Name = "rdbContinue";
			this.rdbContinue.Size = new System.Drawing.Size(77, 20);
			this.rdbContinue.TabIndex = 56;
			this.rdbContinue.TabStop = true;
			this.rdbContinue.Text = "Continue";
			this.rdbContinue.UseVisualStyleBackColor = true;
			// 
			// btnCategoryList
			// 
			this.btnCategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCategoryList.Location = new System.Drawing.Point(237, 227);
			this.btnCategoryList.Name = "btnCategoryList";
			this.btnCategoryList.Size = new System.Drawing.Size(123, 23);
			this.btnCategoryList.TabIndex = 57;
			this.btnCategoryList.Text = "Category List";
			this.btnCategoryList.UseVisualStyleBackColor = true;
			this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(366, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(599, 244);
			this.dataGridView1.TabIndex = 58;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(977, 265);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCategoryList);
			this.Controls.Add(this.rdbContinue);
			this.Controls.Add(this.btnContinueList);
			this.Controls.Add(this.btnCompletedList);
			this.Controls.Add(this.btnAllList);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPriority);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.rdbCompleted);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtId);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "To Do List";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.RadioButton rdbCompleted;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPriority;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnAllList;
		private System.Windows.Forms.Button btnCompletedList;
		private System.Windows.Forms.Button btnContinueList;
		private System.Windows.Forms.RadioButton rdbContinue;
		private System.Windows.Forms.Button btnCategoryList;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

