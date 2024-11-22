namespace PTC_Oficial
{
    partial class Menu_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Empleado));
            this.panelBarradetitulo = new System.Windows.Forms.Panel();
            this.cboTemas = new System.Windows.Forms.ComboBox();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularioPadre = new System.Windows.Forms.Panel();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCalculadora = new FontAwesome.Sharp.IconButton();
            this.btnPermisos = new FontAwesome.Sharp.IconButton();
            this.btnAdelantos = new FontAwesome.Sharp.IconButton();
            this.btnHorario = new FontAwesome.Sharp.IconButton();
            this.btnSalario = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.panelBarradetitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelFormularioPadre.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarradetitulo
            // 
            this.panelBarradetitulo.BackColor = System.Drawing.Color.Gray;
            this.panelBarradetitulo.Controls.Add(this.cboTemas);
            this.panelBarradetitulo.Controls.Add(this.btnCerrarSesion);
            this.panelBarradetitulo.Controls.Add(this.btnMinimizar);
            this.panelBarradetitulo.Controls.Add(this.btnRestaurar);
            this.panelBarradetitulo.Controls.Add(this.btnMaximizar);
            this.panelBarradetitulo.Controls.Add(this.btnCerrar);
            this.panelBarradetitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarradetitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarradetitulo.Name = "panelBarradetitulo";
            this.panelBarradetitulo.Size = new System.Drawing.Size(884, 35);
            this.panelBarradetitulo.TabIndex = 1;
            this.panelBarradetitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarradetitulo_MouseDown);
            // 
            // cboTemas
            // 
            this.cboTemas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTemas.BackColor = System.Drawing.Color.Gray;
            this.cboTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTemas.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.cboTemas.ForeColor = System.Drawing.Color.Black;
            this.cboTemas.FormattingEnabled = true;
            this.cboTemas.Items.AddRange(new object[] {
            "Defecto",
            "Azul",
            "Amarillo",
            "Rojo",
            "Verde",
            "Cafe",
            "Morado"});
            this.cboTemas.Location = new System.Drawing.Point(614, 1);
            this.cboTemas.Name = "cboTemas";
            this.cboTemas.Size = new System.Drawing.Size(121, 31);
            this.cboTemas.TabIndex = 13;
            this.cboTemas.Visible = false;
            this.cboTemas.SelectedIndexChanged += new System.EventHandler(this.cboTemas_SelectedIndexChanged);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(157, 29);
            this.btnCerrarSesion.TabIndex = 12;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::PTC_Oficial.Properties.Resources.BTNMinimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(741, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(47, 35);
            this.btnMinimizar.TabIndex = 11;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = global::PTC_Oficial.Properties.Resources.btnRestaurar;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(794, -3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(47, 35);
            this.btnRestaurar.TabIndex = 10;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::PTC_Oficial.Properties.Resources.btnMaximizar;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(794, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(47, 35);
            this.btnMaximizar.TabIndex = 9;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::PTC_Oficial.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(837, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 35);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Turquoise;
            this.panelContenedor.Controls.Add(this.panelFormularioPadre);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(884, 426);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelFormularioPadre
            // 
            this.panelFormularioPadre.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelFormularioPadre.Controls.Add(this.lblSaludo);
            this.panelFormularioPadre.Controls.Add(this.lblFecha);
            this.panelFormularioPadre.Controls.Add(this.lblHora);
            this.panelFormularioPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioPadre.Location = new System.Drawing.Point(200, 0);
            this.panelFormularioPadre.Name = "panelFormularioPadre";
            this.panelFormularioPadre.Size = new System.Drawing.Size(684, 426);
            this.panelFormularioPadre.TabIndex = 2;
            // 
            // lblSaludo
            // 
            this.lblSaludo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.Location = new System.Drawing.Point(78, 264);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(276, 29);
            this.lblSaludo.TabIndex = 16;
            this.lblSaludo.Text = "¡Bienvenido empleado!";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFecha.Location = new System.Drawing.Point(6, 137);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(128, 44);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.Green;
            this.lblHora.Location = new System.Drawing.Point(6, 25);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(104, 44);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "Hora";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelMenu.Controls.Add(this.btnCalculadora);
            this.panelMenu.Controls.Add(this.btnPermisos);
            this.panelMenu.Controls.Add(this.btnAdelantos);
            this.panelMenu.Controls.Add(this.btnHorario);
            this.panelMenu.Controls.Add(this.btnSalario);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 426);
            this.panelMenu.TabIndex = 1;
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalculadora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculadora.FlatAppearance.BorderSize = 0;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculadora.ForeColor = System.Drawing.Color.White;
            this.btnCalculadora.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalculadora.IconColor = System.Drawing.Color.White;
            this.btnCalculadora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalculadora.IconSize = 30;
            this.btnCalculadora.Location = new System.Drawing.Point(0, 296);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(200, 34);
            this.btnCalculadora.TabIndex = 7;
            this.btnCalculadora.Text = "Calculadora salarial";
            this.btnCalculadora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculadora.UseVisualStyleBackColor = false;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.BackColor = System.Drawing.Color.Transparent;
            this.btnPermisos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPermisos.FlatAppearance.BorderSize = 0;
            this.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermisos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPermisos.ForeColor = System.Drawing.Color.White;
            this.btnPermisos.IconChar = FontAwesome.Sharp.IconChar.HandDots;
            this.btnPermisos.IconColor = System.Drawing.Color.White;
            this.btnPermisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPermisos.IconSize = 30;
            this.btnPermisos.Location = new System.Drawing.Point(0, 262);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(200, 34);
            this.btnPermisos.TabIndex = 6;
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPermisos.UseVisualStyleBackColor = false;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnAdelantos
            // 
            this.btnAdelantos.BackColor = System.Drawing.Color.Transparent;
            this.btnAdelantos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdelantos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdelantos.FlatAppearance.BorderSize = 0;
            this.btnAdelantos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdelantos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdelantos.ForeColor = System.Drawing.Color.White;
            this.btnAdelantos.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnAdelantos.IconColor = System.Drawing.Color.White;
            this.btnAdelantos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdelantos.IconSize = 30;
            this.btnAdelantos.Location = new System.Drawing.Point(0, 228);
            this.btnAdelantos.Name = "btnAdelantos";
            this.btnAdelantos.Size = new System.Drawing.Size(200, 34);
            this.btnAdelantos.TabIndex = 5;
            this.btnAdelantos.Text = "Adelantos";
            this.btnAdelantos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdelantos.UseVisualStyleBackColor = false;
            this.btnAdelantos.Click += new System.EventHandler(this.btnAdelantos_Click);
            // 
            // btnHorario
            // 
            this.btnHorario.BackColor = System.Drawing.Color.Transparent;
            this.btnHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorario.FlatAppearance.BorderSize = 0;
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHorario.ForeColor = System.Drawing.Color.White;
            this.btnHorario.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.btnHorario.IconColor = System.Drawing.Color.White;
            this.btnHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHorario.IconSize = 30;
            this.btnHorario.Location = new System.Drawing.Point(0, 194);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(200, 34);
            this.btnHorario.TabIndex = 4;
            this.btnHorario.Text = "Horario";
            this.btnHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHorario.UseVisualStyleBackColor = false;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // btnSalario
            // 
            this.btnSalario.BackColor = System.Drawing.Color.Transparent;
            this.btnSalario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalario.FlatAppearance.BorderSize = 0;
            this.btnSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalario.ForeColor = System.Drawing.Color.White;
            this.btnSalario.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnSalario.IconColor = System.Drawing.Color.White;
            this.btnSalario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalario.IconSize = 30;
            this.btnSalario.Location = new System.Drawing.Point(0, 160);
            this.btnSalario.Name = "btnSalario";
            this.btnSalario.Size = new System.Drawing.Size(200, 34);
            this.btnSalario.TabIndex = 3;
            this.btnSalario.Text = "Salario";
            this.btnSalario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalario.UseVisualStyleBackColor = false;
            this.btnSalario.Click += new System.EventHandler(this.btnSalario_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Snow;
            this.panelLogo.BackgroundImage = global::PTC_Oficial.Properties.Resources.logoJARDD;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 160);
            this.panelLogo.TabIndex = 1;
            // 
            // timerReloj
            // 
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // Menu_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarradetitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Empleado";
            this.Activated += new System.EventHandler(this.Menu_Empleado_Activated);
            this.Load += new System.EventHandler(this.Menu_Empleado_Load);
            this.ResizeEnd += new System.EventHandler(this.Menu_Empleado_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Menu_Empleado_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Empleado_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_Empleado_MouseDown);
            this.panelBarradetitulo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularioPadre.ResumeLayout(false);
            this.panelFormularioPadre.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarradetitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnHorario;
        private FontAwesome.Sharp.IconButton btnSalario;
        private FontAwesome.Sharp.IconButton btnCalculadora;
        private FontAwesome.Sharp.IconButton btnPermisos;
        private FontAwesome.Sharp.IconButton btnAdelantos;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Panel panelFormularioPadre;
        private System.Windows.Forms.ComboBox cboTemas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.Label lblSaludo;
    }
}