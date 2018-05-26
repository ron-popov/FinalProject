namespace DbapyInc
{
    partial class P4Surveys
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
            System.Windows.Forms.Label surveyIdLabel;
            System.Windows.Forms.Label projectIdLabel;
            System.Windows.Forms.Label surveyDateLabel;
            System.Windows.Forms.Label workerIdLabel;
            System.Windows.Forms.Label q1Label;
            System.Windows.Forms.Label q2Label;
            System.Windows.Forms.Label q3Label;
            System.Windows.Forms.Label q4Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P4Surveys));
            this.databaseDataSet = new DbapyInc.DatabaseDataSet();
            this.surveysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surveysTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.SurveysTableAdapter();
            this.tableAdapterManager = new DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.surveysDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surveyIdTextBox = new System.Windows.Forms.TextBox();
            this.projectIdComboBox = new System.Windows.Forms.ComboBox();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surveyDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workerIdComboBox = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.q1ComboBox = new System.Windows.Forms.ComboBox();
            this.q2ComboBox = new System.Windows.Forms.ComboBox();
            this.q3ComboBox = new System.Windows.Forms.ComboBox();
            this.q4ComboBox = new System.Windows.Forms.ComboBox();
            this.workersTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.WorkersTableAdapter();
            this.projectsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.ProjectsTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            surveyIdLabel = new System.Windows.Forms.Label();
            projectIdLabel = new System.Windows.Forms.Label();
            surveyDateLabel = new System.Windows.Forms.Label();
            workerIdLabel = new System.Windows.Forms.Label();
            q1Label = new System.Windows.Forms.Label();
            q2Label = new System.Windows.Forms.Label();
            q3Label = new System.Windows.Forms.Label();
            q4Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveysDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // surveyIdLabel
            // 
            surveyIdLabel.AutoSize = true;
            surveyIdLabel.Location = new System.Drawing.Point(890, 26);
            surveyIdLabel.Name = "surveyIdLabel";
            surveyIdLabel.Size = new System.Drawing.Size(55, 13);
            surveyIdLabel.TabIndex = 1;
            surveyIdLabel.Text = "Survey Id:";
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.Location = new System.Drawing.Point(890, 52);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new System.Drawing.Size(55, 13);
            projectIdLabel.TabIndex = 3;
            projectIdLabel.Text = "Project Id:";
            // 
            // surveyDateLabel
            // 
            surveyDateLabel.AutoSize = true;
            surveyDateLabel.Location = new System.Drawing.Point(890, 80);
            surveyDateLabel.Name = "surveyDateLabel";
            surveyDateLabel.Size = new System.Drawing.Size(69, 13);
            surveyDateLabel.TabIndex = 5;
            surveyDateLabel.Text = "Survey Date:";
            // 
            // workerIdLabel
            // 
            workerIdLabel.AutoSize = true;
            workerIdLabel.Location = new System.Drawing.Point(890, 105);
            workerIdLabel.Name = "workerIdLabel";
            workerIdLabel.Size = new System.Drawing.Size(57, 13);
            workerIdLabel.TabIndex = 7;
            workerIdLabel.Text = "Worker Id:";
            // 
            // q1Label
            // 
            q1Label.AutoSize = true;
            q1Label.Location = new System.Drawing.Point(890, 132);
            q1Label.Name = "q1Label";
            q1Label.Size = new System.Drawing.Size(24, 13);
            q1Label.TabIndex = 9;
            q1Label.Text = "Q1:";
            // 
            // q2Label
            // 
            q2Label.AutoSize = true;
            q2Label.Location = new System.Drawing.Point(890, 159);
            q2Label.Name = "q2Label";
            q2Label.Size = new System.Drawing.Size(24, 13);
            q2Label.TabIndex = 11;
            q2Label.Text = "Q2:";
            // 
            // q3Label
            // 
            q3Label.AutoSize = true;
            q3Label.Location = new System.Drawing.Point(890, 186);
            q3Label.Name = "q3Label";
            q3Label.Size = new System.Drawing.Size(24, 13);
            q3Label.TabIndex = 13;
            q3Label.Text = "Q3:";
            // 
            // q4Label
            // 
            q4Label.AutoSize = true;
            q4Label.Location = new System.Drawing.Point(890, 213);
            q4Label.Name = "q4Label";
            q4Label.Size = new System.Drawing.Size(24, 13);
            q4Label.TabIndex = 15;
            q4Label.Text = "Q4:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // surveysBindingSource
            // 
            this.surveysBindingSource.DataMember = "Surveys";
            this.surveysBindingSource.DataSource = this.databaseDataSet;
            // 
            // surveysTableAdapter
            // 
            this.surveysTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SurveysTableAdapter = this.surveysTableAdapter;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.WorkersToTeamsTableAdapter = null;
            // 
            // surveysDataGridView
            // 
            this.surveysDataGridView.AutoGenerateColumns = false;
            this.surveysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.surveysDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.surveysDataGridView.DataSource = this.surveysBindingSource;
            this.surveysDataGridView.Location = new System.Drawing.Point(12, 12);
            this.surveysDataGridView.Name = "surveysDataGridView";
            this.surveysDataGridView.Size = new System.Drawing.Size(854, 392);
            this.surveysDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SurveyId";
            this.dataGridViewTextBoxColumn1.HeaderText = "SurveyId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProjectId";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProjectId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SurveyDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "SurveyDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "WorkerId";
            this.dataGridViewTextBoxColumn4.HeaderText = "WorkerId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Q1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Q1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Q2";
            this.dataGridViewTextBoxColumn6.HeaderText = "Q2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Q3";
            this.dataGridViewTextBoxColumn7.HeaderText = "Q3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Q4";
            this.dataGridViewTextBoxColumn8.HeaderText = "Q4";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // surveyIdTextBox
            // 
            this.surveyIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.surveysBindingSource, "SurveyId", true));
            this.surveyIdTextBox.Enabled = false;
            this.surveyIdTextBox.Location = new System.Drawing.Point(965, 23);
            this.surveyIdTextBox.Name = "surveyIdTextBox";
            this.surveyIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.surveyIdTextBox.TabIndex = 2;
            // 
            // projectIdComboBox
            // 
            this.projectIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.surveysBindingSource, "ProjectId", true));
            this.projectIdComboBox.DataSource = this.projectsBindingSource;
            this.projectIdComboBox.DisplayMember = "ProjectName";
            this.projectIdComboBox.FormattingEnabled = true;
            this.projectIdComboBox.Location = new System.Drawing.Point(965, 49);
            this.projectIdComboBox.Name = "projectIdComboBox";
            this.projectIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.projectIdComboBox.TabIndex = 4;
            this.projectIdComboBox.ValueMember = "ProjectId";
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.databaseDataSet;
            // 
            // surveyDateDateTimePicker
            // 
            this.surveyDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.surveysBindingSource, "SurveyDate", true));
            this.surveyDateDateTimePicker.Location = new System.Drawing.Point(965, 76);
            this.surveyDateDateTimePicker.Name = "surveyDateDateTimePicker";
            this.surveyDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.surveyDateDateTimePicker.TabIndex = 6;
            // 
            // workerIdComboBox
            // 
            this.workerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.surveysBindingSource, "WorkerId", true));
            this.workerIdComboBox.DataSource = this.workersBindingSource;
            this.workerIdComboBox.DisplayMember = "WorkerName";
            this.workerIdComboBox.FormattingEnabled = true;
            this.workerIdComboBox.Location = new System.Drawing.Point(965, 102);
            this.workerIdComboBox.Name = "workerIdComboBox";
            this.workerIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.workerIdComboBox.TabIndex = 8;
            this.workerIdComboBox.ValueMember = "WorkerId";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.databaseDataSet;
            // 
            // q1ComboBox
            // 
            this.q1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.surveysBindingSource, "Q1", true));
            this.q1ComboBox.FormattingEnabled = true;
            this.q1ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.q1ComboBox.Location = new System.Drawing.Point(965, 129);
            this.q1ComboBox.Name = "q1ComboBox";
            this.q1ComboBox.Size = new System.Drawing.Size(200, 21);
            this.q1ComboBox.TabIndex = 10;
            // 
            // q2ComboBox
            // 
            this.q2ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.surveysBindingSource, "Q2", true));
            this.q2ComboBox.FormattingEnabled = true;
            this.q2ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.q2ComboBox.Location = new System.Drawing.Point(965, 156);
            this.q2ComboBox.Name = "q2ComboBox";
            this.q2ComboBox.Size = new System.Drawing.Size(200, 21);
            this.q2ComboBox.TabIndex = 12;
            // 
            // q3ComboBox
            // 
            this.q3ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.surveysBindingSource, "Q3", true));
            this.q3ComboBox.FormattingEnabled = true;
            this.q3ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.q3ComboBox.Location = new System.Drawing.Point(965, 183);
            this.q3ComboBox.Name = "q3ComboBox";
            this.q3ComboBox.Size = new System.Drawing.Size(200, 21);
            this.q3ComboBox.TabIndex = 14;
            // 
            // q4ComboBox
            // 
            this.q4ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.surveysBindingSource, "Q4", true));
            this.q4ComboBox.FormattingEnabled = true;
            this.q4ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.q4ComboBox.Location = new System.Drawing.Point(965, 210);
            this.q4ComboBox.Name = "q4ComboBox";
            this.q4ComboBox.Size = new System.Drawing.Size(200, 21);
            this.q4ComboBox.TabIndex = 16;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1063, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 48;
            this.button5.Text = "למטה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(929, 380);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 23);
            this.button6.TabIndex = 47;
            this.button6.Text = "אחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1063, 351);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 23);
            this.button7.TabIndex = 46;
            this.button7.Text = "למעלה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(929, 351);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 23);
            this.button8.TabIndex = 45;
            this.button8.Text = "ראשון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1063, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "שמירה";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(929, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "עדכון ממסד";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1063, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "הסר";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(929, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "הוסף חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(12, 416);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 39);
            this.button14.TabIndex = 63;
            this.button14.Text = "הצג דוח סקרים";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(108, 416);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 40);
            this.button15.TabIndex = 62;
            this.button15.Text = "הדפס דוח צוותים";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // P4Surveys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 467);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(surveyIdLabel);
            this.Controls.Add(this.surveyIdTextBox);
            this.Controls.Add(projectIdLabel);
            this.Controls.Add(this.projectIdComboBox);
            this.Controls.Add(surveyDateLabel);
            this.Controls.Add(this.surveyDateDateTimePicker);
            this.Controls.Add(workerIdLabel);
            this.Controls.Add(this.workerIdComboBox);
            this.Controls.Add(q1Label);
            this.Controls.Add(this.q1ComboBox);
            this.Controls.Add(q2Label);
            this.Controls.Add(this.q2ComboBox);
            this.Controls.Add(q3Label);
            this.Controls.Add(this.q3ComboBox);
            this.Controls.Add(q4Label);
            this.Controls.Add(this.q4ComboBox);
            this.Controls.Add(this.surveysDataGridView);
            this.Name = "P4Surveys";
            this.Text = "P4Surveys";
            this.Load += new System.EventHandler(this.P4Surveys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveysDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource surveysBindingSource;
        private DatabaseDataSetTableAdapters.SurveysTableAdapter surveysTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView surveysDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox surveyIdTextBox;
        private System.Windows.Forms.ComboBox projectIdComboBox;
        private System.Windows.Forms.DateTimePicker surveyDateDateTimePicker;
        private System.Windows.Forms.ComboBox workerIdComboBox;
        private System.Windows.Forms.ComboBox q1ComboBox;
        private System.Windows.Forms.ComboBox q2ComboBox;
        private System.Windows.Forms.ComboBox q3ComboBox;
        private System.Windows.Forms.ComboBox q4ComboBox;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DatabaseDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private DatabaseDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}