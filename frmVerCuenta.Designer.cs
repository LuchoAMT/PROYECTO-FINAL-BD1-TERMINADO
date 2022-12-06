namespace PROYECTO_FINAL_NUEVO
{
    partial class frmVerCuenta
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbCalif = new System.Windows.Forms.TextBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "I.D.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "País:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calificación:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(203, 69);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(203, 123);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(183, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(203, 170);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(183, 20);
            this.tbPais.TabIndex = 6;
            // 
            // tbCalif
            // 
            this.tbCalif.Location = new System.Drawing.Point(203, 222);
            this.tbCalif.Name = "tbCalif";
            this.tbCalif.Size = new System.Drawing.Size(100, 20);
            this.tbCalif.TabIndex = 7;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(65, 305);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(90, 35);
            this.btRegistrar.TabIndex = 8;
            this.btRegistrar.Text = "Registrar Cambios";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(203, 305);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(90, 35);
            this.btBorrar.TabIndex = 9;
            this.btBorrar.Text = "Borrar Cuenta";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tu Cuenta";
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(346, 305);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(90, 35);
            this.btVolver.TabIndex = 11;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // frmVerCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 393);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.tbCalif);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVerCuenta";
            this.Text = "frmVerCuenta";
            this.Load += new System.EventHandler(this.frmVerCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbCalif;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btVolver;
    }
}