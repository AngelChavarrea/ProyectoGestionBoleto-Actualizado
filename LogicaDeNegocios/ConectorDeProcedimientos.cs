
using System;
using Datos;
using MySqlConnector;


namespace LogicaDeNegocios {
    /// <summary>
    /// Class ConectorDeProcedimientos.
    /// </summary>
    class ConectorDeProcedimientos {
        /// <summary>
        /// Conectars the procedimiento.
        /// </summary>
        /// <param name="procedimientos">The procedimientos.</param>
        /// <param name="mySqlConnection">My SQL connection.</param>
        /// <returns>MySqlCommand.</returns>
        public MySqlCommand ConectarProcedimiento(string procedimientos, MySqlConnection mySqlConnection) {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(procedimientos, mySqlConnection);
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }
    }
}
