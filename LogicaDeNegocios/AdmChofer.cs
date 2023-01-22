
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios
{
    /// <summary>
    /// Class AdmChofer.
    /// </summary>
    public class AdmChofer
    {
        Chofer _procedimientos = new Chofer();
        /// <summary>
        /// Registrars the chofer.
        /// </summary>
        /// <param name="chofer">The chofer.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool RegistrarChofer(Chofer chofer) {
            Chofer registrar = chofer;
            registrar.InsertarChofer(registrar);
            return true;
        }
        /// <summary>
        /// Consultas the chofer.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <returns>List&lt;Chofer&gt;.</returns>

        public List<Chofer> ConsularChofer(string cedula) {
            List<Chofer> lista = new List<Chofer>();
            Chofer chofer = null;
            chofer = Chofer.BuscarChofer(cedula);
            lista.Add(chofer);
            return lista;
        }

        /// <summary>
        /// Modificars the specified cedula.
        /// </summary>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string Modificar(string cedula, string telefono, string correo, string contrasena) {
            return _procedimientos.ActualizarChofer(cedula, telefono, correo, contrasena);
        }

        public List<Chofer> ConsultarChofer(string datoVendedor) {
            List<Chofer> chofer = null;
            if (String.IsNullOrEmpty(datoVendedor)) {
                throw new ControlExcepcion("Campo vacio por favor rellenar");
            } else {
                if (datoVendedor == "Iniciar_data_grid_datos") {
                    datoVendedor = "";
                }
                chofer = _procedimientos.ConsultarChofer(datoVendedor);

                if (chofer.Count == 0) {
                    throw new ControlExcepcion("Vendedor no encontrado");
                }
            }

            return chofer;
        }

        public void EliminarChofer(string cedula) {
            if (!Chofer.EliminarChofer(cedula)) {
                throw new ControlExcepcion("Error al eliminar intetar más tarde");
            }
        }
    }
}
