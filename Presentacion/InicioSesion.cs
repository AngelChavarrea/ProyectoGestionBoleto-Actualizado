// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="InicioSesion.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    /// <summary>
    /// Class InicioSesion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    public partial class InicioSesion : Form
    {
        /// <summary>
        /// The consulta
        /// </summary>
        ConsultasProcedimientos consulta = new ConsultasProcedimientos();
        /// <summary>
        /// Initializes a new instance of the <see cref="InicioSesion" /> class.
        /// </summary>
        public InicioSesion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the guna2Button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Usuario = NombreUsuario.Text;
            string password = Contrasenausuario.Text;
            try
            {
                if (ValidacionCamposVacios(Usuario, password))
                {
                    // Se hace uso del control de excepciones conde se llama a la clase ControlExcepcion, si el usuario no ingresa las credenciales 
                    try
                    {
                        ConsultarLoginBD(Usuario, password);
                    }
                    catch (ControlExcepcion ex)
                    {
                        // Se envia un aviso indicando que sus credenciales no son las correctas
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Contrasenausuario.Text = null;
                    }
                }
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        /// <summary>
        /// Consultars the login bd.
        /// </summary>
        /// <param name="correo">The correo.</param>
        /// <param name="password">The password.</param>
        private void ConsultarLoginBD(string correo, string password)
        {
            
            List<int> IdPeronsaAndRol = consulta.Login(correo, password);
            int rol = IdPeronsaAndRol[0];    
            if (rol != 0)
            {
                NombreUsuario.Text = null;
                Contrasenausuario.Text = null;
                Program.Principal.Hide();
                switch (rol)
                {
                    case 1:
                        int Idpersona = IdPeronsaAndRol[1];
                        VentanaAdministrador ventanaAdministrador = new VentanaAdministrador(Idpersona);
                        ventanaAdministrador.ShowDialog();
                        break;
                    case 2:
                        InterfazChofer v = new InterfazChofer();
                        v.ShowDialog();
                        break;
                    case 3:
                        int idCoop = IdPeronsaAndRol[1];
                        InterfazCooperativa c = new InterfazCooperativa(idCoop);
                        c.ShowDialog();
                        break;
                    case 4:
                        InterfazCliente cs = new InterfazCliente();   
                        cs.ShowDialog();
                        break;
                    case 5:
                        InterfazVendedor vendedor = new InterfazVendedor();
                        vendedor.ShowDialog();
                        break;
                }
            }
        }

        /*Metodo para validar si existen campos vacios*/
        /// <summary>
        /// Validacions the campos vacios.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <param name="password">The password.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="LogicaDeNegocios.ControlExcepcion">Campos vacios</exception>
        private bool ValidacionCamposVacios(string usuario, string password)
        {
            bool bandera;
            if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(password))
            {
                bandera = true;
            }
            else
            {
                throw new ControlExcepcion("Campos vacios");
            }
            return bandera;
        }
    }
}
