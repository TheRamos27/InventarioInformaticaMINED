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

namespace CapaPresentacion.MINED
{
    public partial class FrmUsuario : Form
    {

        CN_Usuario herramientaUsuarioCN = new CN_Usuario();
        private string id = null;
        private bool Editar = false;

        public FrmUsuario()
        {
            InitializeComponent();
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

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            this.Hide();
            usuario.ShowDialog();
            this.Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioInformaticaDataSet1.Users' Puede moverla o quitarla según sea necesario.
            MostrarUsuario();
        }

        private void MostrarUsuario()
        {

            CN_Usuario objeto = new CN_Usuario();
            dgvUsuario.DataSource = objeto.MostrarUsuario();
        }

        private void limpiarForm()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtPosicion.Clear();
            txtCorreo.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    herramientaUsuarioCN.InsertarUsuario(txtUsuario.Text, txtContraseña.Text, txtNombres.Text, txtApellidos.Text, txtPosicion.Text, txtCorreo.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarUsuario();
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
                    herramientaUsuarioCN.EditarUsuario(txtUsuario.Text, txtContraseña.Text, txtNombres.Text, txtApellidos.Text, txtPosicion.Text, txtCorreo.Text, id);
                    MessageBox.Show("se edito correctamente");
                    MostrarUsuario();
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
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                id = dgvUsuario.CurrentRow.Cells["Id"].Value.ToString();
                herramientaUsuarioCN.EliminarUsuario(id);
                MessageBox.Show("Eliminado correctamente");
                MostrarUsuario();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                Editar = true;
                txtUsuario.Text = dgvUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = dgvUsuario.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtNombres.Text = dgvUsuario.CurrentRow.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = dgvUsuario.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtPosicion.Text = dgvUsuario.CurrentRow.Cells["Posicionn"].Value.ToString();
                txtCorreo.Text = dgvUsuario.CurrentRow.Cells["Correo"].Value.ToString();
                id = dgvUsuario.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
