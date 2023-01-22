
using System;
using System.Collections.Generic;

namespace LogicaDeNegocios {
    /// <summary>
    /// Class AdmVendedor.
    /// </summary>
    public class AdmVendedor {
        Vendedor procedimientos = new Vendedor();
        public List<Vendedor> ConsultarVendedor(string datoVendedor) {
            List<Vendedor> vendedor = null;
            if (String.IsNullOrEmpty(datoVendedor)) {
                throw new ControlExcepcion("Campo vacio por favor rellenar");
            } else {
                if (datoVendedor == "Iniciar_data_grid_datos") {
                    datoVendedor = "";
                }
                vendedor = procedimientos.BuscarVendedor(datoVendedor);

                if (vendedor.Count == 0) {
                    throw new ControlExcepcion("Vendedor no encontrado");
                }
            }

            return vendedor;
        }

        /// <summary>
        /// Registrars the vendedor.
        /// </summary>
        /// <param name="vendedor">The vendedor.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool RegistrarVendedor(Vendedor vendedor) {
            Vendedor registrar = vendedor;
            registrar.InsertarVendedor(registrar);
            return true;
        }
        /// <summary>
        /// Consultas the Vendedor.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        /// <returns>List&lt;Chofer&gt;.</returns>

        public List<Vendedor> ConsularVendedor(string cedula) {
            List<Vendedor> lista = new List<Vendedor>();
            Vendedor vendedor = null;
            vendedor = Vendedor.BuscarVended(cedula);
            lista.Add(vendedor);
            return lista;
        }

        /// <summary>
        /// Modificars the specified cedula.
        /// </summary>
        /// <param name="cedula">The telefono.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns>System.String.</returns>
        public string Modificar(string cedula, string telefono, string correo, string contrasena) {
            return procedimientos.ActualizarVendedor(cedula, telefono, correo, contrasena);
        }
        public void EliminarVendedor(string cedulaNombre) {
            if (!Vendedor.EliminarVendedor(cedulaNombre)) {
                throw new ControlExcepcion("Error al eliminar, intetar más tarde");
            }
        }
    }
}
