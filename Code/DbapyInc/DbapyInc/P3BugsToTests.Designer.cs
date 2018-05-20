namespace DbapyInc
{
    partial class P3BugsToTests
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
            System.Windows.Forms.Label testIdLabel;
            System.Windows.Forms.Label bugIdLabel;
            this.databaseDataSet = new DbapyInc.DatabaseDataSet();
            this.bugsToTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugsToTestsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.BugsToTestsTableAdapter();
            this.tableAdapterManager = new DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.bugsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.BugsTableAdapter();
            this.testsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.TestsTableAdapter();
            this.bugsToTestsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testIdComboBox = new System.Windows.Forms.ComboBox();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugIdComboBox = new System.Windows.Forms.ComboBox();
            this.bugsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugsBugsToTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            testIdLabel = new System.Windows.Forms.Label();
            bugIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsToTestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsToTestsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBugsToTestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // testIdLabel
            // 
            testIdLabel.AutoSize = true;
            testIdLabel.Location = new System.Drawing.Point(502, 25);
            testIdLabel.Name = "testIdLabel";
            testIdLabel.Size = new System.Drawing.Size(43, 13);
            testIdLabel.TabIndex = 1;
            testIdLabel.Text = "Test Id:";
            // 
            // bugIdLabel
            // 
            bugIdLabel.AutoSize = true;
            bugIdLabel.Location = new System.Drawing.Point(502, 52);
            bugIdLabel.Name = "bugIdLabel";
            bugIdLabel.Size = new System.Drawing.Size(41, 13);
            bugIdLabel.TabIndex = 3;
            bugIdLabel.Text = "Bug Id:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugsToTestsBindingSource
            // 
            this.bugsToTestsBindingSource.DataMember = "BugsToTests";
            this.bugsToTestsBindingSource.DataSource = this.databaseDataSet;
            // 
            // bugsToTestsTableAdapter
            // 
            this.bugsToTestsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BugsTableAdapter = this.bugsTableAdapter;
            this.tableAdapterManager.BugsToTestsTableAdapter = this.bugsToTestsTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProjectComponentsTableAdapter = null;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.ProjectTypesTableAdapter = null;
            this.tableAdapterManager.SurveysTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = this.testsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.WorkersToTeamsTableAdapter = null;
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // bugsToTestsDataGridView
            // 
            this.bugsToTestsDataGridView.AutoGenerateColumns = false;
            this.bugsToTestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugsToTestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.bugsToTestsDataGridView.DataSource = this.bugsToTestsBindingSource;
            this.bugsToTestsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.bugsToTestsDataGridView.Name = "bugsToTestsDataGridView";
            this.bugsToTestsDataGridView.Size = new System.Drawing.Size(457, 239);
            this.bugsToTestsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TestId";
            this.dataGridViewTextBoxColumn1.HeaderText = "TestId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BugId";
            this.dataGridViewTextBoxColumn2.HeaderText = "BugId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // testIdComboBox
            // 
            this.testIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugsToTestsBindingSource, "TestId", true));
            this.testIdComboBox.DataSource = this.testsBindingSource;
            this.testIdComboBox.DisplayMember = "TestId";
            this.testIdComboBox.FormattingEnabled = true;
            this.testIdComboBox.Location = new System.Drawing.Point(551, 22);
            this.testIdComboBox.Name = "testIdComboBox";
            this.testIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.testIdComboBox.TabIndex = 2;
            this.testIdComboBox.ValueMember = "TestId";
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            this.testsBindingSource.DataSource = this.databaseDataSet;
            // 
            // bugIdComboBox
            // 
            this.bugIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugsToTestsBindingSource, "BugId", true));
            this.bugIdComboBox.DataSource = this.bugsBindingSource1;
            this.bugIdComboBox.DisplayMember = "BugName";
            this.bugIdComboBox.FormattingEnabled = true;
            this.bugIdComboBox.Location = new System.Drawing.Point(551, 49);
            this.bugIdComboBox.Name = "bugIdComboBox";
            this.bugIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.bugIdComboBox.TabIndex = 4;
            this.bugIdComboBox.ValueMember = "BugId";
            // 
            // bugsBindingSource1
            // 
            this.bugsBindingSource1.DataMember = "Bugs";
            this.bugsBindingSource1.DataSource = this.databaseDataSet;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(595, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 48;
            this.button5.Text = "למטה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(497, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 47;
            this.button6.Text = "אחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(595, 188);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 46;
            this.button7.Text = "למעלה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(497, 188);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 23);
            this.button8.TabIndex = 45;
            this.button8.Text = "ראשון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(595, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "שמירה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "עדכון ממסד";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "הסר";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "הוסף חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bugsBindingSource
            // 
            this.bugsBindingSource.DataMember = "Bugs";
            this.bugsBindingSource.DataSource = this.databaseDataSet;
            // 
            // bugsBugsToTestsBindingSource
            // 
            this.bugsBugsToTestsBindingSource.DataMember = "BugsBugsToTests";
            this.bugsBugsToTestsBindingSource.DataSource = this.bugsBindingSource;
            // 
            // P3BugsToTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 278);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(testIdLabel);
            this.Controls.Add(this.testIdComboBox);
            this.Controls.Add(bugIdLabel);
            this.Controls.Add(this.bugIdComboBox);
            this.Controls.Add(this.bugsToTestsDataGridView);
            this.Name = "P3BugsToTests";
            this.Text = "P3BugsToTests";
            this.Load += new System.EventHandler(this.P3BugsToTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsToTestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsToTestsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBugsToTestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource bugsToTestsBindingSource;
        private DatabaseDataSetTableAdapters.BugsToTestsTableAdapter bugsToTestsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bugsToTestsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox testIdComboBox;
        private System.Windows.Forms.ComboBox bugIdComboBox;
        private DatabaseDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private DatabaseDataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private System.Windows.Forms.BindingSource bugsBindingSource1;
        private System.Windows.Forms.BindingSource bugsBugsToTestsBindingSource;
    }
}