namespace PTC_Oficial
{
    partial class InicioRecepcionista
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
            this.btnReporte = new PTC_Oficial.BotonEsquinaRedonda();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.errorReportes = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelObjetos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorReportes)).BeginInit();
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
            this.panelObjetos.Controls.Add(this.btnReporte);
            this.panelObjetos.Controls.Add(this.lblTelefono);
            this.panelObjetos.Controls.Add(this.txtTelefono);
            this.panelObjetos.Controls.Add(this.lblNombre);
            this.panelObjetos.Controls.Add(this.txtNombre);
            this.panelObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjetos.Location = new System.Drawing.Point(0, 0);
            this.panelObjetos.Name = "panelObjetos";
            this.panelObjetos.Size = new System.Drawing.Size(684, 426);
            this.panelObjetos.TabIndex = 0;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReporte.BackColor = System.Drawing.Color.Snow;
            this.btnReporte.BackgroundColor = System.Drawing.Color.Snow;
            this.btnReporte.BorderColor = System.Drawing.Color.Lime;
            this.btnReporte.BorderRadius = 40;
            this.btnReporte.BorderSize = 0;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReporte.ForeColor = System.Drawing.Color.Gold;
            this.btnReporte.Location = new System.Drawing.Point(257, 190);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(198, 59);
            this.btnReporte.TabIndex = 48;
            this.btnReporte.Text = "Generar reporte de llegadas tarde";
            this.btnReporte.TextColor = System.Drawing.Color.Gold;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(105, 131);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(119, 29);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.Location = new System.Drawing.Point(230, 130);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(442, 30);
            this.txtTelefono.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(114, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 29);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(230, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(442, 30);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // errorReportes
            // 
            this.errorReportes.ContainerControl = this;
            // 
            // InicioRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioRecepcionista";
            this.Text = "InicioRecepcionista";
            this.panelContenedor.ResumeLayout(false);
            this.panelObjetos.ResumeLayout(false);
            this.panelObjetos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelObjetos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private BotonEsquinaRedonda btnReporte;
        private System.Windows.Forms.ErrorProvider errorReportes;
    }
}