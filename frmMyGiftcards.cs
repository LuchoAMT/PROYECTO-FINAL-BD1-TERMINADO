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
    public partial class frmMyGiftcards : Form
    {
        string id;
        DataSet dsMisCard;
        public frmMyGiftcards(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void frmMyGiftcards_Load(object sender, EventArgs e)
        {
            string sql = "select G.idCard, C.Nombre as 'Beneficiario', G.monto, G.fechaExp from Giftcard G, Comprador C where G.idReciv='" + id + "' and G.idComp=C.idComp";
            dsMisCard = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            dgCards.DataSource = dsMisCard;
            if (dsMisCard != null)
            {
                dgCards.DataMember = dsMisCard.Tables[0].ToString();
                lbNotif.Visible = false;
            }
            else
            {
                dgCards.DataSource = null;
                lbNotif.Visible = true;
                lbNotif.Text = "Nadie te ha regalado una tarjeta de regalo aún. that's sad!";
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btQuitar_Click(object sender, EventArgs e)
        {
            for (int x = 0; x <= dgCards.RowCount - 1; x++)
            {
                if (dgCards.Rows[x].Selected == true)
                {
                    DialogResult resp;
                    resp = MessageBox.Show("Estás seguro/a de querer borrar esta entrada de la lista? \nEsta acción no se puede deshacer", "Confirmación");
                    if (resp.ToString() == "OK")
                    {
                        int exito;
                        string remove = "delete from Giftcard where idCard='" + dsMisCard.Tables[0].Rows[x]["idCard"].ToString() + "'";
                        dsMisCard.Tables[0].Rows.RemoveAt(x);
                        exito = GestorDeBaseDeDatos.Instance.EjecutarConsulta(remove);
                        dgCards.Refresh();
                    }
                }
            }
        }
    }
}
