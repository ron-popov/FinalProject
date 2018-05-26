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
    public partial class P2TeamsGraph : Form
    {
        public P2TeamsGraph()
        {
            InitializeComponent();
        }

        private void workersToTeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersToTeamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P2TeamsGraph_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.WorkersToTeams' table. You can move, or remove it, as needed.
            this.workersToTeamsTableAdapter.Fill(this.databaseDataSet.WorkersToTeams);

            Dictionary<int, int> dict = new Dictionary<int, int>();
           
            foreach(DataRow row in databaseDataSet.WorkersToTeams.Rows)
            {
                int teamId = (int)row["TeamId"];
                if(dict.Keys.Contains<int>(teamId))
                {
                    dict[teamId] += 1;
                }
                else
                {
                    dict[teamId] = 1;
                }
            }

            Dictionary<int, int> workerCountToTeams = new Dictionary<int, int>();

            foreach(int i in dict.Values)
            {
                int workerCount = i;
                if(workerCountToTeams.Keys.Contains<int>(workerCount))
                {
                    workerCountToTeams[workerCount] += 1;
                }
                else
                {
                    workerCountToTeams[workerCount] = 1;
                }
            }

            foreach(int workerCount in workerCountToTeams.Keys)
            {
                chart1.Series["Series1"].Points.AddXY(workerCount, workerCountToTeams[workerCount]);
            }

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "מספר עובדים בצוות";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "מספר צוותים";

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
