using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHubApp
{
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm(List<string> records, string title = "排行榜")
        {
            InitializeComponent();
            this.Text = title;

            lstRecords.Items.Clear();
            foreach (var record in records)
            {
                lstRecords.Items.Add(record);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
