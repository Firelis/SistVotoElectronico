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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            FrmVotante frmVot = new FrmVotante();
            frmVot.Show();
            this.Hide();
        }

        private void btnInicioJuez_Click(object sender, EventArgs e)
        {
            FrmJuezMesa frmJueM = new FrmJuezMesa();
            frmJueM.Show();
            this.Hide();
        }
    }
}
