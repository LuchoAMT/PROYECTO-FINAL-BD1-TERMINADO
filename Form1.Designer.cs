namespace PROYECTO_FINAL_NUEVO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCi = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNotif = new System.Windows.Forms.Label();
            this.btLoginVendedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "C.I.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // tbCi
            // 
            this.tbCi.Location = new System.Drawing.Point(213, 130);
            this.tbCi.Name = "tbCi";
            this.tbCi.Size = new System.Drawing.Size(100, 20);
            this.tbCi.TabIndex = 2;
            this.tbCi.TextChanged += new System.EventHandler(this.tbCi_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(213, 183);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.InitialImage")));
            this.pbLogo.Location = new System.Drawing.Point(103, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(241, 92);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(29, 255);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 39);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(187, 255);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(107, 39);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "¿No tienes una cuenta?";
            // 
            // lbNotif
            // 
            this.lbNotif.AutoSize = true;
            this.lbNotif.Location = new System.Drawing.Point(210, 320);
            this.lbNotif.Name = "lbNotif";
            this.lbNotif.Size = new System.Drawing.Size(0, 13);
            this.lbNotif.TabIndex = 8;
            // 
            // btLoginVendedor
            // 
            this.btLoginVendedor.Location = new System.Drawing.Point(343, 251);
            this.btLoginVendedor.Name = "btLoginVendedor";
            this.btLoginVendedor.Size = new System.Drawing.Size(108, 43);
            this.btLoginVendedor.TabIndex = 9;
            this.btLoginVendedor.Text = "Ingresar como vendedor";
            this.btLoginVendedor.UseVisualStyleBackColor = true;
            this.btLoginVendedor.Click += new System.EventHandler(this.btLoginVendedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 366);
            this.Controls.Add(this.btLoginVendedor);
            this.Controls.Add(this.lbNotif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCi;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNotif;
        private System.Windows.Forms.Button btLoginVendedor;
    }
}

