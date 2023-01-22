
namespace Presentacion.SGA_Administrador
{
    partial class ConsultarCooperativa
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
            this.BtnConsultar = new FontAwesome.Sharp.IconPictureBox();
            this.TxtCedulaCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DataGridCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar_Cliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.DataGridCliente);
            this.guna2GroupBox1.Controls.Add(this.BtnConsultar);
            this.guna2GroupBox1.Controls.Add(this.TxtCedulaCliente);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(689, 365);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Eliminar cooperativa";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.BtnConsultar.ForeColor = System.Drawing.Color.Green;
            this.BtnConsultar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.BtnConsultar.IconColor = System.Drawing.Color.Green;
            this.BtnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsultar.Location = new System.Drawing.Point(493, 71);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(35, 32);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.TabStop = false;
            // 
            // TxtCedulaCliente
            // 
            this.TxtCedulaCliente.BackColor = System.Drawing.Color.Transparent;
            this.TxtCedulaCliente.BorderRadius = 12;
            this.TxtCedulaCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCedulaCliente.DefaultText = "";
            this.TxtCedulaCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCedulaCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCedulaCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCedulaCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCedulaCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCedulaCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCedulaCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCedulaCliente.Location = new System.Drawing.Point(215, 71);
            this.TxtCedulaCliente.Name = "TxtCedulaCliente";
            this.TxtCedulaCliente.PasswordChar = '\0';
            this.TxtCedulaCliente.PlaceholderText = "Ingresar el nombre de la cooperativa a eliminar";
            this.TxtCedulaCliente.SelectedText = "";
            this.TxtCedulaCliente.Size = new System.Drawing.Size(272, 30);
            this.TxtCedulaCliente.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(138, 71);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(71, 30);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Nombre:";
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
            this.Id,
            this.Nombre,
            this.Propietario,
            this.Eliminar_Cliente,
            this.Editar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridCliente.EnableHeadersVisualStyles = false;
            this.DataGridCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridCliente.Location = new System.Drawing.Point(17, 124);
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
            this.DataGridCliente.Size = new System.Drawing.Size(659, 229);
            this.DataGridCliente.TabIndex = 4;
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
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Propietario
            // 
            this.Propietario.HeaderText = "Propietario";
            this.Propietario.Name = "Propietario";
            this.Propietario.ReadOnly = true;
            this.Propietario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // ConsultarCooperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 389);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarCooperativa";
            this.Text = "EliminarCooperativa";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private FontAwesome.Sharp.IconPictureBox BtnConsultar;
        private Guna.UI2.WinForms.Guna2TextBox TxtCedulaCliente;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar_Cliente;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}