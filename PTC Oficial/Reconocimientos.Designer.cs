namespace PTC_Oficial
{
    partial class Reconocimientos
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
            this.lblReconocidoPor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtReconocimiento = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvReconocimientos = new System.Windows.Forms.DataGridView();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.errorReconocimiento = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReconocimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorReconocimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(187, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(343, 29);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Historial de reconocimientos";
            // 
            // lblReconocidoPor
            // 
            this.lblReconocidoPor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReconocidoPor.AutoSize = true;
            this.lblReconocidoPor.BackColor = System.Drawing.Color.Transparent;
            this.lblReconocidoPor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReconocidoPor.ForeColor = System.Drawing.Color.Black;
            this.lblReconocidoPor.Location = new System.Drawing.Point(32, 41);
            this.lblReconocidoPor.Name = "lblReconocidoPor";
            this.lblReconocidoPor.Size = new System.Drawing.Size(160, 22);
            this.lblReconocidoPor.TabIndex = 20;
            this.lblReconocidoPor.Text = "Reconocido por:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(32, 107);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(160, 44);
            this.lblFecha.TabIndex = 21;
            this.lblFecha.Text = "Fecha de \r\nreconocimiento:";
            // 
            // txtReconocimiento
            // 
            this.txtReconocimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReconocimiento.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtReconocimiento.Location = new System.Drawing.Point(198, 38);
            this.txtReconocimiento.Multiline = true;
            this.txtReconocimiento.Name = "txtReconocimiento";
            this.txtReconocimiento.Size = new System.Drawing.Size(435, 63);
            this.txtReconocimiento.TabIndex = 22;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(198, 107);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 30);
            this.dtpFecha.TabIndex = 23;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.Blue;
            this.btnIngresar.Location = new System.Drawing.Point(39, 189);
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
            this.btnEliminar.Location = new System.Drawing.Point(261, 189);
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
            this.btnActualizar.Location = new System.Drawing.Point(473, 189);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(186, 41);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvReconocimientos
            // 
            this.dgvReconocimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReconocimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReconocimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReconocimientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReconocimientos.Location = new System.Drawing.Point(0, 236);
            this.dgvReconocimientos.MultiSelect = false;
            this.dgvReconocimientos.Name = "dgvReconocimientos";
            this.dgvReconocimientos.ReadOnly = true;
            this.dgvReconocimientos.RowHeadersVisible = false;
            this.dgvReconocimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvReconocimientos.RowTemplate.Height = 25;
            this.dgvReconocimientos.Size = new System.Drawing.Size(684, 190);
            this.dgvReconocimientos.TabIndex = 27;
            this.dgvReconocimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReconocimientos_CellContentClick);
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(198, 155);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(435, 30);
            this.cboEmpleados.TabIndex = 55;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(92, 158);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(100, 22);
            this.lblEmpleado.TabIndex = 54;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorReconocimiento
            // 
            this.errorReconocimiento.ContainerControl = this;
            // 
            // Reconocimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.cboEmpleados);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.dgvReconocimientos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtReconocimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblReconocidoPor);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reconocimientos";
            this.Text = "Reconocimientos";
            this.Load += new System.EventHandler(this.Reconocimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReconocimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorReconocimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblReconocidoPor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtReconocimiento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvReconocimientos;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ErrorProvider errorReconocimiento;
    }
}