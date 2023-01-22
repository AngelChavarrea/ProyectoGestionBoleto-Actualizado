
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios {
    /// <summary>
    /// Class Boleto.
    /// </summary>
    public class Boleto {
        /// <summary>
        /// The fecha salida
        /// </summary>
        private DateTime fechaSalida;
        /// <summary>
        /// The fecha emision
        /// </summary>
        private DateTime fechaEmision;
        /// <summary>
        /// The hora salida
        /// </summary>
        private string horaSalida;

        /// <summary>
        /// Initializes a new instance of the <see cref="Boleto" /> class.
        /// </summary>
        /// <param name="fechaSalida">The fecha salida.</param>
        /// <param name="fechaEmision">The fecha emision.</param>
        /// <param name="horaSalida">The hora salida.</param>
        public Boleto(DateTime fechaSalida, DateTime fechaEmision, string horaSalida) {
            this.fechaSalida = fechaSalida;
            this.fechaEmision = fechaEmision;
            this.horaSalida = horaSalida;
        }

        /// <summary>
        /// Gets or sets the fecha salida.
        /// </summary>
        /// <value>The fecha salida.</value>
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        /// <summary>
        /// Gets or sets the fecha emision.
        /// </summary>
        /// <value>The fecha emision.</value>
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        /// <summary>
        /// Gets or sets the hora salida.
        /// </summary>
        /// <value>The hora salida.</value>
        public string HoraSalida { get => horaSalida; set => horaSalida = value; }
    }
}
