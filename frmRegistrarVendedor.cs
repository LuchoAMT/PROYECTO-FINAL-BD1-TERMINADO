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
    public partial class frmRegistrarVendedor : Form
    {
        public frmRegistrarVendedor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            StringBuilder strInsert = new StringBuilder();
            strInsert.AppendFormat("insert into Vendedor(idVend,Nombre,Pais,Calificacion) values('{0}','{1}','{2}','{3}');", tbId.Text, tbNombre.Text, tbPais.Text, tbCalif.Text);
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("Se ingresó 1 registro", "Mensaje");
            Close();
        }
    }
}
