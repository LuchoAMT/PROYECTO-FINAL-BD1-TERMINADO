namespace PROYECTO_FINAL_NUEVO
{
    partial class frmMyGiftcards
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
            this.dgCards = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNotif = new System.Windows.Forms.Label();
            this.btQuitar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCards)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCards
            // 
            this.dgCards.AllowUserToAddRows = false;
            this.dgCards.AllowUserToDeleteRows = false;
            this.dgCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCards.Location = new System.Drawing.Point(49, 85);
            this.dgCards.Name = "dgCards";
            this.dgCards.ReadOnly = true;
            this.dgCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCards.Size = new System.Drawing.Size(677, 273);
            this.dgCards.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tus Tarjetas de Regalo";
            // 
            // lbNotif
            // 
            this.lbNotif.AutoSize = true;
            this.lbNotif.Location = new System.Drawing.Point(497, 60);
            this.lbNotif.Name = "lbNotif";
            this.lbNotif.Size = new System.Drawing.Size(35, 13);
            this.lbNotif.TabIndex = 2;
            this.lbNotif.Text = "label2";
            // 
            // btQuitar
            // 
            this.btQuitar.Location = new System.Drawing.Point(195, 385);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(96, 33);
            this.btQuitar.TabIndex = 3;
            this.btQuitar.Text = "Quitar";
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Click += new System.EventHandler(this.btQuitar_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(436, 385);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(96, 33);
            this.btVolver.TabIndex = 4;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // frmMyGiftcards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btQuitar);
            this.Controls.Add(this.lbNotif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCards);
            this.Name = "frmMyGiftcards";
            this.Text = "frmMyGiftcards";
            this.Load += new System.EventHandler(this.frmMyGiftcards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNotif;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Button btVolver;
    }
}