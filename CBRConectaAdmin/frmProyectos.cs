using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using CBRConectaAdmin.ControlProyectos;
using CBRConectaAdmin.Clases;

namespace CBRConectaAdmin
{
    public partial class frmProyectos : MaterialForm
    {
        public frmProyectos()
        {
            InitializeComponent();
            cargarVentanaAsync();
        }

        private void frmObras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private async Task cargarVentanaAsync()
        {
            Requests req = new Requests();
            var lista = await req.obtenerProyectos();
            VerProyecto obsActivas = new VerProyecto(1, lista) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.tabActiva.Controls.Add(obsActivas);
            obsActivas.Show();
            VerProyecto obsInactivas = new VerProyecto(2, lista) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.tabInactivas.Controls.Add(obsInactivas);
            obsInactivas.Show();
            CrearProyecto obsNueva = new CrearProyecto() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.tabNuevo.Controls.Add(obsNueva);
            obsNueva.Show();
        }
    }
}
