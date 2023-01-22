// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="BuscarBus.Designer.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Presentacion.InicioFroms
{
    /// <summary>
    /// Class BuscarBus.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class BuscarBus
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DataGridInf = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cooperativa_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_pasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boton_DatGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbDestino = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbOrigen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbCooperativa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridInf)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.DataGridInf);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(27, 128);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(658, 235);
            this.guna2GroupBox1.TabIndex = 21;
            this.guna2GroupBox1.Text = "ELEGIR RUTA";
            // 
            // DataGridInf
            // 
            this.DataGridInf.AllowUserToAddRows = false;
            this.DataGridInf.AllowUserToDeleteRows = false;
            this.DataGridInf.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridInf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridInf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridInf.BackgroundColor = System.Drawing.Color.White;
            this.DataGridInf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridInf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridInf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridInf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridInf.ColumnHeadersHeight = 21;
            this.DataGridInf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cooperativa_nombre,
            this.Hora_Salida,
            this.FechaSalida,
            this.Costo_pasaje,
            this.Boton_DatGrid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridInf.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridInf.EnableHeadersVisualStyles = false;
            this.DataGridInf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridInf.Location = new System.Drawing.Point(15, 50);
            this.DataGridInf.MultiSelect = false;
            this.DataGridInf.Name = "DataGridInf";
            this.DataGridInf.ReadOnly = true;
            this.DataGridInf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridInf.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridInf.RowHeadersVisible = false;
            this.DataGridInf.RowHeadersWidth = 62;
            this.DataGridInf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridInf.Size = new System.Drawing.Size(629, 170);
            this.DataGridInf.TabIndex = 13;
            this.DataGridInf.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridInf.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridInf.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridInf.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridInf.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridInf.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridInf.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridInf.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.DataGridInf.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridInf.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridInf.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridInf.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridInf.ThemeStyle.HeaderStyle.Height = 21;
            this.DataGridInf.ThemeStyle.ReadOnly = true;
            this.DataGridInf.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridInf.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridInf.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGridInf.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DataGridInf.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridInf.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridInf.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridInf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridInf_CellContentClick);
            // 
            // Cooperativa_nombre
            // 
            this.Cooperativa_nombre.HeaderText = "Cooperativa";
            this.Cooperativa_nombre.MinimumWidth = 8;
            this.Cooperativa_nombre.Name = "Cooperativa_nombre";
            this.Cooperativa_nombre.ReadOnly = true;
            // 
            // Hora_Salida
            // 
            this.Hora_Salida.HeaderText = "Hora de salida";
            this.Hora_Salida.MinimumWidth = 8;
            this.Hora_Salida.Name = "Hora_Salida";
            this.Hora_Salida.ReadOnly = true;
            // 
            // FechaSalida
            // 
            this.FechaSalida.HeaderText = "Fecha Salida";
            this.FechaSalida.MinimumWidth = 8;
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.ReadOnly = true;
            // 
            // Costo_pasaje
            // 
            this.Costo_pasaje.HeaderText = "Precio";
            this.Costo_pasaje.MinimumWidth = 8;
            this.Costo_pasaje.Name = "Costo_pasaje";
            this.Costo_pasaje.ReadOnly = true;
            // 
            // Boton_DatGrid
            // 
            this.Boton_DatGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Boton_DatGrid.HeaderText = "Seleccionar";
            this.Boton_DatGrid.Name = "Boton_DatGrid";
            this.Boton_DatGrid.ReadOnly = true;
            // 
            // cbDestino
            // 
            this.cbDestino.AutoRoundedCorners = true;
            this.cbDestino.BackColor = System.Drawing.Color.Transparent;
            this.cbDestino.BorderRadius = 17;
            this.cbDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDestino.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDestino.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDestino.ItemHeight = 30;
            this.cbDestino.Location = new System.Drawing.Point(256, 67);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(171, 36);
            this.cbDestino.TabIndex = 20;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged);
            // 
            // cbOrigen
            // 
            this.cbOrigen.AutoRoundedCorners = true;
            this.cbOrigen.BackColor = System.Drawing.Color.Transparent;
            this.cbOrigen.BorderRadius = 17;
            this.cbOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOrigen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOrigen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbOrigen.ItemHeight = 30;
            this.cbOrigen.Location = new System.Drawing.Point(27, 67);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(157, 36);
            this.cbOrigen.TabIndex = 19;
            this.cbOrigen.SelectedIndexChanged += new System.EventHandler(this.cbOrigen_SelectedIndexChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(278, 29);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(128, 22);
            this.guna2HtmlLabel6.TabIndex = 18;
            this.guna2HtmlLabel6.Text = "Lugar de destino";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(45, 29);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(120, 22);
            this.guna2HtmlLabel5.TabIndex = 17;
            this.guna2HtmlLabel5.Text = "Lugar de origen";
            // 
            // cbCooperativa
            // 
            this.cbCooperativa.AutoRoundedCorners = true;
            this.cbCooperativa.BackColor = System.Drawing.Color.Transparent;
            this.cbCooperativa.BorderRadius = 17;
            this.cbCooperativa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCooperativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCooperativa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCooperativa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCooperativa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCooperativa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCooperativa.ItemHeight = 30;
            this.cbCooperativa.Location = new System.Drawing.Point(468, 67);
            this.cbCooperativa.Name = "cbCooperativa";
            this.cbCooperativa.Size = new System.Drawing.Size(217, 36);
            this.cbCooperativa.TabIndex = 16;
            this.cbCooperativa.SelectedIndexChanged += new System.EventHandler(this.cbCooperativa_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(528, 29);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(97, 22);
            this.guna2HtmlLabel3.TabIndex = 15;
            this.guna2HtmlLabel3.Text = "Cooperativa:";
            // 
            // BuscarBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 394);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cbCooperativa);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarBus";
            this.Text = "BuscarBus";
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The guna2 group box1
        /// </summary>
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        /// <summary>
        /// The data grid inf
        /// </summary>
        private Guna.UI2.WinForms.Guna2DataGridView DataGridInf;
        /// <summary>
        /// The cooperativa nombre
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Cooperativa_nombre;
        /// <summary>
        /// The hora salida
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Salida;
        /// <summary>
        /// The fecha salida
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        /// <summary>
        /// The costo pasaje
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_pasaje;
        /// <summary>
        /// The boton dat grid
        /// </summary>
        private System.Windows.Forms.DataGridViewButtonColumn Boton_DatGrid;
        /// <summary>
        /// The cb destino
        /// </summary>
        private Guna.UI2.WinForms.Guna2ComboBox cbDestino;
        /// <summary>
        /// The cb origen
        /// </summary>
        private Guna.UI2.WinForms.Guna2ComboBox cbOrigen;
        /// <summary>
        /// The guna2 HTML label6
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        /// <summary>
        /// The guna2 HTML label5
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        /// <summary>
        /// The cb cooperativa
        /// </summary>
        private Guna.UI2.WinForms.Guna2ComboBox cbCooperativa;
        /// <summary>
        /// The guna2 HTML label3
        /// </summary>
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}