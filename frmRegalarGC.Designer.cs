namespace PROYECTO_FINAL_NUEVO
{
    partial class frmRegalarGC
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDest = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpExp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btComprar = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destinatario";
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(177, 164);
            this.tbMonto.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(188, 20);
            this.tbMonto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto";
            // 
            // cbxDest
            // 
            this.cbxDest.FormattingEnabled = true;
            this.cbxDest.Location = new System.Drawing.Point(177, 113);
            this.cbxDest.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbxDest.Name = "cbxDest";
            this.cbxDest.Size = new System.Drawing.Size(188, 21);
            this.cbxDest.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expiración";
            // 
            // dtpExp
            // 
            this.dtpExp.Location = new System.Drawing.Point(177, 213);
            this.dtpExp.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(217, 20);
            this.dtpExp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Regala una Giftcard";
            // 
            // btComprar
            // 
            this.btComprar.Location = new System.Drawing.Point(95, 348);
            this.btComprar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(83, 35);
            this.btComprar.TabIndex = 7;
            this.btComprar.Text = "Comprar";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(242, 348);
            this.btCancel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(83, 35);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(366, 72);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(35, 13);
            this.lbNum.TabIndex = 9;
            this.lbNum.Text = "label5";
            // 
            // frmRegalarGC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 445);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btComprar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpExp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmRegalarGC";
            this.Text = "Regalar GiftCard";
            this.Load += new System.EventHandler(this.frmRegalarGC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbNum;
    }
}