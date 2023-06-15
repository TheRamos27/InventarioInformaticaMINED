using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.MINED;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.MINED
{

    public partial class FrmNumeroIp : Form
    {
        CN_NumeroIp herramientaCD = new CN_NumeroIp();
        private string idIp = null;
        private bool Editar = false;
        public FrmNumeroIp()
        {
            InitializeComponent();
        }

        private void FrmNumeroIp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioInformaticaDataSet2.NumeroIp' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'inventarioInformaticaDataSet.Users' Puede moverla o quitarla según sea necesario.
            MostrarNumeroIp();
        }
        private void MostrarNumeroIp()
        {

            CN_NumeroIp objeto = new CN_NumeroIp();
            dataGridView1.DataSource = objeto.MostrarNumeroIp();
        }

        

        private void limpiarForm()
        {
            txtPersonaAsignada.Text = "";
            txtNumeroIp.Text = "";
            txtNumeroEquipo.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtPersonaAsignada.Text = dataGridView1.CurrentRow.Cells["NombreAsignacion"].Value.ToString();
                txtNumeroIp.Text = dataGridView1.CurrentRow.Cells["NIp"].Value.ToString();
                txtNumeroEquipo.Text = dataGridView1.CurrentRow.Cells["NombreEquipo"].Value.ToString();
                idIp = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    herramientaCD.InsetarNumeroIp(txtPersonaAsignada.Text, txtNumeroIp.Text, txtNumeroEquipo.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarNumeroIp();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {

                try
                {
                    herramientaCD.EditarNumeroIp(txtPersonaAsignada.Text, txtNumeroIp.Text, txtNumeroEquipo.Text, idIp);
                    MessageBox.Show("se edito correctamente");
                    MostrarNumeroIp();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idIp = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                herramientaCD.EliminarNumeroIp(idIp);
                MessageBox.Show("Eliminado correctamente");
                MostrarNumeroIp();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuInicio menu = new FrmMenuInicio();
            this.Hide();
            menu.ShowDialog();
            this.Close();
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

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            this.Hide();
            usuario.ShowDialog();
            this.Close();
        }
    }
}
