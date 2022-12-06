namespace PROYECTO_FINAL_NUEVO
{
    partial class frmAddStock
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
            this.lbxProds = new System.Windows.Forms.ListBox();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxProds
            // 
            this.lbxProds.FormattingEnabled = true;
            this.lbxProds.Location = new System.Drawing.Point(31, 30);
            this.lbxProds.Name = "lbxProds";
            this.lbxProds.Size = new System.Drawing.Size(146, 290);
            this.lbxProds.TabIndex = 0;
            this.lbxProds.SelectedIndexChanged += new System.EventHandler(this.lbxProds_SelectedIndexChanged);
            // 
            // numCant
            // 
            this.numCant.Location = new System.Drawing.Point(293, 110);
            this.numCant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(121, 20);
            this.numCant.TabIndex = 1;
            this.numCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuantos desea añadir?";
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(284, 197);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(143, 31);
            this.btConfirm.TabIndex = 3;
            this.btConfirm.Text = "Confirmar";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(284, 263);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(143, 31);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(281, 155);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(35, 13);
            this.lbStock.TabIndex = 5;
            this.lbStock.Text = "Stock";
            // 
            // frmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 368);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCant);
            this.Controls.Add(this.lbxProds);
            this.Name = "frmAddStock";
            this.Text = "Agregar Stock";
            this.Load += new System.EventHandler(this.frmAddStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProds;
        private System.Windows.Forms.NumericUpDown numCant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbStock;
    }
}