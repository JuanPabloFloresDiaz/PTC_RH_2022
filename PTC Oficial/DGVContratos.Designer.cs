namespace PTC_Oficial
{
    partial class DGVContratos
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnElminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.errorDatosRegistrados = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.panelContenedor.SuspendLayout();
            this.panelObjetos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatosRegistrados)).BeginInit();
            this.PanelDivisor.SuspendLayout();
            this.panelCampos.SuspendLayout();
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
            this.panelObjetos.Controls.Add(this.PanelDivisor);
            this.panelObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjetos.Location = new System.Drawing.Point(0, 0);
            this.panelObjetos.Name = "panelObjetos";
            this.panelObjetos.Size = new System.Drawing.Size(684, 426);
            this.panelObjetos.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.Location = new System.Drawing.Point(320, 82);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(234, 25);
            this.txtDireccion.TabIndex = 28;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(98, 82);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(216, 22);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección del empleado:";
            this.lblDireccion.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // btnElminar
            // 
            this.btnElminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnElminar.BackColor = System.Drawing.Color.Snow;
            this.btnElminar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnElminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnElminar.BorderRadius = 40;
            this.btnElminar.BorderSize = 0;
            this.btnElminar.FlatAppearance.BorderSize = 0;
            this.btnElminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElminar.ForeColor = System.Drawing.Color.Red;
            this.btnElminar.Location = new System.Drawing.Point(392, 164);
            this.btnElminar.Name = "btnElminar";
            this.btnElminar.Size = new System.Drawing.Size(162, 40);
            this.btnElminar.TabIndex = 5;
            this.btnElminar.Text = "Eliminar";
            this.btnElminar.TextColor = System.Drawing.Color.Red;
            this.btnElminar.UseVisualStyleBackColor = false;
            this.btnElminar.Click += new System.EventHandler(this.btnElminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActualizar.BackColor = System.Drawing.Color.Snow;
            this.btnActualizar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizar.BorderRadius = 40;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Lime;
            this.btnActualizar.Location = new System.Drawing.Point(152, 164);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(162, 40);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Lime;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(624, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(152, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(402, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Datos de empleados registrados";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(3, 216);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowTemplate.Height = 25;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(678, 207);
            this.dgvEmpleados.TabIndex = 1;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // errorDatosRegistrados
            // 
            this.errorDatosRegistrados.ContainerControl = this;
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 1;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.dgvEmpleados, 0, 1);
            this.PanelDivisor.Controls.Add(this.panelCampos, 0, 0);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 2;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 29;
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.btnElminar);
            this.panelCampos.Controls.Add(this.btnSalir);
            this.panelCampos.Controls.Add(this.lblTitulo);
            this.panelCampos.Controls.Add(this.txtDireccion);
            this.panelCampos.Controls.Add(this.lblDireccion);
            this.panelCampos.Controls.Add(this.btnActualizar);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(3, 3);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(678, 207);
            this.panelCampos.TabIndex = 2;
            // 
            // DGVContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DGVContratos";
            this.Text = "DGVContratos";
            this.Load += new System.EventHandler(this.DGVContratos_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelObjetos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatosRegistrados)).EndInit();
            this.PanelDivisor.ResumeLayout(false);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errorDatosRegistrados;
        public System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Panel panelObjetos;
        private FontAwesome.Sharp.IconButton btnSalir;
        public BotonEsquinaRedonda btnActualizar;
        public BotonEsquinaRedonda btnElminar;
        public System.Windows.Forms.Label lblDireccion;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.Panel panelCampos;
    }
}