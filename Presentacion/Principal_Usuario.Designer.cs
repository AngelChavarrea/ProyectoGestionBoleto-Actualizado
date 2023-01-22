// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Principal_Usuario.Designer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Presentacion
{
    /// <summary>
    /// Class Principal_Usuario.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Principal_Usuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Usuario));
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonInicioSesion = new FontAwesome.Sharp.IconButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.botonRegistroUsuario = new FontAwesome.Sharp.IconButton();
            this.BotonHome = new FontAwesome.Sharp.IconButton();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.Fecha_Sistema = new System.Windows.Forms.Label();
            this.BotonParaMinimizarVentana = new FontAwesome.Sharp.IconPictureBox();
            this.BotonCierreDeAplicacion = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Hora_Sistema = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCierreDeAplicacion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.AutoSize = true;
            this.PanelContenedor.BackColor = System.Drawing.Color.White;
            this.PanelContenedor.Location = new System.Drawing.Point(217, 75);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(706, 392);
            this.PanelContenedor.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.panel2.Controls.Add(this.BotonInicioSesion);
            this.panel2.Controls.Add(this.guna2HtmlLabel2);
            this.panel2.Controls.Add(this.botonRegistroUsuario);
            this.panel2.Controls.Add(this.BotonHome);
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 392);
            this.panel2.TabIndex = 30;
            // 
            // BotonInicioSesion
            // 
            this.BotonInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.BotonInicioSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonInicioSesion.FlatAppearance.BorderSize = 0;
            this.BotonInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInicioSesion.ForeColor = System.Drawing.SystemColors.Info;
            this.BotonInicioSesion.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.BotonInicioSesion.IconColor = System.Drawing.Color.White;
            this.BotonInicioSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonInicioSesion.IconSize = 55;
            this.BotonInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonInicioSesion.Location = new System.Drawing.Point(0, 240);
            this.BotonInicioSesion.Name = "BotonInicioSesion";
            this.BotonInicioSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BotonInicioSesion.Size = new System.Drawing.Size(217, 120);
            this.BotonInicioSesion.TabIndex = 14;
            this.BotonInicioSesion.Text = "INICIAR SESION";
            this.BotonInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonInicioSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonInicioSesion.UseVisualStyleBackColor = false;
            this.BotonInicioSesion.Click += new System.EventHandler(this.BotonInicioSesion_Click_1);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(10, 371);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(195, 18);
            this.guna2HtmlLabel2.TabIndex = 13;
            this.guna2HtmlLabel2.Text = "Copyright © 2022 VIAJEROS S.A";
            // 
            // botonRegistroUsuario
            // 
            this.botonRegistroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.botonRegistroUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRegistroUsuario.FlatAppearance.BorderSize = 0;
            this.botonRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistroUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.botonRegistroUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.botonRegistroUsuario.IconColor = System.Drawing.Color.White;
            this.botonRegistroUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonRegistroUsuario.IconSize = 55;
            this.botonRegistroUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistroUsuario.Location = new System.Drawing.Point(0, 120);
            this.botonRegistroUsuario.Name = "botonRegistroUsuario";
            this.botonRegistroUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.botonRegistroUsuario.Size = new System.Drawing.Size(217, 120);
            this.botonRegistroUsuario.TabIndex = 11;
            this.botonRegistroUsuario.Text = "REGISTRATE";
            this.botonRegistroUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistroUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonRegistroUsuario.UseVisualStyleBackColor = false;
            this.botonRegistroUsuario.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // BotonHome
            // 
            this.BotonHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BotonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.BotonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonHome.FlatAppearance.BorderSize = 0;
            this.BotonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonHome.ForeColor = System.Drawing.SystemColors.Info;
            this.BotonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BotonHome.IconColor = System.Drawing.Color.White;
            this.BotonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonHome.Location = new System.Drawing.Point(0, 0);
            this.BotonHome.Name = "BotonHome";
            this.BotonHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BotonHome.Size = new System.Drawing.Size(217, 120);
            this.BotonHome.TabIndex = 12;
            this.BotonHome.Text = " PRINCIPAL";
            this.BotonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonHome.UseVisualStyleBackColor = false;
            this.BotonHome.Click += new System.EventHandler(this.BotonHome_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.PanelSuperior.Controls.Add(this.Fecha_Sistema);
            this.PanelSuperior.Controls.Add(this.BotonParaMinimizarVentana);
            this.PanelSuperior.Controls.Add(this.BotonCierreDeAplicacion);
            this.PanelSuperior.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(923, 35);
            this.PanelSuperior.TabIndex = 31;
            this.PanelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseMove);
            // 
            // Fecha_Sistema
            // 
            this.Fecha_Sistema.AutoSize = true;
            this.Fecha_Sistema.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Fecha_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fecha_Sistema.Location = new System.Drawing.Point(372, 11);
            this.Fecha_Sistema.Name = "Fecha_Sistema";
            this.Fecha_Sistema.Size = new System.Drawing.Size(60, 20);
            this.Fecha_Sistema.TabIndex = 2;
            this.Fecha_Sistema.Text = "LABEL";
            this.Fecha_Sistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonParaMinimizarVentana
            // 
            this.BotonParaMinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.BotonParaMinimizarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonParaMinimizarVentana.ForeColor = System.Drawing.Color.Yellow;
            this.BotonParaMinimizarVentana.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.BotonParaMinimizarVentana.IconColor = System.Drawing.Color.Yellow;
            this.BotonParaMinimizarVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonParaMinimizarVentana.IconSize = 34;
            this.BotonParaMinimizarVentana.Location = new System.Drawing.Point(840, 7);
            this.BotonParaMinimizarVentana.Name = "BotonParaMinimizarVentana";
            this.BotonParaMinimizarVentana.Size = new System.Drawing.Size(39, 34);
            this.BotonParaMinimizarVentana.TabIndex = 1;
            this.BotonParaMinimizarVentana.TabStop = false;
            this.BotonParaMinimizarVentana.Click += new System.EventHandler(this.BotonParaMinimizarVentana_Click_1);
            // 
            // BotonCierreDeAplicacion
            // 
            this.BotonCierreDeAplicacion.BackColor = System.Drawing.Color.Transparent;
            this.BotonCierreDeAplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCierreDeAplicacion.ForeColor = System.Drawing.Color.Yellow;
            this.BotonCierreDeAplicacion.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BotonCierreDeAplicacion.IconColor = System.Drawing.Color.Yellow;
            this.BotonCierreDeAplicacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonCierreDeAplicacion.IconSize = 37;
            this.BotonCierreDeAplicacion.Location = new System.Drawing.Point(855, 4);
            this.BotonCierreDeAplicacion.Name = "BotonCierreDeAplicacion";
            this.BotonCierreDeAplicacion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BotonCierreDeAplicacion.Size = new System.Drawing.Size(64, 37);
            this.BotonCierreDeAplicacion.TabIndex = 0;
            this.BotonCierreDeAplicacion.TabStop = false;
            this.BotonCierreDeAplicacion.Click += new System.EventHandler(this.BotonCierreDeAplicacion_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.guna2HtmlLabel9);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.Hora_Sistema);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 42);
            this.panel1.TabIndex = 32;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(99, 9);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(304, 20);
            this.guna2HtmlLabel9.TabIndex = 6;
            this.guna2HtmlLabel9.Text = "Sistema de Gestion de Boletos de AutoBuses";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Presentacion.Properties.Resources.pngtree_blue_big_car_illustration_cartoon_shuttle_blue_bus_gray_glass_png_image_4543102;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(66, 31);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Hora_Sistema
            // 
            this.Hora_Sistema.AutoSize = true;
            this.Hora_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_Sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Hora_Sistema.Location = new System.Drawing.Point(832, 9);
            this.Hora_Sistema.Name = "Hora_Sistema";
            this.Hora_Sistema.Size = new System.Drawing.Size(80, 24);
            this.Hora_Sistema.TabIndex = 1;
            this.Hora_Sistema.Text = "17:51:10";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.TopMost = true;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCierreDeAplicacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// The boton registro usuario
        /// </summary>
        private FontAwesome.Sharp.IconButton botonRegistroUsuario;
        /// <summary>
        /// The panel contenedor
        /// </summary>
        private System.Windows.Forms.Panel PanelContenedor;
        /// <summary>
        /// The panel2
        /// </summary>
        private System.Windows.Forms.Panel panel2;
        /// <summary>
        /// The panel superior
        /// </summary>
        private System.Windows.Forms.Panel PanelSuperior;
        /// <summary>
        /// The fecha sistema
        /// </summary>
        private System.Windows.Forms.Label Fecha_Sistema;
        /// <summary>
        /// The boton para minimizar ventana
        /// </summary>
        private FontAwesome.Sharp.IconPictureBox BotonParaMinimizarVentana;
        /// <summary>
        /// The boton cierre de aplicacion
        /// </summary>
        private FontAwesome.Sharp.IconPictureBox BotonCierreDeAplicacion;
        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The hora sistema
        /// </summary>
        private System.Windows.Forms.Label Hora_Sistema;
        /// <summary>
        /// The boton home
        /// </summary>
        private FontAwesome.Sharp.IconButton BotonHome;
        /// <summary>
        /// The guna2 HTML label2
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        /// <summary>
        /// The guna2 borderless form1
        /// </summary>
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        /// <summary>
        /// The guna2 picture box1
        /// </summary>
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        /// <summary>
        /// The timer1
        /// </summary>
        private System.Windows.Forms.Timer timer1;
        /// <summary>
        /// The guna2 HTML label9
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        /// <summary>
        /// The boton inicio sesion
        /// </summary>
        private FontAwesome.Sharp.IconButton BotonInicioSesion;
    }
}

