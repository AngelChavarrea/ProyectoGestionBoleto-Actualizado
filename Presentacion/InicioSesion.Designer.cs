// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="InicioSesion.Designer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Presentacion
{
    /// <summary>
    /// Class InicioSesion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class InicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NombreUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.Contrasenausuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.botonInicioSesion = new Guna.UI2.WinForms.Guna2Button();
            this.Fecha_Hora_Sistema = new System.Windows.Forms.Timer(this.components);
            this.TextoInicioSesion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreUsuario.DefaultText = "";
            this.NombreUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NombreUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NombreUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NombreUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NombreUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NombreUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NombreUsuario.Location = new System.Drawing.Point(264, 147);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.PasswordChar = '\0';
            this.NombreUsuario.PlaceholderText = "Correo electronico";
            this.NombreUsuario.SelectedText = "";
            this.NombreUsuario.Size = new System.Drawing.Size(200, 36);
            this.NombreUsuario.TabIndex = 0;
            // 
            // Contrasenausuario
            // 
            this.Contrasenausuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Contrasenausuario.DefaultText = "";
            this.Contrasenausuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Contrasenausuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Contrasenausuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Contrasenausuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Contrasenausuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Contrasenausuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Contrasenausuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Contrasenausuario.Location = new System.Drawing.Point(264, 215);
            this.Contrasenausuario.MaxLength = 9;
            this.Contrasenausuario.Name = "Contrasenausuario";
            this.Contrasenausuario.PasswordChar = '*';
            this.Contrasenausuario.PlaceholderText = "Contraseña";
            this.Contrasenausuario.SelectedText = "";
            this.Contrasenausuario.Size = new System.Drawing.Size(200, 36);
            this.Contrasenausuario.TabIndex = 1;
            // 
            // botonInicioSesion
            // 
            this.botonInicioSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.botonInicioSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.botonInicioSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.botonInicioSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.botonInicioSesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonInicioSesion.ForeColor = System.Drawing.Color.White;
            this.botonInicioSesion.Location = new System.Drawing.Point(264, 286);
            this.botonInicioSesion.Name = "botonInicioSesion";
            this.botonInicioSesion.Size = new System.Drawing.Size(200, 45);
            this.botonInicioSesion.TabIndex = 3;
            this.botonInicioSesion.Text = "LOGIN";
            this.botonInicioSesion.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Fecha_Hora_Sistema
            // 
            this.Fecha_Hora_Sistema.Enabled = true;
            // 
            // TextoInicioSesion
            // 
            this.TextoInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.TextoInicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextoInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoInicioSesion.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.TextoInicioSesion.Location = new System.Drawing.Point(264, 73);
            this.TextoInicioSesion.Name = "TextoInicioSesion";
            this.TextoInicioSesion.Size = new System.Drawing.Size(190, 33);
            this.TextoInicioSesion.TabIndex = 2;
            this.TextoInicioSesion.Text = "Inicio de sesión";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 394);
            this.Controls.Add(this.TextoInicioSesion);
            this.Controls.Add(this.botonInicioSesion);
            this.Controls.Add(this.Contrasenausuario);
            this.Controls.Add(this.NombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.Text = "InicioSeccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The nombre usuario
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox NombreUsuario;
        /// <summary>
        /// The contrasenausuario
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox Contrasenausuario;
        /// <summary>
        /// The boton inicio sesion
        /// </summary>
        private Guna.UI2.WinForms.Guna2Button botonInicioSesion;
        /// <summary>
        /// The fecha hora sistema
        /// </summary>
        private System.Windows.Forms.Timer Fecha_Hora_Sistema;
        /// <summary>
        /// The texto inicio sesion
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel TextoInicioSesion;
    }
}