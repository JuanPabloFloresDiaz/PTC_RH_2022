namespace PTC_Oficial
{
    partial class InicioAdminOficial
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
            this.panelCons = new System.Windows.Forms.Panel();
            this.panelObjetos = new System.Windows.Forms.Panel();
            this.PanelDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.dtpAdministracion = new System.Windows.Forms.DateTimePicker();
            this.lblFechanacimiento = new System.Windows.Forms.Label();
            this.PanelDivisor2 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelDashboard1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBaja = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnCumpli = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnGestion = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnReconocimientos = new PTC_Oficial.BotonEsquinaRedonda();
            this.PanelDashboard2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnActaadministrativa = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnNom = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnContratosEmpleados = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnSancion = new PTC_Oficial.BotonEsquinaRedonda();
            this.panelCons.SuspendLayout();
            this.panelObjetos.SuspendLayout();
            this.PanelDivisor.SuspendLayout();
            this.panelCampos.SuspendLayout();
            this.PanelDivisor2.SuspendLayout();
            this.PanelDashboard1.SuspendLayout();
            this.PanelDashboard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCons
            // 
            this.panelCons.Controls.Add(this.panelObjetos);
            this.panelCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCons.Location = new System.Drawing.Point(0, 0);
            this.panelCons.Name = "panelCons";
            this.panelCons.Size = new System.Drawing.Size(684, 426);
            this.panelCons.TabIndex = 0;
            // 
            // panelObjetos
            // 
            this.panelObjetos.Controls.Add(this.PanelDivisor);
            this.panelObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjetos.Location = new System.Drawing.Point(0, 0);
            this.panelObjetos.Name = "panelObjetos";
            this.panelObjetos.Size = new System.Drawing.Size(684, 426);
            this.panelObjetos.TabIndex = 0;
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 1;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.panelCampos, 0, 0);
            this.PanelDivisor.Controls.Add(this.PanelDivisor2, 0, 1);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 2;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 0;
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.dtpAdministracion);
            this.panelCampos.Controls.Add(this.lblFechanacimiento);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(3, 3);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(678, 207);
            this.panelCampos.TabIndex = 15;
            this.panelCampos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCampos_Paint);
            // 
            // dtpAdministracion
            // 
            this.dtpAdministracion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpAdministracion.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dtpAdministracion.Enabled = false;
            this.dtpAdministracion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpAdministracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdministracion.Location = new System.Drawing.Point(342, 9);
            this.dtpAdministracion.Name = "dtpAdministracion";
            this.dtpAdministracion.Size = new System.Drawing.Size(206, 32);
            this.dtpAdministracion.TabIndex = 106;
            // 
            // lblFechanacimiento
            // 
            this.lblFechanacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechanacimiento.AutoSize = true;
            this.lblFechanacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechanacimiento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechanacimiento.ForeColor = System.Drawing.Color.Black;
            this.lblFechanacimiento.Location = new System.Drawing.Point(115, 17);
            this.lblFechanacimiento.Name = "lblFechanacimiento";
            this.lblFechanacimiento.Size = new System.Drawing.Size(221, 22);
            this.lblFechanacimiento.TabIndex = 103;
            this.lblFechanacimiento.Text = "Fecha de administración:";
            // 
            // PanelDivisor2
            // 
            this.PanelDivisor2.ColumnCount = 2;
            this.PanelDivisor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor2.Controls.Add(this.PanelDashboard1, 0, 0);
            this.PanelDivisor2.Controls.Add(this.PanelDashboard2, 1, 0);
            this.PanelDivisor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor2.Location = new System.Drawing.Point(3, 216);
            this.PanelDivisor2.Name = "PanelDivisor2";
            this.PanelDivisor2.RowCount = 1;
            this.PanelDivisor2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor2.Size = new System.Drawing.Size(678, 207);
            this.PanelDivisor2.TabIndex = 1;
            // 
            // PanelDashboard1
            // 
            this.PanelDashboard1.BackColor = System.Drawing.Color.Transparent;
            this.PanelDashboard1.ColumnCount = 2;
            this.PanelDashboard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDashboard1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDashboard1.Controls.Add(this.btnBaja, 0, 1);
            this.PanelDashboard1.Controls.Add(this.btnCumpli, 0, 0);
            this.PanelDashboard1.Controls.Add(this.btnGestion, 1, 0);
            this.PanelDashboard1.Controls.Add(this.btnReconocimientos, 1, 1);
            this.PanelDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDashboard1.Location = new System.Drawing.Point(3, 3);
            this.PanelDashboard1.Name = "PanelDashboard1";
            this.PanelDashboard1.RowCount = 2;
            this.PanelDashboard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDashboard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDashboard1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelDashboard1.Size = new System.Drawing.Size(333, 201);
            this.PanelDashboard1.TabIndex = 20;
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBaja.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.btnBaja.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBaja.BorderRadius = 40;
            this.btnBaja.BorderSize = 0;
            this.btnBaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaja.ForeColor = System.Drawing.Color.Black;
            this.btnBaja.Location = new System.Drawing.Point(3, 103);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(160, 95);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Bajas laborales";
            this.btnBaja.TextColor = System.Drawing.Color.Black;
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnCumpli
            // 
            this.btnCumpli.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCumpli.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.btnCumpli.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCumpli.BorderRadius = 40;
            this.btnCumpli.BorderSize = 0;
            this.btnCumpli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCumpli.FlatAppearance.BorderSize = 0;
            this.btnCumpli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCumpli.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCumpli.ForeColor = System.Drawing.Color.Black;
            this.btnCumpli.Location = new System.Drawing.Point(3, 3);
            this.btnCumpli.Name = "btnCumpli";
            this.btnCumpli.Size = new System.Drawing.Size(160, 94);
            this.btnCumpli.TabIndex = 0;
            this.btnCumpli.Text = "Cumplimiento empleado";
            this.btnCumpli.TextColor = System.Drawing.Color.Black;
            this.btnCumpli.UseVisualStyleBackColor = false;
            this.btnCumpli.Click += new System.EventHandler(this.btnCumpli_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGestion.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.btnGestion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGestion.BorderRadius = 40;
            this.btnGestion.BorderSize = 0;
            this.btnGestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGestion.ForeColor = System.Drawing.Color.Black;
            this.btnGestion.Location = new System.Drawing.Point(169, 3);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(161, 94);
            this.btnGestion.TabIndex = 1;
            this.btnGestion.Text = "Gestion de vacaciones";
            this.btnGestion.TextColor = System.Drawing.Color.Black;
            this.btnGestion.UseVisualStyleBackColor = false;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnReconocimientos
            // 
            this.btnReconocimientos.BackColor = System.Drawing.Color.Aquamarine;
            this.btnReconocimientos.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.btnReconocimientos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReconocimientos.BorderRadius = 40;
            this.btnReconocimientos.BorderSize = 0;
            this.btnReconocimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReconocimientos.FlatAppearance.BorderSize = 0;
            this.btnReconocimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReconocimientos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReconocimientos.ForeColor = System.Drawing.Color.Black;
            this.btnReconocimientos.Location = new System.Drawing.Point(169, 103);
            this.btnReconocimientos.Name = "btnReconocimientos";
            this.btnReconocimientos.Size = new System.Drawing.Size(161, 95);
            this.btnReconocimientos.TabIndex = 3;
            this.btnReconocimientos.Text = "Historial de reconocimientos";
            this.btnReconocimientos.TextColor = System.Drawing.Color.Black;
            this.btnReconocimientos.UseVisualStyleBackColor = false;
            this.btnReconocimientos.Click += new System.EventHandler(this.btnReconocimientos_Click);
            // 
            // PanelDashboard2
            // 
            this.PanelDashboard2.BackColor = System.Drawing.Color.Transparent;
            this.PanelDashboard2.ColumnCount = 2;
            this.PanelDashboard2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDashboard2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDashboard2.Controls.Add(this.btnActaadministrativa, 0, 1);
            this.PanelDashboard2.Controls.Add(this.btnNom, 0, 1);
            this.PanelDashboard2.Controls.Add(this.btnContratosEmpleados, 0, 0);
            this.PanelDashboard2.Controls.Add(this.btnSancion, 1, 0);
            this.PanelDashboard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDashboard2.Location = new System.Drawing.Point(342, 3);
            this.PanelDashboard2.Name = "PanelDashboard2";
            this.PanelDashboard2.RowCount = 2;
            this.PanelDashboard2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDashboard2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDashboard2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelDashboard2.Size = new System.Drawing.Size(333, 201);
            this.PanelDashboard2.TabIndex = 24;
            // 
            // btnActaadministrativa
            // 
            this.btnActaadministrativa.BackColor = System.Drawing.Color.Aquamarine;
            this.btnActaadministrativa.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.btnActaadministrativa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActaadministrativa.BorderRadius = 40;
            this.btnActaadministrativa.BorderSize = 0;
            this.btnActaadministrativa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActaadministrativa.FlatAppearance.BorderSize = 0;
            this.btnActaadministrativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActaadministrativa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActaadministrativa.ForeColor = System.Drawing.Color.Black;
            this.btnActaadministrativa.Location = new System.Drawing.Point(3, 103);
            this.btnActaadministrativa.Name = "btnActaadministrativa";
            this.btnActaadministrativa.Size = new System.Drawing.Size(160, 95);
            this.btnActaadministrativa.TabIndex = 6;
            this.btnActaadministrativa.Text = "Actas administrativas";
            this.btnActaadministrativa.TextColor = System.Drawing.Color.Black;
            this.btnActaadministrativa.UseVisualStyleBackColor = false;
            this.btnActaadministrativa.Click += new System.EventHandler(this.btnActaadministrativa_Click);
            // 
            // btnNom
            // 
            this.btnNom.BackColor = System.Drawing.Color.Aquamarine;
            this.btnNom.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.btnNom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNom.BorderRadius = 15;
            this.btnNom.BorderSize = 0;
            this.btnNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNom.FlatAppearance.BorderSize = 0;
            this.btnNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNom.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNom.ForeColor = System.Drawing.Color.Black;
            this.btnNom.Location = new System.Drawing.Point(169, 103);
            this.btnNom.Name = "btnNom";
            this.btnNom.Size = new System.Drawing.Size(161, 95);
            this.btnNom.TabIndex = 7;
            this.btnNom.Text = "Nomina";
            this.btnNom.TextColor = System.Drawing.Color.Black;
            this.btnNom.UseVisualStyleBackColor = false;
            this.btnNom.Click += new System.EventHandler(this.btnNom_Click);
            // 
            // btnContratosEmpleados
            // 
            this.btnContratosEmpleados.BackColor = System.Drawing.Color.Aquamarine;
            this.btnContratosEmpleados.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.btnContratosEmpleados.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnContratosEmpleados.BorderRadius = 40;
            this.btnContratosEmpleados.BorderSize = 0;
            this.btnContratosEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnContratosEmpleados.FlatAppearance.BorderSize = 0;
            this.btnContratosEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratosEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContratosEmpleados.ForeColor = System.Drawing.Color.Black;
            this.btnContratosEmpleados.Location = new System.Drawing.Point(3, 3);
            this.btnContratosEmpleados.Name = "btnContratosEmpleados";
            this.btnContratosEmpleados.Size = new System.Drawing.Size(160, 94);
            this.btnContratosEmpleados.TabIndex = 4;
            this.btnContratosEmpleados.Text = "Contrato empleados";
            this.btnContratosEmpleados.TextColor = System.Drawing.Color.Black;
            this.btnContratosEmpleados.UseVisualStyleBackColor = false;
            this.btnContratosEmpleados.Click += new System.EventHandler(this.btnContratosEmpleados_Click);
            // 
            // btnSancion
            // 
            this.btnSancion.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSancion.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.btnSancion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSancion.BorderRadius = 15;
            this.btnSancion.BorderSize = 0;
            this.btnSancion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSancion.FlatAppearance.BorderSize = 0;
            this.btnSancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSancion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSancion.ForeColor = System.Drawing.Color.Black;
            this.btnSancion.Location = new System.Drawing.Point(169, 3);
            this.btnSancion.Name = "btnSancion";
            this.btnSancion.Size = new System.Drawing.Size(161, 94);
            this.btnSancion.TabIndex = 5;
            this.btnSancion.Text = "Sanciones de empleados";
            this.btnSancion.TextColor = System.Drawing.Color.Black;
            this.btnSancion.UseVisualStyleBackColor = false;
            this.btnSancion.Click += new System.EventHandler(this.btnSancion_Click);
            // 
            // InicioAdminOficial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelCons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioAdminOficial";
            this.Text = "InicioAdminOficial";
            this.Load += new System.EventHandler(this.InicioAdminOficial_Load);
            this.panelCons.ResumeLayout(false);
            this.panelObjetos.ResumeLayout(false);
            this.PanelDivisor.ResumeLayout(false);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.PanelDivisor2.ResumeLayout(false);
            this.PanelDashboard1.ResumeLayout(false);
            this.PanelDashboard2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCons;
        private System.Windows.Forms.Panel panelObjetos;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor2;
        private System.Windows.Forms.TableLayoutPanel PanelDashboard1;
        private System.Windows.Forms.TableLayoutPanel PanelDashboard2;
        private FontAwesome.Sharp.IconButton btnCumplimiento;
        private FontAwesome.Sharp.IconButton btnGestionVacaciones;
        private FontAwesome.Sharp.IconButton btnBajas;
        private FontAwesome.Sharp.IconButton btnSanciones;
        private FontAwesome.Sharp.IconButton btnActas;
        private FontAwesome.Sharp.IconButton btnNomina;
        private FontAwesome.Sharp.IconButton btnContrato;
        private System.Windows.Forms.DateTimePicker dtpAdministracion;
        private System.Windows.Forms.Label lblFechanacimiento;
        private BotonEsquinaRedonda btnBaja;
        private BotonEsquinaRedonda btnCumpli;
        private BotonEsquinaRedonda btnGestion;
        private BotonEsquinaRedonda btnReconocimientos;
        private BotonEsquinaRedonda btnActaadministrativa;
        private BotonEsquinaRedonda btnNom;
        private BotonEsquinaRedonda btnContratosEmpleados;
        private BotonEsquinaRedonda btnSancion;
    }
}