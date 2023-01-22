
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios {
    /// <summary>
    /// Class AdmAdministrador.
    /// </summary>
    public class AdmAdministrador {
        /// <summary>
        /// Registrar administrador.
        /// </summary>
        /// <param name="admin">The admin.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Administrador _admin = new Administrador();
        public bool RegistrarAdministrador(Administrador admin) {
            Administrador registrar = admin;
            registrar.InsertarAdministrador(registrar);
            return true;
        }
        /// <summary>
        /// Consultas the admin.
        /// </summary>
        /// <param name="idPersona">La persona identificadora.</param>
        /// <returns>List&lt;Administrador&gt;.</returns>
        public List<Administrador> ConsultaAdmin(int id) {
            List<Administrador> newLista = new List<Administrador>();
            Administrador admin = null;
            admin = Administrador.ConsultarAdministrador(id);
            newLista.Add(admin);
            return newLista;
        }

        /// <summary>
        /// Modificars the specified cedula.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string Modificar(string cedula, string telefono, string correo, string contrasena) {
            return _admin.ActualizarAdministrador(cedula, telefono, correo, contrasena);
        }
    }
}
