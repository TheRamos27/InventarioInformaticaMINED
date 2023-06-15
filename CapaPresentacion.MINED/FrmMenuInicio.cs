using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.MINED
{
    public partial class FrmMenuInicio : Form
    {
        public FrmMenuInicio()
        {
            InitializeComponent();
        }



        private void eQUIPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEquipo equipo = new FrmEquipo();
            this.Hide();
            equipo.ShowDialog();
            this.Close();
        }

        private void iPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNumeroIp ip = new FrmNumeroIp();
            this.Hide();
            ip.ShowDialog();
            this.Close();
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            this.Hide();
            usuario.ShowDialog();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
