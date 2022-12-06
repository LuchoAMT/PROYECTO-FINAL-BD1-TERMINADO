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
    public partial class frmPedidos : Form
    {
        string id;
        DataSet dsPed;
        public frmPedidos(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            string sql = "select V.num, V.idProd, P.nombre, P.precio, V.cantProd, VE.idVend,VE.Nombre as 'Vendedor', V.estado from Venta V, Vendedor VE, Producto P where V.idProd=P.idProd and V.idComp='" + id + "' and V.idVend=VE.idVend";
            dsPed = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            dgPedidos.DataSource = dsPed;
            if (dsPed != null)
            {
                dgPedidos.DataMember = dsPed.Tables[0].ToString();
                lbNotif.Visible = false;
            }
            else
            {
                dgPedidos.DataSource = null;
                lbNotif.Visible = true;
                lbNotif.Text = "Aún no has pedido nada. Comienza a comprar!";
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btDevolver_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgPedidos.RowCount; i++)
            {
                if (dgPedidos.Rows[i].Selected == true)
                {
                    DialogResult resp;
                    resp = MessageBox.Show("Estás seguro/a de querer devoler esta compra? \nEsta acción no se puede deshacer", "Confirmación");
                    if (resp.ToString() == "OK")
                    {
                        string sql = "update Venta set estado='Devuelto' where num='" + dgPedidos.Rows[i].Cells[0].Value.ToString() + "'";
                        int exito = GestorDeBaseDeDatos.Instance.EjecutarConsulta(sql);
                        dgPedidos.Rows.RemoveAt(i);
                        dgPedidos.Refresh();
                    }
                }
            }
        }
    }
}
