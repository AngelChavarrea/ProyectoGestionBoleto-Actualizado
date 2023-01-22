using System;
using System.Collections.Generic;

namespace LogicaDeNegocios {
    /// <summary>
    /// Class AdmClienteProcedimiento.
    /// </summary>
    public class AdmClienteProcedimiento {
        /// <summary>
        /// The procedimientos
        /// </summary>
        Cliente _procedimientos = new Cliente();
        /// <summary>
        /// Se crea el metodo Registrar cliente que guarda los datos de un nuevo <see cref="Cliente" />
        /// </summary>
        /// <param name="cliente">Datos del nuevo <see cref="Cliente" />.</param>
        /// <returns>Si el <see cref="Cliente" /> se registró correctamente devuelve <see cref="true" />,si no, devlueve <see cref="false" />.</returns>
        public bool RegistrarCliente(Cliente cliente) {
            Cliente clienteregistrar = cliente;
            clienteregistrar.InsertarCliente(clienteregistrar);
            return true;
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
            return _procedimientos.ActualizarCliente(cedula, telefono, correo, contrasena);
        }

        /// <summary>
        /// Consultars the cliente.
        /// </summary>
        /// <param name="Dato">The cedula.</param>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Cliente no registrado</exception>
       public List<Cliente> ConsultarCliente(string Dato ) {
            List<Cliente> client = null;
            if (String.IsNullOrEmpty(Dato)) {
                throw new ControlExcepcion("Campo vacio por favor rellenar");
            } else {
                if (Dato == "Iniciar_data_grid_datos") {
                    Dato = "";
                }
                client = _procedimientos.BuscarCliente(Dato);

                if (client.Count == 0) {
                    throw new ControlExcepcion("Cliente no encontrado");
                }
            }
            
            return client;
        }

        public List<Cliente> ConsultaClient(string cedula) {
            List<Cliente> lista = new List<Cliente>();
            Cliente client = Cliente.BuscarClient(cedula);
            lista.Add(client);
            return lista;
        }

        public void EliminarCliente(string cedula) {
            if (!Cliente.EliminarCliente(cedula)) {
                throw new ControlExcepcion("Error al eliminar intetar más tarde");
            }
        }
    }
}
