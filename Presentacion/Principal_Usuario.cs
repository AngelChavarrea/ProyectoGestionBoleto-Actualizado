// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Principal_Usuario.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

using FontAwesome.Sharp;
using LogicaDeNegocios;
using Presentacion.InicioFroms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    /// <summary>
    /// Class Principal_Usuario.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Principal_Usuario : Form
    {
        Color colorBotoneSeleccionado = Color.FromArgb(48, 88, 115);
        Color colorBotoneOriginal = Color.FromArgb(241, 246, 249);
        /// <summary>
        /// Codigo para arrastrar la ventana a cualquier parte de la pantalla
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
        /// The icon button
        /// </summary>
        IconButton iconButton;
        /// <summary>
        /// Initializes a new instance of the <see cref="Principal_Usuario"/> class.
        /// </summary>
        public Principal_Usuario()
        {
            InitializeComponent();
            IniciarFromPrinciapl();
        }
        /// <summary>
        /// Iniciars from princiapl.
        /// </summary>
        private void IniciarFromPrinciapl()
        {
            BuscarBus Frm = new BuscarBus("");
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            iconButton = BotonHome;
            iconButton.ForeColor = colorBotoneSeleccionado;
            iconButton.IconColor = colorBotoneSeleccionado;
            iconButton.BackColor = Color.FromArgb(58, 200, 248);
        }

        /// <summary>
        /// Handles the Click event of the btnComprar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnComprar_Click(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            RegistroCliente Frm = new RegistroCliente();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
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
            iconButton.BackColor = Color.FromArgb(58, 200, 248);
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
        /// Handles the Click event of the BotonHome control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonHome_Click(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            BuscarBus Frm = new BuscarBus("");
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }
        /*-------------------------------------------------------------------------------------------------------*/
        /// <summary>
        /// Handles the 1 event of the BotonCierreDeAplicacion_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonCierreDeAplicacion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

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
        /// Se realiza el metodo para minimizar la aplicacion
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonParaMinimizarVentana_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Handles the 1 event of the BotonInicioSesion_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonInicioSesion_Click_1(object sender, EventArgs e)
        {
            this.PanelContenedor.Controls.Clear();
            InicioSesion Frm = new InicioSesion();
            Frm.TopLevel = false;
            PanelContenedor.Controls.Add(Frm);
            Frm.Show();
            RestablecerColorOriginalBotones();
            GenerarNuevoColorBoton(sender);
        }
    }
}
