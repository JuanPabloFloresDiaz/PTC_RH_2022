namespace PTC_Oficial
{
    partial class RecuperarContraseñaPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseñaPF));
            this.panelBarradetitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnVerificar = new PTC_Oficial.BotonEsquinaRedonda();
            this.cboPregunta = new System.Windows.Forms.ComboBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarradetitulo
            // 
            this.panelBarradetitulo.BackColor = System.Drawing.Color.Gray;
            this.panelBarradetitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarradetitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarradetitulo.Name = "panelBarradetitulo";
            this.panelBarradetitulo.Size = new System.Drawing.Size(884, 35);
            this.panelBarradetitulo.TabIndex = 10;
            this.panelBarradetitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarradetitulo_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Turquoise;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Controls.Add(this.btnVerificar);
            this.panelContenedor.Controls.Add(this.cboPregunta);
            this.panelContenedor.Controls.Add(this.lblRespuesta);
            this.panelContenedor.Controls.Add(this.lblPregunta);
            this.panelContenedor.Controls.Add(this.textBox2);
            this.panelContenedor.Controls.Add(this.pcbLogo);
            this.panelContenedor.Controls.Add(this.textBox1);
            this.panelContenedor.Controls.Add(this.lblCorreo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(884, 426);
            this.panelContenedor.TabIndex = 11;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnVerificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVerificar.BorderRadius = 40;
            this.btnVerificar.BorderSize = 0;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerificar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnVerificar.Location = new System.Drawing.Point(136, 360);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(196, 54);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnVerificar.UseVisualStyleBackColor = false;
            // 
            // cboPregunta
            // 
            this.cboPregunta.BackColor = System.Drawing.Color.Snow;
            this.cboPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPregunta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboPregunta.ForeColor = System.Drawing.Color.Black;
            this.cboPregunta.FormattingEnabled = true;
            this.cboPregunta.Location = new System.Drawing.Point(136, 144);
            this.cboPregunta.Name = "cboPregunta";
            this.cboPregunta.Size = new System.Drawing.Size(413, 31);
            this.cboPregunta.TabIndex = 4;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.BackColor = System.Drawing.Color.Transparent;
            this.lblRespuesta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRespuesta.Location = new System.Drawing.Point(28, 232);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(115, 22);
            this.lblRespuesta.TabIndex = 2;
            this.lblRespuesta.Text = "Respuesta:";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPregunta.Location = new System.Drawing.Point(28, 145);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(102, 22);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "Pregunta:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 232);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 90);
            this.textBox2.TabIndex = 5;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.BackgroundImage = global::PTC_Oficial.Properties.Resources.logoJARDD;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLogo.Location = new System.Drawing.Point(555, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(326, 420);
            this.pcbLogo.TabIndex = 2;
            this.pcbLogo.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(227, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.Location = new System.Drawing.Point(28, 26);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(193, 22);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo Electronico:";
            // 
            // RecuperarContraseñaPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarradetitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecuperarContraseñaPF";
            this.Text = "RecuperarContraseñaPF";
            this.Activated += new System.EventHandler(this.RecuperarContraseñaPF_Activated);
            this.Load += new System.EventHandler(this.RecuperarContraseñaPF_Load);
            this.ResizeEnd += new System.EventHandler(this.RecuperarContraseñaPF_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.RecuperarContraseñaPF_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RecuperarContraseñaPF_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecuperarContraseñaPF_MouseDown);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarradetitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboPregunta;
        private BotonEsquinaRedonda btnVerificar;
    }
}