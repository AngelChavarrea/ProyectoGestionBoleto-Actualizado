using Presentacion.SGA_Chofer;
using Presentacion.SGA_Vendedor;
using Presentacion.UsuarioCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.SGA_Administrador
{
    public partial class FormEditarPrincipal : Form
    {
        string dato;
        public FormEditarPrincipal(int TipoUsuario, string dato)
        {
            InitializeComponent();
            this.dato = dato;
            IniciarFrom(TipoUsuario);
        }

        private void IniciarFrom(int tipoUsuario)
        {
            if (tipoUsuario == 1)
            {
                PerfilCliente perfilCliente = new PerfilCliente(dato,true);
                perfilCliente.TopLevel = false;
                PanelPrincipal.Controls.Add(perfilCliente);    
                perfilCliente.Show();
            }
            if (tipoUsuario == 2)
            {
                PerfilVendedor perfilCliente = new PerfilVendedor(dato);
                perfilCliente.TopLevel = false;
                PanelPrincipal.Controls.Add(perfilCliente);
                perfilCliente.Show();
            }
            if (tipoUsuario == 3)
            {
                PerfilChofer perfilCliente = new PerfilChofer(dato);
                perfilCliente.TopLevel = false;
                PanelPrincipal.Controls.Add(perfilCliente);
                perfilCliente.Show();
            }
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
