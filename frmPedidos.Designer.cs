namespace PROYECTO_FINAL_NUEVO
{
    partial class frmPedidos
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
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.btDevolver = new System.Windows.Forms.Button();
            this.lbNotif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPedidos
            // 
            this.dgPedidos.AllowUserToAddRows = false;
            this.dgPedidos.AllowUserToDeleteRows = false;
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Location = new System.Drawing.Point(48, 85);
            this.dgPedidos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgPedidos.MultiSelect = false;
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.ReadOnly = true;
            this.dgPedidos.RowHeadersWidth = 102;
            this.dgPedidos.RowTemplate.Height = 40;
            this.dgPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPedidos.Size = new System.Drawing.Size(858, 285);
            this.dgPedidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tus Pedidos";
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(592, 387);
            this.btVolver.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(92, 30);
            this.btVolver.TabIndex = 2;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btDevolver
            // 
            this.btDevolver.Location = new System.Drawing.Point(389, 387);
            this.btDevolver.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btDevolver.Name = "btDevolver";
            this.btDevolver.Size = new System.Drawing.Size(92, 30);
            this.btDevolver.TabIndex = 3;
            this.btDevolver.Text = "Devolver";
            this.btDevolver.UseVisualStyleBackColor = true;
            this.btDevolver.Click += new System.EventHandler(this.btDevolver_Click);
            // 
            // lbNotif
            // 
            this.lbNotif.AutoSize = true;
            this.lbNotif.Location = new System.Drawing.Point(516, 58);
            this.lbNotif.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbNotif.Name = "lbNotif";
            this.lbNotif.Size = new System.Drawing.Size(35, 13);
            this.lbNotif.TabIndex = 4;
            this.lbNotif.Text = "label2";
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 491);
            this.Controls.Add(this.lbNotif);
            this.Controls.Add(this.btDevolver);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPedidos);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmPedidos";
            this.Text = "frmPedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btDevolver;
        private System.Windows.Forms.Label lbNotif;
    }
}