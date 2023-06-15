using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWinForm.MINED
{
    public partial class frmInicio : Form
    {
        CN_Equipo objetoCD = new CN_Equipo();
        private string idProducto = null;
        private bool Editar = false;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
