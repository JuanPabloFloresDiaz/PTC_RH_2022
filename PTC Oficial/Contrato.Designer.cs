namespace PTC_Oficial
{
    partial class Contrato
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
            components = new System.ComponentModel.Container();
            lblTitulo = new System.Windows.Forms.Label();
            PanelDivisor = new System.Windows.Forms.TableLayoutPanel();
            panelCampos = new System.Windows.Forms.Panel();
            txtClausulas = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            cboSalarios = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dtpHasta = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            dtpDesde = new System.Windows.Forms.DateTimePicker();
            cboNacionalidades = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            cboEmpleados = new System.Windows.Forms.ComboBox();
            lblEmpleado = new System.Windows.Forms.Label();
            btnActualizar = new BotonEsquinaRedonda();
            btnEliminar = new BotonEsquinaRedonda();
            btnRegistrar = new BotonEsquinaRedonda();
            txtEmpresa = new System.Windows.Forms.TextBox();
            lblNIT = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            dtpFecha = new System.Windows.Forms.DateTimePicker();
            dgvContrato = new System.Windows.Forms.DataGridView();
            errorContrato = new System.Windows.Forms.ErrorProvider(components);
            PanelDivisor.SuspendLayout();
            panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContrato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorContrato).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = System.Drawing.Color.Transparent;
            lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(313, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(140, 35);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Contrato";
            // 
            // PanelDivisor
            // 
            PanelDivisor.ColumnCount = 1;
            PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            PanelDivisor.Controls.Add(panelCampos, 0, 0);
            PanelDivisor.Controls.Add(dgvContrato, 0, 1);
            PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelDivisor.Location = new System.Drawing.Point(0, 0);
            PanelDivisor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PanelDivisor.Name = "PanelDivisor";
            PanelDivisor.RowCount = 2;
            PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.74648F));
            PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.25352F));
            PanelDivisor.Size = new System.Drawing.Size(782, 568);
            PanelDivisor.TabIndex = 21;
            // 
            // panelCampos
            // 
            panelCampos.Controls.Add(txtClausulas);
            panelCampos.Controls.Add(label5);
            panelCampos.Controls.Add(cboSalarios);
            panelCampos.Controls.Add(label4);
            panelCampos.Controls.Add(label3);
            panelCampos.Controls.Add(dtpHasta);
            panelCampos.Controls.Add(label2);
            panelCampos.Controls.Add(dtpDesde);
            panelCampos.Controls.Add(cboNacionalidades);
            panelCampos.Controls.Add(label1);
            panelCampos.Controls.Add(cboEmpleados);
            panelCampos.Controls.Add(lblEmpleado);
            panelCampos.Controls.Add(btnActualizar);
            panelCampos.Controls.Add(btnEliminar);
            panelCampos.Controls.Add(btnRegistrar);
            panelCampos.Controls.Add(txtEmpresa);
            panelCampos.Controls.Add(lblNIT);
            panelCampos.Controls.Add(lblFecha);
            panelCampos.Controls.Add(dtpFecha);
            panelCampos.Controls.Add(lblTitulo);
            panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCampos.Location = new System.Drawing.Point(3, 4);
            panelCampos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new System.Drawing.Size(776, 320);
            panelCampos.TabIndex = 0;
            // 
            // txtClausulas
            // 
            txtClausulas.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtClausulas.BackColor = System.Drawing.Color.White;
            txtClausulas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtClausulas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtClausulas.Location = new System.Drawing.Point(604, 49);
            txtClausulas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtClausulas.Multiline = true;
            txtClausulas.Name = "txtClausulas";
            txtClausulas.Size = new System.Drawing.Size(160, 140);
            txtClausulas.TabIndex = 66;
            txtClausulas.TextChanged += txtClausulas_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(524, 49);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(90, 24);
            label5.TabIndex = 65;
            label5.Text = "Clausulas: ";
            // 
            // cboSalarios
            // 
            cboSalarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboSalarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboSalarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboSalarios.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cboSalarios.FormattingEnabled = true;
            cboSalarios.Location = new System.Drawing.Point(604, 269);
            cboSalarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboSalarios.Name = "cboSalarios";
            cboSalarios.Size = new System.Drawing.Size(167, 32);
            cboSalarios.TabIndex = 64;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(616, 224);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 24);
            label4.TabIndex = 63;
            label4.Text = "Salarios:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(264, 160);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(123, 24);
            label3.TabIndex = 62;
            label3.Text = "Contrato hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpHasta.CustomFormat = "yyyy-MM-dd";
            dtpHasta.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpHasta.Location = new System.Drawing.Point(382, 147);
            dtpHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new System.Drawing.Size(159, 38);
            dtpHasta.TabIndex = 61;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(275, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 48);
            label2.TabIndex = 60;
            label2.Text = "Contrato a\r\npartir de:";
            // 
            // dtpDesde
            // 
            dtpDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpDesde.CustomFormat = "yyyy-MM-dd";
            dtpDesde.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDesde.Location = new System.Drawing.Point(361, 52);
            dtpDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new System.Drawing.Size(159, 38);
            dtpDesde.TabIndex = 59;
            // 
            // cboNacionalidades
            // 
            cboNacionalidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboNacionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboNacionalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboNacionalidades.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cboNacionalidades.FormattingEnabled = true;
            cboNacionalidades.Location = new System.Drawing.Point(441, 213);
            cboNacionalidades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboNacionalidades.Name = "cboNacionalidades";
            cboNacionalidades.Size = new System.Drawing.Size(167, 32);
            cboNacionalidades.TabIndex = 58;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(331, 217);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 24);
            label1.TabIndex = 57;
            label1.Text = "Nacionalidad:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboEmpleados
            // 
            cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new System.Drawing.Point(97, 217);
            cboEmpleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new System.Drawing.Size(227, 32);
            cboEmpleados.TabIndex = 56;
            // 
            // lblEmpleado
            // 
            lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEmpleado.ForeColor = System.Drawing.Color.Black;
            lblEmpleado.Location = new System.Drawing.Point(4, 217);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new System.Drawing.Size(89, 24);
            lblEmpleado.TabIndex = 55;
            lblEmpleado.Text = "Empleado:";
            lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnActualizar.BackColor = System.Drawing.Color.Snow;
            btnActualizar.BackgroundColor = System.Drawing.Color.Snow;
            btnActualizar.BorderColor = System.Drawing.Color.Lime;
            btnActualizar.BorderRadius = 40;
            btnActualizar.BorderSize = 0;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.Color.Lime;
            btnActualizar.Location = new System.Drawing.Point(441, 261);
            btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(134, 53);
            btnActualizar.TabIndex = 54;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextColor = System.Drawing.Color.Lime;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnEliminar.BackColor = System.Drawing.Color.Snow;
            btnEliminar.BackgroundColor = System.Drawing.Color.Snow;
            btnEliminar.BorderColor = System.Drawing.Color.Red;
            btnEliminar.BorderRadius = 40;
            btnEliminar.BorderSize = 0;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.ForeColor = System.Drawing.Color.Red;
            btnEliminar.Location = new System.Drawing.Point(274, 260);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(134, 53);
            btnEliminar.TabIndex = 53;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextColor = System.Drawing.Color.Red;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnRegistrar.BackColor = System.Drawing.Color.Snow;
            btnRegistrar.BackgroundColor = System.Drawing.Color.Snow;
            btnRegistrar.BorderColor = System.Drawing.Color.RoyalBlue;
            btnRegistrar.BorderRadius = 40;
            btnRegistrar.BorderSize = 0;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrar.ForeColor = System.Drawing.Color.RoyalBlue;
            btnRegistrar.Location = new System.Drawing.Point(119, 260);
            btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(134, 53);
            btnRegistrar.TabIndex = 52;
            btnRegistrar.Text = "Insertar";
            btnRegistrar.TextColor = System.Drawing.Color.RoyalBlue;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtEmpresa.BackColor = System.Drawing.Color.White;
            txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtEmpresa.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtEmpresa.Location = new System.Drawing.Point(97, 155);
            txtEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new System.Drawing.Size(160, 31);
            txtEmpresa.TabIndex = 51;
            // 
            // lblNIT
            // 
            lblNIT.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblNIT.AutoSize = true;
            lblNIT.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNIT.ForeColor = System.Drawing.Color.Black;
            lblNIT.Location = new System.Drawing.Point(4, 108);
            lblNIT.Name = "lblNIT";
            lblNIT.Size = new System.Drawing.Size(84, 72);
            lblNIT.TabIndex = 50;
            lblNIT.Text = "Nombre\r\nde \r\nempresa: ";
            lblNIT.Click += lblNIT_Click;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFecha.ForeColor = System.Drawing.Color.Black;
            lblFecha.Location = new System.Drawing.Point(4, 15);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(67, 72);
            lblFecha.TabIndex = 49;
            lblFecha.Text = "Fecha\r\nde\r\ningreso:";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            dtpFecha.CustomFormat = "yyyy-MM-dd";
            dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFecha.Location = new System.Drawing.Point(97, 49);
            dtpFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(159, 38);
            dtpFecha.TabIndex = 48;
            // 
            // dgvContrato
            // 
            dgvContrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvContrato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContrato.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvContrato.Location = new System.Drawing.Point(3, 332);
            dgvContrato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvContrato.MultiSelect = false;
            dgvContrato.Name = "dgvContrato";
            dgvContrato.ReadOnly = true;
            dgvContrato.RowHeadersVisible = false;
            dgvContrato.RowHeadersWidth = 51;
            dgvContrato.RowTemplate.Height = 25;
            dgvContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvContrato.Size = new System.Drawing.Size(776, 232);
            dgvContrato.TabIndex = 1;
            dgvContrato.CellContentClick += dgvContrato_CellContentClick;
            // 
            // errorContrato
            // 
            errorContrato.ContainerControl = this;
            // 
            // Contrato
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.PaleTurquoise;
            ClientSize = new System.Drawing.Size(782, 568);
            Controls.Add(PanelDivisor);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Contrato";
            Text = "Contrato";
            Load += Contrato_Load;
            PanelDivisor.ResumeLayout(false);
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContrato).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorContrato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.DataGridView dgvContrato;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblNIT;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnRegistrar;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboNacionalidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSalarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.TextBox txtClausulas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorContrato;
    }
}