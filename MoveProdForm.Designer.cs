namespace NavieraISWT2
{
    partial class MoveProdForm
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
            this.components = new System.ComponentModel.Container();
            this.bayEntryLbl = new System.Windows.Forms.Label();
            this.truckDataGroup = new System.Windows.Forms.GroupBox();
            this.condTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.truckNumTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numContTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baySelectGrp = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bahia5 = new System.Windows.Forms.Button();
            this.bahia4 = new System.Windows.Forms.Button();
            this.bahia3 = new System.Windows.Forms.Button();
            this.bahia2 = new System.Windows.Forms.Button();
            this.bahia1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.storeProdBtn = new System.Windows.Forms.Button();
            this.prodsDGrid = new System.Windows.Forms.DataGridView();
            this.timerGrp = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openBayTimeLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.truckDataGroup.SuspendLayout();
            this.baySelectGrp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodsDGrid)).BeginInit();
            this.timerGrp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bayEntryLbl
            // 
            this.bayEntryLbl.AutoSize = true;
            this.bayEntryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayEntryLbl.Location = new System.Drawing.Point(13, 13);
            this.bayEntryLbl.Name = "bayEntryLbl";
            this.bayEntryLbl.Size = new System.Drawing.Size(241, 25);
            this.bayEntryLbl.TabIndex = 0;
            this.bayEntryLbl.Text = "Nota de ingreso a bahía";
            // 
            // truckDataGroup
            // 
            this.truckDataGroup.Controls.Add(this.condTxtBx);
            this.truckDataGroup.Controls.Add(this.label5);
            this.truckDataGroup.Controls.Add(this.truckNumTxtBx);
            this.truckDataGroup.Controls.Add(this.label3);
            this.truckDataGroup.Controls.Add(this.numContTxtBx);
            this.truckDataGroup.Controls.Add(this.label2);
            this.truckDataGroup.Location = new System.Drawing.Point(12, 57);
            this.truckDataGroup.Name = "truckDataGroup";
            this.truckDataGroup.Size = new System.Drawing.Size(332, 107);
            this.truckDataGroup.TabIndex = 1;
            this.truckDataGroup.TabStop = false;
            this.truckDataGroup.Text = "Datos del camión";
            // 
            // condTxtBx
            // 
            this.condTxtBx.Location = new System.Drawing.Point(138, 70);
            this.condTxtBx.Name = "condTxtBx";
            this.condTxtBx.Size = new System.Drawing.Size(179, 20);
            this.condTxtBx.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Conductor:";
            // 
            // truckNumTxtBx
            // 
            this.truckNumTxtBx.Location = new System.Drawing.Point(138, 43);
            this.truckNumTxtBx.Name = "truckNumTxtBx";
            this.truckNumTxtBx.Size = new System.Drawing.Size(179, 20);
            this.truckNumTxtBx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa del camión:";
            // 
            // numContTxtBx
            // 
            this.numContTxtBx.Location = new System.Drawing.Point(138, 17);
            this.numContTxtBx.Name = "numContTxtBx";
            this.numContTxtBx.Size = new System.Drawing.Size(179, 20);
            this.numContTxtBx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de contendedor:";
            // 
            // baySelectGrp
            // 
            this.baySelectGrp.Controls.Add(this.label4);
            this.baySelectGrp.Controls.Add(this.bahia5);
            this.baySelectGrp.Controls.Add(this.bahia4);
            this.baySelectGrp.Controls.Add(this.bahia3);
            this.baySelectGrp.Controls.Add(this.bahia2);
            this.baySelectGrp.Controls.Add(this.bahia1);
            this.baySelectGrp.Location = new System.Drawing.Point(350, 57);
            this.baySelectGrp.Name = "baySelectGrp";
            this.baySelectGrp.Size = new System.Drawing.Size(415, 107);
            this.baySelectGrp.TabIndex = 2;
            this.baySelectGrp.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seleccione la bahía:";
            // 
            // bahia5
            // 
            this.bahia5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bahia5.Location = new System.Drawing.Point(323, 46);
            this.bahia5.Name = "bahia5";
            this.bahia5.Size = new System.Drawing.Size(63, 43);
            this.bahia5.TabIndex = 10;
            this.bahia5.Text = "Bahía 5";
            this.bahia5.UseVisualStyleBackColor = false;
            this.bahia5.Click += new System.EventHandler(this.bahia5_Click);
            // 
            // bahia4
            // 
            this.bahia4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bahia4.Location = new System.Drawing.Point(250, 46);
            this.bahia4.Name = "bahia4";
            this.bahia4.Size = new System.Drawing.Size(67, 43);
            this.bahia4.TabIndex = 9;
            this.bahia4.Text = "Bahía 4";
            this.bahia4.UseVisualStyleBackColor = false;
            this.bahia4.Click += new System.EventHandler(this.bahia4_Click);
            // 
            // bahia3
            // 
            this.bahia3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bahia3.Location = new System.Drawing.Point(177, 46);
            this.bahia3.Name = "bahia3";
            this.bahia3.Size = new System.Drawing.Size(67, 43);
            this.bahia3.TabIndex = 8;
            this.bahia3.Text = "Bahía 3";
            this.bahia3.UseVisualStyleBackColor = false;
            this.bahia3.Click += new System.EventHandler(this.bahia3_Click);
            // 
            // bahia2
            // 
            this.bahia2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bahia2.Location = new System.Drawing.Point(95, 46);
            this.bahia2.Name = "bahia2";
            this.bahia2.Size = new System.Drawing.Size(76, 43);
            this.bahia2.TabIndex = 7;
            this.bahia2.Text = "Bahía 2";
            this.bahia2.UseVisualStyleBackColor = false;
            this.bahia2.Click += new System.EventHandler(this.bahia2_Click);
            // 
            // bahia1
            // 
            this.bahia1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bahia1.Location = new System.Drawing.Point(22, 46);
            this.bahia1.Name = "bahia1";
            this.bahia1.Size = new System.Drawing.Size(67, 43);
            this.bahia1.TabIndex = 6;
            this.bahia1.Text = "Bahía 1";
            this.bahia1.UseVisualStyleBackColor = false;
            this.bahia1.Click += new System.EventHandler(this.bahia1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.storeProdBtn);
            this.groupBox1.Controls.Add(this.prodsDGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 447);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos de entrada";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelBtn.Location = new System.Drawing.Point(6, 401);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(92, 39);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // storeProdBtn
            // 
            this.storeProdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.storeProdBtn.Location = new System.Drawing.Point(104, 401);
            this.storeProdBtn.Name = "storeProdBtn";
            this.storeProdBtn.Size = new System.Drawing.Size(128, 39);
            this.storeProdBtn.TabIndex = 1;
            this.storeProdBtn.Text = "Ingresar producto";
            this.storeProdBtn.UseVisualStyleBackColor = false;
            this.storeProdBtn.Click += new System.EventHandler(this.storeProdBtn_Click);
            // 
            // prodsDGrid
            // 
            this.prodsDGrid.AllowUserToAddRows = false;
            this.prodsDGrid.AllowUserToDeleteRows = false;
            this.prodsDGrid.AllowUserToResizeRows = false;
            this.prodsDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodsDGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.prodsDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodsDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.prodsDGrid.Location = new System.Drawing.Point(6, 19);
            this.prodsDGrid.Name = "prodsDGrid";
            this.prodsDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodsDGrid.Size = new System.Drawing.Size(826, 376);
            this.prodsDGrid.TabIndex = 0;
            // 
            // timerGrp
            // 
            this.timerGrp.Controls.Add(this.panel1);
            this.timerGrp.Location = new System.Drawing.Point(350, 57);
            this.timerGrp.Name = "timerGrp";
            this.timerGrp.Size = new System.Drawing.Size(415, 107);
            this.timerGrp.TabIndex = 4;
            this.timerGrp.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.openBayTimeLbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 88);
            this.panel1.TabIndex = 0;
            // 
            // openBayTimeLbl
            // 
            this.openBayTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBayTimeLbl.Location = new System.Drawing.Point(0, 34);
            this.openBayTimeLbl.Name = "openBayTimeLbl";
            this.openBayTimeLbl.Size = new System.Drawing.Size(403, 36);
            this.openBayTimeLbl.TabIndex = 0;
            this.openBayTimeLbl.Text = "00:00";
            this.openBayTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(403, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bahía abierta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MoveProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 629);
            this.Controls.Add(this.baySelectGrp);
            this.Controls.Add(this.timerGrp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.truckDataGroup);
            this.Controls.Add(this.bayEntryLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MoveProdForm";
            this.Text = "IngresarProducto";
            this.Load += new System.EventHandler(this.MoveProd_Load);
            this.truckDataGroup.ResumeLayout(false);
            this.truckDataGroup.PerformLayout();
            this.baySelectGrp.ResumeLayout(false);
            this.baySelectGrp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodsDGrid)).EndInit();
            this.timerGrp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bayEntryLbl;
        private System.Windows.Forms.GroupBox truckDataGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox truckNumTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numContTxtBx;
        private System.Windows.Forms.GroupBox baySelectGrp;
        private System.Windows.Forms.Button bahia5;
        private System.Windows.Forms.Button bahia4;
        private System.Windows.Forms.Button bahia3;
        private System.Windows.Forms.Button bahia2;
        private System.Windows.Forms.Button bahia1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox condTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button storeProdBtn;
        private System.Windows.Forms.DataGridView prodsDGrid;
        private System.Windows.Forms.GroupBox timerGrp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label openBayTimeLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cancelBtn;
    }
}