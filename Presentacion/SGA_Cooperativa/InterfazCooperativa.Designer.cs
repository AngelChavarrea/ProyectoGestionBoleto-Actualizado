// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="InterfazCliente.Designer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Presentacion
{
    /// <summary>
    /// Class InterfazCliente.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class InterfazCooperativa
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseSesion = new FontAwesome.Sharp.IconButton();
            this.RutasFavoritas = new FontAwesome.Sharp.IconButton();
            this.History = new FontAwesome.Sharp.IconButton();
            this.EditPerfil = new FontAwesome.Sharp.IconButton();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.Fecha_Sistema = new System.Windows.Forms.Label();
            this.BotonParaMinimizarVentana = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Hora_Sistema = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.CloseSesion);
            this.panel2.Controls.Add(this.RutasFavoritas);
            this.panel2.Controls.Add(this.History);
            this.panel2.Controls.Add(this.EditPerfil);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Location = new System.Drawing.Point(-1, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 391);
            this.panel2.TabIndex = 3;
            // 
            // CloseSesion
            // 
            this.CloseSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.CloseSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.CloseSesion.FlatAppearance.BorderSize = 0;
            this.CloseSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.CloseSesion.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.CloseSesion.IconColor = System.Drawing.Color.White;
            this.CloseSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseSesion.IconSize = 40;
            this.CloseSesion.Location = new System.Drawing.Point(0, 335);
            this.CloseSesion.Margin = new System.Windows.Forms.Padding(2);
            this.CloseSesion.Name = "CloseSesion";
            this.CloseSesion.Size = new System.Drawing.Size(205, 55);
            this.CloseSesion.TabIndex = 6;
            this.CloseSesion.Text = "Cerrar Sesión";
            this.CloseSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseSesion.UseVisualStyleBackColor = false;
            this.CloseSesion.Click += new System.EventHandler(this.CloseSesion_Click);
            // 
            // RutasFavoritas
            // 
            this.RutasFavoritas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.RutasFavoritas.Dock = System.Windows.Forms.DockStyle.Top;
            this.RutasFavoritas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.RutasFavoritas.FlatAppearance.BorderSize = 0;
            this.RutasFavoritas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RutasFavoritas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutasFavoritas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.RutasFavoritas.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.RutasFavoritas.IconColor = System.Drawing.Color.White;
            this.RutasFavoritas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RutasFavoritas.IconSize = 40;
            this.RutasFavoritas.Location = new System.Drawing.Point(0, 280);
            this.RutasFavoritas.Margin = new System.Windows.Forms.Padding(2);
            this.RutasFavoritas.Name = "RutasFavoritas";
            this.RutasFavoritas.Size = new System.Drawing.Size(205, 55);
            this.RutasFavoritas.TabIndex = 5;
            this.RutasFavoritas.Text = "Generar boleto";
            this.RutasFavoritas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RutasFavoritas.UseVisualStyleBackColor = false;
            this.RutasFavoritas.Click += new System.EventHandler(this.RutasFavoritas_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.History.Dock = System.Windows.Forms.DockStyle.Top;
            this.History.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.History.FlatAppearance.BorderSize = 0;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.History.IconChar = FontAwesome.Sharp.IconChar.Bus;
            this.History.IconColor = System.Drawing.Color.White;
            this.History.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.History.IconSize = 40;
            this.History.Location = new System.Drawing.Point(0, 225);
            this.History.Margin = new System.Windows.Forms.Padding(2);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(205, 55);
            this.History.TabIndex = 4;
            this.History.Text = "Agregar Bus";
            this.History.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // EditPerfil
            // 
            this.EditPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.EditPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditPerfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.EditPerfil.FlatAppearance.BorderSize = 0;
            this.EditPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.EditPerfil.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.EditPerfil.IconColor = System.Drawing.Color.White;
            this.EditPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditPerfil.IconSize = 40;
            this.EditPerfil.Location = new System.Drawing.Point(0, 169);
            this.EditPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.EditPerfil.Name = "EditPerfil";
            this.EditPerfil.Size = new System.Drawing.Size(205, 56);
            this.EditPerfil.TabIndex = 3;
            this.EditPerfil.Text = "Editar Perfil";
            this.EditPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditPerfil.UseVisualStyleBackColor = false;
            this.EditPerfil.Click += new System.EventHandler(this.EditPerfil_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
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
            this.Home.Location = new System.Drawing.Point(0, 113);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(205, 56);
            this.Home.TabIndex = 2;
            this.Home.Text = "Principal";
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(205, 113);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(27, 10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(143, 22);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "DILLAN AREVALO S";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Presentacion.Properties.Resources.c82646ff36e2523350d01fff093938f6;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(55, 40);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(79, 63);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.PanelSuperior.Controls.Add(this.Fecha_Sistema);
            this.PanelSuperior.Controls.Add(this.BotonParaMinimizarVentana);
            this.PanelSuperior.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(923, 35);
            this.PanelSuperior.TabIndex = 32;
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
            this.BotonParaMinimizarVentana.Location = new System.Drawing.Point(885, 1);
            this.BotonParaMinimizarVentana.Name = "BotonParaMinimizarVentana";
            this.BotonParaMinimizarVentana.Size = new System.Drawing.Size(39, 34);
            this.BotonParaMinimizarVentana.TabIndex = 1;
            this.BotonParaMinimizarVentana.TabStop = false;
            this.BotonParaMinimizarVentana.Click += new System.EventHandler(this.BotonParaMinimizarVentana_Click);
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
            this.panel1.Size = new System.Drawing.Size(923, 45);
            this.panel1.TabIndex = 33;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(109, 13);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(304, 20);
            this.guna2HtmlLabel9.TabIndex = 7;
            this.guna2HtmlLabel9.Text = "Sistema de Gestion de Boletos de AutoBuses";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Presentacion.Properties.Resources.pngtree_blue_big_car_illustration_cartoon_shuttle_blue_bus_gray_glass_png_image_4543101;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(27, 8);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.White;
            this.PanelContenedor.Location = new System.Drawing.Point(202, 77);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(722, 391);
            this.PanelContenedor.TabIndex = 34;
            // 
            // InterfazCooperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 467);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazCooperativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonParaMinimizarVentana)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The guna2 borderless form1
        /// </summary>
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
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
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The guna2 picture box1
        /// </summary>
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        /// <summary>
        /// The hora sistema
        /// </summary>
        private System.Windows.Forms.Label Hora_Sistema;
        /// <summary>
        /// The timer1
        /// </summary>
        private System.Windows.Forms.Timer timer1;
        /// <summary>
        /// The home
        /// </summary>
        private FontAwesome.Sharp.IconButton Home;
        /// <summary>
        /// The guna2 panel1
        /// </summary>
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        /// <summary>
        /// The panel contenedor
        /// </summary>
        private Guna.UI2.WinForms.Guna2Panel PanelContenedor;
        /// <summary>
        /// The edit perfil
        /// </summary>
        private FontAwesome.Sharp.IconButton EditPerfil;
        /// <summary>
        /// The close sesion
        /// </summary>
        private FontAwesome.Sharp.IconButton CloseSesion;
        /// <summary>
        /// The rutas favoritas
        /// </summary>
        private FontAwesome.Sharp.IconButton RutasFavoritas;
        /// <summary>
        /// The history
        /// </summary>
        private FontAwesome.Sharp.IconButton History;
        /// <summary>
        /// The guna2 HTML label1
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        /// <summary>
        /// The guna2 circle picture box1
        /// </summary>
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
    }
}