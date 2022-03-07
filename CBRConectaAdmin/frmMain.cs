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

namespace CBRConectaAdmin
{
    public partial class frmMain : MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.Text = "¡Bienvenido " + UserData.nombre + "!";
        }

        private void txtSubir_Click(object sender, EventArgs e)
        {
            frmUpload men = new frmUpload();
            men.Show();
            this.Hide();
        }

        private void txtObras_Click(object sender, EventArgs e)
        {
            frmProyectos obras = new frmProyectos();
            obras.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmSingup sup = new frmSingup();
            sup.Show();
            this.Hide();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }
    }
}
