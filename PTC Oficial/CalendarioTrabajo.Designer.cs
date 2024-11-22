namespace PTC_Oficial
{
    partial class CalendarioTrabajo
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
            this.panelDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnFuncion = new PTC_Oficial.BotonEsquinaRedonda();
            this.cboFunciones = new System.Windows.Forms.ComboBox();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnAgregar = new PTC_Oficial.BotonEsquinaRedonda();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.dgvCalendario = new System.Windows.Forms.DataGridView();
            this.errorCalendario = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelObjetos = new System.Windows.Forms.Panel();
            this.panelDivisor.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCalendario)).BeginInit();
            this.panelObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDivisor
            // 
            this.panelDivisor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelDivisor.ColumnCount = 1;
            this.panelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDivisor.Controls.Add(this.panelContenedor, 0, 0);
            this.panelDivisor.Controls.Add(this.dgvCalendario, 0, 1);
            this.panelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDivisor.Location = new System.Drawing.Point(0, 0);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.RowCount = 2;
            this.panelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.46009F));
            this.panelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.53991F));
            this.panelDivisor.Size = new System.Drawing.Size(684, 426);
            this.panelDivisor.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelContenedor.Controls.Add(this.btnFuncion);
            this.panelContenedor.Controls.Add(this.cboFunciones);
            this.panelContenedor.Controls.Add(this.cboEmpleados);
            this.panelContenedor.Controls.Add(this.lblEmpleado);
            this.panelContenedor.Controls.Add(this.cboDia);
            this.panelContenedor.Controls.Add(this.txtHora);
            this.panelContenedor.Controls.Add(this.btnActualizar);
            this.panelContenedor.Controls.Add(this.btnEliminar);
            this.panelContenedor.Controls.Add(this.btnAgregar);
            this.panelContenedor.Controls.Add(this.lblFuncion);
            this.panelContenedor.Controls.Add(this.dtpFecha);
            this.panelContenedor.Controls.Add(this.lblTitulo);
            this.panelContenedor.Controls.Add(this.lblFecha);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Controls.Add(this.lblDia);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(3, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(678, 225);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnFuncion
            // 
            this.btnFuncion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFuncion.BackColor = System.Drawing.Color.Snow;
            this.btnFuncion.BackgroundColor = System.Drawing.Color.Snow;
            this.btnFuncion.BorderColor = System.Drawing.Color.Lime;
            this.btnFuncion.BorderRadius = 40;
            this.btnFuncion.BorderSize = 0;
            this.btnFuncion.FlatAppearance.BorderSize = 0;
            this.btnFuncion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnFuncion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncion.ForeColor = System.Drawing.Color.Gold;
            this.btnFuncion.Location = new System.Drawing.Point(478, 182);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Size = new System.Drawing.Size(137, 40);
            this.btnFuncion.TabIndex = 47;
            this.btnFuncion.Text = "Generar funciones a realizar";
            this.btnFuncion.TextColor = System.Drawing.Color.Gold;
            this.btnFuncion.UseVisualStyleBackColor = false;
            this.btnFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // cboFunciones
            // 
            this.cboFunciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboFunciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFunciones.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboFunciones.FormattingEnabled = true;
            this.cboFunciones.Location = new System.Drawing.Point(97, 81);
            this.cboFunciones.Name = "cboFunciones";
            this.cboFunciones.Size = new System.Drawing.Size(556, 28);
            this.cboFunciones.TabIndex = 46;
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(97, 147);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(556, 28);
            this.cboEmpleados.TabIndex = 45;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(16, 150);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 20);
            this.lblEmpleado.TabIndex = 44;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboDia
            // 
            this.cboDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDia.Enabled = false;
            this.cboDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Location = new System.Drawing.Point(58, 42);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(171, 23);
            this.cboDia.TabIndex = 26;
            this.cboDia.SelectedIndexChanged += new System.EventHandler(this.cboDia_SelectedIndexChanged);
            // 
            // txtHora
            // 
            this.txtHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHora.BackColor = System.Drawing.Color.White;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHora.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHora.Location = new System.Drawing.Point(482, 40);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(171, 25);
            this.txtHora.TabIndex = 25;
            this.txtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHora_KeyPress);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnActualizar.Location = new System.Drawing.Point(335, 182);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(137, 40);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Lime;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnEliminar.Location = new System.Drawing.Point(192, 179);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 40);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.Red;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnAgregar.Location = new System.Drawing.Point(49, 179);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 40);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFuncion
            // 
            this.lblFuncion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFuncion.ForeColor = System.Drawing.Color.Black;
            this.lblFuncion.Location = new System.Drawing.Point(16, 81);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(75, 40);
            this.lblFuncion.TabIndex = 20;
            this.lblFuncion.Text = "Funciones \r\na realizar: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(291, 33);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(129, 32);
            this.dtpFecha.TabIndex = 18;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(206, -3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 29);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Calendario de trabajo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(235, 41);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(428, 41);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(48, 20);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "Horas:";
            // 
            // lblDia
            // 
            this.lblDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDia.ForeColor = System.Drawing.Color.Black;
            this.lblDia.Location = new System.Drawing.Point(16, 41);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(36, 20);
            this.lblDia.TabIndex = 13;
            this.lblDia.Text = "Dia: ";
            // 
            // dgvCalendario
            // 
            this.dgvCalendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalendario.Location = new System.Drawing.Point(3, 234);
            this.dgvCalendario.Name = "dgvCalendario";
            this.dgvCalendario.ReadOnly = true;
            this.dgvCalendario.RowHeadersVisible = false;
            this.dgvCalendario.RowTemplate.Height = 25;
            this.dgvCalendario.Size = new System.Drawing.Size(678, 189);
            this.dgvCalendario.TabIndex = 1;
            this.dgvCalendario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalendario_CellContentClick);
            // 
            // errorCalendario
            // 
            this.errorCalendario.ContainerControl = this;
            // 
            // panelObjetos
            // 
            this.panelObjetos.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelObjetos.Controls.Add(this.panelDivisor);
            this.panelObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjetos.Location = new System.Drawing.Point(0, 0);
            this.panelObjetos.Name = "panelObjetos";
            this.panelObjetos.Size = new System.Drawing.Size(684, 426);
            this.panelObjetos.TabIndex = 1;
            // 
            // CalendarioTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelObjetos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalendarioTrabajo";
            this.Text = "CalendarioTrabajo";
            this.Load += new System.EventHandler(this.CalendarioTrabajo_Load);
            this.panelDivisor.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCalendario)).EndInit();
            this.panelObjetos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelDivisor;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.DataGridView dgvCalendario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txtHora;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnAgregar;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.ErrorProvider errorCalendario;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.ComboBox cboFunciones;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private BotonEsquinaRedonda btnFuncion;
        private System.Windows.Forms.Panel panelObjetos;
    }
}