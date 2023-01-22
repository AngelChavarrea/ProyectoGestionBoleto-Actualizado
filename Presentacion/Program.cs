using System;
using LogicaDeNegocios;
using Presentacion.InicioFroms;
using Presentacion.SGA_Administrador;
using Presentacion.SGA_Cooperativa;
using Presentacion.UsuarioCliente;
using System.Windows.Forms;

namespace Presentacion {
    /// <summary>
    /// Class Program.
    /// </summary>
    static class Program {
        /////
        /// <summary>
        /// The principal
        /// </summary>
        public static Principal_Usuario Principal = null;
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        [STAThread]
        static void Main() {
           Application.Run(Principal = new Principal_Usuario());
        }
    }
}
