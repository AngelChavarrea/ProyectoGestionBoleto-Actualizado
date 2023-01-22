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
    public partial class ConsultarChofer : Form
    {
        AdmChofer admChofer = new AdmChofer();
        public ConsultarChofer()
        {
            InitializeComponent();
            LllenarDataGrid("Iniciar_data_grid_datos");
        }
        private void LllenarDataGrid(string DatoVendedor)
        {
            try
            {
                List<Chofer> listaCliente = admChofer.ConsultarChofer(DatoVendedor);
                TxtChofer.Text = null;
                DataGridChofer.Rows.Clear();
                int x = 0;
                foreach (Chofer v in listaCliente)
                {
                    DataGridChofer.Rows.Add(1);
                    DataGridChofer.Rows[x].Cells[1].Value = v.Cedula.ToString();
                    DataGridChofer.Rows[x].Cells[0].Value = v.Nombre.ToString();
                    DataGridChofer.Rows[x].Cells[2].Value = v.CredencialUsuario.Correo.ToString();
                    x++;
                }
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridChofer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.DataGridChofer.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.DataGridChofer.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon("..\\..\\Resources\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 1, e.CellBounds.Top + 1);
                this.DataGridChofer.Rows[e.RowIndex].Height = icoAtomico.Height + 2;
                this.DataGridChofer.Columns[e.ColumnIndex].Width = icoAtomico.Width;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.DataGridChofer.Columns[e.ColumnIndex].Name == "Eliminar_Cliente" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.DataGridChofer.Rows[e.RowIndex].Cells["Eliminar_Cliente"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon("..\\..\\Resources\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 1);
                this.DataGridChofer.Rows[e.RowIndex].Height = icoAtomico.Height + 2;
                this.DataGridChofer.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                e.Handled = true;
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
                LllenarDataGrid(TxtChofer.Text);
        }

        private void DataGridChofer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int x = DataGridChofer.CurrentCell.RowIndex;
                string cedula = DataGridChofer.Rows[x].Cells[1].Value.ToString();
                try
                {
                    admChofer.EliminarChofer(cedula);
                    MessageBox.Show("Vendedor eliminado con exito");
                    DataGridChofer.Rows.Remove(DataGridChofer.CurrentRow);
                }
                catch (ControlExcepcion ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (e.ColumnIndex == 4)
            {
                int x = DataGridChofer.CurrentCell.RowIndex;
                string cedula = DataGridChofer.Rows[x].Cells[1].Value.ToString();
                FormEditarPrincipal formEditarPrincipal = new FormEditarPrincipal(3, cedula);
                Form form = VentanaAdministrador.ActiveForm;
                VentanaAdministrador.ActiveForm.Hide();
                formEditarPrincipal.ShowDialog();
                form.Show();
            }
        }
    }
}
