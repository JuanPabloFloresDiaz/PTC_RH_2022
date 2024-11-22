namespace PTC_Oficial
{
    partial class AdelantosEmpleado
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
            this.panelContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAdelantos = new System.Windows.Forms.DataGridView();
            this.panelSubcontenedor = new System.Windows.Forms.Panel();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnAgregar = new PTC_Oficial.BotonEsquinaRedonda();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblJustificacion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.errorAdelantos = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).BeginInit();
            this.panelSubcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdelantos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.ColumnCount = 1;
            this.panelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelContenedor.Controls.Add(this.dgvAdelantos, 0, 1);
            this.panelContenedor.Controls.Add(this.panelSubcontenedor, 0, 0);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.RowCount = 2;
            this.panelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.51174F));
            this.panelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.48826F));
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 0;
            // 
            // dgvAdelantos
            // 
            this.dgvAdelantos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdelantos.Location = new System.Drawing.Point(3, 248);
            this.dgvAdelantos.Name = "dgvAdelantos";
            this.dgvAdelantos.ReadOnly = true;
            this.dgvAdelantos.RowHeadersVisible = false;
            this.dgvAdelantos.RowTemplate.Height = 25;
            this.dgvAdelantos.Size = new System.Drawing.Size(678, 175);
            this.dgvAdelantos.TabIndex = 0;
            this.dgvAdelantos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdelantos_CellContentClick);
            // 
            // panelSubcontenedor
            // 
            this.panelSubcontenedor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelSubcontenedor.Controls.Add(this.cboDia);
            this.panelSubcontenedor.Controls.Add(this.cboEmpleados);
            this.panelSubcontenedor.Controls.Add(this.lblEmpleado);
            this.panelSubcontenedor.Controls.Add(this.btnActualizar);
            this.panelSubcontenedor.Controls.Add(this.btnEliminar);
            this.panelSubcontenedor.Controls.Add(this.btnAgregar);
            this.panelSubcontenedor.Controls.Add(this.txtJustificacion);
            this.panelSubcontenedor.Controls.Add(this.dtpHora);
            this.panelSubcontenedor.Controls.Add(this.dtpFecha);
            this.panelSubcontenedor.Controls.Add(this.lblTitulo);
            this.panelSubcontenedor.Controls.Add(this.lblJustificacion);
            this.panelSubcontenedor.Controls.Add(this.lblFecha);
            this.panelSubcontenedor.Controls.Add(this.lblHora);
            this.panelSubcontenedor.Controls.Add(this.lblDia);
            this.panelSubcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubcontenedor.Location = new System.Drawing.Point(3, 3);
            this.panelSubcontenedor.Name = "panelSubcontenedor";
            this.panelSubcontenedor.Size = new System.Drawing.Size(678, 239);
            this.panelSubcontenedor.TabIndex = 1;
            // 
            // cboDia
            // 
            this.cboDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDia.Enabled = false;
            this.cboDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Location = new System.Drawing.Point(61, 36);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(171, 23);
            this.cboDia.TabIndex = 48;
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(110, 70);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(559, 28);
            this.cboEmpleados.TabIndex = 47;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(29, 73);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 20);
            this.lblEmpleado.TabIndex = 46;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.Snow;
            this.btnActualizar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnActualizar.BorderColor = System.Drawing.Color.Lime;
            this.btnActualizar.BorderRadius = 40;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Lime;
            this.btnActualizar.Location = new System.Drawing.Point(552, 196);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 40);
            this.btnActualizar.TabIndex = 28;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Lime;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(552, 150);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 40);
            this.btnEliminar.TabIndex = 27;
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
            this.btnAgregar.Location = new System.Drawing.Point(552, 104);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 40);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJustificacion.BackColor = System.Drawing.Color.White;
            this.txtJustificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJustificacion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJustificacion.Location = new System.Drawing.Point(110, 119);
            this.txtJustificacion.Multiline = true;
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.Size = new System.Drawing.Size(436, 117);
            this.txtJustificacion.TabIndex = 25;
            // 
            // dtpHora
            // 
            this.dtpHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHora.CustomFormat = "hh:mm";
            this.dtpHora.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(471, 28);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(151, 32);
            this.dtpHora.TabIndex = 24;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(282, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(129, 32);
            this.dtpFecha.TabIndex = 23;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(238, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 29);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Datos del adelanto";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJustificacion
            // 
            this.lblJustificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJustificacion.AutoSize = true;
            this.lblJustificacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJustificacion.ForeColor = System.Drawing.Color.Black;
            this.lblJustificacion.Location = new System.Drawing.Point(19, 119);
            this.lblJustificacion.Name = "lblJustificacion";
            this.lblJustificacion.Size = new System.Drawing.Size(85, 20);
            this.lblJustificacion.TabIndex = 20;
            this.lblJustificacion.Text = "Justificacion:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(238, 36);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(431, 36);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 20);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "Hora:";
            // 
            // lblDia
            // 
            this.lblDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDia.ForeColor = System.Drawing.Color.Black;
            this.lblDia.Location = new System.Drawing.Point(19, 36);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(36, 20);
            this.lblDia.TabIndex = 17;
            this.lblDia.Text = "Dia: ";
            // 
            // errorAdelantos
            // 
            this.errorAdelantos.ContainerControl = this;
            // 
            // AdelantosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdelantosEmpleado";
            this.Text = "AdelantosEmpleado";
            this.Load += new System.EventHandler(this.AdelantosEmpleado_Load);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).EndInit();
            this.panelSubcontenedor.ResumeLayout(false);
            this.panelSubcontenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdelantos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelContenedor;
        private System.Windows.Forms.DataGridView dgvAdelantos;
        private System.Windows.Forms.Panel panelSubcontenedor;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnAgregar;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblJustificacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.ErrorProvider errorAdelantos;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboDia;
    }
}