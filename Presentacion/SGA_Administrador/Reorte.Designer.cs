
namespace Presentacion.SGA_Administrador
{
    partial class Reorte
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
            this.bocCedula = new Guna.UI2.WinForms.Guna2RadioButton();
            this.boxFecha = new Guna.UI2.WinForms.Guna2RadioButton();
            this.boxCooperativa = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtDato = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnConsultar = new FontAwesome.Sharp.IconPictureBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DataGridReporte = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula_Comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cooperativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSaldida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConsultar)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // bocCedula
            // 
            this.bocCedula.AutoSize = true;
            this.bocCedula.Checked = true;
            this.bocCedula.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bocCedula.CheckedState.BorderThickness = 0;
            this.bocCedula.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bocCedula.CheckedState.InnerColor = System.Drawing.Color.White;
            this.bocCedula.CheckedState.InnerOffset = -4;
            this.bocCedula.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.bocCedula.ForeColor = System.Drawing.Color.Black;
            this.bocCedula.Location = new System.Drawing.Point(179, 86);
            this.bocCedula.Name = "bocCedula";
            this.bocCedula.Size = new System.Drawing.Size(91, 22);
            this.bocCedula.TabIndex = 1;
            this.bocCedula.TabStop = true;
            this.bocCedula.Text = "Por cédula";
            this.bocCedula.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bocCedula.UncheckedState.BorderThickness = 2;
            this.bocCedula.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.bocCedula.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.bocCedula.CheckedChanged += new System.EventHandler(this.bocCedula_CheckedChanged);
            // 
            // boxFecha
            // 
            this.boxFecha.AutoSize = true;
            this.boxFecha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxFecha.CheckedState.BorderThickness = 0;
            this.boxFecha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxFecha.CheckedState.InnerColor = System.Drawing.Color.White;
            this.boxFecha.CheckedState.InnerOffset = -4;
            this.boxFecha.ForeColor = System.Drawing.Color.Black;
            this.boxFecha.Location = new System.Drawing.Point(276, 86);
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(123, 22);
            this.boxFecha.TabIndex = 2;
            this.boxFecha.Text = "Por fecha salida";
            this.boxFecha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.boxFecha.UncheckedState.BorderThickness = 2;
            this.boxFecha.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.boxFecha.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.boxFecha.CheckedChanged += new System.EventHandler(this.boxFecha_CheckedChanged);
            // 
            // boxCooperativa
            // 
            this.boxCooperativa.AutoSize = true;
            this.boxCooperativa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxCooperativa.CheckedState.BorderThickness = 0;
            this.boxCooperativa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxCooperativa.CheckedState.InnerColor = System.Drawing.Color.White;
            this.boxCooperativa.CheckedState.InnerOffset = -4;
            this.boxCooperativa.ForeColor = System.Drawing.Color.Black;
            this.boxCooperativa.Location = new System.Drawing.Point(405, 86);
            this.boxCooperativa.Name = "boxCooperativa";
            this.boxCooperativa.Size = new System.Drawing.Size(122, 22);
            this.boxCooperativa.TabIndex = 3;
            this.boxCooperativa.Text = "Por cooperativa";
            this.boxCooperativa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.boxCooperativa.UncheckedState.BorderThickness = 2;
            this.boxCooperativa.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.boxCooperativa.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.boxCooperativa.CheckedChanged += new System.EventHandler(this.boxCooperativa_CheckedChanged);
            // 
            // txtDato
            // 
            this.txtDato.BorderRadius = 10;
            this.txtDato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDato.DefaultText = "";
            this.txtDato.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDato.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDato.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDato.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDato.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDato.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDato.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDato.Location = new System.Drawing.Point(245, 129);
            this.txtDato.Name = "txtDato";
            this.txtDato.PasswordChar = '\0';
            this.txtDato.PlaceholderText = "Ingresar la cédula";
            this.txtDato.SelectedText = "";
            this.txtDato.Size = new System.Drawing.Size(200, 22);
            this.txtDato.TabIndex = 5;
            this.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BtnConsultar.ForeColor = System.Drawing.Color.Green;
            this.BtnConsultar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.BtnConsultar.IconColor = System.Drawing.Color.Green;
            this.BtnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsultar.Location = new System.Drawing.Point(451, 127);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(35, 32);
            this.BtnConsultar.TabIndex = 6;
            this.BtnConsultar.TabStop = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.fecha);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.DataGridReporte);
            this.guna2GroupBox1.Controls.Add(this.boxFecha);
            this.guna2GroupBox1.Controls.Add(this.BtnConsultar);
            this.guna2GroupBox1.Controls.Add(this.bocCedula);
            this.guna2GroupBox1.Controls.Add(this.txtDato);
            this.guna2GroupBox1.Controls.Add(this.boxCooperativa);
            this.guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(689, 365);
            this.guna2GroupBox1.TabIndex = 7;
            this.guna2GroupBox1.Text = "Reporte de ventas";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(103)))), ((int)(((byte)(129)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(295, 50);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(95, 30);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Filtar datos";
            // 
            // DataGridReporte
            // 
            this.DataGridReporte.AllowUserToAddRows = false;
            this.DataGridReporte.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridReporte.BackgroundColor = System.Drawing.Color.White;
            this.DataGridReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridReporte.ColumnHeadersHeight = 40;
            this.DataGridReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FechaCompra,
            this.Fecha_Salida,
            this.Cedula_Comprador,
            this.Cedula_Cliente,
            this.Cooperativa,
            this.HoraSaldida,
            this.Bus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridReporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridReporte.EnableHeadersVisualStyles = false;
            this.DataGridReporte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridReporte.Location = new System.Drawing.Point(16, 165);
            this.DataGridReporte.Name = "DataGridReporte";
            this.DataGridReporte.ReadOnly = true;
            this.DataGridReporte.RowHeadersVisible = false;
            this.DataGridReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridReporte.Size = new System.Drawing.Size(658, 187);
            this.DataGridReporte.TabIndex = 7;
            this.DataGridReporte.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridReporte.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridReporte.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridReporte.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridReporte.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridReporte.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridReporte.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridReporte.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridReporte.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridReporte.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridReporte.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridReporte.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridReporte.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridReporte.ThemeStyle.ReadOnly = true;
            this.DataGridReporte.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridReporte.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridReporte.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridReporte.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridReporte.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridReporte.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridReporte.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "Id_Compra";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FechaCompra
            // 
            this.FechaCompra.HeaderText = "Fecha Compra";
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.ReadOnly = true;
            // 
            // Fecha_Salida
            // 
            this.Fecha_Salida.HeaderText = "Fecha Salida";
            this.Fecha_Salida.Name = "Fecha_Salida";
            this.Fecha_Salida.ReadOnly = true;
            // 
            // Cedula_Comprador
            // 
            this.Cedula_Comprador.HeaderText = "Cedula comprador";
            this.Cedula_Comprador.Name = "Cedula_Comprador";
            this.Cedula_Comprador.ReadOnly = true;
            // 
            // Cedula_Cliente
            // 
            this.Cedula_Cliente.HeaderText = "Cedula Cliente";
            this.Cedula_Cliente.Name = "Cedula_Cliente";
            this.Cedula_Cliente.ReadOnly = true;
            // 
            // Cooperativa
            // 
            this.Cooperativa.HeaderText = "Nombre Cooperativa";
            this.Cooperativa.Name = "Cooperativa";
            this.Cooperativa.ReadOnly = true;
            // 
            // HoraSaldida
            // 
            this.HoraSaldida.HeaderText = "Hora Salida";
            this.HoraSaldida.Name = "HoraSaldida";
            this.HoraSaldida.ReadOnly = true;
            // 
            // Bus
            // 
            this.Bus.HeaderText = "Placa Bus";
            this.Bus.Name = "Bus";
            this.Bus.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.Checked = true;
            this.fecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fecha.Location = new System.Drawing.Point(226, 127);
            this.fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(219, 32);
            this.fecha.TabIndex = 9;
            this.fecha.Value = new System.DateTime(2022, 3, 9, 15, 34, 35, 26);
            this.fecha.Visible = false;
            // 
            // Reorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 389);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reorte";
            this.Text = "Reorte";
            ((System.ComponentModel.ISupportInitialize)(this.BtnConsultar)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2RadioButton bocCedula;
        private Guna.UI2.WinForms.Guna2RadioButton boxFecha;
        private Guna.UI2.WinForms.Guna2RadioButton boxCooperativa;
        private Guna.UI2.WinForms.Guna2TextBox txtDato;
        private FontAwesome.Sharp.IconPictureBox BtnConsultar;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridReporte;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula_Comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cooperativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSaldida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bus;
        private Guna.UI2.WinForms.Guna2DateTimePicker fecha;
    }
}