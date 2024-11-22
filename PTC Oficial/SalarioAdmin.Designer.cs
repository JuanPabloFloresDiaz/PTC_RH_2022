namespace PTC_Oficial
{
    partial class SalarioAdmin
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
            this.dgvSalario = new System.Windows.Forms.DataGridView();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.pcbCotizaciones = new System.Windows.Forms.PictureBox();
            this.btnImagen = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnRegistrar = new PTC_Oficial.BotonEsquinaRedonda();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCotizaciones = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegistropago = new System.Windows.Forms.Label();
            this.lblSalarioNeto = new System.Windows.Forms.Label();
            this.lblSalariobruto = new System.Windows.Forms.Label();
            this.cboDescuento = new System.Windows.Forms.ComboBox();
            this.cboPago = new System.Windows.Forms.ComboBox();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtHorasextra = new System.Windows.Forms.TextBox();
            this.errorSalario = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.PanelDivisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalario)).BeginInit();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCotizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalario)).BeginInit();
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
            this.PanelDivisor.Controls.Add(this.dgvSalario, 0, 1);
            this.PanelDivisor.Controls.Add(this.panelCampos, 0, 0);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 2;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 5;
            // 
            // dgvSalario
            // 
            this.dgvSalario.AllowUserToAddRows = false;
            this.dgvSalario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalario.Location = new System.Drawing.Point(3, 216);
            this.dgvSalario.Name = "dgvSalario";
            this.dgvSalario.ReadOnly = true;
            this.dgvSalario.RowHeadersVisible = false;
            this.dgvSalario.RowTemplate.Height = 25;
            this.dgvSalario.Size = new System.Drawing.Size(678, 207);
            this.dgvSalario.TabIndex = 4;
            this.dgvSalario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalario_CellContentClick);
            this.dgvSalario.DoubleClick += new System.EventHandler(this.dgvSalario_DoubleClick);
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.pcbCotizaciones);
            this.panelCampos.Controls.Add(this.btnImagen);
            this.panelCampos.Controls.Add(this.btnActualizar);
            this.panelCampos.Controls.Add(this.btnEliminar);
            this.panelCampos.Controls.Add(this.btnRegistrar);
            this.panelCampos.Controls.Add(this.label5);
            this.panelCampos.Controls.Add(this.lblCotizaciones);
            this.panelCampos.Controls.Add(this.label3);
            this.panelCampos.Controls.Add(this.lblRegistropago);
            this.panelCampos.Controls.Add(this.lblSalarioNeto);
            this.panelCampos.Controls.Add(this.lblSalariobruto);
            this.panelCampos.Controls.Add(this.cboDescuento);
            this.panelCampos.Controls.Add(this.cboPago);
            this.panelCampos.Controls.Add(this.txtSalarioNeto);
            this.panelCampos.Controls.Add(this.txtSalarioBruto);
            this.panelCampos.Controls.Add(this.txtHorasextra);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(3, 3);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(678, 207);
            this.panelCampos.TabIndex = 5;
            // 
            // pcbCotizaciones
            // 
            this.pcbCotizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbCotizaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbCotizaciones.Location = new System.Drawing.Point(524, 9);
            this.pcbCotizaciones.Name = "pcbCotizaciones";
            this.pcbCotizaciones.Size = new System.Drawing.Size(145, 149);
            this.pcbCotizaciones.TabIndex = 48;
            this.pcbCotizaciones.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImagen.BackColor = System.Drawing.Color.Purple;
            this.btnImagen.BackgroundColor = System.Drawing.Color.Purple;
            this.btnImagen.BorderColor = System.Drawing.Color.Lime;
            this.btnImagen.BorderRadius = 40;
            this.btnImagen.BorderSize = 0;
            this.btnImagen.FlatAppearance.BorderSize = 0;
            this.btnImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.ForeColor = System.Drawing.Color.Yellow;
            this.btnImagen.Location = new System.Drawing.Point(524, 164);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(132, 40);
            this.btnImagen.TabIndex = 47;
            this.btnImagen.Text = "Seleccionar imagen";
            this.btnImagen.TextColor = System.Drawing.Color.Yellow;
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
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
            this.btnActualizar.Location = new System.Drawing.Point(343, 164);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(132, 40);
            this.btnActualizar.TabIndex = 46;
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
            this.btnEliminar.Location = new System.Drawing.Point(181, 164);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 40);
            this.btnEliminar.TabIndex = 45;
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
            this.btnRegistrar.Location = new System.Drawing.Point(8, 164);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 40);
            this.btnRegistrar.TabIndex = 44;
            this.btnRegistrar.Text = "Insertar";
            this.btnRegistrar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Descuento: ";
            // 
            // lblCotizaciones
            // 
            this.lblCotizaciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCotizaciones.AutoSize = true;
            this.lblCotizaciones.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCotizaciones.ForeColor = System.Drawing.Color.Black;
            this.lblCotizaciones.Location = new System.Drawing.Point(414, 7);
            this.lblCotizaciones.Name = "lblCotizaciones";
            this.lblCotizaciones.Size = new System.Drawing.Size(104, 40);
            this.lblCotizaciones.TabIndex = 42;
            this.lblCotizaciones.Text = "Imagen con las \r\ncotizaciones: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Horas extra: ";
            // 
            // lblRegistropago
            // 
            this.lblRegistropago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistropago.AutoSize = true;
            this.lblRegistropago.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistropago.ForeColor = System.Drawing.Color.Black;
            this.lblRegistropago.Location = new System.Drawing.Point(299, 83);
            this.lblRegistropago.Name = "lblRegistropago";
            this.lblRegistropago.Size = new System.Drawing.Size(113, 40);
            this.lblRegistropago.TabIndex = 40;
            this.lblRegistropago.Text = "Empleado y su\r\nregistro de pago:";
            // 
            // lblSalarioNeto
            // 
            this.lblSalarioNeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalarioNeto.AutoSize = true;
            this.lblSalarioNeto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalarioNeto.ForeColor = System.Drawing.Color.Black;
            this.lblSalarioNeto.Location = new System.Drawing.Point(5, 45);
            this.lblSalarioNeto.Name = "lblSalarioNeto";
            this.lblSalarioNeto.Size = new System.Drawing.Size(84, 20);
            this.lblSalarioNeto.TabIndex = 39;
            this.lblSalarioNeto.Text = "Salario neto:";
            // 
            // lblSalariobruto
            // 
            this.lblSalariobruto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalariobruto.AutoSize = true;
            this.lblSalariobruto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalariobruto.ForeColor = System.Drawing.Color.Black;
            this.lblSalariobruto.Location = new System.Drawing.Point(3, 3);
            this.lblSalariobruto.Name = "lblSalariobruto";
            this.lblSalariobruto.Size = new System.Drawing.Size(88, 20);
            this.lblSalariobruto.TabIndex = 38;
            this.lblSalariobruto.Text = "Salario bruto:";
            // 
            // cboDescuento
            // 
            this.cboDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDescuento.FormattingEnabled = true;
            this.cboDescuento.Location = new System.Drawing.Point(94, 126);
            this.cboDescuento.Name = "cboDescuento";
            this.cboDescuento.Size = new System.Drawing.Size(188, 23);
            this.cboDescuento.TabIndex = 37;
            // 
            // cboPago
            // 
            this.cboPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPago.FormattingEnabled = true;
            this.cboPago.Location = new System.Drawing.Point(331, 126);
            this.cboPago.Name = "cboPago";
            this.cboPago.Size = new System.Drawing.Size(188, 23);
            this.cboPago.TabIndex = 36;
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalarioNeto.BackColor = System.Drawing.Color.White;
            this.txtSalarioNeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalarioNeto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSalarioNeto.Location = new System.Drawing.Point(93, 45);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.Size = new System.Drawing.Size(188, 25);
            this.txtSalarioNeto.TabIndex = 35;
            this.txtSalarioNeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioNeto_KeyPress);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalarioBruto.BackColor = System.Drawing.Color.White;
            this.txtSalarioBruto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalarioBruto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSalarioBruto.Location = new System.Drawing.Point(93, 3);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(188, 25);
            this.txtSalarioBruto.TabIndex = 33;
            this.txtSalarioBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioBruto_KeyPress);
            // 
            // txtHorasextra
            // 
            this.txtHorasextra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHorasextra.BackColor = System.Drawing.Color.White;
            this.txtHorasextra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorasextra.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHorasextra.Location = new System.Drawing.Point(93, 87);
            this.txtHorasextra.Name = "txtHorasextra";
            this.txtHorasextra.Size = new System.Drawing.Size(188, 25);
            this.txtHorasextra.TabIndex = 32;
            this.txtHorasextra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasextra_KeyPress);
            // 
            // errorSalario
            // 
            this.errorSalario.ContainerControl = this;
            // 
            // SalarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalarioAdmin";
            this.Text = "SalarioAdmin";
            this.Load += new System.EventHandler(this.SalarioAdmin_Load);
            this.panelContenedor.ResumeLayout(false);
            this.PanelDivisor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalario)).EndInit();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCotizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.DataGridView dgvSalario;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtHorasextra;
        private System.Windows.Forms.ComboBox cboDescuento;
        private System.Windows.Forms.ComboBox cboPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCotizaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRegistropago;
        private System.Windows.Forms.Label lblSalarioNeto;
        private System.Windows.Forms.Label lblSalariobruto;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnRegistrar;
        private System.Windows.Forms.PictureBox pcbCotizaciones;
        private BotonEsquinaRedonda btnImagen;
        private System.Windows.Forms.ErrorProvider errorSalario;
    }
}