
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios {
    /// <summary>
    /// Se crea la clase persona con cuatro atributos
    /// </summary>
    public class Persona {
        /// <summary>
        /// The cedula
        /// </summary>
        private string _cedula;
        /// <summary>
        /// The nombre
        /// </summary>
        private string _nombre;
        /// <summary>
        /// The sexo
        /// </summary>
        private string _sexo;
        /// <summary>
        /// The telefono
        /// </summary>
        private string _telefono;

        /// <summary>
        /// Se crea el costructor por defecto
        /// </summary>
        public Persona() { }
        /// <summary>
        /// Se crea el costructor de la clase persona parametrizado
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="sexo">The sexo.</param>
        /// <param name="telefono">The telefono.</param>
        public Persona(string cedula, string nombre, string sexo, string telefono) {
            this._cedula = cedula;
            this._nombre = nombre;
            this._sexo = sexo;
            this._telefono = telefono;

         }
        // Se crea los metodos getters y setters
        /// <summary>
        /// Gets or sets the cedula.
        /// </summary>
        /// <value>The cedula.</value>
        public string Cedula { get => _cedula; set => _cedula = value; }
        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>The nombre.</value>
        public string Nombre { get => _nombre; set => _nombre = value; }
        /// <summary>
        /// Gets or sets the sexo.
        /// </summary>
        /// <value>The sexo.</value>
        public string Sexo { get => _sexo; set => _sexo = value; }
        /// <summary>
        /// Gets or sets the telefono.
        /// </summary>
        /// <value>The telefono.</value>
        public string Telefono { get => _telefono; set => _telefono = value; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() {
            return "Cedula: " + _cedula + "Nombre: " + _nombre + "Sexo: " + _sexo + "Telefono: " + _telefono;

        }
    }
}
