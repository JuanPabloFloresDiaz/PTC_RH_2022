namespace PTC_Oficial
{
    partial class RegistroPagos
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
            this.panelContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.panelSubcontenedor = new System.Windows.Forms.Panel();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnAgregar = new PTC_Oficial.BotonEsquinaRedonda();
            this.cboFormadepago = new System.Windows.Forms.ComboBox();
            this.lblForma = new System.Windows.Forms.Label();
            this.dtpFechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechavencimiento = new System.Windows.Forms.Label();
            this.dtpFechapago = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvRegistroPago = new System.Windows.Forms.DataGridView();
            this.errorPago = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelSubcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.ColumnCount = 1;
            this.panelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelContenedor.Controls.Add(this.panelSubcontenedor, 0, 0);
            this.panelContenedor.Controls.Add(this.dgvRegistroPago, 0, 1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.RowCount = 2;
            this.panelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.80751F));
            this.panelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.19249F));
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelSubcontenedor
            // 
            this.panelSubcontenedor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelSubcontenedor.Controls.Add(this.cboEmpleados);
            this.panelSubcontenedor.Controls.Add(this.lblEmpleado);
            this.panelSubcontenedor.Controls.Add(this.btnActualizar);
            this.panelSubcontenedor.Controls.Add(this.btnEliminar);
            this.panelSubcontenedor.Controls.Add(this.btnAgregar);
            this.panelSubcontenedor.Controls.Add(this.cboFormadepago);
            this.panelSubcontenedor.Controls.Add(this.lblForma);
            this.panelSubcontenedor.Controls.Add(this.dtpFechavencimiento);
            this.panelSubcontenedor.Controls.Add(this.lblFechavencimiento);
            this.panelSubcontenedor.Controls.Add(this.dtpFechapago);
            this.panelSubcontenedor.Controls.Add(this.lblFecha);
            this.panelSubcontenedor.Controls.Add(this.lblTitulo);
            this.panelSubcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubcontenedor.Location = new System.Drawing.Point(3, 3);
            this.panelSubcontenedor.Name = "panelSubcontenedor";
            this.panelSubcontenedor.Size = new System.Drawing.Size(678, 236);
            this.panelSubcontenedor.TabIndex = 0;
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(390, 92);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(267, 28);
            this.cboEmpleados.TabIndex = 47;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(309, 95);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 20);
            this.lblEmpleado.TabIndex = 46;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnActualizar.Location = new System.Drawing.Point(309, 182);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 40);
            this.btnActualizar.TabIndex = 27;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Lime;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnEliminar.Location = new System.Drawing.Point(461, 182);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 40);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.Red;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnAgregar.Location = new System.Drawing.Point(165, 182);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 40);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboFormadepago
            // 
            this.cboFormadepago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboFormadepago.BackColor = System.Drawing.Color.White;
            this.cboFormadepago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormadepago.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboFormadepago.FormattingEnabled = true;
            this.cboFormadepago.Location = new System.Drawing.Point(134, 95);
            this.cboFormadepago.Name = "cboFormadepago";
            this.cboFormadepago.Size = new System.Drawing.Size(169, 28);
            this.cboFormadepago.TabIndex = 23;
            // 
            // lblForma
            // 
            this.lblForma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForma.AutoSize = true;
            this.lblForma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForma.ForeColor = System.Drawing.Color.Black;
            this.lblForma.Location = new System.Drawing.Point(22, 103);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(106, 20);
            this.lblForma.TabIndex = 21;
            this.lblForma.Text = "Forma de pago:";
            this.lblForma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechavencimiento
            // 
            this.dtpFechavencimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechavencimiento.CustomFormat = "yyyy-MM-dd";
            this.dtpFechavencimiento.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechavencimiento.Location = new System.Drawing.Point(461, 38);
            this.dtpFechavencimiento.Name = "dtpFechavencimiento";
            this.dtpFechavencimiento.Size = new System.Drawing.Size(196, 32);
            this.dtpFechavencimiento.TabIndex = 20;
            // 
            // lblFechavencimiento
            // 
            this.lblFechavencimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechavencimiento.AutoSize = true;
            this.lblFechavencimiento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechavencimiento.ForeColor = System.Drawing.Color.Black;
            this.lblFechavencimiento.Location = new System.Drawing.Point(309, 48);
            this.lblFechavencimiento.Name = "lblFechavencimiento";
            this.lblFechavencimiento.Size = new System.Drawing.Size(146, 20);
            this.lblFechavencimiento.TabIndex = 19;
            this.lblFechavencimiento.Text = "Fecha de vencimiento:";
            this.lblFechavencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechapago
            // 
            this.dtpFechapago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechapago.CustomFormat = "yyyy-MM-dd";
            this.dtpFechapago.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechapago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechapago.Location = new System.Drawing.Point(134, 38);
            this.dtpFechapago.Name = "dtpFechapago";
            this.dtpFechapago.Size = new System.Drawing.Size(169, 32);
            this.dtpFechapago.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(23, 48);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(105, 20);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha de pago:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(232, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 29);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Registro de pagos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRegistroPago
            // 
            this.dgvRegistroPago.AllowUserToAddRows = false;
            this.dgvRegistroPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistroPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroPago.Location = new System.Drawing.Point(3, 245);
            this.dgvRegistroPago.Name = "dgvRegistroPago";
            this.dgvRegistroPago.ReadOnly = true;
            this.dgvRegistroPago.RowHeadersVisible = false;
            this.dgvRegistroPago.RowTemplate.Height = 25;
            this.dgvRegistroPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistroPago.Size = new System.Drawing.Size(678, 178);
            this.dgvRegistroPago.TabIndex = 1;
            this.dgvRegistroPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroPago_CellContentClick);
            // 
            // errorPago
            // 
            this.errorPago.ContainerControl = this;
            // 
            // RegistroPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroPagos";
            this.Text = "RegistroPagos";
            this.Load += new System.EventHandler(this.RegistroPagos_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelSubcontenedor.ResumeLayout(false);
            this.panelSubcontenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelContenedor;
        private System.Windows.Forms.Panel panelSubcontenedor;
        private System.Windows.Forms.DataGridView dgvRegistroPago;
        private System.Windows.Forms.DateTimePicker dtpFechavencimiento;
        private System.Windows.Forms.Label lblFechavencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechapago;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.ComboBox cboFormadepago;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnAgregar;
        private System.Windows.Forms.ErrorProvider errorPago;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
    }
}