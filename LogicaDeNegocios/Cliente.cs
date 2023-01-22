using System;
using Datos;
using MySqlConnector;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios {
    /// <summary>
    /// <br />
    /// </summary>
    /// Se crea la clase cliente que hereda de la clase persona

    public class Cliente: Persona {

        /// <summary>
        /// The credencial usuario
        /// </summary>
        private CredencialUsuario _credencialUsuario;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cliente" /> class.
        /// </summary>
        public Cliente()  { }
        // Se crea el constructor parametrizado y se invoca a base para hacer uso de la herencia

        /// <summary>
        /// Initializes a new instance of the <see cref="T:LogicaDeNegocios.Cliente" /> class.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="credencialUsuario">The credencial usuario.</param>
        public Cliente(string cedula, string nombre, string sexo, string telefono, CredencialUsuario credencialUsuario)
                       : base(cedula, nombre, sexo, telefono) {         

            this._credencialUsuario = credencialUsuario;
        }

        /// <summary>
        /// Gets or sets the credencial usuario.
        /// </summary>
        /// <value>The credencial usuario.</value>
        public CredencialUsuario CredencialUsuario { get => _credencialUsuario; set => _credencialUsuario = value; }

        /// <summary>
        /// Insertars the cliente.
        /// </summary>
        /// <param name="client">The client.</param>
        public void InsertarCliente(Cliente client) {
               
                Conexion con = new Conexion();
                /// Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
                ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
                try {
                    List<Cliente> listaNueva = new List<Cliente>();
                    listaNueva.Add(client);
                    MySqlCommand mySqlCommand = conector.ConectarProcedimiento("RegistroClienteGeneral", con.conectar());
                     foreach (Cliente cliente in listaNueva) {
                        mySqlCommand.Parameters.AddWithValue("@CedulaFx", cliente.Cedula);
                        mySqlCommand.Parameters.AddWithValue("@NombreFx", cliente.Nombre);
                        mySqlCommand.Parameters.AddWithValue("@SexoFx", cliente.Sexo);
                        mySqlCommand.Parameters.AddWithValue("@TelefonoFx", cliente.Telefono);
                        mySqlCommand.Parameters.AddWithValue("@CorreoFx", cliente.CredencialUsuario.Correo);
                        mySqlCommand.Parameters.AddWithValue("@ContrasenaFx", cliente.CredencialUsuario.Contrasena);
                        mySqlCommand.Parameters.AddWithValue("@Foreking_RolesUsuarioFx", cliente.CredencialUsuario.Rol);
                    }
                     mySqlCommand.ExecuteReader();
                     con.cerrar();
                } catch (MySqlException ex) {

                    Console.WriteLine(ex);
                }

            }

        internal static bool EliminarCliente(string cedula) {
            bool x = false;
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("EliminarCliente", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@CedulaFx", cedula);
                mySqlCommand.ExecuteNonQuery();
                x = true;
                con.cerrar();
            } catch (MySqlException ex) {
                Console.WriteLine("Error emitido por: " + ex);
            }
            return x;
        }

        /// <summary>
        /// Buscars the cliente.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <returns>List&lt;Cliente&gt;.</returns>
        public static Cliente BuscarClient(string cedula) {

            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            Cliente client = null;
            CredencialUsuario credencial = null;
            try {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_BuscarCliente", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@Cedula", cedula);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read()) {
                    credencial = new CredencialUsuario(lector["Correo"].ToString(), lector["Contrasena"].ToString(), 3);
                    client = new Cliente(lector["Cedula"].ToString(), lector["Nombre"].ToString(), lector["Sexo"].ToString(), 
                     lector["Telefono"].ToString(), credencial);
                }
                con.cerrar();
            } catch (MySqlException ex) {
                Console.WriteLine("Error emitido por: " + ex);
            }
            return client;
        }

        public List<Cliente> BuscarCliente(string dato) {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            Cliente client = null;
            CredencialUsuario credencial = null;
            List<Cliente> listCliente = new List<Cliente>();
            try {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("ConsultarCliente", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@DatoFx", dato);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read()) {
                    credencial = new CredencialUsuario(lector["Correo"].ToString(), lector["Contrasena"].ToString(), 0);
                    client = new Cliente(lector["Cedula"].ToString(), lector["Nombre"].ToString(), lector["Sexo"].ToString(), lector["Telefono"].ToString(), credencial);
                    listCliente.Add(client);
                }
                con.cerrar();
            } catch (MySqlException ex)  {
                Console.WriteLine("Error emitido por: "+ex);
            }
             return listCliente;
        }
        /// <summary>
        /// Actualizars the cliente.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string ActualizarCliente(string cedula, string telefono, string correo, string contrasena) {
            string mensaje = "";
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();

            try {
                MySqlCommand comando = conector.ConectarProcedimiento("spl_ModificarCliente", con.conectar());
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Cedula1", cedula);
                comando.Parameters.AddWithValue("@Telefono1", telefono);
                comando.Parameters.AddWithValue("@Correo1", correo);
                comando.Parameters.AddWithValue("@Contraseña1", contrasena);
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
