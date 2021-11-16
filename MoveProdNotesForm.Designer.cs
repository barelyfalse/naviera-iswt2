namespace NavieraISWT2
{
    partial class MoveProdNotesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EntryRNotesTitleLbl = new System.Windows.Forms.Label();
            this.notesDtaGrdViw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.notesDtaGrdViw)).BeginInit();
            this.SuspendLayout();
            // 
            // EntryRNotesTitleLbl
            // 
            this.EntryRNotesTitleLbl.AutoSize = true;
            this.EntryRNotesTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryRNotesTitleLbl.Location = new System.Drawing.Point(12, 9);
            this.EntryRNotesTitleLbl.Name = "EntryRNotesTitleLbl";
            this.EntryRNotesTitleLbl.Size = new System.Drawing.Size(241, 25);
            this.EntryRNotesTitleLbl.TabIndex = 0;
            this.EntryRNotesTitleLbl.Text = "Notas de entrada/salida";
            // 
            // notesDtaGrdViw
            // 
            this.notesDtaGrdViw.AllowUserToAddRows = false;
            this.notesDtaGrdViw.AllowUserToDeleteRows = false;
            this.notesDtaGrdViw.AllowUserToResizeRows = false;
            this.notesDtaGrdViw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notesDtaGrdViw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesDtaGrdViw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.notesDtaGrdViw.Location = new System.Drawing.Point(12, 37);
            this.notesDtaGrdViw.MultiSelect = false;
            this.notesDtaGrdViw.Name = "notesDtaGrdViw";
            this.notesDtaGrdViw.ReadOnly = true;
            this.notesDtaGrdViw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.notesDtaGrdViw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notesDtaGrdViw.ShowEditingIcon = false;
            this.notesDtaGrdViw.Size = new System.Drawing.Size(583, 365);
            this.notesDtaGrdViw.TabIndex = 1;
            this.notesDtaGrdViw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notesDtaGrdViw_CellDoubleClick);
            // 
            // MoveProdNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 414);
            this.Controls.Add(this.notesDtaGrdViw);
            this.Controls.Add(this.EntryRNotesTitleLbl);
            this.Name = "MoveProdNotesForm";
            this.Text = "MoveProdNotesForm";
            this.Load += new System.EventHandler(this.MoveProdNotesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notesDtaGrdViw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EntryRNotesTitleLbl;
        private System.Windows.Forms.DataGridView notesDtaGrdViw;
    }
}