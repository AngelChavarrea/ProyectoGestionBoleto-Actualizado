
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios {
    /// <summary>
    /// Class Bus.
    /// </summary>
    public class Bus {
        /// <summary>
        /// The placa
        /// </summary>
        private string placa;
        /// <summary>
        /// The number disco
        /// </summary>
        private int numDisco;
        /// <summary>
        /// The asiento
        /// </summary>
        private int asiento;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bus" /> class.
        /// </summary>
        /// <param name="placa">The placa.</param>
        /// <param name="numDisco">The number disco.</param>
        /// <param name="asiento">The asiento.</param>
        public Bus() { }
        public Bus(string placa, int numDisco, int asiento) {
            this.placa = placa;
            this.numDisco = numDisco;
            this.asiento = asiento;
        }

        /// <summary>
        /// Gets or sets the placa.
        /// </summary>
        /// <value>The placa.</value>
        public string Placa { get => placa; set => placa = value; }
        /// <summary>
        /// Gets or sets the number disco.
        /// </summary>
        /// <value>The number disco.</value>
        public int NumDisco { get => numDisco; set => numDisco = value; }
        /// <summary>
        /// Gets or sets the asiento.
        /// </summary>
        /// <value>The asiento.</value>
        public int Asiento { get => asiento; set => asiento = value; }


    }
}
