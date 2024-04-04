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

namespace SistemaFactura
{
    public partial class FormRegistrarUsuario : Form
    {
        private Conexion.Conexion conexion;
        public FormRegistrarUsuario()
        {
            InitializeComponent();
            tbNit.Controls.RemoveAt(0);
            conexion = new Conexion.Conexion();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbNit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nit = tbNit.Text.Trim();
            string nombre = tetNombre.Text.Trim();

            // Validar los datos ingresados (por ejemplo, asegurarse de que no estén vacíos)
            if (string.IsNullOrEmpty(nit) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese todos los campos.");
                return;
            }
            string consulta = "INSERT INTO usuario (nit, nombre) VALUES (@nit, @nombre)";
            using (SqlCommand command = new SqlCommand(consulta, conexion.con))
            {
                command.Parameters.AddWithValue("@nit", nit);
                command.Parameters.AddWithValue("@nombre", nombre);
                try
                {
                    conexion.conectarBD();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado exitosamente.");
                    this.Close(); // Cerrar el formulario de registro de usuario después del registro exitoso
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                }
                finally
                {
                    conexion.cerrarBD();
                }
            }
        }
    }
}
