using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CBRConectaAdmin.Clases;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;

namespace CBRConectaAdmin.ControlProyectos
{
    public partial class CrearProyecto : Form
    {
        string path = "";
        public CrearProyecto()
        {
            InitializeComponent();
        }
        private void txtProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            await crearProyecto();
        }

        private async Task crearProyecto()
        {
            try
            {
                if (dtpFechaInicio.Value.Date < DateTime.Today.Date)
                {
                    lblMessage.Text = "La fecha no es válida";
                    lblMessage.Visible = true;
                }
                else if (path == "")
                {
                    lblMessage.Text = "Seleccione un archivo";
                    lblMessage.Visible = true;
                }
                else
                {
                    Requests req = new Requests();
                    string nombre = txtNombre.Text;
                    DateTime dt = dtpFechaInicio.Value;
                    string noP = txtProyecto.Text;
                    string result = await req.crearProyecto(nombre, dt, noP, "Activa", path);
                    if (result == "Éxito")
                    {
                        MessageBox.Show("¡Proyecto creado con éxito!");
                        lblMessage.Visible = false;
                        txtNombre.Clear();
                        txtProyecto.Clear();
                        dtpFechaInicio.Value = DateTime.Today.Date;
                        path = "";
                        lblDoc.Text = "Documento seleccionado: Ninguno";
                        lblMessage.Visible = false;
                    }
                    else
                    {
                        lblMessage.Text = result;
                        lblMessage.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Selección del archivo
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Selecccionar documento PDF";
            dlg.Filter = "PDF (*.pdf)|*.pdf";
            DialogResult dlgRes = dlg.ShowDialog();
            if (dlgRes != DialogResult.Cancel)
            {
                path = dlg.FileName;
                lblDoc.Text = "Documento seleccionado: " + dlg.SafeFileName;
            }
        }
    }
}
