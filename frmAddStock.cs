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
    public partial class frmAddStock : Form
    {
        DataSet dsLista;
        public frmAddStock()
        {
            InitializeComponent();
        }

        private void lbxProds_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stock = "select stock from Producto where nombre='" + lbxProds.SelectedItem.ToString() + "'";
            DataSet dsStock = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(stock);
            lbStock.Text = "Quedan " + dsStock.Tables[0].Rows[0][0].ToString() + " unidades de este producto";
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            string lista = "select nombre from Producto";
            dsLista = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(lista);
            for (int i = 0; i < dsLista.Tables[0].Rows.Count; i++)
            {
                lbxProds.Items.AddRange(dsLista.Tables[0].Rows[i][0].ToString().Split(','));
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string sql = "update Producto set stock = stock+'" + int.Parse(numCant.Value.ToString()) + "' where nombre='" + lbxProds.SelectedItem.ToString() + "'";
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(sql);
            MessageBox.Show("Se añadieron " + numCant.Value.ToString() + " unidades al stock", "Notificación");
            this.Close();
            this.Dispose();
        }
    }
}
