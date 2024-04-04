﻿using System.Data.SqlClient;

namespace SistemaFactura.Conexion
{
    internal class Database
    {
        private string cadenaConexion;
        public SqlConnection con { get; set; }
        public Database()
        {
            cadenaConexion = @"Data Source=DESKTOP-FM8K9EG\SQLEXPRESS;Initial Catalog=sistema_factura;User ID=factura_admin;Password=admin123";
            con = new SqlConnection(cadenaConexion);
        }
        public void conectarBD()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la BD: " + ex.Message);
            }
        }
        public void cerrarBD()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la BD: " + ex.Message);
            }
        }

    }
}