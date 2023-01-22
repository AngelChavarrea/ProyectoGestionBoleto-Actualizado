
using System;
using Datos;
using Guna.UI2.WinForms;
using MySqlConnector;

using System.Collections.Generic;

namespace LogicaDeNegocios {
    /// <summary>
    /// Class Cooperativa.
    /// </summary>
    public class Cooperativa
    {
        /// <summary>
        /// The propietario
        /// </summary>
        private string _propietario;
        /// <summary>
        /// The nombre cooperativa
        /// </summary>
        private string _nombreCooperativa;
        /// <summary>
        /// The ruc
        /// </summary>
        private string _ruc;
        /// <summary>
        /// The telefono
        /// </summary>
        private string _telefono;
        /// <summary>
        /// The credencial usuario
        /// </summary>
        private CredencialUsuario _credencialUsuario;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cooperativa" /> class.
        /// </summary>
        /// <param name="ruc">The ruc.</param>
        /// <param name="propietario">The propietario.</param>
        /// <param name="nombreCooperativa">The nombre cooperativa.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="credencialUsuario">The credencial usuario.</param>
        public Cooperativa(string ruc, string propietario, string nombreCooperativa, string telefono, 
                           CredencialUsuario credencialUsuario) {

            this._propietario = propietario;
            this._nombreCooperativa = nombreCooperativa;
            this._ruc = ruc;
            this._telefono = telefono;
            this._credencialUsuario = credencialUsuario;
        }
        public Cooperativa() { }
        /// <summary>
        /// Gets or sets the propietario.
        /// </summary>
        /// <value>The propietario.</value>
        public string Propietario { get => _propietario; set => _propietario = value; }
        /// <summary>
        /// Gets or sets the nombre cooperativa.
        /// </summary>
        /// <value>The nombre cooperativa.</value>
        public string NombreCooperativa { get => _nombreCooperativa; set => _nombreCooperativa = value; }
        /// <summary>
        /// llenea los combos para agregar boletos
        /// </summary>
        /// <param name="idCooperativa"></param>
        /// <param name="combo"></param>
        /// <param name="x"></param>
        internal void LLenarCombos(int idCooperativa, Guna2ComboBox combo,int x) {
           Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            if (x != 0) {
                Console.WriteLine("KKKKK"+x);
                try {
                    Console.WriteLine(idCooperativa + "" + x);
                    MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_Buscarbus", con.conectar());
                    mySqlCommand.Parameters.AddWithValue("@idCooperativa", idCooperativa);
                    mySqlCommand.Parameters.AddWithValue("@idRuta", x);
                    MySqlDataReader lector = mySqlCommand.ExecuteReader();

                    while (lector.Read()) {
                        Console.WriteLine("jjjjjjjjjjjjjjjjjjjjjjjj");
                        string anexar = lector["Placa"].ToString();
                        combo.Items.Add(anexar);
                        ;
                        ;
                    }
                    con.cerrar();
                } catch (MySqlException ex) {
                    Console.WriteLine("Error emitido por: " + ex);
                }
            } else {
                try {
                    MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_BuscarRutA", con.conectar());
                    mySqlCommand.Parameters.AddWithValue("@idCooperativa", idCooperativa);
                    MySqlDataReader lector = mySqlCommand.ExecuteReader();

                    while (lector.Read()) {
                        string anexar = lector["idRuta"].ToString() + ")  De: " + lector["Salida"].ToString() + "  A: " + lector["Destino"].ToString(); ;
                        combo.Items.Add(anexar);
                    }
                    con.cerrar();
                } catch (MySqlException ex) {
                    Console.WriteLine("Error emitido por: " + ex);
                  }
            }
            
            
        }
        /// <summary>
        /// Busca la cooperativa
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        internal static List<string> buscarCoop(string v) {
            List<string> lista = new List<string>();
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("BuscarCoop", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@Dato", v);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read()) {
                    lista.Add(lector["id"].ToString());
                    lista.Add(lector["cooperativa"].ToString());
                    lista.Add(lector["Nombre"].ToString());
                }
                con.cerrar();
            } catch (MySqlException ex)
             {            
                Console.WriteLine(ex);
            }
            return lista;
        }
        /// <summary>
        /// Metodo generar boleto
        /// </summary>
        /// <param name="first"></param>
        /// <param name="placaBus"></param>
        /// <param name="fecha"></param>
        /// <param name="hora"></param>
        /// <param name="precio"></param>
        /// <returns></returns>
        internal bool GenerarBOleto(int first, string placaBus, string fecha, string hora, string precio) {
            bool validar = true;
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("InsertarRuta", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@idRuta", first) ;
                mySqlCommand.Parameters.AddWithValue("@placas", placaBus);
                mySqlCommand.Parameters.AddWithValue("@fecha", Convert.ToDateTime(fecha));
                mySqlCommand.Parameters.AddWithValue("@hora",hora);
                mySqlCommand.Parameters.AddWithValue("@Precios", Convert.ToDouble(precio));
                mySqlCommand.ExecuteReader();
                con.cerrar();
            } catch (MySqlException ex) {
                validar = false;
                Console.WriteLine(ex);
            }
            Conexion cone = new Conexion();
            try  {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("IngresarAsientos", cone.conectar());
                mySqlCommand.Parameters.AddWithValue("@placas", placaBus);
                mySqlCommand.ExecuteReader();
                cone.cerrar();
            } catch (MySqlException ex) {
                validar = false;
                Console.WriteLine(ex);
            }
            return validar;
        }

        /// <summary>
        /// Gets or sets the ruc.
        /// </summary>
        /// <value>The ruc.</value>
        public string Ruc { get => _ruc; set => _ruc = value; }
        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>The telefono.</value>
        public string Telefono { get => _telefono; set => _telefono = value; }
        /// <summary>
        /// Gets or sets the credencial usuario.
        /// </summary>
        /// <value>The credencial usuario.</value>
        public CredencialUsuario CredencialUsuario { get => _credencialUsuario; set => _credencialUsuario = value; }

        /// <summary>
        /// Insertars the cooperativa.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        public void InsertarCooperativa(Cooperativa cooperativa) {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try {
                List<Cooperativa> lista = new List<Cooperativa>();
                lista.Add(cooperativa);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_insertarCooperativa", con.conectar());
                foreach (Cooperativa coop in lista) {
                    mySqlCommand.Parameters.AddWithValue("@Ruc", coop.Ruc);
                    mySqlCommand.Parameters.AddWithValue("@Propietario", coop.Propietario);
                    mySqlCommand.Parameters.AddWithValue("@NombreCooperativa", coop.NombreCooperativa);
                    mySqlCommand.Parameters.AddWithValue("@Telefono", coop.Telefono);
                    mySqlCommand.Parameters.AddWithValue("@Correo", coop.CredencialUsuario.Correo);
                    mySqlCommand.Parameters.AddWithValue("@Contrasena", coop.CredencialUsuario.Contrasena);
                    mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuario", coop.CredencialUsuario.Rol);
                }
                mySqlCommand.ExecuteReader();
                con.cerrar();
            } catch (MySqlException ex) {

                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Buscars the cooperativa.
        /// </summary>
        /// <param name="idCooperativa">The cedula.</param>
        /// <returns>List&lt;Chofer&gt;.</returns>
        public static Cooperativa BuscarCooperativa(int idCooperativa) {

            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            Cooperativa cooperativa = null;
            CredencialUsuario credencial = null;
            try  {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_BuscarCooperativa", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@idCooperativa", idCooperativa);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read()) {
                    credencial = new CredencialUsuario(lector["Correo"].ToString(), lector["Contrasena"].ToString(), 3);
                    cooperativa = new Cooperativa(lector["Ruc"].ToString(), lector["Propietario"].ToString(), 
                    lector["NombreCooperativa"].ToString(), lector["Telefono"].ToString(), credencial);
                }
                con.cerrar();
            } catch (MySqlException ex) {
                Console.WriteLine("Error emitido por: " + ex);
            }
            return cooperativa;
        }

        /// <summary>
        /// Actualizars the cooperativa.
        /// </summary>
        /// <param name="ruc">The cedula.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string ActualizarCooperativa(string ruc, string telefono, string correo, string contrasena) {
            string mensaje = "";
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();

            try {
                MySqlCommand comando = conector.ConectarProcedimiento("spl_ModificarCooperativa", con.conectar());
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Ruc", ruc);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@Contraseña", contrasena);
                comando.ExecuteNonQuery();
                con.cerrar();
                mensaje = "Se actualizaron los campos correctamente";
            } catch (MySqlException ex) {

                mensaje = "Se ha producido un error al actualizar los datos" + ex;
            }
            return mensaje;
        }
    }
}
