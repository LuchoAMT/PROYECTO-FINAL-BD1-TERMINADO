namespace PROYECTO_FINAL_NUEVO
{
    partial class RegistrarComprador
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
            this.tbCi = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbCalif = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "C.I.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "País:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calificación:";
            // 
            // tbCi
            // 
            this.tbCi.Location = new System.Drawing.Point(249, 93);
            this.tbCi.Name = "tbCi";
            this.tbCi.Size = new System.Drawing.Size(100, 20);
            this.tbCi.TabIndex = 4;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(249, 140);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 5;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(249, 193);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(100, 20);
            this.tbPais.TabIndex = 6;
            // 
            // tbCalif
            // 
            this.tbCalif.Enabled = false;
            this.tbCalif.Location = new System.Drawing.Point(249, 243);
            this.tbCalif.Name = "tbCalif";
            this.tbCalif.Size = new System.Drawing.Size(100, 20);
            this.tbCalif.TabIndex = 7;
            this.tbCalif.Text = "0";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(210, 304);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Registrate!";
            // 
            // RegistrarComprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 383);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbCalif);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbCi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarComprador";
            this.Text = "Registrar Comprador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCi;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbCalif;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
    }
}