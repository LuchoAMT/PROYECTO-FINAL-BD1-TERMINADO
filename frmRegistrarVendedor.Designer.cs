namespace PROYECTO_FINAL_NUEVO
{
    partial class frmRegistrarVendedor
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbCalif = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrate como Vendedor!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "I.D.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "País";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Calificación";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(175, 71);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 5;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(175, 118);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(196, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(175, 165);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(100, 20);
            this.tbPais.TabIndex = 7;
            // 
            // tbCalif
            // 
            this.tbCalif.Enabled = false;
            this.tbCalif.Location = new System.Drawing.Point(175, 208);
            this.tbCalif.Name = "tbCalif";
            this.tbCalif.Size = new System.Drawing.Size(100, 20);
            this.tbCalif.TabIndex = 8;
            this.tbCalif.Text = "0";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(175, 273);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 29);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmRegistrarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 358);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbCalif);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistrarVendedor";
            this.Text = "frmRegistrarVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbCalif;
        private System.Windows.Forms.Button btnRegistrar;
    }
}