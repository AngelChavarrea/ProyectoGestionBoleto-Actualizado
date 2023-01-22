using LogicaDeNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.SGA_Cooperativa
{
    public partial class GenerarBoleto : Form
    {
        int idCooperativa;
        AdmCooperativa admCooperativa = new AdmCooperativa();
        public GenerarBoleto(int idCooperativa)
        {
            InitializeComponent();
            this.idCooperativa = idCooperativa;
            admCooperativa.LLenarCombos(idCooperativa,cbRuta, 0);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (cbBus.Text==""||cbRuta.Text=="")
            {
                MessageBox.Show("Por favor ingresar datos validos");
            }
            else
            {
                string x = cbRuta.Text;
                char first = x.FirstOrDefault();
                string numero = first.ToString();
                int xx = Convert.ToInt32(numero);
                try
                {
                  admCooperativa.GenerarBoleto(xx, cbBus.Text, FechaSalida.Text, HoraSalida.Text, Precio.Text);
                    MessageBox.Show("Boleto generado con exito");
                    Precio.Text = null;
                    cbBus.Text = null;
                }
                catch (ControlExcepcion ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            
        }

        private void cbBus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBus.Items.Clear();
            string x = cbRuta.Text;
            char first = x.FirstOrDefault();
            string numero = first.ToString();
            int xx = Convert.ToInt32(numero);
            admCooperativa.LLenarCombos(idCooperativa,cbBus, xx);
        }
    }
}
