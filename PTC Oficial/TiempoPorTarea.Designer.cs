namespace PTC_Oficial
{
    partial class TiempoPorTarea
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
            this.PanelDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFinalizacion = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtSubtarea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnRegistrar = new PTC_Oficial.BotonEsquinaRedonda();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.lblNIT = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.dgvTiempotarea = new System.Windows.Forms.DataGridView();
            this.errorTiempo = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.PanelDivisor.SuspendLayout();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempotarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.PanelDivisor);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 0;
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 1;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.panelCampos, 0, 0);
            this.PanelDivisor.Controls.Add(this.dgvTiempotarea, 0, 1);
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
            this.panelCampos.Controls.Add(this.lblFecha);
            this.panelCampos.Controls.Add(this.dtpFecha);
            this.panelCampos.Controls.Add(this.dtpFinal);
            this.panelCampos.Controls.Add(this.lblFinalizacion);
            this.panelCampos.Controls.Add(this.dtpInicio);
            this.panelCampos.Controls.Add(this.lblInicio);
            this.panelCampos.Controls.Add(this.txtSubtarea);
            this.panelCampos.Controls.Add(this.label1);
            this.panelCampos.Controls.Add(this.btnActualizar);
            this.panelCampos.Controls.Add(this.btnEliminar);
            this.panelCampos.Controls.Add(this.btnRegistrar);
            this.panelCampos.Controls.Add(this.txtTarea);
            this.panelCampos.Controls.Add(this.lblNIT);
            this.panelCampos.Controls.Add(this.txtDescripcion);
            this.panelCampos.Controls.Add(this.lblHoras);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(3, 3);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(678, 207);
            this.panelCampos.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(239, 122);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 53;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(295, 112);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(140, 32);
            this.dtpFecha.TabIndex = 52;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFinal.CustomFormat = "hh:mm";
            this.dtpFinal.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(523, 112);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(152, 32);
            this.dtpFinal.TabIndex = 51;
            // 
            // lblFinalizacion
            // 
            this.lblFinalizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFinalizacion.AutoSize = true;
            this.lblFinalizacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFinalizacion.ForeColor = System.Drawing.Color.Black;
            this.lblFinalizacion.Location = new System.Drawing.Point(441, 112);
            this.lblFinalizacion.Name = "lblFinalizacion";
            this.lblFinalizacion.Size = new System.Drawing.Size(78, 40);
            this.lblFinalizacion.TabIndex = 50;
            this.lblFinalizacion.Text = "Hora \r\nfinalizacion:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpInicio.CustomFormat = "hh:mm";
            this.dtpInicio.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(53, 112);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(180, 32);
            this.dtpInicio.TabIndex = 49;
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInicio.ForeColor = System.Drawing.Color.Black;
            this.lblInicio.Location = new System.Drawing.Point(3, 104);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(44, 40);
            this.lblInicio.TabIndex = 48;
            this.lblInicio.Text = "Hora \r\ninicio:\r\n";
            // 
            // txtSubtarea
            // 
            this.txtSubtarea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubtarea.BackColor = System.Drawing.Color.White;
            this.txtSubtarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtarea.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSubtarea.Location = new System.Drawing.Point(508, 8);
            this.txtSubtarea.Multiline = true;
            this.txtSubtarea.Name = "txtSubtarea";
            this.txtSubtarea.Size = new System.Drawing.Size(167, 98);
            this.txtSubtarea.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(466, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 40);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sub \r\ntarea:";
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
            this.btnActualizar.Location = new System.Drawing.Point(422, 164);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 40);
            this.btnActualizar.TabIndex = 41;
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
            this.btnEliminar.Location = new System.Drawing.Point(276, 163);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 40);
            this.btnEliminar.TabIndex = 40;
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
            this.btnRegistrar.Location = new System.Drawing.Point(140, 163);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 40);
            this.btnRegistrar.TabIndex = 39;
            this.btnRegistrar.Text = "Insertar";
            this.btnRegistrar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtTarea
            // 
            this.txtTarea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTarea.BackColor = System.Drawing.Color.White;
            this.txtTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarea.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTarea.Location = new System.Drawing.Point(320, 7);
            this.txtTarea.Multiline = true;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(140, 99);
            this.txtTarea.TabIndex = 35;
            // 
            // lblNIT
            // 
            this.lblNIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNIT.ForeColor = System.Drawing.Color.Black;
            this.lblNIT.Location = new System.Drawing.Point(278, 11);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(46, 20);
            this.lblNIT.TabIndex = 34;
            this.lblNIT.Text = "Tarea:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(100, 6);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(179, 100);
            this.txtDescripcion.TabIndex = 33;
            // 
            // lblHoras
            // 
            this.lblHoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoras.ForeColor = System.Drawing.Color.Black;
            this.lblHoras.Location = new System.Drawing.Point(3, 6);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(91, 40);
            this.lblHoras.TabIndex = 32;
            this.lblHoras.Text = "Descricpción \r\nde tarea:";
            // 
            // dgvTiempotarea
            // 
            this.dgvTiempotarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiempotarea.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTiempotarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiempotarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTiempotarea.Location = new System.Drawing.Point(3, 216);
            this.dgvTiempotarea.MultiSelect = false;
            this.dgvTiempotarea.Name = "dgvTiempotarea";
            this.dgvTiempotarea.ReadOnly = true;
            this.dgvTiempotarea.RowHeadersVisible = false;
            this.dgvTiempotarea.RowTemplate.Height = 25;
            this.dgvTiempotarea.Size = new System.Drawing.Size(678, 207);
            this.dgvTiempotarea.TabIndex = 1;
            // 
            // errorTiempo
            // 
            this.errorTiempo.ContainerControl = this;
            // 
            // TiempoPorTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TiempoPorTarea";
            this.Text = "TiempoPorTarea";
            this.panelContenedor.ResumeLayout(false);
            this.PanelDivisor.ResumeLayout(false);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempotarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTiempo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.DataGridView dgvTiempotarea;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtSubtarea;
        private System.Windows.Forms.Label label1;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnRegistrar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label lblFinalizacion;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.ErrorProvider errorTiempo;
    }
}