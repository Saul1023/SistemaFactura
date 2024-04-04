
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaFactura.Conexion;
namespace SistemaFactura
{
    public partial class FormLogin : Form
    {
        private Conexion.Conexion conexion;
        public FormLogin()
        {
            InitializeComponent();
            conexion = new Conexion.Conexion();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string nit = txtNit.Text.Trim();

            if (string.IsNullOrEmpty(nit))
            {
                MessageBox.Show("Por favor, ingrese el NIT.");
                return;
            }

            string consulta = "SELECT COUNT(*) FROM usuario WHERE nit = @nit";
            using (SqlCommand command = new SqlCommand(consulta, conexion.con))
            {
                command.Parameters.AddWithValue("@nit", nit);
                try
                {
                    conexion.conectarBD();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        // Inicio de sesión exitoso, abrir el formulario para generar facturas
                        FormGenerarFactura formGenerarFactura = new FormGenerarFactura();
                        formGenerarFactura.Show();
                        this.Hide(); // Ocultar el formulario de inicio de sesión
                    }
                    else
                    {
                        // El NIT proporcionado no está registrado, abrir el formulario de registro de usuario
                        MessageBox.Show("El NIT proporcionado no está registrado. Se abrirá el formulario de registro de usuario.");
                        FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario();
                        formRegistrarUsuario.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }
        private void txtNit_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
