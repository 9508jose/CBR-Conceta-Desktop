namespace CBRConectaAdmin.ControlProyectos
{
    partial class VerProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProyecto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbDocumento = new MaterialSkin.Controls.MaterialComboBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.cmbEmpleado = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAsignar = new MaterialSkin.Controls.MaterialButton();
            this.btnLiberarColado = new MaterialSkin.Controls.MaterialButton();
            this.btnFinalizar = new MaterialSkin.Controls.MaterialButton();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.Hint = "Buscar proyecto";
            this.txtBuscar.LeadingIcon = global::CBRConectaAdmin.Properties.Resources.search_icon;
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(428, 50);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.Text = "";
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.cmbDocumento.IntegralHeight = false;
            this.cmbDocumento.ItemHeight = 43;
            this.cmbDocumento.Location = new System.Drawing.Point(460, 12);
            this.cmbDocumento.MaxDropDownItems = 4;
            this.cmbDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(562, 49);
            this.cmbDocumento.StartIndex = 0;
            this.cmbDocumento.TabIndex = 7;
            this.cmbDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbDocumento_SelectedIndexChanged);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(512, 67);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(454, 440);
            this.axAcroPDF1.TabIndex = 9;
            this.axAcroPDF1.Visible = false;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.AutoResize = false;
            this.cmbEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmpleado.Depth = 0;
            this.cmbEmpleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmpleado.DropDownHeight = 174;
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.DropDownWidth = 121;
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Hint = "Empleado";
            this.cmbEmpleado.IntegralHeight = false;
            this.cmbEmpleado.ItemHeight = 43;
            this.cmbEmpleado.Location = new System.Drawing.Point(12, 399);
            this.cmbEmpleado.MaxDropDownItems = 4;
            this.cmbEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(338, 49);
            this.cmbEmpleado.StartIndex = 0;
            this.cmbEmpleado.TabIndex = 12;
            this.cmbEmpleado.Visible = false;
            // 
            // btnAsignar
            // 
            this.btnAsignar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsignar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAsignar.Depth = 0;
            this.btnAsignar.DrawShadows = false;
            this.btnAsignar.HighEmphasis = true;
            this.btnAsignar.Icon = null;
            this.btnAsignar.Location = new System.Drawing.Point(357, 402);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsignar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAsignar.Size = new System.Drawing.Size(83, 36);
            this.btnAsignar.TabIndex = 13;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAsignar.UseAccentColor = false;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Visible = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnLiberarColado
            // 
            this.btnLiberarColado.AutoSize = false;
            this.btnLiberarColado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLiberarColado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLiberarColado.Depth = 0;
            this.btnLiberarColado.DrawShadows = false;
            this.btnLiberarColado.Enabled = false;
            this.btnLiberarColado.HighEmphasis = true;
            this.btnLiberarColado.Icon = null;
            this.btnLiberarColado.Location = new System.Drawing.Point(13, 457);
            this.btnLiberarColado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLiberarColado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLiberarColado.Name = "btnLiberarColado";
            this.btnLiberarColado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLiberarColado.Size = new System.Drawing.Size(165, 36);
            this.btnLiberarColado.TabIndex = 14;
            this.btnLiberarColado.Text = "Liberar colado";
            this.btnLiberarColado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLiberarColado.UseAccentColor = false;
            this.btnLiberarColado.UseVisualStyleBackColor = true;
            this.btnLiberarColado.Visible = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AutoSize = false;
            this.btnFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinalizar.Depth = 0;
            this.btnFinalizar.DrawShadows = false;
            this.btnFinalizar.HighEmphasis = true;
            this.btnFinalizar.Icon = null;
            this.btnFinalizar.Location = new System.Drawing.Point(275, 457);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinalizar.Size = new System.Drawing.Size(165, 36);
            this.btnFinalizar.TabIndex = 15;
            this.btnFinalizar.Text = "Finalizar obra";
            this.btnFinalizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinalizar.UseAccentColor = false;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombre,
            this.clmEmpleado,
            this.clmFecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.Location = new System.Drawing.Point(13, 78);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(427, 315);
            this.gridView.TabIndex = 16;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 50;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre del proyecto";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 150;
            // 
            // clmEmpleado
            // 
            this.clmEmpleado.HeaderText = "Empleado asignado";
            this.clmEmpleado.Name = "clmEmpleado";
            this.clmEmpleado.ReadOnly = true;
            this.clmEmpleado.Width = 150;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha de inicio";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // VerProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 519);
            this.ControlBox = false;
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnLiberarColado);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.cmbDocumento);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerProyecto";
            this.Text = "Obras";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialComboBox cmbDocumento;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private MaterialSkin.Controls.MaterialComboBox cmbEmpleado;
        private MaterialSkin.Controls.MaterialButton btnAsignar;
        private MaterialSkin.Controls.MaterialButton btnLiberarColado;
        private MaterialSkin.Controls.MaterialButton btnFinalizar;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
    }
}