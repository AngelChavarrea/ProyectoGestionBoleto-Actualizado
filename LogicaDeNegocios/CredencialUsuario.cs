
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios {
    /// <summary>
    /// Se crea la clase credencial con los atributos correo y contraseña.
    /// </summary>
    public class CredencialUsuario  {
        /// <summary>
        /// The correo
        /// </summary>
        private string _correo;
        /// <summary>
        /// The contrasena
        /// </summary>
        private string _contrasena;
        /// <summary>
        /// The rol
        /// </summary>
        private int _rol;
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public CredencialUsuario() { }

        /// <summary>
        /// Se crea el construcor parametrizando.
        /// </summary>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <param name="rol">The rol.</param>
        public CredencialUsuario(string correo, string contrasena, int rol) {
            this._correo = correo;
            this._contrasena = contrasena;
            this._rol = rol;
        }
        // Se crea los metodos getters y setters de la clase CredencialUsuario
        /// <summary>
        /// Gets or sets the correo.
        /// </summary>
        /// <value>The correo.</value>
        public string Correo { get => _correo; set => _correo = value; }
        /// <summary>
        /// Gets or sets the contrasena.
        /// </summary>
        /// <value>The contrasena.</value>
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        /// <summary>
        /// Gets or sets the rol.
        /// </summary>
        /// <value>The rol.</value>
        public int Rol { get => _rol; set => _rol = value; }
    }
}
