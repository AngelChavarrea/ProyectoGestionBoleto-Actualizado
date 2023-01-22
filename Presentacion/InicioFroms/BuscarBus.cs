// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="BuscarBus.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using System;
using System.Windows.Forms;

namespace Presentacion.InicioFroms
{
    /// <summary>
    /// Class BuscarBus.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class BuscarBus : Form
    {
        /// <summary>
        /// The procedimientos
        /// </summary>
        public string cedula;
         public static Comprar Ventana_ventaBoletos = null;
        ConsultasProcedimientos procedimientos = new ConsultasProcedimientos();
        /// <summary>
        /// Initializes a new instance of the <see cref="BuscarBus"/> class.
        /// </summary>
        public BuscarBus(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            procedimientos.LlenarCombos(cbOrigen, cbDestino);
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the cbDestino control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                EliminarComboElementos();
                procedimientos.LlenarComboCooperativa(cbCooperativa, origen, Destino);

            }
        }

        /// <summary>
        /// Comprobars the combo vacio.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool Comprobar_combo_vacio()
        {
            bool bandera = false;
            if (!cbOrigen.SelectedIndex.Equals(-1) && !cbDestino.SelectedIndex.Equals(-1))
            {
                bandera = true;
            }
            return bandera;
        }

        /// <summary>
        /// Eliminars the combo elementos.
        /// </summary>
        private void EliminarComboElementos()
        {
            cbCooperativa.Items.Clear();
            DataGridInf.Rows.Clear();
        }
        /// <summary>
        /// Handles the CellContentClick event of the DataGridInf control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void DataGridInf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    if (procedimientos.ValidarDataGridVacio(DataGridInf))
                    {
                        int x = DataGridInf.CurrentCell.RowIndex;
                        string cooperativa = DataGridInf.Rows[x].Cells[0].Value.ToString();
                        string fecha_salida = DataGridInf.Rows[x].Cells[1].Value.ToString();
                        string horario_salida = DataGridInf.Rows[x].Cells[2].Value.ToString();
                        Ventana_ventaBoletos = new Comprar(cooperativa, fecha_salida, horario_salida,cedula);
                        Program.Principal.Hide();
                        Ventana_ventaBoletos.ShowDialog();
                    }
                }
                catch (ControlExcepcion ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        /// <summary>
        /// Validacions the cooperativa.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool Validacion_Cooperativa()
        {
            if (!cbCooperativa.SelectedIndex.Equals(-1))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the cbCooperativa control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbCooperativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validacion_Cooperativa() && Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                string cooperativa = cbCooperativa.Text;
                DataGridInf.Rows.Clear();
                procedimientos.LLenarGrit(origen, Destino, cooperativa, DataGridInf);
                DataGridInf.ClearSelection();
            }
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the cbOrigen control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comprobar_combo_vacio())
            {
                string origen = cbOrigen.Text;
                string Destino = cbDestino.Text;
                EliminarComboElementos();
                procedimientos.LlenarComboCooperativa(cbCooperativa, origen, Destino);
            }
        }
    }
}
