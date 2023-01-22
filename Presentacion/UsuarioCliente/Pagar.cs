// ***********************************************************************
// Assembly         : Presentacion
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Pagar.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using LogicaDeNegocios;
using Presentacion.InicioFroms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Diagnostics;

namespace Presentacion.UsuarioCliente
{
    /// <summary>
    /// Class Pagar.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Pagar : Form
    {
        int idBusNuevo;
        string cedula;
        List<string> asientos = new List<string>();
        AdmPago admpago = new AdmPago();
        Pago p = new Pago();
        /// <summary>
        /// Initializes a new instance of the <see cref="Pagar"/> class.
        /// </summary>
        /// <param name="texto">The texto.</param>
        /// <param name="cooperativa">The cooperativa.</param>
        /// <param name="fechaSalida">The fecha salida.</param>
        /// <param name="horaSalida">The hora salida.</param>
        public Pagar(string texto, int idBusNuevo, string cedula, List<string> asientos)
        {
            InitializeComponent();
            AdmPago ap = new AdmPago();
            txtTotal.Text += ap.calcularTotalPagar(Comprar.getPrecio());
            InfBoleto.Text += texto;
            this.idBusNuevo = idBusNuevo;
            this.cedula = cedula;
            this.asientos = asientos;
        }
        /// <summary>
        /// Releases the capture.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="hwnd">The HWND.</param>
        /// <param name="wmsg">The WMSG.</param>
        /// <param name="wparam">The wparam.</param>
        /// <param name="lparam">The lparam.</param>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /// <summary>
        /// Handles the MouseMove event of the guna2Panel1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //metodo para regresar a paginade conpra.
        /// <summary>
        /// Handles the Click event of the BotonRetroceder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnPagar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (Pago.pagarBoleto(idBusNuevo, cedula,asientos))
            {
                btnPagar.Visible = false;
                InfBoleto.Text = null;
                btnImprimir.Visible = true;
                txtTotal.Text = null;
                PanelSegundario.Visible = true;
                Box1.Visible = false;
                BotonRetroceder.Visible = false;
            }
           else{
                MessageBox.Show("Error al comprar");
            }           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnPagar.Visible == true)
            {
                this.Close();
                BuscarBus.Ventana_ventaBoletos.Show();
            }
            else
            {
                this.Close();
                BuscarBus.Ventana_ventaBoletos.Close();
                Program.Principal.Show();
                Comprar.VaciarLista();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string paginaHtml_text = Properties.Resources.Presentar.ToString();
            paginaHtml_text = paginaHtml_text.Replace("@fechas", DateTime.Now.ToString("dd/MM/yyyy"));
            List<string> lista = Pago.GuardarPdf();
            if (lista[2] == "")
            {
                paginaHtml_text = paginaHtml_text.Replace("@cliente", "Consumidor Final");
            }
            else
            {
                paginaHtml_text = paginaHtml_text.Replace("@cliente", lista[2]);
            }
            paginaHtml_text = paginaHtml_text.Replace("@Filax", lista[0]);
            paginaHtml_text = paginaHtml_text.Replace("@Total", lista[1]);
            string ruta = @"C:\Users\sergi\Documents\6TO SEMESTRE\Construccion de software\AcrobatXIPortable" + ".pdf";
                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    Document pdfDocument = new Document(PageSize.A4, 20, 20, 20, 20);
                    PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDocument, stream);
                    pdfDocument.Open();
                    pdfDocument.Add(new Phrase());
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.pngtree_blue_big_car_illustration_cartoon_shuttle_blue_bus_gray_glass_png_image_4543101, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(100, 100);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDocument.LeftMargin, pdfDocument.Top - 80);
                    pdfDocument.Add(img);
                    using (StringReader sr = new StringReader(paginaHtml_text))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, pdfDocument, sr);
                    }
                    pdfDocument.Close();
                    stream.Close();
                }
                Imprimir imprimir = new Imprimir();
                imprimir.printPDFWithAcrobat(ruta);
                MessageBox.Show("El boleto se imprimio correctamente");
                this.Close();
                BuscarBus.Ventana_ventaBoletos.Close();
                Program.Principal.Show();
                Comprar.VaciarLista(); 
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "BoletoGenerado" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            guardar.Filter = "Pdf Files|*.pdf";
            string paginaHtml_text = Properties.Resources.Presentar.ToString();
            paginaHtml_text = paginaHtml_text.Replace("@fechas", DateTime.Now.ToString("dd/MM/yyyy"));
            List<string> lista = Pago.GuardarPdf();
            if (lista[2]=="")
            {
                paginaHtml_text = paginaHtml_text.Replace("@cliente", "Consumidor Final");
            }
            else
            {
                paginaHtml_text = paginaHtml_text.Replace("@cliente", lista[2]);
            }
            paginaHtml_text = paginaHtml_text.Replace("@Filax",lista[0]);
            paginaHtml_text = paginaHtml_text.Replace("@Total", lista[1]);
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDocument = new Document(PageSize.A4, 20, 20, 20, 20);
                    PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDocument, stream);
                    pdfDocument.Open();
                    pdfDocument.Add(new Phrase());
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.pngtree_blue_big_car_illustration_cartoon_shuttle_blue_bus_gray_glass_png_image_4543101, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(100, 100);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDocument.LeftMargin, pdfDocument.Top - 80);
                    pdfDocument.Add(img);
                    using (StringReader sr = new StringReader(paginaHtml_text))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, pdfDocument, sr);
                    }
                    pdfDocument.Close();
                    stream.Close();
                }
                MessageBox.Show("El boleto se guardo correctamente");
                Process.Start(guardar.FileName);
                this.Close();
                BuscarBus.Ventana_ventaBoletos.Close();
                Program.Principal.Show();
                Comprar.VaciarLista();
            }
        }
    }
}
