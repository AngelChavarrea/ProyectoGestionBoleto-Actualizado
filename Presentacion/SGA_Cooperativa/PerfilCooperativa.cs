// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="PerfilCooperativa.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.SGA_Cooperativa
{
    /// <summary>
    /// Class PerfilCliente.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class PerfilCooperativa : Form
    {
        /// <summary>
        /// The adm cooperativa
        /// </summary>
        AdmCooperativa adm = new AdmCooperativa();
        /// <summary>
        /// Initializes a new instance of the <see cref="PerfilCooperativa"/> class.
        /// </summary>
        int idCooperativa;
        /// <param name="(idCooperativa">The identifier persona.</param>
        public PerfilCooperativa(int idCooperativa)
        {
           InitializeComponent();
            LlenarInformacion(idCooperativa);
            this.idCooperativa = idCooperativa;
        }

        /// <summary>
        /// Llenars the informacion.
        /// </summary>
        /// <param name="idPersona">The identifier persona.</param>
       private void LlenarInformacion(int idCooperativa)
        {
            List<Cooperativa> Cooperativa = adm.ConsultarCooperativa(idCooperativa);
           foreach(Cooperativa cooperativa in Cooperativa)
            {
                txtRuc.Text = cooperativa.Ruc;
                txtCoop.Text = cooperativa.NombreCooperativa;
                txtPropietario.Text = cooperativa.Propietario;
                txtTelefono.Text = cooperativa.Telefono;
                txtCorreo.Text = cooperativa.CredencialUsuario.Correo;
                txtPassword.Text = cooperativa.CredencialUsuario.Contrasena;
            }
            
        }
        private void EditarButon_Click(object sender, EventArgs e)
        {
            string ruc = txtRuc.Text.Trim(), nombre = txtNombre.Text, propietario = txtPropietario.Text, telefono = txtTelefono.Text.Trim(), correo = txtCorreo.Text.Trim(), contrasena = txtPassword.Text.Trim();
            BorrarAlerta();

            if (validar())
            {
                adm.Modificar(ruc, telefono, correo, contrasena);
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
