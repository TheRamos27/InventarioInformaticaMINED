using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.MINED
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=RAMOS-DELL;DataBase= InventarioInformatica;Integrated Security=true");
            conn.Open();
            string query = "SELECT * FROM Users WHERE Usuario=@Usuario AND Contraseña=@Contraseña";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Bienvenido a SII-SISTEMA DE INVENTARIO INFORMATICO!");
                FrmMenuInicio inicio = new FrmMenuInicio();
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña Invalida");
            }
            reader.Close();
            conn.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
