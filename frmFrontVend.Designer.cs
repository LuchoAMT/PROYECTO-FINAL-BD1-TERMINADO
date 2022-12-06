namespace PROYECTO_FINAL_NUEVO
{
    partial class frmFrontVend
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSal = new System.Windows.Forms.Label();
            this.dgVent = new System.Windows.Forms.DataGridView();
            this.lbShow = new System.Windows.Forms.Label();
            this.mostrarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDevolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.mostrarVentasToolStripMenuItem,
            this.mostrarDevolucionesToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.stockToolStripMenuItem.Text = "Ampliar stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // lbSal
            // 
            this.lbSal.AutoSize = true;
            this.lbSal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbSal.Location = new System.Drawing.Point(518, 9);
            this.lbSal.Name = "lbSal";
            this.lbSal.Size = new System.Drawing.Size(35, 13);
            this.lbSal.TabIndex = 1;
            this.lbSal.Text = "label1";
            // 
            // dgVent
            // 
            this.dgVent.AllowUserToAddRows = false;
            this.dgVent.AllowUserToDeleteRows = false;
            this.dgVent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVent.Location = new System.Drawing.Point(57, 126);
            this.dgVent.Name = "dgVent";
            this.dgVent.ReadOnly = true;
            this.dgVent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVent.Size = new System.Drawing.Size(792, 275);
            this.dgVent.TabIndex = 2;
            this.dgVent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbShow
            // 
            this.lbShow.AutoSize = true;
            this.lbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShow.Location = new System.Drawing.Point(54, 78);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(57, 20);
            this.lbShow.TabIndex = 3;
            this.lbShow.Text = "label1";
            // 
            // mostrarVentasToolStripMenuItem
            // 
            this.mostrarVentasToolStripMenuItem.Name = "mostrarVentasToolStripMenuItem";
            this.mostrarVentasToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.mostrarVentasToolStripMenuItem.Text = "Mostrar Ventas";
            this.mostrarVentasToolStripMenuItem.Click += new System.EventHandler(this.mostrarVentasToolStripMenuItem_Click);
            // 
            // mostrarDevolucionesToolStripMenuItem
            // 
            this.mostrarDevolucionesToolStripMenuItem.Name = "mostrarDevolucionesToolStripMenuItem";
            this.mostrarDevolucionesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.mostrarDevolucionesToolStripMenuItem.Text = "Mostrar Devoluciones";
            this.mostrarDevolucionesToolStripMenuItem.Click += new System.EventHandler(this.mostrarDevolucionesToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // frmFrontVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 447);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.dgVent);
            this.Controls.Add(this.lbSal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFrontVend";
            this.Text = "frmFrontVend";
            this.Load += new System.EventHandler(this.frmFrontVend_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.Label lbSal;
        private System.Windows.Forms.DataGridView dgVent;
        private System.Windows.Forms.ToolStripMenuItem mostrarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDevolucionesToolStripMenuItem;
        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}