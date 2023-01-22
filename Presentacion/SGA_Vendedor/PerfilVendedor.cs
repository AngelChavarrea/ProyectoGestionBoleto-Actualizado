// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="PerfilChofer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.SGA_Vendedor
{
    /// <summary>
    /// Class PerfilVendedor.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class PerfilVendedor : Form
    {
        /// <summary>
        /// The adm Vendedor
        /// </summary>
        AdmVendedor adm = new AdmVendedor();
        /// <summary>
        /// Initializes a new instance of the <see cref="PerfilVendedor"/> class.
        /// </summary>
        /// <param name="(cedula">The identifier persona.</param>
        public PerfilVendedor(string cedula)
        {
            InitializeComponent();
            LlenarInformacion(cedula);

        }

        /// <summary>
        /// Llenars the informacion.
        /// </summary>
        /// <param name="cedula">The identifier persona.</param>
        private void LlenarInformacion(string cedula)
        {
            List<Vendedor> Vendedor = adm.ConsularVendedor(cedula);
            foreach (Vendedor vendedor in Vendedor)
            {
                txtCedula.Text = vendedor.Cedula;
                txtNom.Text = vendedor.Nombre;
                txtSexo.Text = vendedor.Sexo;
                txtTelefono.Text = vendedor.Telefono;
                txtCorreo.Text = vendedor.CredencialUsuario.Correo;
                txtPassword.Text = vendedor.CredencialUsuario.Contrasena;
            }

        }

        private void EditarButon_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombre = txtNombre.Text, sexo = txtSexo.Text, telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(), contrasena = txtPassword.Text.Trim();
            BorrarAlerta();

            if (validar())
            {
                adm.Modificar(cedula, telefono, correo, contrasena);
                MessageBox.Show("Datos actualizados con exito.");
            }
            else
            {
                MessageBox.Show("Existe un campo vacio");
            }
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

            if (valida.ValidarTelefono(txtTelefono.Text) != true)
            {
                campo = false;
                errorProvider1.SetError(txtTelefono, "Se esperaba 10 numeros.");
            }

            if (valida.validarEmail(txtCorreo.Text) != true)
            {
                campo = false;
                errorProvider1.SetError(txtCorreo, "Ingrese su correo electronico.");
            }
            if (txtPassword.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtPassword, "Ingrese una contraseña.");
            }
            if (!campo)
            {
                throw new ControlExcepcion("Datos no validos!");
            }

            if (!campo)
            {
                throw new ControlExcepcion("Datos no validos!");
            }
            return campo;
        }
        /// <summary>
        /// Borrars the alerta.
        /// </summary>
        private void BorrarAlerta()
        {
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtPassword, "");
        }
    }
}
