
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace LogicaDeNegocios {
    // se crea la clase validacion
    /// <summary>
    /// Class Validacion.
    /// </summary>
    public class Validacion {
        // Se crea el metodo ValidarCedula para que los numeros de cedula sean igual a 10 digitos
        /// <summary>
        /// Validars the cedula.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool ValidarCedula(string cedula) {
            bool x = true;
            if (cedula.Length != 10) {
                x = false;
            }
            return x;
        }

        // Se crea el metodo ValidarTelefono para que el numero de telefono para que permita solo ingresar 10 digitos
        /// <summary>
        /// Validars the telefono.
        /// </summary>
        /// <param name="telefono">The telefono.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool ValidarTelefono(string telefono) {
            bool campo = true;
            if (telefono.Length != 10) {
                campo = false;
            }
            return campo;
        }

        /// <summary>
        /// Validars the licencia.
        /// </summary>
        /// <param name="licencia">The licencia.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool ValidarLicencia(string licencia) {
            bool campo = true;
            if (licencia.Length != 10) {
                campo = false;
            }
            return campo;
        }
        /// <summary>
        /// Validars the cod acceso.
        /// </summary>
        /// <param name="codAcceso">The cod acceso.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool ValidarCodAcceso(string codAcceso) {
            bool campo = true;
            if (codAcceso.Length != 10) {
                campo = false;
            }
            return campo;
        }

        // Se crea el metodo validarEmail
        /// <summary>
        /// Validars the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool validarEmail(string email) {
            if (email == null) {
                return false;
            }
            if (new EmailAddressAttribute().IsValid(email) ) {
                return true;
            } else {

                return false;
            }
        }
        /// <summary>
        /// Validars the sueldo.
        /// </summary>
        /// <param name="sueldo">The sueldo.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool ValidarSueldo(string sueldo) {
            bool bandera = true;
            double valor = 0.0;
            try {
                valor = Double.Parse(sueldo);
                
            } catch(FormatException ex) {
                bandera = false;
                MessageBox.Show(ex.Message); 
            }
            return bandera;
        }
    }
}
