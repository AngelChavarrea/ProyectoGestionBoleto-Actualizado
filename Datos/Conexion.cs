
using System;
using MySqlConnector;
using System.Windows.Forms;

namespace Datos {
    /// <summary>
    /// Class Conexion.
    /// </summary>
    public class Conexion
    {

        /// <summary>
        /// The conexion database externa
        /// </summary>
        private static string _conexion_DB_externa = "Server=MYSQL5040.site4now.net;Database=db_a83d0f_a7eb45;Uid=a83d0f_a7eb45;Pwd=1234emelec";

        /// <summary>
        /// The sqlconnection
        /// </summary>
        private MySqlConnection _sqlconnection = null;

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>The connection.</value>
        public MySqlConnection Connection { get => _sqlconnection; set => _sqlconnection = value; }

        //metodo para conectar con la base de datos

        /// <summary>
        /// Conectars this instance.
        /// </summary>
        /// <returns>MySqlConnection.</returns>
        public MySqlConnection conectar() {
            try {
                Connection = new MySqlConnection();
                Connection.ConnectionString = _conexion_DB_externa;
                Connection.Open();
            } catch (MySqlException x) {
                MessageBox.Show(x.ToString());
               
            }
            return Connection;
        }
        // metodo para cerrar la conexion
        /// <summary>
        /// Cerrars this instance.
        /// </summary>
        public void cerrar() {
            try {
                Connection.Close();
            } catch (MySqlException x) {

                MessageBox.Show(x.ToString());
            }
        }


    }
}
