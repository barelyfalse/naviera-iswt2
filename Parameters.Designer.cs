namespace NavieraISWT2
{
    partial class Parameters
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
            this.baseCostLbl = new System.Windows.Forms.Label();
            this.saveParamsBtn = new System.Windows.Forms.Button();
            this.baseNumUpDwn = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.baseNumUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // baseCostLbl
            // 
            this.baseCostLbl.AutoSize = true;
            this.baseCostLbl.Location = new System.Drawing.Point(12, 19);
            this.baseCostLbl.Name = "baseCostLbl";
            this.baseCostLbl.Size = new System.Drawing.Size(63, 13);
            this.baseCostLbl.TabIndex = 0;
            this.baseCostLbl.Text = "Costo base:";
            // 
            // saveParamsBtn
            // 
            this.saveParamsBtn.Location = new System.Drawing.Point(61, 57);
            this.saveParamsBtn.Name = "saveParamsBtn";
            this.saveParamsBtn.Size = new System.Drawing.Size(75, 23);
            this.saveParamsBtn.TabIndex = 2;
            this.saveParamsBtn.Text = "Guardar";
            this.saveParamsBtn.UseVisualStyleBackColor = true;
            this.saveParamsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // baseNumUpDwn
            // 
            this.baseNumUpDwn.DecimalPlaces = 2;
            this.baseNumUpDwn.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.baseNumUpDwn.Location = new System.Drawing.Point(81, 17);
            this.baseNumUpDwn.Name = "baseNumUpDwn";
            this.baseNumUpDwn.Size = new System.Drawing.Size(103, 20);
            this.baseNumUpDwn.TabIndex = 1;
            this.baseNumUpDwn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 92);
            this.Controls.Add(this.baseNumUpDwn);
            this.Controls.Add(this.saveParamsBtn);
            this.Controls.Add(this.baseCostLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Parameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parámetros";
            this.Load += new System.EventHandler(this.Parameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseNumUpDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baseCostLbl;
        private System.Windows.Forms.Button saveParamsBtn;
        private System.Windows.Forms.NumericUpDown baseNumUpDwn;
    }
}