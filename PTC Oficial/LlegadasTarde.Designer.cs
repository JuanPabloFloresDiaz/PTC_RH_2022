namespace PTC_Oficial
{
    partial class LlegadasTarde
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnAgregar = new PTC_Oficial.BotonEsquinaRedonda();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dgvLlegadasTarde = new System.Windows.Forms.DataGridView();
            this.errorLlegadasTarde = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlegadasTarde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLlegadasTarde)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.btnEliminar);
            this.panelContenedor.Controls.Add(this.btnAgregar);
            this.panelContenedor.Controls.Add(this.cboEmpleados);
            this.panelContenedor.Controls.Add(this.lblEmpleado);
            this.panelContenedor.Controls.Add(this.txtJustificacion);
            this.panelContenedor.Controls.Add(this.lblTexto);
            this.panelContenedor.Controls.Add(this.dtpHora);
            this.panelContenedor.Controls.Add(this.dtpFecha);
            this.panelContenedor.Controls.Add(this.lblFecha);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Controls.Add(this.dgvLlegadasTarde);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Snow;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnEliminar.BorderColor = System.Drawing.Color.Red;
            this.btnEliminar.BorderRadius = 40;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(407, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 40);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.Red;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.Snow;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnAgregar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.Location = new System.Drawing.Point(122, 193);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 40);
            this.btnAgregar.TabIndex = 52;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(122, 74);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(500, 28);
            this.cboEmpleados.TabIndex = 51;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(47, 77);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 20);
            this.lblEmpleado.TabIndex = 50;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJustificacion.BackColor = System.Drawing.Color.White;
            this.txtJustificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJustificacion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJustificacion.Location = new System.Drawing.Point(122, 123);
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.ReadOnly = true;
            this.txtJustificacion.Size = new System.Drawing.Size(500, 25);
            this.txtJustificacion.TabIndex = 49;
            this.txtJustificacion.Text = "Llego tarde.";
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.ForeColor = System.Drawing.Color.Black;
            this.lblTexto.Location = new System.Drawing.Point(70, 123);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(46, 20);
            this.lblTexto.TabIndex = 48;
            this.lblTexto.Text = "Texto:";
            // 
            // dtpHora
            // 
            this.dtpHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHora.CustomFormat = "hh:mm";
            this.dtpHora.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(407, 12);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(215, 32);
            this.dtpHora.TabIndex = 28;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(122, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(239, 32);
            this.dtpFecha.TabIndex = 27;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(78, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(367, 20);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 20);
            this.lblHora.TabIndex = 25;
            this.lblHora.Text = "Hora:";
            // 
            // dgvLlegadasTarde
            // 
            this.dgvLlegadasTarde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLlegadasTarde.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLlegadasTarde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlegadasTarde.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLlegadasTarde.Location = new System.Drawing.Point(0, 239);
            this.dgvLlegadasTarde.MultiSelect = false;
            this.dgvLlegadasTarde.Name = "dgvLlegadasTarde";
            this.dgvLlegadasTarde.ReadOnly = true;
            this.dgvLlegadasTarde.RowHeadersVisible = false;
            this.dgvLlegadasTarde.RowTemplate.Height = 25;
            this.dgvLlegadasTarde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLlegadasTarde.Size = new System.Drawing.Size(684, 187);
            this.dgvLlegadasTarde.TabIndex = 0;
            this.dgvLlegadasTarde.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLlegadasTarde_CellContentClick);
            // 
            // errorLlegadasTarde
            // 
            this.errorLlegadasTarde.ContainerControl = this;
            // 
            // LlegadasTarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LlegadasTarde";
            this.Text = "LlegadasTarde";
            this.Load += new System.EventHandler(this.LlegadasTarde_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlegadasTarde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLlegadasTarde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.DataGridView dgvLlegadasTarde;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.Label lblTexto;
        private BotonEsquinaRedonda btnAgregar;
        private BotonEsquinaRedonda btnEliminar;
        private System.Windows.Forms.ErrorProvider errorLlegadasTarde;
    }
}