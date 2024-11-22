namespace PTC_Oficial
{
    partial class CumplimientoEmpleados
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
            this.txtProductividad = new System.Windows.Forms.MaskedTextBox();
            this.txtEficiencia = new System.Windows.Forms.MaskedTextBox();
            this.txtEntornoLaboral = new System.Windows.Forms.MaskedTextBox();
            this.txtTrabajoenequipo = new System.Windows.Forms.MaskedTextBox();
            this.txtEsfuerzo = new System.Windows.Forms.MaskedTextBox();
            this.txtActitud = new System.Windows.Forms.MaskedTextBox();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.dgvCumplimientoEmpleado = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnAgregar = new PTC_Oficial.BotonEsquinaRedonda();
            this.lblProductividad = new System.Windows.Forms.Label();
            this.lblEficiencia = new System.Windows.Forms.Label();
            this.lblEntornoLaboral = new System.Windows.Forms.Label();
            this.lblActitud = new System.Windows.Forms.Label();
            this.lblEsfuerzo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorCumplimiento = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCumplimientoEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCumplimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(201, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(328, 29);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Cumplimiento de empleado";
            // 
            // txtProductividad
            // 
            this.txtProductividad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductividad.BackColor = System.Drawing.Color.Snow;
            this.txtProductividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductividad.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProductividad.Location = new System.Drawing.Point(167, 46);
            this.txtProductividad.Mask = "999";
            this.txtProductividad.Name = "txtProductividad";
            this.txtProductividad.Size = new System.Drawing.Size(46, 23);
            this.txtProductividad.TabIndex = 19;
            // 
            // txtEficiencia
            // 
            this.txtEficiencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEficiencia.BackColor = System.Drawing.Color.Snow;
            this.txtEficiencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEficiencia.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEficiencia.Location = new System.Drawing.Point(167, 102);
            this.txtEficiencia.Mask = "999";
            this.txtEficiencia.Name = "txtEficiencia";
            this.txtEficiencia.Size = new System.Drawing.Size(46, 23);
            this.txtEficiencia.TabIndex = 20;
            // 
            // txtEntornoLaboral
            // 
            this.txtEntornoLaboral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEntornoLaboral.BackColor = System.Drawing.Color.Snow;
            this.txtEntornoLaboral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntornoLaboral.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEntornoLaboral.Location = new System.Drawing.Point(167, 158);
            this.txtEntornoLaboral.Mask = "999";
            this.txtEntornoLaboral.Name = "txtEntornoLaboral";
            this.txtEntornoLaboral.Size = new System.Drawing.Size(46, 23);
            this.txtEntornoLaboral.TabIndex = 21;
            // 
            // txtTrabajoenequipo
            // 
            this.txtTrabajoenequipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrabajoenequipo.BackColor = System.Drawing.Color.Snow;
            this.txtTrabajoenequipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrabajoenequipo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTrabajoenequipo.Location = new System.Drawing.Point(535, 158);
            this.txtTrabajoenequipo.Mask = "999";
            this.txtTrabajoenequipo.Name = "txtTrabajoenequipo";
            this.txtTrabajoenequipo.Size = new System.Drawing.Size(46, 23);
            this.txtTrabajoenequipo.TabIndex = 24;
            // 
            // txtEsfuerzo
            // 
            this.txtEsfuerzo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEsfuerzo.BackColor = System.Drawing.Color.Snow;
            this.txtEsfuerzo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEsfuerzo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEsfuerzo.Location = new System.Drawing.Point(535, 102);
            this.txtEsfuerzo.Mask = "999";
            this.txtEsfuerzo.Name = "txtEsfuerzo";
            this.txtEsfuerzo.Size = new System.Drawing.Size(46, 23);
            this.txtEsfuerzo.TabIndex = 23;
            // 
            // txtActitud
            // 
            this.txtActitud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtActitud.BackColor = System.Drawing.Color.Snow;
            this.txtActitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActitud.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtActitud.Location = new System.Drawing.Point(535, 46);
            this.txtActitud.Mask = "999";
            this.txtActitud.Name = "txtActitud";
            this.txtActitud.Size = new System.Drawing.Size(46, 23);
            this.txtActitud.TabIndex = 22;
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(167, 200);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(414, 30);
            this.cboEmpleados.TabIndex = 47;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(73, 204);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 20);
            this.lblEmpleado.TabIndex = 46;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCumplimientoEmpleado
            // 
            this.dgvCumplimientoEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCumplimientoEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCumplimientoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCumplimientoEmpleado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCumplimientoEmpleado.Location = new System.Drawing.Point(0, 282);
            this.dgvCumplimientoEmpleado.MultiSelect = false;
            this.dgvCumplimientoEmpleado.Name = "dgvCumplimientoEmpleado";
            this.dgvCumplimientoEmpleado.ReadOnly = true;
            this.dgvCumplimientoEmpleado.RowHeadersVisible = false;
            this.dgvCumplimientoEmpleado.RowTemplate.Height = 25;
            this.dgvCumplimientoEmpleado.Size = new System.Drawing.Size(684, 144);
            this.dgvCumplimientoEmpleado.TabIndex = 48;
            this.dgvCumplimientoEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCumplimientoEmpleado_CellContentClick);
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
            this.btnActualizar.Location = new System.Drawing.Point(453, 236);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(128, 40);
            this.btnActualizar.TabIndex = 51;
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
            this.btnEliminar.Location = new System.Drawing.Point(310, 236);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 40);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.Red;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.BackColor = System.Drawing.Color.Snow;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnAgregar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.Location = new System.Drawing.Point(167, 236);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 40);
            this.btnAgregar.TabIndex = 49;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProductividad
            // 
            this.lblProductividad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductividad.AutoSize = true;
            this.lblProductividad.BackColor = System.Drawing.Color.Transparent;
            this.lblProductividad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductividad.ForeColor = System.Drawing.Color.Black;
            this.lblProductividad.Location = new System.Drawing.Point(53, 29);
            this.lblProductividad.Name = "lblProductividad";
            this.lblProductividad.Size = new System.Drawing.Size(95, 40);
            this.lblProductividad.TabIndex = 52;
            this.lblProductividad.Text = "Productividad \r\ny calidad:";
            this.lblProductividad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEficiencia
            // 
            this.lblEficiencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEficiencia.AutoSize = true;
            this.lblEficiencia.BackColor = System.Drawing.Color.Transparent;
            this.lblEficiencia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEficiencia.ForeColor = System.Drawing.Color.Black;
            this.lblEficiencia.Location = new System.Drawing.Point(78, 102);
            this.lblEficiencia.Name = "lblEficiencia";
            this.lblEficiencia.Size = new System.Drawing.Size(70, 20);
            this.lblEficiencia.TabIndex = 53;
            this.lblEficiencia.Text = "Eficiencia:";
            this.lblEficiencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntornoLaboral
            // 
            this.lblEntornoLaboral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEntornoLaboral.AutoSize = true;
            this.lblEntornoLaboral.BackColor = System.Drawing.Color.Transparent;
            this.lblEntornoLaboral.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEntornoLaboral.ForeColor = System.Drawing.Color.Black;
            this.lblEntornoLaboral.Location = new System.Drawing.Point(46, 141);
            this.lblEntornoLaboral.Name = "lblEntornoLaboral";
            this.lblEntornoLaboral.Size = new System.Drawing.Size(102, 40);
            this.lblEntornoLaboral.TabIndex = 54;
            this.lblEntornoLaboral.Text = "Presencia en\r\nentorno laboral:";
            this.lblEntornoLaboral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActitud
            // 
            this.lblActitud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblActitud.AutoSize = true;
            this.lblActitud.BackColor = System.Drawing.Color.Transparent;
            this.lblActitud.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActitud.ForeColor = System.Drawing.Color.Black;
            this.lblActitud.Location = new System.Drawing.Point(476, 47);
            this.lblActitud.Name = "lblActitud";
            this.lblActitud.Size = new System.Drawing.Size(53, 20);
            this.lblActitud.TabIndex = 55;
            this.lblActitud.Text = "Actitud:";
            this.lblActitud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEsfuerzo
            // 
            this.lblEsfuerzo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEsfuerzo.AutoSize = true;
            this.lblEsfuerzo.BackColor = System.Drawing.Color.Transparent;
            this.lblEsfuerzo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEsfuerzo.ForeColor = System.Drawing.Color.Black;
            this.lblEsfuerzo.Location = new System.Drawing.Point(463, 102);
            this.lblEsfuerzo.Name = "lblEsfuerzo";
            this.lblEsfuerzo.Size = new System.Drawing.Size(66, 20);
            this.lblEsfuerzo.TabIndex = 56;
            this.lblEsfuerzo.Text = "Esfuerzo:";
            this.lblEsfuerzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(453, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 40);
            this.label6.TabIndex = 57;
            this.label6.Text = "Trabajo en \r\nequipo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorCumplimiento
            // 
            this.errorCumplimiento.ContainerControl = this;
            // 
            // CumplimientoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEsfuerzo);
            this.Controls.Add(this.lblActitud);
            this.Controls.Add(this.lblEntornoLaboral);
            this.Controls.Add(this.lblEficiencia);
            this.Controls.Add(this.lblProductividad);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCumplimientoEmpleado);
            this.Controls.Add(this.cboEmpleados);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txtTrabajoenequipo);
            this.Controls.Add(this.txtEsfuerzo);
            this.Controls.Add(this.txtActitud);
            this.Controls.Add(this.txtEntornoLaboral);
            this.Controls.Add(this.txtEficiencia);
            this.Controls.Add(this.txtProductividad);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CumplimientoEmpleados";
            this.Text = "CumplimientoEmpleados";
            this.Load += new System.EventHandler(this.CumplimientoEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCumplimientoEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCumplimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox txtProductividad;
        private System.Windows.Forms.MaskedTextBox txtEficiencia;
        private System.Windows.Forms.MaskedTextBox txtEntornoLaboral;
        private System.Windows.Forms.MaskedTextBox txtTrabajoenequipo;
        private System.Windows.Forms.MaskedTextBox txtEsfuerzo;
        private System.Windows.Forms.MaskedTextBox txtActitud;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.DataGridView dgvCumplimientoEmpleado;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnAgregar;
        private System.Windows.Forms.Label lblProductividad;
        private System.Windows.Forms.Label lblEficiencia;
        private System.Windows.Forms.Label lblEntornoLaboral;
        private System.Windows.Forms.Label lblActitud;
        private System.Windows.Forms.Label lblEsfuerzo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorCumplimiento;
    }
}