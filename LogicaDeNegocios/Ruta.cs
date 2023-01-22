using System;
using Datos;
using MySqlConnector;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    // Se crea la clase  Ruta
    /// <summary>
    /// Class Ruta.
    /// </summary>
    public class Ruta {
        // Atributos
        /// <summary>
        /// The bus identifier
        /// </summary>
        int _busId;
        /// <summary>
        /// The lugar salida
        /// </summary>
        string _lugarSalida;
        /// <summary>
        /// The fecha salida
        /// </summary>
        string _fechaSalida;
        /// <summary>
        /// The lugardestino
        /// </summary>
        string _lugardestino;
        /// <summary>
        /// The hora salida
        /// </summary>
       string _horaSalida;
        /// <summary>
        /// The cooperativa
        /// </summary>
       string _cooperativa;
        /// <summary>
        /// The numerodico
        /// </summary>
         string _asiento;
        /// <summary>
        /// The numerodico
        /// </summary>
         string _numerodico;
        /// <summary>
        /// The precio
        /// </summary>
       string _precio;
        int _boletoID;
        // se crea el constructor parametrizado
        /// <summary>
        /// Initializes a new instance of the <see cref="Ruta" /> class.
        /// </summary>
        /// <param name="busId">The bus identifier.</param>
        /// <param name="lugarSalida">The lugar salida.</param>
        /// <param name="fechaSalida">The fecha salida.</param>
        /// <param name="lugardestino">The lugardestino.</param>
        /// <param name="horaSalida">The hora salida.</param>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="asiento">The numerodico.</param>
        /// <param name="numerodico">The numerodico.</param>
        /// <param name="precio">The precio.</param>
        
        public Ruta(int boletoID, int busId, string lugarSalida, string fechaSalida, string lugardestino, 
                    string horaSalida, string cooperativa, string numerodico, string asiento, string precio) {
            this._boletoID = boletoID;
            this._busId= busId;
            this._lugarSalida = lugarSalida;
            this._fechaSalida = fechaSalida;
            this._lugardestino = lugardestino;
            this._horaSalida = horaSalida;
            this._cooperativa = cooperativa;
            this._asiento = asiento;
            this._numerodico = numerodico;
            this._precio = precio;
        }
        public Ruta() { }
        // Se crean los metodos getters y setters
        /// <summary>
        /// Gets or sets the lugar salida.
        /// </summary>
        /// <value>The lugar salida.</value>
        public string LugarSalida { get => _lugarSalida; set => _lugarSalida = value; }
        /// <summary>
        /// Gets or sets the fecha salida.
        /// </summary>
        /// <value>The fecha salida.</value>
        public string FechaSalida { get => _fechaSalida; set => _fechaSalida = value; }
        /// <summary>
        /// Gets or sets the lugardestino.
        /// </summary>
        /// <value>The lugardestino.</value>
        public string Lugardestino { get => _lugardestino; set => _lugardestino = value; }
        /// <summary>
        /// Gets or sets the hora salida.
        /// </summary>
        /// <value>The hora salida.</value>
        public String HoraSalida { get => _horaSalida; set => _horaSalida = value; }
        /// <summary>
        /// Gets or sets the cooperativa.
        /// </summary>
        /// <value>The cooperativa.</value>
        public string Cooperativa { get => _cooperativa; set => _cooperativa = value; }
        /// <summary>
        /// Gets or sets the numerodico.
        /// </summary>
        /// <value>The numerodico.</value>
        public string Numerodico { get => _numerodico; set => _numerodico = value; }
        /// <summary>
        /// Gets or sets the precio.
        /// </summary>
        /// <value>The precio.</value>
        public String Precio { get => _precio; set => _precio = value; }
        /// <summary>
        /// Gets or sets the bus identifier.
        /// </summary>
        /// <value>The bus identifier.</value>
        public int BusId { get => _busId; set => _busId = value; }
        public string Asiento { get => _asiento; set => _asiento = value; }
        public int BoletoID { get => _boletoID; set => _boletoID = value; }
        Bus _bus = new Bus();
        /// <summary>
        /// Para insertar nueva ruta
        /// </summary>
        /// <param name="ruta"></param>
        public void InsertarRuta(Ruta ruta) {
            Conexion con = new Conexion();
            /// Se llama a la clase  ConectorDeProcedimientos y se crea el objeto conector que permite realizar el procedimiento de inserta un nuevo cliente
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try {
                List<Ruta> lista = new List<Ruta>();
                lista.Add(ruta);
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_insertarRuta", con.conectar());
                foreach (Ruta ruta in lista) {
                    mySqlCommand.Parameters.AddWithValue("@Cooperativa", ruta.Cooperativa);
                    mySqlCommand.Parameters.AddWithValue("@NumeroDisco", ruta.Numerodico);
                    mySqlCommand.Parameters.AddWithValue("@lugarOrigen", ruta.LugarSalida);
                    mySqlCommand.Parameters.AddWithValue("@lugarDestino", ruta.Lugardestino);
                    mySqlCommand.Parameters.AddWithValue("@horaSalida", ruta.HoraSalida);
                    mySqlCommand.Parameters.AddWithValue("@NumAsiento", ruta.Asiento);
                    mySqlCommand.Parameters.AddWithValue("@Precio", ruta.Precio);

                }
                mySqlCommand.ExecuteReader();
                con.cerrar();
            } catch (MySqlException ex) {

                Console.WriteLine(ex);
            }

        }
    }
}
