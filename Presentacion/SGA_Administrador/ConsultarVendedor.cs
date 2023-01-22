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
    public partial class ConsultarVendedor : Form
    {
        AdmVendedor admVendedor = new AdmVendedor();
        public ConsultarVendedor()
        {
            InitializeComponent();
            LllenarDataGrid("Iniciar_data_grid_datos");
        }
        private void LllenarDataGrid(string DatoVendedor)
        {
            try
            {
                List<Vendedor> listaCliente = admVendedor.ConsultarVendedor(DatoVendedor);
                TxtCedulaVendedor.Text = null;
                DataGridVendedor.Rows.Clear();
                int x = 0;
                foreach (Vendedor v in listaCliente)
                {
                    DataGridVendedor.Rows.Add(1);
                    DataGridVendedor.Rows[x].Cells[1].Value = v.Cedula.ToString();
                    DataGridVendedor.Rows[x].Cells[0].Value = v.Nombre.ToString();
                    DataGridVendedor.Rows[x].Cells[2].Value = v.CredencialUsuario.Correo.ToString();
                    x++;
                }
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridVendedor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.DataGridVendedor.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.DataGridVendedor.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon("..\\..\\Resources\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 1, e.CellBounds.Top + 1);
                this.DataGridVendedor.Rows[e.RowIndex].Height = icoAtomico.Height + 2;
                this.DataGridVendedor.Columns[e.ColumnIndex].Width = icoAtomico.Width;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.DataGridVendedor.Columns[e.ColumnIndex].Name == "Eliminar_Cliente" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.DataGridVendedor.Rows[e.RowIndex].Cells["Eliminar_Cliente"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon("..\\..\\Resources\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 1);
                this.DataGridVendedor.Rows[e.RowIndex].Height = icoAtomico.Height + 2;
                this.DataGridVendedor.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }
        }

        private void DataGridVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int x = DataGridVendedor.CurrentCell.RowIndex;
                string cedulaNombre = DataGridVendedor.Rows[x].Cells[1].Value.ToString();
                try
                {
                    admVendedor.EliminarVendedor(cedulaNombre);
                    MessageBox.Show("Vendedor eliminado con exito");
                    DataGridVendedor.Rows.Remove(DataGridVendedor.CurrentRow);
                }
                catch (ControlExcepcion ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (e.ColumnIndex == 4)
            {
                int x = DataGridVendedor.CurrentCell.RowIndex;
                string cedula = DataGridVendedor.Rows[x].Cells[1].Value.ToString();
                FormEditarPrincipal formEditarPrincipal = new FormEditarPrincipal(2, cedula);
                Form form = VentanaAdministrador.ActiveForm;
                VentanaAdministrador.ActiveForm.Hide();
                formEditarPrincipal.ShowDialog();
                form.Show();
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            string dato = TxtCedulaVendedor.Text;        
            LllenarDataGrid(dato);
        }
    }
}
