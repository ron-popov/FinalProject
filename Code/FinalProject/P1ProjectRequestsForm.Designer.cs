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
            System.Windows.Forms.Label projectRequestNameLabel;
            System.Windows.Forms.Label projectRequestDescriptionLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.databaseDataSet = new FinalProject.DatabaseDataSet();
            this.tProjectRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tProjectRequestsTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tProjectRequestsTableAdapter();
            this.tableAdapterManager = new FinalProject.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tProjectRequestsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectRequestIdTextBox = new System.Windows.Forms.TextBox();
            this.projectRequestCustomerIdComboBox = new System.Windows.Forms.ComboBox();
            this.projectRequestNameTextBox = new System.Windows.Forms.TextBox();
            this.projectRequestDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.tCostumersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCostumersTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tCostumersTableAdapter();
            projectRequestIdLabel = new System.Windows.Forms.Label();
            projectRequestCustomerIdLabel = new System.Windows.Forms.Label();
            projectRequestNameLabel = new System.Windows.Forms.Label();
            projectRequestDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectRequestsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCostumersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(850, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "First";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(850, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Last";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(769, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Down";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(769, 317);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Add New";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(850, 317);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(769, 346);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(850, 346);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 26;
            this.button8.Text = "Reload";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
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
            this.tableAdapterManager.tWorkersTableAdapter = null;
            this.tableAdapterManager.tWorkersToTeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProject.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.tProjectRequestsDataGridView.Size = new System.Drawing.Size(913, 220);
            this.tProjectRequestsDataGridView.TabIndex = 27;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "projectRequestName";
            this.dataGridViewTextBoxColumn3.HeaderText = "projectRequestName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "projectRequestDescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "projectRequestDescription";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // projectRequestIdLabel
            // 
            projectRequestIdLabel.AutoSize = true;
            projectRequestIdLabel.Location = new System.Drawing.Point(12, 258);
            projectRequestIdLabel.Name = "projectRequestIdLabel";
            projectRequestIdLabel.Size = new System.Drawing.Size(97, 13);
            projectRequestIdLabel.TabIndex = 27;
            projectRequestIdLabel.Text = "project Request Id:";
            // 
            // projectRequestIdTextBox
            // 
            this.projectRequestIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectRequestsBindingSource, "projectRequestId", true));
            this.projectRequestIdTextBox.Location = new System.Drawing.Point(162, 255);
            this.projectRequestIdTextBox.Name = "projectRequestIdTextBox";
            this.projectRequestIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.projectRequestIdTextBox.TabIndex = 28;
            // 
            // projectRequestCustomerIdLabel
            // 
            projectRequestCustomerIdLabel.AutoSize = true;
            projectRequestCustomerIdLabel.Location = new System.Drawing.Point(12, 284);
            projectRequestCustomerIdLabel.Name = "projectRequestCustomerIdLabel";
            projectRequestCustomerIdLabel.Size = new System.Drawing.Size(144, 13);
            projectRequestCustomerIdLabel.TabIndex = 29;
            projectRequestCustomerIdLabel.Text = "project Request Customer Id:";
            // 
            // projectRequestCustomerIdComboBox
            // 
            this.projectRequestCustomerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectRequestsBindingSource, "projectRequestCustomerId", true));
            this.projectRequestCustomerIdComboBox.DataSource = this.tCostumersBindingSource;
            this.projectRequestCustomerIdComboBox.DisplayMember = "costumerName";
            this.projectRequestCustomerIdComboBox.FormattingEnabled = true;
            this.projectRequestCustomerIdComboBox.Location = new System.Drawing.Point(162, 281);
            this.projectRequestCustomerIdComboBox.Name = "projectRequestCustomerIdComboBox";
            this.projectRequestCustomerIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.projectRequestCustomerIdComboBox.TabIndex = 30;
            // 
            // projectRequestNameLabel
            // 
            projectRequestNameLabel.AutoSize = true;
            projectRequestNameLabel.Location = new System.Drawing.Point(12, 311);
            projectRequestNameLabel.Name = "projectRequestNameLabel";
            projectRequestNameLabel.Size = new System.Drawing.Size(116, 13);
            projectRequestNameLabel.TabIndex = 31;
            projectRequestNameLabel.Text = "project Request Name:";
            // 
            // projectRequestNameTextBox
            // 
            this.projectRequestNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectRequestsBindingSource, "projectRequestName", true));
            this.projectRequestNameTextBox.Location = new System.Drawing.Point(162, 308);
            this.projectRequestNameTextBox.Name = "projectRequestNameTextBox";
            this.projectRequestNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.projectRequestNameTextBox.TabIndex = 32;
            // 
            // projectRequestDescriptionLabel
            // 
            projectRequestDescriptionLabel.AutoSize = true;
            projectRequestDescriptionLabel.Location = new System.Drawing.Point(12, 337);
            projectRequestDescriptionLabel.Name = "projectRequestDescriptionLabel";
            projectRequestDescriptionLabel.Size = new System.Drawing.Size(141, 13);
            projectRequestDescriptionLabel.TabIndex = 33;
            projectRequestDescriptionLabel.Text = "project Request Description:";
            // 
            // projectRequestDescriptionTextBox
            // 
            this.projectRequestDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectRequestsBindingSource, "projectRequestDescription", true));
            this.projectRequestDescriptionTextBox.Location = new System.Drawing.Point(162, 334);
            this.projectRequestDescriptionTextBox.Name = "projectRequestDescriptionTextBox";
            this.projectRequestDescriptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.projectRequestDescriptionTextBox.TabIndex = 34;
            // 
            // tCostumersBindingSource
            // 
            this.tCostumersBindingSource.DataMember = "tCostumers";
            this.tCostumersBindingSource.DataSource = this.databaseDataSet;
            // 
            // tCostumersTableAdapter
            // 
            this.tCostumersTableAdapter.ClearBeforeFill = true;
            // 
            // P1ProjectRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 428);
            this.Controls.Add(projectRequestIdLabel);
            this.Controls.Add(this.projectRequestIdTextBox);
            this.Controls.Add(projectRequestCustomerIdLabel);
            this.Controls.Add(this.projectRequestCustomerIdComboBox);
            this.Controls.Add(projectRequestNameLabel);
            this.Controls.Add(this.projectRequestNameTextBox);
            this.Controls.Add(projectRequestDescriptionLabel);
            this.Controls.Add(this.projectRequestDescriptionTextBox);
            this.Controls.Add(this.tProjectRequestsDataGridView);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "P1ProjectRequestsForm";
            this.Text = "P1ProjectRequests";
            this.Load += new System.EventHandler(this.P1ProjectRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectRequestsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCostumersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tProjectRequestsBindingSource;
        private DatabaseDataSetTableAdapters.tProjectRequestsTableAdapter tProjectRequestsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.tCostumersTableAdapter tCostumersTableAdapter;
        private System.Windows.Forms.DataGridView tProjectRequestsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox projectRequestIdTextBox;
        private System.Windows.Forms.ComboBox projectRequestCustomerIdComboBox;
        private System.Windows.Forms.TextBox projectRequestNameTextBox;
        private System.Windows.Forms.TextBox projectRequestDescriptionTextBox;
        private System.Windows.Forms.BindingSource tCostumersBindingSource;
    }
}