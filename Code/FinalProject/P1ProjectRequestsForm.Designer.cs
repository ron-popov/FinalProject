namespace FinalProject
{
    partial class P1ProjectRequestsForm
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
            System.Windows.Forms.Label projectRequestIdLabel;
            System.Windows.Forms.Label projectRequestCustomerIdLabel;
            System.Windows.Forms.Label projectRequestManagerIdLabel;
            this.databaseDataSet = new FinalProject.DatabaseDataSet();
            this.tProjectRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tProjectRequestsTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tProjectRequestsTableAdapter();
            this.tableAdapterManager = new FinalProject.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tCostumersTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tCostumersTableAdapter();
            this.tWorkersTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tWorkersTableAdapter();
            this.projectRequestIdTextBox = new System.Windows.Forms.TextBox();
            this.projectRequestCustomerIdComboBox = new System.Windows.Forms.ComboBox();
            this.tCostumersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectRequestManagerIdComboBox = new System.Windows.Forms.ComboBox();
            this.tWorkersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.managerApprovedButton = new System.Windows.Forms.Button();
            this.tProjectRequestsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            projectRequestIdLabel = new System.Windows.Forms.Label();
            projectRequestCustomerIdLabel = new System.Windows.Forms.Label();
            projectRequestManagerIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCostumersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWorkersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectRequestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // projectRequestIdLabel
            // 
            projectRequestIdLabel.AutoSize = true;
            projectRequestIdLabel.Location = new System.Drawing.Point(611, 22);
            projectRequestIdLabel.Name = "projectRequestIdLabel";
            projectRequestIdLabel.Size = new System.Drawing.Size(97, 13);
            projectRequestIdLabel.TabIndex = 1;
            projectRequestIdLabel.Text = "project Request Id:";
            // 
            // projectRequestCustomerIdLabel
            // 
            projectRequestCustomerIdLabel.AutoSize = true;
            projectRequestCustomerIdLabel.Location = new System.Drawing.Point(611, 48);
            projectRequestCustomerIdLabel.Name = "projectRequestCustomerIdLabel";
            projectRequestCustomerIdLabel.Size = new System.Drawing.Size(144, 13);
            projectRequestCustomerIdLabel.TabIndex = 3;
            projectRequestCustomerIdLabel.Text = "project Request Customer Id:";
            // 
            // projectRequestManagerIdLabel
            // 
            projectRequestManagerIdLabel.AutoSize = true;
            projectRequestManagerIdLabel.Location = new System.Drawing.Point(611, 75);
            projectRequestManagerIdLabel.Name = "projectRequestManagerIdLabel";
            projectRequestManagerIdLabel.Size = new System.Drawing.Size(142, 13);
            projectRequestManagerIdLabel.TabIndex = 5;
            projectRequestManagerIdLabel.Text = "project Request Manager Id:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tProjectRequestsBindingSource
            // 
            this.tProjectRequestsBindingSource.DataMember = "tProjectRequests";
            this.tProjectRequestsBindingSource.DataSource = this.databaseDataSet;
            // 
            // tProjectRequestsTableAdapter
            // 
            this.tProjectRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tCostumersTableAdapter = this.tCostumersTableAdapter;
            this.tableAdapterManager.tFeaturesTableAdapter = null;
            this.tableAdapterManager.tProjectRequestsTableAdapter = this.tProjectRequestsTableAdapter;
            this.tableAdapterManager.tProjectsTableAdapter = null;
            this.tableAdapterManager.tSpecialtiesTableAdapter = null;
            this.tableAdapterManager.tSpecialtiesToFeaturesTableAdapter = null;
            this.tableAdapterManager.tSpecialtyToWorkerTableAdapter = null;
            this.tableAdapterManager.tTeamsTableAdapter = null;
            this.tableAdapterManager.tWorkersTableAdapter = this.tWorkersTableAdapter;
            this.tableAdapterManager.tWorkersToTeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProject.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tCostumersTableAdapter
            // 
            this.tCostumersTableAdapter.ClearBeforeFill = true;
            // 
            // tWorkersTableAdapter
            // 
            this.tWorkersTableAdapter.ClearBeforeFill = true;
            // 
            // projectRequestIdTextBox
            // 
            this.projectRequestIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectRequestsBindingSource, "projectRequestId", true));
            this.projectRequestIdTextBox.Location = new System.Drawing.Point(761, 19);
            this.projectRequestIdTextBox.Name = "projectRequestIdTextBox";
            this.projectRequestIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.projectRequestIdTextBox.TabIndex = 2;
            // 
            // projectRequestCustomerIdComboBox
            // 
            this.projectRequestCustomerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectRequestsBindingSource, "projectRequestCustomerId", true));
            this.projectRequestCustomerIdComboBox.DataSource = this.tCostumersBindingSource;
            this.projectRequestCustomerIdComboBox.DisplayMember = "costumerName";
            this.projectRequestCustomerIdComboBox.FormattingEnabled = true;
            this.projectRequestCustomerIdComboBox.Location = new System.Drawing.Point(761, 45);
            this.projectRequestCustomerIdComboBox.Name = "projectRequestCustomerIdComboBox";
            this.projectRequestCustomerIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.projectRequestCustomerIdComboBox.TabIndex = 4;
            this.projectRequestCustomerIdComboBox.ValueMember = "costumerId";
            // 
            // tCostumersBindingSource
            // 
            this.tCostumersBindingSource.DataMember = "tCostumers";
            this.tCostumersBindingSource.DataSource = this.databaseDataSet;
            // 
            // projectRequestManagerIdComboBox
            // 
            this.projectRequestManagerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectRequestsBindingSource, "projectRequestManagerId", true));
            this.projectRequestManagerIdComboBox.DataSource = this.tWorkersBindingSource;
            this.projectRequestManagerIdComboBox.DisplayMember = "workerName";
            this.projectRequestManagerIdComboBox.FormattingEnabled = true;
            this.projectRequestManagerIdComboBox.Location = new System.Drawing.Point(761, 72);
            this.projectRequestManagerIdComboBox.Name = "projectRequestManagerIdComboBox";
            this.projectRequestManagerIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.projectRequestManagerIdComboBox.TabIndex = 6;
            this.projectRequestManagerIdComboBox.ValueMember = "workerId";
            // 
            // tWorkersBindingSource
            // 
            this.tWorkersBindingSource.DataMember = "tWorkers";
            this.tWorkersBindingSource.DataSource = this.databaseDataSet;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(746, 247);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(113, 23);
            this.RefreshButton.TabIndex = 26;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(627, 247);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(113, 23);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(746, 218);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 23);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(627, 218);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(113, 23);
            this.AddNewButton.TabIndex = 23;
            this.AddNewButton.Text = "Add";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(627, 189);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(113, 23);
            this.LastButton.TabIndex = 22;
            this.LastButton.Text = "Last";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(627, 160);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(113, 23);
            this.FirstButton.TabIndex = 21;
            this.FirstButton.Text = "First";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click_1);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(746, 189);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(113, 23);
            this.DownButton.TabIndex = 20;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(746, 160);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(113, 23);
            this.UpButton.TabIndex = 19;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "project Request Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 28;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(761, 97);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(122, 20);
            this.statusTextBox.TabIndex = 29;
            // 
            // managerApprovedButton
            // 
            this.managerApprovedButton.Location = new System.Drawing.Point(627, 131);
            this.managerApprovedButton.Name = "managerApprovedButton";
            this.managerApprovedButton.Size = new System.Drawing.Size(232, 23);
            this.managerApprovedButton.TabIndex = 30;
            this.managerApprovedButton.Text = "Managment Approved";
            this.managerApprovedButton.UseVisualStyleBackColor = true;
            this.managerApprovedButton.Click += new System.EventHandler(this.managerApprovedButton_Click);
            // 
            // tProjectRequestsDataGridView
            // 
            this.tProjectRequestsDataGridView.AutoGenerateColumns = false;
            this.tProjectRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tProjectRequestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tProjectRequestsDataGridView.DataSource = this.tProjectRequestsBindingSource;
            this.tProjectRequestsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.tProjectRequestsDataGridView.Name = "tProjectRequestsDataGridView";
            this.tProjectRequestsDataGridView.Size = new System.Drawing.Size(593, 258);
            this.tProjectRequestsDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "projectRequestId";
            this.dataGridViewTextBoxColumn1.HeaderText = "projectRequestId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "projectRequestCustomerId";
            this.dataGridViewTextBoxColumn2.HeaderText = "projectRequestCustomerId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "projectRequestManagerId";
            this.dataGridViewTextBoxColumn3.HeaderText = "projectRequestManagerId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "projectRequestManagmentApproved";
            this.dataGridViewTextBoxColumn4.HeaderText = "projectRequestManagmentApproved";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // P1ProjectRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 290);
            this.Controls.Add(this.tProjectRequestsDataGridView);
            this.Controls.Add(this.managerApprovedButton);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(projectRequestIdLabel);
            this.Controls.Add(this.projectRequestIdTextBox);
            this.Controls.Add(projectRequestCustomerIdLabel);
            this.Controls.Add(this.projectRequestCustomerIdComboBox);
            this.Controls.Add(projectRequestManagerIdLabel);
            this.Controls.Add(this.projectRequestManagerIdComboBox);
            this.Name = "P1ProjectRequestsForm";
            this.Text = "P1ProjectRequests";
            this.Load += new System.EventHandler(this.P1ProjectRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCostumersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWorkersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectRequestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tProjectRequestsBindingSource;
        private DatabaseDataSetTableAdapters.tProjectRequestsTableAdapter tProjectRequestsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.tCostumersTableAdapter tCostumersTableAdapter;
        private System.Windows.Forms.TextBox projectRequestIdTextBox;
        private System.Windows.Forms.ComboBox projectRequestCustomerIdComboBox;
        private System.Windows.Forms.ComboBox projectRequestManagerIdComboBox;
        private System.Windows.Forms.BindingSource tCostumersBindingSource;
        private DatabaseDataSetTableAdapters.tWorkersTableAdapter tWorkersTableAdapter;
        private System.Windows.Forms.BindingSource tWorkersBindingSource;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button managerApprovedButton;
        private System.Windows.Forms.DataGridView tProjectRequestsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}