using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_NUEVO
{
    public partial class frmLoginVendedor : Form
    {
        DataSet dtsVend;
        public frmLoginVendedor()
        {
            InitializeComponent();
        }

        private void btLoginVend_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "")
            {
                frmFrontVend fFrontVend = new frmFrontVend(tbId.Text);
                fFrontVend.ShowDialog();
            }
        }

        private void btRegistrarVend_Click(object sender, EventArgs e)
        {
            frmRegistrarVendedor fVend = new frmRegistrarVendedor();
            fVend.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fComp = new Form1();
            fComp.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Vendedor where idVend='" + tbId.Text + "'";
            dtsVend = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(query);
            if (dtsVend != null)
            {
                tbNombre.Text = dtsVend.Tables[0].Rows[0][1].ToString();
                lbNotif.Visible = false;
            }
            else
            {
                tbNombre.Text = "";
                lbNotif.Visible = true;
                lbNotif.Text = "El usuario no está registrado!!";
            }
        }
    }
}
