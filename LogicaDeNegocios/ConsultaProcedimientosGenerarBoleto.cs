
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios {
    /// <summary>
    /// Class ConsultaProcedimientosGenerarBoleto.
    /// </summary>
    public class ConsultaProcedimientosGenerarBoleto {
        /// <summary>
        /// Se llama al clase  ProcedimientosPaginaprincipal y se crea el objeto procedimientos para llamar a los metodos que contiene
        /// The procedimientos
        /// </summary>
        ProcedimientosPaginaprincipal _procedimientos = new ProcedimientosPaginaprincipal();

        /// <summary>
        /// Se crea una lista GenerarInformacionBoleto llamada  generarInformacionBoleto llamando al metodo BuscarBoleto
        /// Generars the informacion boleto.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="fechasalida">The fechasalida.</param>
        /// <param name="horasalida">The horasalida.</param>
        /// <returns>List&lt;GenerarInformacionBoleto&gt;.</returns>
        public List<Ruta> generarInformacionBoleto(string cooperativa, string fechasalida, string horasalida) {
            List<Ruta> listaBoletosGenerados = new List<Ruta>();
            listaBoletosGenerados = _procedimientos.BuscarBoleto(cooperativa, fechasalida, horasalida);
            return listaBoletosGenerados;
            
        }

        // Se crea el metodo llamado LlenarComboAsientos para obtener el numero de asientos de un bus en particular
        /// <summary>
        /// Llenars the combo asientos.
        /// </summary>
        /// <param name="busId">The bus identifier.</param>
        /// <param name="cbNumeroAsientos">The cb numero asientos.</param>
        public void LlenarComboAsientos(int busId, ComboBox cbNumeroAsientos,int boletoID)
        {
            // Se crea una lista string llamada  NumeroAsiento en la que se almacenara los numeros de asientos de un bus en particular.
            List<string> numeroAsiento = _procedimientos.BuscarNumerosAsientos(busId, boletoID);
            if (numeroAsiento.Count != 0) {
                foreach (string asiento in numeroAsiento) {
                    cbNumeroAsientos.Items.Add(asiento);
                }
            }

        }
    }
}
