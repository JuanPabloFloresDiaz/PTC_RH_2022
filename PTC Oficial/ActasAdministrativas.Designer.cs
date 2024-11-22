namespace PTC_Oficial
{
    partial class ActasAdministrativas
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
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAcusador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHechos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFalta = new System.Windows.Forms.TextBox();
            this.lblNIT = new System.Windows.Forms.Label();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnRegistrar = new PTC_Oficial.BotonEsquinaRedonda();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvActas = new System.Windows.Forms.DataGridView();
            this.errorActas = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelDivisor.SuspendLayout();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorActas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(211, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 29);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Actas administrativas";
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 1;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.panelCampos, 0, 0);
            this.PanelDivisor.Controls.Add(this.dgvActas, 0, 1);
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
            this.panelCampos.Controls.Add(this.cboEmpleados);
            this.panelCampos.Controls.Add(this.lblEmpleado);
            this.panelCampos.Controls.Add(this.txtCargo);
            this.panelCampos.Controls.Add(this.label6);
            this.panelCampos.Controls.Add(this.txtAcusador);
            this.panelCampos.Controls.Add(this.label5);
            this.panelCampos.Controls.Add(this.txtHechos);
            this.panelCampos.Controls.Add(this.label4);
            this.panelCampos.Controls.Add(this.txtCiudad);
            this.panelCampos.Controls.Add(this.label3);
            this.panelCampos.Controls.Add(this.txtEmpresa);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Controls.Add(this.txtRazon);
            this.panelCampos.Controls.Add(this.label1);
            this.panelCampos.Controls.Add(this.txtFalta);
            this.panelCampos.Controls.Add(this.lblNIT);
            this.panelCampos.Controls.Add(this.btnActualizar);
            this.panelCampos.Controls.Add(this.btnEliminar);
            this.panelCampos.Controls.Add(this.btnRegistrar);
            this.panelCampos.Controls.Add(this.lblFecha);
            this.panelCampos.Controls.Add(this.dtpFecha);
            this.panelCampos.Controls.Add(this.lblTitulo);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(3, 3);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(678, 207);
            this.panelCampos.TabIndex = 0;
            this.panelCampos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCampos_Paint);
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(191, 133);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(332, 28);
            this.cboEmpleados.TabIndex = 68;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(110, 136);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 20);
            this.lblEmpleado.TabIndex = 67;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCargo
            // 
            this.txtCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCargo.BackColor = System.Drawing.Color.White;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCargo.Location = new System.Drawing.Point(529, 48);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(140, 25);
            this.txtCargo.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(449, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 60);
            this.label6.TabIndex = 65;
            this.label6.Text = "Cargo \r\nempleado \r\nacusado:";
            // 
            // txtAcusador
            // 
            this.txtAcusador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcusador.BackColor = System.Drawing.Color.White;
            this.txtAcusador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAcusador.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAcusador.Location = new System.Drawing.Point(290, 105);
            this.txtAcusador.Name = "txtAcusador";
            this.txtAcusador.Size = new System.Drawing.Size(140, 25);
            this.txtAcusador.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(221, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Acusador: ";
            // 
            // txtHechos
            // 
            this.txtHechos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHechos.BackColor = System.Drawing.Color.White;
            this.txtHechos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHechos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHechos.Location = new System.Drawing.Point(290, 31);
            this.txtHechos.Multiline = true;
            this.txtHechos.Name = "txtHechos";
            this.txtHechos.Size = new System.Drawing.Size(140, 68);
            this.txtHechos.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(221, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Hechos: ";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCiudad.Location = new System.Drawing.Point(75, 104);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(140, 25);
            this.txtCiudad.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Ciudad: ";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpresa.BackColor = System.Drawing.Color.White;
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpresa.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmpresa.Location = new System.Drawing.Point(75, 73);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(140, 25);
            this.txtEmpresa.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 40);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nombre de \r\nla empresa: ";
            // 
            // txtRazon
            // 
            this.txtRazon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRazon.BackColor = System.Drawing.Color.White;
            this.txtRazon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazon.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRazon.Location = new System.Drawing.Point(75, 7);
            this.txtRazon.Multiline = true;
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(140, 49);
            this.txtRazon.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 40);
            this.label1.TabIndex = 55;
            this.label1.Text = "Razon del\r\nacta: ";
            // 
            // txtFalta
            // 
            this.txtFalta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFalta.BackColor = System.Drawing.Color.White;
            this.txtFalta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFalta.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFalta.Location = new System.Drawing.Point(529, 105);
            this.txtFalta.Name = "txtFalta";
            this.txtFalta.Size = new System.Drawing.Size(140, 25);
            this.txtFalta.TabIndex = 54;
            this.txtFalta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFalta_KeyPress);
            // 
            // lblNIT
            // 
            this.lblNIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNIT.ForeColor = System.Drawing.Color.Black;
            this.lblNIT.Location = new System.Drawing.Point(472, 109);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(64, 20);
            this.lblNIT.TabIndex = 53;
            this.lblNIT.Text = "N° Falta: ";
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
            this.btnActualizar.Location = new System.Drawing.Point(419, 164);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 40);
            this.btnActualizar.TabIndex = 52;
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
            this.btnEliminar.Location = new System.Drawing.Point(273, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 40);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.Red;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnRegistrar.Location = new System.Drawing.Point(137, 166);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 40);
            this.btnRegistrar.TabIndex = 50;
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
            this.lblFecha.Location = new System.Drawing.Point(476, 3);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 40);
            this.lblFecha.TabIndex = 49;
            this.lblFecha.Text = "Fecha\r\nacta:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(529, 3);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(140, 32);
            this.dtpFecha.TabIndex = 48;
            // 
            // dgvActas
            // 
            this.dgvActas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvActas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActas.Location = new System.Drawing.Point(3, 216);
            this.dgvActas.MultiSelect = false;
            this.dgvActas.Name = "dgvActas";
            this.dgvActas.ReadOnly = true;
            this.dgvActas.RowHeadersVisible = false;
            this.dgvActas.RowTemplate.Height = 25;
            this.dgvActas.Size = new System.Drawing.Size(678, 207);
            this.dgvActas.TabIndex = 1;
            this.dgvActas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActas_CellContentClick);
            // 
            // errorActas
            // 
            this.errorActas.ContainerControl = this;
            // 
            // ActasAdministrativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.PanelDivisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActasAdministrativas";
            this.Text = "ActasAdministrativas";
            this.Load += new System.EventHandler(this.ActasAdministrativas_Load);
            this.PanelDivisor.ResumeLayout(false);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorActas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.DataGridView dgvActas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnRegistrar;
        private System.Windows.Forms.TextBox txtAcusador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHechos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFalta;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ErrorProvider errorActas;
    }
}