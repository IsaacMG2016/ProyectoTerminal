namespace Modulo
{
    partial class MenuIni
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuIni));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ejecucionButton = new System.Windows.Forms.Button();
            this.planificarButton = new System.Windows.Forms.Button();
            this.cadenasButton = new System.Windows.Forms.Button();
            this.administradorButton = new System.Windows.Forms.Button();
            this.historicoGroupBox = new System.Windows.Forms.GroupBox();
            this.historicoDataGridView = new System.Windows.Forms.DataGridView();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.FechaEjLabel = new System.Windows.Forms.Label();
            this.FechaILabel = new System.Windows.Forms.Label();
            this.FechaFLabel = new System.Windows.Forms.Label();
            this.EstatusLabel = new System.Windows.Forms.Label();
            this.ClasificacionLabel = new System.Windows.Forms.Label();
            this.FechaIniButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ClasificacionComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Clasificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informacion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewButtonColumn();
            this.historicoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ejecucionButton
            // 
            this.ejecucionButton.Image = ((System.Drawing.Image)(resources.GetObject("ejecucionButton.Image")));
            this.ejecucionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ejecucionButton.Location = new System.Drawing.Point(25, 35);
            this.ejecucionButton.Name = "ejecucionButton";
            this.ejecucionButton.Size = new System.Drawing.Size(162, 137);
            this.ejecucionButton.TabIndex = 0;
            this.ejecucionButton.Text = " Menú de   ejecución";
            this.ejecucionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ejecucionButton.UseVisualStyleBackColor = true;
            this.ejecucionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // planificarButton
            // 
            this.planificarButton.Image = ((System.Drawing.Image)(resources.GetObject("planificarButton.Image")));
            this.planificarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.planificarButton.Location = new System.Drawing.Point(361, 35);
            this.planificarButton.Name = "planificarButton";
            this.planificarButton.Size = new System.Drawing.Size(162, 137);
            this.planificarButton.TabIndex = 2;
            this.planificarButton.Text = "Planificar ejecuciones";
            this.planificarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.planificarButton.UseVisualStyleBackColor = true;
            // 
            // cadenasButton
            // 
            this.cadenasButton.Image = ((System.Drawing.Image)(resources.GetObject("cadenasButton.Image")));
            this.cadenasButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cadenasButton.Location = new System.Drawing.Point(193, 35);
            this.cadenasButton.Name = "cadenasButton";
            this.cadenasButton.Size = new System.Drawing.Size(162, 137);
            this.cadenasButton.TabIndex = 4;
            this.cadenasButton.Text = "Creación de cadenas";
            this.cadenasButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cadenasButton.UseVisualStyleBackColor = true;
            // 
            // administradorButton
            // 
            this.administradorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.administradorButton.Image = ((System.Drawing.Image)(resources.GetObject("administradorButton.Image")));
            this.administradorButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.administradorButton.Location = new System.Drawing.Point(742, 35);
            this.administradorButton.Name = "administradorButton";
            this.administradorButton.Size = new System.Drawing.Size(162, 137);
            this.administradorButton.TabIndex = 5;
            this.administradorButton.Text = "Administración";
            this.administradorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.administradorButton.UseVisualStyleBackColor = true;
            // 
            // historicoGroupBox
            // 
            this.historicoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historicoGroupBox.Controls.Add(this.comboBox1);
            this.historicoGroupBox.Controls.Add(this.ClasificacionComboBox);
            this.historicoGroupBox.Controls.Add(this.textBox2);
            this.historicoGroupBox.Controls.Add(this.textBox1);
            this.historicoGroupBox.Controls.Add(this.button1);
            this.historicoGroupBox.Controls.Add(this.FechaIniButton);
            this.historicoGroupBox.Controls.Add(this.ClasificacionLabel);
            this.historicoGroupBox.Controls.Add(this.EstatusLabel);
            this.historicoGroupBox.Controls.Add(this.FechaFLabel);
            this.historicoGroupBox.Controls.Add(this.FechaILabel);
            this.historicoGroupBox.Controls.Add(this.FechaEjLabel);
            this.historicoGroupBox.Controls.Add(this.NombreTextBox);
            this.historicoGroupBox.Controls.Add(this.NombreLabel);
            this.historicoGroupBox.Controls.Add(this.historicoDataGridView);
            this.historicoGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.historicoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicoGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.historicoGroupBox.Location = new System.Drawing.Point(0, 193);
            this.historicoGroupBox.Name = "historicoGroupBox";
            this.historicoGroupBox.Size = new System.Drawing.Size(916, 490);
            this.historicoGroupBox.TabIndex = 6;
            this.historicoGroupBox.TabStop = false;
            this.historicoGroupBox.Text = "Historial de ejecuciones";
            // 
            // historicoDataGridView
            // 
            this.historicoDataGridView.AllowUserToAddRows = false;
            this.historicoDataGridView.AllowUserToDeleteRows = false;
            this.historicoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historicoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historicoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.historicoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.historicoDataGridView.ColumnHeadersHeight = 40;
            this.historicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clasificación,
            this.Nombre,
            this.FechaIni,
            this.FechaFin,
            this.Estatus,
            this.Informacion,
            this.Responsable});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historicoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.historicoDataGridView.Location = new System.Drawing.Point(6, 156);
            this.historicoDataGridView.Name = "historicoDataGridView";
            this.historicoDataGridView.ReadOnly = true;
            this.historicoDataGridView.Size = new System.Drawing.Size(898, 322);
            this.historicoDataGridView.TabIndex = 0;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.ForeColor = System.Drawing.Color.Black;
            this.NombreLabel.Location = new System.Drawing.Point(42, 27);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(68, 20);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(10, 64);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(155, 26);
            this.NombreTextBox.TabIndex = 2;
            // 
            // FechaEjLabel
            // 
            this.FechaEjLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FechaEjLabel.AutoSize = true;
            this.FechaEjLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaEjLabel.ForeColor = System.Drawing.Color.Black;
            this.FechaEjLabel.Location = new System.Drawing.Point(265, 27);
            this.FechaEjLabel.Name = "FechaEjLabel";
            this.FechaEjLabel.Size = new System.Drawing.Size(154, 20);
            this.FechaEjLabel.TabIndex = 3;
            this.FechaEjLabel.Text = "Fecha de ejecución";
            // 
            // FechaILabel
            // 
            this.FechaILabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FechaILabel.AutoSize = true;
            this.FechaILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaILabel.ForeColor = System.Drawing.Color.Black;
            this.FechaILabel.Location = new System.Drawing.Point(213, 67);
            this.FechaILabel.Name = "FechaILabel";
            this.FechaILabel.Size = new System.Drawing.Size(48, 20);
            this.FechaILabel.TabIndex = 4;
            this.FechaILabel.Text = "Inicio";
            // 
            // FechaFLabel
            // 
            this.FechaFLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FechaFLabel.AutoSize = true;
            this.FechaFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFLabel.ForeColor = System.Drawing.Color.Black;
            this.FechaFLabel.Location = new System.Drawing.Point(213, 104);
            this.FechaFLabel.Name = "FechaFLabel";
            this.FechaFLabel.Size = new System.Drawing.Size(32, 20);
            this.FechaFLabel.TabIndex = 5;
            this.FechaFLabel.Text = "Fin";
            // 
            // EstatusLabel
            // 
            this.EstatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EstatusLabel.AutoSize = true;
            this.EstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstatusLabel.ForeColor = System.Drawing.Color.Black;
            this.EstatusLabel.Location = new System.Drawing.Point(727, 27);
            this.EstatusLabel.Name = "EstatusLabel";
            this.EstatusLabel.Size = new System.Drawing.Size(66, 20);
            this.EstatusLabel.TabIndex = 6;
            this.EstatusLabel.Text = "Estatus";
            // 
            // ClasificacionLabel
            // 
            this.ClasificacionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClasificacionLabel.AutoSize = true;
            this.ClasificacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClasificacionLabel.ForeColor = System.Drawing.Color.Black;
            this.ClasificacionLabel.Location = new System.Drawing.Point(509, 27);
            this.ClasificacionLabel.Name = "ClasificacionLabel";
            this.ClasificacionLabel.Size = new System.Drawing.Size(105, 20);
            this.ClasificacionLabel.TabIndex = 7;
            this.ClasificacionLabel.Text = "Clasificación";
            // 
            // FechaIniButton
            // 
            this.FechaIniButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FechaIniButton.Image = ((System.Drawing.Image)(resources.GetObject("FechaIniButton.Image")));
            this.FechaIniButton.Location = new System.Drawing.Point(267, 64);
            this.FechaIniButton.Name = "FechaIniButton";
            this.FechaIniButton.Size = new System.Drawing.Size(35, 35);
            this.FechaIniButton.TabIndex = 8;
            this.FechaIniButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(267, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(326, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 26);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(326, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 26);
            this.textBox2.TabIndex = 11;
            // 
            // ClasificacionComboBox
            // 
            this.ClasificacionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClasificacionComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClasificacionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClasificacionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClasificacionComboBox.FormattingEnabled = true;
            this.ClasificacionComboBox.Location = new System.Drawing.Point(513, 59);
            this.ClasificacionComboBox.Name = "ClasificacionComboBox";
            this.ClasificacionComboBox.Size = new System.Drawing.Size(176, 28);
            this.ClasificacionComboBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(731, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // Clasificación
            // 
            this.Clasificación.FillWeight = 101.8613F;
            this.Clasificación.HeaderText = "Clasificación";
            this.Clasificación.Name = "Clasificación";
            this.Clasificación.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 101.8613F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechaIni
            // 
            this.FechaIni.FillWeight = 101.8613F;
            this.FechaIni.HeaderText = "Fecha inicio";
            this.FechaIni.Name = "FechaIni";
            this.FechaIni.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.FillWeight = 101.8613F;
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.FillWeight = 101.8613F;
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // Informacion
            // 
            this.Informacion.FillWeight = 88.83249F;
            this.Informacion.HeaderText = "Información";
            this.Informacion.Name = "Informacion";
            this.Informacion.ReadOnly = true;
            this.Informacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Responsable
            // 
            this.Responsable.FillWeight = 101.8613F;
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.Name = "Responsable";
            this.Responsable.ReadOnly = true;
            // 
            // MenuIni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(916, 683);
            this.Controls.Add(this.historicoGroupBox);
            this.Controls.Add(this.administradorButton);
            this.Controls.Add(this.cadenasButton);
            this.Controls.Add(this.planificarButton);
            this.Controls.Add(this.ejecucionButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MenuIni";
            this.Text = "Modulo de administración de procesos";
            this.historicoGroupBox.ResumeLayout(false);
            this.historicoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historicoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ejecucionButton;
        private System.Windows.Forms.Button planificarButton;
        private System.Windows.Forms.Button cadenasButton;
        private System.Windows.Forms.Button administradorButton;
        private System.Windows.Forms.GroupBox historicoGroupBox;
        private System.Windows.Forms.DataGridView historicoDataGridView;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label FechaEjLabel;
        private System.Windows.Forms.Label FechaFLabel;
        private System.Windows.Forms.Label FechaILabel;
        private System.Windows.Forms.Label ClasificacionLabel;
        private System.Windows.Forms.Label EstatusLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox ClasificacionComboBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FechaIniButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewButtonColumn Informacion;
        private System.Windows.Forms.DataGridViewButtonColumn Responsable;
    }
}

