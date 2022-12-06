using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_NUEVO
{
    public partial class frmComprar : Form
    {
        string idProd;
        string idComp;
        int numVent;
        DataSet dsVend;
        DataSet dsComp;
        public frmComprar(string idProd, string idComp, int numVent)
        {
            this.idProd = idProd;
            this.idComp = idComp;
            this.numVent = numVent;
            InitializeComponent();
        }

        private void frmComprar_Load(object sender, EventArgs e)
        {
            string selectVend = "select Nombre from Vendedor";
            dsVend = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(selectVend);
            for (int i = 0; i < dsVend.Tables[0].Rows.Count; i++)
            {
                cbxVendedor.Items.AddRange(dsVend.Tables[0].Rows[i][0].ToString().Split(','));
            }
            string sql = "select * from Producto where idProd='" + idProd + "'";
            dsComp = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            if (dsComp != null)
            {
                tbProd.Text = dsComp.Tables[0].Rows[0][1].ToString().Trim();
                tbPrecio.Text = dsComp.Tables[0].Rows[0][6].ToString().Trim();
                tbCantidad.Text = "1";
                lbStock.Text = "Quedan " + dsComp.Tables[0].Rows[0][5].ToString().Trim() + " unidades en existencias";
                tbSubT.Text = (float.Parse(tbPrecio.Text) * int.Parse(tbCantidad.Text)).ToString();
                tbDesc.Text = dsComp.Tables[0].Rows[0][7].ToString();
                if (tbDesc.Text == "" || tbDesc.Text == " ")
                {
                    tbTotal.Text = tbSubT.Text;
                }
                else
                {
                    float desc = float.Parse(tbDesc.Text);
                    tbTotal.Text = (float.Parse(tbSubT.Text) - (float.Parse(tbSubT.Text) * desc)).ToString();
                }
                
            }
            else
            {
                MessageBox.Show("No se econtraron datos", "Error");
            }
            
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad.Text == "" || tbCantidad.Text == " " || tbCantidad.Text == "0")
            {
                btConfirm.Enabled = false;
                tbSubT.Text = " ";
            }
            else
            {
                btConfirm.Enabled = true;
                int cant = Convert.ToInt32(tbCantidad.Text);
                float subTotal = cant * float.Parse(tbPrecio.Text);
                float total = 0;
                if (tbDesc.Text == "" || tbDesc.Text == " ")
                {
                    total = subTotal;
                    tbTotal.Text = total.ToString();
                }
                else
                {
                    total = subTotal - (subTotal * float.Parse(tbDesc.Text));
                    
                }
                tbSubT.Text = subTotal.ToString();
                tbTotal.Text = total.ToString();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            int success;
            if (cbxVendedor.SelectedItem != null)
            {
                string selectIdVen = "select idVend from Vendedor where Nombre='" + cbxVendedor.SelectedItem.ToString() + "'";
                dsVend = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(selectIdVen);
                if (int.Parse(dsComp.Tables[0].Rows[0][5].ToString()) >= int.Parse(tbCantidad.Text))
                {
                    StringBuilder strInsert = new StringBuilder();
                    strInsert.AppendFormat("insert into Venta(num,idVend,idComp,idProd,cantProd,total,estado) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", numVent, dsVend.Tables[0].Rows[0][0].ToString(), idComp, idProd, tbCantidad.Text, tbTotal.Text, "Enviando");
                    success = GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
                    numVent++;
                    string cambiostock = "update Producto set stock=stock-'" + int.Parse(tbCantidad.Text) + "' where idProd='" + idProd + "'";
                    int stock = GestorDeBaseDeDatos.Instance.EjecutarConsulta(cambiostock);
                    string rem = "delete from Carrito where idComp='" + idComp + "' and idProd='" + idProd + "'";
                    int del = GestorDeBaseDeDatos.Instance.EjecutarConsulta(rem);
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("No hay sufucientes artículos para realizar la compra!!", "Advertencia");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Vendedor de la lista", "Mensaje");
            }
            
        }
    }
}
