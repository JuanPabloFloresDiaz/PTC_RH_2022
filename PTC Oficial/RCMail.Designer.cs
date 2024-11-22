namespace PTC_Oficial
{
    partial class RCMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCMail));
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnEnviar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTexto.Location = new System.Drawing.Point(12, 19);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(226, 72);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Ingrese su correo \r\nelectronico o su \r\nnombre de usuario";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(12, 98);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(358, 32);
            this.txtCorreo.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEnviar.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.btnEnviar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnviar.BorderRadius = 40;
            this.btnEnviar.BorderSize = 0;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEnviar.Location = new System.Drawing.Point(12, 136);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(150, 40);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextColor = System.Drawing.Color.MidnightBlue;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnSalir.IconColor = System.Drawing.Color.Red;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(631, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // RCMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RCMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtCorreo;
        private BotonEsquinaRedonda btnEnviar;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}