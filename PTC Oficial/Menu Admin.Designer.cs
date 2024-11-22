namespace PTC_Oficial
{
    partial class Menu_Admin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Admin));
            panelBarradetitulo = new System.Windows.Forms.Panel();
            cboTemas = new System.Windows.Forms.ComboBox();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new System.Windows.Forms.Button();
            btnRestaurar = new System.Windows.Forms.Button();
            btnMaximizar = new System.Windows.Forms.Button();
            btnCerrar = new System.Windows.Forms.Button();
            panelContenedor = new System.Windows.Forms.Panel();
            panelFormularioPadre = new System.Windows.Forms.Panel();
            lblSaludo = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            lblHora = new System.Windows.Forms.Label();
            panelMenu = new System.Windows.Forms.Panel();
            btnFunciones = new FontAwesome.Sharp.IconButton();
            btnCalculadora = new FontAwesome.Sharp.IconButton();
            btnRegistro = new FontAwesome.Sharp.IconButton();
            btnCalendario = new FontAwesome.Sharp.IconButton();
            btnRegistroPago = new FontAwesome.Sharp.IconButton();
            btnMenuAdm = new FontAwesome.Sharp.IconButton();
            panelLogo = new System.Windows.Forms.Panel();
            timerReloj = new System.Windows.Forms.Timer(components);
            panelBarradetitulo.SuspendLayout();
            panelContenedor.SuspendLayout();
            panelFormularioPadre.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelBarradetitulo
            // 
            panelBarradetitulo.BackColor = System.Drawing.Color.Gray;
            panelBarradetitulo.Controls.Add(cboTemas);
            panelBarradetitulo.Controls.Add(btnCerrarSesion);
            panelBarradetitulo.Controls.Add(btnMinimizar);
            panelBarradetitulo.Controls.Add(btnRestaurar);
            panelBarradetitulo.Controls.Add(btnMaximizar);
            panelBarradetitulo.Controls.Add(btnCerrar);
            panelBarradetitulo.Dock = System.Windows.Forms.DockStyle.Top;
            panelBarradetitulo.Location = new System.Drawing.Point(0, 0);
            panelBarradetitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelBarradetitulo.Name = "panelBarradetitulo";
            panelBarradetitulo.Size = new System.Drawing.Size(1010, 47);
            panelBarradetitulo.TabIndex = 1;
            panelBarradetitulo.MouseDown += panelBarradetitulo_MouseDown;
            // 
            // cboTemas
            // 
            cboTemas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cboTemas.BackColor = System.Drawing.Color.Gray;
            cboTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboTemas.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            cboTemas.ForeColor = System.Drawing.Color.Black;
            cboTemas.FormattingEnabled = true;
            cboTemas.Items.AddRange(new object[] { "Defecto", "Azul", "Amarillo", "Rojo", "Verde", "Cafe", "Morado" });
            cboTemas.Location = new System.Drawing.Point(704, 1);
            cboTemas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboTemas.Name = "cboTemas";
            cboTemas.Size = new System.Drawing.Size(138, 37);
            cboTemas.TabIndex = 14;
            cboTemas.Visible = false;
            cboTemas.SelectedIndexChanged += cboTemas_SelectedIndexChanged;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = System.Drawing.Color.Gray;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrarSesion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCerrarSesion.IconColor = System.Drawing.Color.Black;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.Location = new System.Drawing.Point(3, 4);
            btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new System.Drawing.Size(179, 39);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMinimizar.BackgroundImage = Properties.Resources.BTNMinimizar;
            btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinimizar.Location = new System.Drawing.Point(849, 0);
            btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new System.Drawing.Size(54, 47);
            btnMinimizar.TabIndex = 7;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRestaurar.BackgroundImage = Properties.Resources.btnRestaurar;
            btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestaurar.Location = new System.Drawing.Point(903, 0);
            btnRestaurar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new System.Drawing.Size(54, 47);
            btnRestaurar.TabIndex = 6;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMaximizar.BackgroundImage = Properties.Resources.btnMaximizar;
            btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMaximizar.Location = new System.Drawing.Point(903, 0);
            btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new System.Drawing.Size(54, 47);
            btnMaximizar.TabIndex = 5;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.Location = new System.Drawing.Point(957, 0);
            btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(54, 47);
            btnCerrar.TabIndex = 4;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = System.Drawing.Color.Turquoise;
            panelContenedor.Controls.Add(panelFormularioPadre);
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(0, 47);
            panelContenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(1010, 568);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // panelFormularioPadre
            // 
            panelFormularioPadre.BackColor = System.Drawing.Color.PaleTurquoise;
            panelFormularioPadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panelFormularioPadre.Controls.Add(lblSaludo);
            panelFormularioPadre.Controls.Add(lblFecha);
            panelFormularioPadre.Controls.Add(lblHora);
            panelFormularioPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            panelFormularioPadre.Location = new System.Drawing.Point(229, 0);
            panelFormularioPadre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelFormularioPadre.Name = "panelFormularioPadre";
            panelFormularioPadre.Size = new System.Drawing.Size(781, 568);
            panelFormularioPadre.TabIndex = 3;
            // 
            // lblSaludo
            // 
            lblSaludo.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = System.Drawing.Color.Transparent;
            lblSaludo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSaludo.Location = new System.Drawing.Point(65, 341);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new System.Drawing.Size(400, 35);
            lblSaludo.TabIndex = 17;
            lblSaludo.Text = "¡Bienvenido administrador!";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.BackColor = System.Drawing.Color.Transparent;
            lblFecha.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFecha.ForeColor = System.Drawing.Color.DarkBlue;
            lblFecha.Location = new System.Drawing.Point(6, 184);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(148, 51);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblHora.AutoSize = true;
            lblHora.BackColor = System.Drawing.Color.Transparent;
            lblHora.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHora.ForeColor = System.Drawing.Color.Green;
            lblHora.Location = new System.Drawing.Point(6, 35);
            lblHora.Name = "lblHora";
            lblHora.Size = new System.Drawing.Size(122, 51);
            lblHora.TabIndex = 12;
            lblHora.Text = "Hora";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            panelMenu.Controls.Add(btnFunciones);
            panelMenu.Controls.Add(btnCalculadora);
            panelMenu.Controls.Add(btnRegistro);
            panelMenu.Controls.Add(btnCalendario);
            panelMenu.Controls.Add(btnRegistroPago);
            panelMenu.Controls.Add(btnMenuAdm);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(229, 568);
            panelMenu.TabIndex = 0;
            // 
            // btnFunciones
            // 
            btnFunciones.BackColor = System.Drawing.Color.Transparent;
            btnFunciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnFunciones.Dock = System.Windows.Forms.DockStyle.Top;
            btnFunciones.FlatAppearance.BorderSize = 0;
            btnFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFunciones.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnFunciones.ForeColor = System.Drawing.Color.White;
            btnFunciones.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            btnFunciones.IconColor = System.Drawing.Color.White;
            btnFunciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFunciones.IconSize = 30;
            btnFunciones.Location = new System.Drawing.Point(0, 497);
            btnFunciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnFunciones.Name = "btnFunciones";
            btnFunciones.Size = new System.Drawing.Size(229, 45);
            btnFunciones.TabIndex = 10;
            btnFunciones.Text = "Otras funciones";
            btnFunciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFunciones.UseVisualStyleBackColor = false;
            btnFunciones.Click += btnFunciones_Click;
            // 
            // btnCalculadora
            // 
            btnCalculadora.BackColor = System.Drawing.Color.Transparent;
            btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnCalculadora.Dock = System.Windows.Forms.DockStyle.Top;
            btnCalculadora.FlatAppearance.BorderSize = 0;
            btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalculadora.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCalculadora.ForeColor = System.Drawing.Color.White;
            btnCalculadora.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btnCalculadora.IconColor = System.Drawing.Color.White;
            btnCalculadora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCalculadora.IconSize = 30;
            btnCalculadora.Location = new System.Drawing.Point(0, 452);
            btnCalculadora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new System.Drawing.Size(229, 45);
            btnCalculadora.TabIndex = 9;
            btnCalculadora.Text = "Calculadora salarial";
            btnCalculadora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCalculadora.UseVisualStyleBackColor = false;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = System.Drawing.Color.Transparent;
            btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegistro.ForeColor = System.Drawing.Color.White;
            btnRegistro.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnRegistro.IconColor = System.Drawing.Color.White;
            btnRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistro.IconSize = 30;
            btnRegistro.Location = new System.Drawing.Point(0, 379);
            btnRegistro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new System.Drawing.Size(229, 73);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "Registro de usuarios";
            btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnCalendario
            // 
            btnCalendario.BackColor = System.Drawing.Color.Transparent;
            btnCalendario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnCalendario.Dock = System.Windows.Forms.DockStyle.Top;
            btnCalendario.FlatAppearance.BorderSize = 0;
            btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalendario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCalendario.ForeColor = System.Drawing.Color.White;
            btnCalendario.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            btnCalendario.IconColor = System.Drawing.Color.White;
            btnCalendario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCalendario.IconSize = 30;
            btnCalendario.Location = new System.Drawing.Point(0, 303);
            btnCalendario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.Size = new System.Drawing.Size(229, 76);
            btnCalendario.TabIndex = 6;
            btnCalendario.Text = "Calendario de trabajo";
            btnCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCalendario.UseVisualStyleBackColor = false;
            btnCalendario.Click += btnCalendario_Click;
            // 
            // btnRegistroPago
            // 
            btnRegistroPago.BackColor = System.Drawing.Color.Transparent;
            btnRegistroPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnRegistroPago.Dock = System.Windows.Forms.DockStyle.Top;
            btnRegistroPago.FlatAppearance.BorderSize = 0;
            btnRegistroPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistroPago.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegistroPago.ForeColor = System.Drawing.Color.White;
            btnRegistroPago.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            btnRegistroPago.IconColor = System.Drawing.Color.White;
            btnRegistroPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistroPago.IconSize = 30;
            btnRegistroPago.Location = new System.Drawing.Point(0, 258);
            btnRegistroPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRegistroPago.Name = "btnRegistroPago";
            btnRegistroPago.Size = new System.Drawing.Size(229, 45);
            btnRegistroPago.TabIndex = 5;
            btnRegistroPago.Text = "Registro de pagos";
            btnRegistroPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRegistroPago.UseVisualStyleBackColor = false;
            btnRegistroPago.Click += btnRegistroPago_Click;
            // 
            // btnMenuAdm
            // 
            btnMenuAdm.BackColor = System.Drawing.Color.Transparent;
            btnMenuAdm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnMenuAdm.Dock = System.Windows.Forms.DockStyle.Top;
            btnMenuAdm.FlatAppearance.BorderSize = 0;
            btnMenuAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMenuAdm.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMenuAdm.ForeColor = System.Drawing.Color.White;
            btnMenuAdm.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            btnMenuAdm.IconColor = System.Drawing.Color.White;
            btnMenuAdm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuAdm.IconSize = 30;
            btnMenuAdm.Location = new System.Drawing.Point(0, 213);
            btnMenuAdm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnMenuAdm.Name = "btnMenuAdm";
            btnMenuAdm.Size = new System.Drawing.Size(229, 45);
            btnMenuAdm.TabIndex = 3;
            btnMenuAdm.Text = "Inicio";
            btnMenuAdm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnMenuAdm.UseVisualStyleBackColor = false;
            btnMenuAdm.Click += btnMenuAdm_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = System.Drawing.Color.Snow;
            panelLogo.BackgroundImage = Properties.Resources.logoJARDD;
            panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            panelLogo.Location = new System.Drawing.Point(0, 0);
            panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new System.Drawing.Size(229, 213);
            panelLogo.TabIndex = 0;
            // 
            // timerReloj
            // 
            timerReloj.Tick += timerReloj_Tick;
            // 
            // Menu_Admin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1010, 615);
            Controls.Add(panelContenedor);
            Controls.Add(panelBarradetitulo);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Menu_Admin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Menu_Admin";
            Activated += Menu_Admin_Activated;
            Load += Menu_Admin_Load;
            ResizeEnd += Menu_Admin_ResizeEnd;
            SizeChanged += Menu_Admin_SizeChanged;
            Paint += Menu_Admin_Paint;
            MouseDown += Menu_Admin_MouseDown;
            panelBarradetitulo.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            panelFormularioPadre.ResumeLayout(false);
            panelFormularioPadre.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnMenuAdm;
        private FontAwesome.Sharp.IconButton btnRegistroPago;
        private FontAwesome.Sharp.IconButton btnCalendario;
        private FontAwesome.Sharp.IconButton btnRegistro;
        private FontAwesome.Sharp.IconButton btnCalculadora;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Panel panelFormularioPadre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.Label lblSaludo;
        public System.Windows.Forms.ComboBox cboTemas;
        private FontAwesome.Sharp.IconButton btnFunciones;
    }
}