namespace NavieraISWT2
{
    partial class NoteProdsForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prodsDtaGrdVw = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clientNameTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientDirTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientTel1TxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clientTel2TxtBx = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodsDtaGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(166, 25);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Nota de entrada";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 401);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clientTel2TxtBx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.clientTel1TxtBx);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.clientDirTxtBx);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.clientNameTxtBx);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(763, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del cliente";
            // 
            // prodsDtaGrdVw
            // 
            this.prodsDtaGrdVw.AllowUserToAddRows = false;
            this.prodsDtaGrdVw.AllowUserToDeleteRows = false;
            this.prodsDtaGrdVw.AllowUserToResizeRows = false;
            this.prodsDtaGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodsDtaGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodsDtaGrdVw.Location = new System.Drawing.Point(18, 56);
            this.prodsDtaGrdVw.Name = "prodsDtaGrdVw";
            this.prodsDtaGrdVw.ReadOnly = true;
            this.prodsDtaGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodsDtaGrdVw.ShowEditingIcon = false;
            this.prodsDtaGrdVw.Size = new System.Drawing.Size(733, 376);
            this.prodsDtaGrdVw.TabIndex = 0;
            this.prodsDtaGrdVw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodsDtaGrdVw_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // clientNameTxtBx
            // 
            this.clientNameTxtBx.Location = new System.Drawing.Point(70, 19);
            this.clientNameTxtBx.Name = "clientNameTxtBx";
            this.clientNameTxtBx.ReadOnly = true;
            this.clientNameTxtBx.Size = new System.Drawing.Size(174, 20);
            this.clientNameTxtBx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección";
            // 
            // clientDirTxtBx
            // 
            this.clientDirTxtBx.Location = new System.Drawing.Point(70, 45);
            this.clientDirTxtBx.Multiline = true;
            this.clientDirTxtBx.Name = "clientDirTxtBx";
            this.clientDirTxtBx.ReadOnly = true;
            this.clientDirTxtBx.Size = new System.Drawing.Size(174, 72);
            this.clientDirTxtBx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teléfono 1";
            // 
            // clientTel1TxtBx
            // 
            this.clientTel1TxtBx.Location = new System.Drawing.Point(70, 123);
            this.clientTel1TxtBx.Name = "clientTel1TxtBx";
            this.clientTel1TxtBx.ReadOnly = true;
            this.clientTel1TxtBx.Size = new System.Drawing.Size(174, 20);
            this.clientTel1TxtBx.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono 2";
            // 
            // clientTel2TxtBx
            // 
            this.clientTel2TxtBx.Location = new System.Drawing.Point(70, 149);
            this.clientTel2TxtBx.Name = "clientTel2TxtBx";
            this.clientTel2TxtBx.ReadOnly = true;
            this.clientTel2TxtBx.Size = new System.Drawing.Size(174, 20);
            this.clientTel2TxtBx.TabIndex = 7;
            // 
            // NoteProdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 444);
            this.Controls.Add(this.prodsDtaGrdVw);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleLbl);
            this.Name = "NoteProdsForm";
            this.Text = "NoteProdsForm";
            this.Load += new System.EventHandler(this.NoteProdsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodsDtaGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView prodsDtaGrdVw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox clientTel2TxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientTel1TxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientDirTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientNameTxtBx;
        private System.Windows.Forms.Label label1;
    }
}