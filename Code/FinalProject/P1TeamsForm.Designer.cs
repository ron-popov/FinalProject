namespace FinalProject
{
    partial class P1TeamsForm
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
            this.databaseDataSet = new FinalProject.DatabaseDataSet();
            this.tTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTeamsTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tTeamsTableAdapter();
            this.tableAdapterManager = new FinalProject.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tTeamsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tWorkersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWorkersTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tWorkersTableAdapter();
            this.tWorkersToTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWorkersToTeamsTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tWorkersToTeamsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ManagerIdTextbox = new System.Windows.Forms.TextBox();
            this.ManagerNameTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTeamsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWorkersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWorkersToTeamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTeamsBindingSource
            // 
            this.tTeamsBindingSource.DataMember = "tTeams";
            this.tTeamsBindingSource.DataSource = this.databaseDataSet;
            // 
            // tTeamsTableAdapter
            // 
            this.tTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tCostumersTableAdapter = null;
            this.tableAdapterManager.tFeaturesTableAdapter = null;
            this.tableAdapterManager.tProjectRequestsTableAdapter = null;
            this.tableAdapterManager.tProjectsTableAdapter = null;
            this.tableAdapterManager.tSpecialtiesTableAdapter = null;
            this.tableAdapterManager.tSpecialtiesToFeaturesTableAdapter = null;
            this.tableAdapterManager.tSpecialtyToWorkerTableAdapter = null;
            this.tableAdapterManager.tTeamsTableAdapter = this.tTeamsTableAdapter;
            this.tableAdapterManager.tWorkersTableAdapter = this.tWorkersTableAdapter;
            this.tableAdapterManager.tWorkersToTeamsTableAdapter = this.tWorkersToTeamsTableAdapter;
            this.tableAdapterManager.UpdateOrder = FinalProject.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tTeamsDataGridView
            // 
            this.tTeamsDataGridView.AutoGenerateColumns = false;
            this.tTeamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tTeamsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tTeamsDataGridView.DataSource = this.tTeamsBindingSource;
            this.tTeamsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.tTeamsDataGridView.Name = "tTeamsDataGridView";
            this.tTeamsDataGridView.Size = new System.Drawing.Size(489, 198);
            this.tTeamsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "teamId";
            this.dataGridViewTextBoxColumn1.HeaderText = "teamId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "teamManagerId";
            this.dataGridViewTextBoxColumn2.HeaderText = "teamManagerId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(507, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 173);
            this.listBox1.TabIndex = 2;
            // 
            // tWorkersBindingSource
            // 
            this.tWorkersBindingSource.DataMember = "tWorkers";
            this.tWorkersBindingSource.DataSource = this.databaseDataSet;
            // 
            // tWorkersTableAdapter
            // 
            this.tWorkersTableAdapter.ClearBeforeFill = true;
            // 
            // tWorkersToTeamsBindingSource
            // 
            this.tWorkersToTeamsBindingSource.DataMember = "tWorkersToTeams";
            this.tWorkersToTeamsBindingSource.DataSource = this.databaseDataSet;
            // 
            // tWorkersToTeamsTableAdapter
            // 
            this.tWorkersToTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team Members";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "First";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Last";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Down";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 392);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Remove";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(93, 363);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 363);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Add New";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Manager Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Manager Name :";
            // 
            // ManagerIdTextbox
            // 
            this.ManagerIdTextbox.Location = new System.Drawing.Point(300, 223);
            this.ManagerIdTextbox.Name = "ManagerIdTextbox";
            this.ManagerIdTextbox.Size = new System.Drawing.Size(100, 20);
            this.ManagerIdTextbox.TabIndex = 14;
            // 
            // ManagerNameTextbox
            // 
            this.ManagerNameTextbox.Location = new System.Drawing.Point(300, 245);
            this.ManagerNameTextbox.Name = "ManagerNameTextbox";
            this.ManagerNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.ManagerNameTextbox.TabIndex = 15;
            // 
            // P1TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 427);
            this.Controls.Add(this.ManagerNameTextbox);
            this.Controls.Add(this.ManagerIdTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tTeamsDataGridView);
            this.Name = "P1TeamsForm";
            this.Text = "P1TeamsForm";
            this.Load += new System.EventHandler(this.P1TeamsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTeamsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWorkersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWorkersToTeamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tTeamsBindingSource;
        private DatabaseDataSetTableAdapters.tTeamsTableAdapter tTeamsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tTeamsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ListBox listBox1;
        private DatabaseDataSetTableAdapters.tWorkersTableAdapter tWorkersTableAdapter;
        private System.Windows.Forms.BindingSource tWorkersBindingSource;
        private DatabaseDataSetTableAdapters.tWorkersToTeamsTableAdapter tWorkersToTeamsTableAdapter;
        private System.Windows.Forms.BindingSource tWorkersToTeamsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ManagerIdTextbox;
        private System.Windows.Forms.TextBox ManagerNameTextbox;
    }
}