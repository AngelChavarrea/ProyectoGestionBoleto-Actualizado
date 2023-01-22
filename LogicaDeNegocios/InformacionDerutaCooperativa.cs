
using System;

namespace LogicaDeNegocios {
    // Se crea la clase InformacionDerutaCooperativa
    /// <summary>
    /// Class InformacionDerutaCooperativa.
    /// </summary>
    public class InformacionDerutaCooperativa {
        /// <summary>
        /// The cooperativa
        /// </summary>
        string _cooperativa;
        /// <summary>
        /// The hora salida
        /// </summary>
        DateTime _hora_salida;
        /// <summary>
        /// The precio
        /// </summary>
        double _precio;
        // Constructor parametrizado  
        /// <summary>
        /// Initializes a new instance of the <see cref="InformacionDerutaCooperativa" /> class.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="hora_salida">The hora salida.</param>
        /// <param name="precio">The precio.</param>
        public InformacionDerutaCooperativa(string cooperativa, DateTime hora_salida, double precio) {
            this._cooperativa = cooperativa;
            this._hora_salida = hora_salida;
            this._precio = precio;
        }

        // metodos getters y setters
        /// <summary>
        /// Gets or sets the cooperativa.
        /// </summary>
        /// <value>The cooperativa.</value>
        public string Cooperativa { get => _cooperativa; set => _cooperativa = value; }
        /// <summary>
        /// Gets or sets the hora salida.
        /// </summary>
        /// <value>The hora salida.</value>
        public DateTime Hora_salida { get => _hora_salida; set => _hora_salida = value; }
        /// <summary>
        /// Gets or sets the precio.
        /// </summary>
        /// <value>The precio.</value>
        public double Precio { get => _precio; set => _precio = value; }
    }
}
