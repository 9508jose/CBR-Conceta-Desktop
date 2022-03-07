namespace CBRConectaAdmin
{
    partial class frmMain
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
            this.txtSubir = new MaterialSkin.Controls.MaterialButton();
            this.txtObras = new MaterialSkin.Controls.MaterialButton();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubir
            // 
            this.txtSubir.AutoSize = false;
            this.txtSubir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtSubir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txtSubir.Depth = 0;
            this.txtSubir.HighEmphasis = true;
            this.txtSubir.Icon = null;
            this.txtSubir.Location = new System.Drawing.Point(49, 287);
            this.txtSubir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSubir.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSubir.Name = "txtSubir";
            this.txtSubir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtSubir.Size = new System.Drawing.Size(263, 36);
            this.txtSubir.TabIndex = 0;
            this.txtSubir.Text = "Subir formato";
            this.txtSubir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txtSubir.UseAccentColor = false;
            this.txtSubir.UseVisualStyleBackColor = true;
            this.txtSubir.Click += new System.EventHandler(this.txtSubir_Click);
            // 
            // txtObras
            // 
            this.txtObras.AutoSize = false;
            this.txtObras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtObras.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txtObras.Depth = 0;
            this.txtObras.HighEmphasis = true;
            this.txtObras.Icon = null;
            this.txtObras.Location = new System.Drawing.Point(49, 335);
            this.txtObras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtObras.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObras.Name = "txtObras";
            this.txtObras.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtObras.Size = new System.Drawing.Size(263, 36);
            this.txtObras.TabIndex = 1;
            this.txtObras.Text = "Ver obras";
            this.txtObras.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txtObras.UseAccentColor = false;
            this.txtObras.UseVisualStyleBackColor = true;
            this.txtObras.Click += new System.EventHandler(this.txtObras_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = false;
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.HighEmphasis = true;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(49, 383);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(263, 36);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar usuario";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = false;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(92, 484);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(178, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CBRConectaAdmin.Properties.Resources.logo_max;
            this.pictureBox1.Location = new System.Drawing.Point(70, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtObras);
            this.Controls.Add(this.txtSubir);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton txtSubir;
        private MaterialSkin.Controls.MaterialButton txtObras;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}