namespace PROYECTO_FINAL_NUEVO
{
    partial class frmCarrito
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
            this.dgCarrito = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNotif = new System.Windows.Forms.Label();
            this.btComprar = new System.Windows.Forms.Button();
            this.btQuitar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCarrito
            // 
            this.dgCarrito.AllowUserToAddRows = false;
            this.dgCarrito.AllowUserToDeleteRows = false;
            this.dgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarrito.Location = new System.Drawing.Point(49, 72);
            this.dgCarrito.MultiSelect = false;
            this.dgCarrito.Name = "dgCarrito";
            this.dgCarrito.ReadOnly = true;
            this.dgCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCarrito.Size = new System.Drawing.Size(689, 256);
            this.dgCarrito.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tu Carrito";
            // 
            // lbNotif
            // 
            this.lbNotif.AutoSize = true;
            this.lbNotif.Location = new System.Drawing.Point(446, 53);
            this.lbNotif.Name = "lbNotif";
            this.lbNotif.Size = new System.Drawing.Size(35, 13);
            this.lbNotif.TabIndex = 2;
            this.lbNotif.Text = "label2";
            // 
            // btComprar
            // 
            this.btComprar.Location = new System.Drawing.Point(146, 379);
            this.btComprar.Name = "btComprar";
            this.btComprar.Size = new System.Drawing.Size(102, 36);
            this.btComprar.TabIndex = 3;
            this.btComprar.Text = "Comprar";
            this.btComprar.UseVisualStyleBackColor = true;
            this.btComprar.Click += new System.EventHandler(this.btComprar_Click);
            // 
            // btQuitar
            // 
            this.btQuitar.Location = new System.Drawing.Point(344, 379);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(102, 36);
            this.btQuitar.TabIndex = 4;
            this.btQuitar.Text = "Quitar del Carrito";
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Click += new System.EventHandler(this.btQuitar_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(547, 379);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(102, 36);
            this.btVolver.TabIndex = 5;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // frmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btQuitar);
            this.Controls.Add(this.btComprar);
            this.Controls.Add(this.lbNotif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCarrito);
            this.Name = "frmCarrito";
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.frmCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNotif;
        private System.Windows.Forms.Button btComprar;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Button btVolver;
    }
}