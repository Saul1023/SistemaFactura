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
    public partial class FormGenerarFactura : Form
    {
        public FormGenerarFactura()
        {
            InitializeComponent();
            TipoFactura.Items.Add("ESPECIFICO");
            TipoFactura.Items.Add("GENERAL");
            TipoFactura.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private string cadenaConexion = "Data Source=localhost;Initial Catalog=sistema_factura;User ID=factura_admin;Password=admin123";

        private string ObtenerTipoFactura()
        {
            if (TipoFactura.SelectedItem != null)
            {
                return TipoFactura.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de factura.");
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el tipo de factura seleccionado
            string tipoFactura = ObtenerTipoFactura();

            // Si el tipo de factura es válido
            if (!string.IsNullOrEmpty(tipoFactura))
            {
                // Obtener los demás datos de la factura (por ejemplo, podrías obtenerlos de otros controles en tu formulario)
                // Supongamos que obtienes estos datos de otros controles del formulario
                string nitUsuario = tbNit.Text;
                string nombreRazon = tbNombreRazon.Text;
                string nitEmisor = tbNitEmisor.Text;
                int numeroFactura = Convert.ToInt32(tbNumeroFactura.Text);
                string codAutorizacion = tbCodigoAutorizacion.Text;
                DateTime fechaEmision = DateTime.Now;
                decimal monto = Convert.ToDecimal(tbMonto.Text);
                decimal montoImponible = Convert.ToDecimal(tbMontoImponible.Text);
                string codControl = tbCodigoControl.Text;


                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    string consulta = @"INSERT INTO factura (nit_usuario, nombre_razon, nit_emisor, numero_factura, cod_autorizacion, fecha_emision, monto, monto_imponible, cod_control, tipo_especifico, tipo_general)
                                VALUES (@nitUsuario, @nombreRazon, @nitEmisor, @numeroFactura, @codAutorizacion, @fechaEmision, @monto, @montoImponible, @codControl, @tipoEspecifico, @tipoGeneral)";

                    SqlCommand command = new SqlCommand(consulta, connection);
                    command.Parameters.AddWithValue("@nitUsuario", nitUsuario);
                    command.Parameters.AddWithValue("@nombreRazon", nombreRazon);
                    command.Parameters.AddWithValue("@nitEmisor", nitEmisor);
                    command.Parameters.AddWithValue("@numeroFactura", numeroFactura);
                    command.Parameters.AddWithValue("@codAutorizacion", codAutorizacion);
                    command.Parameters.AddWithValue("@fechaEmision", fechaEmision);
                    command.Parameters.AddWithValue("@monto", monto);
                    command.Parameters.AddWithValue("@montoImponible", montoImponible);
                    command.Parameters.AddWithValue("@codControl", codControl);
                    command.Parameters.AddWithValue("@tipoEspecifico", tipoFactura == "ESPECIFICO" ? 1 : 0);
                    command.Parameters.AddWithValue("@tipoGeneral", tipoFactura == "GENERAL" ? 1 : 0);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Factura generada y registrada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar y registrar la factura: " + ex.Message);
                    }
                }
            }
        }
    }
}
