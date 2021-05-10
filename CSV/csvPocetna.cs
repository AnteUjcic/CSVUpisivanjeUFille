using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSV
{
    public partial class csvPocetna : Form
    {
        public csvPocetna()
        {
            InitializeComponent();
        }

        private void btnPocetnaUnos_Click(object sender, EventArgs e)
        {
            csvUnos frmUnos = new csvUnos();
            frmUnos.Show();
        }

        private void btnPocetnaPregled_Click(object sender, EventArgs e)
        {
            csvOverview frmPregled = new csvOverview();
            frmPregled.Show();
            this.Hide();
        }
    }
}
