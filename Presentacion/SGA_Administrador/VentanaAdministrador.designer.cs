// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="VentanaAdministrador.designer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

using Presentacion;

namespace Presentacion
{
    /// <summary>
    /// Class VentanaAdministrador.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class VentanaAdministrador
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
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.Fecha_Sistema = new System.Windows.Forms.Label();
            this.BotonParaMinimizarVentana = new FontAwesome.Sharp.IconPictureBox();
            this.BotonCierreDeAplicacion = new FontAwesome.Sharp.IconPictureBox();
            this.GneralPanelOpciones = new Guna.UI2.WinForms.Guna2Panel();
            this.Exit = new FontAwesome.Sharp.IconButton();
            this.Reporte = new FontAwesome.Sharp.IconButton();
            this.PanelEliminar = new Guna.UI2.WinForms.Guna2Panel();
            this.EliminarVendedor = new FontAwesome.Sharp.IconButton();
            this.EliminarChofer = new FontAwesome.Sharp.IconButton();
            this.EliminarCooperativa = new FontAwesome.Sharp.IconButton();
            this.EliminarCliente = new FontAwesome.Sharp.IconButton();
            this.Eliminar = new FontAwesome.Sharp.IconButton();
            this.PanelRegistro = new Guna.UI2.WinForms.Guna2Panel();
            this.Vendedor = new FontAwesome.Sharp.IconButton();
            this.Chofer = new FontAwesome.Sharp.IconButton();
            this.RegistrarCooperativa = new FontAwesome.Sharp.IconButton();
            this.RegistrarCliente = new FontAwesome.Sharp.IconButton();
            this.BotonregistrasAdmin = new FontAwesome.Sharp.IconButton();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Hora_Sistema = new System.Windows.Forms.Label();
            this.Fecha_Hora_Sistema = new System.Windows.Forms.Timer(this.components);
            this.PanelPrincipalContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.Salir = new FontAwesome.Sharp.IconButton();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCierreDeAplicacion)).BeginInit();
            this.GneralPanelOpciones.SuspendLayout();
            this.PanelEliminar.SuspendLayout();
            this.PanelRegistro.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.PanelPrincipalContenedor.SuspendLayout();
            this.SuspendLayout();
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
            this.PanelSuperior.Size = new System.Drawing.Size(919, 35);
            this.PanelSuperior.TabIndex = 0;
            this.PanelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseMove);
            // 
            // Fecha_Sistema
            // 
            this.Fecha_Sistema.AutoSize = true;
            this.Fecha_Sistema.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Fecha_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Sistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
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
            this.BotonParaMinimizarVentana.Click += new System.EventHandler(this.BotonParaMinimizarVentana_Click);
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
            this.BotonCierreDeAplicacion.Location = new System.Drawing.Point(874, 5);
            this.BotonCierreDeAplicacion.Name = "BotonCierreDeAplicacion";
            this.BotonCierreDeAplicacion.Size = new System.Drawing.Size(38, 37);
            this.BotonCierreDeAplicacion.TabIndex = 0;
            this.BotonCierreDeAplicacion.TabStop = false;
            this.BotonCierreDeAplicacion.Click += new System.EventHandler(this.BotonCierreDeAplicacion_Click);
            // 
            // GneralPanelOpciones
            // 
            this.GneralPanelOpciones.AutoScroll = true;
            this.GneralPanelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.GneralPanelOpciones.Controls.Add(this.Exit);
            this.GneralPanelOpciones.Controls.Add(this.Reporte);
            this.GneralPanelOpciones.Controls.Add(this.PanelEliminar);
            this.GneralPanelOpciones.Controls.Add(this.Eliminar);
            this.GneralPanelOpciones.Controls.Add(this.PanelRegistro);
            this.GneralPanelOpciones.Controls.Add(this.BotonregistrasAdmin);
            this.GneralPanelOpciones.Controls.Add(this.Home);
            this.GneralPanelOpciones.Location = new System.Drawing.Point(0, 77);
            this.GneralPanelOpciones.Name = "GneralPanelOpciones";
            this.GneralPanelOpciones.Size = new System.Drawing.Size(205, 390);
            this.GneralPanelOpciones.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Exit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit.IconSize = 40;
            this.Exit.Location = new System.Drawing.Point(0, 736);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(188, 78);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "CERRAR SESION";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Reporte
            // 
            this.Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.Reporte.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Reporte.FlatAppearance.BorderSize = 0;
            this.Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Reporte.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.Reporte.IconColor = System.Drawing.Color.White;
            this.Reporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reporte.IconSize = 40;
            this.Reporte.Location = new System.Drawing.Point(0, 658);
            this.Reporte.Margin = new System.Windows.Forms.Padding(2);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(188, 78);
            this.Reporte.TabIndex = 7;
            this.Reporte.Text = "REPORTE";
            this.Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reporte.UseVisualStyleBackColor = false;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // PanelEliminar
            // 
            this.PanelEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelEliminar.Controls.Add(this.EliminarVendedor);
            this.PanelEliminar.Controls.Add(this.EliminarChofer);
            this.PanelEliminar.Controls.Add(this.EliminarCooperativa);
            this.PanelEliminar.Controls.Add(this.EliminarCliente);
            this.PanelEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEliminar.Location = new System.Drawing.Point(0, 446);
            this.PanelEliminar.Name = "PanelEliminar";
            this.PanelEliminar.Size = new System.Drawing.Size(188, 212);
            this.PanelEliminar.TabIndex = 6;
            this.PanelEliminar.Visible = false;
            // 
            // EliminarVendedor
            // 
            this.EliminarVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.EliminarVendedor.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.EliminarVendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.EliminarVendedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.EliminarVendedor.FlatAppearance.BorderSize = 0;
            this.EliminarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.EliminarVendedor.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.EliminarVendedor.IconColor = System.Drawing.Color.White;
            this.EliminarVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarVendedor.IconSize = 55;
            this.EliminarVendedor.Location = new System.Drawing.Point(0, 159);
            this.EliminarVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarVendedor.Name = "EliminarVendedor";
            this.EliminarVendedor.Size = new System.Drawing.Size(188, 53);
            this.EliminarVendedor.TabIndex = 4;
            this.EliminarVendedor.Text = "VENDEDOR";
            this.EliminarVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarVendedor.UseVisualStyleBackColor = false;
            this.EliminarVendedor.Click += new System.EventHandler(this.EliminarVendedor_Click);
            // 
            // EliminarChofer
            // 
            this.EliminarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.EliminarChofer.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.EliminarChofer.Dock = System.Windows.Forms.DockStyle.Top;
            this.EliminarChofer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.EliminarChofer.FlatAppearance.BorderSize = 0;
            this.EliminarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarChofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.EliminarChofer.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.EliminarChofer.IconColor = System.Drawing.Color.White;
            this.EliminarChofer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarChofer.IconSize = 55;
            this.EliminarChofer.Location = new System.Drawing.Point(0, 106);
            this.EliminarChofer.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarChofer.Name = "EliminarChofer";
            this.EliminarChofer.Size = new System.Drawing.Size(188, 53);
            this.EliminarChofer.TabIndex = 3;
            this.EliminarChofer.Text = "CHOFER";
            this.EliminarChofer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarChofer.UseVisualStyleBackColor = false;
            this.EliminarChofer.Click += new System.EventHandler(this.EliminarChofer_Click);
            // 
            // EliminarCooperativa
            // 
            this.EliminarCooperativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.EliminarCooperativa.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.EliminarCooperativa.Dock = System.Windows.Forms.DockStyle.Top;
            this.EliminarCooperativa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.EliminarCooperativa.FlatAppearance.BorderSize = 0;
            this.EliminarCooperativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarCooperativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarCooperativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.EliminarCooperativa.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.EliminarCooperativa.IconColor = System.Drawing.Color.White;
            this.EliminarCooperativa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarCooperativa.IconSize = 55;
            this.EliminarCooperativa.Location = new System.Drawing.Point(0, 53);
            this.EliminarCooperativa.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarCooperativa.Name = "EliminarCooperativa";
            this.EliminarCooperativa.Size = new System.Drawing.Size(188, 53);
            this.EliminarCooperativa.TabIndex = 2;
            this.EliminarCooperativa.Text = "COOPERATIVA";
            this.EliminarCooperativa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarCooperativa.UseVisualStyleBackColor = false;
            this.EliminarCooperativa.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // EliminarCliente
            // 
            this.EliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.EliminarCliente.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.EliminarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.EliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.EliminarCliente.FlatAppearance.BorderSize = 0;
            this.EliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.EliminarCliente.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.EliminarCliente.IconColor = System.Drawing.Color.White;
            this.EliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarCliente.IconSize = 55;
            this.EliminarCliente.Location = new System.Drawing.Point(0, 0);
            this.EliminarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarCliente.Name = "EliminarCliente";
            this.EliminarCliente.Size = new System.Drawing.Size(188, 53);
            this.EliminarCliente.TabIndex = 1;
            this.EliminarCliente.Text = "CLIENTE";
            this.EliminarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarCliente.UseVisualStyleBackColor = false;
            this.EliminarCliente.Click += new System.EventHandler(this.EliminarCliente_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.Eliminar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Eliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.Eliminar.IconColor = System.Drawing.Color.White;
            this.Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Eliminar.IconSize = 40;
            this.Eliminar.Location = new System.Drawing.Point(0, 368);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(188, 78);
            this.Eliminar.TabIndex = 5;
            this.Eliminar.Text = "CONSULTAR";
            this.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // PanelRegistro
            // 
            this.PanelRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelRegistro.Controls.Add(this.Vendedor);
            this.PanelRegistro.Controls.Add(this.Chofer);
            this.PanelRegistro.Controls.Add(this.RegistrarCooperativa);
            this.PanelRegistro.Controls.Add(this.RegistrarCliente);
            this.PanelRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRegistro.Location = new System.Drawing.Point(0, 156);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.Size = new System.Drawing.Size(188, 212);
            this.PanelRegistro.TabIndex = 1;
            this.PanelRegistro.Visible = false;
            // 
            // Vendedor
            // 
            this.Vendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.Vendedor.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Vendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Vendedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Vendedor.FlatAppearance.BorderSize = 0;
            this.Vendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Vendedor.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.Vendedor.IconColor = System.Drawing.Color.White;
            this.Vendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Vendedor.IconSize = 55;
            this.Vendedor.Location = new System.Drawing.Point(0, 159);
            this.Vendedor.Margin = new System.Windows.Forms.Padding(2);
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Size = new System.Drawing.Size(188, 53);
            this.Vendedor.TabIndex = 4;
            this.Vendedor.Text = "VENDEDOR";
            this.Vendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Vendedor.UseVisualStyleBackColor = false;
            this.Vendedor.Click += new System.EventHandler(this.Vendedor_Click);
            // 
            // Chofer
            // 
            this.Chofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.Chofer.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Chofer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Chofer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Chofer.FlatAppearance.BorderSize = 0;
            this.Chofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Chofer.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.Chofer.IconColor = System.Drawing.Color.White;
            this.Chofer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Chofer.IconSize = 55;
            this.Chofer.Location = new System.Drawing.Point(0, 106);
            this.Chofer.Margin = new System.Windows.Forms.Padding(2);
            this.Chofer.Name = "Chofer";
            this.Chofer.Size = new System.Drawing.Size(188, 53);
            this.Chofer.TabIndex = 3;
            this.Chofer.Text = "CHOFER";
            this.Chofer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Chofer.UseVisualStyleBackColor = false;
            this.Chofer.Click += new System.EventHandler(this.Chofer_Click);
            // 
            // RegistrarCooperativa
            // 
            this.RegistrarCooperativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.RegistrarCooperativa.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.RegistrarCooperativa.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrarCooperativa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.RegistrarCooperativa.FlatAppearance.BorderSize = 0;
            this.RegistrarCooperativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarCooperativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarCooperativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.RegistrarCooperativa.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.RegistrarCooperativa.IconColor = System.Drawing.Color.White;
            this.RegistrarCooperativa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RegistrarCooperativa.IconSize = 55;
            this.RegistrarCooperativa.Location = new System.Drawing.Point(0, 53);
            this.RegistrarCooperativa.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrarCooperativa.Name = "RegistrarCooperativa";
            this.RegistrarCooperativa.Size = new System.Drawing.Size(188, 53);
            this.RegistrarCooperativa.TabIndex = 2;
            this.RegistrarCooperativa.Text = "COOPERATIVA";
            this.RegistrarCooperativa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrarCooperativa.UseVisualStyleBackColor = false;
            this.RegistrarCooperativa.Click += new System.EventHandler(this.RegistrarCooperativa_Click);
            // 
            // RegistrarCliente
            // 
            this.RegistrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.RegistrarCliente.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.RegistrarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.RegistrarCliente.FlatAppearance.BorderSize = 0;
            this.RegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.RegistrarCliente.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.RegistrarCliente.IconColor = System.Drawing.Color.White;
            this.RegistrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RegistrarCliente.IconSize = 55;
            this.RegistrarCliente.Location = new System.Drawing.Point(0, 0);
            this.RegistrarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrarCliente.Name = "RegistrarCliente";
            this.RegistrarCliente.Size = new System.Drawing.Size(188, 53);
            this.RegistrarCliente.TabIndex = 1;
            this.RegistrarCliente.Text = "CLIENTE";
            this.RegistrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrarCliente.UseVisualStyleBackColor = false;
            this.RegistrarCliente.Click += new System.EventHandler(this.RegistrarCliente_Click);
            // 
            // BotonregistrasAdmin
            // 
            this.BotonregistrasAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.BotonregistrasAdmin.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BotonregistrasAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonregistrasAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BotonregistrasAdmin.FlatAppearance.BorderSize = 0;
            this.BotonregistrasAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonregistrasAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonregistrasAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.BotonregistrasAdmin.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BotonregistrasAdmin.IconColor = System.Drawing.Color.White;
            this.BotonregistrasAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonregistrasAdmin.IconSize = 40;
            this.BotonregistrasAdmin.Location = new System.Drawing.Point(0, 78);
            this.BotonregistrasAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.BotonregistrasAdmin.Name = "BotonregistrasAdmin";
            this.BotonregistrasAdmin.Size = new System.Drawing.Size(188, 78);
            this.BotonregistrasAdmin.TabIndex = 0;
            this.BotonregistrasAdmin.Text = "REGISTRAR";
            this.BotonregistrasAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonregistrasAdmin.UseVisualStyleBackColor = false;
            this.BotonregistrasAdmin.Click += new System.EventHandler(this.BotonregistrasAdmin_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.Home.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.White;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.IconSize = 40;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(188, 78);
            this.Home.TabIndex = 1;
            this.Home.Text = "PRINCIPAL";
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.panel4.Controls.Add(this.guna2HtmlLabel9);
            this.panel4.Controls.Add(this.guna2Panel1);
            this.panel4.Controls.Add(this.guna2PictureBox1);
            this.panel4.Controls.Add(this.Hora_Sistema);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(919, 42);
            this.panel4.TabIndex = 3;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(99, 9);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(304, 20);
            this.guna2HtmlLabel9.TabIndex = 7;
            this.guna2HtmlLabel9.Text = "Sistema de Gestion de Boletos de AutoBuses";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(207, 40);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(712, 522);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Presentacion.Properties.Resources.pngtree_blue_big_car_illustration_cartoon_shuttle_blue_bus_gray_glass_png_image_4543101;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(66, 37);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Hora_Sistema
            // 
            this.Hora_Sistema.AutoSize = true;
            this.Hora_Sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_Sistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Hora_Sistema.Location = new System.Drawing.Point(832, 9);
            this.Hora_Sistema.Name = "Hora_Sistema";
            this.Hora_Sistema.Size = new System.Drawing.Size(80, 24);
            this.Hora_Sistema.TabIndex = 1;
            this.Hora_Sistema.Text = "17:51:10";
            // 
            // Fecha_Hora_Sistema
            // 
            this.Fecha_Hora_Sistema.Enabled = true;
            this.Fecha_Hora_Sistema.Tick += new System.EventHandler(this.Fecha_Hora_Sistema_Tick);
            // 
            // PanelPrincipalContenedor
            // 
            this.PanelPrincipalContenedor.BackColor = System.Drawing.Color.White;
            this.PanelPrincipalContenedor.Controls.Add(this.Salir);
            this.PanelPrincipalContenedor.Location = new System.Drawing.Point(205, 77);
            this.PanelPrincipalContenedor.Name = "PanelPrincipalContenedor";
            this.PanelPrincipalContenedor.Size = new System.Drawing.Size(713, 389);
            this.PanelPrincipalContenedor.TabIndex = 4;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.Transparent;
            this.Salir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.Salir.IconColor = System.Drawing.Color.White;
            this.Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Salir.IconSize = 55;
            this.Salir.Location = new System.Drawing.Point(151, 421);
            this.Salir.Margin = new System.Windows.Forms.Padding(2);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(188, 89);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Salir.UseVisualStyleBackColor = false;
            // 
            // VentanaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(245)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(919, 467);
            this.Controls.Add(this.PanelPrincipalContenedor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.GneralPanelOpciones);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.Name = "VentanaAdministrador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIAJEROS S.A";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCierreDeAplicacion)).EndInit();
            this.GneralPanelOpciones.ResumeLayout(false);
            this.PanelEliminar.ResumeLayout(false);
            this.PanelRegistro.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.PanelPrincipalContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The panel superior
        /// </summary>
        private System.Windows.Forms.Panel PanelSuperior;
        /// <summary>
        /// The panel4
        /// </summary>
        private System.Windows.Forms.Panel panel4;
        /// <summary>
        /// The boton cierre de aplicacion
        /// </summary>
        private FontAwesome.Sharp.IconPictureBox BotonCierreDeAplicacion;
        /// <summary>
        /// The boton para minimizar ventana
        /// </summary>
        private FontAwesome.Sharp.IconPictureBox BotonParaMinimizarVentana;
        /// <summary>
        /// The botonregistras admin
        /// </summary>
        private FontAwesome.Sharp.IconButton BotonregistrasAdmin;
        /// <summary>
        /// The fecha sistema
        /// </summary>
        private System.Windows.Forms.Label Fecha_Sistema;
        /// <summary>
        /// The hora sistema
        /// </summary>
        private System.Windows.Forms.Label Hora_Sistema;
        /// <summary>
        /// The fecha hora sistema
        /// </summary>
        private System.Windows.Forms.Timer Fecha_Hora_Sistema;
        /// <summary>
        /// The guna2 picture box1
        /// </summary>
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        /// <summary>
        /// The guna2 panel1
        /// </summary>
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        /// <summary>
        /// The panel principal contenedor
        /// </summary>
        private Guna.UI2.WinForms.Guna2Panel PanelPrincipalContenedor;
        /// <summary>
        /// The panel registro
        /// </summary>
        private Guna.UI2.WinForms.Guna2Panel PanelRegistro;
        /// <summary>
        /// The vendedor
        /// </summary>
        private FontAwesome.Sharp.IconButton Vendedor;
        /// <summary>
        /// The chofer
        /// </summary>
        private FontAwesome.Sharp.IconButton Chofer;
        /// <summary>
        /// The registrar cooperativa
        /// </summary>
        private FontAwesome.Sharp.IconButton RegistrarCooperativa;
        /// <summary>
        /// The registrar cliente
        /// </summary>
        private FontAwesome.Sharp.IconButton RegistrarCliente;
        /// <summary>
        /// The salir
        /// </summary>
        private FontAwesome.Sharp.IconButton Salir;
        /// <summary>
        /// The gneral panel opciones
        /// </summary>
        private Guna.UI2.WinForms.Guna2Panel GneralPanelOpciones;
        /// <summary>
        /// The home
        /// </summary>
        private FontAwesome.Sharp.IconButton Home;
        /// <summary>
        /// The panel eliminar
        /// </summary>
        private Guna.UI2.WinForms.Guna2Panel PanelEliminar;
        /// <summary>
        /// The icon button2
        /// </summary>
        private FontAwesome.Sharp.IconButton EliminarVendedor;
        /// <summary>
        /// The icon button3
        /// </summary>
        private FontAwesome.Sharp.IconButton EliminarChofer;
        /// <summary>
        /// The icon button4
        /// </summary>
        private FontAwesome.Sharp.IconButton EliminarCooperativa;
        /// <summary>
        /// The icon button5
        /// </summary>
        private FontAwesome.Sharp.IconButton EliminarCliente;
        /// <summary>
        /// The eliminar
        /// </summary>
        private FontAwesome.Sharp.IconButton Eliminar;
        /// <summary>
        /// The exit
        /// </summary>
        private FontAwesome.Sharp.IconButton Exit;
        /// <summary>
        /// The reporte
        /// </summary>
        private FontAwesome.Sharp.IconButton Reporte;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
    }
}

