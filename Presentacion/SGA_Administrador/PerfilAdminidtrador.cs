// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="PerfilAdminidtrador.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.SGA_Administrador
{
    /// <summary>
    /// Class PerfilAdminidtrador.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class PerfilAdminidtrador : Form
    {
        /// <summary>
        /// The adm administrador
        /// </summary>
        AdmAdministrador admAdministrador = new AdmAdministrador();
        /// <summary>
        /// Initializes a new instance of the <see cref="PerfilAdminidtrador"/> class.
        /// </summary>
        /// <param name="idPersona">The identifier persona.</param>
        public PerfilAdminidtrador(int id)
        {
            InitializeComponent();
            LlenarInformacion(id);
        }

        /// <summary>
        /// Llenars the informacion.
        /// </summary>
        /// <param name="idPersona">The identifier persona.</param>
        private void LlenarInformacion(int id)
        {
            List<Administrador> Administrador = admAdministrador.ConsultaAdmin(id);
            foreach(Administrador admin in Administrador)
            {
                txtCedula.Text = admin.Cedula;
                txtName.Text = admin.Nombre;
                txtSexo.Text = admin.Sexo;
                txtTelefono.Text = admin.Telefono;
                txtCorreo.Text = admin.CredencialUsuario.Correo;
                txtContraseña.Text = admin.CredencialUsuario.Contrasena;
            }
            
        }
        /// <summary>
        /// Se validan los textbos que seran editados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditarButon_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim(), nombre = txtName.Text, sexo = txtSexo.Text, telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(), contrasena = txtContraseña.Text.Trim();
            BorrarAlerta();

            if (validar())
            {
                admAdministrador.Modificar(cedula, telefono, correo, contrasena);
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
            if (txtContraseña.Text == "")
            {
                campo = false;
                errorProvider1.SetError(txtContraseña, "Ingrese una contraseña.");
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
            errorProvider1.SetError(txtContraseña, "");
        }
    }
}
