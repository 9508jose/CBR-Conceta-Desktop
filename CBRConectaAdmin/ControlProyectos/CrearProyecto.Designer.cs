namespace CBRConectaAdmin.ControlProyectos
{
    partial class CrearProyecto
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
            this.txtProyecto = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDocumento = new MaterialSkin.Controls.MaterialButton();
            this.lblDoc = new MaterialSkin.Controls.MaterialLabel();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
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
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(279, 103);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(471, 50);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtProyecto
            // 
            this.txtProyecto.AnimateReadOnly = false;
            this.txtProyecto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProyecto.Depth = 0;
            this.txtProyecto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProyecto.Hint = "No. de proyecto";
            this.txtProyecto.LeadingIcon = null;
            this.txtProyecto.Location = new System.Drawing.Point(279, 229);
            this.txtProyecto.MaxLength = 50;
            this.txtProyecto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProyecto.Multiline = false;
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(471, 50);
            this.txtProyecto.TabIndex = 2;
            this.txtProyecto.Text = "";
            this.txtProyecto.TrailingIcon = null;
            this.txtProyecto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProyecto_KeyPress);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.dtpFechaInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dtpFechaInicio.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.dtpFechaInicio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(469, 179);
            this.dtpFechaInicio.MinDate = new System.DateTime(2022, 2, 5, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(278, 26);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(276, 179);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Fecha de inicio:";
            // 
            // btnDocumento
            // 
            this.btnDocumento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDocumento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDocumento.Depth = 0;
            this.btnDocumento.HighEmphasis = true;
            this.btnDocumento.Icon = null;
            this.btnDocumento.Location = new System.Drawing.Point(279, 299);
            this.btnDocumento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDocumento.Name = "btnDocumento";
            this.btnDocumento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDocumento.Size = new System.Drawing.Size(156, 36);
            this.btnDocumento.TabIndex = 3;
            this.btnDocumento.Text = "Subir documento";
            this.btnDocumento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnDocumento.UseAccentColor = false;
            this.btnDocumento.UseVisualStyleBackColor = true;
            this.btnDocumento.Click += new System.EventHandler(this.btnDocumento_Click);
            // 
            // lblDoc
            // 
            this.lblDoc.Depth = 0;
            this.lblDoc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDoc.Location = new System.Drawing.Point(442, 309);
            this.lblDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(308, 78);
            this.lblDoc.TabIndex = 6;
            this.lblDoc.Text = "Documento seleccionado: Ninguno\r\n";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(430, 407);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(146, 36);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Crear proyecto";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Depth = 0;
            this.lblMessage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMessage.Location = new System.Drawing.Point(276, 77);
            this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(471, 23);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Error";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // CrearProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 482);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.btnDocumento);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.txtNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearProyecto";
            this.Text = "CrearProyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtProyecto;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnDocumento;
        private MaterialSkin.Controls.MaterialLabel lblDoc;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialLabel lblMessage;
    }
}