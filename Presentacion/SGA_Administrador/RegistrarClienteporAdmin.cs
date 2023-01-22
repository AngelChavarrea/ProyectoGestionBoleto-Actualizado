// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="RegistrarClienteporAdmin.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.SGA_Administrador
{
    /// <summary>
    /// Class RegistrarClienteporAdmin.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RegistrarClienteporAdmin : Form
    {
        //private string cedula;
        /// <summary>
        /// The registro cliente procedimiento
        /// </summary>
        AdmClienteProcedimiento registroClienteProcedimiento = new AdmClienteProcedimiento();
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrarClienteporAdmin"/> class.
        /// </summary>
        public RegistrarClienteporAdmin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Borrars the alerta.
        /// </summary>
        private void BorrarAlerta()
        {
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(cmbSexo, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtContraseña, "");
        }
        /// <summary>
        /// Limpiars this instance.
        /// </summary>
        public void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            cmbSexo.Text = null;
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
        }
        /// <summary>
        /// Validars this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Datos no validos!</exception>
        private bool validar()
        {
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
        /// <summary>
        /// Handles the Click event of the btnGuardar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombre = txtNombre.Text.Trim(), sexo = cmbSexo.Text.Trim(),
                telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(),
                contraseña = txtContraseña.Text.Trim();
            BorrarAlerta();
            try
            {
                if (validar())
                {
                    CredencialUsuario credencial = new CredencialUsuario(correo, contraseña,4);
                    Cliente cliente = new Cliente(cedula, nombre, sexo, telefono, credencial);
                    registroClienteProcedimiento.RegistrarCliente(cliente);
                    MessageBox.Show("Registro realizado con exito");
                    Limpiar();         
                }
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the txtCedula control.
        ///  El evento valida que el textBox solo reciba solo numeros. 
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

        /// <summary>
        /// Handles the KeyPress event of the txtNombre control.
        /// El evento valida que el textBox solo reciba letras.
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
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) && (e.KeyChar
               != Convert.ToChar(Keys.Space) && (e.KeyChar != '@' && (e.KeyChar != '.')) && !char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the txtTelefono control.
        /// El evento valida que el textBox solo reciba numeros.
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
    }
}
