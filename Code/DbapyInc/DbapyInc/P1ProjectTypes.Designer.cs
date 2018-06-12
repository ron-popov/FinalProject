namespace DbapyInc
{
    partial class P1ProjectTypes
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
            System.Windows.Forms.Label typeIdLabel;
            System.Windows.Forms.Label typeNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1ProjectTypes));
            System.Windows.Forms.Label label1;
            this.databaseDataSet = new DbapyInc.DatabaseDataSet();
            this.projectTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTypesTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.ProjectTypesTableAdapter();
            this.tableAdapterManager = new DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.projectTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdTextBox = new System.Windows.Forms.TextBox();
            this.typeNameTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.ProjectsTableAdapter();
            typeIdLabel = new System.Windows.Forms.Label();
            typeNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTypesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // typeIdLabel
            // 
            typeIdLabel.AutoSize = true;
            typeIdLabel.Location = new System.Drawing.Point(552, 35);
            typeIdLabel.Name = "typeIdLabel";
            typeIdLabel.Size = new System.Drawing.Size(46, 13);
            typeIdLabel.TabIndex = 1;
            typeIdLabel.Text = "Type Id:";
            // 
            // typeNameLabel
            // 
            typeNameLabel.AutoSize = true;
            typeNameLabel.Location = new System.Drawing.Point(552, 61);
            typeNameLabel.Name = "typeNameLabel";
            typeNameLabel.Size = new System.Drawing.Size(65, 13);
            typeNameLabel.TabIndex = 3;
            typeNameLabel.Text = "Type Name:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectTypesBindingSource
            // 
            this.projectTypesBindingSource.DataMember = "ProjectTypes";
            this.projectTypesBindingSource.DataSource = this.databaseDataSet;
            // 
            // projectTypesTableAdapter
            // 
            this.projectTypesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProjectTypesTableAdapter = this.projectTypesTableAdapter;
            this.tableAdapterManager.SurveysTableAdapter = null;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.TestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.WorkersToTeamsTableAdapter = null;
            // 
            // projectTypesDataGridView
            // 
            this.projectTypesDataGridView.AutoGenerateColumns = false;
            this.projectTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.projectTypesDataGridView.DataSource = this.projectTypesBindingSource;
            this.projectTypesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.projectTypesDataGridView.Name = "projectTypesDataGridView";
            this.projectTypesDataGridView.Size = new System.Drawing.Size(510, 262);
            this.projectTypesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TypeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "TypeId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TypeName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // typeIdTextBox
            // 
            this.typeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectTypesBindingSource, "TypeId", true));
            this.typeIdTextBox.Enabled = false;
            this.typeIdTextBox.Location = new System.Drawing.Point(623, 32);
            this.typeIdTextBox.Name = "typeIdTextBox";
            this.typeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeIdTextBox.TabIndex = 2;
            this.typeIdTextBox.TextChanged += new System.EventHandler(this.typeIdTextBox_TextChanged);
            // 
            // typeNameTextBox
            // 
            this.typeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectTypesBindingSource, "TypeName", true));
            this.typeNameTextBox.Location = new System.Drawing.Point(623, 58);
            this.typeNameTextBox.Name = "typeNameTextBox";
            this.typeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeNameTextBox.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(641, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "למטה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(543, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "אחרון";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(641, 221);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 30;
            this.button7.Text = "למעלה";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(543, 221);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "ראשון";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(641, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "שמירה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "עדכון ממסד";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "הסר";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "הוסף חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 280);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 39);
            this.button13.TabIndex = 66;
            this.button13.Text = "הדפס דוח סוגי פרויקטים";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(108, 279);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 40);
            this.button14.TabIndex = 65;
            this.button14.Text = "הצג דוח סוגי פרויקטים";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(623, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(541, 87);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 13);
            label1.TabIndex = 68;
            label1.Text = "Projects Count";
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
            // P1ProjectTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 346);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(typeIdLabel);
            this.Controls.Add(this.typeIdTextBox);
            this.Controls.Add(typeNameLabel);
            this.Controls.Add(this.typeNameTextBox);
            this.Controls.Add(this.projectTypesDataGridView);
            this.Name = "P1ProjectTypes";
            this.Text = "P1ProjectTypes";
            this.Load += new System.EventHandler(this.P1ProjectTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTypesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource projectTypesBindingSource;
        private DatabaseDataSetTableAdapters.ProjectTypesTableAdapter projectTypesTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView projectTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox typeIdTextBox;
        private System.Windows.Forms.TextBox typeNameTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private DatabaseDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
    }
}