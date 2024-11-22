namespace PTC_Oficial
{
    partial class FormContratacionEmpleado
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
            this.panelObjetos = new System.Windows.Forms.Panel();
            this.PanelDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.panelDashboard2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.panelDashboard4 = new System.Windows.Forms.TableLayoutPanel();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnTabla = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnElminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.panelDashboard1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFechanacimiento = new System.Windows.Forms.Label();
            this.lblNombrecompleto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panelDashboard3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIngresar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.PanelGenero = new System.Windows.Forms.TableLayoutPanel();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.PanelArea = new System.Windows.Forms.TableLayoutPanel();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.errorContratos = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelObjetos.SuspendLayout();
            this.PanelDivisor.SuspendLayout();
            this.panelDashboard2.SuspendLayout();
            this.panelDashboard4.SuspendLayout();
            this.panelDashboard1.SuspendLayout();
            this.panelDashboard3.SuspendLayout();
            this.PanelGenero.SuspendLayout();
            this.PanelArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelObjetos);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelObjetos
            // 
            this.panelObjetos.Controls.Add(this.PanelDivisor);
            this.panelObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjetos.Location = new System.Drawing.Point(0, 0);
            this.panelObjetos.Name = "panelObjetos";
            this.panelObjetos.Size = new System.Drawing.Size(684, 426);
            this.panelObjetos.TabIndex = 0;
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 2;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.panelDashboard2, 1, 0);
            this.PanelDivisor.Controls.Add(this.panelDashboard4, 1, 1);
            this.PanelDivisor.Controls.Add(this.panelDashboard1, 0, 0);
            this.PanelDivisor.Controls.Add(this.panelDashboard3, 0, 1);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 2;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 0;
            this.PanelDivisor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDivisor_Paint);
            // 
            // panelDashboard2
            // 
            this.panelDashboard2.ColumnCount = 2;
            this.panelDashboard2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard2.Controls.Add(this.txtDireccion, 1, 1);
            this.panelDashboard2.Controls.Add(this.lblDireccion, 0, 1);
            this.panelDashboard2.Controls.Add(this.lblIngreso, 0, 0);
            this.panelDashboard2.Controls.Add(this.dtpIngreso, 1, 0);
            this.panelDashboard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard2.Location = new System.Drawing.Point(345, 3);
            this.panelDashboard2.Name = "panelDashboard2";
            this.panelDashboard2.RowCount = 2;
            this.panelDashboard2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard2.Size = new System.Drawing.Size(336, 207);
            this.panelDashboard2.TabIndex = 0;
            this.panelDashboard2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard2_Paint);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.Location = new System.Drawing.Point(171, 108);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(162, 94);
            this.txtDireccion.TabIndex = 27;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(39, 133);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(126, 44);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección del empleado:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreso.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIngreso.ForeColor = System.Drawing.Color.Black;
            this.lblIngreso.Location = new System.Drawing.Point(70, 29);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(95, 44);
            this.lblIngreso.TabIndex = 4;
            this.lblIngreso.Text = "Fecha de ingreso:";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpIngreso.CalendarFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpIngreso.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpIngreso.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpIngreso.CalendarTitleBackColor = System.Drawing.Color.PaleTurquoise;
            this.dtpIngreso.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpIngreso.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpIngreso.CustomFormat = "yyyy-MM-dd";
            this.dtpIngreso.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIngreso.Location = new System.Drawing.Point(171, 37);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(162, 29);
            this.dtpIngreso.TabIndex = 28;
            // 
            // panelDashboard4
            // 
            this.panelDashboard4.ColumnCount = 2;
            this.panelDashboard4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard4.Controls.Add(this.cboUsuario, 1, 0);
            this.panelDashboard4.Controls.Add(this.lblEmpleado, 0, 0);
            this.panelDashboard4.Controls.Add(this.btnTabla, 1, 1);
            this.panelDashboard4.Controls.Add(this.btnElminar, 0, 1);
            this.panelDashboard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard4.Location = new System.Drawing.Point(345, 216);
            this.panelDashboard4.Name = "panelDashboard4";
            this.panelDashboard4.RowCount = 2;
            this.panelDashboard4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard4.Size = new System.Drawing.Size(336, 207);
            this.panelDashboard4.TabIndex = 1;
            // 
            // cboUsuario
            // 
            this.cboUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUsuario.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(171, 35);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(162, 32);
            this.cboUsuario.TabIndex = 46;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(72, 37);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(93, 29);
            this.lblEmpleado.TabIndex = 45;
            this.lblEmpleado.Text = "Usuario:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTabla
            // 
            this.btnTabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTabla.BackColor = System.Drawing.Color.LightGray;
            this.btnTabla.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnTabla.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTabla.BorderRadius = 40;
            this.btnTabla.BorderSize = 0;
            this.btnTabla.FlatAppearance.BorderSize = 0;
            this.btnTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabla.ForeColor = System.Drawing.Color.Yellow;
            this.btnTabla.Location = new System.Drawing.Point(171, 135);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(162, 40);
            this.btnTabla.TabIndex = 0;
            this.btnTabla.Text = "Tabla de ingresos";
            this.btnTabla.TextColor = System.Drawing.Color.Yellow;
            this.btnTabla.UseVisualStyleBackColor = false;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // btnElminar
            // 
            this.btnElminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElminar.BackColor = System.Drawing.Color.Snow;
            this.btnElminar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnElminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnElminar.BorderRadius = 40;
            this.btnElminar.BorderSize = 0;
            this.btnElminar.Enabled = false;
            this.btnElminar.FlatAppearance.BorderSize = 0;
            this.btnElminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElminar.ForeColor = System.Drawing.Color.Red;
            this.btnElminar.Location = new System.Drawing.Point(3, 135);
            this.btnElminar.Name = "btnElminar";
            this.btnElminar.Size = new System.Drawing.Size(162, 40);
            this.btnElminar.TabIndex = 1;
            this.btnElminar.Text = "Eliminar";
            this.btnElminar.TextColor = System.Drawing.Color.Red;
            this.btnElminar.UseVisualStyleBackColor = false;
            this.btnElminar.Click += new System.EventHandler(this.btnElminar_Click);
            // 
            // panelDashboard1
            // 
            this.panelDashboard1.ColumnCount = 2;
            this.panelDashboard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard1.Controls.Add(this.lblFechanacimiento, 0, 1);
            this.panelDashboard1.Controls.Add(this.lblNombrecompleto, 0, 0);
            this.panelDashboard1.Controls.Add(this.txtNombre, 1, 0);
            this.panelDashboard1.Controls.Add(this.dtpNacimiento, 1, 1);
            this.panelDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard1.Location = new System.Drawing.Point(3, 3);
            this.panelDashboard1.Name = "panelDashboard1";
            this.panelDashboard1.RowCount = 2;
            this.panelDashboard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard1.Size = new System.Drawing.Size(336, 207);
            this.panelDashboard1.TabIndex = 2;
            // 
            // lblFechanacimiento
            // 
            this.lblFechanacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechanacimiento.AutoSize = true;
            this.lblFechanacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechanacimiento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechanacimiento.ForeColor = System.Drawing.Color.Black;
            this.lblFechanacimiento.Location = new System.Drawing.Point(59, 133);
            this.lblFechanacimiento.Name = "lblFechanacimiento";
            this.lblFechanacimiento.Size = new System.Drawing.Size(106, 44);
            this.lblFechanacimiento.TabIndex = 3;
            this.lblFechanacimiento.Text = "Fecha nacimiento:";
            // 
            // lblNombrecompleto
            // 
            this.lblNombrecompleto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombrecompleto.AutoSize = true;
            this.lblNombrecompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrecompleto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombrecompleto.ForeColor = System.Drawing.Color.Black;
            this.lblNombrecompleto.Location = new System.Drawing.Point(58, 29);
            this.lblNombrecompleto.Name = "lblNombrecompleto";
            this.lblNombrecompleto.Size = new System.Drawing.Size(107, 44);
            this.lblNombrecompleto.TabIndex = 2;
            this.lblNombrecompleto.Text = "Nombres y apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(171, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 25);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNacimiento.CalendarFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpNacimiento.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpNacimiento.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNacimiento.CalendarTitleBackColor = System.Drawing.Color.PaleTurquoise;
            this.dtpNacimiento.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpNacimiento.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtpNacimiento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNacimiento.Location = new System.Drawing.Point(171, 140);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(162, 29);
            this.dtpNacimiento.TabIndex = 27;
            // 
            // panelDashboard3
            // 
            this.panelDashboard3.ColumnCount = 2;
            this.panelDashboard3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard3.Controls.Add(this.btnIngresar, 0, 1);
            this.panelDashboard3.Controls.Add(this.btnActualizar, 1, 1);
            this.panelDashboard3.Controls.Add(this.PanelGenero, 1, 0);
            this.panelDashboard3.Controls.Add(this.PanelArea, 0, 0);
            this.panelDashboard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard3.Location = new System.Drawing.Point(3, 216);
            this.panelDashboard3.Name = "panelDashboard3";
            this.panelDashboard3.RowCount = 2;
            this.panelDashboard3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard3.Size = new System.Drawing.Size(336, 207);
            this.panelDashboard3.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.BackColor = System.Drawing.Color.Snow;
            this.btnIngresar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnIngresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIngresar.BorderRadius = 40;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.Color.Blue;
            this.btnIngresar.Location = new System.Drawing.Point(3, 135);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(162, 40);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.Blue;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.Snow;
            this.btnActualizar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizar.BorderRadius = 40;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Lime;
            this.btnActualizar.Location = new System.Drawing.Point(171, 135);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(162, 40);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Lime;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // PanelGenero
            // 
            this.PanelGenero.ColumnCount = 2;
            this.PanelGenero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.20988F));
            this.PanelGenero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.79012F));
            this.PanelGenero.Controls.Add(this.cboGenero, 0, 0);
            this.PanelGenero.Controls.Add(this.lblGenero, 0, 0);
            this.PanelGenero.Location = new System.Drawing.Point(171, 3);
            this.PanelGenero.Name = "PanelGenero";
            this.PanelGenero.RowCount = 1;
            this.PanelGenero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelGenero.Size = new System.Drawing.Size(162, 97);
            this.PanelGenero.TabIndex = 2;
            // 
            // cboGenero
            // 
            this.cboGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGenero.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(73, 34);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(86, 28);
            this.cboGenero.TabIndex = 47;
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.Color.Black;
            this.lblGenero.Location = new System.Drawing.Point(3, 39);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 18);
            this.lblGenero.TabIndex = 9;
            this.lblGenero.Text = "Genero:";
            // 
            // PanelArea
            // 
            this.PanelArea.ColumnCount = 2;
            this.PanelArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.PanelArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.PanelArea.Controls.Add(this.cboArea, 0, 0);
            this.PanelArea.Controls.Add(this.lblArea, 0, 0);
            this.PanelArea.Location = new System.Drawing.Point(3, 3);
            this.PanelArea.Name = "PanelArea";
            this.PanelArea.RowCount = 1;
            this.PanelArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelArea.Size = new System.Drawing.Size(162, 97);
            this.PanelArea.TabIndex = 3;
            // 
            // cboArea
            // 
            this.cboArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboArea.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(66, 34);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(93, 28);
            this.cboArea.TabIndex = 47;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArea.ForeColor = System.Drawing.Color.Black;
            this.lblArea.Location = new System.Drawing.Point(4, 23);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(56, 51);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area de trabajo:";
            // 
            // errorContratos
            // 
            this.errorContratos.ContainerControl = this;
            // 
            // FormContratacionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContratacionEmpleado";
            this.Text = "FormContratacionEmpleado";
            this.Load += new System.EventHandler(this.FormContratacionEmpleado_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelObjetos.ResumeLayout(false);
            this.PanelDivisor.ResumeLayout(false);
            this.panelDashboard2.ResumeLayout(false);
            this.panelDashboard2.PerformLayout();
            this.panelDashboard4.ResumeLayout(false);
            this.panelDashboard4.PerformLayout();
            this.panelDashboard1.ResumeLayout(false);
            this.panelDashboard1.PerformLayout();
            this.panelDashboard3.ResumeLayout(false);
            this.PanelGenero.ResumeLayout(false);
            this.PanelGenero.PerformLayout();
            this.PanelArea.ResumeLayout(false);
            this.PanelArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorContratos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelObjetos;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.TableLayoutPanel panelDashboard2;
        private System.Windows.Forms.TableLayoutPanel panelDashboard4;
        private System.Windows.Forms.TableLayoutPanel panelDashboard1;
        private System.Windows.Forms.TableLayoutPanel panelDashboard3;
        private System.Windows.Forms.TableLayoutPanel PanelGenero;
        private System.Windows.Forms.TableLayoutPanel PanelArea;
        private System.Windows.Forms.ErrorProvider errorContratos;
        public System.Windows.Forms.ComboBox cboUsuario;
        public System.Windows.Forms.ComboBox cboGenero;
        public System.Windows.Forms.ComboBox cboArea;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.DateTimePicker dtpIngreso;
        public System.Windows.Forms.DateTimePicker dtpNacimiento;
        public BotonEsquinaRedonda btnIngresar;
        public BotonEsquinaRedonda btnTabla;
        public BotonEsquinaRedonda btnElminar;
        public BotonEsquinaRedonda btnActualizar;
        public System.Windows.Forms.Label lblNombrecompleto;
        public System.Windows.Forms.Label lblFechanacimiento;
        public System.Windows.Forms.Label lblIngreso;
        public System.Windows.Forms.Label lblDireccion;
        public System.Windows.Forms.Label lblGenero;
        public System.Windows.Forms.Label lblArea;
        public System.Windows.Forms.Label lblEmpleado;
    }
}