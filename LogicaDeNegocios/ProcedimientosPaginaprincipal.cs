
using System;
using Datos;
using MySqlConnector;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios {
    /// <summary>
    /// Class ProcedimientosPaginaprincipal.
    /// </summary>
    public class ProcedimientosPaginaprincipal {
        /// <summary>
        /// The con
        /// </summary>
        Conexion _con = new Conexion();
        private static string _cedula = "";

        public static string getCedula() {
            return _cedula;
        }

        public static void setCedula(string cedulas) {
            _cedula = cedulas;
        }

        /// <summary>
        /// Iniciases the seccion.
        /// </summary>
        /// <param name="correo">The correo.</param>
        /// <param name="password">The password.</param>
        /// <returns>List&lt;System.Int32&gt;.</returns>
        public List<int> IniciasSeccion(string correo, string password) {
            List<int> idPeronsaAndRol = new List<int>();
            List<string> idCedula = new List<string>();
            try {
                MySqlCommand mySqlCommand = ConectarProcedimiento("sspl_ProcesoInicioSeccion");
                mySqlCommand.Parameters.AddWithValue("@CorreoFx", correo);
                mySqlCommand.Parameters.AddWithValue("@contrasenaFx", password);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read()) {
                    int x = Convert.ToInt32(lector["Foreking_RolesUsuario"]);
                    idPeronsaAndRol.Add(Convert.ToInt32(lector["Foreking_RolesUsuario"]));
                    if (x == 1 || x==3) {
                        idPeronsaAndRol.Add(Convert.ToInt32(lector["idPersona"]));
                    } else {
                        idCedula.Add(Convert.ToString(lector["Cedula"]));
                        setCedula(idCedula[0]);
                    }                  
                }
                _con.cerrar(); 
            } catch (Exception ex) {
                MessageBox.Show("Error intentolo mas tarde" + ex);

            }          
            return idPeronsaAndRol;
        }

        /// <summary>
        /// Buscars the numeros asientos.
        /// </summary>
        /// <param name="busId">The bus identifier.</param>
        /// <returns>List&lt;System.String&gt;.</returns>
        public List<string> BuscarNumerosAsientos(int busId, int boletoID) {
            List<string> asientos = new List<string>();
            try {
                MySqlCommand mySqlCommand = ConectarProcedimiento("BuscarAsientos");
                mySqlCommand.Parameters.AddWithValue("@idBus", busId);
                mySqlCommand.Parameters.AddWithValue("@BoletoID", boletoID);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read()) {
                    asientos.Add(lector["DescripcionBus"].ToString());
                }
                _con.cerrar();
            } catch (Exception ex) {
                MessageBox.Show("Error intentolo mas tarde" + ex);

            }
            return asientos;
        }

        /// <summary>
        /// Buscars the boleto.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="fechasalida">The fechasalida.</param>
        /// <param name="horasalida">The horasalida.</param>
        /// <returns>List&lt;Ruta&gt;.</returns>
         public List<Ruta> BuscarBoleto(string cooperativa, string fechasalida, string horasalida) {
            List<Ruta> newlist = new List<Ruta>();
            Ruta generarInformacionBoleto = null;
            try {
                MySqlCommand mySqlCommand = ConectarProcedimiento("spl_LlenarVentanaCompra");
                mySqlCommand.Parameters.AddWithValue("@cooperativaFX", cooperativa);
                mySqlCommand.Parameters.AddWithValue("@horaSalidaFX", fechasalida);
                mySqlCommand.Parameters.AddWithValue("@fechaSalidaFX", Convert.ToDateTime(horasalida));
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read()) {
                    generarInformacionBoleto = new Ruta(
                    Convert.ToInt32(lector["Id_generearBoleto"].ToString()), Convert.ToInt32(lector["idBus"].ToString()), lector["salida"].ToString(), lector["FechaSalida"].ToString(), lector["destino"].ToString(),
                    lector["HoraSalida"].ToString(), lector["nombreCooperativa"].ToString(), lector["Disco"].ToString(), lector["CantidadAsiento"].ToString(), lector["Precio"].ToString()
                    );
                    
                    newlist.Add(generarInformacionBoleto);
                    
                }
                _con.cerrar();
            } catch (Exception ex) {
                MessageBox.Show("Error intentolo mas tarde" + ex);

            }
            return newlist;
        }

        /// <summary>
        /// Cargars the cooperativa.
        /// </summary>
        /// <param name="origen">The origen.</param>
        /// <param name="destino">The destino.</param>
        /// <returns>List&lt;System.String&gt;.</returns>
        public List<string> CargarCooperativa(string origen, string destino) {
            List<string> cooperativa = new List<string>();
            try {
                MySqlCommand mySqlCommand = ConectarProcedimiento("ProcesoBuscarCooperativa");
                mySqlCommand.Parameters.AddWithValue("@SalidaFx", origen);
                mySqlCommand.Parameters.AddWithValue("@SestinoFX", destino);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read()) {
                    cooperativa.Add(lector["nombreCooperativa"].ToString());
                }
                _con.cerrar();
            } catch (Exception ex) {
                MessageBox.Show("Error intentolo mas tarde" + ex);

            }
            return cooperativa;
        }

        /// <summary>
        /// Lllenars the data grid.
        /// </summary>
        /// <param name="origen">The origen.</param>
        /// <param name="destino">The destino.</param>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="dataGridInf">The data grid inf.</param>
        public void LllenarDataGrid(string origen, string destino, string cooperativa, DataGridView dataGridInf) {
            try {
                MySqlCommand mySqlCommand = ConectarProcedimiento("ProcesoLlenarDataGrid");
                mySqlCommand.Parameters.AddWithValue("@SalidaFx", origen);
                mySqlCommand.Parameters.AddWithValue("@DestinoFX", destino);
                mySqlCommand.Parameters.AddWithValue("@CooperativaFX", cooperativa);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read()) {
                    int numerofila = dataGridInf.Rows.Count;
                    dataGridInf.Rows.Add(1);
                    dataGridInf.Rows[numerofila].Cells[0].Value = lector["nombreCooperativa"].ToString();
                    dataGridInf.Rows[numerofila].Cells[1].Value = lector["HoraSalida"].ToString();
                    dataGridInf.Rows[numerofila].Cells[2].Value = lector["FechaSalida"];
                    dataGridInf.Rows[numerofila].Cells[3].Value = lector["Precio"].ToString();
                    dataGridInf.Rows[numerofila].Cells[4].Value = "Seleccionar...";
                }
                _con.cerrar();
            } catch (Exception ex) {
                 MessageBox.Show("Error intentolo mas tarde"+ex);
            }
        }
        /// <summary>
        /// Cargars the ciudad.
        /// </summary>
        /// <returns>List&lt;System.String&gt;.</returns>
        public List<string> CargarCiudad() {
            List<string> ciudad = new List<string>();
            try {
                MySqlCommand mySqlCommand = ConectarProcedimiento("ProcesoBusquedaCiudad"); 
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                    while (lector.Read()) {
                        ciudad.Add(lector["DescripcionCiudad"].ToString());
                    }
                _con.cerrar();
            } catch (Exception ex) {
                MessageBox.Show("Error intentolo mas tarde"+ex);

            }
            return ciudad;
        }

        /// <summary>
        /// Conectars the procedimiento.
        /// </summary>
        /// <param name="procedimientos">The procedimientos.</param>
        /// <returns>MySqlCommand.</returns>
        private MySqlCommand ConectarProcedimiento(string procedimientos) {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(procedimientos, _con.conectar());
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }

    }
}
