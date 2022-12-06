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
    public partial class frmWishlist : Form
    {
        string id;
        DataSet dsLista;
        public frmWishlist(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void frmWishlist_Load(object sender, EventArgs e)
        {
            string sql = "select W.idProd, P.nombre,precio from Wishlist W, Producto P where W.idProd=P.idProd and W.idComp='" + id + "'";
            dsLista = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            dgWishL.DataSource = dsLista;
            if (dsLista != null)
            {
                dgWishL.DataMember = dsLista.Tables[0].ToString();
                lbNotif.Visible = false;
            }
            else
            {
                dgWishL.DataSource = null;
                lbNotif.Visible = true;
                lbNotif.Text = "Tus lista está vacía. Comienza a llenarla!";
            }

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            for (int x = 0; x <= dgWishL.RowCount - 1; x++)
            {
                if (dgWishL.Rows[x].Selected == true)
                {
                    DialogResult resp;
                    resp = MessageBox.Show("Estás seguro/a de querer borrar esta entrada de la lista?", "Confirmación");
                    if (resp.ToString() == "OK")
                    {
                        int exito;
                        string remove = "delete from Wishlist where idComp='" + id + "' and idProd=" + dgWishL.Rows[x].Cells["idProd"].Value.ToString();
                        dsLista.Tables[0].Rows.RemoveAt(x);
                        exito = GestorDeBaseDeDatos.Instance.EjecutarConsulta(remove);
                    }
                }
            }

        }

        private void btAddToCart_Click(object sender, EventArgs e)
        {

            for (int x = 0; x <= dgWishL.RowCount - 1; x++)
            {
                if (dgWishL.Rows[x].Selected == true)
                {
                    DialogResult resp;
                    resp = MessageBox.Show("Estás seguro/a de querer mover al carrito? La entrada se borrará de esta lista", "Confirmación");
                    if (resp.ToString() == "OK")
                    {
                        int exInsert;
                        StringBuilder strInsert = new StringBuilder();
                        strInsert.AppendFormat("insert into Carrito(idCarrito,idComp,idProd,cantidad,subtotal) values('{0}','{1}','{2}','{3}','{4}');", id, id, dgWishL.Rows[x].Cells["idProd"].Value, "1", dgWishL.Rows[x].Cells["precio"].Value);
                        exInsert = GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());

                        int exito;
                        string remove = "delete from Wishlist where idComp='" + id + "' and idProd=" + dgWishL.Rows[x].Cells["idProd"].Value.ToString();
                        dsLista.Tables[0].Rows.RemoveAt(x);
                        exito = GestorDeBaseDeDatos.Instance.EjecutarConsulta(remove);
                    }
                }
            }
        }
    }
}
