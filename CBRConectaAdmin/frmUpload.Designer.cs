namespace CBRConectaAdmin
{
    partial class frmUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpload));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.cmbRubro = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbDocumento = new MaterialSkin.Controls.MaterialComboBox();
            this.btnRegresar = new MaterialSkin.Controls.MaterialButton();
            this.btnCargar = new MaterialSkin.Controls.MaterialButton();
            this.btnAdjuntar = new MaterialSkin.Controls.MaterialButton();
            this.lblSelect = new MaterialSkin.Controls.MaterialLabel();
            this.lblPDFSel = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.cardPDF = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.imgEmpty = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.cardPDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(338, 197);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(559, 537);
            this.axAcroPDF1.TabIndex = 8;
            this.axAcroPDF1.Visible = false;
            // 
            // cmbRubro
            // 
            this.cmbRubro.AutoResize = false;
            this.cmbRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRubro.Depth = 0;
            this.cmbRubro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRubro.DropDownHeight = 174;
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.DropDownWidth = 121;
            this.cmbRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRubro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Hint = "Rubro";
            this.cmbRubro.IntegralHeight = false;
            this.cmbRubro.ItemHeight = 43;
            this.cmbRubro.Location = new System.Drawing.Point(22, 73);
            this.cmbRubro.MaxDropDownItems = 4;
            this.cmbRubro.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(314, 49);
            this.cmbRubro.StartIndex = 0;
            this.cmbRubro.TabIndex = 1;
            this.cmbRubro.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            this.cmbRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbArea_KeyPress);
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.AutoResize = false;
            this.cmbDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDocumento.Depth = 0;
            this.cmbDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDocumento.DropDownHeight = 174;
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.DropDownWidth = 121;
            this.cmbDocumento.Enabled = false;
            this.cmbDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Hint = "Documento";
            this.cmbDocumento.IntegralHeight = false;
            this.cmbDocumento.ItemHeight = 43;
            this.cmbDocumento.Location = new System.Drawing.Point(376, 73);
            this.cmbDocumento.MaxDropDownItems = 4;
            this.cmbDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(317, 49);
            this.cmbDocumento.StartIndex = 0;
            this.cmbDocumento.TabIndex = 2;
            this.cmbDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoReporte_SelectedIndexChanged);
            this.cmbDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbArea_KeyPress);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.HighEmphasis = true;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(22, 683);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegresar.Size = new System.Drawing.Size(94, 36);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRegresar.UseAccentColor = true;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.AutoSize = false;
            this.btnCargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCargar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCargar.Depth = 0;
            this.btnCargar.Enabled = false;
            this.btnCargar.HighEmphasis = true;
            this.btnCargar.Icon = null;
            this.btnCargar.Location = new System.Drawing.Point(953, 73);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCargar.Size = new System.Drawing.Size(195, 36);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCargar.UseAccentColor = false;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.AutoSize = false;
            this.btnAdjuntar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdjuntar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdjuntar.Depth = 0;
            this.btnAdjuntar.Enabled = false;
            this.btnAdjuntar.HighEmphasis = true;
            this.btnAdjuntar.Icon = null;
            this.btnAdjuntar.Location = new System.Drawing.Point(716, 73);
            this.btnAdjuntar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdjuntar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdjuntar.Size = new System.Drawing.Size(229, 36);
            this.btnAdjuntar.TabIndex = 9;
            this.btnAdjuntar.Text = "Adjuntar documento";
            this.btnAdjuntar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdjuntar.UseAccentColor = false;
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Depth = 0;
            this.lblSelect.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelect.Location = new System.Drawing.Point(352, 90);
            this.lblSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(9, 19);
            this.lblSelect.TabIndex = 10;
            this.lblSelect.Text = ">";
            // 
            // lblPDFSel
            // 
            this.lblPDFSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPDFSel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPDFSel.Depth = 0;
            this.lblPDFSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPDFSel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPDFSel.Location = new System.Drawing.Point(158, 5);
            this.lblPDFSel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPDFSel.Name = "lblPDFSel";
            this.lblPDFSel.ReadOnly = true;
            this.lblPDFSel.Size = new System.Drawing.Size(953, 30);
            this.lblPDFSel.TabIndex = 11;
            this.lblPDFSel.Text = "";
            this.lblPDFSel.Visible = false;
            // 
            // cardPDF
            // 
            this.cardPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardPDF.Controls.Add(this.materialLabel1);
            this.cardPDF.Controls.Add(this.lblPDFSel);
            this.cardPDF.Depth = 0;
            this.cardPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardPDF.Location = new System.Drawing.Point(22, 130);
            this.cardPDF.Margin = new System.Windows.Forms.Padding(14);
            this.cardPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardPDF.Name = "cardPDF";
            this.cardPDF.Padding = new System.Windows.Forms.Padding(14);
            this.cardPDF.Size = new System.Drawing.Size(1126, 40);
            this.cardPDF.TabIndex = 12;
            this.cardPDF.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "PDF Seleccionado:";
            // 
            // imgEmpty
            // 
            this.imgEmpty.Image = ((System.Drawing.Image)(resources.GetObject("imgEmpty.Image")));
            this.imgEmpty.Location = new System.Drawing.Point(421, 261);
            this.imgEmpty.Name = "imgEmpty";
            this.imgEmpty.Size = new System.Drawing.Size(387, 398);
            this.imgEmpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEmpty.TabIndex = 13;
            this.imgEmpty.TabStop = false;
            this.imgEmpty.Visible = false;
            // 
            // frmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 740);
            this.Controls.Add(this.imgEmpty);
            this.Controls.Add(this.cardPDF);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.cmbDocumento);
            this.Controls.Add(this.cmbRubro);
            this.Controls.Add(this.axAcroPDF1);
            this.MaximizeBox = false;
            this.Name = "frmUpload";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subir archivos - Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.cardPDF.ResumeLayout(false);
            this.cardPDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmpty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private MaterialSkin.Controls.MaterialComboBox cmbRubro;
        private MaterialSkin.Controls.MaterialComboBox cmbDocumento;
        private MaterialSkin.Controls.MaterialButton btnRegresar;
        private MaterialSkin.Controls.MaterialButton btnCargar;
        private MaterialSkin.Controls.MaterialButton btnAdjuntar;
        private MaterialSkin.Controls.MaterialLabel lblSelect;
        private MaterialSkin.Controls.MaterialMultiLineTextBox lblPDFSel;
        private MaterialSkin.Controls.MaterialCard cardPDF;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox imgEmpty;
    }
}