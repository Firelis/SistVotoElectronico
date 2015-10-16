using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistVotoElectronico
{
    public partial class FrmJuezMesa : Form
    {
        public FrmJuezMesa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmJuezMesa_Load(object sender, EventArgs e)
        {

        }

        private void lblJuezSalir_Click(object sender, EventArgs e)
        {

        }

        private void lblJuezSalir_Click_1(object sender, EventArgs e)
        {
            FrmControl frmContr = new FrmControl();
            frmContr.ShowDialog();
        }

        private void txtJuezDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
        {
            e.Handled = false;
        }
        else if (Char.IsControl(e.KeyChar))
       {
            e.Handled = false;
       }
       else if (Char.IsSeparator(e.KeyChar))
       {
           e.Handled = false;
       }
       else
       {
           e.Handled = true;
       }
     }

        private void txtJuezTipDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnJuezHabilitarVoto_Click(object sender, EventArgs e)
        {
            lblJuezMensajeSist.Text = "Se activo la votacion, a la espera del Voto.";
        }

   }
}
