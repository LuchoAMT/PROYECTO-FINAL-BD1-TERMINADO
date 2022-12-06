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
    public partial class frmRegalarGC : Form
    {
        string id;
        int numCard;
        DataSet dsGC;
        public frmRegalarGC(string id, int numCard)
        {
            this.id = id;
            this.numCard = numCard;
            InitializeComponent();
        }

        private void frmRegalarGC_Load(object sender, EventArgs e)
        {
            lbNum.Text = "NumCard = " + numCard.ToString();
            string sql = "select Nombre from Comprador";
            dsGC = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            if (dsGC != null)
            {
                for (int i = 0; i < dsGC.Tables[0].Rows.Count; i++)
                {
                    cbxDest.Items.AddRange(dsGC.Tables[0].Rows[i][0].ToString().Split(','));
                }
                tbMonto.Text = "100"; //por defecto la tarjeta viene en 100
                dtpExp.Value = DateTime.Now;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            if (cbxDest.SelectedItem != null)
            {
                string sql = "select idComp from Comprador where Nombre = '" + cbxDest.SelectedItem.ToString() + "'";
                DataSet dsReciv = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);

                StringBuilder strInsert = new StringBuilder();
                strInsert.AppendFormat("insert into Giftcard(idCard,idComp,idReciv,monto,fechaExp) values('{0}','{1}','{2}','{3}','{4}');", numCard, id, dsReciv.Tables[0].Rows[0][0].ToString(), tbMonto.Text, dtpExp.Value.ToString());
                int amogus = GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
                numCard++;
                this.Close();
            }
            else
            {
                MessageBox.Show("Elige un usuario a quien regalarle la Giftcard", "Mensaje");
            }

        }
    }
}
