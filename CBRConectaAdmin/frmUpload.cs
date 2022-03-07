using CBRConectaAdmin.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;

namespace CBRConectaAdmin
{
    public partial class frmUpload : MaterialForm
    {
        private Requests req = new Requests();
        private string path = "";
        private bool hayDoc = false;
        private dynamic jsonGot;
        private int idSel = 0;
        public frmUpload()
        {
            InitializeComponent();
            var materialSM = MaterialSkinManager.Instance;
            materialSM.AddFormToManage(this);
            materialSM.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSM.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
            rellenarCMB();
            obtenerCatalogo();
            this.Text = "Subir archivo - " + UserData.nombre +"!";
        }

        void rellenarCMB()
        {
            cmbRubro.Items.Add("Reportes fotográficos");
            cmbRubro.Items.Add("Control de obra");
            cmbRubro.Items.Add("Operaciones y mantenimiento");
            cmbRubro.Items.Add("Liberación de colado");
        }

        //Obtiene el catálogo de PDFs
        async void obtenerCatalogo()
        {
            dynamic data = await req.obtenerCatalogo();
            if (data != null)jsonGot = JValue.Parse(data);
        }

        private void cmbArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdjuntar.Enabled = false;
            btnCargar.Enabled = false;
            btnAdjuntar.Text = "Adjuntar documento";
            lblPDFSel.Visible = false;
            cardPDF.Visible = false;
            cmbDocumento.Items.Clear();
            cmbDocumento.Enabled = true;
            imgEmpty.Visible = false;
            hayDoc = false;
            idSel = 0;
            switch (cmbRubro.SelectedIndex)
            {
                case 0:
                    cmbDocumento.Items.Add("Visita técnica");
                    cmbDocumento.Items.Add("Arranque y PM");
                    cmbDocumento.Items.Add("Avance semanal");
                    break;
                case 1:
                    cmbDocumento.Items.Add("Minuta de campo");
                    cmbDocumento.Items.Add("Bitácora de obra");
                    cmbDocumento.Items.Add("Requisición de material");
                    cmbDocumento.Items.Add("Dispersión");
                    cmbDocumento.Items.Add("Asistencia");
                    cmbDocumento.Items.Add("Almacén");
                    cmbDocumento.Items.Add("Comprobación de gastos");
                    cmbDocumento.Items.Add("Insumos");
                    cmbDocumento.Items.Add("Programa de obra");
                    cmbDocumento.Items.Add("Orden de cambio");
                    break;
                case 2:
                    cmbDocumento.Items.Add("Constancia de capacitación");
                    cmbDocumento.Items.Add("Formato de visita técnica");
                    cmbDocumento.Items.Add("Bitácora de operación y mantenimiento");
                    cmbDocumento.Items.Add("Inscripción al programa de asistencia técnica");
                    cmbDocumento.Items.Add("Encuesta de satisfacción de servicio");
                    cmbDocumento.Items.Add("Encuesta de satisfacción de arranque y puesta en marcha");
                    break;
                case 3:
                    cmbDocumento.Items.Add("Trazo y nivelación");
                    cmbDocumento.Items.Add("Acero de refuerzo");
                    cmbDocumento.Items.Add("Cimbra");
                    cmbDocumento.Items.Add("Programa colado");
                    cmbDocumento.Items.Add("Liberación de colado");
                    break;
            }
            axAcroPDF1.Visible = false;
        }

        private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            btnAdjuntar.Enabled = true;
            path = String.Empty;
            lblPDFSel.Visible = false;
            cardPDF.Visible = false;
            hayDoc = false;
            if (cmbDocumento.SelectedIndex != -1)
            {
                visualizarPDFAsync(1);
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            buscarPDF();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            guardarPDFAsync();
        }

        private async Task visualizarPDFAsync(int mode)
        {
            switch (mode)
            {
                case 1:
                    string rubro = cmbRubro.SelectedItem.ToString(), documento = cmbDocumento.SelectedItem.ToString();
                    byte[] pdf = null;
                    if (jsonGot != null)
                    {
                        if (((IEnumerable<dynamic>)jsonGot).Where(archivo => archivo.rubro == rubro && archivo.identificador == documento).Count() > 0)
                        {
                            foreach (var archivo in ((IEnumerable<dynamic>)jsonGot).Where(archivo => archivo.rubro == rubro && archivo.identificador == documento))
                            {
                                idSel = archivo.id;
                            }
                            pdf = await req.obtenerPDFAsync(idSel);
                        }
                    }
                    if (pdf != null)
                    {
                        string filename = Application.StartupPath + @"\temp\" + Guid.NewGuid().ToString().Substring(0, 10);
                        System.IO.File.WriteAllBytes(filename, pdf);
                        axAcroPDF1.src = filename;
                        axAcroPDF1.Visible = true;
                        btnAdjuntar.Text = "Reemplazar documento";
                        imgEmpty.Visible = false;
                        btnAdjuntar.Enabled = true;
                        hayDoc = true;

                    }
                    else if (pdf == null)
                    {
                        axAcroPDF1.Visible = false;
                        btnAdjuntar.Text = "Adjuntar documento";
                        imgEmpty.Visible = true;
                        btnAdjuntar.Enabled = true;
                        hayDoc = false;
                        idSel = 0;
                    }
                    break;
                case 2:
                    axAcroPDF1.src = path;
                    axAcroPDF1.Visible = true;
                    imgEmpty.Visible = false;
                    break;
            }
        }

        private async Task guardarPDFAsync()
        {
            string rubro = cmbRubro.SelectedItem.ToString();
            string iden = cmbDocumento.SelectedItem.ToString();
            if (hayDoc)
            {
                if (await req.actualizarPDFAsync(idSel,rubro, iden, path))
                {
                    btnCargar.Enabled = false;
                    lblPDFSel.Visible = false;
                    cardPDF.Visible = false;
                    path = String.Empty;
                    MessageBox.Show("¡El archivo se actualizó correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obtenerCatalogo();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al intentar subir el archivo", "¡Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (await req.guardarPDFAsync(rubro, iden, path))
                {
                    btnCargar.Enabled = false;
                    lblPDFSel.Visible = false;
                    cardPDF.Visible = false;
                    path = String.Empty;
                    hayDoc = true;
                    MessageBox.Show("¡El archivo se subió correctamente!", "¡Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obtenerCatalogo();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al intentar subir el archivo", "¡Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hayDoc = false;
                    idSel = 0;
                }
            }

        }

        private void buscarPDF()
        {
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Selección del archivo
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Selecccionar documento PDF";
            dlg.Filter = "PDF (*.pdf)|*.pdf";
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                path = dlg.FileName;
                lblPDFSel.Text = path;
                lblPDFSel.Visible = true;
                cardPDF.Visible = true;
                btnCargar.Enabled = true;
                visualizarPDFAsync(2);
            }
        }

        private void frmMen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
