using System;
using System.Collections.Generic;

namespace LogicaDeNegocios {
    public class AdmRuta {
        Ruta procedimientos = new Ruta();
        /// <summary>
        /// Registrars the ruta.
        /// </summary>
        /// <param name="ruta">The ruta.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool RegistrarRuta(Ruta ruta) {
            Ruta registrar = ruta;
            registrar.InsertarRuta(registrar);
            return true;
        }
    }
}
