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
    public partial class FrmVotante : Form
    {
        public FrmVotante()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmControl frmContr = new FrmControl();
            frmContr.ShowDialog();            
        }

        private void btnVotanteEmitirVoto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por Emitir Su Voto.");

        }

    }
}
