// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Pagar.Designer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Presentacion.UsuarioCliente
{
    /// <summary>
    /// Class Pagar.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Pagar
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
            this.Box1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.InfBoleto = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnPagar = new Guna.UI2.WinForms.Guna2Button();
            this.btnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelSegundario = new Guna.UI2.WinForms.Guna2Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Btn_Guardar = new Guna.UI2.WinForms.Guna2Button();
            this.BotonRetroceder = new FontAwesome.Sharp.IconButton();
            this.Box1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.PanelSegundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Box1
            // 
            this.Box1.BackColor = System.Drawing.Color.Transparent;
            this.Box1.BorderRadius = 20;
            this.Box1.Controls.Add(this.guna2HtmlLabel1);
            this.Box1.Controls.Add(this.txtTotal);
            this.Box1.Controls.Add(this.InfBoleto);
            this.Box1.Controls.Add(this.btnCancelar);
            this.Box1.Controls.Add(this.btnPagar);
            this.Box1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.Box1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.ForeColor = System.Drawing.Color.Ivory;
            this.Box1.Location = new System.Drawing.Point(41, 64);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(605, 374);
            this.Box1.TabIndex = 37;
            this.Box1.Text = "Información boleto";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(22, 313);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(93, 23);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "Total a pagar";
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(304, 313);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(120, 33);
            this.txtTotal.TabIndex = 16;
            // 
            // InfBoleto
            // 
            this.InfBoleto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfBoleto.Location = new System.Drawing.Point(22, 74);
            this.InfBoleto.Name = "InfBoleto";
            this.InfBoleto.Size = new System.Drawing.Size(402, 233);
            this.InfBoleto.TabIndex = 15;
            this.InfBoleto.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoRoundedCorners = true;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(446, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 42);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.AutoRoundedCorners = true;
            this.btnPagar.BorderRadius = 20;
            this.btnPagar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPagar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(446, 141);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(138, 42);
            this.btnPagar.TabIndex = 12;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoRoundedCorners = true;
            this.btnImprimir.BorderRadius = 31;
            this.btnImprimir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImprimir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImprimir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImprimir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImprimir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(149, 144);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(315, 65);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel9);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.BotonRetroceder);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(687, 44);
            this.guna2Panel1.TabIndex = 38;
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(84, 12);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(304, 20);
            this.guna2HtmlLabel9.TabIndex = 42;
            this.guna2HtmlLabel9.Text = "Sistema de Gestion de Boletos de AutoBuses";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Presentacion.Properties.Resources.pngtree_blue_big_car_illustration_cartoon_shuttle_blue_bus_gray_glass_png_image_4543102;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(66, 37);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 41;
            this.guna2PictureBox1.TabStop = false;
            // 
            // PanelSegundario
            // 
            this.PanelSegundario.Controls.Add(this.btnImprimir);
            this.PanelSegundario.Controls.Add(this.iconPictureBox1);
            this.PanelSegundario.Controls.Add(this.Btn_Guardar);
            this.PanelSegundario.Location = new System.Drawing.Point(32, 64);
            this.PanelSegundario.Name = "PanelSegundario";
            this.PanelSegundario.Size = new System.Drawing.Size(614, 357);
            this.PanelSegundario.TabIndex = 39;
            this.PanelSegundario.Visible = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(121)))), ((int)(((byte)(158)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 116;
            this.iconPictureBox1.Location = new System.Drawing.Point(247, 26);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(116, 127);
            this.iconPictureBox1.TabIndex = 20;
            this.iconPictureBox1.TabStop = false;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.AutoRoundedCorners = true;
            this.Btn_Guardar.BorderRadius = 31;
            this.Btn_Guardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Guardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Guardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Guardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(196)))), ((int)(((byte)(214)))));
            this.Btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Location = new System.Drawing.Point(149, 242);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(315, 65);
            this.Btn_Guardar.TabIndex = 19;
            this.Btn_Guardar.Text = "GUARDAR PDF";
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // BotonRetroceder
            // 
            this.BotonRetroceder.BackColor = System.Drawing.Color.Transparent;
            this.BotonRetroceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonRetroceder.Dock = System.Windows.Forms.DockStyle.Right;
            this.BotonRetroceder.FlatAppearance.BorderSize = 0;
            this.BotonRetroceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonRetroceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRetroceder.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BotonRetroceder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotonRetroceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BotonRetroceder.IconSize = 37;
            this.BotonRetroceder.Location = new System.Drawing.Point(628, 0);
            this.BotonRetroceder.Name = "BotonRetroceder";
            this.BotonRetroceder.Size = new System.Drawing.Size(59, 44);
            this.BotonRetroceder.TabIndex = 40;
            this.BotonRetroceder.UseVisualStyleBackColor = false;
            this.BotonRetroceder.Visible = false;
            this.BotonRetroceder.Click += new System.EventHandler(this.BotonRetroceder_Click);
            // 
            // Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.PanelSegundario);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Box1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagar";
            this.Text = "Pagar";
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.PanelSegundario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The guna2 borderless form1
        /// </summary>
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        /// <summary>
        /// The guna2 group box1
        /// </summary>
        private Guna.UI2.WinForms.Guna2GroupBox Box1;
        /// <summary>
        /// The BTN pagar
        /// </summary>
        private Guna.UI2.WinForms.Guna2Button btnPagar;
        /// <summary>
        /// The guna2 panel1
        /// </summary>
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        /// <summary>
        /// The guna2 picture box1
        /// </summary>
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        /// <summary>
        /// The guna2 button2
        /// </summary>
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        /// <summary>
        /// The guna2 HTML label9
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private System.Windows.Forms.RichTextBox InfBoleto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2Button btnImprimir;
        private Guna.UI2.WinForms.Guna2Panel PanelSegundario;
        private Guna.UI2.WinForms.Guna2Button Btn_Guardar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton BotonRetroceder;
    }
}