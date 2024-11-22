namespace PTC_Oficial
{
    partial class MenuRecepcionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRecepcionista));
            this.panelBarradetitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.cboTemas = new System.Windows.Forms.ComboBox();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularioPadre = new System.Windows.Forms.Panel();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLlegadasTarde = new FontAwesome.Sharp.IconButton();
            this.btnControlHorario = new FontAwesome.Sharp.IconButton();
            this.btnMenuRec = new FontAwesome.Sharp.IconButton();
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
            this.panelBarradetitulo.Controls.Add(this.btnMaximizar);
            this.panelBarradetitulo.Controls.Add(this.btnCerrar);
            this.panelBarradetitulo.Controls.Add(this.btnRestaurar);
            this.panelBarradetitulo.Controls.Add(this.btnMinimizar);
            this.panelBarradetitulo.Controls.Add(this.cboTemas);
            this.panelBarradetitulo.Controls.Add(this.btnCerrarSesion);
            this.panelBarradetitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarradetitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarradetitulo.Name = "panelBarradetitulo";
            this.panelBarradetitulo.Size = new System.Drawing.Size(884, 35);
            this.panelBarradetitulo.TabIndex = 0;
            this.panelBarradetitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarradetitulo_MouseDown);
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
            this.btnMaximizar.TabIndex = 18;
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
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = global::PTC_Oficial.Properties.Resources.btnRestaurar;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(784, -1);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(47, 35);
            this.btnRestaurar.TabIndex = 16;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
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
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.cboTemas.Location = new System.Drawing.Point(604, 3);
            this.cboTemas.Name = "cboTemas";
            this.cboTemas.Size = new System.Drawing.Size(121, 31);
            this.cboTemas.TabIndex = 14;
            this.cboTemas.Visible = false;
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(157, 29);
            this.btnCerrarSesion.TabIndex = 13;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
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
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelFormularioPadre
            // 
            this.panelFormularioPadre.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelFormularioPadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelFormularioPadre.Controls.Add(this.lblSaludo);
            this.panelFormularioPadre.Controls.Add(this.lblFecha);
            this.panelFormularioPadre.Controls.Add(this.lblHora);
            this.panelFormularioPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularioPadre.Location = new System.Drawing.Point(200, 0);
            this.panelFormularioPadre.Name = "panelFormularioPadre";
            this.panelFormularioPadre.Size = new System.Drawing.Size(684, 426);
            this.panelFormularioPadre.TabIndex = 4;
            // 
            // lblSaludo
            // 
            this.lblSaludo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.Location = new System.Drawing.Point(85, 230);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(318, 29);
            this.lblSaludo.TabIndex = 17;
            this.lblSaludo.Text = "¡Bienvenido recepcionista!";
            this.lblSaludo.Click += new System.EventHandler(this.lblSaludo_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFecha.Location = new System.Drawing.Point(6, 153);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(116, 41);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.Green;
            this.lblHora.Location = new System.Drawing.Point(6, 27);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(97, 41);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "Hora";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelMenu.Controls.Add(this.btnLlegadasTarde);
            this.panelMenu.Controls.Add(this.btnControlHorario);
            this.panelMenu.Controls.Add(this.btnMenuRec);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 426);
            this.panelMenu.TabIndex = 2;
            // 
            // btnLlegadasTarde
            // 
            this.btnLlegadasTarde.BackColor = System.Drawing.Color.Transparent;
            this.btnLlegadasTarde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLlegadasTarde.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLlegadasTarde.FlatAppearance.BorderSize = 0;
            this.btnLlegadasTarde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlegadasTarde.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLlegadasTarde.ForeColor = System.Drawing.Color.White;
            this.btnLlegadasTarde.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus;
            this.btnLlegadasTarde.IconColor = System.Drawing.Color.White;
            this.btnLlegadasTarde.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLlegadasTarde.IconSize = 30;
            this.btnLlegadasTarde.Location = new System.Drawing.Point(0, 228);
            this.btnLlegadasTarde.Name = "btnLlegadasTarde";
            this.btnLlegadasTarde.Size = new System.Drawing.Size(200, 34);
            this.btnLlegadasTarde.TabIndex = 9;
            this.btnLlegadasTarde.Text = "Llegadas tarde";
            this.btnLlegadasTarde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLlegadasTarde.UseVisualStyleBackColor = false;
            this.btnLlegadasTarde.Click += new System.EventHandler(this.btnLlegadasTarde_Click);
            // 
            // btnControlHorario
            // 
            this.btnControlHorario.BackColor = System.Drawing.Color.Transparent;
            this.btnControlHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnControlHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControlHorario.FlatAppearance.BorderSize = 0;
            this.btnControlHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlHorario.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnControlHorario.ForeColor = System.Drawing.Color.White;
            this.btnControlHorario.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnControlHorario.IconColor = System.Drawing.Color.White;
            this.btnControlHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnControlHorario.IconSize = 30;
            this.btnControlHorario.Location = new System.Drawing.Point(0, 194);
            this.btnControlHorario.Name = "btnControlHorario";
            this.btnControlHorario.Size = new System.Drawing.Size(200, 34);
            this.btnControlHorario.TabIndex = 8;
            this.btnControlHorario.Text = "Control de Horario";
            this.btnControlHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnControlHorario.UseVisualStyleBackColor = false;
            this.btnControlHorario.Click += new System.EventHandler(this.btnControlHorario_Click);
            // 
            // btnMenuRec
            // 
            this.btnMenuRec.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuRec.FlatAppearance.BorderSize = 0;
            this.btnMenuRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRec.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuRec.ForeColor = System.Drawing.Color.White;
            this.btnMenuRec.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnMenuRec.IconColor = System.Drawing.Color.White;
            this.btnMenuRec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuRec.IconSize = 30;
            this.btnMenuRec.Location = new System.Drawing.Point(0, 160);
            this.btnMenuRec.Name = "btnMenuRec";
            this.btnMenuRec.Size = new System.Drawing.Size(200, 34);
            this.btnMenuRec.TabIndex = 2;
            this.btnMenuRec.Text = "Inicio";
            this.btnMenuRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuRec.UseVisualStyleBackColor = false;
            this.btnMenuRec.Click += new System.EventHandler(this.btnMenuRec_Click);
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
            // MenuRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarradetitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuRecepcionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuRecepcionista";
            this.Activated += new System.EventHandler(this.MenuRecepcionista_Activated);
            this.Load += new System.EventHandler(this.MenuRecepcionista_Load);
            this.ResizeEnd += new System.EventHandler(this.MenuRecepcionista_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.MenuRecepcionista_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuRecepcionista_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuRecepcionista_MouseDown);
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
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.ComboBox cboTemas;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnMenuRec;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelFormularioPadre;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private FontAwesome.Sharp.IconButton btnLlegadasTarde;
        private FontAwesome.Sharp.IconButton btnControlHorario;
        private System.Windows.Forms.Timer timerReloj;
    }
}