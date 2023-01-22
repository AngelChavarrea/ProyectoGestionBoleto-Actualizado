// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="RegistroRuta.Designer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Presentacion
{
    /// <summary>
    /// Class RegistroChofer.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class RegistroRuta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOrigen = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbDisco = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDestino = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbAsiento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtHSalida = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtFechasalida = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbmCooperativa = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 77);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(89, 24);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Cooperativa:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(3, 253);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(122, 24);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "Número de disco:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(3, 199);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(116, 24);
            this.guna2HtmlLabel3.TabIndex = 20;
            this.guna2HtmlLabel3.Text = "Lugar de origen:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(338, 199);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(135, 24);
            this.guna2HtmlLabel4.TabIndex = 21;
            this.guna2HtmlLabel4.Text = "Número de asiento:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(338, 77);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(110, 24);
            this.guna2HtmlLabel5.TabIndex = 22;
            this.guna2HtmlLabel5.Text = "Fecha de salida:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(338, 141);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(105, 24);
            this.guna2HtmlLabel8.TabIndex = 25;
            this.guna2HtmlLabel8.Text = "Hora de salida:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.AutoRoundedCorners = true;
            this.txtOrigen.BackColor = System.Drawing.Color.Transparent;
            this.txtOrigen.BorderRadius = 12;
            this.txtOrigen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrigen.DefaultText = "";
            this.txtOrigen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrigen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrigen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrigen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrigen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrigen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOrigen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrigen.Location = new System.Drawing.Point(131, 196);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.PasswordChar = '\0';
            this.txtOrigen.PlaceholderText = "Ingrese ciudad de origen";
            this.txtOrigen.SelectedText = "";
            this.txtOrigen.Size = new System.Drawing.Size(196, 27);
            this.txtOrigen.TabIndex = 27;
            // 
            // cmbDisco
            // 
            this.cmbDisco.AutoRoundedCorners = true;
            this.cmbDisco.BackColor = System.Drawing.Color.Transparent;
            this.cmbDisco.BorderRadius = 17;
            this.cmbDisco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDisco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisco.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDisco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDisco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDisco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDisco.ItemHeight = 30;
            this.cmbDisco.Location = new System.Drawing.Point(131, 244);
            this.cmbDisco.Name = "cmbDisco";
            this.cmbDisco.Size = new System.Drawing.Size(196, 36);
            this.cmbDisco.TabIndex = 29;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.ColumnHeadersHeight = 21;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Sexo,
            this.Telefono,
            this.Correo,
            this.Ciudad,
            this.Usuario,
            this.Contraseña});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCliente.Location = new System.Drawing.Point(6, 635);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 62;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(879, 46);
            this.dgvCliente.TabIndex = 34;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCliente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCliente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCliente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCliente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCliente.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvCliente.ThemeStyle.ReadOnly = true;
            this.dgvCliente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCliente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCliente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCliente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCliente.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCliente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MaxInputLength = 10;
            this.Cedula.MinimumWidth = 8;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MaxInputLength = 60;
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MaxInputLength = 30;
            this.Sexo.MinimumWidth = 8;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MaxInputLength = 10;
            this.Telefono.MinimumWidth = 8;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MaxInputLength = 20;
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MaxInputLength = 20;
            this.Ciudad.MinimumWidth = 8;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MaxInputLength = 20;
            this.Usuario.MinimumWidth = 8;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.MaxInputLength = 20;
            this.Contraseña.MinimumWidth = 8;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoRoundedCorners = true;
            this.btnGuardar.BorderRadius = 14;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(274, 298);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 30);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(3, 141);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(121, 24);
            this.guna2HtmlLabel6.TabIndex = 36;
            this.guna2HtmlLabel6.Text = "Lugar de destino:";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(338, 253);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(49, 24);
            this.guna2HtmlLabel7.TabIndex = 37;
            this.guna2HtmlLabel7.Text = "Precio:";
            // 
            // txtDestino
            // 
            this.txtDestino.AutoRoundedCorners = true;
            this.txtDestino.BackColor = System.Drawing.Color.Transparent;
            this.txtDestino.BorderRadius = 12;
            this.txtDestino.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDestino.DefaultText = "";
            this.txtDestino.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDestino.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDestino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDestino.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDestino.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDestino.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDestino.Location = new System.Drawing.Point(131, 141);
            this.txtDestino.MaxLength = 100000;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.PasswordChar = '\0';
            this.txtDestino.PlaceholderText = "Ingrese una ciudad de destino.";
            this.txtDestino.SelectedText = "";
            this.txtDestino.Size = new System.Drawing.Size(196, 27);
            this.txtDestino.TabIndex = 38;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoRoundedCorners = true;
            this.txtPrecio.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecio.BorderRadius = 12;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.Location = new System.Drawing.Point(481, 253);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderText = "Ingrese un precio 0,00.";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.Size = new System.Drawing.Size(196, 27);
            this.txtPrecio.TabIndex = 39;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cbAsiento);
            this.guna2GroupBox1.Controls.Add(this.dtHSalida);
            this.guna2GroupBox1.Controls.Add(this.dtFechasalida);
            this.guna2GroupBox1.Controls.Add(this.cbmCooperativa);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.btnGuardar);
            this.guna2GroupBox1.Controls.Add(this.txtPrecio);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GroupBox1.Controls.Add(this.txtDestino);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.txtOrigen);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2GroupBox1.Controls.Add(this.cmbDisco);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 26);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(689, 340);
            this.guna2GroupBox1.TabIndex = 40;
            this.guna2GroupBox1.Text = "Registro de chofer.";
            // 
            // cbAsiento
            // 
            this.cbAsiento.AutoRoundedCorners = true;
            this.cbAsiento.BackColor = System.Drawing.Color.Transparent;
            this.cbAsiento.BorderRadius = 17;
            this.cbAsiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsiento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAsiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAsiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAsiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAsiento.ItemHeight = 30;
            this.cbAsiento.Location = new System.Drawing.Point(479, 196);
            this.cbAsiento.Name = "cbAsiento";
            this.cbAsiento.Size = new System.Drawing.Size(196, 36);
            this.cbAsiento.TabIndex = 44;
            // 
            // dtHSalida
            // 
            this.dtHSalida.AutoRoundedCorners = true;
            this.dtHSalida.BorderRadius = 17;
            this.dtHSalida.Checked = true;
            this.dtHSalida.FillColor = System.Drawing.Color.White;
            this.dtHSalida.FocusedColor = System.Drawing.Color.White;
            this.dtHSalida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtHSalida.ForeColor = System.Drawing.Color.Black;
            this.dtHSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHSalida.Location = new System.Drawing.Point(475, 141);
            this.dtHSalida.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtHSalida.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtHSalida.Name = "dtHSalida";
            this.dtHSalida.Size = new System.Drawing.Size(200, 36);
            this.dtHSalida.TabIndex = 43;
            this.dtHSalida.Value = new System.DateTime(2022, 3, 7, 18, 8, 0, 0);
            // 
            // dtFechasalida
            // 
            this.dtFechasalida.AutoRoundedCorners = true;
            this.dtFechasalida.BorderRadius = 17;
            this.dtFechasalida.Checked = true;
            this.dtFechasalida.FillColor = System.Drawing.Color.White;
            this.dtFechasalida.FocusedColor = System.Drawing.Color.White;
            this.dtFechasalida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFechasalida.ForeColor = System.Drawing.Color.Black;
            this.dtFechasalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechasalida.Location = new System.Drawing.Point(475, 77);
            this.dtFechasalida.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFechasalida.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFechasalida.Name = "dtFechasalida";
            this.dtFechasalida.Size = new System.Drawing.Size(200, 36);
            this.dtFechasalida.TabIndex = 42;
            this.dtFechasalida.Value = new System.DateTime(2022, 3, 7, 18, 8, 51, 661);
            // 
            // cbmCooperativa
            // 
            this.cbmCooperativa.AutoRoundedCorners = true;
            this.cbmCooperativa.BackColor = System.Drawing.Color.Transparent;
            this.cbmCooperativa.BorderRadius = 17;
            this.cbmCooperativa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmCooperativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmCooperativa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmCooperativa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmCooperativa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbmCooperativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmCooperativa.ItemHeight = 30;
            this.cbmCooperativa.Location = new System.Drawing.Point(131, 77);
            this.cbmCooperativa.Name = "cbmCooperativa";
            this.cbmCooperativa.Size = new System.Drawing.Size(196, 36);
            this.cbmCooperativa.TabIndex = 40;
            // 
            // RegistroRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 389);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgvCliente);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroRuta";
            this.Text = "RegistroCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// The CMB sexo
        /// </summary>
        private Guna.UI2.WinForms.Guna2ComboBox cmbDisco;
        /// <summary>
        /// The text nombre
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtOrigen;
        /// <summary>
        /// The guna2 HTML label8
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        /// <summary>
        /// The guna2 HTML label5
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        /// <summary>
        /// The guna2 HTML label4
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        /// <summary>
        /// The guna2 HTML label3
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        /// <summary>
        /// The guna2 HTML label2
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        /// <summary>
        /// The guna2 HTML label1
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        /// <summary>
        /// The DGV cliente
        /// </summary>
        private Guna.UI2.WinForms.Guna2DataGridView dgvCliente;
        /// <summary>
        /// The cedula
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        /// <summary>
        /// The nombre
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        /// <summary>
        /// The sexo
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        /// <summary>
        /// The telefono
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        /// <summary>
        /// The correo
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        /// <summary>
        /// The ciudad
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        /// <summary>
        /// The usuario
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        /// <summary>
        /// The contraseña
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        /// <summary>
        /// The BTN guardar
        /// </summary>
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        /// <summary>
        /// The error provider1
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorProvider1;
        /// <summary>
        /// The guna2 HTML label6
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        /// <summary>
        /// The text licencia
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        /// <summary>
        /// The text sueldo
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox txtDestino;
        /// <summary>
        /// The guna2 HTML label7
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbmCooperativa;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtHSalida;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFechasalida;
        private Guna.UI2.WinForms.Guna2ComboBox cbAsiento;
    }
}