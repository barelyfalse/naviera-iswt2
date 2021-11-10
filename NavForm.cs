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
    public partial class NavForm : Form
    {
        bool[] openBays = new bool[5];
        int[] openBayTimes = new int[5];
        public float baseCost { get; set; }

        public NavForm()
        {
            openBays = new bool[5];
            openBayTimes = new int[5];
            InitializeComponent();
            UpdateOnHoldProductsLbl();
            baseCost = 1;
        }

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            MoveProdForm ingProd = new MoveProdForm(this, true);
            ingProd.Show();
        }

        private void retirarBtn_Click(object sender, EventArgs e)
        {
            MoveProdForm ingProd = new MoveProdForm(this, false);
            ingProd.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            NavieraISWT2.Program.StopHttpServer();
        }

        public void OpenBay(int bay)
        {
            openBays[bay] = true;
            UpdateBayPanels();

            switch (bay)
            {
                case 0:
                    this.timer1.Enabled = true;
                    break;
                case 1:
                    this.timer2.Enabled = true;
                    break;
                case 2:
                    this.timer3.Enabled = true;
                    break;
                case 3:
                    this.timer4.Enabled = true;
                    break;
                case 4:
                    this.timer5.Enabled = true;
                    break;
                default:
                    Console.WriteLine("wrong bay number");
                    break;
            }
        }

        public void CloseBay(int bay)
        {
            openBays[bay] = false;
            UpdateBayPanels();

            switch (bay)
            {
                case 0:
                    this.timer1.Enabled = false;
                    openBayTimes[bay] = 0;
                    bahia1TimeLbl.Text = "";
                    break;
                case 1:
                    this.timer2.Enabled = false;
                    openBayTimes[bay] = 0;
                    bahia2TimeLbl.Text = "";
                    break;
                case 2:
                    this.timer3.Enabled = false;
                    openBayTimes[bay] = 0;
                    bahia3TimeLbl.Text = "";
                    break;
                case 3:
                    this.timer4.Enabled = false;
                    openBayTimes[bay] = 0;
                    bahia4TimeLbl.Text = "";
                    break;
                case 4:
                    this.timer5.Enabled = false;
                    openBayTimes[bay] = 0;
                    bahia5TimeLbl.Text = "";
                    break;
                default:
                    Console.WriteLine("wrong bay number");
                    break;
            }
        }

        public void UpdateOnHoldProductsLbl()
        {
            int wait = SqliteDataAccess.GetProductosOnHold();
            waitingProductsLbl.Text = "Productos en espera: " + wait;
        }

        public void FocusForm(MoveProdForm pro)
        {
            this.BringToFront();
            this.Focus();
        }

        private void UpdateBayPanels()
        {
            Color openColor = Color.FromArgb(255, 128, 128);
            Color closedColor = Color.FromArgb(192, 255, 192);
            bahia1Pnl.BackColor = openBays[0] ? openColor : closedColor;
            bahia2Pnl.BackColor = openBays[1] ? openColor : closedColor;
            bahia3Pnl.BackColor = openBays[2] ? openColor : closedColor;
            bahia4Pnl.BackColor = openBays[3] ? openColor : closedColor;
            bahia5Pnl.BackColor = openBays[4] ? openColor : closedColor;
        }

        public bool[] GetOpenBays()
        {
            return openBays;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            openBayTimes[0] += 10;
            TimeSpan span = TimeSpan.FromMilliseconds(openBayTimes[0]);
            this.bahia1TimeLbl.Text = span.ToString().Length > 11 ? span.ToString().Remove(11) : span.ToString() + ".00";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            openBayTimes[1] += 10;
            TimeSpan span = TimeSpan.FromMilliseconds(openBayTimes[1]);
            this.bahia2TimeLbl.Text = span.ToString().Length > 11 ? span.ToString().Remove(11) : span.ToString() + ".00";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            openBayTimes[2] += 10;
            TimeSpan span = TimeSpan.FromMilliseconds(openBayTimes[2]);
            this.bahia3TimeLbl.Text = span.ToString().Length > 11 ? span.ToString().Remove(11) : span.ToString() + ".00";
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            openBayTimes[3] += 10;
            TimeSpan span = TimeSpan.FromMilliseconds(openBayTimes[3]);
            this.bahia4TimeLbl.Text = span.ToString().Length > 11 ? span.ToString().Remove(11) : span.ToString() + ".00";
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            openBayTimes[4]+= 10;
            TimeSpan span = TimeSpan.FromMilliseconds(openBayTimes[4]);
            this.bahia5TimeLbl.Text = span.ToString().Length > 11 ? span.ToString().Remove(11) : span.ToString() + ".00";
        }

    }
}
