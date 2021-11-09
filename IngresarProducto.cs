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
    public partial class IngresarProducto : Form
    {
        NavForm mainform;
        int bay;
        int openBayTime = 0;

        public IngresarProducto(NavForm main)
        {
            mainform = main;
            InitializeComponent();
            lockInputs();
            GetSelectableBays();
        }

        private void IngresarProducto_Load(object sender, EventArgs e)
        {
            prodsDGrid.DataSource = SqliteDataAccess.LoadProducts();

            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            {
                column.HeaderText = "Seleccionar";
                column.Name = "selected";
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                column.FlatStyle = FlatStyle.Standard;
                column.CellTemplate = new DataGridViewCheckBoxCell();
            }

            DataGridViewComboBoxColumn cmboxCol = new DataGridViewComboBoxColumn();
            {
                cmboxCol.HeaderText = "Categoria";
                cmboxCol.Name = "category";
                cmboxCol.CellTemplate = new DataGridViewComboBoxCell();
                cmboxCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                cmboxCol.FlatStyle = FlatStyle.Flat;
                cmboxCol.Items.AddRange("Alimentos", "Electronicos", "Sin clasificar");
            }

            prodsDGrid.Columns.Insert(0, column);
            prodsDGrid.Columns.Insert(6, cmboxCol);

            /*  0 - seleccionar
                1 - id
                2 - Nombre
                3 - cantidad
                4 - fecha vencimiento
                5 - envio
                6 - categoria
            */

            prodsDGrid.Columns[1].HeaderText = "ID";
            prodsDGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            prodsDGrid.Columns[5].HeaderText = "ID Envio";
            prodsDGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            prodsDGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            prodsDGrid.ReadOnly = false;
            for(int i = 1; i < prodsDGrid.Columns.Count - 1; i++)
            {
                prodsDGrid.Columns[i].ReadOnly = true;
            }
        }

        private void lockInputs(bool locked = true)
        {
            numContTxtBx.Enabled = !locked;
            truckNumTxtBx.Enabled = !locked;
            condTxtBx.Enabled = !locked;
            prodsDGrid.Enabled = !locked;
            storeProdBtn.Enabled = !locked;
        }

        private void SelectedBay()
        {
            baySelectGrp.Visible = false;
            lockInputs(false);
            bayEntryLbl.Text = "Nota de ingreso a bahía " + (bay + 1);
            //timer logic
            timer1.Enabled = true;
        }

        private void GetSelectableBays()
        {
            bool[] bays = mainform.GetOpenBays();

            bahia1.Enabled = !bays[0];
            bahia2.Enabled = !bays[1];
            bahia3.Enabled = !bays[2];
            bahia4.Enabled = !bays[3];
            bahia5.Enabled = !bays[4];
        }

        private void bahia1_Click(object sender, EventArgs e)
        {
            mainform.OpenBay(0);
            bay = 0;
            SelectedBay();
        }

        private void bahia2_Click(object sender, EventArgs e)
        {
            mainform.OpenBay(1);
            bay = 1;
            SelectedBay();
        }

        private void bahia3_Click(object sender, EventArgs e)
        {
            mainform.OpenBay(2);
            bay = 2;
            SelectedBay();
        }

        private void bahia4_Click(object sender, EventArgs e)
        {
            mainform.OpenBay(3);
            bay = 3; 
            SelectedBay();
        }

        private void bahia5_Click(object sender, EventArgs e)
        {
            mainform.OpenBay(4);
            bay = 4;
            SelectedBay();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            openBayTime += 10;
            TimeSpan time = TimeSpan.FromMilliseconds(openBayTime);
            openBayTimeLbl.Text = time.ToString().Length > 11 ? time.ToString().Remove(11) : time.ToString() + ".00";

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
