namespace Project14_SQLAllRelations
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.db14Project20DataSet = new Project14_SQLAllRelations.Db14Project20DataSet();
			this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.teamsTableAdapter = new Project14_SQLAllRelations.Db14Project20DataSetTableAdapters.TeamsTableAdapter();
			this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.db14Project20DataSet1 = new Project14_SQLAllRelations.Db14Project20DataSet1();
			this.teamDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.teamDetailsTableAdapter = new Project14_SQLAllRelations.Db14Project20DataSet1TableAdapters.TeamDetailsTableAdapter();
			this.teamDetailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.db14Project20DataSet2 = new Project14_SQLAllRelations.Db14Project20DataSet2();
			this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.playersTableAdapter = new Project14_SQLAllRelations.Db14Project20DataSet2TableAdapters.PlayersTableAdapter();
			this.playerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.db14Project20DataSet3 = new Project14_SQLAllRelations.Db14Project20DataSet3();
			this.sponsorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sponsorsTableAdapter = new Project14_SQLAllRelations.Db14Project20DataSet3TableAdapters.SponsorsTableAdapter();
			this.sponsorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sponsorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sponsorsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIdDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn,
            this.teamCountryDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.teamsBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(409, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamDetailIdDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn1,
            this.teamColorDataGridViewTextBoxColumn,
            this.teamCityDataGridViewTextBoxColumn,
            this.teamValueDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.teamDetailsBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(427, 12);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(524, 150);
			this.dataGridView2.TabIndex = 1;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AutoGenerateColumns = false;
			this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIdDataGridViewTextBoxColumn,
            this.playerNameDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn2});
			this.dataGridView3.DataSource = this.playersBindingSource;
			this.dataGridView3.Location = new System.Drawing.Point(12, 168);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(409, 150);
			this.dataGridView3.TabIndex = 2;
			// 
			// db14Project20DataSet
			// 
			this.db14Project20DataSet.DataSetName = "Db14Project20DataSet";
			this.db14Project20DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// teamsBindingSource
			// 
			this.teamsBindingSource.DataMember = "Teams";
			this.teamsBindingSource.DataSource = this.db14Project20DataSet;
			// 
			// teamsTableAdapter
			// 
			this.teamsTableAdapter.ClearBeforeFill = true;
			// 
			// teamIdDataGridViewTextBoxColumn
			// 
			this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "TeamId";
			this.teamIdDataGridViewTextBoxColumn.HeaderText = "TeamId";
			this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
			this.teamIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// teamNameDataGridViewTextBoxColumn
			// 
			this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
			this.teamNameDataGridViewTextBoxColumn.HeaderText = "TeamName";
			this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
			// 
			// teamCountryDataGridViewTextBoxColumn
			// 
			this.teamCountryDataGridViewTextBoxColumn.DataPropertyName = "TeamCountry";
			this.teamCountryDataGridViewTextBoxColumn.HeaderText = "TeamCountry";
			this.teamCountryDataGridViewTextBoxColumn.Name = "teamCountryDataGridViewTextBoxColumn";
			// 
			// db14Project20DataSet1
			// 
			this.db14Project20DataSet1.DataSetName = "Db14Project20DataSet1";
			this.db14Project20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// teamDetailsBindingSource
			// 
			this.teamDetailsBindingSource.DataMember = "TeamDetails";
			this.teamDetailsBindingSource.DataSource = this.db14Project20DataSet1;
			// 
			// teamDetailsTableAdapter
			// 
			this.teamDetailsTableAdapter.ClearBeforeFill = true;
			// 
			// teamDetailIdDataGridViewTextBoxColumn
			// 
			this.teamDetailIdDataGridViewTextBoxColumn.DataPropertyName = "TeamDetailId";
			this.teamDetailIdDataGridViewTextBoxColumn.HeaderText = "TeamDetailId";
			this.teamDetailIdDataGridViewTextBoxColumn.Name = "teamDetailIdDataGridViewTextBoxColumn";
			this.teamDetailIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// teamIdDataGridViewTextBoxColumn1
			// 
			this.teamIdDataGridViewTextBoxColumn1.DataPropertyName = "TeamId";
			this.teamIdDataGridViewTextBoxColumn1.HeaderText = "TeamId";
			this.teamIdDataGridViewTextBoxColumn1.Name = "teamIdDataGridViewTextBoxColumn1";
			// 
			// teamColorDataGridViewTextBoxColumn
			// 
			this.teamColorDataGridViewTextBoxColumn.DataPropertyName = "TeamColor";
			this.teamColorDataGridViewTextBoxColumn.HeaderText = "TeamColor";
			this.teamColorDataGridViewTextBoxColumn.Name = "teamColorDataGridViewTextBoxColumn";
			// 
			// teamCityDataGridViewTextBoxColumn
			// 
			this.teamCityDataGridViewTextBoxColumn.DataPropertyName = "TeamCity";
			this.teamCityDataGridViewTextBoxColumn.HeaderText = "TeamCity";
			this.teamCityDataGridViewTextBoxColumn.Name = "teamCityDataGridViewTextBoxColumn";
			// 
			// teamValueDataGridViewTextBoxColumn
			// 
			this.teamValueDataGridViewTextBoxColumn.DataPropertyName = "TeamValue";
			this.teamValueDataGridViewTextBoxColumn.HeaderText = "TeamValue";
			this.teamValueDataGridViewTextBoxColumn.Name = "teamValueDataGridViewTextBoxColumn";
			// 
			// db14Project20DataSet2
			// 
			this.db14Project20DataSet2.DataSetName = "Db14Project20DataSet2";
			this.db14Project20DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// playersBindingSource
			// 
			this.playersBindingSource.DataMember = "Players";
			this.playersBindingSource.DataSource = this.db14Project20DataSet2;
			// 
			// playersTableAdapter
			// 
			this.playersTableAdapter.ClearBeforeFill = true;
			// 
			// playerIdDataGridViewTextBoxColumn
			// 
			this.playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
			this.playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
			this.playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
			this.playerIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// playerNameDataGridViewTextBoxColumn
			// 
			this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
			this.playerNameDataGridViewTextBoxColumn.HeaderText = "PlayerName";
			this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
			// 
			// teamIdDataGridViewTextBoxColumn2
			// 
			this.teamIdDataGridViewTextBoxColumn2.DataPropertyName = "TeamId";
			this.teamIdDataGridViewTextBoxColumn2.HeaderText = "TeamId";
			this.teamIdDataGridViewTextBoxColumn2.Name = "teamIdDataGridViewTextBoxColumn2";
			// 
			// dataGridView4
			// 
			this.dataGridView4.AutoGenerateColumns = false;
			this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sponsorIdDataGridViewTextBoxColumn,
            this.sponsorNameDataGridViewTextBoxColumn});
			this.dataGridView4.DataSource = this.sponsorsBindingSource;
			this.dataGridView4.Location = new System.Drawing.Point(427, 168);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.Size = new System.Drawing.Size(524, 150);
			this.dataGridView4.TabIndex = 3;
			// 
			// db14Project20DataSet3
			// 
			this.db14Project20DataSet3.DataSetName = "Db14Project20DataSet3";
			this.db14Project20DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sponsorsBindingSource
			// 
			this.sponsorsBindingSource.DataMember = "Sponsors";
			this.sponsorsBindingSource.DataSource = this.db14Project20DataSet3;
			// 
			// sponsorsTableAdapter
			// 
			this.sponsorsTableAdapter.ClearBeforeFill = true;
			// 
			// sponsorIdDataGridViewTextBoxColumn
			// 
			this.sponsorIdDataGridViewTextBoxColumn.DataPropertyName = "SponsorId";
			this.sponsorIdDataGridViewTextBoxColumn.HeaderText = "SponsorId";
			this.sponsorIdDataGridViewTextBoxColumn.Name = "sponsorIdDataGridViewTextBoxColumn";
			this.sponsorIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sponsorNameDataGridViewTextBoxColumn
			// 
			this.sponsorNameDataGridViewTextBoxColumn.DataPropertyName = "SponsorName";
			this.sponsorNameDataGridViewTextBoxColumn.HeaderText = "SponsorName";
			this.sponsorNameDataGridViewTextBoxColumn.Name = "sponsorNameDataGridViewTextBoxColumn";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(963, 333);
			this.Controls.Add(this.dataGridView4);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sponsorsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private Db14Project20DataSet db14Project20DataSet;
		private System.Windows.Forms.BindingSource teamsBindingSource;
		private Db14Project20DataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamCountryDataGridViewTextBoxColumn;
		private Db14Project20DataSet1 db14Project20DataSet1;
		private System.Windows.Forms.BindingSource teamDetailsBindingSource;
		private Db14Project20DataSet1TableAdapters.TeamDetailsTableAdapter teamDetailsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamDetailIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamColorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamValueDataGridViewTextBoxColumn;
		private Db14Project20DataSet2 db14Project20DataSet2;
		private System.Windows.Forms.BindingSource playersBindingSource;
		private Db14Project20DataSet2TableAdapters.PlayersTableAdapter playersTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridView dataGridView4;
		private Db14Project20DataSet3 db14Project20DataSet3;
		private System.Windows.Forms.BindingSource sponsorsBindingSource;
		private Db14Project20DataSet3TableAdapters.SponsorsTableAdapter sponsorsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn sponsorIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sponsorNameDataGridViewTextBoxColumn;
	}
}

