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
using CBRConectaAdmin.Clases;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CBRConectaAdmin
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            var materialSM = MaterialSkinManager.Instance;
            materialSM.AddFormToManage(this);
            materialSM.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSM.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.Red400,
                TextShade.WHITE);
            limpiarTemporales();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            lblLogining.Visible = true;
            lblError.Visible = false;
            await login();
        }

        private async Task login()
        {
            Requests q = new Requests();
            if (await q.login(txtUser.Text, txtPass.Text))
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Datos incorrectos";
                txtUser.Focus();
                btnLogin.Enabled = true;
                lblLogining.Visible = false;
            }
        }

        private void limpiarTemporales()
        {
            try
            {
                Directory.Delete(Application.StartupPath + @"\temp", true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                Directory.CreateDirectory(Application.StartupPath + @"\temp");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
