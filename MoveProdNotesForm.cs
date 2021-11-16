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
    public partial class MoveProdNotesForm : Form
    {
        bool entry;
        public MoveProdNotesForm(bool entry)
        {
            InitializeComponent();
            this.entry = entry;
        }

        private void MoveProdNotesForm_Load(object sender, EventArgs e)
        {
            if(entry)
            {
                EntryRNotesTitleLbl.Text = "Notas de entrada";
                notesDtaGrdViw.DataSource = SqliteDataAccess.LoadEntryNotes();
                notesDtaGrdViw.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                notesDtaGrdViw.Columns["PlacaCamion"].HeaderText = "Camión";
                notesDtaGrdViw.Columns["Contenedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                notesDtaGrdViw.Columns["TiempoApertura"].HeaderText = "Tiempo de apertura";
            }
            else
            {
                EntryRNotesTitleLbl.Text = "Notas de salida";
                notesDtaGrdViw.DataSource = SqliteDataAccess.LoadRemoveNotes();
                notesDtaGrdViw.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                notesDtaGrdViw.Columns["PlacaCamion"].HeaderText = "Camión";
                notesDtaGrdViw.Columns["TiempoApertura"].HeaderText = "Tiempo de apertura";
                notesDtaGrdViw.Columns["Contenedor"].Visible = false;
            }
        }

        private void notesDtaGrdViw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (entry)
                {
                    NoteProdsForm prods = new NoteProdsForm(int.Parse(notesDtaGrdViw.Rows[e.RowIndex].Cells["ID"].Value.ToString()), true);
                    prods.ShowDialog();
                }
                else
                {
                    NoteProdsForm prods = new NoteProdsForm(int.Parse(notesDtaGrdViw.Rows[e.RowIndex].Cells["ID"].Value.ToString()), false);
                    prods.ShowDialog();
                }
            }
        }
    }
}
