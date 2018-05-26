namespace DbapyInc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P2Workers));
            this.databaseDataSet = new DbapyInc.DatabaseDataSet();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIdTextBox = new System.Windows.Forms.TextBox();
            this.workerNameTextBox = new System.Windows.Forms.TextBox();
            this.workerPhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.workerAddressTextBox = new System.Windows.Forms.TextBox();
            this.workerJoinDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workerBirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.workersToTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersToTeamsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.WorkersToTeamsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            workerIdLabel = new System.Windows.Forms.Label();
            workerNameLabel = new System.Windows.Forms.Label();
            workerPhoneLabel = new System.Windows.Forms.Label();
            workerAddressLabel = new System.Windows.Forms.Label();
            workerJoinDateLabel = new System.Windows.Forms.Label();
            workerBirthDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersToTeamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workerIdLabel
            // 
            workerIdLabel.AutoSize = true;
            workerIdLabel.Location = new System.Drawing.Point(829, 12);
            workerIdLabel.Name = "workerIdLabel";
            workerIdLabel.Size = new System.Drawing.Size(57, 13);
            workerIdLabel.TabIndex = 32;
            workerIdLabel.Text = "Worker Id:";
            // 
            // workerNameLabel
            // 
            workerNameLabel.AutoSize = true;
            workerNameLabel.Location = new System.Drawing.Point(829, 38);
            workerNameLabel.Name = "workerNameLabel";
            workerNameLabel.Size = new System.Drawing.Size(76, 13);
            workerNameLabel.TabIndex = 34;
            workerNameLabel.Text = "Worker Name:";
            // 
            // workerPhoneLabel
            // 
            workerPhoneLabel.AutoSize = true;
            workerPhoneLabel.Location = new System.Drawing.Point(829, 64);
            workerPhoneLabel.Name = "workerPhoneLabel";
            workerPhoneLabel.Size = new System.Drawing.Size(79, 13);
            workerPhoneLabel.TabIndex = 36;
            workerPhoneLabel.Text = "Worker Phone:";
            // 
            // workerAddressLabel
            // 
            workerAddressLabel.AutoSize = true;
            workerAddressLabel.Location = new System.Drawing.Point(829, 90);
            workerAddressLabel.Name = "workerAddressLabel";
            workerAddressLabel.Size = new System.Drawing.Size(86, 13);
            workerAddressLabel.TabIndex = 38;
            workerAddressLabel.Text = "Worker Address:";
            // 
            // workerJoinDateLabel
            // 
            workerJoinDateLabel.AutoSize = true;
            workerJoinDateLabel.Location = new System.Drawing.Point(829, 143);
            workerJoinDateLabel.Name = "workerJoinDateLabel";
            workerJoinDateLabel.Size = new System.Drawing.Size(93, 13);
            workerJoinDateLabel.TabIndex = 40;
            workerJoinDateLabel.Text = "Worker Join Date:";
            // 
            // workerBirthDateLabel
            // 
            workerBirthDateLabel.AutoSize = true;
            workerBirthDateLabel.Location = new System.Drawing.Point(829, 117);
            workerBirthDateLabel.Name = "workerBirthDateLabel";
            workerBirthDateLabel.Size = new System.Drawing.Size(95, 13);
            workerBirthDateLabel.TabIndex = 42;
            workerBirthDateLabel.Text = "Worker Birth Date:";
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(980, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "למטה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(846, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "אחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(980, 334);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 23);
            this.button7.TabIndex = 30;
            this.button7.Text = "למעלה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(846, 334);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "ראשון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(980, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "שמירה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(846, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "עדכון ממסד";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(980, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "הסר";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "הוסף חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.workersDataGridView.Size = new System.Drawing.Size(788, 374);
            this.workersDataGridView.TabIndex = 32;
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
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "WorkerJoinDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "WorkerBirthDate";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn6.HeaderText = "WorkerBirthDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // workerIdTextBox
            // 
            this.workerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WorkerId", true));
            this.workerIdTextBox.Location = new System.Drawing.Point(930, 9);
            this.workerIdTextBox.Name = "workerIdTextBox";
            this.workerIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.workerIdTextBox.TabIndex = 33;
            // 
            // workerNameTextBox
            // 
            this.workerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WorkerName", true));
            this.workerNameTextBox.Location = new System.Drawing.Point(930, 35);
            this.workerNameTextBox.Name = "workerNameTextBox";
            this.workerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.workerNameTextBox.TabIndex = 35;
            // 
            // workerPhoneMaskedTextBox
            // 
            this.workerPhoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WorkerPhone", true));
            this.workerPhoneMaskedTextBox.Location = new System.Drawing.Point(930, 61);
            this.workerPhoneMaskedTextBox.Mask = "000-0000000";
            this.workerPhoneMaskedTextBox.Name = "workerPhoneMaskedTextBox";
            this.workerPhoneMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.workerPhoneMaskedTextBox.TabIndex = 37;
            // 
            // workerAddressTextBox
            // 
            this.workerAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "WorkerAddress", true));
            this.workerAddressTextBox.Location = new System.Drawing.Point(930, 87);
            this.workerAddressTextBox.Name = "workerAddressTextBox";
            this.workerAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.workerAddressTextBox.TabIndex = 39;
            // 
            // workerJoinDateDateTimePicker
            // 
            this.workerJoinDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workersBindingSource, "WorkerJoinDate", true));
            this.workerJoinDateDateTimePicker.Enabled = false;
            this.workerJoinDateDateTimePicker.Location = new System.Drawing.Point(930, 139);
            this.workerJoinDateDateTimePicker.Name = "workerJoinDateDateTimePicker";
            this.workerJoinDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.workerJoinDateDateTimePicker.TabIndex = 41;
            // 
            // workerBirthDateDateTimePicker
            // 
            this.workerBirthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workersBindingSource, "WorkerBirthDate", true));
            this.workerBirthDateDateTimePicker.Location = new System.Drawing.Point(930, 113);
            this.workerBirthDateDateTimePicker.Name = "workerBirthDateDateTimePicker";
            this.workerBirthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.workerBirthDateDateTimePicker.TabIndex = 43;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(149, 431);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 59);
            this.button9.TabIndex = 44;
            this.button9.Text = "חיפוש לפי שם";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 45;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(287, 405);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 47;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(287, 431);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 59);
            this.button10.TabIndex = 46;
            this.button10.Text = "חיפוש לפי קוד עובד";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(15, 405);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 85);
            this.button11.TabIndex = 48;
            this.button11.Text = "נקה חיפוש";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(947, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(829, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Worker Years Exp :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Worker Age :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(930, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 52;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(416, 405);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 40);
            this.button12.TabIndex = 54;
            this.button12.Text = "הצג דוח עובד";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(416, 451);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 39);
            this.button13.TabIndex = 55;
            this.button13.Text = "הדפס דוח עובד";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(534, 431);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "צוותי עובד";
            // 
            // workersToTeamsBindingSource
            // 
            this.workersToTeamsBindingSource.DataMember = "WorkersToTeams";
            this.workersToTeamsBindingSource.DataSource = this.databaseDataSet;
            // 
            // workersToTeamsTableAdapter
            // 
            this.workersToTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(829, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Current Projects :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(947, 217);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 20);
            this.textBox5.TabIndex = 58;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(670, 448);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 39);
            this.button14.TabIndex = 61;
            this.button14.Text = "הדפס דוח עובדים";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(670, 402);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 40);
            this.button15.TabIndex = 60;
            this.button15.Text = "הצג דוח עובדים";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // P2Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 502);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(workerIdLabel);
            this.Controls.Add(this.workerIdTextBox);
            this.Controls.Add(workerNameLabel);
            this.Controls.Add(this.workerNameTextBox);
            this.Controls.Add(workerPhoneLabel);
            this.Controls.Add(this.workerPhoneMaskedTextBox);
            this.Controls.Add(workerAddressLabel);
            this.Controls.Add(this.workerAddressTextBox);
            this.Controls.Add(workerJoinDateLabel);
            this.Controls.Add(this.workerJoinDateDateTimePicker);
            this.Controls.Add(workerBirthDateLabel);
            this.Controls.Add(this.workerBirthDateDateTimePicker);
            this.Controls.Add(this.workersDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "P2Workers";
            this.Text = "P2Workers";
            this.Load += new System.EventHandler(this.P2Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersToTeamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DatabaseDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.TextBox workerIdTextBox;
        private System.Windows.Forms.TextBox workerNameTextBox;
        private System.Windows.Forms.MaskedTextBox workerPhoneMaskedTextBox;
        private System.Windows.Forms.TextBox workerAddressTextBox;
        private System.Windows.Forms.DateTimePicker workerJoinDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker workerBirthDateDateTimePicker;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource workersToTeamsBindingSource;
        private DatabaseDataSetTableAdapters.WorkersToTeamsTableAdapter workersToTeamsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}