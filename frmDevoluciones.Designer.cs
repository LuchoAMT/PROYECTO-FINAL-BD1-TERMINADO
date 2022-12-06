namespace PROYECTO_FINAL_NUEVO
{
    partial class frmDevoluciones
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
            this.dgDevoluciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNotif = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDevoluciones
            // 
            this.dgDevoluciones.AllowUserToAddRows = false;
            this.dgDevoluciones.AllowUserToDeleteRows = false;
            this.dgDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDevoluciones.Location = new System.Drawing.Point(39, 78);
            this.dgDevoluciones.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgDevoluciones.Name = "dgDevoluciones";
            this.dgDevoluciones.ReadOnly = true;
            this.dgDevoluciones.RowHeadersWidth = 102;
            this.dgDevoluciones.RowTemplate.Height = 40;
            this.dgDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDevoluciones.Size = new System.Drawing.Size(743, 303);
            this.dgDevoluciones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tus Pedidos Devueltos";
            // 
            // lbNotif
            // 
            this.lbNotif.AutoSize = true;
            this.lbNotif.Location = new System.Drawing.Point(562, 49);
            this.lbNotif.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbNotif.Name = "lbNotif";
            this.lbNotif.Size = new System.Drawing.Size(35, 13);
            this.lbNotif.TabIndex = 2;
            this.lbNotif.Text = "label2";
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(375, 418);
            this.btVolver.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(88, 34);
            this.btVolver.TabIndex = 3;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 492);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.lbNotif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDevoluciones);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmDevoluciones";
            this.Text = "frmDevoluciones";
            this.Load += new System.EventHandler(this.frmDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDevoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDevoluciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNotif;
        private System.Windows.Forms.Button btVolver;
    }
}