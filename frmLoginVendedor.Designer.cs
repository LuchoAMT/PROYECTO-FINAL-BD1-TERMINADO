namespace PROYECTO_FINAL_NUEVO
{
    partial class frmLoginVendedor
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btLoginVend = new System.Windows.Forms.Button();
            this.btRegistrarVend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbNotif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa como vendedor!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "I.D.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(207, 92);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 5;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(207, 129);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(160, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // btLoginVend
            // 
            this.btLoginVend.Location = new System.Drawing.Point(62, 211);
            this.btLoginVend.Name = "btLoginVend";
            this.btLoginVend.Size = new System.Drawing.Size(75, 39);
            this.btLoginVend.TabIndex = 9;
            this.btLoginVend.Text = "Login";
            this.btLoginVend.UseVisualStyleBackColor = true;
            this.btLoginVend.Click += new System.EventHandler(this.btLoginVend_Click);
            // 
            // btRegistrarVend
            // 
            this.btRegistrarVend.Location = new System.Drawing.Point(219, 211);
            this.btRegistrarVend.Name = "btRegistrarVend";
            this.btRegistrarVend.Size = new System.Drawing.Size(75, 39);
            this.btRegistrarVend.TabIndex = 10;
            this.btRegistrarVend.Text = "Registrate";
            this.btRegistrarVend.UseVisualStyleBackColor = true;
            this.btRegistrarVend.Click += new System.EventHandler(this.btRegistrarVend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "¿No estás Registrado?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ingresar como comprador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbNotif
            // 
            this.lbNotif.AutoSize = true;
            this.lbNotif.Location = new System.Drawing.Point(216, 306);
            this.lbNotif.Name = "lbNotif";
            this.lbNotif.Size = new System.Drawing.Size(0, 13);
            this.lbNotif.TabIndex = 13;
            // 
            // frmLoginVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 380);
            this.Controls.Add(this.lbNotif);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btRegistrarVend);
            this.Controls.Add(this.btLoginVend);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLoginVendedor";
            this.Text = "frmLoginVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btLoginVend;
        private System.Windows.Forms.Button btRegistrarVend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbNotif;
    }
}