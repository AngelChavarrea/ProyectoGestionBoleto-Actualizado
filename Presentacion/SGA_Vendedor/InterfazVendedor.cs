// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="InterfazCliente.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using FontAwesome.Sharp;
using LogicaDeNegocios;
using Presentacion.InicioFroms;
using Presentacion.SGA_Vendedor;
using Presentacion.UsuarioCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    /// <summary>
    /// Class InterfazCliente.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class InterfazVendedor : Form
    {
        /// <summary>
        /// The procedimientos
        /// </summary>
        ConsultasProcedimientos procedimientos = new ConsultasProcedimientos();
        /// <summary>
        /// The color botone seleccionado
        /// </summary>
        Color colorBotoneSeleccionado = Color.FromArgb(48, 88, 115);
        /// <summary>
        /// The color botone original
        /// </summary>
        Color colorBotoneOriginal = Color.FromArgb(241, 246, 249);
        /// <summary>
        /// The icon button
        /// </summary>
        IconButton iconButton;
        /// <summary>
        /// The identifier persona
        /// </summary>
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfazCliente"/> class.
        /// </summary>
        /// <param name="idPersona">The identifier persona.</param>
        public InterfazVendedor()
        {
            InitializeComponent();
            InicializarPanelConFromRutas();
        }

        /// <summary>
        /// Inicializars the panel con from rutas.
        /// </summary>
        private void InicializarPanelConFromRutas()
        {
            this.PanelContenedor.Controls.Clear();
            BuscarBus Frm = new BuscarBus("");
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            iconButton = Home;
            iconButton.BackColor = Color.FromArgb(154, 189, 213);
            iconButton.IconColor = colorBotoneSeleccionado;
            iconButton.ForeColor = colorBotoneSeleccionado;
        }
        /// <summary>
        /// Generars the nuevo color boton.
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void GenerarNuevoColorBoton(object sender)
        {
            iconButton = (IconButton)sender;
            iconButton.IconColor = colorBotoneSeleccionado;
            iconButton.ForeColor = colorBotoneSeleccionado;
            iconButton.BackColor = Color.FromArgb(154, 189, 213);
        }
        /// <summary>
        /// Restablecers the color original botones.
        /// </summary>
        private void RestablecerColorOriginalBotones()
        {
            iconButton.IconColor = colorBotoneOriginal;
            iconButton.ForeColor = colorBotoneOriginal;
            iconButton.BackColor = Color.FromArgb(66, 121, 158);
        }

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

        /// <summary>
        /// Handles the Click event of the CloseSesion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CloseSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar la sesión?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Program.Principal.Show();
            }        
            
        }

        /// <summary>
        /// Handles the Click event of the Home control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Home_Click(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            BuscarBus Frm = new BuscarBus("");
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }

        /// <summary>
        /// Handles the Click event of the EditPerfil control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EditPerfil_Click(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            string cedula = ProcedimientosPaginaprincipal.getCedula();
            PerfilVendedor Frm = new PerfilVendedor(cedula);
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }

        /// <summary>
        /// Handles the Click event of the History control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void History_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }

        /// <summary>
        /// Handles the Click event of the RutasFavoritas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RutasFavoritas_Click(object sender, EventArgs e)
        {
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }
    }
}
