
namespace CBRConectaAdmin
{
    partial class frmProyectos
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
            this.btnRegresar = new MaterialSkin.Controls.MaterialButton();
            this.tabInactivas = new System.Windows.Forms.TabPage();
            this.tabActiva = new System.Windows.Forms.TabPage();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = false;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.HighEmphasis = true;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(438, 644);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegresar.Size = new System.Drawing.Size(175, 36);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRegresar.UseAccentColor = false;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // tabInactivas
            // 
            this.tabInactivas.BackColor = System.Drawing.Color.White;
            this.tabInactivas.Location = new System.Drawing.Point(4, 22);
            this.tabInactivas.Name = "tabInactivas";
            this.tabInactivas.Padding = new System.Windows.Forms.Padding(3);
            this.tabInactivas.Size = new System.Drawing.Size(907, 518);
            this.tabInactivas.TabIndex = 2;
            this.tabInactivas.Text = "Proyectos inactivos";
            // 
            // tabActiva
            // 
            this.tabActiva.Location = new System.Drawing.Point(4, 22);
            this.tabActiva.Name = "tabActiva";
            this.tabActiva.Padding = new System.Windows.Forms.Padding(3);
            this.tabActiva.Size = new System.Drawing.Size(1034, 518);
            this.tabActiva.TabIndex = 0;
            this.tabActiva.Text = "Proyectos activos";
            this.tabActiva.UseVisualStyleBackColor = true;
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabActiva);
            this.materialTabControl.Controls.Add(this.tabInactivas);
            this.materialTabControl.Controls.Add(this.tabNuevo);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.HotTrack = true;
            this.materialTabControl.Location = new System.Drawing.Point(6, 91);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(1042, 544);
            this.materialTabControl.TabIndex = 2;
            // 
            // tabNuevo
            // 
            this.tabNuevo.Location = new System.Drawing.Point(4, 22);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevo.Size = new System.Drawing.Size(907, 518);
            this.tabNuevo.TabIndex = 3;
            this.tabNuevo.Text = "Crear proyecto";
            this.tabNuevo.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 59);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1055, 33);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector";
            // 
            // frmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 689);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl);
            this.Controls.Add(this.btnRegresar);
            this.MaximizeBox = false;
            this.Name = "frmProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmObras_FormClosed);
            this.materialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnRegresar;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabActiva;
        private System.Windows.Forms.TabPage tabInactivas;
        private System.Windows.Forms.TabPage tabNuevo;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}