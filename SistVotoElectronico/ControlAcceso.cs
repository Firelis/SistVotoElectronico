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
    public partial class FrmControl : Form
    {
        public FrmControl()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnControlAcceso_Click(object sender, EventArgs e)
        {
            if (txtControlUsuario.Text == "Segovia" && txtControlContraseña.Text == "Pikachu")
            {
                MessageBox.Show("Acceso Concedido, Cerrando...");
                Application.ExitThread();
            }
            else
            {
                MessageBox.Show("Revise el Usuario o Contraseña");
            }
        }
    }
}
