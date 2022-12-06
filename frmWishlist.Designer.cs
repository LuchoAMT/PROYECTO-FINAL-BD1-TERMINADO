namespace PROYECTO_FINAL_NUEVO
{
    partial class frmWishlist
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
            this.dgWishL = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNotif = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.btAddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgWishL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgWishL
            // 
            this.dgWishL.AllowUserToAddRows = false;
            this.dgWishL.AllowUserToDeleteRows = false;
            this.dgWishL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWishL.Location = new System.Drawing.Point(63, 67);
            this.dgWishL.MultiSelect = false;
            this.dgWishL.Name = "dgWishL";
            this.dgWishL.ReadOnly = true;
            this.dgWishL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWishL.Size = new System.Drawing.Size(655, 269);
            this.dgWishL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tu Lista de Deseos";
            // 
            // lbNotif
            // 
            this.lbNotif.AutoSize = true;
            this.lbNotif.Location = new System.Drawing.Point(438, 50);
            this.lbNotif.Name = "lbNotif";
            this.lbNotif.Size = new System.Drawing.Size(35, 13);
            this.lbNotif.TabIndex = 2;
            this.lbNotif.Text = "label2";
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(63, 377);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(151, 28);
            this.btEliminar.TabIndex = 3;
            this.btEliminar.Text = "Eliminar de la lista";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(567, 377);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(151, 28);
            this.btVolver.TabIndex = 4;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btAddToCart
            // 
            this.btAddToCart.Location = new System.Drawing.Point(322, 377);
            this.btAddToCart.Name = "btAddToCart";
            this.btAddToCart.Size = new System.Drawing.Size(151, 28);
            this.btAddToCart.TabIndex = 5;
            this.btAddToCart.Text = "Agregar al carrito";
            this.btAddToCart.UseVisualStyleBackColor = true;
            this.btAddToCart.Click += new System.EventHandler(this.btAddToCart_Click);
            // 
            // frmWishlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAddToCart);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.lbNotif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgWishL);
            this.Name = "frmWishlist";
            this.Text = "Lista de Deseos";
            this.Load += new System.EventHandler(this.frmWishlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWishL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgWishL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNotif;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btAddToCart;
    }
}