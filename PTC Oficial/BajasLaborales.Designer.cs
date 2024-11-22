namespace PTC_Oficial
{
    partial class BajasLaborales
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PanelDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.cboVacaciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnRegistrar = new PTC_Oficial.BotonEsquinaRedonda();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.lblNIT = new System.Windows.Forms.Label();
            this.dgvBajas = new System.Windows.Forms.DataGridView();
            this.errorBajas = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelDivisor.SuspendLayout();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBajas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(184, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(318, 29);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Gestion de bajas laborales";
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 1;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.panelCampos, 0, 0);
            this.PanelDivisor.Controls.Add(this.dgvBajas, 0, 1);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 2;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 21;
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.cboVacaciones);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Controls.Add(this.cboEstatus);
            this.panelCampos.Controls.Add(this.label1);
            this.panelCampos.Controls.Add(this.cboEmpleados);
            this.panelCampos.Controls.Add(this.lblEmpleado);
            this.panelCampos.Controls.Add(this.btnActualizar);
            this.panelCampos.Controls.Add(this.btnEliminar);
            this.panelCampos.Controls.Add(this.btnRegistrar);
            this.panelCampos.Controls.Add(this.lblFecha);
            this.panelCampos.Controls.Add(this.dtpFecha);
            this.panelCampos.Controls.Add(this.txtJustificacion);
            this.panelCampos.Controls.Add(this.lblNIT);
            this.panelCampos.Controls.Add(this.lblTitulo);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(3, 3);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(678, 207);
            this.panelCampos.TabIndex = 0;
            // 
            // cboVacaciones
            // 
            this.cboVacaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboVacaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVacaciones.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboVacaciones.FormattingEnabled = true;
            this.cboVacaciones.Location = new System.Drawing.Point(458, 125);
            this.cboVacaciones.Name = "cboVacaciones";
            this.cboVacaciones.Size = new System.Drawing.Size(211, 28);
            this.cboVacaciones.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(377, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Vacaciones:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboEstatus
            // 
            this.cboEstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(458, 91);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(211, 28);
            this.cboEstatus.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(396, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Estatus:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(110, 120);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(261, 28);
            this.cboEmpleados.TabIndex = 56;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(29, 123);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 20);
            this.lblEmpleado.TabIndex = 55;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActualizar.BackColor = System.Drawing.Color.Snow;
            this.btnActualizar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnActualizar.BorderColor = System.Drawing.Color.Lime;
            this.btnActualizar.BorderRadius = 40;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Lime;
            this.btnActualizar.Location = new System.Drawing.Point(415, 164);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 40);
            this.btnActualizar.TabIndex = 54;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Lime;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.BackColor = System.Drawing.Color.Snow;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnEliminar.BorderColor = System.Drawing.Color.Red;
            this.btnEliminar.BorderRadius = 40;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(269, 163);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 40);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.Red;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrar.BackColor = System.Drawing.Color.Snow;
            this.btnRegistrar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnRegistrar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.BorderRadius = 40;
            this.btnRegistrar.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.Location = new System.Drawing.Point(133, 163);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 40);
            this.btnRegistrar.TabIndex = 52;
            this.btnRegistrar.Text = "Insertar";
            this.btnRegistrar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(399, 45);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 51;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(458, 45);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(211, 32);
            this.dtpFecha.TabIndex = 50;
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJustificacion.BackColor = System.Drawing.Color.White;
            this.txtJustificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJustificacion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJustificacion.Location = new System.Drawing.Point(110, 41);
            this.txtJustificacion.Multiline = true;
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.Size = new System.Drawing.Size(276, 73);
            this.txtJustificacion.TabIndex = 49;
            // 
            // lblNIT
            // 
            this.lblNIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNIT.ForeColor = System.Drawing.Color.Black;
            this.lblNIT.Location = new System.Drawing.Point(26, 45);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(85, 20);
            this.lblNIT.TabIndex = 48;
            this.lblNIT.Text = "Justificacion:";
            // 
            // dgvBajas
            // 
            this.dgvBajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBajas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBajas.Location = new System.Drawing.Point(3, 216);
            this.dgvBajas.MultiSelect = false;
            this.dgvBajas.Name = "dgvBajas";
            this.dgvBajas.ReadOnly = true;
            this.dgvBajas.RowHeadersVisible = false;
            this.dgvBajas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvBajas.RowTemplate.Height = 25;
            this.dgvBajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBajas.Size = new System.Drawing.Size(678, 207);
            this.dgvBajas.TabIndex = 1;
            this.dgvBajas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBajas_CellContentClick);
            // 
            // errorBajas
            // 
            this.errorBajas.ContainerControl = this;
            // 
            // BajasLaborales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.PanelDivisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BajasLaborales";
            this.Text = "BajasLaborales";
            this.Load += new System.EventHandler(this.BajasLaborales_Load);
            this.PanelDivisor.ResumeLayout(false);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBajas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.DataGridView dgvBajas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.Label lblNIT;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnRegistrar;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboVacaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorBajas;
    }
}