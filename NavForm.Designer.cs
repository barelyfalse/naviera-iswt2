using System.Windows.Forms;

namespace NavieraISWT2
{
    partial class NavForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.waitingProductsLbl = new System.Windows.Forms.Label();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.retirarBtn = new System.Windows.Forms.Button();
            this.bahia1Pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bahia2Pnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bahia3Pnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bahia4Pnl = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bahia5Pnl = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.bahia1TimeLbl = new System.Windows.Forms.Label();
            this.bahia2TimeLbl = new System.Windows.Forms.Label();
            this.bahia3TimeLbl = new System.Windows.Forms.Label();
            this.bahia4TimeLbl = new System.Windows.Forms.Label();
            this.bahia5TimeLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.paramBtn = new System.Windows.Forms.Button();
            this.bahia1Pnl.SuspendLayout();
            this.bahia2Pnl.SuspendLayout();
            this.bahia3Pnl.SuspendLayout();
            this.bahia4Pnl.SuspendLayout();
            this.bahia5Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // waitingProductsLbl
            // 
            this.waitingProductsLbl.AutoSize = true;
            this.waitingProductsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingProductsLbl.Location = new System.Drawing.Point(12, 19);
            this.waitingProductsLbl.Name = "waitingProductsLbl";
            this.waitingProductsLbl.Size = new System.Drawing.Size(181, 17);
            this.waitingProductsLbl.TabIndex = 0;
            this.waitingProductsLbl.Text = "Productos en espera: {}";
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Location = new System.Drawing.Point(148, 60);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(109, 59);
            this.ingresarBtn.TabIndex = 1;
            this.ingresarBtn.Text = "Ingresar producto";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // retirarBtn
            // 
            this.retirarBtn.Location = new System.Drawing.Point(276, 60);
            this.retirarBtn.Name = "retirarBtn";
            this.retirarBtn.Size = new System.Drawing.Size(109, 59);
            this.retirarBtn.TabIndex = 2;
            this.retirarBtn.Text = "Retirar producto";
            this.retirarBtn.UseVisualStyleBackColor = true;
            this.retirarBtn.Click += new System.EventHandler(this.retirarBtn_Click);
            // 
            // bahia1Pnl
            // 
            this.bahia1Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bahia1Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bahia1Pnl.Controls.Add(this.label2);
            this.bahia1Pnl.Location = new System.Drawing.Point(16, 150);
            this.bahia1Pnl.Name = "bahia1Pnl";
            this.bahia1Pnl.Size = new System.Drawing.Size(98, 70);
            this.bahia1Pnl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bahía 1";
            // 
            // bahia2Pnl
            // 
            this.bahia2Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bahia2Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bahia2Pnl.Controls.Add(this.label3);
            this.bahia2Pnl.Location = new System.Drawing.Point(120, 150);
            this.bahia2Pnl.Name = "bahia2Pnl";
            this.bahia2Pnl.Size = new System.Drawing.Size(98, 70);
            this.bahia2Pnl.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bahía 2";
            // 
            // bahia3Pnl
            // 
            this.bahia3Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bahia3Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bahia3Pnl.Controls.Add(this.label4);
            this.bahia3Pnl.Location = new System.Drawing.Point(224, 150);
            this.bahia3Pnl.Name = "bahia3Pnl";
            this.bahia3Pnl.Size = new System.Drawing.Size(98, 70);
            this.bahia3Pnl.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bahía 3";
            // 
            // bahia4Pnl
            // 
            this.bahia4Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bahia4Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bahia4Pnl.Controls.Add(this.label5);
            this.bahia4Pnl.Location = new System.Drawing.Point(328, 150);
            this.bahia4Pnl.Name = "bahia4Pnl";
            this.bahia4Pnl.Size = new System.Drawing.Size(98, 70);
            this.bahia4Pnl.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bahía 4";
            // 
            // bahia5Pnl
            // 
            this.bahia5Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bahia5Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bahia5Pnl.Controls.Add(this.label6);
            this.bahia5Pnl.Location = new System.Drawing.Point(432, 150);
            this.bahia5Pnl.Name = "bahia5Pnl";
            this.bahia5Pnl.Size = new System.Drawing.Size(98, 70);
            this.bahia5Pnl.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bahía 5";
            // 
            // bahia1TimeLbl
            // 
            this.bahia1TimeLbl.Location = new System.Drawing.Point(16, 227);
            this.bahia1TimeLbl.Name = "bahia1TimeLbl";
            this.bahia1TimeLbl.Size = new System.Drawing.Size(98, 13);
            this.bahia1TimeLbl.TabIndex = 4;
            this.bahia1TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bahia2TimeLbl
            // 
            this.bahia2TimeLbl.Location = new System.Drawing.Point(120, 227);
            this.bahia2TimeLbl.Name = "bahia2TimeLbl";
            this.bahia2TimeLbl.Size = new System.Drawing.Size(98, 13);
            this.bahia2TimeLbl.TabIndex = 4;
            this.bahia2TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bahia3TimeLbl
            // 
            this.bahia3TimeLbl.Location = new System.Drawing.Point(224, 227);
            this.bahia3TimeLbl.Name = "bahia3TimeLbl";
            this.bahia3TimeLbl.Size = new System.Drawing.Size(98, 13);
            this.bahia3TimeLbl.TabIndex = 4;
            this.bahia3TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bahia4TimeLbl
            // 
            this.bahia4TimeLbl.Location = new System.Drawing.Point(328, 227);
            this.bahia4TimeLbl.Name = "bahia4TimeLbl";
            this.bahia4TimeLbl.Size = new System.Drawing.Size(98, 13);
            this.bahia4TimeLbl.TabIndex = 4;
            this.bahia4TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bahia5TimeLbl
            // 
            this.bahia5TimeLbl.Location = new System.Drawing.Point(432, 227);
            this.bahia5TimeLbl.Name = "bahia5TimeLbl";
            this.bahia5TimeLbl.Size = new System.Drawing.Size(98, 13);
            this.bahia5TimeLbl.TabIndex = 4;
            this.bahia5TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // paramBtn
            // 
            this.paramBtn.Location = new System.Drawing.Point(435, 60);
            this.paramBtn.Name = "paramBtn";
            this.paramBtn.Size = new System.Drawing.Size(75, 23);
            this.paramBtn.TabIndex = 5;
            this.paramBtn.Text = "Parámetros";
            this.paramBtn.UseVisualStyleBackColor = true;
            this.paramBtn.Click += new System.EventHandler(this.paramBtn_Click);
            // 
            // NavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.paramBtn);
            this.Controls.Add(this.bahia5TimeLbl);
            this.Controls.Add(this.bahia4TimeLbl);
            this.Controls.Add(this.bahia3TimeLbl);
            this.Controls.Add(this.bahia2TimeLbl);
            this.Controls.Add(this.bahia1TimeLbl);
            this.Controls.Add(this.retirarBtn);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.bahia5Pnl);
            this.Controls.Add(this.bahia4Pnl);
            this.Controls.Add(this.bahia3Pnl);
            this.Controls.Add(this.bahia2Pnl);
            this.Controls.Add(this.bahia1Pnl);
            this.Controls.Add(this.waitingProductsLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NavForm";
            this.Text = "Naviera ISWT2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.bahia1Pnl.ResumeLayout(false);
            this.bahia1Pnl.PerformLayout();
            this.bahia2Pnl.ResumeLayout(false);
            this.bahia2Pnl.PerformLayout();
            this.bahia3Pnl.ResumeLayout(false);
            this.bahia3Pnl.PerformLayout();
            this.bahia4Pnl.ResumeLayout(false);
            this.bahia4Pnl.PerformLayout();
            this.bahia5Pnl.ResumeLayout(false);
            this.bahia5Pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label waitingProductsLbl;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.Button retirarBtn;
        private System.Windows.Forms.Panel bahia1Pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bahia2Pnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel bahia3Pnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel bahia4Pnl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel bahia5Pnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bahia1TimeLbl;
        private System.Windows.Forms.Label bahia2TimeLbl;
        private System.Windows.Forms.Label bahia3TimeLbl;
        private System.Windows.Forms.Label bahia4TimeLbl;
        private System.Windows.Forms.Label bahia5TimeLbl;
        private Timer timer1;
        private Timer timer2;
        private Timer timer3;
        private Timer timer4;
        private Timer timer5;
        private Button paramBtn;
    }
}

