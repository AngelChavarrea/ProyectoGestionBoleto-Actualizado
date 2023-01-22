// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="RegistroVendedor.cs" company="">
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
    /// Class RegistroVendedor.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RegistroVendedor : Form
    {
        /// <summary>
        /// The cedula
        /// </summary>
        private string cedula;
        // Se llama al clase  RegistroClienteProcedimiento y se crea el objeto registroClienteProcedimiento para llamar a los metodos que contiene
        /// <summary>
        /// The adm
        /// </summary>
        AdmVendedor adm = new AdmVendedor();
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistroVendedor"/> class.
        /// </summary>
        /// <param name="cedula">The cedula.</param>
        public RegistroVendedor(string cedula)
        {
            this.cedula = cedula;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistroVendedor"/> class.
        /// </summary>
        public RegistroVendedor()
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
            string cedula = txtCedula.Text.Trim(), nombre = txtNombre.Text.Trim(), sexo = cmbSexo.Text.Trim(),
                    telefono = txtTelefono.Text.Trim(),sueldo= txtSueldo.Text, correo = txtCorreo.Text.Trim(),
                   contraseña = txtContraseña.Text.Trim();
            BorrarAlerta();
            try
            {
            // Al validar que los campos se llenaron correctamente se guarda el regitro y se envia al formulario cliente
                if (validar())
                {
                    CredencialUsuario credencial = new CredencialUsuario(correo, contraseña,5);
                    Vendedor vendedor = new Vendedor(cedula, nombre, sexo, telefono, Convert.ToDouble(sueldo), credencial);
                   adm.RegistrarVendedor(vendedor);
                    MessageBox.Show("Registro de vendedor realizado con éxito");
                    Limpiar();
                    //this.Hide();
                   // InterfazCliente interfazCliente= new InterfazCliente();
                    //interfazCliente.Show();
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
                if (valida.ValidarCedula(txtCedula.Text) != true)
                {
                    campo = false;
                    errorProvider1.SetError(txtCedula, "Se esperaba 10 numeros.");
                }
                if (txtNombre.Text == "")
                {
                    campo = false;
                    errorProvider1.SetError(txtNombre, "Ingrese su nombre completo.");
                }
                if (valida.ValidarTelefono(txtTelefono.Text) != true)
                {
                    campo = false;
                    errorProvider1.SetError(txtTelefono, "Se esperaba 10 numeros.");
                }
                if (cmbSexo.SelectedIndex < 0)
                {
                    campo = false;
                    errorProvider1.SetError(cmbSexo, "Selecione un tipo de genero.");
                }
                if(valida.ValidarSueldo(txtSueldo.Text) != true)
                {
                errorProvider1.SetError(txtSueldo, "Ingrese el monto del sueldo.");
                }
                if (valida.validarEmail(txtCorreo.Text) != true)
                {
                    campo = false;
                    errorProvider1.SetError(txtCorreo, "Ingrese su correo electronico.");
                }
                if (txtContraseña.Text == "")
                {
                    campo = false;
                    errorProvider1.SetError(txtContraseña, "Ingrese una contraseña.");
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
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtSueldo, "");
            errorProvider1.SetError(cmbSexo, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtContraseña, "");
        }

        // Metodo limpiar elimina los datos de los texbox una vez que se ingreso el registro
        /// <summary>
        /// Limpiars this instance.
        /// </summary>
        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            cmbSexo.Text = null;
            txtTelefono.Clear();
            txtSueldo.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
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

        // El evento valida que el textBox solo reciba numeros 
        /// <summary>
        /// Handles the KeyPress event of the txtTelefono control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        // Se llama al metodo Close() para cerrar el formulario login y mostrar el formulario principal
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

        // El evento valida que el textBox solo reciba letras
        /// <summary>
        /// Handles the KeyPress event of the txtNombre control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) &&
                 (e.KeyChar != Convert.ToChar(Keys.Space)))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the txtCorreo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back))&& (e.KeyChar
               != Convert.ToChar(Keys.Space)&&(e.KeyChar != '@' && (e.KeyChar != '.'))&& !char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the txtSueldo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && (e.KeyChar !=Convert.ToChar(Keys.Back)) && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
