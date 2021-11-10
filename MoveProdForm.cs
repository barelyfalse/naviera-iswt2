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
    public partial class MoveProdForm : Form
    {
        char[] charsToTrim = { ' ' };
        NavForm mainform;
        int bay = -1;
        int openBayTime = 0;
        bool enterProduct;

        public MoveProdForm(NavForm main, bool enter)
        {
            mainform = main;
            InitializeComponent();
            lockInputs();
            GetSelectableBays();
            this.ControlBox = false;
            enterProduct = enter;
        }

        private void IngresarProducto_Load(object sender, EventArgs e)
        {
            prodsDGrid.DataSource = SqliteDataAccess.LoadProducts();

            DataGridViewCheckBoxColumn selCol = new DataGridViewCheckBoxColumn();
            {
                selCol.HeaderText = "Seleccionar";
                selCol.Name = "selected";
                selCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                selCol.FlatStyle = FlatStyle.Standard;
                selCol.CellTemplate = new DataGridViewCheckBoxCell();
            }

            DataGridViewColumn costCol = new DataGridViewColumn();
            {
                costCol.HeaderText = "Costo/ día";
                costCol.Name = "cost";
                costCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                costCol.CellTemplate = new DataGridViewTextBoxCell();
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

            prodsDGrid.Columns.Insert(0, selCol);
            prodsDGrid.Columns.Insert(8, costCol);
            prodsDGrid.Columns.Insert(9, cmboxCol);

            /*  0 - seleccionar
                1 - id
                2 - Nombre
                3 - peso
                4 - valor de referencia
                5 - cantidad
                6 - fecha vencimiento
                7 - envio
                8 - costo/día
                9 - categoria
            */

            prodsDGrid.Columns[1].HeaderText = "ID";
            prodsDGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            prodsDGrid.Columns[5].HeaderText = "Peso (T)";
            prodsDGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            prodsDGrid.Columns[5].HeaderText = "Valor de referencia";
            prodsDGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            prodsDGrid.Columns[6].HeaderText = "Fecha de vencimiento";
            prodsDGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            prodsDGrid.Columns[7].HeaderText = "ID Envio";
            prodsDGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            prodsDGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            prodsDGrid.ReadOnly = false;
            for(int i = 1; i < prodsDGrid.Columns.Count - 1; i++)
            {
                prodsDGrid.Columns[i].ReadOnly = true;
            }

            foreach (DataGridViewRow row in prodsDGrid.Rows)
            {
                if(row.Cells[3].Value != null && row.Cells[4].Value != null)
                {
                    //cobro por dia = costo base * (tonelada * valor de referencia)
                    row.Cells[8].Value = (mainform.baseCost * (float.Parse(row.Cells[3].Value.ToString()) * float.Parse(row.Cells[4].Value.ToString()))).ToString();
                    row.Cells[8].ToolTipText = mainform.baseCost + " * (" + row.Cells[3].Value + " * " + row.Cells[4].Value + ")";
                }
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
            if(bay != -1)
            {
                mainform.CloseBay(bay);
            }            
            this.Close();
        }

        //TODO secure close bay at close form

        private void storeProdBtn_Click(object sender, EventArgs e)
        {
            string errors = "";
            bool er = false;

            numContTxtBx.Text = numContTxtBx.Text.Trim(charsToTrim);
            truckNumTxtBx.Text = truckNumTxtBx.Text.Trim(charsToTrim);
            condTxtBx.Text = condTxtBx.Text.Trim(charsToTrim);

            if (string.IsNullOrEmpty(numContTxtBx.Text) || !numContTxtBx.Text.All(char.IsDigit))
            {
                errors += "Número de contenedor inválido!";
                er = true;
            }

            if (string.IsNullOrEmpty(truckNumTxtBx.Text) || !truckNumTxtBx.Text.All(char.IsLetterOrDigit))
            {
                errors += "\nPlaca de camión inválida";
                er = true;
            }

            if (string.IsNullOrEmpty(condTxtBx.Text) || !condTxtBx.Text.All(char.IsLetter))
            {
                errors += "\nNombre de conductor inválido";
                er = true;
            }

            foreach (DataGridViewRow row in prodsDGrid.Rows)
            {
                if(row.Cells["selected"].Value != null && (bool)row.Cells["selected"].Value == true)
                {
                    if(row.Cells["category"].Value == null)
                    {
                        errors += "\nNo se seleccionó categoria para el producto con ID " + row.Cells["id_producto"].Value;
                        er = true;
                    }
                }
            }

            if (er)
            {
                MessageBox.Show(errors, "Error de entrada!", MessageBoxButtons.OK);
            } 
            else
            {
                Console.WriteLine("Sin errores uwu");

                List<int> prodids = new List<int>();
                foreach (DataGridViewRow row in prodsDGrid.Rows)
                {
                    if (row.Cells["selected"].Value != null && (bool)row.Cells["selected"].Value == true)
                    {
                        if(row.Cells["id_producto"].Value != null && int.TryParse(row.Cells["id_producto"].Value.ToString(), out int id))
                        {
                            prodids.Add(id);
                        }
                    }
                }

                if(prodids.Count > 0)
                {
                    SqliteDataAccess.EntryNote(numContTxtBx.Text, truckNumTxtBx.Text, condTxtBx.Text, openBayTimeLbl.Text, prodids.ToArray(), bay);
                }
            }
        }
    }
}
