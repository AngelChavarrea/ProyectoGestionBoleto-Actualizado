// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="RegistroChofer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

using LogicaDeNegocios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Presentacion
{
    /// <summary>
    /// Class RegistroRuta.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RegistroRuta : Form
    {
        /// <summary>
        /// The cedula
        /// </summary>
        /// <summary>
        /// The registro
        /// </summary>
        AdmRuta registro = new AdmRuta();

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


        /// <summary>
        /// Initializes a new instance of the <see cref="RegistroChofer"/> class.
        /// </summary>
        public RegistroRuta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the guna2Button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Metodo para guardar la informacion del registro de un cliente 
        /// <summary>
        /// Handles the Click event of the btnGuardar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id=0;
            string cooperativa = cbmCooperativa.Text, origen = txtOrigen.Text, destino = txtDestino.Text,
            disco = cmbDisco.Text.Trim(), asiento = cbAsiento.Text,
            precio = txtPrecio.Text;
            string fecha = dtFechasalida.Value.ToString("dd/MM/yyyy");
            //timePicker.Format = DateTimePickerFormat.Time.ToString("hh/mm/ss");
            //DateTime myDate = datePortionDateTimePicker.Value.Date +
            // timePortionDateTimePicker.Value.TimeOfDay;
           // timePortionDateTimePicker.ToString();
            string hora = dtHSalida.Value.Hour.ToString("HH:mm:ss");
            DateTimePickerFormat.Time.ToString("HH:mm:ss");
            // ToString("hh:mm:ss");
                     
            BorrarAlerta();
            try
            {
            // Al validar que los campos se llenaron correctamente se guarda el regitro y se envia al formulario cliente
                if (validar())
                {
                    Ruta registrar = new Ruta(id,2 ,origen, destino, cooperativa, disco,asiento, precio, fecha,  hora);
                    registro.RegistrarRuta(registrar);
                    MessageBox.Show("Registro de chofer realizado con éxito");
                    Limpiar();
                     Program.Principal.Hide();
                }
            }
            catch(ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // El metodo validar realiza la validacion de cada uno de los textBox y se muestra la alerta del campo que falta completar
        /// <summary>
        /// Validars this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Datos no validos!</exception>
        private bool validar() {
            Validacion valida = new Validacion();
            bool campo = true;
                if (cbmCooperativa.SelectedIndex < 0)
                {
                    campo = false;
                    errorProvider1.SetError(cbmCooperativa, "Seleccione una cooperativa.");
                }
                if (txtOrigen.Text == "")
                {
                    campo = false;
                    errorProvider1.SetError(txtOrigen, "Ingrese un lugar de origen.");
                }
                if (txtDestino.Text =="")
                {
                    campo = false;
                    errorProvider1.SetError(txtDestino, "Ingrese un lugar de destino.");
                }
                if (cbAsiento.SelectedIndex <0)
                {
                    campo = false;
                    errorProvider1.SetError(cbAsiento, "Seleccione un número de asiento.");
                }
                if (valida.ValidarSueldo(txtPrecio.Text) != true)
                {
                    errorProvider1.SetError(txtPrecio, "Ingrese un monto del pasaje.");
                }
                if (cmbDisco.SelectedIndex < 0)
                {
                    campo = false;
                    errorProvider1.SetError(cmbDisco, "Selecione un tipo de genero.");
                }
                if (!campo)
                {
                     throw new ControlExcepcion("Datos no validos!");
                }

            return campo;
        }
        // El metodo Borrar alerta elimina las alertas una vez que se lleno bien la informacion en el textbox
        /// <summary>
        /// Borrars the alerta.
        /// </summary>
        private void BorrarAlerta()
        {
            errorProvider1.SetError(cbmCooperativa, "");
            errorProvider1.SetError(txtOrigen, "");
            errorProvider1.SetError(txtPrecio, "");
            errorProvider1.SetError(txtDestino, "");
            errorProvider1.SetError(cmbDisco, "");
            errorProvider1.SetError(cbAsiento, "");
        }

        // Metodo limpiar elimina los datos de los texbox una vez que se ingreso el registro
        /// <summary>
        /// Limpiars this instance.
        /// </summary>
        public void Limpiar()
        {
            cbmCooperativa =null;
            txtDestino.Clear();
            txtOrigen.Clear();
            cmbDisco.Text = null;
            cbAsiento = null;
            txtPrecio.Clear();
        }

        /// <summary>
        /// Handles the Click event of the BotonParaMinimizarVentana control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonParaMinimizarVentana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Handles the Click event of the BotonRetroceder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.Principal.Show();
        }

      
    }
}
