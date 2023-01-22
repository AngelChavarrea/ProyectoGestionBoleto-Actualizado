using System;
using Datos;
using MySqlConnector;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogicaDeNegocios {
    public class Pago {
        public  static int MNumeroboleto;
        private string _nombreConsumidor;
        private string _cedulaConsumidor;
        public Pago() { }
        private static List<string> _boleto = new List<string>();
        public static List<Pago> InfoBoleto = new List<Pago>();
        public Pago(string nombreConsumidor, string cedulaConsumidor) {
            this.CedulaConsumidor = cedulaConsumidor;
            this.NombreConsumidor = nombreConsumidor;
        }
        private string _cooperativa, _destino, _fechaSalida, _horaSalida, _lugarSalida, _numeroDisco;
        private double _precios;

        public string Destino { get => _destino; set => _destino = value; }
        public string FechaSalida { get => _fechaSalida; set => _fechaSalida = value; }
        public string HoraSalida { get => _horaSalida; set => _horaSalida = value; }
        public string LugarSalida1 { get => _lugarSalida; set => _lugarSalida = value; }
        public string NumeroDisco { get => _numeroDisco; set => _numeroDisco = value; }
        public double Precios { get => _precios; set => _precios = value; }
        public string NombreConsumidor { get => _nombreConsumidor; set => _nombreConsumidor = value; }
        public string CedulaConsumidor { get => _cedulaConsumidor; set => _cedulaConsumidor = value; }

        public string getCooperativa() {
            return _cooperativa;
        }

        public void setCooperativa(string cooperativa) {
            this._cooperativa = cooperativa;
        }
        public static List<string> getBoleto() {
            return _boleto;
        }
        public static bool pagarBoleto(int id_bus, string cedula_cliente, List<string> asientos) {
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            bool validacion = false;        
            try {
                MessageBoxButtons ob = MessageBoxButtons.YesNoCancel;
                DialogResult obj = MessageBox.Show("Desea confirmar el pago","Titulo",ob, MessageBoxIcon.Question);
                if (obj == DialogResult.Yes) {
                    int num = MNumeroboleto;
                    
                    while (num > 0) {
                        int x = 1;
                        MySqlCommand mySqlCommand = conector.ConectarProcedimiento("spl_pago", con.conectar());
                        mySqlCommand.Parameters.AddWithValue("@id_bus", id_bus);
                        mySqlCommand.Parameters.AddWithValue("@cedula_cliente", cedula_cliente);
                        mySqlCommand.Parameters.AddWithValue("@FechaActual", DateTime.Now);
                        foreach (Pago p in InfoBoleto) {         
                            if (x == num) {
                                mySqlCommand.Parameters.AddWithValue("@Nombre_comprador", p._nombreConsumidor);
                                mySqlCommand.Parameters.AddWithValue("@cedula_Comprador", p._cedulaConsumidor);
                            }
                            x++;
                        }
                        mySqlCommand.ExecuteNonQuery();
                        num--;
                    }
                    _boleto.Clear();
                    InfoBoleto.Clear();
                    MessageBox.Show("Se realizó el pago con éxito ");
                    validacion = true;
                }
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            } try {
                Conexion cono = new Conexion();
                foreach (string p in asientos) {
                    MySqlCommand mySqlCommand = conector.ConectarProcedimiento("InactivarAsientos", cono.conectar());
                    mySqlCommand.Parameters.AddWithValue("@asiento", p);
                    mySqlCommand.Parameters.AddWithValue("@Idboleto", id_bus);
                    mySqlCommand.ExecuteNonQuery();
                }
                
                cono.cerrar();
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            return validacion;
        }

        public static List<string> GuardarPdf() {
            List<string> list = new List<string>();
            string tablas = string.Empty;
            double precio=0;
            string cliente= string.Empty;
            Conexion con = new Conexion();
            ConectorDeProcedimientos conector = new ConectorDeProcedimientos();
            try {
                MySqlCommand mySqlCommand = conector.ConectarProcedimiento("ImprimirBoleto", con.conectar());
                mySqlCommand.Parameters.AddWithValue("@cantboleto", MNumeroboleto);
                MySqlDataReader lector = mySqlCommand.ExecuteReader();
                while (lector.Read()) {
                    tablas += "<tr>";
                    tablas += "<td>" + lector["Id_compra"].ToString() + "</td>";
                    tablas += "<td>" + lector["cooperativa"].ToString() + "</td>";
                    tablas += "<td>" + lector["Placa"].ToString() + "</td>";
                    tablas += "<td>" + lector["Cedula_Comprador"].ToString() + "</td>";
                    tablas += "<td>" + lector["Fecha_Salida"].ToString() + "</td>";
                    tablas += "<td>" + lector["HoraSalida"].ToString() + "</td>";
                    tablas += "<td>" + lector["Precio"].ToString() + "</td>";
                    tablas += "</tr>";
                    precio = precio + Convert.ToDouble(lector["Precio"]);
                    MNumeroboleto--;
                    cliente = lector["Nombre_cliente"].ToString();
                }
                list.Add(tablas);
                list.Add(Convert.ToString(precio));
                list.Add(cliente);
                con.cerrar();
            } catch (MySqlException ex) {
                Console.WriteLine("Error emitido por: " + ex);
            }
            return list;
        }
    }
}
