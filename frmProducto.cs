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
    public partial class frmProducto : Form
    {
        string idProd;
        string id;
        DataSet dsProd;
        public frmProducto(string idProd, string id)
        {
            InitializeComponent();
            this.idProd = idProd;
            this.id = id;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            string prod = "select * from Producto where idProd='" + idProd + "'";
            dsProd = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(prod);

            tbId.Text = dsProd.Tables[0].Rows[0][0].ToString();
            tbNombre.Text = dsProd.Tables[0].Rows[0][1].ToString();
            tbDesc.Text = dsProd.Tables[0].Rows[0][2].ToString();
            tbCat.Text = dsProd.Tables[0].Rows[0][3].ToString();
            tbSubCat.Text = dsProd.Tables[0].Rows[0][4].ToString();
            tbStock.Text = dsProd.Tables[0].Rows[0][5].ToString();
            tbPrecio.Text = dsProd.Tables[0].Rows[0][6].ToString();
            if (dsProd.Tables[0].Rows[0][7].ToString() == null)
            {
                tbOferta.Text = "";
            }
            else
                tbOferta.Text = dsProd.Tables[0].Rows[0][7].ToString();
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            string numVent = "select max(num) from Venta";
            DataSet nroVenta = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(numVent);
            frmComprar fCompra = new frmComprar(idProd, id, int.Parse(nroVenta.Tables[0].Rows[0][0].ToString()) + 1);
            fCompra.ShowDialog();
            this.Close();
        }
    }
}
