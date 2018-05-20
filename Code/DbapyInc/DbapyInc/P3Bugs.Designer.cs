namespace DbapyInc
{
    partial class P3Bugs
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
            System.Windows.Forms.Label bugIdLabel;
            System.Windows.Forms.Label bugNameLabel;
            System.Windows.Forms.Label bugDescriptionLabel;
            this.databaseDataSet = new DbapyInc.DatabaseDataSet();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.BugsTableAdapter();
            this.tableAdapterManager = new DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.bugsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugIdTextBox = new System.Windows.Forms.TextBox();
            this.bugNameTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bugDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            bugIdLabel = new System.Windows.Forms.Label();
            bugNameLabel = new System.Windows.Forms.Label();
            bugDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugsBindingSource
            // 
            this.bugsBindingSource.DataMember = "Bugs";
            this.bugsBindingSource.DataSource = this.databaseDataSet;
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BugsTableAdapter = this.bugsTableAdapter;
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
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.WorkersToTeamsTableAdapter = null;
            // 
            // bugsDataGridView
            // 
            this.bugsDataGridView.AutoGenerateColumns = false;
            this.bugsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.bugsDataGridView.DataSource = this.bugsBindingSource;
            this.bugsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.bugsDataGridView.Name = "bugsDataGridView";
            this.bugsDataGridView.Size = new System.Drawing.Size(520, 326);
            this.bugsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BugId";
            this.dataGridViewTextBoxColumn1.HeaderText = "BugId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BugName";
            this.dataGridViewTextBoxColumn2.HeaderText = "BugName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BugDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "BugDescription";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bugIdLabel
            // 
            bugIdLabel.AutoSize = true;
            bugIdLabel.Location = new System.Drawing.Point(565, 26);
            bugIdLabel.Name = "bugIdLabel";
            bugIdLabel.Size = new System.Drawing.Size(41, 13);
            bugIdLabel.TabIndex = 1;
            bugIdLabel.Text = "Bug Id:";
            // 
            // bugIdTextBox
            // 
            this.bugIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugsBindingSource, "BugId", true));
            this.bugIdTextBox.Location = new System.Drawing.Point(656, 23);
            this.bugIdTextBox.Name = "bugIdTextBox";
            this.bugIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.bugIdTextBox.TabIndex = 2;
            // 
            // bugNameLabel
            // 
            bugNameLabel.AutoSize = true;
            bugNameLabel.Location = new System.Drawing.Point(565, 52);
            bugNameLabel.Name = "bugNameLabel";
            bugNameLabel.Size = new System.Drawing.Size(60, 13);
            bugNameLabel.TabIndex = 3;
            bugNameLabel.Text = "Bug Name:";
            // 
            // bugNameTextBox
            // 
            this.bugNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugsBindingSource, "BugName", true));
            this.bugNameTextBox.Location = new System.Drawing.Point(656, 49);
            this.bugNameTextBox.Name = "bugNameTextBox";
            this.bugNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.bugNameTextBox.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(656, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 48;
            this.button5.Text = "למטה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(558, 315);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 47;
            this.button6.Text = "אחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(656, 286);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 46;
            this.button7.Text = "למעלה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(558, 286);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 23);
            this.button8.TabIndex = 45;
            this.button8.Text = "ראשון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(656, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "שמירה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "עדכון ממסד";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "הסר";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "הוסף חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bugDescriptionLabel
            // 
            bugDescriptionLabel.AutoSize = true;
            bugDescriptionLabel.Location = new System.Drawing.Point(565, 85);
            bugDescriptionLabel.Name = "bugDescriptionLabel";
            bugDescriptionLabel.Size = new System.Drawing.Size(85, 13);
            bugDescriptionLabel.TabIndex = 48;
            bugDescriptionLabel.Text = "Bug Description:";
            // 
            // bugDescriptionRichTextBox
            // 
            this.bugDescriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bugsBindingSource, "BugDescription", true));
            this.bugDescriptionRichTextBox.Location = new System.Drawing.Point(656, 82);
            this.bugDescriptionRichTextBox.Name = "bugDescriptionRichTextBox";
            this.bugDescriptionRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.bugDescriptionRichTextBox.TabIndex = 49;
            this.bugDescriptionRichTextBox.Text = "";
            // 
            // P3Bugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 352);
            this.Controls.Add(bugDescriptionLabel);
            this.Controls.Add(this.bugDescriptionRichTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(bugIdLabel);
            this.Controls.Add(this.bugIdTextBox);
            this.Controls.Add(bugNameLabel);
            this.Controls.Add(this.bugNameTextBox);
            this.Controls.Add(this.bugsDataGridView);
            this.Name = "P3Bugs";
            this.Text = "P3Bugs";
            this.Load += new System.EventHandler(this.P3Bugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private DatabaseDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bugsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox bugIdTextBox;
        private System.Windows.Forms.TextBox bugNameTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox bugDescriptionRichTextBox;
    }
}