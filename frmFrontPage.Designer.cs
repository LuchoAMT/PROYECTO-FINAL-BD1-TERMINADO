namespace PROYECTO_FINAL_NUEVO
{
    partial class frmFrontPage
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
            this.mcbEnviarA = new System.Windows.Forms.ToolStripComboBox();
            this.cuentaYListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mWishlist = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosYDevolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mDevoluciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mCarrito = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasDeRegaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regalarUnaTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misTarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSaludo = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcbEnviarA,
            this.cuentaYListaToolStripMenuItem,
            this.pedidosYDevolucionesToolStripMenuItem,
            this.mCarrito,
            this.tarjetasDeRegaloToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mcbEnviarA
            // 
            this.mcbEnviarA.Name = "mcbEnviarA";
            this.mcbEnviarA.Size = new System.Drawing.Size(121, 23);
            this.mcbEnviarA.Text = "Enviar a ";
            // 
            // cuentaYListaToolStripMenuItem
            // 
            this.cuentaYListaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCuenta,
            this.mWishlist});
            this.cuentaYListaToolStripMenuItem.Name = "cuentaYListaToolStripMenuItem";
            this.cuentaYListaToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
            this.cuentaYListaToolStripMenuItem.Text = "Cuenta y Lista";
            // 
            // mCuenta
            // 
            this.mCuenta.Name = "mCuenta";
            this.mCuenta.Size = new System.Drawing.Size(154, 22);
            this.mCuenta.Text = "Cuenta";
            this.mCuenta.Click += new System.EventHandler(this.mCuenta_Click);
            // 
            // mWishlist
            // 
            this.mWishlist.Name = "mWishlist";
            this.mWishlist.Size = new System.Drawing.Size(154, 22);
            this.mWishlist.Text = "Lista de Deseos";
            this.mWishlist.Click += new System.EventHandler(this.mWishlist_Click);
            // 
            // pedidosYDevolucionesToolStripMenuItem
            // 
            this.pedidosYDevolucionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPedidos,
            this.mDevoluciones});
            this.pedidosYDevolucionesToolStripMenuItem.Name = "pedidosYDevolucionesToolStripMenuItem";
            this.pedidosYDevolucionesToolStripMenuItem.Size = new System.Drawing.Size(144, 23);
            this.pedidosYDevolucionesToolStripMenuItem.Text = "Pedidos y Devoluciones";
            // 
            // mPedidos
            // 
            this.mPedidos.Name = "mPedidos";
            this.mPedidos.Size = new System.Drawing.Size(145, 22);
            this.mPedidos.Text = "Pedidos";
            this.mPedidos.Click += new System.EventHandler(this.mPedidos_Click);
            // 
            // mDevoluciones
            // 
            this.mDevoluciones.Name = "mDevoluciones";
            this.mDevoluciones.Size = new System.Drawing.Size(145, 22);
            this.mDevoluciones.Text = "Devoluciones";
            this.mDevoluciones.Click += new System.EventHandler(this.mDevoluciones_Click);
            // 
            // mCarrito
            // 
            this.mCarrito.Name = "mCarrito";
            this.mCarrito.Size = new System.Drawing.Size(55, 23);
            this.mCarrito.Text = "Carrito";
            this.mCarrito.Click += new System.EventHandler(this.mCarrito_Click);
            // 
            // tarjetasDeRegaloToolStripMenuItem
            // 
            this.tarjetasDeRegaloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regalarUnaTarjetaToolStripMenuItem,
            this.misTarjetasToolStripMenuItem});
            this.tarjetasDeRegaloToolStripMenuItem.Name = "tarjetasDeRegaloToolStripMenuItem";
            this.tarjetasDeRegaloToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
            this.tarjetasDeRegaloToolStripMenuItem.Text = "Tarjetas de Regalo";
            // 
            // regalarUnaTarjetaToolStripMenuItem
            // 
            this.regalarUnaTarjetaToolStripMenuItem.Name = "regalarUnaTarjetaToolStripMenuItem";
            this.regalarUnaTarjetaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.regalarUnaTarjetaToolStripMenuItem.Text = "Regalar una tarjeta";
            this.regalarUnaTarjetaToolStripMenuItem.Click += new System.EventHandler(this.regalarUnaTarjetaToolStripMenuItem_Click);
            // 
            // misTarjetasToolStripMenuItem
            // 
            this.misTarjetasToolStripMenuItem.Name = "misTarjetasToolStripMenuItem";
            this.misTarjetasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.misTarjetasToolStripMenuItem.Text = "Mis tarjetas";
            this.misTarjetasToolStripMenuItem.Click += new System.EventHandler(this.misTarjetasToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // lbSaludo
            // 
            this.lbSaludo.AutoSize = true;
            this.lbSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaludo.Location = new System.Drawing.Point(682, 9);
            this.lbSaludo.Name = "lbSaludo";
            this.lbSaludo.Size = new System.Drawing.Size(56, 15);
            this.lbSaludo.TabIndex = 1;
            this.lbSaludo.Text = "lbSaludo";
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(27, 139);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.Size = new System.Drawing.Size(821, 255);
            this.dgProductos.TabIndex = 2;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(27, 81);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 3;
            this.cbxCategoria.Text = "Categoria";
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // frmFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 445);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.lbSaludo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFrontPage";
            this.Text = "Amazon";
            this.Load += new System.EventHandler(this.frmFrontPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox mcbEnviarA;
        private System.Windows.Forms.ToolStripMenuItem cuentaYListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCuenta;
        private System.Windows.Forms.ToolStripMenuItem mWishlist;
        private System.Windows.Forms.ToolStripMenuItem pedidosYDevolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mPedidos;
        private System.Windows.Forms.ToolStripMenuItem mDevoluciones;
        private System.Windows.Forms.ToolStripMenuItem mCarrito;
        private System.Windows.Forms.Label lbSaludo;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetasDeRegaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regalarUnaTarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misTarjetasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.ComboBox cbxCategoria;
    }
}