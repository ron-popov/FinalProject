namespace DbapyInc
{
    partial class P2Teams
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
            System.Windows.Forms.Label teamIdLabel;
            System.Windows.Forms.Label teamNameLabel;
            System.Windows.Forms.Label manageridLabel;
            System.Windows.Forms.Label componentIdLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P2Teams));
            this.databaseDataSet = new DbapyInc.DatabaseDataSet();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.TeamsTableAdapter();
            this.tableAdapterManager = new DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.projectComponentsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.ProjectComponentsTableAdapter();
            this.workersTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.WorkersTableAdapter();
            this.teamsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdTextBox = new System.Windows.Forms.TextBox();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.manageridComboBox = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentIdComboBox = new System.Windows.Forms.ComboBox();
            this.projectComponentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.ProjectsTableAdapter();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.workersToTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersToTeamsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.WorkersToTeamsTableAdapter();
            teamIdLabel = new System.Windows.Forms.Label();
            teamNameLabel = new System.Windows.Forms.Label();
            manageridLabel = new System.Windows.Forms.Label();
            componentIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectComponentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersToTeamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teamIdLabel
            // 
            teamIdLabel.AutoSize = true;
            teamIdLabel.Location = new System.Drawing.Point(820, 25);
            teamIdLabel.Name = "teamIdLabel";
            teamIdLabel.Size = new System.Drawing.Size(49, 13);
            teamIdLabel.TabIndex = 1;
            teamIdLabel.Text = "Team Id:";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new System.Drawing.Point(812, 51);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new System.Drawing.Size(68, 13);
            teamNameLabel.TabIndex = 3;
            teamNameLabel.Text = "Team Name:";
            // 
            // manageridLabel
            // 
            manageridLabel.AutoSize = true;
            manageridLabel.Location = new System.Drawing.Point(820, 82);
            manageridLabel.Name = "manageridLabel";
            manageridLabel.Size = new System.Drawing.Size(67, 13);
            manageridLabel.TabIndex = 5;
            manageridLabel.Text = "Manager Id :";
            // 
            // componentIdLabel
            // 
            componentIdLabel.AutoSize = true;
            componentIdLabel.Location = new System.Drawing.Point(812, 133);
            componentIdLabel.Name = "componentIdLabel";
            componentIdLabel.Size = new System.Drawing.Size(76, 13);
            componentIdLabel.TabIndex = 7;
            componentIdLabel.Text = "Component Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(802, 107);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 13);
            label1.TabIndex = 41;
            label1.Text = "Manager Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(790, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 13);
            label2.TabIndex = 43;
            label2.Text = "Component Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(802, 186);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 13);
            label3.TabIndex = 45;
            label3.Text = "Project Name :";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.databaseDataSet;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BugsTableAdapter = null;
            this.tableAdapterManager.BugsToTestsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProjectComponentsTableAdapter = this.projectComponentsTableAdapter;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.ProjectTypesTableAdapter = null;
            this.tableAdapterManager.SurveysTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = this.teamsTableAdapter;
            this.tableAdapterManager.TestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            this.tableAdapterManager.WorkersToTeamsTableAdapter = null;
            // 
            // projectComponentsTableAdapter
            // 
            this.projectComponentsTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // teamsDataGridView
            // 
            this.teamsDataGridView.AutoGenerateColumns = false;
            this.teamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.teamsDataGridView.DataSource = this.teamsBindingSource;
            this.teamsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.teamsDataGridView.Name = "teamsDataGridView";
            this.teamsDataGridView.Size = new System.Drawing.Size(766, 383);
            this.teamsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TeamId";
            this.dataGridViewTextBoxColumn1.HeaderText = "TeamId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeamName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TeamName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Managerid";
            this.dataGridViewTextBoxColumn3.HeaderText = "Managerid";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ComponentId";
            this.dataGridViewTextBoxColumn4.HeaderText = "ComponentId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // teamIdTextBox
            // 
            this.teamIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "TeamId", true));
            this.teamIdTextBox.Enabled = false;
            this.teamIdTextBox.Location = new System.Drawing.Point(894, 22);
            this.teamIdTextBox.Name = "teamIdTextBox";
            this.teamIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.teamIdTextBox.TabIndex = 2;
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "TeamName", true));
            this.teamNameTextBox.Location = new System.Drawing.Point(894, 48);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.teamNameTextBox.TabIndex = 4;
            // 
            // manageridComboBox
            // 
            this.manageridComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "Managerid", true));
            this.manageridComboBox.DataSource = this.workersBindingSource;
            this.manageridComboBox.DisplayMember = "WorkerId";
            this.manageridComboBox.FormattingEnabled = true;
            this.manageridComboBox.Location = new System.Drawing.Point(894, 74);
            this.manageridComboBox.Name = "manageridComboBox";
            this.manageridComboBox.Size = new System.Drawing.Size(121, 21);
            this.manageridComboBox.TabIndex = 6;
            this.manageridComboBox.ValueMember = "WorkerId";
            this.manageridComboBox.SelectedIndexChanged += new System.EventHandler(this.manageridComboBox_SelectedIndexChanged);
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.databaseDataSet;
            // 
            // componentIdComboBox
            // 
            this.componentIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "ComponentId", true));
            this.componentIdComboBox.DataSource = this.projectComponentsBindingSource;
            this.componentIdComboBox.DisplayMember = "ComponentId";
            this.componentIdComboBox.FormattingEnabled = true;
            this.componentIdComboBox.Location = new System.Drawing.Point(894, 130);
            this.componentIdComboBox.Name = "componentIdComboBox";
            this.componentIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.componentIdComboBox.TabIndex = 8;
            this.componentIdComboBox.ValueMember = "ComponentId";
            this.componentIdComboBox.SelectedIndexChanged += new System.EventHandler(this.componentIdComboBox_SelectedIndexChanged);
            // 
            // projectComponentsBindingSource
            // 
            this.projectComponentsBindingSource.DataMember = "ProjectComponents";
            this.projectComponentsBindingSource.DataSource = this.databaseDataSet;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(915, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "למטה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(817, 375);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 39;
            this.button6.Text = "אחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(915, 346);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 38;
            this.button7.Text = "למעלה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(817, 346);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 23);
            this.button8.TabIndex = 37;
            this.button8.Text = "ראשון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(915, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "שמירה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(817, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "עדכון ממסד";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(915, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "הסר";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "הוסף חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "TeamName", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(894, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 42;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "TeamName", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(894, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 44;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "TeamName", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(894, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 46;
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
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(108, 410);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 39);
            this.button13.TabIndex = 57;
            this.button13.Text = "הדפס דוח צוותים";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 410);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 40);
            this.button12.TabIndex = 56;
            this.button12.Text = "הצג דוח צוותים";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
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
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(361, 409);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 39);
            this.button9.TabIndex = 59;
            this.button9.Text = "הדפס דוח צוות";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(265, 409);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 40);
            this.button10.TabIndex = 58;
            this.button10.Text = "הצג דוח צוות";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage_1);
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
            // P2Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 459);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(teamIdLabel);
            this.Controls.Add(this.teamIdTextBox);
            this.Controls.Add(teamNameLabel);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(manageridLabel);
            this.Controls.Add(this.manageridComboBox);
            this.Controls.Add(componentIdLabel);
            this.Controls.Add(this.componentIdComboBox);
            this.Controls.Add(this.teamsDataGridView);
            this.Name = "P2Teams";
            this.Text = "P2Teams";
            this.Load += new System.EventHandler(this.P2Teams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectComponentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersToTeamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private DatabaseDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView teamsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DatabaseDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.TextBox teamIdTextBox;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.ComboBox manageridComboBox;
        private System.Windows.Forms.ComboBox componentIdComboBox;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DatabaseDataSetTableAdapters.ProjectComponentsTableAdapter projectComponentsTableAdapter;
        private System.Windows.Forms.BindingSource projectComponentsBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private DatabaseDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.BindingSource workersToTeamsBindingSource;
        private DatabaseDataSetTableAdapters.WorkersToTeamsTableAdapter workersToTeamsTableAdapter;
    }
}