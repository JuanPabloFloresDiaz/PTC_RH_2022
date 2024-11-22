namespace PTC_Oficial
{
    partial class TipoRC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoRC));
            this.panelBarradetitulo = new System.Windows.Forms.Panel();
            this.btnLogin = new PTC_Oficial.BotonEsquinaRedonda();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.btnGmail = new FontAwesome.Sharp.IconButton();
            this.btnPreguntasfrecuentes = new FontAwesome.Sharp.IconButton();
            this.panelBarradetitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarradetitulo
            // 
            this.panelBarradetitulo.BackColor = System.Drawing.Color.DimGray;
            this.panelBarradetitulo.Controls.Add(this.btnLogin);
            this.panelBarradetitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarradetitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarradetitulo.Name = "panelBarradetitulo";
            this.panelBarradetitulo.Size = new System.Drawing.Size(513, 35);
            this.panelBarradetitulo.TabIndex = 5;
            this.panelBarradetitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarradetitulo_MouseDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 29;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(0, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 29);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Volver al login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Turquoise;
            this.panelContenedor.Controls.Add(this.panelDashboard);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(513, 301);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelDashboard
            // 
            this.panelDashboard.ColumnCount = 2;
            this.panelDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard.Controls.Add(this.btnGmail, 0, 0);
            this.panelDashboard.Controls.Add(this.btnPreguntasfrecuentes, 1, 0);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.RowCount = 1;
            this.panelDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDashboard.Size = new System.Drawing.Size(513, 301);
            this.panelDashboard.TabIndex = 0;
            // 
            // btnGmail
            // 
            this.btnGmail.BackColor = System.Drawing.Color.DarkRed;
            this.btnGmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGmail.FlatAppearance.BorderSize = 0;
            this.btnGmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGmail.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGmail.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnGmail.IconColor = System.Drawing.Color.White;
            this.btnGmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGmail.Location = new System.Drawing.Point(3, 3);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(250, 295);
            this.btnGmail.TabIndex = 1;
            this.btnGmail.Text = "Correo Electronico";
            this.btnGmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGmail.UseVisualStyleBackColor = false;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // btnPreguntasfrecuentes
            // 
            this.btnPreguntasfrecuentes.BackColor = System.Drawing.Color.DarkBlue;
            this.btnPreguntasfrecuentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreguntasfrecuentes.FlatAppearance.BorderSize = 0;
            this.btnPreguntasfrecuentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPreguntasfrecuentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnPreguntasfrecuentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreguntasfrecuentes.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPreguntasfrecuentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPreguntasfrecuentes.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnPreguntasfrecuentes.IconColor = System.Drawing.Color.White;
            this.btnPreguntasfrecuentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreguntasfrecuentes.Location = new System.Drawing.Point(259, 3);
            this.btnPreguntasfrecuentes.Name = "btnPreguntasfrecuentes";
            this.btnPreguntasfrecuentes.Size = new System.Drawing.Size(251, 295);
            this.btnPreguntasfrecuentes.TabIndex = 2;
            this.btnPreguntasfrecuentes.Text = "Preguntas de seguridad";
            this.btnPreguntasfrecuentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreguntasfrecuentes.UseVisualStyleBackColor = false;
            this.btnPreguntasfrecuentes.Click += new System.EventHandler(this.btnPreguntasfrecuentes_Click);
            // 
            // TipoRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 336);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarradetitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TipoRC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoRC";
            this.Activated += new System.EventHandler(this.TipoRC_Activated);
            this.ResizeEnd += new System.EventHandler(this.TipoRC_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.TipoRC_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TipoRC_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TipoRC_MouseDown);
            this.panelBarradetitulo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarradetitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private BotonEsquinaRedonda btnLogin;
        private System.Windows.Forms.TableLayoutPanel panelDashboard;
        private FontAwesome.Sharp.IconButton btnGmail;
        private FontAwesome.Sharp.IconButton btnPreguntasfrecuentes;
    }
}