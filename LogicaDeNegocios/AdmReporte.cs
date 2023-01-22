using Datos;
using Guna.UI2.WinForms;
using MySqlConnector;
using System;

namespace LogicaDeNegocios {
    /// <summary>
    /// Class reporte
    /// </summary>
    public class AdmReporte {
        /// <summary>
        /// Metodo para realizar re´porte
        /// </summary>
        /// <param name="dataGridReporte"></param>
        /// <param name="idConsulta"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        public bool LlenarDatagridReporte(Guna2DataGridView dataGridReporte, int idConsulta,string dato) {
            DateTime tiempo = new DateTime(2022, 03, 13);
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            string consulta = "";
            switch (idConsulta) {
                case 1:  consulta = "BuscarReporteFecha"; 
                    tiempo = Convert.ToDateTime(dato);
                    break;
                case 2:  consulta = "BuscarReporteCooperativa";
                    break;
                case 3: consulta = "BuscarReporteCedula"; break;
                default: consulta = "BuscarReporte"; break;
            }

            try {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento(consulta, con.conectar());
                if (idConsulta==1) mySqlCommand.Parameters.AddWithValue("@Dato", tiempo);
               else mySqlCommand.Parameters.AddWithValue("@Dato", dato);
                    MySqlDataReader lector = mySqlCommand.ExecuteReader();
                     bool x = true;
                    while (lector.Read()) {
                        if (x) dataGridReporte.Rows.Clear();
                        int numerofila = dataGridReporte.Rows.Count;
                        dataGridReporte.Rows.Add(1);
                        dataGridReporte.Rows[numerofila].Cells[0].Value = lector["Id_compra"].ToString();
                        dataGridReporte.Rows[numerofila].Cells[1].Value = lector["Fecha_Compra"].ToString();
                        dataGridReporte.Rows[numerofila].Cells[2].Value = lector["Fecha_Salida"].ToString();
                        dataGridReporte.Rows[numerofila].Cells[3].Value = lector["Cedula_Comprador"].ToString();
                        dataGridReporte.Rows[numerofila].Cells[4].Value = lector["Cedula_cliente"].ToString();
                        dataGridReporte.Rows[numerofila].Cells[5].Value = lector["cooperativa"].ToString();
                        dataGridReporte.Rows[numerofila].Cells[6].Value = lector["HoraSalida"].ToString();
                        dataGridReporte.Rows[numerofila].Cells[7].Value = lector["Placa"].ToString();
                        x = false;
                }
                con.cerrar();
                if (x) {
                    throw new ControlExcepcion("No existe reporte");
                }
                return x;
            } catch {
                throw new ControlExcepcion("No existe reporte");
            }
        }
    }
}
