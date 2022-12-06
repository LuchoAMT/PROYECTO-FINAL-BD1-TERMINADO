using PROYECTO_FINAL_NUEVO;
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
    public partial class Form1 : Form
    {
        DataSet dtsComp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "")
            {
                frmFrontPage front = new frmFrontPage(tbCi.Text);
                front.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarComprador reg = new RegistrarComprador();
            reg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLoginVendedor_Click(object sender, EventArgs e)
        {
            frmLoginVendedor fVendedor = new frmLoginVendedor();
            fVendedor.ShowDialog();
            this.Visible= false;
            this.Close();
            this.Dispose();
        }

        private void tbCi_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Comprador where idComp='" + tbCi.Text + "'";
            dtsComp = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(query);
            if (dtsComp != null)
            {
                tbNombre.Text = dtsComp.Tables[0].Rows[0][1].ToString();
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
