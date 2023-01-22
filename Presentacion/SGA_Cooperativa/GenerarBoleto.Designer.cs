
namespace Presentacion.SGA_Cooperativa
{
    partial class GenerarBoleto
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.HoraSalida = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Precio = new Guna.UI2.WinForms.Guna2TextBox();
            this.FechaSalida = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbBus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbRuta = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.HoraSalida);
            this.guna2GroupBox1.Controls.Add(this.iconButton1);
            this.guna2GroupBox1.Controls.Add(this.Precio);
            this.guna2GroupBox1.Controls.Add(this.FechaSalida);
            this.guna2GroupBox1.Controls.Add(this.iconPictureBox1);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.Controls.Add(this.cbBus);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.cbRuta);
            this.guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(17, 13);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(689, 365);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Generar boleto";
            // 
            // HoraSalida
            // 
            this.HoraSalida.Animated = true;
            this.HoraSalida.BorderRadius = 10;
            this.HoraSalida.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.HoraSalida.Checked = true;
            this.HoraSalida.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.HoraSalida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraSalida.Location = new System.Drawing.Point(510, 208);
            this.HoraSalida.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.HoraSalida.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ShowUpDown = true;
            this.HoraSalida.Size = new System.Drawing.Size(124, 30);
            this.HoraSalida.TabIndex = 13;
            this.HoraSalida.Value = new System.DateTime(2022, 3, 11, 16, 52, 41, 476);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(290, 300);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(114, 46);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Generar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Precio
            // 
            this.Precio.BorderRadius = 10;
            this.Precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Precio.DefaultText = "";
            this.Precio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Precio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Precio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Precio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Precio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Precio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Precio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Precio.Location = new System.Drawing.Point(510, 256);
            this.Precio.Name = "Precio";
            this.Precio.PasswordChar = '\0';
            this.Precio.PlaceholderText = "";
            this.Precio.SelectedText = "";
            this.Precio.Size = new System.Drawing.Size(124, 22);
            this.Precio.TabIndex = 11;
            // 
            // FechaSalida
            // 
            this.FechaSalida.Animated = true;
            this.FechaSalida.BorderRadius = 10;
            this.FechaSalida.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.FechaSalida.Checked = true;
            this.FechaSalida.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.FechaSalida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaSalida.Location = new System.Drawing.Point(510, 157);
            this.FechaSalida.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FechaSalida.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.ShowUpDown = true;
            this.FechaSalida.Size = new System.Drawing.Size(124, 30);
            this.FechaSalida.TabIndex = 8;
            this.FechaSalida.Value = new System.DateTime(2022, 3, 11, 16, 52, 41, 476);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BusAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(205)))), ((int)(((byte)(221)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 88;
            this.iconPictureBox1.Location = new System.Drawing.Point(300, 48);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(89, 88);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(394, 254);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(90, 24);
            this.guna2HtmlLabel5.TabIndex = 6;
            this.guna2HtmlLabel5.Text = "Precio boleto";
            // 
            // cbBus
            // 
            this.cbBus.BackColor = System.Drawing.Color.Transparent;
            this.cbBus.BorderRadius = 15;
            this.cbBus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBus.ItemHeight = 30;
            this.cbBus.Location = new System.Drawing.Point(112, 206);
            this.cbBus.Name = "cbBus";
            this.cbBus.Size = new System.Drawing.Size(228, 36);
            this.cbBus.TabIndex = 5;
            this.cbBus.SelectedIndexChanged += new System.EventHandler(this.cbBus_SelectedIndexChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(28, 213);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(72, 24);
            this.guna2HtmlLabel4.TabIndex = 4;
            this.guna2HtmlLabel4.Text = "Elegir Bus";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(383, 211);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(101, 24);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Hora de salida";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(378, 159);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(106, 24);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Fecha de salida";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 157);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 24);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Elegir ruta";
            // 
            // cbRuta
            // 
            this.cbRuta.AutoRoundedCorners = true;
            this.cbRuta.BackColor = System.Drawing.Color.Transparent;
            this.cbRuta.BorderRadius = 17;
            this.cbRuta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRuta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRuta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRuta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRuta.ItemHeight = 30;
            this.cbRuta.Location = new System.Drawing.Point(106, 150);
            this.cbRuta.Name = "cbRuta";
            this.cbRuta.Size = new System.Drawing.Size(234, 36);
            this.cbRuta.TabIndex = 0;
            this.cbRuta.SelectedIndexChanged += new System.EventHandler(this.cbRuta_SelectedIndexChanged);
            // 
            // GenerarBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 391);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerarBoleto";
            this.Text = "GenerarBoleto";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbBus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbRuta;
        private Guna.UI2.WinForms.Guna2DateTimePicker FechaSalida;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2TextBox Precio;
        private Guna.UI2.WinForms.Guna2DateTimePicker HoraSalida;
    }
}