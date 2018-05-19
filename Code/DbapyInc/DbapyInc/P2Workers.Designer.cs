﻿namespace DbapyInc
{
    partial class P2Workers
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
            System.Windows.Forms.Label workerIdLabel;
            System.Windows.Forms.Label workerNameLabel;
            System.Windows.Forms.Label workerPhoneLabel;
            System.Windows.Forms.Label workerAddressLabel;
            System.Windows.Forms.Label workerJoinDateLabel;
            System.Windows.Forms.Label workerBirthDateLabel;
            this.databaseDataSet = new DbapyInc.DatabaseDataSet();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIdTextBox = new System.Windows.Forms.TextBox();
            this.workerNameTextBox = new System.Windows.Forms.TextBox();
            this.workerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.workerAddressTextBox = new System.Windows.Forms.TextBox();
            this.workerJoinDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workerBirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            workerIdLabel = new System.Windows.Forms.Label();
            workerNameLabel = new System.Windows.Forms.Label();
            workerPhoneLabel = new System.Windows.Forms.Label();
            workerAddressLabel = new System.Windows.Forms.Label();
            workerJoinDateLabel = new System.Windows.Forms.Label();
            workerBirthDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.databaseDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BugsTableAdapter = null;
            this.tableAdapterManager.BugsToTestsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProjectComponentsTableAdapter = null;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.ProjectTypesTableAdapter = null;
            this.tableAdapterManager.SurveysTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            this.tableAdapterManager.WorkersToTeamsTableAdapter = null;
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.AutoGenerateColumns = false;
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.workersDataGridView.DataSource = this.workersBindingSource;
            this.workersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.Size = new System.Drawing.Size(760, 320);
            this.workersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "WorkerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "WorkerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WorkerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "WorkerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WorkerPhone";
            this.dataGridViewTextBoxColumn3.HeaderText = "WorkerPhone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "WorkerAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "WorkerAddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "WorkerJoinDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "WorkerJoinDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "WorkerBirthDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "WorkerBirthDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // workerIdLabel
            // 
            workerIdLabel.AutoSize = true;
            workerIdLabel.Location = new System.Drawing.Point(821, 21);
            workerIdLabel.Name = "workerIdLabel";
            workerIdLabel.Size = new System.Drawing.Size(57, 13);
            workerIdLabel.TabIndex = 1;
            workerIdLabel.Text = "Worker Id:";
            // 
            // workerIdTextBox
            // 
            this.workerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WorkerId", true));
            this.workerIdTextBox.Location = new System.Drawing.Point(922, 18);
            this.workerIdTextBox.Name = "workerIdTextBox";
            this.workerIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.workerIdTextBox.TabIndex = 2;
            // 
            // workerNameLabel
            // 
            workerNameLabel.AutoSize = true;
            workerNameLabel.Location = new System.Drawing.Point(821, 47);
            workerNameLabel.Name = "workerNameLabel";
            workerNameLabel.Size = new System.Drawing.Size(76, 13);
            workerNameLabel.TabIndex = 3;
            workerNameLabel.Text = "Worker Name:";
            // 
            // workerNameTextBox
            // 
            this.workerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WorkerName", true));
            this.workerNameTextBox.Location = new System.Drawing.Point(922, 44);
            this.workerNameTextBox.Name = "workerNameTextBox";
            this.workerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.workerNameTextBox.TabIndex = 4;
            // 
            // workerPhoneLabel
            // 
            workerPhoneLabel.AutoSize = true;
            workerPhoneLabel.Location = new System.Drawing.Point(821, 73);
            workerPhoneLabel.Name = "workerPhoneLabel";
            workerPhoneLabel.Size = new System.Drawing.Size(79, 13);
            workerPhoneLabel.TabIndex = 5;
            workerPhoneLabel.Text = "Worker Phone:";
            // 
            // workerPhoneTextBox
            // 
            this.workerPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WorkerPhone", true));
            this.workerPhoneTextBox.Location = new System.Drawing.Point(922, 70);
            this.workerPhoneTextBox.Name = "workerPhoneTextBox";
            this.workerPhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.workerPhoneTextBox.TabIndex = 6;
            // 
            // workerAddressLabel
            // 
            workerAddressLabel.AutoSize = true;
            workerAddressLabel.Location = new System.Drawing.Point(821, 99);
            workerAddressLabel.Name = "workerAddressLabel";
            workerAddressLabel.Size = new System.Drawing.Size(86, 13);
            workerAddressLabel.TabIndex = 7;
            workerAddressLabel.Text = "Worker Address:";
            // 
            // workerAddressTextBox
            // 
            this.workerAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WorkerAddress", true));
            this.workerAddressTextBox.Location = new System.Drawing.Point(922, 96);
            this.workerAddressTextBox.Name = "workerAddressTextBox";
            this.workerAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.workerAddressTextBox.TabIndex = 8;
            // 
            // workerJoinDateLabel
            // 
            workerJoinDateLabel.AutoSize = true;
            workerJoinDateLabel.Location = new System.Drawing.Point(821, 126);
            workerJoinDateLabel.Name = "workerJoinDateLabel";
            workerJoinDateLabel.Size = new System.Drawing.Size(93, 13);
            workerJoinDateLabel.TabIndex = 9;
            workerJoinDateLabel.Text = "Worker Join Date:";
            // 
            // workerJoinDateDateTimePicker
            // 
            this.workerJoinDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workersBindingSource, "WorkerJoinDate", true));
            this.workerJoinDateDateTimePicker.Location = new System.Drawing.Point(922, 122);
            this.workerJoinDateDateTimePicker.Name = "workerJoinDateDateTimePicker";
            this.workerJoinDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.workerJoinDateDateTimePicker.TabIndex = 10;
            // 
            // workerBirthDateLabel
            // 
            workerBirthDateLabel.AutoSize = true;
            workerBirthDateLabel.Location = new System.Drawing.Point(821, 152);
            workerBirthDateLabel.Name = "workerBirthDateLabel";
            workerBirthDateLabel.Size = new System.Drawing.Size(95, 13);
            workerBirthDateLabel.TabIndex = 11;
            workerBirthDateLabel.Text = "Worker Birth Date:";
            // 
            // workerBirthDateDateTimePicker
            // 
            this.workerBirthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workersBindingSource, "WorkerBirthDate", true));
            this.workerBirthDateDateTimePicker.Location = new System.Drawing.Point(922, 148);
            this.workerBirthDateDateTimePicker.Name = "workerBirthDateDateTimePicker";
            this.workerBirthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.workerBirthDateDateTimePicker.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(966, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "למטה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(832, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "אחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(966, 278);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 23);
            this.button7.TabIndex = 30;
            this.button7.Text = "למעלה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(832, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "ראשון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(966, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "שמירה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(832, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "עדכון ממסד";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(966, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "הסר";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(832, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "הוסף חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // P2Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 347);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(workerIdLabel);
            this.Controls.Add(this.workerIdTextBox);
            this.Controls.Add(workerNameLabel);
            this.Controls.Add(this.workerNameTextBox);
            this.Controls.Add(workerPhoneLabel);
            this.Controls.Add(this.workerPhoneTextBox);
            this.Controls.Add(workerAddressLabel);
            this.Controls.Add(this.workerAddressTextBox);
            this.Controls.Add(workerJoinDateLabel);
            this.Controls.Add(this.workerJoinDateDateTimePicker);
            this.Controls.Add(workerBirthDateLabel);
            this.Controls.Add(this.workerBirthDateDateTimePicker);
            this.Controls.Add(this.workersDataGridView);
            this.Name = "P2Workers";
            this.Text = "P2Workers";
            this.Load += new System.EventHandler(this.P2Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DatabaseDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox workerIdTextBox;
        private System.Windows.Forms.TextBox workerNameTextBox;
        private System.Windows.Forms.TextBox workerPhoneTextBox;
        private System.Windows.Forms.TextBox workerAddressTextBox;
        private System.Windows.Forms.DateTimePicker workerJoinDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker workerBirthDateDateTimePicker;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}