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
    public partial class frmDevoluciones : Form
    {
        string id;
        DataSet dsDev;
        public frmDevoluciones(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            string sql = "select V.num, V.idProd, P.nombre, P.precio, V.cantProd, VE.idVend,VE.Nombre as 'Vendedor' from Venta V, Vendedor VE, Producto P where V.idProd=P.idProd and V.idComp='" + id + "' and V.idVend=VE.idVend and V.estado='Devuelto'";
            dsDev = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            dgDevoluciones.DataSource = dsDev;
            if (dsDev != null)
            {
                dgDevoluciones.DataMember = dsDev.Tables[0].ToString();
                lbNotif.Visible = false;
            }
            else
            {
                dgDevoluciones.DataSource = null;
                lbNotif.Visible = true;
                lbNotif.Text = "Aún no has pedido nada. Comienza a comprar!";
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
