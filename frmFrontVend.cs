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
    public partial class frmFrontVend : Form
    {
        string id;
        DataSet dsGrid;
        public frmFrontVend(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmFrontVend_Load(object sender, EventArgs e)
        {
            string nom = "select Nombre from Vendedor where idVend='" + id + "'";
            DataSet dsNom = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(nom);
            lbSal.Text = dsNom.Tables[0].Rows[0][0].ToString().Trim() + " página principal";

            string sql = "select V.num, V.idComp, C.Nombre, V.idProd, P.nombre as 'Producto', V.cantProd, V.total from Venta V, Comprador C, Producto P where V.idComp=C.idComp and V.idProd=P.idProd and V.estado='Enviando' and V.idVend='" + id + "'";
            dsGrid = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            dgVent.DataSource = dsGrid;
            if (dsGrid != null)
            {
                dgVent.DataMember = dsGrid.Tables[0].ToString().Trim();
                lbShow.Text = "Tus Ventas";
            }
            else 
            {
                dgVent.DataMember = null;
                lbShow.Text = "Parece que aun nadie ha comprado nada";
            }
        }

        private void mostrarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select V.num, V.idComp, C.Nombre, V.idProd, P.nombre as 'Producto', V.cantProd, V.total from Venta V, Comprador C, Producto P where V.idComp=C.idComp and V.idProd=P.idProd and V.estado='Enviando' and V.idVend='" + id + "'";
            dsGrid = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            dgVent.DataSource = dsGrid;
            if (dsGrid != null)
            {
                dgVent.DataMember = dsGrid.Tables[0].ToString().Trim();
                lbShow.Text = "Tus Ventas";
            }
            else
            {
                dgVent.DataMember = null;
                lbShow.Text = "Parece que aun nadie ha comprado nada";
            }
        }

        private void mostrarDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select V.num, V.idComp, C.Nombre, V.idProd, P.nombre as 'Producto', V.cantProd, V.total from Venta V, Comprador C, Producto P where V.idComp=C.idComp and V.idProd=P.idProd and V.estado='Devuelto' and V.idVend='" + id + "'";
            dsGrid = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            dgVent.DataSource = dsGrid;
            if (dsGrid != null)
            {
                dgVent.DataMember = dsGrid.Tables[0].ToString();
                lbShow.Text = "Pedidos devueltos";
            }
            else
            {
                dgVent.DataMember = null;
                lbShow.Text = "Parece que aun nadie ha devuelto nada";
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStock fstock = new frmAddStock();
            fstock.ShowDialog();
        }
    }
}
