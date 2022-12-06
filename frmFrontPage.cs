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
    public partial class frmFrontPage : Form
    {
        DataSet dsUsr;
        DataSet dsProds;
        string id;
        public frmFrontPage(string miId)
        {
            this.id = miId;
            InitializeComponent();
        }

        private void mCuenta_Click(object sender, EventArgs e)
        {
            frmVerCuenta fVerCuenta = new frmVerCuenta(id, dsUsr, this);
            fVerCuenta.ShowDialog();
        }

        private void mWishlist_Click(object sender, EventArgs e)
        {
            frmWishlist fWish = new frmWishlist(id);
            fWish.ShowDialog();
        }

        private void frmFrontPage_Load(object sender, EventArgs e)
        {
            string query = "select Nombre from Comprador where idComp='" + id + "'";
            dsUsr = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(query);
            lbSaludo.Text = "Bienvenido " + dsUsr.Tables[0].Rows[0][0].ToString();

            string sqlpais = "select * from paises";
            DataSet dspais = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sqlpais);
            for (int i = 0; i < dspais.Tables[0].Rows.Count; i++)
            {
                mcbEnviarA.Items.AddRange(dspais.Tables[0].Rows[i][0].ToString().Split(','));
            }

            string sqlCats = "select distinct categoria from Producto";
            DataSet dsCbx = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sqlCats);
            for (int i = 0; i < dsCbx.Tables[0].Rows.Count; i++)
            {
                cbxCategoria.Items.AddRange(dsCbx.Tables[0].Rows[i][0].ToString().Split(','));
            }

            string prods = "select * from Producto";
            dsProds = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(prods);
            dgProductos.DataSource = dsProds;
            dgProductos.DataMember = dsProds.Tables[0].ToString();
        }

        private void mCarrito_Click(object sender, EventArgs e)
        {
            frmCarrito frmCarrito = new frmCarrito(id);
            frmCarrito.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void mPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos fPedidos = new frmPedidos(id);
            fPedidos.ShowDialog();
        }

        private void mDevoluciones_Click(object sender, EventArgs e)
        {
            frmDevoluciones fDevs = new frmDevoluciones(id);
            fDevs.ShowDialog();
        }

        private void regalarUnaTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string numCard = "select max(idCard) from Giftcard";
            DataSet nroCard = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(numCard);
            int nroTarjeta = Convert.ToInt32(nroCard.Tables[0].Rows[0][0].ToString());
            frmRegalarGC fRegalar = new frmRegalarGC(id, ++nroTarjeta);
            fRegalar.ShowDialog();
        }

        private void misTarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMyGiftcards fMyGC = new frmMyGiftcards(id);
            fMyGC.ShowDialog();
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selCat = "select * from Producto where categoria='" + cbxCategoria.SelectedItem.ToString() + "'";
            dsProds = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(selCat);
            dgProductos.DataSource = dsProds;
            dgProductos.Refresh();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgProductos.Rows.Count; i++)
            {
                if (dgProductos.Rows[i].Selected == true)
                {
                    int pos = e.RowIndex;
                    string idP = dgProductos.Rows[pos].Cells["idProd"].Value.ToString().Trim();
                    frmProducto fProd = new frmProducto(idP, id);
                    fProd.ShowDialog();
                }
            }
        }
    }
}
