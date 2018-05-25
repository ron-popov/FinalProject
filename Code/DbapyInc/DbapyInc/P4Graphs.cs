using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbapyInc
{
    public partial class P4Graphs : Form
    {
        public P4Graphs()
        {
            InitializeComponent();
        }

        private void P4Graphs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Surveys' table. You can move, or remove it, as needed.
            this.surveysTableAdapter.Fill(this.databaseDataSet.Surveys);

            int[,] scores = new int[4, 5];

            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    scores[i, j] = 0;
                }
            }

            foreach(DataRow row in databaseDataSet.Surveys.Rows)
            {
                int q1 = int.Parse(row["Q1"].ToString());
                int q2 = int.Parse(row["Q2"].ToString());
                int q3 = int.Parse(row["Q3"].ToString());
                int q4 = int.Parse(row["Q4"].ToString());

                scores[0, q1 - 1]++;
                scores[1, q2 - 1]++;
                scores[2, q3 - 1]++;
                scores[3, q4 - 1]++;
            }

            chart1.Series["Series1"].Points.AddXY(1, scores[0, 0]);
            chart1.Series["Series1"].Points.AddXY(2, scores[0, 1]);
            chart1.Series["Series1"].Points.AddXY(3, scores[0, 2]);
            chart1.Series["Series1"].Points.AddXY(4, scores[0, 3]);
            chart1.Series["Series1"].Points.AddXY(5, scores[0, 4]);

            chart2.Series["Series1"].Points.AddXY(1, scores[1, 0]);
            chart2.Series["Series1"].Points.AddXY(2, scores[1, 1]);
            chart2.Series["Series1"].Points.AddXY(3, scores[1, 2]);
            chart2.Series["Series1"].Points.AddXY(4, scores[1, 3]);
            chart2.Series["Series1"].Points.AddXY(5, scores[1, 4]);

            chart4.Series["Series1"].Points.AddXY(1, scores[2, 0]);
            chart4.Series["Series1"].Points.AddXY(2, scores[2, 1]);
            chart4.Series["Series1"].Points.AddXY(3, scores[2, 2]);
            chart4.Series["Series1"].Points.AddXY(4, scores[2, 3]);
            chart4.Series["Series1"].Points.AddXY(5, scores[2, 4]);

            chart5.Series["Series1"].Points.AddXY(1, scores[3, 0]);
            chart5.Series["Series1"].Points.AddXY(2, scores[3, 1]);
            chart5.Series["Series1"].Points.AddXY(3, scores[3, 2]);
            chart5.Series["Series1"].Points.AddXY(4, scores[3, 3]);
            chart5.Series["Series1"].Points.AddXY(5, scores[3, 4]);

        }

        private void surveysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.surveysBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
