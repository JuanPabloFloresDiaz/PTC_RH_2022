namespace PTC_Oficial
{
    partial class Primer_Uso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Primer_Uso));
            this.panelBarradetitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnLimpiar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnRegistrarse = new PTC_Oficial.BotonEsquinaRedonda();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pcbTipoUsuario = new System.Windows.Forms.PictureBox();
            this.pcbGMAIL = new System.Windows.Forms.PictureBox();
            this.pcbContraseña = new System.Windows.Forms.PictureBox();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.errorPrimerUso = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBarradetitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTipoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGMAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrimerUso)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarradetitulo
            // 
            this.panelBarradetitulo.BackColor = System.Drawing.Color.Gray;
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
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::PTC_Oficial.Properties.Resources.BTNMinimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(731, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(47, 35);
            this.btnMinimizar.TabIndex = 7;
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
            this.btnRestaurar.Location = new System.Drawing.Point(784, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(47, 35);
            this.btnRestaurar.TabIndex = 6;
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
            this.btnMaximizar.Location = new System.Drawing.Point(784, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(47, 35);
            this.btnMaximizar.TabIndex = 5;
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
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Turquoise;
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Controls.Add(this.pcbLogo);
            this.panelContenedor.Controls.Add(this.lblSaludo);
            this.panelContenedor.Controls.Add(this.btnLimpiar);
            this.panelContenedor.Controls.Add(this.btnRegistrarse);
            this.panelContenedor.Controls.Add(this.lblTipoUsuario);
            this.panelContenedor.Controls.Add(this.lblEmail);
            this.panelContenedor.Controls.Add(this.lblContraseña);
            this.panelContenedor.Controls.Add(this.lblUsuario);
            this.panelContenedor.Controls.Add(this.pcbTipoUsuario);
            this.panelContenedor.Controls.Add(this.pcbGMAIL);
            this.panelContenedor.Controls.Add(this.pcbContraseña);
            this.panelContenedor.Controls.Add(this.pcbUsuario);
            this.panelContenedor.Controls.Add(this.cboTipoUsuario);
            this.panelContenedor.Controls.Add(this.txtCorreo);
            this.panelContenedor.Controls.Add(this.txtContraseña);
            this.panelContenedor.Controls.Add(this.txtNombre);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(884, 426);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PTC_Oficial.Properties.Resources.recurso___copia;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(535, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 417);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.BackgroundImage = global::PTC_Oficial.Properties.Resources.logoJARDD;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLogo.Location = new System.Drawing.Point(118, 6);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(395, 100);
            this.pcbLogo.TabIndex = 23;
            this.pcbLogo.TabStop = false;
            // 
            // lblSaludo
            // 
            this.lblSaludo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSaludo.Location = new System.Drawing.Point(120, 109);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(409, 66);
            this.lblSaludo.TabIndex = 22;
            this.lblSaludo.Text = "¡Bienvenido!\r\nIngrese un usuario administrador\r\npara poder empezar a utilizar su " +
    "programa.";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.Red;
            this.btnLimpiar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiar.BorderRadius = 40;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(322, 366);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(172, 51);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.Black;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarse.BackColor = System.Drawing.Color.Cyan;
            this.btnRegistrarse.BackgroundColor = System.Drawing.Color.Cyan;
            this.btnRegistrarse.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarse.BorderRadius = 40;
            this.btnRegistrarse.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarse.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarse.Location = new System.Drawing.Point(118, 366);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(172, 51);
            this.btnRegistrarse.TabIndex = 20;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.TextColor = System.Drawing.Color.Black;
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTipoUsuario.Location = new System.Drawing.Point(86, 321);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(136, 25);
            this.lblTipoUsuario.TabIndex = 19;
            this.lblTipoUsuario.Text = "Tipo de usuario";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEmail.Location = new System.Drawing.Point(157, 274);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 25);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "E-MAIL";
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblContraseña.Location = new System.Drawing.Point(118, 227);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(104, 25);
            this.lblContraseña.TabIndex = 17;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUsuario.Location = new System.Drawing.Point(149, 180);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 25);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "Usuario";
            // 
            // pcbTipoUsuario
            // 
            this.pcbTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pcbTipoUsuario.BackgroundImage = global::PTC_Oficial.Properties.Resources.TIPOUSUARIO_removebg_preview;
            this.pcbTipoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTipoUsuario.Location = new System.Drawing.Point(228, 319);
            this.pcbTipoUsuario.Name = "pcbTipoUsuario";
            this.pcbTipoUsuario.Size = new System.Drawing.Size(30, 29);
            this.pcbTipoUsuario.TabIndex = 15;
            this.pcbTipoUsuario.TabStop = false;
            // 
            // pcbGMAIL
            // 
            this.pcbGMAIL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbGMAIL.BackColor = System.Drawing.Color.Transparent;
            this.pcbGMAIL.BackgroundImage = global::PTC_Oficial.Properties.Resources.GMAILIMG_removebg_preview;
            this.pcbGMAIL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbGMAIL.Location = new System.Drawing.Point(228, 272);
            this.pcbGMAIL.Name = "pcbGMAIL";
            this.pcbGMAIL.Size = new System.Drawing.Size(30, 29);
            this.pcbGMAIL.TabIndex = 14;
            this.pcbGMAIL.TabStop = false;
            // 
            // pcbContraseña
            // 
            this.pcbContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbContraseña.BackColor = System.Drawing.Color.Transparent;
            this.pcbContraseña.BackgroundImage = global::PTC_Oficial.Properties.Resources.contraseña_icon;
            this.pcbContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbContraseña.Location = new System.Drawing.Point(228, 225);
            this.pcbContraseña.Name = "pcbContraseña";
            this.pcbContraseña.Size = new System.Drawing.Size(30, 29);
            this.pcbContraseña.TabIndex = 13;
            this.pcbContraseña.TabStop = false;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pcbUsuario.BackgroundImage = global::PTC_Oficial.Properties.Resources.usuario_icon;
            this.pcbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbUsuario.Location = new System.Drawing.Point(228, 178);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(30, 29);
            this.pcbUsuario.TabIndex = 12;
            this.pcbUsuario.TabStop = false;
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipoUsuario.BackColor = System.Drawing.Color.Teal;
            this.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoUsuario.Enabled = false;
            this.cboTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(264, 319);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(249, 28);
            this.cboTipoUsuario.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.BackColor = System.Drawing.Color.Teal;
            this.txtCorreo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(264, 273);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(249, 26);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.BackColor = System.Drawing.Color.Teal;
            this.txtContraseña.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(264, 227);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(249, 26);
            this.txtContraseña.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.Color.Teal;
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(264, 181);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // errorPrimerUso
            // 
            this.errorPrimerUso.ContainerControl = this;
            // 
            // Primer_Uso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarradetitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Primer_Uso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primer_Uso";
            this.Activated += new System.EventHandler(this.Primer_Uso_Activated);
            this.Load += new System.EventHandler(this.Primer_Uso_Load);
            this.ResizeEnd += new System.EventHandler(this.Primer_Uso_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Primer_Uso_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Primer_Uso_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Primer_Uso_MouseDown);
            this.panelBarradetitulo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTipoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGMAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrimerUso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarradetitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pcbTipoUsuario;
        private System.Windows.Forms.PictureBox pcbGMAIL;
        private System.Windows.Forms.PictureBox pcbContraseña;
        private System.Windows.Forms.PictureBox pcbUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private BotonEsquinaRedonda btnLimpiar;
        private BotonEsquinaRedonda btnRegistrarse;
        private System.Windows.Forms.ErrorProvider errorPrimerUso;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}