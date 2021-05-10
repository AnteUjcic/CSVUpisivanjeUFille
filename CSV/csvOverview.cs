using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSV
{
    public partial class csvOverview : Form
    {
        public csvOverview()
        {
            InitializeComponent();
        }

        private void btnOverviewUcitaj_Click(object sender, EventArgs e)
        {
            csvOverview frmOverviewPod = new csvOverview();
            this.Hide();
            frmOverviewPod.Show();


        }
    }
}
