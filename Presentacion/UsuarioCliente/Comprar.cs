// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Comprar.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using Presentacion.UsuarioCliente;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Presentacion.InicioFroms;

namespace Presentacion
{
    
    /// <summary>
    /// Class Comprar.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Comprar : Form
    {
        List<string> asientos = new List<string>();
        int idBusNuevo = 0;
        // Se llama al clase Validacion  y se crea el objeto validacion  para llamar a los metodos que contiene
        /// <summary>
        /// The validacion
        /// </summary>
        Validacion validacion = new Validacion();
        string boletos;
        private static List<Double> precio = new List<Double>();

        //public  List<GenerarInformacionBoleto> getBoleto()
        //{
        //    return boleto;
        //}

        //public  void setBoleto(string lugarSalida,string precio,string cooperativa,string lugardestino, string horaSalida,string fechaSalida,string numerodis,string numAsientos )
        //{
        //    boleto.Add(new GenerarInformacionBoleto(1,lugarSalida,fechaSalida,lugardestino,horaSalida,cooperativa,numerodis,precio));
        //}
        string cedula;

        public static List<Double> getPrecio()
        {
            return precio;
        }

        public static void setPrecio(double precios)
        {
            precio.Add(precios);
        }
        public static void VaciarLista()
        {
            precio.Clear();
        }




        // Se llama al clase ConsultaProcedimientosGenerarBoleto y se crea el objeto consultasProcedemientos para llamar a los metodos que contiene
        /// <summary>
        /// The consultas procedemientos
        /// </summary>
        ConsultaProcedimientosGenerarBoleto consultasProcedemientos = new ConsultaProcedimientosGenerarBoleto();
        /// <summary>
        /// The boletos nuveos
        /// </summary>
        List<string> boletosNuveos = new List<string>();


        /// <summary>
        /// Initializes a new instance of the <see cref="Comprar"/> class.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="fechaSalida">The fecha salida.</param>
        /// <param name="horaSalida">The hora salida.</param>
        public Comprar(string cooperativa, string fechaSalida, string horaSalida, string cedula)
        {
            InitializeComponent();
            /// Se llama al metodo en el constructor para que los datos se caguen de manera automatica al ingresar al formulario compra
            this.cedula = cedula;
            LlenarInformacionAutomaticamente(cooperativa, fechaSalida, horaSalida);        
        }

        // Se crea el metodo LlenarInformacionAutomaticamente que recibe como parametro cooperativa, fechaSalida, horaSalida, se crea una lista almacenada GenerarInformacionBoleto
        // llamada generarInformacionBoleto la cual se llena al llamar al metodo LlenarComboAsientos 
        /// <summary>
        /// Llenars the informacion automaticamente.
        /// </summary>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="fechaSalida">The fecha salida.</param>
        /// <param name="horaSalida">The hora salida.</param>
        private void LlenarInformacionAutomaticamente(string cooperativa, string fechaSalida, string horaSalida)
        {
           List<Ruta> generarInformacionBoleto = consultasProcedemientos.generarInformacionBoleto(cooperativa, fechaSalida, horaSalida);
            /// Se utiliza el bucle foreach para realizar la agregacion de los datos que poseee un boleto y el usuario pueda completar con sus datos para posterior a ello almacenadas dentro de la base de datos
            foreach (Ruta item in generarInformacionBoleto)
            {
                
                idBusNuevo = item.BoletoID;
                TxtCooperativa.Text = item.Cooperativa;
                TxtDestino.Text = item.Lugardestino;
                TxtFechaSalida.Text = item.FechaSalida;
                TxtHoraSalida.Text = item.HoraSalida;
                TxtLugarSalida.Text = item.LugarSalida;
                TxtNDisco.Text = item.Numerodico;
                TxtPrecio.Text = item.Precio;
                consultasProcedemientos.LlenarComboAsientos(item.BusId,CbNumeroAsientos, idBusNuevo);
            }
            
        }

        // Se realiza el evento tick para mostrar la fecha y hora actual en el sistema
        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha_Sistema.Text = DateTime.Now.ToLongDateString();
            Hora_Sistema.Text = DateTime.Now.ToLongTimeString();
        }

        // Se llama al metodo Exit para cerrar la aplicacion y se muestra un mensaje de alerta para confirmar el cierre de la aplicacion
        /// <summary>
        /// Handles the Click event of the BotonCierreDeAplicacion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonCierreDeAplicacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                Program.Principal.Show();
            }
        }


        // Se realiza el metodo para minimizar la aplicacion 
        /// <summary>
        /// Handles the Click event of the BotonParaMinimizarVentana control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonParaMinimizarVentana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /*Codigo para arrastrar la ventana a cualquier parte de la pantalla*/
        /// <summary>
        /// Releases the capture.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="hwnd">The HWND.</param>
        /// <param name="wmsg">The WMSG.</param>
        /// <param name="wparam">The wparam.</param>
        /// <param name="lparam">The lparam.</param>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /// <summary>
        /// Handles the MouseMove event of the PanelSuperior control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void PanelSuperior_MouseMove(object sender, MouseEventArgs e)
        {       
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Se llama al metodo Close() para cerrar el formulario login y mostrar el formulario principal
        /// <summary>
        /// Handles the Click event of the BotonRetroceder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            if (cedula == "")
            {
                this.Close();
                Program.Principal.Show();
            }
            else
            {
                this.Close();
            }
            
        }

       // string j ="";
        // Se realiza el metodo LLenarInformacionBoletoCarro para agregar la compra de un boleto  
        private void LLenarInformacionBoletoCarro()
        {            
            boletos += Environment.NewLine + "-----------------------------------" + Environment.NewLine + "Cedula: " + txtCedula.Text + Environment.NewLine + "Nombre: " + TxtNombre.Text + Environment.NewLine
            + "Cooperativa: " + TxtCooperativa.Text + Environment.NewLine + "Hora Salida: " + TxtHoraSalida.Text + Environment.NewLine
            + "Fecha Salida: " + TxtFechaSalida.Text + Environment.NewLine + "Disco del bus: " + TxtNDisco.Text + Environment.NewLine
            + "Asiento:" + CbNumeroAsientos.Text + Environment.NewLine + "Precio Unitario: "+TxtPrecio.Text;           
            boletosNuveos.Add(CbNumeroAsientos.Text);
            setPrecio(Convert.ToDouble(TxtPrecio.Text));
            Pago.InfoBoleto.Add(new Pago(TxtNombre.Text, txtCedula.Text));
            // Pago.setBoleto(new Pago(TxtCooperativa.Text, TxtDestino.Text, TxtFechaSalida.Text, TxtHoraSalida.Text,TxtLugarSalida.Text, TxtNDisco.Text,Convert.ToDouble(TxtPrecio.Text)));           
        }

        // Se crea el metodo VaciarCampos para limpiar los campos que seran ingresados por el cliente
        /// <summary>
        /// Vaciars the campos.
        /// </summary>
        private void VaciarCampos()
        {
            txtCedula.Text = null;
            TxtNombre.Text = null;
            CbNumeroAsientos.Items.Remove(CbNumeroAsientos.Text);
        }

        // Se crea el metodo CambiarTextoCarrito para agreagar la informacion por cada boleto y aumentar la cantidad de boletos con un contador 
        /// <summary>
        /// Cambiars the texto carrito.
        /// </summary>
        private void CambiarTextoCarrito()
        {
            int valor = Convert.ToInt32(CarritoBtn.Text);
            valor += 1;
            CarritoBtn.Text = Convert.ToString(valor);
        }

        // Metodo para validar que no hayan campos vacios en el fromulario.
        /// <summary>
        /// Verificars the campos vacios.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Campos invalidos!</exception>
        private bool verificarCamposVacios()
        {
            bool campo = false;
            if(validacion.ValidarCedula(txtCedula.Text)!= true ||  String.IsNullOrEmpty(TxtNombre.Text)  ||  String.IsNullOrEmpty(CbNumeroAsientos.Text))
            {
                campo = true;
                throw new ControlExcepcion(" Campos invalidos!");
            }
            return campo;
        }

        // se crea el metodo para agregar la compra de un boleto
        /// <summary>
        /// Handles the Click event of the guna2Button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!verificarCamposVacios())
                {
                    CambiarTextoCarrito();
                    LLenarInformacionBoletoCarro();
                    asientos.Add(CbNumeroAsientos.Text);
                    VaciarCampos();
                }
            }
            catch(ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        // Se crea el metodo para mostrar la informacion almacenada en el carrito
        /// <summary>
        /// Handles the Click event of the CarritoBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CarritoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCarrito())
                {
                    Pago.MNumeroboleto = Convert.ToInt32(CarritoBtn.Text);  
                    Pagar pagar = new Pagar(boletos, idBusNuevo, cedula,asientos);
                    BuscarBus.Ventana_ventaBoletos.Hide();
                    pagar.ShowDialog();  
                }
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // Se crea el metodo ValidarCarrito para mostrar la informacion si no se agregado ningunboleto se lanza la excepcion
        /// <summary>
        /// Validars the carrito.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">No hay boletos agregados al carrito</exception>
        private bool ValidarCarrito()
        {
            bool bandera = true;
            if (Convert.ToInt32(CarritoBtn.Text) == 0)
            {
                bandera = false;
                throw new ControlExcepcion("No hay boletos agregados al carrito");
            }
            return bandera;
        }

        // El evento valida que el textBox solo reciba numeros 
        /// <summary>
        /// Handles the KeyPress event of the txtCedula control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        // El evento valida que el textBox solo reciba letras
        /// <summary>
        /// Handles the KeyPress event of the TxtNombre control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) &&
                 (e.KeyChar != Convert.ToChar(Keys.Space)))
            {
                e.Handled = true;
                return;
            }
        }

    }
}
