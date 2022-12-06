namespace PROYECTO_FINAL_NUEVO
{
    partial class frmComprar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProd = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbSubT = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxVendedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SubTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // tbProd
            // 
            this.tbProd.Location = new System.Drawing.Point(154, 81);
            this.tbProd.Name = "tbProd";
            this.tbProd.ReadOnly = true;
            this.tbProd.Size = new System.Drawing.Size(211, 20);
            this.tbProd.TabIndex = 6;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(154, 120);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 7;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(154, 164);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 8;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            // 
            // tbSubT
            // 
            this.tbSubT.Location = new System.Drawing.Point(154, 210);
            this.tbSubT.Name = "tbSubT";
            this.tbSubT.ReadOnly = true;
            this.tbSubT.Size = new System.Drawing.Size(100, 20);
            this.tbSubT.TabIndex = 9;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(154, 255);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ReadOnly = true;
            this.tbDesc.Size = new System.Drawing.Size(100, 20);
            this.tbDesc.TabIndex = 10;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(154, 296);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Checkout";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(398, 88);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(35, 13);
            this.lbStock.TabIndex = 13;
            this.lbStock.Text = "label8";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(343, 361);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 33);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Enabled = false;
            this.btConfirm.Location = new System.Drawing.Point(92, 361);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(106, 33);
            this.btConfirm.TabIndex = 15;
            this.btConfirm.Text = "Confirmar Compra";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "vendedor";
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.FormattingEnabled = true;
            this.cbxVendedor.Location = new System.Drawing.Point(380, 164);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(121, 21);
            this.cbxVendedor.TabIndex = 17;
            this.cbxVendedor.Text = "Elegir un vendedor";
            // 
            // frmComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 435);
            this.Controls.Add(this.cbxVendedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbSubT);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmComprar";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.frmComprar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbSubT;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxVendedor;
    }
}