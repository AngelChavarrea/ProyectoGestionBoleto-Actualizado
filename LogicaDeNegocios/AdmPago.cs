using System;
using System.Collections.Generic;

namespace LogicaDeNegocios {
   public class AdmPago {
        /// <summary>
        /// Se realiza el medodo para obtener el total a pagar
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public double calcularTotalPagar(List<double> precio) {
            double totalPagar = 0;
            foreach(double p in precio) {
                totalPagar += p;
            }
            return totalPagar;
        }
    }
}
