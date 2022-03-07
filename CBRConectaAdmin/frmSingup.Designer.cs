namespace CBRConectaAdmin
{
    partial class frmSingup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbPrivilegios = new MaterialSkin.Controls.MaterialComboBox();
            this.txtPuesto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDepartamento = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassPass = new MaterialSkin.Controls.MaterialTextBox();
            this.lblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = global::CBRConectaAdmin.Properties.Resources.person;
            this.txtNombre.LeaveOnEnterKey = true;
            this.txtNombre.Location = new System.Drawing.Point(110, 147);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(460, 50);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtApellido
            // 
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.LeadingIcon = global::CBRConectaAdmin.Properties.Resources.person_fill;
            this.txtApellido.LeaveOnEnterKey = true;
            this.txtApellido.Location = new System.Drawing.Point(110, 203);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(460, 50);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "";
            this.txtApellido.TrailingIcon = null;
            // 
            // cmbPrivilegios
            // 
            this.cmbPrivilegios.AutoResize = false;
            this.cmbPrivilegios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPrivilegios.Depth = 0;
            this.cmbPrivilegios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPrivilegios.DropDownHeight = 174;
            this.cmbPrivilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrivilegios.DropDownWidth = 121;
            this.cmbPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPrivilegios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPrivilegios.FormattingEnabled = true;
            this.cmbPrivilegios.Hint = "Privilegios";
            this.cmbPrivilegios.IntegralHeight = false;
            this.cmbPrivilegios.ItemHeight = 43;
            this.cmbPrivilegios.Location = new System.Drawing.Point(110, 260);
            this.cmbPrivilegios.MaxDropDownItems = 4;
            this.cmbPrivilegios.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPrivilegios.Name = "cmbPrivilegios";
            this.cmbPrivilegios.Size = new System.Drawing.Size(460, 49);
            this.cmbPrivilegios.StartIndex = 0;
            this.cmbPrivilegios.TabIndex = 2;
            // 
            // txtPuesto
            // 
            this.txtPuesto.AnimateReadOnly = false;
            this.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuesto.Depth = 0;
            this.txtPuesto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPuesto.Hint = "Puesto";
            this.txtPuesto.LeadingIcon = global::CBRConectaAdmin.Properties.Resources.person_workspace;
            this.txtPuesto.LeaveOnEnterKey = true;
            this.txtPuesto.Location = new System.Drawing.Point(110, 483);
            this.txtPuesto.MaxLength = 50;
            this.txtPuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPuesto.Multiline = false;
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(460, 50);
            this.txtPuesto.TabIndex = 6;
            this.txtPuesto.Text = "";
            this.txtPuesto.TrailingIcon = null;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.AnimateReadOnly = false;
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepartamento.Depth = 0;
            this.txtDepartamento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDepartamento.Hint = "Departamento";
            this.txtDepartamento.LeadingIcon = global::CBRConectaAdmin.Properties.Resources.shop_window;
            this.txtDepartamento.LeaveOnEnterKey = true;
            this.txtDepartamento.Location = new System.Drawing.Point(110, 539);
            this.txtDepartamento.MaxLength = 50;
            this.txtDepartamento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDepartamento.Multiline = false;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(460, 50);
            this.txtDepartamento.TabIndex = 7;
            this.txtDepartamento.Text = "";
            this.txtDepartamento.TrailingIcon = null;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = false;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(368, 654);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(158, 36);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(142, 654);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(158, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancelar.UseAccentColor = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(159, 107);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(351, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Ingresa la información para el registro del usuario";
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = global::CBRConectaAdmin.Properties.Resources.envelope_fill;
            this.txtEmail.LeaveOnEnterKey = true;
            this.txtEmail.Location = new System.Drawing.Point(110, 595);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(460, 50);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtPass
            // 
            this.txtPass.AnimateReadOnly = false;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.Hint = "Contraseña";
            this.txtPass.LeadingIcon = global::CBRConectaAdmin.Properties.Resources.key_fill;
            this.txtPass.LeaveOnEnterKey = true;
            this.txtPass.Location = new System.Drawing.Point(110, 371);
            this.txtPass.MaxLength = 50;
            this.txtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Password = true;
            this.txtPass.Size = new System.Drawing.Size(460, 50);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "";
            this.txtPass.TrailingIcon = null;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.LeadingIcon = global::CBRConectaAdmin.Properties.Resources.person_circle;
            this.txtUsuario.LeaveOnEnterKey = true;
            this.txtUsuario.Location = new System.Drawing.Point(110, 315);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(460, 50);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // txtPassPass
            // 
            this.txtPassPass.AnimateReadOnly = false;
            this.txtPassPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassPass.Depth = 0;
            this.txtPassPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassPass.Hint = "Repite contraseña";
            this.txtPassPass.LeadingIcon = global::CBRConectaAdmin.Properties.Resources.key_fill;
            this.txtPassPass.LeaveOnEnterKey = true;
            this.txtPassPass.Location = new System.Drawing.Point(110, 427);
            this.txtPassPass.MaxLength = 50;
            this.txtPassPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassPass.Multiline = false;
            this.txtPassPass.Name = "txtPassPass";
            this.txtPassPass.Password = true;
            this.txtPassPass.Size = new System.Drawing.Size(460, 50);
            this.txtPassPass.TabIndex = 5;
            this.txtPassPass.Text = "";
            this.txtPassPass.TrailingIcon = null;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.Depth = 0;
            this.lblMessage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMessage.HighEmphasis = true;
            this.lblMessage.Location = new System.Drawing.Point(110, 696);
            this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(460, 43);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Error";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // frmSingup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 747);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtPassPass);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cmbPrivilegios);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmSingup";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSingup_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialComboBox cmbPrivilegios;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtPass;
        private MaterialSkin.Controls.MaterialTextBox txtPuesto;
        private MaterialSkin.Controls.MaterialTextBox txtDepartamento;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtPassPass;
        private MaterialSkin.Controls.MaterialLabel lblMessage;
    }
}