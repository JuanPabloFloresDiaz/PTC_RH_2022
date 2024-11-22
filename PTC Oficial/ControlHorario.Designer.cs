namespace PTC_Oficial
{
    partial class ControlHorario
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
            this.dgvControlHorario = new System.Windows.Forms.DataGridView();
            this.panelSubcontenedor = new System.Windows.Forms.Panel();
            this.cboTiempoTarea = new System.Windows.Forms.ComboBox();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTiempoTarea = new System.Windows.Forms.Label();
            this.btnTiempoTarea = new PTC_Oficial.BotonEsquinaRedonda();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnRegistrar = new PTC_Oficial.BotonEsquinaRedonda();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.lblNIT = new System.Windows.Forms.Label();
            this.txtHorastrabajada = new System.Windows.Forms.TextBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.dtpAcabo = new System.Windows.Forms.DateTimePicker();
            this.lblDescansoA = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDescansode = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.lblSalida = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errorControlhorario = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelObjetos = new System.Windows.Forms.Panel();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlHorario)).BeginInit();
            this.panelSubcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorControlhorario)).BeginInit();
            this.panelObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.ColumnCount = 1;
            this.panelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelContenedor.Controls.Add(this.dgvControlHorario, 0, 1);
            this.panelContenedor.Controls.Add(this.panelSubcontenedor, 0, 0);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.RowCount = 2;
            this.panelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.90141F));
            this.panelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.09859F));
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 0;
            // 
            // dgvControlHorario
            // 
            this.dgvControlHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvControlHorario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvControlHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlHorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControlHorario.Location = new System.Drawing.Point(3, 288);
            this.dgvControlHorario.MultiSelect = false;
            this.dgvControlHorario.Name = "dgvControlHorario";
            this.dgvControlHorario.ReadOnly = true;
            this.dgvControlHorario.RowHeadersVisible = false;
            this.dgvControlHorario.RowTemplate.Height = 25;
            this.dgvControlHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvControlHorario.Size = new System.Drawing.Size(678, 135);
            this.dgvControlHorario.TabIndex = 0;
            this.dgvControlHorario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvControlHorario_CellContentClick);
            // 
            // panelSubcontenedor
            // 
            this.panelSubcontenedor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelSubcontenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubcontenedor.Controls.Add(this.cboTiempoTarea);
            this.panelSubcontenedor.Controls.Add(this.cboEmpleados);
            this.panelSubcontenedor.Controls.Add(this.cboDia);
            this.panelSubcontenedor.Controls.Add(this.lblFecha);
            this.panelSubcontenedor.Controls.Add(this.dtpFecha);
            this.panelSubcontenedor.Controls.Add(this.label1);
            this.panelSubcontenedor.Controls.Add(this.lblTiempoTarea);
            this.panelSubcontenedor.Controls.Add(this.btnTiempoTarea);
            this.panelSubcontenedor.Controls.Add(this.lblEmpleado);
            this.panelSubcontenedor.Controls.Add(this.btnActualizar);
            this.panelSubcontenedor.Controls.Add(this.btnEliminar);
            this.panelSubcontenedor.Controls.Add(this.btnRegistrar);
            this.panelSubcontenedor.Controls.Add(this.txtNIT);
            this.panelSubcontenedor.Controls.Add(this.lblNIT);
            this.panelSubcontenedor.Controls.Add(this.txtHorastrabajada);
            this.panelSubcontenedor.Controls.Add(this.lblHoras);
            this.panelSubcontenedor.Controls.Add(this.dtpAcabo);
            this.panelSubcontenedor.Controls.Add(this.lblDescansoA);
            this.panelSubcontenedor.Controls.Add(this.dtpInicio);
            this.panelSubcontenedor.Controls.Add(this.lblDescansode);
            this.panelSubcontenedor.Controls.Add(this.dtpSalida);
            this.panelSubcontenedor.Controls.Add(this.lblSalida);
            this.panelSubcontenedor.Controls.Add(this.dtpEntrada);
            this.panelSubcontenedor.Controls.Add(this.lblEntrada);
            this.panelSubcontenedor.Controls.Add(this.lblDia);
            this.panelSubcontenedor.Controls.Add(this.lblTitulo);
            this.panelSubcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubcontenedor.Location = new System.Drawing.Point(3, 3);
            this.panelSubcontenedor.Name = "panelSubcontenedor";
            this.panelSubcontenedor.Size = new System.Drawing.Size(678, 279);
            this.panelSubcontenedor.TabIndex = 1;
            // 
            // cboTiempoTarea
            // 
            this.cboTiempoTarea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTiempoTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiempoTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTiempoTarea.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboTiempoTarea.FormattingEnabled = true;
            this.cboTiempoTarea.Location = new System.Drawing.Point(527, 85);
            this.cboTiempoTarea.Name = "cboTiempoTarea";
            this.cboTiempoTarea.Size = new System.Drawing.Size(140, 28);
            this.cboTiempoTarea.TabIndex = 50;
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(339, 188);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(211, 28);
            this.cboEmpleados.TabIndex = 49;
            // 
            // cboDia
            // 
            this.cboDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDia.Enabled = false;
            this.cboDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Location = new System.Drawing.Point(51, 36);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(202, 23);
            this.cboDia.TabIndex = 48;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(322, 125);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 47;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(381, 125);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(140, 32);
            this.dtpFecha.TabIndex = 46;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(556, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 40);
            this.label1.TabIndex = 45;
            this.label1.Text = "Generar\r\ntiempo por tarea:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiempoTarea
            // 
            this.lblTiempoTarea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTiempoTarea.AutoSize = true;
            this.lblTiempoTarea.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTiempoTarea.ForeColor = System.Drawing.Color.Black;
            this.lblTiempoTarea.Location = new System.Drawing.Point(550, 36);
            this.lblTiempoTarea.Name = "lblTiempoTarea";
            this.lblTiempoTarea.Size = new System.Drawing.Size(115, 20);
            this.lblTiempoTarea.TabIndex = 43;
            this.lblTiempoTarea.Text = "Tiempo por tarea:";
            this.lblTiempoTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTiempoTarea
            // 
            this.btnTiempoTarea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTiempoTarea.BackColor = System.Drawing.Color.Transparent;
            this.btnTiempoTarea.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTiempoTarea.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnTiempoTarea.BorderRadius = 40;
            this.btnTiempoTarea.BorderSize = 0;
            this.btnTiempoTarea.FlatAppearance.BorderSize = 0;
            this.btnTiempoTarea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnTiempoTarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTiempoTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiempoTarea.ForeColor = System.Drawing.Color.Gold;
            this.btnTiempoTarea.Location = new System.Drawing.Point(550, 185);
            this.btnTiempoTarea.Name = "btnTiempoTarea";
            this.btnTiempoTarea.Size = new System.Drawing.Size(117, 40);
            this.btnTiempoTarea.TabIndex = 42;
            this.btnTiempoTarea.Text = "Tiempo por tarea";
            this.btnTiempoTarea.TextColor = System.Drawing.Color.Gold;
            this.btnTiempoTarea.UseVisualStyleBackColor = false;
            this.btnTiempoTarea.Click += new System.EventHandler(this.btnTiempoTarea_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(258, 188);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 20);
            this.lblEmpleado.TabIndex = 40;
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
            this.btnActualizar.Location = new System.Drawing.Point(550, 231);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 40);
            this.btnActualizar.TabIndex = 38;
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
            this.btnEliminar.Location = new System.Drawing.Point(404, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 40);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.Red;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.BackColor = System.Drawing.Color.Snow;
            this.btnRegistrar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnRegistrar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.BorderRadius = 40;
            this.btnRegistrar.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.Location = new System.Drawing.Point(268, 230);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 40);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Insertar";
            this.btnRegistrar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNIT
            // 
            this.txtNIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNIT.BackColor = System.Drawing.Color.White;
            this.txtNIT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIT.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNIT.Location = new System.Drawing.Point(381, 73);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(140, 25);
            this.txtNIT.TabIndex = 31;
            // 
            // lblNIT
            // 
            this.lblNIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNIT.ForeColor = System.Drawing.Color.Black;
            this.lblNIT.Location = new System.Drawing.Point(339, 77);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(36, 20);
            this.lblNIT.TabIndex = 30;
            this.lblNIT.Text = "NIT: ";
            this.lblNIT.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtHorastrabajada
            // 
            this.txtHorastrabajada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHorastrabajada.BackColor = System.Drawing.Color.White;
            this.txtHorastrabajada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorastrabajada.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHorastrabajada.Location = new System.Drawing.Point(381, 36);
            this.txtHorastrabajada.Name = "txtHorastrabajada";
            this.txtHorastrabajada.Size = new System.Drawing.Size(140, 25);
            this.txtHorastrabajada.TabIndex = 29;
            // 
            // lblHoras
            // 
            this.lblHoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoras.ForeColor = System.Drawing.Color.Black;
            this.lblHoras.Location = new System.Drawing.Point(258, 41);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(117, 20);
            this.lblHoras.TabIndex = 28;
            this.lblHoras.Text = "Horas trabajadas: ";
            // 
            // dtpAcabo
            // 
            this.dtpAcabo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpAcabo.CustomFormat = "hh:mm";
            this.dtpAcabo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpAcabo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAcabo.Location = new System.Drawing.Point(98, 231);
            this.dtpAcabo.Name = "dtpAcabo";
            this.dtpAcabo.Size = new System.Drawing.Size(155, 32);
            this.dtpAcabo.TabIndex = 27;
            // 
            // lblDescansoA
            // 
            this.lblDescansoA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescansoA.AutoSize = true;
            this.lblDescansoA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescansoA.ForeColor = System.Drawing.Color.Black;
            this.lblDescansoA.Location = new System.Drawing.Point(9, 231);
            this.lblDescansoA.Name = "lblDescansoA";
            this.lblDescansoA.Size = new System.Drawing.Size(83, 40);
            this.lblDescansoA.TabIndex = 26;
            this.lblDescansoA.Text = "Acabo su\r\ndescanso a:";
            this.lblDescansoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpInicio.CustomFormat = "hh:mm";
            this.dtpInicio.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(98, 181);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(155, 32);
            this.dtpInicio.TabIndex = 25;
            // 
            // lblDescansode
            // 
            this.lblDescansode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescansode.AutoSize = true;
            this.lblDescansode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescansode.ForeColor = System.Drawing.Color.Black;
            this.lblDescansode.Location = new System.Drawing.Point(9, 181);
            this.lblDescansode.Name = "lblDescansode";
            this.lblDescansode.Size = new System.Drawing.Size(83, 40);
            this.lblDescansode.TabIndex = 24;
            this.lblDescansode.Text = "Inicio su\r\ndescanso a:";
            this.lblDescansode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpSalida.CustomFormat = "hh:mm";
            this.dtpSalida.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalida.Location = new System.Drawing.Point(65, 128);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(188, 32);
            this.dtpSalida.TabIndex = 23;
            // 
            // lblSalida
            // 
            this.lblSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalida.ForeColor = System.Drawing.Color.Black;
            this.lblSalida.Location = new System.Drawing.Point(9, 135);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(50, 20);
            this.lblSalida.TabIndex = 22;
            this.lblSalida.Text = "Salida:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEntrada.CustomFormat = "hh:mm";
            this.dtpEntrada.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntrada.Location = new System.Drawing.Point(73, 78);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(180, 32);
            this.dtpEntrada.TabIndex = 21;
            // 
            // lblEntrada
            // 
            this.lblEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEntrada.ForeColor = System.Drawing.Color.Black;
            this.lblEntrada.Location = new System.Drawing.Point(9, 85);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(58, 20);
            this.lblEntrada.TabIndex = 20;
            this.lblEntrada.Text = "Entrada:";
            // 
            // lblDia
            // 
            this.lblDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDia.ForeColor = System.Drawing.Color.Black;
            this.lblDia.Location = new System.Drawing.Point(9, 41);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(36, 20);
            this.lblDia.TabIndex = 18;
            this.lblDia.Text = "Dia: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(235, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(224, 29);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Control de horario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorControlhorario
            // 
            this.errorControlhorario.ContainerControl = this;
            // 
            // panelObjetos
            // 
            this.panelObjetos.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelObjetos.Controls.Add(this.panelContenedor);
            this.panelObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjetos.Location = new System.Drawing.Point(0, 0);
            this.panelObjetos.Name = "panelObjetos";
            this.panelObjetos.Size = new System.Drawing.Size(684, 426);
            this.panelObjetos.TabIndex = 1;
            // 
            // ControlHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelObjetos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlHorario";
            this.Text = "ControlHorario";
            this.Load += new System.EventHandler(this.ControlHorario_Load);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlHorario)).EndInit();
            this.panelSubcontenedor.ResumeLayout(false);
            this.panelSubcontenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorControlhorario)).EndInit();
            this.panelObjetos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelContenedor;
        private System.Windows.Forms.DataGridView dgvControlHorario;
        private System.Windows.Forms.Panel panelSubcontenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.DateTimePicker dtpAcabo;
        private System.Windows.Forms.Label lblDescansoA;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblDescansode;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.TextBox txtHorastrabajada;
        private System.Windows.Forms.Label lblHoras;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnRegistrar;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblTiempoTarea;
        private BotonEsquinaRedonda btnTiempoTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.ComboBox cboTiempoTarea;
        private System.Windows.Forms.ErrorProvider errorControlhorario;
        private System.Windows.Forms.Panel panelObjetos;
    }
}