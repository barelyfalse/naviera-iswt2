using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavieraISWT2
{
    public partial class Parameters : Form
    {
        NavForm mainform;
        public Parameters(NavForm main)
        {
            InitializeComponent();
            mainform = main;
            this.ControlBox = false;
        }

        private void Parameters_Load(object sender, EventArgs e)
        {
            baseNumUpDwn.Value = (decimal)mainform.baseCost;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(baseCostLbl.Text))
            {
                mainform.baseCost = (float)baseNumUpDwn.Value;
                this.Close();
            }
        }
    }
}
