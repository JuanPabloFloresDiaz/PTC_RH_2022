namespace PTC_Oficial
{
    partial class HorarioAdmin
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
            this.PanelDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.PanelDivisor2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnAgregar = new PTC_Oficial.BotonEsquinaRedonda();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.errorHorario = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.PanelDivisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.PanelDivisor2.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.PanelDivisor);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 0;
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 1;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.dgvHorario, 0, 1);
            this.PanelDivisor.Controls.Add(this.PanelDivisor2, 0, 0);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 2;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 0;
            // 
            // dgvHorario
            // 
            this.dgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHorario.Location = new System.Drawing.Point(3, 216);
            this.dgvHorario.MultiSelect = false;
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.RowHeadersVisible = false;
            this.dgvHorario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHorario.RowTemplate.Height = 25;
            this.dgvHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorario.Size = new System.Drawing.Size(678, 207);
            this.dgvHorario.TabIndex = 0;
            this.dgvHorario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorario_CellContentClick);
            // 
            // PanelDivisor2
            // 
            this.PanelDivisor2.ColumnCount = 1;
            this.PanelDivisor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor2.Controls.Add(this.panelBotones, 0, 1);
            this.PanelDivisor2.Controls.Add(this.panelCampos, 0, 0);
            this.PanelDivisor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor2.Location = new System.Drawing.Point(3, 3);
            this.PanelDivisor2.Name = "PanelDivisor2";
            this.PanelDivisor2.RowCount = 2;
            this.PanelDivisor2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.42995F));
            this.PanelDivisor2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.57005F));
            this.PanelDivisor2.Size = new System.Drawing.Size(678, 207);
            this.PanelDivisor2.TabIndex = 1;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnActualizar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnAgregar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Location = new System.Drawing.Point(3, 154);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(672, 50);
            this.panelBotones.TabIndex = 0;
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
            this.btnActualizar.Location = new System.Drawing.Point(280, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(137, 40);
            this.btnActualizar.TabIndex = 25;
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
            this.btnEliminar.Location = new System.Drawing.Point(510, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 40);
            this.btnEliminar.TabIndex = 24;
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
            this.btnAgregar.Location = new System.Drawing.Point(50, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 40);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.dtpHora);
            this.panelCampos.Controls.Add(this.cboTurno);
            this.panelCampos.Controls.Add(this.lblTurno);
            this.panelCampos.Controls.Add(this.cboDia);
            this.panelCampos.Controls.Add(this.lblDia);
            this.panelCampos.Controls.Add(this.cboEmpleados);
            this.panelCampos.Controls.Add(this.lblEmpleado);
            this.panelCampos.Controls.Add(this.dtpFecha);
            this.panelCampos.Controls.Add(this.lblFecha);
            this.panelCampos.Controls.Add(this.lblHora);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(3, 3);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(672, 145);
            this.panelCampos.TabIndex = 1;
            // 
            // dtpHora
            // 
            this.dtpHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpHora.CustomFormat = "hh:mm";
            this.dtpHora.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(470, 6);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(188, 32);
            this.dtpHora.TabIndex = 52;
            // 
            // cboTurno
            // 
            this.cboTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(239, 58);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(171, 23);
            this.cboTurno.TabIndex = 51;
            // 
            // lblTurno
            // 
            this.lblTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTurno.AutoSize = true;
            this.lblTurno.BackColor = System.Drawing.Color.Transparent;
            this.lblTurno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurno.ForeColor = System.Drawing.Color.Black;
            this.lblTurno.Location = new System.Drawing.Point(183, 61);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(50, 20);
            this.lblTurno.TabIndex = 50;
            this.lblTurno.Text = "Turno: ";
            // 
            // cboDia
            // 
            this.cboDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDia.Enabled = false;
            this.cboDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Location = new System.Drawing.Point(239, 11);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(171, 23);
            this.cboDia.TabIndex = 49;
            // 
            // lblDia
            // 
            this.lblDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDia.ForeColor = System.Drawing.Color.Black;
            this.lblDia.Location = new System.Drawing.Point(197, 10);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(36, 20);
            this.lblDia.TabIndex = 48;
            this.lblDia.Text = "Dia: ";
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(87, 102);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(556, 28);
            this.cboEmpleados.TabIndex = 47;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(6, 105);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 20);
            this.lblEmpleado.TabIndex = 46;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(62, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(129, 32);
            this.dtpFecha.TabIndex = 28;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(6, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(416, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 20);
            this.lblHora.TabIndex = 26;
            this.lblHora.Text = "Hora:";
            // 
            // errorHorario
            // 
            this.errorHorario.ContainerControl = this;
            // 
            // HorarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HorarioAdmin";
            this.Text = "HorarioAdmin";
            this.Load += new System.EventHandler(this.HorarioAdmin_Load);
            this.panelContenedor.ResumeLayout(false);
            this.PanelDivisor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.PanelDivisor2.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorHorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor2;
        private System.Windows.Forms.Panel panelBotones;
        private BotonEsquinaRedonda btnAgregar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnActualizar;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.ErrorProvider errorHorario;
    }
}