namespace FinalProject
{
    partial class P1ProjectsForm
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
            System.Windows.Forms.Label projectIdLabel;
            System.Windows.Forms.Label projectNameLabel;
            System.Windows.Forms.Label projectManagerIdLabel;
            System.Windows.Forms.Label customerIdLabel;
            System.Windows.Forms.Label projectRequestIdLabel;
            System.Windows.Forms.Label projectDescirptionLabel;
            this.databaseDataSet = new FinalProject.DatabaseDataSet();
            this.tProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tProjectsTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tProjectsTableAdapter();
            this.tableAdapterManager = new FinalProject.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tCostumersTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tCostumersTableAdapter();
            this.tWorkersTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tWorkersTableAdapter();
            this.projectIdTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.projectManagerIdComboBox = new System.Windows.Forms.ComboBox();
            this.tWorkersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIdComboBox = new System.Windows.Forms.ComboBox();
            this.tCostumersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectRequestIdComboBox = new System.Windows.Forms.ComboBox();
            this.projectDescirptionTextBox = new System.Windows.Forms.TextBox();
            this.tProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tProjectRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tProjectRequestsTableAdapter = new FinalProject.DatabaseDataSetTableAdapters.tProjectRequestsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            projectIdLabel = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            projectManagerIdLabel = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            projectRequestIdLabel = new System.Windows.Forms.Label();
            projectDescirptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWorkersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCostumersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectRequestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.Location = new System.Drawing.Point(12, 254);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new System.Drawing.Size(54, 13);
            projectIdLabel.TabIndex = 1;
            projectIdLabel.Text = "project Id:";
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(12, 280);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(73, 13);
            projectNameLabel.TabIndex = 3;
            projectNameLabel.Text = "project Name:";
            // 
            // projectManagerIdLabel
            // 
            projectManagerIdLabel.AutoSize = true;
            projectManagerIdLabel.Location = new System.Drawing.Point(12, 306);
            projectManagerIdLabel.Name = "projectManagerIdLabel";
            projectManagerIdLabel.Size = new System.Drawing.Size(99, 13);
            projectManagerIdLabel.TabIndex = 5;
            projectManagerIdLabel.Text = "project Manager Id:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(12, 333);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(65, 13);
            customerIdLabel.TabIndex = 7;
            customerIdLabel.Text = "customer Id:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tProjectsBindingSource
            // 
            this.tProjectsBindingSource.DataMember = "tProjects";
            this.tProjectsBindingSource.DataSource = this.databaseDataSet;
            // 
            // tProjectsTableAdapter
            // 
            this.tProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tCostumersTableAdapter = this.tCostumersTableAdapter;
            this.tableAdapterManager.tFeaturesTableAdapter = null;
            this.tableAdapterManager.tProjectRequestsTableAdapter = null;
            this.tableAdapterManager.tProjectsTableAdapter = this.tProjectsTableAdapter;
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
            // projectIdTextBox
            // 
            this.projectIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectsBindingSource, "projectId", true));
            this.projectIdTextBox.Location = new System.Drawing.Point(117, 251);
            this.projectIdTextBox.Name = "projectIdTextBox";
            this.projectIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.projectIdTextBox.TabIndex = 2;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectsBindingSource, "projectName", true));
            this.projectNameTextBox.Location = new System.Drawing.Point(117, 277);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.projectNameTextBox.TabIndex = 4;
            // 
            // projectManagerIdComboBox
            // 
            this.projectManagerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectsBindingSource, "projectManagerId", true));
            this.projectManagerIdComboBox.DataSource = this.tWorkersBindingSource;
            this.projectManagerIdComboBox.DisplayMember = "workerName";
            this.projectManagerIdComboBox.FormattingEnabled = true;
            this.projectManagerIdComboBox.Location = new System.Drawing.Point(117, 303);
            this.projectManagerIdComboBox.Name = "projectManagerIdComboBox";
            this.projectManagerIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.projectManagerIdComboBox.TabIndex = 6;
            this.projectManagerIdComboBox.ValueMember = "workerId";
            // 
            // tWorkersBindingSource
            // 
            this.tWorkersBindingSource.DataMember = "tWorkers";
            this.tWorkersBindingSource.DataSource = this.databaseDataSet;
            // 
            // customerIdComboBox
            // 
            this.customerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectsBindingSource, "customerId", true));
            this.customerIdComboBox.DataSource = this.tCostumersBindingSource;
            this.customerIdComboBox.DisplayMember = "costumerName";
            this.customerIdComboBox.FormattingEnabled = true;
            this.customerIdComboBox.Location = new System.Drawing.Point(117, 330);
            this.customerIdComboBox.Name = "customerIdComboBox";
            this.customerIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.customerIdComboBox.TabIndex = 8;
            this.customerIdComboBox.ValueMember = "costumerId";
            // 
            // tCostumersBindingSource
            // 
            this.tCostumersBindingSource.DataMember = "tCostumers";
            this.tCostumersBindingSource.DataSource = this.databaseDataSet;
            // 
            // projectRequestIdLabel
            // 
            projectRequestIdLabel.AutoSize = true;
            projectRequestIdLabel.Location = new System.Drawing.Point(14, 361);
            projectRequestIdLabel.Name = "projectRequestIdLabel";
            projectRequestIdLabel.Size = new System.Drawing.Size(97, 13);
            projectRequestIdLabel.TabIndex = 8;
            projectRequestIdLabel.Text = "project Request Id:";
            // 
            // projectRequestIdComboBox
            // 
            this.projectRequestIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectsBindingSource, "projectRequestId", true));
            this.projectRequestIdComboBox.DataSource = this.tProjectRequestsBindingSource;
            this.projectRequestIdComboBox.DisplayMember = "projectRequestName";
            this.projectRequestIdComboBox.FormattingEnabled = true;
            this.projectRequestIdComboBox.Location = new System.Drawing.Point(117, 358);
            this.projectRequestIdComboBox.Name = "projectRequestIdComboBox";
            this.projectRequestIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.projectRequestIdComboBox.TabIndex = 9;
            this.projectRequestIdComboBox.ValueMember = "projectRequestId";
            // 
            // projectDescirptionLabel
            // 
            projectDescirptionLabel.AutoSize = true;
            projectDescirptionLabel.Location = new System.Drawing.Point(12, 387);
            projectDescirptionLabel.Name = "projectDescirptionLabel";
            projectDescirptionLabel.Size = new System.Drawing.Size(98, 13);
            projectDescirptionLabel.TabIndex = 10;
            projectDescirptionLabel.Text = "project Descirption:";
            // 
            // projectDescirptionTextBox
            // 
            this.projectDescirptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tProjectsBindingSource, "projectDescirption", true));
            this.projectDescirptionTextBox.Location = new System.Drawing.Point(118, 384);
            this.projectDescirptionTextBox.Name = "projectDescirptionTextBox";
            this.projectDescirptionTextBox.Size = new System.Drawing.Size(120, 20);
            this.projectDescirptionTextBox.TabIndex = 11;
            // 
            // tProjectsDataGridView
            // 
            this.tProjectsDataGridView.AutoGenerateColumns = false;
            this.tProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tProjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tProjectsDataGridView.DataSource = this.tProjectsBindingSource;
            this.tProjectsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.tProjectsDataGridView.Name = "tProjectsDataGridView";
            this.tProjectsDataGridView.Size = new System.Drawing.Size(805, 220);
            this.tProjectsDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "projectId";
            this.dataGridViewTextBoxColumn1.HeaderText = "projectId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "projectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "projectName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "projectManagerId";
            this.dataGridViewTextBoxColumn3.HeaderText = "projectManagerId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "customerId";
            this.dataGridViewTextBoxColumn4.HeaderText = "customerId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "projectRequestId";
            this.dataGridViewTextBoxColumn5.HeaderText = "projectRequestId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "projectDescirption";
            this.dataGridViewTextBoxColumn6.HeaderText = "projectDescirption";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Down";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "First";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(342, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(936, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Creating New Project";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tProjectRequestsBindingSource;
            this.comboBox1.DisplayMember = "projectRequestName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(989, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "projectRequestId";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Project Request Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(876, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Manager Id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tWorkersBindingSource;
            this.comboBox2.DisplayMember = "workerName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(989, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.ValueMember = "workerId";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(879, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Add New Project";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(879, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(231, 87);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // P1ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 441);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tProjectsDataGridView);
            this.Controls.Add(projectDescirptionLabel);
            this.Controls.Add(this.projectDescirptionTextBox);
            this.Controls.Add(projectRequestIdLabel);
            this.Controls.Add(this.projectRequestIdComboBox);
            this.Controls.Add(projectIdLabel);
            this.Controls.Add(this.projectIdTextBox);
            this.Controls.Add(projectNameLabel);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(projectManagerIdLabel);
            this.Controls.Add(this.projectManagerIdComboBox);
            this.Controls.Add(customerIdLabel);
            this.Controls.Add(this.customerIdComboBox);
            this.Name = "P1ProjectsForm";
            this.Text = "P1ProjectsForm";
            this.Load += new System.EventHandler(this.P1ProjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWorkersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCostumersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProjectRequestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tProjectsBindingSource;
        private DatabaseDataSetTableAdapters.tProjectsTableAdapter tProjectsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.tWorkersTableAdapter tWorkersTableAdapter;
        private System.Windows.Forms.TextBox projectIdTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.ComboBox projectManagerIdComboBox;
        private System.Windows.Forms.ComboBox customerIdComboBox;
        private System.Windows.Forms.BindingSource tWorkersBindingSource;
        private DatabaseDataSetTableAdapters.tCostumersTableAdapter tCostumersTableAdapter;
        private System.Windows.Forms.BindingSource tCostumersBindingSource;
        private System.Windows.Forms.ComboBox projectRequestIdComboBox;
        private System.Windows.Forms.TextBox projectDescirptionTextBox;
        private System.Windows.Forms.DataGridView tProjectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource tProjectRequestsBindingSource;
        private DatabaseDataSetTableAdapters.tProjectRequestsTableAdapter tProjectRequestsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}