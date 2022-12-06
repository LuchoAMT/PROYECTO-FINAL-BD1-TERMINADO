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
    public partial class frmCarrito : Form
    {
        string id;
        DataSet dsCart;
        public frmCarrito(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void frmCarrito_Load(object sender, EventArgs e)
        {
            string sql = "select C.idProd, P.nombre,precio, C.cantidad from Carrito C, Producto P where C.idProd=P.idProd and C.idComp='" + id + "'";
            dsCart = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            dgCarrito.DataSource = dsCart;
            if (dsCart != null)
            {
                dgCarrito.DataMember = dsCart.Tables[0].ToString();
                lbNotif.Visible = false;
            }
            else
            {
                dgCarrito.DataSource = null;
                lbNotif.Visible = true;
                lbNotif.Text = "Tu carrito está vacío. Comienza a llenarlo!";
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btQuitar_Click(object sender, EventArgs e)
        {
            for (int x = 0; x <= dgCarrito.RowCount - 1; x++)
            {
                if (dgCarrito.Rows[x].Selected == true)
                {
                    DialogResult resp;
                    resp = MessageBox.Show("Estás seguro/a de querer borrar esta entrada de la lista? \nEsta acción no se puede deshacer", "Confirmación");
                    if (resp.ToString() == "OK")
                    {
                        int exito;
                        string remove = "delete from Carrito where idComp='" + id + "' and idProd=" + dgCarrito.Rows[x].Cells["idProd"].Value.ToString();
                        dsCart.Tables[0].Rows.RemoveAt(x);
                        exito = GestorDeBaseDeDatos.Instance.EjecutarConsulta(remove);
                    }
                }
            }
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgCarrito.RowCount; i++)
            {
                if (dgCarrito.Rows[i].Selected == true)
                {
                    string numVent = "select max(num) from Venta";
                    DataSet nroVenta = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(numVent);
                    frmComprar fCompra = new frmComprar(dgCarrito.Rows[i].Cells["idProd"].Value.ToString(), id, int.Parse(nroVenta.Tables[0].Rows[0][0].ToString())+1);
                    fCompra.ShowDialog();
                    this.Close();
                }
            } 
        }
    }
}
