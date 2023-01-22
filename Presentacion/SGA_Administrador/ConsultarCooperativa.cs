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

namespace Presentacion.SGA_Administrador
{
    public partial class ConsultarCooperativa : Form
    {
        AdmCooperativa admCooperatica = new AdmCooperativa();
        public ConsultarCooperativa()
        {
            InitializeComponent();
            List<string> lista = admCooperatica.ConsultarCooperativa("Inicio");
            LlenarDataGrid(lista);
        }

        private void LlenarDataGrid(List<string> lista)
        {
            foreach (string x in lista)
            {
                
            }
        }
    }
}
