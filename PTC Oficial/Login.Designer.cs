namespace PTC_Oficial
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelBarradetitulo = new System.Windows.Forms.Panel();
            this.btnMIN = new System.Windows.Forms.Button();
            this.btnRES = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblRecuperarcontraseña = new System.Windows.Forms.LinkLabel();
            this.pcbContraseña = new System.Windows.Forms.PictureBox();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new PTC_Oficial.BotonEsquinaRedonda();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.errorLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBarradetitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarradetitulo
            // 
            this.panelBarradetitulo.BackColor = System.Drawing.Color.Gray;
            this.panelBarradetitulo.Controls.Add(this.btnMIN);
            this.panelBarradetitulo.Controls.Add(this.btnRES);
            this.panelBarradetitulo.Controls.Add(this.btnMax);
            this.panelBarradetitulo.Controls.Add(this.btnSalir);
            this.panelBarradetitulo.Controls.Add(this.btnMinimizar);
            this.panelBarradetitulo.Controls.Add(this.btnRestaurar);
            this.panelBarradetitulo.Controls.Add(this.btnMaximizar);
            this.panelBarradetitulo.Controls.Add(this.btnCerrar);
            this.panelBarradetitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarradetitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarradetitulo.Name = "panelBarradetitulo";
            this.panelBarradetitulo.Size = new System.Drawing.Size(884, 35);
            this.panelBarradetitulo.TabIndex = 2;
            this.panelBarradetitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarradetitulo_MouseDown);
            // 
            // btnMIN
            // 
            this.btnMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMIN.BackgroundImage = global::PTC_Oficial.Properties.Resources.BTNMinimizar;
            this.btnMIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMIN.FlatAppearance.BorderSize = 0;
            this.btnMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMIN.Location = new System.Drawing.Point(728, 0);
            this.btnMIN.Name = "btnMIN";
            this.btnMIN.Size = new System.Drawing.Size(47, 35);
            this.btnMIN.TabIndex = 0;
            this.btnMIN.UseVisualStyleBackColor = true;
            this.btnMIN.Click += new System.EventHandler(this.btnMIN_Click);
            // 
            // btnRES
            // 
            this.btnRES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRES.BackgroundImage = global::PTC_Oficial.Properties.Resources.btnRestaurar;
            this.btnRES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRES.FlatAppearance.BorderSize = 0;
            this.btnRES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRES.Location = new System.Drawing.Point(781, -3);
            this.btnRES.Name = "btnRES";
            this.btnRES.Size = new System.Drawing.Size(47, 35);
            this.btnRES.TabIndex = 1;
            this.btnRES.UseVisualStyleBackColor = true;
            this.btnRES.Click += new System.EventHandler(this.btnRES_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackgroundImage = global::PTC_Oficial.Properties.Resources.btnMaximizar;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(781, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(47, 35);
            this.btnMax.TabIndex = 2;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackgroundImage = global::PTC_Oficial.Properties.Resources.cerrar;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(834, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::PTC_Oficial.Properties.Resources.BTNMinimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(1231, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(47, 35);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = global::PTC_Oficial.Properties.Resources.btnRestaurar;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(1284, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(47, 35);
            this.btnRestaurar.TabIndex = 6;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::PTC_Oficial.Properties.Resources.btnMaximizar;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(1337, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(47, 35);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::PTC_Oficial.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(1390, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 35);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Turquoise;
            this.panelContenedor.Controls.Add(this.lblRecuperarcontraseña);
            this.panelContenedor.Controls.Add(this.pcbContraseña);
            this.panelContenedor.Controls.Add(this.pcbUsuario);
            this.panelContenedor.Controls.Add(this.btnIniciarSesion);
            this.panelContenedor.Controls.Add(this.txtContraseña);
            this.panelContenedor.Controls.Add(this.pcbLogo);
            this.panelContenedor.Controls.Add(this.txtUsuario);
            this.panelContenedor.Controls.Add(this.lblBienvenido);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(884, 426);
            this.panelContenedor.TabIndex = 3;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // lblRecuperarcontraseña
            // 
            this.lblRecuperarcontraseña.ActiveLinkColor = System.Drawing.Color.Purple;
            this.lblRecuperarcontraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecuperarcontraseña.AutoSize = true;
            this.lblRecuperarcontraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblRecuperarcontraseña.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecuperarcontraseña.ForeColor = System.Drawing.Color.Black;
            this.lblRecuperarcontraseña.LinkColor = System.Drawing.Color.Blue;
            this.lblRecuperarcontraseña.Location = new System.Drawing.Point(272, 358);
            this.lblRecuperarcontraseña.Name = "lblRecuperarcontraseña";
            this.lblRecuperarcontraseña.Size = new System.Drawing.Size(324, 29);
            this.lblRecuperarcontraseña.TabIndex = 12;
            this.lblRecuperarcontraseña.TabStop = true;
            this.lblRecuperarcontraseña.Text = "¿Desea recuperar la contraseña?";
            this.lblRecuperarcontraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRecuperarcontraseña_LinkClicked);
            // 
            // pcbContraseña
            // 
            this.pcbContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbContraseña.BackgroundImage = global::PTC_Oficial.Properties.Resources.contraseña_icon;
            this.pcbContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbContraseña.Location = new System.Drawing.Point(258, 269);
            this.pcbContraseña.Name = "pcbContraseña";
            this.pcbContraseña.Size = new System.Drawing.Size(30, 29);
            this.pcbContraseña.TabIndex = 11;
            this.pcbContraseña.TabStop = false;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbUsuario.BackgroundImage = global::PTC_Oficial.Properties.Resources.usuario_icon;
            this.pcbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbUsuario.Location = new System.Drawing.Point(258, 209);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(30, 29);
            this.pcbUsuario.TabIndex = 10;
            this.pcbUsuario.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Cyan;
            this.btnIniciarSesion.BackgroundColor = System.Drawing.Color.Cyan;
            this.btnIniciarSesion.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnIniciarSesion.BorderRadius = 40;
            this.btnIniciarSesion.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.Location = new System.Drawing.Point(355, 304);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(187, 51);
            this.btnIniciarSesion.TabIndex = 9;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.TextColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.BackColor = System.Drawing.Color.Turquoise;
            this.txtContraseña.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.Location = new System.Drawing.Point(294, 269);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(302, 29);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbLogo.BackgroundImage = global::PTC_Oficial.Properties.Resources.logoJARDD;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLogo.Location = new System.Drawing.Point(294, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(302, 130);
            this.pcbLogo.TabIndex = 7;
            this.pcbLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BackColor = System.Drawing.Color.Turquoise;
            this.txtUsuario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(294, 209);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(302, 29);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.ForeColor = System.Drawing.Color.Black;
            this.lblBienvenido.Location = new System.Drawing.Point(355, 136);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(187, 70);
            this.lblBienvenido.TabIndex = 5;
            this.lblBienvenido.Text = "¡Bienvenido!\r\nInicie sesión\r\n";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLogin
            // 
            this.errorLogin.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarradetitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResizeEnd += new System.EventHandler(this.Login_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panelBarradetitulo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarradetitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnMIN;
        private System.Windows.Forms.Button btnRES;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox pcbLogo;
        private BotonEsquinaRedonda btnIniciarSesion;
        private System.Windows.Forms.ErrorProvider errorLogin;
        private System.Windows.Forms.PictureBox pcbUsuario;
        private System.Windows.Forms.PictureBox pcbContraseña;
        private System.Windows.Forms.LinkLabel lblRecuperarcontraseña;
    }
}