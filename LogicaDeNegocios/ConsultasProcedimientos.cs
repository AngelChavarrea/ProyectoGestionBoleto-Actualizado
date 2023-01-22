
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios {
    /// <summary>
    /// Class ConsultasProcedimientos.
    /// </summary>
    public class ConsultasProcedimientos {
        // Se llama al clase  ProcedimientosPaginaprincipal y se crea el objeto procediminetos para llamar a los metodos que contiene
        /// <summary>
        /// The procedimientos
        /// </summary>
        ProcedimientosPaginaprincipal _procedimientos = new ProcedimientosPaginaprincipal();

        // Se crea el metodo para validar que el usuario y la contraseña sean autenticos y validos
        /// <summary>
        /// Logins the specified usuario.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <param name="password">The password.</param>
        /// <returns>List&lt;System.Int32&gt;.</returns>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Usuario y/o contrasena incorrecta</exception>
        public List<int> Login(string usuario, string password) {
            List<int> idPeronsaAndRol = _procedimientos.IniciasSeccion(usuario, password);
            if(idPeronsaAndRol.Count > 0) {
                MessageBox.Show("Inicio de sesión realizado con éxito.");
            } else {
                throw new ControlExcepcion("Usuario y/o contrasena incorrecta");
               
            }
            return idPeronsaAndRol;
        }
        /// <summary>
        /// Llenars the combos.
        /// </summary>
        /// <param name="cbOrigen">The cb origen.</param>
        /// <param name="cbDestino">The cb destino.</param>
        public void LlenarCombos(ComboBox cbOrigen, ComboBox cbDestino) {
            List<string> ciudad = new List<string>();
            ciudad = _procedimientos.CargarCiudad();
            if (ciudad.Count!=0)  {
                foreach (string ciudadfx in ciudad) {
                    cbOrigen.Items.Add(ciudadfx);
                    cbDestino.Items.Add(ciudadfx);
                }
            }

        }
        /// <summary>
        /// Llenars the combo cooperativa.
        /// </summary>
        /// <param name="cbCooperativa">The cb cooperativa.</param>
        /// <param name="origen">The origen.</param>
        /// <param name="destino">The destino.</param>
        public void LlenarComboCooperativa(ComboBox cbCooperativa, string origen, string destino) {
            List<string> coopeativa = new List<string>();
            string coop = string.Empty;
            coopeativa = _procedimientos.CargarCooperativa(origen,destino);
            if (coopeativa.Count != 0) {
                foreach (string coopeativafx in coopeativa) {
                    if (coopeativafx != coop) {
                        cbCooperativa.Items.Add(coopeativafx);
                        coop = coopeativafx;
                    }
                    
                }
            }
        }
        /// <summary>
        /// ls the lenar grit.
        /// </summary>
        /// <param name="origen">The origen.</param>
        /// <param name="destino">The destino.</param>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="dataGridInf">The data grid inf.</param>
        public void LLenarGrit(string origen, string destino, string cooperativa, DataGridView dataGridInf) {
            _procedimientos.LllenarDataGrid(origen, destino, cooperativa, dataGridInf);
        }
        /// <summary>
        /// Validars the data grid vacio.
        /// </summary>
        /// <param name="dataGridInf">The data grid inf.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Por favor seleccionar un horario!</exception>
        public bool ValidarDataGridVacio(DataGridView dataGridInf) {
            bool bandera = false;

            if (dataGridInf.SelectedRows.Count > 0) {
                bandera= true;
            } else {
                throw new ControlExcepcion(" Por favor seleccionar un horario!");
            }
            return bandera;
        }
    }
}
