namespace DbapyInc
{
    partial class P2Components
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
            System.Windows.Forms.Label componentIdLabel;
            System.Windows.Forms.Label componentNameLabel;
            System.Windows.Forms.Label projectIdLabel;
            System.Windows.Forms.Label label1;
            this.databaseDataSet = new DbapyInc.DatabaseDataSet();
            this.projectComponentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectComponentsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.ProjectComponentsTableAdapter();
            this.tableAdapterManager = new DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.projectsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.ProjectsTableAdapter();
            this.projectComponentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentIdTextBox = new System.Windows.Forms.TextBox();
            this.componentNameTextBox = new System.Windows.Forms.TextBox();
            this.projectIdComboBox = new System.Windows.Forms.ComboBox();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            componentIdLabel = new System.Windows.Forms.Label();
            componentNameLabel = new System.Windows.Forms.Label();
            projectIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectComponentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectComponentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // componentIdLabel
            // 
            componentIdLabel.AutoSize = true;
            componentIdLabel.Location = new System.Drawing.Point(674, 25);
            componentIdLabel.Name = "componentIdLabel";
            componentIdLabel.Size = new System.Drawing.Size(76, 13);
            componentIdLabel.TabIndex = 1;
            componentIdLabel.Text = "Component Id:";
            // 
            // componentNameLabel
            // 
            componentNameLabel.AutoSize = true;
            componentNameLabel.Location = new System.Drawing.Point(674, 51);
            componentNameLabel.Name = "componentNameLabel";
            componentNameLabel.Size = new System.Drawing.Size(95, 13);
            componentNameLabel.TabIndex = 3;
            componentNameLabel.Text = "Component Name:";
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.Location = new System.Drawing.Point(674, 77);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new System.Drawing.Size(55, 13);
            projectIdLabel.TabIndex = 5;
            projectIdLabel.Text = "Project Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(674, 102);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 13);
            label1.TabIndex = 54;
            label1.Text = "Project Name :";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectComponentsBindingSource
            // 
            this.projectComponentsBindingSource.DataMember = "ProjectComponents";
            this.projectComponentsBindingSource.DataSource = this.databaseDataSet;
            // 
            // projectComponentsTableAdapter
            // 
            this.projectComponentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BugsTableAdapter = null;
            this.tableAdapterManager.BugsToTestsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProjectComponentsTableAdapter = this.projectComponentsTableAdapter;
            this.tableAdapterManager.ProjectsTableAdapter = this.projectsTableAdapter;
            this.tableAdapterManager.ProjectTypesTableAdapter = null;
            this.tableAdapterManager.SurveysTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.WorkersToTeamsTableAdapter = null;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // projectComponentsDataGridView
            // 
            this.projectComponentsDataGridView.AutoGenerateColumns = false;
            this.projectComponentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectComponentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.projectComponentsDataGridView.DataSource = this.projectComponentsBindingSource;
            this.projectComponentsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.projectComponentsDataGridView.Name = "projectComponentsDataGridView";
            this.projectComponentsDataGridView.Size = new System.Drawing.Size(630, 288);
            this.projectComponentsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ComponentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ComponentId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ComponentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ComponentName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProjectId";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProjectId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // componentIdTextBox
            // 
            this.componentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectComponentsBindingSource, "ComponentId", true));
            this.componentIdTextBox.Enabled = false;
            this.componentIdTextBox.Location = new System.Drawing.Point(775, 22);
            this.componentIdTextBox.Name = "componentIdTextBox";
            this.componentIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.componentIdTextBox.TabIndex = 2;
            // 
            // componentNameTextBox
            // 
            this.componentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectComponentsBindingSource, "ComponentName", true));
            this.componentNameTextBox.Location = new System.Drawing.Point(775, 48);
            this.componentNameTextBox.Name = "componentNameTextBox";
            this.componentNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.componentNameTextBox.TabIndex = 4;
            // 
            // projectIdComboBox
            // 
            this.projectIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectComponentsBindingSource, "ProjectId", true));
            this.projectIdComboBox.DataSource = this.projectsBindingSource;
            this.projectIdComboBox.DisplayMember = "ProjectId";
            this.projectIdComboBox.FormattingEnabled = true;
            this.projectIdComboBox.Location = new System.Drawing.Point(775, 74);
            this.projectIdComboBox.Name = "projectIdComboBox";
            this.projectIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.projectIdComboBox.TabIndex = 6;
            this.projectIdComboBox.ValueMember = "ProjectId";
            this.projectIdComboBox.SelectedIndexChanged += new System.EventHandler(this.projectIdComboBox_SelectedIndexChanged);
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.databaseDataSet;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(785, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 48;
            this.button5.Text = "למטה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(687, 269);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 47;
            this.button6.Text = "אחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(785, 240);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 46;
            this.button7.Text = "למעלה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(687, 240);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 23);
            this.button8.TabIndex = 45;
            this.button8.Text = "ראשון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(785, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "שמירה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(687, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "עדכון ממסד";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(785, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "הסר";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "הוסף חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 349);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 60);
            this.button9.TabIndex = 49;
            this.button9.Text = "חיפוש לפי שם פרויקט";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 50;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 52;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(118, 349);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 60);
            this.button10.TabIndex = 51;
            this.button10.Text = "חיפוש לפי קוד פרויקט";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(224, 323);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 86);
            this.button11.TabIndex = 53;
            this.button11.Text = "נקה חיפוש";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectComponentsBindingSource, "ComponentId", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(775, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 55;
            // 
            // P2Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 421);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(componentIdLabel);
            this.Controls.Add(this.componentIdTextBox);
            this.Controls.Add(componentNameLabel);
            this.Controls.Add(this.componentNameTextBox);
            this.Controls.Add(projectIdLabel);
            this.Controls.Add(this.projectIdComboBox);
            this.Controls.Add(this.projectComponentsDataGridView);
            this.Name = "P2Components";
            this.Text = "P2Components";
            this.Load += new System.EventHandler(this.P2Components_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectComponentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectComponentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource projectComponentsBindingSource;
        private DatabaseDataSetTableAdapters.ProjectComponentsTableAdapter projectComponentsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.DataGridView projectComponentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox componentIdTextBox;
        private System.Windows.Forms.TextBox componentNameTextBox;
        private System.Windows.Forms.ComboBox projectIdComboBox;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox3;
    }
}