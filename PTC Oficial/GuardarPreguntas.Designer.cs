namespace PTC_Oficial
{
    partial class GuardarPreguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuardarPreguntas));
            this.panelBarradetitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblExplicación = new System.Windows.Forms.Label();
            this.btnResponder = new PTC_Oficial.BotonEsquinaRedonda();
            this.cboPreguntas = new System.Windows.Forms.ComboBox();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.txtRespuestas = new System.Windows.Forms.TextBox();
            this.panelBarradetitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarradetitulo
            // 
            this.panelBarradetitulo.BackColor = System.Drawing.Color.DimGray;
            this.panelBarradetitulo.Controls.Add(this.btnCerrar);
            this.panelBarradetitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarradetitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarradetitulo.Name = "panelBarradetitulo";
            this.panelBarradetitulo.Size = new System.Drawing.Size(609, 35);
            this.panelBarradetitulo.TabIndex = 0;
            this.panelBarradetitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarradetitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DimGray;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.Red;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 32;
            this.btnCerrar.Location = new System.Drawing.Point(579, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Silver;
            this.panelContenedor.BackgroundImage = global::PTC_Oficial.Properties.Resources.recurso___copia;
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Controls.Add(this.lblExplicación);
            this.panelContenedor.Controls.Add(this.btnResponder);
            this.panelContenedor.Controls.Add(this.cboPreguntas);
            this.panelContenedor.Controls.Add(this.cboUsuarios);
            this.panelContenedor.Controls.Add(this.txtRespuestas);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(609, 351);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // lblExplicación
            // 
            this.lblExplicación.AutoSize = true;
            this.lblExplicación.BackColor = System.Drawing.Color.Transparent;
            this.lblExplicación.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExplicación.ForeColor = System.Drawing.Color.Snow;
            this.lblExplicación.Location = new System.Drawing.Point(342, 23);
            this.lblExplicación.Name = "lblExplicación";
            this.lblExplicación.Size = new System.Drawing.Size(264, 266);
            this.lblExplicación.TabIndex = 5;
            this.lblExplicación.Text = resources.GetString("lblExplicación.Text");
            this.lblExplicación.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.Transparent;
            this.btnResponder.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnResponder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResponder.BorderRadius = 40;
            this.btnResponder.BorderSize = 0;
            this.btnResponder.FlatAppearance.BorderSize = 0;
            this.btnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResponder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnResponder.Location = new System.Drawing.Point(12, 263);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(298, 40);
            this.btnResponder.TabIndex = 4;
            this.btnResponder.Text = "Responder";
            this.btnResponder.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnResponder.UseVisualStyleBackColor = false;
            // 
            // cboPreguntas
            // 
            this.cboPreguntas.BackColor = System.Drawing.Color.DarkBlue;
            this.cboPreguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPreguntas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboPreguntas.ForeColor = System.Drawing.Color.White;
            this.cboPreguntas.FormattingEnabled = true;
            this.cboPreguntas.Location = new System.Drawing.Point(12, 23);
            this.cboPreguntas.Name = "cboPreguntas";
            this.cboPreguntas.Size = new System.Drawing.Size(298, 27);
            this.cboPreguntas.TabIndex = 3;
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.BackColor = System.Drawing.Color.DarkBlue;
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboUsuarios.ForeColor = System.Drawing.Color.White;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(12, 88);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(298, 27);
            this.cboUsuarios.TabIndex = 2;
            // 
            // txtRespuestas
            // 
            this.txtRespuestas.BackColor = System.Drawing.Color.DarkBlue;
            this.txtRespuestas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuestas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRespuestas.ForeColor = System.Drawing.Color.White;
            this.txtRespuestas.Location = new System.Drawing.Point(12, 152);
            this.txtRespuestas.Multiline = true;
            this.txtRespuestas.Name = "txtRespuestas";
            this.txtRespuestas.Size = new System.Drawing.Size(298, 78);
            this.txtRespuestas.TabIndex = 1;
            // 
            // GuardarPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 386);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarradetitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuardarPreguntas";
            this.Opacity = 0.9D;
            this.Text = "GuardarPreguntas";
            this.Activated += new System.EventHandler(this.GuardarPreguntas_Activated);
            this.Load += new System.EventHandler(this.GuardarPreguntas_Load);
            this.ResizeEnd += new System.EventHandler(this.GuardarPreguntas_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.GuardarPreguntas_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GuardarPreguntas_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GuardarPreguntas_MouseDown);
            this.panelBarradetitulo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarradetitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TextBox txtRespuestas;
        private System.Windows.Forms.ComboBox cboPreguntas;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private BotonEsquinaRedonda btnResponder;
        private System.Windows.Forms.Label lblExplicación;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}