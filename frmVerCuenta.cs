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
    public partial class frmVerCuenta : Form
    {
        string id;
        DataSet dsUsr;
        frmFrontPage fPadre;
        public frmVerCuenta(string id, DataSet dsU, frmFrontPage fvPadre)
        {
            this.id = id;
            dsU = dsUsr;
            fPadre = fvPadre;
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            int exito;
            string sql = "update Comprador set Nombre='" + tbNombre.Text + "',Pais='" + tbPais.Text + "',Calificacion='" + tbCalif.Text + "' where idComp='" + id + "'";
            exito = GestorDeBaseDeDatos.Instance.EjecutarConsulta(sql);
            MessageBox.Show("Se actualizaron los datos de la cuenta", "Mensaje");
            this.Close();
        }

        private void frmVerCuenta_Load(object sender, EventArgs e)
        {
            string sql = "select * from Comprador where idComp='" + id + "'";
            dsUsr = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            tbId.Text = id;
            tbNombre.Text = dsUsr.Tables[0].Rows[0][1].ToString();
            tbPais.Text = dsUsr.Tables[0].Rows[0][2].ToString();
            tbCalif.Text = dsUsr.Tables[0].Rows[0][3].ToString();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Estás seguro/a de querer borrar su cuenta?", "Confirmación");
            if (resp.ToString() == "OK")
            {
                int exito;
                string vconsulta = "delete from Comprador where idComp=" + tbId.Text;
                exito = GestorDeBaseDeDatos.Instance.EjecutarConsulta(vconsulta);
                string mje = "Se borró " + exito + " registros";
                MessageBox.Show(mje, "Eliminación exitosa");
                this.Close();
                fPadre.Close();

            }
        }
    }
}
