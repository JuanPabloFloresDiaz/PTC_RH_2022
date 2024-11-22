namespace PTC_Oficial
{
    partial class Nomina
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
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnRegistrar = new PTC_Oficial.BotonEsquinaRedonda();
            this.cboSalario = new System.Windows.Forms.ComboBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.cboEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtAguinaldo = new System.Windows.Forms.TextBox();
            this.lblAguinaldo = new System.Windows.Forms.Label();
            this.dgvNominas = new System.Windows.Forms.DataGridView();
            this.errorNomina = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelDivisor.SuspendLayout();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(290, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(101, 29);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Nomina";
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 1;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.panelCampos, 0, 0);
            this.PanelDivisor.Controls.Add(this.dgvNominas, 0, 1);
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
            this.panelCampos.Controls.Add(this.btnActualizar);
            this.panelCampos.Controls.Add(this.btnEliminar);
            this.panelCampos.Controls.Add(this.btnRegistrar);
            this.panelCampos.Controls.Add(this.cboSalario);
            this.panelCampos.Controls.Add(this.lblSalario);
            this.panelCampos.Controls.Add(this.cboEmpleados);
            this.panelCampos.Controls.Add(this.lblEmpleado);
            this.panelCampos.Controls.Add(this.txtAguinaldo);
            this.panelCampos.Controls.Add(this.lblAguinaldo);
            this.panelCampos.Controls.Add(this.lblTitulo);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(3, 3);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(678, 207);
            this.panelCampos.TabIndex = 0;
            this.panelCampos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCampos_Paint);
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
            this.btnActualizar.Location = new System.Drawing.Point(426, 148);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 40);
            this.btnActualizar.TabIndex = 75;
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
            this.btnEliminar.Location = new System.Drawing.Point(280, 150);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 40);
            this.btnEliminar.TabIndex = 74;
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
            this.btnRegistrar.Location = new System.Drawing.Point(144, 150);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 40);
            this.btnRegistrar.TabIndex = 73;
            this.btnRegistrar.Text = "Insertar";
            this.btnRegistrar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboSalario
            // 
            this.cboSalario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSalario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSalario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboSalario.FormattingEnabled = true;
            this.cboSalario.Location = new System.Drawing.Point(90, 69);
            this.cboSalario.Name = "cboSalario";
            this.cboSalario.Size = new System.Drawing.Size(585, 28);
            this.cboSalario.TabIndex = 72;
            // 
            // lblSalario
            // 
            this.lblSalario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.ForeColor = System.Drawing.Color.Black;
            this.lblSalario.Location = new System.Drawing.Point(20, 77);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(54, 20);
            this.lblSalario.TabIndex = 71;
            this.lblSalario.Text = "Salario:";
            this.lblSalario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboEmpleados
            // 
            this.cboEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEmpleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEmpleados.FormattingEnabled = true;
            this.cboEmpleados.Location = new System.Drawing.Point(90, 35);
            this.cboEmpleados.Name = "cboEmpleados";
            this.cboEmpleados.Size = new System.Drawing.Size(585, 28);
            this.cboEmpleados.TabIndex = 70;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(9, 38);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(75, 20);
            this.lblEmpleado.TabIndex = 69;
            this.lblEmpleado.Text = "Empleado:";
            this.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAguinaldo
            // 
            this.txtAguinaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAguinaldo.BackColor = System.Drawing.Color.White;
            this.txtAguinaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAguinaldo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAguinaldo.Location = new System.Drawing.Point(90, 112);
            this.txtAguinaldo.Multiline = true;
            this.txtAguinaldo.Name = "txtAguinaldo";
            this.txtAguinaldo.Size = new System.Drawing.Size(171, 24);
            this.txtAguinaldo.TabIndex = 56;
            this.txtAguinaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAguinaldo_KeyPress);
            // 
            // lblAguinaldo
            // 
            this.lblAguinaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAguinaldo.AutoSize = true;
            this.lblAguinaldo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAguinaldo.ForeColor = System.Drawing.Color.Black;
            this.lblAguinaldo.Location = new System.Drawing.Point(20, 116);
            this.lblAguinaldo.Name = "lblAguinaldo";
            this.lblAguinaldo.Size = new System.Drawing.Size(73, 20);
            this.lblAguinaldo.TabIndex = 55;
            this.lblAguinaldo.Text = "Aguinaldo:";
            // 
            // dgvNominas
            // 
            this.dgvNominas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNominas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNominas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNominas.Location = new System.Drawing.Point(3, 216);
            this.dgvNominas.MultiSelect = false;
            this.dgvNominas.Name = "dgvNominas";
            this.dgvNominas.ReadOnly = true;
            this.dgvNominas.RowHeadersVisible = false;
            this.dgvNominas.RowTemplate.Height = 25;
            this.dgvNominas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNominas.Size = new System.Drawing.Size(678, 207);
            this.dgvNominas.TabIndex = 1;
            this.dgvNominas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNominas_CellContentClick);
            // 
            // errorNomina
            // 
            this.errorNomina.ContainerControl = this;
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.PanelDivisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nomina";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_Load);
            this.PanelDivisor.ResumeLayout(false);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.DataGridView dgvNominas;
        private System.Windows.Forms.TextBox txtAguinaldo;
        private System.Windows.Forms.Label lblAguinaldo;
        private System.Windows.Forms.ComboBox cboSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.ComboBox cboEmpleados;
        private System.Windows.Forms.Label lblEmpleado;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnRegistrar;
        private System.Windows.Forms.ErrorProvider errorNomina;
    }
}