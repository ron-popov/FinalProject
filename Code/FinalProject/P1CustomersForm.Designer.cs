namespace FinalProject
{
    partial class P1CustomersForm
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
            System.Windows.Forms.Label costumerIdLabel;
            System.Windows.Forms.Label costumerNameLabel;
            System.Windows.Forms.Label customerPhoneNumberLabel;
            System.Windows.Forms.Label customerEmailAddressLabel;
            System.Windows.Forms.Label customerAdressLabel;
            this.databaseDataSet = new FinalProject.DatabaseDataSet();
            this.tCostumersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCostumersTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tCostumersTableAdapter();
            this.tableAdapterManager = new FinalProject.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tCostumersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumerIdTextBox = new System.Windows.Forms.TextBox();
            this.costumerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerAdressTextBox = new System.Windows.Forms.TextBox();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            costumerIdLabel = new System.Windows.Forms.Label();
            costumerNameLabel = new System.Windows.Forms.Label();
            customerPhoneNumberLabel = new System.Windows.Forms.Label();
            customerEmailAddressLabel = new System.Windows.Forms.Label();
            customerAdressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCostumersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCostumersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // costumerIdLabel
            // 
            costumerIdLabel.AutoSize = true;
            costumerIdLabel.Location = new System.Drawing.Point(741, 25);
            costumerIdLabel.Name = "costumerIdLabel";
            costumerIdLabel.Size = new System.Drawing.Size(65, 13);
            costumerIdLabel.TabIndex = 1;
            costumerIdLabel.Text = "costumer Id:";
            // 
            // costumerNameLabel
            // 
            costumerNameLabel.AutoSize = true;
            costumerNameLabel.Location = new System.Drawing.Point(741, 51);
            costumerNameLabel.Name = "costumerNameLabel";
            costumerNameLabel.Size = new System.Drawing.Size(84, 13);
            costumerNameLabel.TabIndex = 3;
            costumerNameLabel.Text = "costumer Name:";
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new System.Drawing.Point(741, 77);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new System.Drawing.Size(127, 13);
            customerPhoneNumberLabel.TabIndex = 5;
            customerPhoneNumberLabel.Text = "customer Phone Number:";
            // 
            // customerEmailAddressLabel
            // 
            customerEmailAddressLabel.AutoSize = true;
            customerEmailAddressLabel.Location = new System.Drawing.Point(741, 103);
            customerEmailAddressLabel.Name = "customerEmailAddressLabel";
            customerEmailAddressLabel.Size = new System.Drawing.Size(122, 13);
            customerEmailAddressLabel.TabIndex = 7;
            customerEmailAddressLabel.Text = "customer Email Address:";
            // 
            // customerAdressLabel
            // 
            customerAdressLabel.AutoSize = true;
            customerAdressLabel.Location = new System.Drawing.Point(741, 129);
            customerAdressLabel.Name = "customerAdressLabel";
            customerAdressLabel.Size = new System.Drawing.Size(88, 13);
            customerAdressLabel.TabIndex = 9;
            customerAdressLabel.Text = "customer Adress:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tCostumersTableAdapter = this.tCostumersTableAdapter;
            this.tableAdapterManager.tFeaturesTableAdapter = null;
            this.tableAdapterManager.tProjectRequestsTableAdapter = null;
            this.tableAdapterManager.tProjectsTableAdapter = null;
            this.tableAdapterManager.tSpecialtiesTableAdapter = null;
            this.tableAdapterManager.tSpecialtiesToFeaturesTableAdapter = null;
            this.tableAdapterManager.tSpecialtyToWorkerTableAdapter = null;
            this.tableAdapterManager.tTeamsTableAdapter = null;
            this.tableAdapterManager.tWorkersTableAdapter = null;
            this.tableAdapterManager.tWorkersToTeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProject.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tCostumersDataGridView
            // 
            this.tCostumersDataGridView.AutoGenerateColumns = false;
            this.tCostumersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tCostumersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tCostumersDataGridView.DataSource = this.tCostumersBindingSource;
            this.tCostumersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.tCostumersDataGridView.Name = "tCostumersDataGridView";
            this.tCostumersDataGridView.Size = new System.Drawing.Size(693, 479);
            this.tCostumersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "costumerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "costumerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "costumerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "costumerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "customerPhoneNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "customerPhoneNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "customerEmailAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "customerEmailAddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "customerAdress";
            this.dataGridViewTextBoxColumn5.HeaderText = "customerAdress";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // costumerIdTextBox
            // 
            this.costumerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCostumersBindingSource, "costumerId", true));
            this.costumerIdTextBox.Location = new System.Drawing.Point(899, 22);
            this.costumerIdTextBox.Name = "costumerIdTextBox";
            this.costumerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.costumerIdTextBox.TabIndex = 2;
            // 
            // costumerNameTextBox
            // 
            this.costumerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCostumersBindingSource, "costumerName", true));
            this.costumerNameTextBox.Location = new System.Drawing.Point(899, 48);
            this.costumerNameTextBox.Name = "costumerNameTextBox";
            this.costumerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.costumerNameTextBox.TabIndex = 4;
            // 
            // customerPhoneNumberTextBox
            // 
            this.customerPhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCostumersBindingSource, "customerPhoneNumber", true));
            this.customerPhoneNumberTextBox.Location = new System.Drawing.Point(899, 74);
            this.customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            this.customerPhoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerPhoneNumberTextBox.TabIndex = 6;
            // 
            // customerEmailAddressTextBox
            // 
            this.customerEmailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCostumersBindingSource, "customerEmailAddress", true));
            this.customerEmailAddressTextBox.Location = new System.Drawing.Point(899, 100);
            this.customerEmailAddressTextBox.Name = "customerEmailAddressTextBox";
            this.customerEmailAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerEmailAddressTextBox.TabIndex = 8;
            // 
            // customerAdressTextBox
            // 
            this.customerAdressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCostumersBindingSource, "customerAdress", true));
            this.customerAdressTextBox.Location = new System.Drawing.Point(899, 126);
            this.customerAdressTextBox.Name = "customerAdressTextBox";
            this.customerAdressTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerAdressTextBox.TabIndex = 10;
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(1099, 19);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(75, 23);
            this.UpButton.TabIndex = 11;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(1099, 48);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(75, 23);
            this.DownButton.TabIndex = 12;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(1018, 19);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(75, 23);
            this.FirstButton.TabIndex = 13;
            this.FirstButton.Text = "First";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(1018, 48);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(75, 23);
            this.LastButton.TabIndex = 14;
            this.LastButton.Text = "Last";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(1018, 97);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewButton.TabIndex = 15;
            this.AddNewButton.Text = "Add";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1104, 97);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1018, 126);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(1104, 126);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 18;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // P1CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 517);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(costumerIdLabel);
            this.Controls.Add(this.costumerIdTextBox);
            this.Controls.Add(costumerNameLabel);
            this.Controls.Add(this.costumerNameTextBox);
            this.Controls.Add(customerPhoneNumberLabel);
            this.Controls.Add(this.customerPhoneNumberTextBox);
            this.Controls.Add(customerEmailAddressLabel);
            this.Controls.Add(this.customerEmailAddressTextBox);
            this.Controls.Add(customerAdressLabel);
            this.Controls.Add(this.customerAdressTextBox);
            this.Controls.Add(this.tCostumersDataGridView);
            this.Name = "P1CustomersForm";
            this.Text = "P1CustomersForm";
            this.Load += new System.EventHandler(this.P1CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCostumersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCostumersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tCostumersBindingSource;
        private DatabaseDataSetTableAdapters.tCostumersTableAdapter tCostumersTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tCostumersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox costumerIdTextBox;
        private System.Windows.Forms.TextBox costumerNameTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.TextBox customerEmailAddressTextBox;
        private System.Windows.Forms.TextBox customerAdressTextBox;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}