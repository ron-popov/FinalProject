namespace DbapyInc
{
    partial class P1Projects
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
            System.Windows.Forms.Label orderIdLabel;
            System.Windows.Forms.Label managerIdLabel;
            System.Windows.Forms.Label projectTypeLabel;
            System.Windows.Forms.Label projectPriceLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1Projects));
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.databaseDataSet = new DbapyInc.DatabaseDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.ProjectsTableAdapter();
            this.tableAdapterManager = new DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.ordersTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.OrdersTableAdapter();
            this.projectTypesTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.ProjectTypesTableAdapter();
            this.workersTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.WorkersTableAdapter();
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIdTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.orderIdComboBox = new System.Windows.Forms.ComboBox();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerIdComboBox = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.projectTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectPriceTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.workersToTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersToTeamsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.WorkersToTeamsTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            projectIdLabel = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            orderIdLabel = new System.Windows.Forms.Label();
            managerIdLabel = new System.Windows.Forms.Label();
            projectTypeLabel = new System.Windows.Forms.Label();
            projectPriceLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTypesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersToTeamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.Location = new System.Drawing.Point(724, 21);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new System.Drawing.Size(55, 13);
            projectIdLabel.TabIndex = 25;
            projectIdLabel.Text = "Project Id:";
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(724, 47);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(74, 13);
            projectNameLabel.TabIndex = 27;
            projectNameLabel.Text = "Project Name:";
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Location = new System.Drawing.Point(724, 73);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new System.Drawing.Size(48, 13);
            orderIdLabel.TabIndex = 29;
            orderIdLabel.Text = "Order Id:";
            // 
            // managerIdLabel
            // 
            managerIdLabel.AutoSize = true;
            managerIdLabel.Location = new System.Drawing.Point(724, 100);
            managerIdLabel.Name = "managerIdLabel";
            managerIdLabel.Size = new System.Drawing.Size(64, 13);
            managerIdLabel.TabIndex = 31;
            managerIdLabel.Text = "Manager Id:";
            // 
            // projectTypeLabel
            // 
            projectTypeLabel.AutoSize = true;
            projectTypeLabel.Location = new System.Drawing.Point(724, 127);
            projectTypeLabel.Name = "projectTypeLabel";
            projectTypeLabel.Size = new System.Drawing.Size(70, 13);
            projectTypeLabel.TabIndex = 33;
            projectTypeLabel.Text = "Project Type:";
            // 
            // projectPriceLabel
            // 
            projectPriceLabel.AutoSize = true;
            projectPriceLabel.Location = new System.Drawing.Point(724, 154);
            projectPriceLabel.Name = "projectPriceLabel";
            projectPriceLabel.Size = new System.Drawing.Size(70, 13);
            projectPriceLabel.TabIndex = 35;
            projectPriceLabel.Text = "Project Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 37;
            label1.Text = "שם מנהל :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 13);
            label2.TabIndex = 39;
            label2.Text = "שנות וותק :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(952, 127);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 13);
            label3.TabIndex = 41;
            label3.Text = "סוג פרויקט :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(1, 57);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 13);
            label4.TabIndex = 41;
            label4.Text = "צוותים למנהל :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(825, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "למטה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(727, 315);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "אחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(825, 286);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "למעלה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(727, 286);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 23);
            this.button8.TabIndex = 21;
            this.button8.Text = "ראשון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(825, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "שמירה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(727, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "עדכון ממסד";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(825, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "הסר";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(727, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "הוסף חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.databaseDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BugsTableAdapter = null;
            this.tableAdapterManager.BugsToTestsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ProjectComponentsTableAdapter = null;
            this.tableAdapterManager.ProjectsTableAdapter = this.projectsTableAdapter;
            this.tableAdapterManager.ProjectTypesTableAdapter = this.projectTypesTableAdapter;
            this.tableAdapterManager.SurveysTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            this.tableAdapterManager.WorkersToTeamsTableAdapter = null;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // projectTypesTableAdapter
            // 
            this.projectTypesTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // projectsDataGridView
            // 
            this.projectsDataGridView.AutoGenerateColumns = false;
            this.projectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.projectsDataGridView.DataSource = this.projectsBindingSource;
            this.projectsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.projectsDataGridView.Name = "projectsDataGridView";
            this.projectsDataGridView.Size = new System.Drawing.Size(674, 326);
            this.projectsDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProjectId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProjectId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProjectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProjectName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderId";
            this.dataGridViewTextBoxColumn3.HeaderText = "OrderId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ManagerId";
            this.dataGridViewTextBoxColumn4.HeaderText = "ManagerId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProjectType";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProjectType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProjectPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "ProjectPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // projectIdTextBox
            // 
            this.projectIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectId", true));
            this.projectIdTextBox.Enabled = false;
            this.projectIdTextBox.Location = new System.Drawing.Point(804, 18);
            this.projectIdTextBox.Name = "projectIdTextBox";
            this.projectIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.projectIdTextBox.TabIndex = 26;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectName", true));
            this.projectNameTextBox.Location = new System.Drawing.Point(804, 44);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.projectNameTextBox.TabIndex = 28;
            // 
            // orderIdComboBox
            // 
            this.orderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "OrderId", true));
            this.orderIdComboBox.DataSource = this.ordersBindingSource;
            this.orderIdComboBox.DisplayMember = "OrderId";
            this.orderIdComboBox.FormattingEnabled = true;
            this.orderIdComboBox.Location = new System.Drawing.Point(804, 70);
            this.orderIdComboBox.Name = "orderIdComboBox";
            this.orderIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderIdComboBox.TabIndex = 30;
            this.orderIdComboBox.ValueMember = "OrderId";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.databaseDataSet;
            // 
            // managerIdComboBox
            // 
            this.managerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ManagerId", true));
            this.managerIdComboBox.DataSource = this.workersBindingSource;
            this.managerIdComboBox.DisplayMember = "WorkerId";
            this.managerIdComboBox.FormattingEnabled = true;
            this.managerIdComboBox.Location = new System.Drawing.Point(804, 97);
            this.managerIdComboBox.Name = "managerIdComboBox";
            this.managerIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.managerIdComboBox.TabIndex = 32;
            this.managerIdComboBox.ValueMember = "WorkerId";
            this.managerIdComboBox.SelectedIndexChanged += new System.EventHandler(this.managerIdComboBox_SelectedIndexChanged);
            this.managerIdComboBox.ValueMemberChanged += new System.EventHandler(this.managerIdComboBox_ValueMemberChanged);
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.databaseDataSet;
            // 
            // projectTypeComboBox
            // 
            this.projectTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectType", true));
            this.projectTypeComboBox.DataSource = this.projectTypesBindingSource;
            this.projectTypeComboBox.DisplayMember = "TypeId";
            this.projectTypeComboBox.FormattingEnabled = true;
            this.projectTypeComboBox.Location = new System.Drawing.Point(804, 124);
            this.projectTypeComboBox.Name = "projectTypeComboBox";
            this.projectTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.projectTypeComboBox.TabIndex = 34;
            this.projectTypeComboBox.ValueMember = "TypeId";
            this.projectTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.projectTypeComboBox_SelectedIndexChanged);
            // 
            // projectTypesBindingSource
            // 
            this.projectTypesBindingSource.DataMember = "ProjectTypes";
            this.projectTypesBindingSource.DataSource = this.databaseDataSet;
            // 
            // projectPriceTextBox
            // 
            this.projectPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectPrice", true));
            this.projectPriceTextBox.Location = new System.Drawing.Point(804, 151);
            this.projectPriceTextBox.Name = "projectPriceTextBox";
            this.projectPriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.projectPriceTextBox.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectId", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(92, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectId", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(92, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 40;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectId", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(1032, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(label2);
            this.panel1.Location = new System.Drawing.Point(946, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 100);
            this.panel1.TabIndex = 43;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ProjectId", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(92, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 42;
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(955, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(203, 23);
            this.button9.TabIndex = 44;
            this.button9.Text = "הצג דוח פרויקטים";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(954, 315);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(204, 23);
            this.button10.TabIndex = 45;
            this.button10.Text = "הדפס דוח פרויקטים";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // P1Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 361);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(projectIdLabel);
            this.Controls.Add(this.projectIdTextBox);
            this.Controls.Add(projectNameLabel);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(orderIdLabel);
            this.Controls.Add(this.orderIdComboBox);
            this.Controls.Add(managerIdLabel);
            this.Controls.Add(this.managerIdComboBox);
            this.Controls.Add(projectTypeLabel);
            this.Controls.Add(this.projectTypeComboBox);
            this.Controls.Add(projectPriceLabel);
            this.Controls.Add(this.projectPriceTextBox);
            this.Controls.Add(this.projectsDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "P1Projects";
            this.Text = "P1Projects";
            this.Load += new System.EventHandler(this.P1Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTypesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersToTeamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private DatabaseDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView projectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox projectIdTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.ComboBox orderIdComboBox;
        private System.Windows.Forms.ComboBox managerIdComboBox;
        private System.Windows.Forms.ComboBox projectTypeComboBox;
        private System.Windows.Forms.TextBox projectPriceTextBox;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DatabaseDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DatabaseDataSetTableAdapters.ProjectTypesTableAdapter projectTypesTableAdapter;
        private System.Windows.Forms.BindingSource projectTypesBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource workersToTeamsBindingSource;
        private DatabaseDataSetTableAdapters.WorkersToTeamsTableAdapter workersToTeamsTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}