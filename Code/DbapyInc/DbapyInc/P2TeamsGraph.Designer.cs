namespace DbapyInc
{
    partial class P2TeamsGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.databaseDataSet = new DbapyInc.DatabaseDataSet();
            this.workersToTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersToTeamsTableAdapter = new DbapyInc.DatabaseDataSetTableAdapters.WorkersToTeamsTableAdapter();
            this.tableAdapterManager = new DbapyInc.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersToTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.WorkersToTeamsTableAdapter = this.workersToTeamsTableAdapter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(451, 354);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // P2TeamsGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 378);
            this.Controls.Add(this.chart1);
            this.Name = "P2TeamsGraph";
            this.Text = "P2TeamsGraph";
            this.Load += new System.EventHandler(this.P2TeamsGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersToTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource workersToTeamsBindingSource;
        private DatabaseDataSetTableAdapters.WorkersToTeamsTableAdapter workersToTeamsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}