// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="EliminarClienteporAdmin.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
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
    /// <summary>
    /// Class EliminarClienteporAdmin.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ConsultarClienteporAdmin : Form
    {
        /// <summary>
        /// The adm cliente procedimiento
        /// </summary>
        AdmClienteProcedimiento admClienteProcedimiento = new AdmClienteProcedimiento();
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultarClienteporAdmin"/> class.
        /// </summary>
        public ConsultarClienteporAdmin()
        {
            InitializeComponent();
            LllenarDataGrid("Iniciar_data_grid_datos");
        }

        /// <summary>
        /// Handles the Click event of the iconPictureBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {         
            try
            {  
                string DatoCliente = TxtDatoCliente.Text;
                LllenarDataGrid(DatoCliente);
                }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LllenarDataGrid(string DatoCliente)
        {
            try
            {
                List<Cliente> listaCliente = admClienteProcedimiento.ConsultarCliente(DatoCliente);
                TxtDatoCliente.Text = null;
                DataGridCliente.Rows.Clear();
                int x = 0;
                foreach (Cliente c in listaCliente)
                {
                    Console.WriteLine("////////////" + c.Cedula + c.Nombre + c.CredencialUsuario.Correo + "//////////////////");
                    DataGridCliente.Rows.Add(1);
                    DataGridCliente.Rows[x].Cells[1].Value = c.Cedula.ToString();
                    DataGridCliente.Rows[x].Cells[0].Value = c.Nombre.ToString();
                    DataGridCliente.Rows[x].Cells[2].Value = c.CredencialUsuario.Correo.ToString();
                    x++;
                }
            }
            catch (ControlExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridCliente_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.DataGridCliente.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.DataGridCliente.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon("..\\..\\Resources\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 1, e.CellBounds.Top + 1);
                this.DataGridCliente.Rows[e.RowIndex].Height = icoAtomico.Height+2;
                this.DataGridCliente.Columns[e.ColumnIndex].Width = icoAtomico.Width;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.DataGridCliente.Columns[e.ColumnIndex].Name == "Eliminar_Cliente" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.DataGridCliente.Rows[e.RowIndex].Cells["Eliminar_Cliente"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon("..\\..\\Resources\\eliminar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 5, e.CellBounds.Top + 1);
                this.DataGridCliente.Rows[e.RowIndex].Height = icoAtomico.Height+2;
                this.DataGridCliente.Columns[e.ColumnIndex].Width = icoAtomico.Width+10;
                e.Handled = true;
            }
        }

        private void DataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int x = DataGridCliente.CurrentCell.RowIndex;
                string cedulaNombre = DataGridCliente.Rows[x].Cells[1].Value.ToString();
                try
                {
                    admClienteProcedimiento.EliminarCliente(cedulaNombre);
                    MessageBox.Show("Cliente eliminado con exito");
                    DataGridCliente.Rows.Remove(DataGridCliente.CurrentRow);
                }
                catch (ControlExcepcion ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            if (e.ColumnIndex == 4)
            {
                int x = DataGridCliente.CurrentCell.RowIndex;
                string cedula = DataGridCliente.Rows[x].Cells[1].Value.ToString();
                FormEditarPrincipal formEditarPrincipal = new FormEditarPrincipal(1,cedula);
                Form form = VentanaAdministrador.ActiveForm;
                VentanaAdministrador.ActiveForm.Hide();
                formEditarPrincipal.ShowDialog();
                form.Show();
            }
        }
    }
}
