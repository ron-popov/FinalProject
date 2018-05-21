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
            teamIdLabel = new System.Windows.Forms.Label();
            teamNameLabel = new System.Windows.Forms.Label();
            manageridLabel = new System.Windows.Forms.Label();
            componentIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectComponentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teamIdLabel
            // 
            teamIdLabel.AutoSize = true;
            teamIdLabel.Location = new System.Drawing.Point(812, 25);
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
            manageridLabel.Location = new System.Drawing.Point(812, 77);
            manageridLabel.Name = "manageridLabel";
            manageridLabel.Size = new System.Drawing.Size(60, 13);
            manageridLabel.TabIndex = 5;
            manageridLabel.Text = "Managerid:";
            // 
            // componentIdLabel
            // 
            componentIdLabel.AutoSize = true;
            componentIdLabel.Location = new System.Drawing.Point(812, 104);
            componentIdLabel.Name = "componentIdLabel";
            componentIdLabel.Size = new System.Drawing.Size(76, 13);
            componentIdLabel.TabIndex = 7;
            componentIdLabel.Text = "Component Id:";
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
            this.teamsDataGridView.Size = new System.Drawing.Size(766, 276);
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
            this.manageridComboBox.DisplayMember = "WorkerName";
            this.manageridComboBox.FormattingEnabled = true;
            this.manageridComboBox.Location = new System.Drawing.Point(894, 74);
            this.manageridComboBox.Name = "manageridComboBox";
            this.manageridComboBox.Size = new System.Drawing.Size(121, 21);
            this.manageridComboBox.TabIndex = 6;
            this.manageridComboBox.ValueMember = "WorkerId";
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
            this.componentIdComboBox.DisplayMember = "ComponentName";
            this.componentIdComboBox.FormattingEnabled = true;
            this.componentIdComboBox.Location = new System.Drawing.Point(894, 101);
            this.componentIdComboBox.Name = "componentIdComboBox";
            this.componentIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.componentIdComboBox.TabIndex = 8;
            this.componentIdComboBox.ValueMember = "ComponentId";
            // 
            // projectComponentsBindingSource
            // 
            this.projectComponentsBindingSource.DataMember = "ProjectComponents";
            this.projectComponentsBindingSource.DataSource = this.databaseDataSet;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(915, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "למטה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(817, 265);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 39;
            this.button6.Text = "אחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(915, 236);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 38;
            this.button7.Text = "למעלה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(817, 236);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 23);
            this.button8.TabIndex = 37;
            this.button8.Text = "ראשון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(915, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "שמירה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(817, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "עדכון ממסד";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(915, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "הסר";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "הוסף חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // P2Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 308);
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
    }
}