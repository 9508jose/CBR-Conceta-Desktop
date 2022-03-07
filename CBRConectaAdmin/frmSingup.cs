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
    public partial class frmSingup : MaterialForm
    {
        Requests q = new Requests();
        public frmSingup()
        {
            InitializeComponent();
            cmbPrivilegios.Items.Add("Administrador");
            cmbPrivilegios.Items.Add("Empleado");
        }

        private void frmSingup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            registroAsync();
        }

        private async Task registroAsync()
        {
            if (txtPass.Text != txtPassPass.Text)
            {
                string message = await q.singupAsync(txtNombre.Text, txtApellido.Text, (cmbPrivilegios.SelectedIndex + 1), txtUsuario.Text, txtPass.Text, txtPuesto.Text, txtDepartamento.Text, txtEmail.Text);
                if (message == "Éxito")
                {
                    MessageBox.Show("¡Registro realizado con éxito!");
                    frmMain main = new frmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    lblMessage.Text = message;
                    lblMessage.Visible = true;
                }
            }
            else
            {
                lblMessage.Text = "Las contraseñas no coinciden";
                lblMessage.Visible = true;
            }
        }
    }
}
