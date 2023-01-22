// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="EliminarClienteporAdmin.Designer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Presentacion.SGA_Administrador
{
    /// <summary>
    /// Class EliminarClienteporAdmin.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class ConsultarClienteporAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar_Cliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnConsultar = new FontAwesome.Sharp.IconPictureBox();
            this.TxtDatoCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCliente)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridCliente
            // 
            this.DataGridCliente.AllowUserToAddRows = false;
            this.DataGridCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCliente.BackgroundColor = System.Drawing.Color.White;
            this.DataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridCliente.ColumnHeadersHeight = 30;
            this.DataGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.CedulaCliente,
            this.CorreoCliente,
            this.Eliminar_Cliente,
            this.Editar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridCliente.EnableHeadersVisualStyles = false;
            this.DataGridCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridCliente.Location = new System.Drawing.Point(17, 142);
            this.DataGridCliente.Name = "DataGridCliente";
            this.DataGridCliente.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridCliente.RowHeadersVisible = false;
            this.DataGridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCliente.Size = new System.Drawing.Size(659, 205);
            this.DataGridCliente.TabIndex = 0;
            this.DataGridCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridCliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridCliente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridCliente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridCliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DataGridCliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridCliente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Informal Roman", 10F);
            this.DataGridCliente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridCliente.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridCliente.ThemeStyle.ReadOnly = true;
            this.DataGridCliente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridCliente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridCliente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridCliente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridCliente.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridCliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridCliente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCliente_CellContentClick);
            this.DataGridCliente.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridCliente_CellPainting);
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CedulaCliente
            // 
            this.CedulaCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CedulaCliente.HeaderText = "Cédula";
            this.CedulaCliente.Name = "CedulaCliente";
            this.CedulaCliente.ReadOnly = true;
            this.CedulaCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CorreoCliente
            // 
            this.CorreoCliente.HeaderText = "Correo";
            this.CorreoCliente.Name = "CorreoCliente";
            this.CorreoCliente.ReadOnly = true;
            this.CorreoCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Eliminar_Cliente
            // 
            this.Eliminar_Cliente.HeaderText = "Eliminar";
            this.Eliminar_Cliente.Name = "Eliminar_Cliente";
            this.Eliminar_Cliente.ReadOnly = true;
            this.Eliminar_Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar_Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.BtnConsultar);
            this.guna2GroupBox1.Controls.Add(this.TxtDatoCliente);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.DataGridCliente);
            this.guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(689, 365);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Consultar cliente";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BtnConsultar.ForeColor = System.Drawing.Color.Green;
            this.BtnConsultar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.BtnConsultar.IconColor = System.Drawing.Color.Green;
            this.BtnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsultar.Location = new System.Drawing.Point(493, 85);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(35, 32);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.TabStop = false;
            this.BtnConsultar.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // TxtDatoCliente
            // 
            this.TxtDatoCliente.BackColor = System.Drawing.Color.Transparent;
            this.TxtDatoCliente.BorderRadius = 12;
            this.TxtDatoCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDatoCliente.DefaultText = "";
            this.TxtDatoCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDatoCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDatoCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDatoCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDatoCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDatoCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDatoCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDatoCliente.Location = new System.Drawing.Point(257, 85);
            this.TxtDatoCliente.Name = "TxtDatoCliente";
            this.TxtDatoCliente.PasswordChar = '\0';
            this.TxtDatoCliente.PlaceholderText = "Ingresar la cédula o nombre del cliente";
            this.TxtDatoCliente.SelectedText = "";
            this.TxtDatoCliente.Size = new System.Drawing.Size(230, 30);
            this.TxtDatoCliente.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(129)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(198, 85);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(53, 30);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Datos:";
            // 
            // ConsultarClienteporAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 389);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarClienteporAdmin";
            this.Text = "EliminarClienteporAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCliente)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConsultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The data grid cliente
        /// </summary>
        private Guna.UI2.WinForms.Guna2DataGridView DataGridCliente;
        /// <summary>
        /// The guna2 group box1
        /// </summary>
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        /// <summary>
        /// The text cedula cliente
        /// </summary>
        private Guna.UI2.WinForms.Guna2TextBox TxtDatoCliente;
        /// <summary>
        /// The guna2 HTML label1
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        /// <summary>
        /// The BTN consultar
        /// </summary>
        private FontAwesome.Sharp.IconPictureBox BtnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoCliente;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar_Cliente;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}