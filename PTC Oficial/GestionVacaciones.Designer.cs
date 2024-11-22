namespace PTC_Oficial
{
    partial class GestionVacaciones
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvVacaciones = new System.Windows.Forms.DataGridView();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.errorVacaciones = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(199, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(273, 29);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Gestion de vacaciones";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.lblFechaInicio.Location = new System.Drawing.Point(45, 44);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(168, 32);
            this.lblFechaInicio.TabIndex = 20;
            this.lblFechaInicio.Text = "Fecha Inicial: ";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFinal.Location = new System.Drawing.Point(63, 88);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(150, 32);
            this.lblFechaFinal.TabIndex = 21;
            this.lblFechaFinal.Text = "Fecha final: ";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaInicial.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaInicial.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFechaInicial.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaInicial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(219, 42);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(432, 39);
            this.dtpFechaInicial.TabIndex = 22;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaFinal.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFechaFinal.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFinal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(219, 86);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(432, 39);
            this.dtpFechaFinal.TabIndex = 23;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.Blue;
            this.btnIngresar.Location = new System.Drawing.Point(24, 164);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(186, 41);
            this.btnIngresar.TabIndex = 24;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(248, 164);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(186, 41);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.Color.Lime;
            this.btnActualizar.Location = new System.Drawing.Point(465, 164);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(186, 41);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvVacaciones
            // 
            this.dgvVacaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVacaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacaciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVacaciones.Location = new System.Drawing.Point(0, 211);
            this.dgvVacaciones.MultiSelect = false;
            this.dgvVacaciones.Name = "dgvVacaciones";
            this.dgvVacaciones.ReadOnly = true;
            this.dgvVacaciones.RowHeadersVisible = false;
            this.dgvVacaciones.RowHeadersWidth = 51;
            this.dgvVacaciones.RowTemplate.Height = 25;
            this.dgvVacaciones.Size = new System.Drawing.Size(684, 215);
            this.dgvVacaciones.TabIndex = 27;
            this.dgvVacaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacaciones_CellContentClick);
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(216, 130);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(435, 28);
            this.cboEmpleados.TabIndex = 53;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(76, 123);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(134, 32);
            this.lblEmpleado.TabIndex = 52;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorVacaciones
            // 
            this.errorVacaciones.ContainerControl = this;
            // 
            // GestionVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.cboEmpleados);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.dgvVacaciones);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionVacaciones";
            this.Text = "GestionVacaciones";
            this.Load += new System.EventHandler(this.GestionVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVacaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvVacaciones;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ErrorProvider errorVacaciones;
    }
}