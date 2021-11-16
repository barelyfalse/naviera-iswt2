using NavieraISWT2.models;
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
    public partial class NoteProdsForm : Form
    {
        int noteId;
        bool entry;

        public NoteProdsForm(int idNote, bool entry)
        {
            InitializeComponent();
            this.noteId = idNote;
            this.entry = entry;
        }

        private void NoteProdsForm_Load(object sender, EventArgs e)
        {
            if(entry)
            {
                titleLbl.Text = "Nota de entrada";

                prodsDtaGrdVw.DataSource = SqliteDataAccess.LoadEntryNoteProducts(noteId);

                prodsDtaGrdVw.Columns["id_producto"].Visible = false;
                prodsDtaGrdVw.Columns["ValorReferencia"].HeaderText = "Valor de referencia";
                prodsDtaGrdVw.Columns["FechaVencimiento"].HeaderText = "Fecha de vencimiento";
                prodsDtaGrdVw.Columns["id_envio"].HeaderText = "ID de envío";
            }
            else
            {
                titleLbl.Text = "Nota de entrada";

                prodsDtaGrdVw.DataSource = SqliteDataAccess.LoadRemoveNoteProducts(noteId);

                prodsDtaGrdVw.Columns["id_producto"].Visible = false;
                prodsDtaGrdVw.Columns["ValorReferencia"].HeaderText = "Valor de referencia";
                prodsDtaGrdVw.Columns["FechaVencimiento"].HeaderText = "Fecha de vencimiento";
                prodsDtaGrdVw.Columns["id_envio"].HeaderText = "ID de envío";
            }
        }

        private void prodsDtaGrdVw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellShipId = int.Parse(prodsDtaGrdVw.Rows[e.RowIndex].Cells["id_envio"].Value.ToString());
            Cliente cl = SqliteDataAccess.LoadNoteClient(cellShipId);
            clientNameTxtBx.Text = cl.Nombre;
            clientDirTxtBx.Text = cl.Direccion;
            clientTel1TxtBx.Text = cl.Telefono1;
            clientTel2TxtBx.Text = cl.Telefono2;
        }
    }
}
