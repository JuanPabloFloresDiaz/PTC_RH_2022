namespace PTC_Oficial
{
    partial class CalculadoraAFPyISSS
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
            this.pcbIngresoBruto = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cboPor = new System.Windows.Forms.ComboBox();
            this.lblValorDeFecha = new System.Windows.Forms.Label();
            this.txtIngresoBruto = new System.Windows.Forms.TextBox();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pcbPagoNeto = new System.Windows.Forms.PictureBox();
            this.pcbImpuestos = new System.Windows.Forms.PictureBox();
            this.pcbRenta = new System.Windows.Forms.PictureBox();
            this.pcbAFP = new System.Windows.Forms.PictureBox();
            this.pcbISSS = new System.Windows.Forms.PictureBox();
            this.pcbSalario = new System.Windows.Forms.PictureBox();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.lblRenta = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtPagoNeto = new System.Windows.Forms.TextBox();
            this.txtImpuestoTotal = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.lblPagoNeto = new System.Windows.Forms.Label();
            this.lblImpuestosTotales = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblISSS = new System.Windows.Forms.Label();
            this.errorMATH = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIngresoBruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPagoNeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImpuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbISSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMATH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(180, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(262, 29);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Calculadora de AFP e ISSS";
            // 
            // pcbIngresoBruto
            // 
            this.pcbIngresoBruto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbIngresoBruto.BackColor = System.Drawing.Color.Transparent;
            this.pcbIngresoBruto.BackgroundImage = global::PTC_Oficial.Properties.Resources.vector_de_billetes_de_dolar;
            this.pcbIngresoBruto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbIngresoBruto.Location = new System.Drawing.Point(27, 120);
            this.pcbIngresoBruto.Name = "pcbIngresoBruto";
            this.pcbIngresoBruto.Size = new System.Drawing.Size(29, 32);
            this.pcbIngresoBruto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIngresoBruto.TabIndex = 17;
            this.pcbIngresoBruto.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcular.BackColor = System.Drawing.Color.Snow;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.Color.Blue;
            this.btnCalcular.Location = new System.Drawing.Point(372, 121);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(99, 30);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cboPor
            // 
            this.cboPor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPor.BackColor = System.Drawing.Color.White;
            this.cboPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPor.FormattingEnabled = true;
            this.cboPor.Location = new System.Drawing.Point(213, 121);
            this.cboPor.Name = "cboPor";
            this.cboPor.Size = new System.Drawing.Size(129, 30);
            this.cboPor.TabIndex = 15;
            // 
            // lblValorDeFecha
            // 
            this.lblValorDeFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorDeFecha.AutoSize = true;
            this.lblValorDeFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDeFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorDeFecha.Location = new System.Drawing.Point(219, 79);
            this.lblValorDeFecha.Name = "lblValorDeFecha";
            this.lblValorDeFecha.Size = new System.Drawing.Size(27, 16);
            this.lblValorDeFecha.TabIndex = 14;
            this.lblValorDeFecha.Text = "por";
            // 
            // txtIngresoBruto
            // 
            this.txtIngresoBruto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngresoBruto.BackColor = System.Drawing.Color.White;
            this.txtIngresoBruto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIngresoBruto.Location = new System.Drawing.Point(54, 121);
            this.txtIngresoBruto.Name = "txtIngresoBruto";
            this.txtIngresoBruto.Size = new System.Drawing.Size(129, 31);
            this.txtIngresoBruto.TabIndex = 13;
            this.txtIngresoBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresoBruto_KeyPress);
            // 
            // lblIngresar
            // 
            this.lblIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngresar.Location = new System.Drawing.Point(27, 79);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(156, 16);
            this.lblIngresar.TabIndex = 12;
            this.lblIngresar.Text = "Introduce tu ingreso bruto";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.BackColor = System.Drawing.Color.Snow;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.Color.Red;
            this.btnBorrar.Location = new System.Drawing.Point(512, 122);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(99, 30);
            this.btnBorrar.TabIndex = 34;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pcbPagoNeto
            // 
            this.pcbPagoNeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbPagoNeto.BackColor = System.Drawing.Color.Transparent;
            this.pcbPagoNeto.BackgroundImage = global::PTC_Oficial.Properties.Resources.vector_de_billetes_de_dolar;
            this.pcbPagoNeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbPagoNeto.Location = new System.Drawing.Point(194, 395);
            this.pcbPagoNeto.Name = "pcbPagoNeto";
            this.pcbPagoNeto.Size = new System.Drawing.Size(29, 27);
            this.pcbPagoNeto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPagoNeto.TabIndex = 52;
            this.pcbPagoNeto.TabStop = false;
            // 
            // pcbImpuestos
            // 
            this.pcbImpuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.pcbImpuestos.BackgroundImage = global::PTC_Oficial.Properties.Resources.vector_de_billetes_de_dolar;
            this.pcbImpuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImpuestos.Location = new System.Drawing.Point(194, 351);
            this.pcbImpuestos.Name = "pcbImpuestos";
            this.pcbImpuestos.Size = new System.Drawing.Size(29, 27);
            this.pcbImpuestos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImpuestos.TabIndex = 51;
            this.pcbImpuestos.TabStop = false;
            // 
            // pcbRenta
            // 
            this.pcbRenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbRenta.BackColor = System.Drawing.Color.Transparent;
            this.pcbRenta.BackgroundImage = global::PTC_Oficial.Properties.Resources.vector_de_billetes_de_dolar;
            this.pcbRenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbRenta.Location = new System.Drawing.Point(194, 307);
            this.pcbRenta.Name = "pcbRenta";
            this.pcbRenta.Size = new System.Drawing.Size(29, 27);
            this.pcbRenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRenta.TabIndex = 50;
            this.pcbRenta.TabStop = false;
            // 
            // pcbAFP
            // 
            this.pcbAFP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbAFP.BackColor = System.Drawing.Color.Transparent;
            this.pcbAFP.BackgroundImage = global::PTC_Oficial.Properties.Resources.vector_de_billetes_de_dolar;
            this.pcbAFP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbAFP.Location = new System.Drawing.Point(194, 263);
            this.pcbAFP.Name = "pcbAFP";
            this.pcbAFP.Size = new System.Drawing.Size(29, 27);
            this.pcbAFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAFP.TabIndex = 49;
            this.pcbAFP.TabStop = false;
            // 
            // pcbISSS
            // 
            this.pcbISSS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbISSS.BackColor = System.Drawing.Color.Transparent;
            this.pcbISSS.BackgroundImage = global::PTC_Oficial.Properties.Resources.vector_de_billetes_de_dolar;
            this.pcbISSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbISSS.Location = new System.Drawing.Point(194, 219);
            this.pcbISSS.Name = "pcbISSS";
            this.pcbISSS.Size = new System.Drawing.Size(29, 27);
            this.pcbISSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbISSS.TabIndex = 48;
            this.pcbISSS.TabStop = false;
            // 
            // pcbSalario
            // 
            this.pcbSalario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbSalario.BackColor = System.Drawing.Color.Transparent;
            this.pcbSalario.BackgroundImage = global::PTC_Oficial.Properties.Resources.vector_de_billetes_de_dolar;
            this.pcbSalario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbSalario.Location = new System.Drawing.Point(194, 175);
            this.pcbSalario.Name = "pcbSalario";
            this.pcbSalario.Size = new System.Drawing.Size(29, 27);
            this.pcbSalario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSalario.TabIndex = 47;
            this.pcbSalario.TabStop = false;
            // 
            // txtRenta
            // 
            this.txtRenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRenta.BackColor = System.Drawing.Color.White;
            this.txtRenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRenta.Location = new System.Drawing.Point(219, 307);
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.ReadOnly = true;
            this.txtRenta.Size = new System.Drawing.Size(129, 27);
            this.txtRenta.TabIndex = 46;
            // 
            // lblRenta
            // 
            this.lblRenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRenta.AutoSize = true;
            this.lblRenta.BackColor = System.Drawing.Color.Transparent;
            this.lblRenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblRenta.Location = new System.Drawing.Point(27, 313);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(127, 21);
            this.lblRenta.TabIndex = 45;
            this.lblRenta.Text = "Pago de renta:";
            // 
            // txtSalario
            // 
            this.txtSalario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalario.BackColor = System.Drawing.Color.White;
            this.txtSalario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalario.Location = new System.Drawing.Point(219, 175);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(129, 27);
            this.txtSalario.TabIndex = 44;
            // 
            // lblSalario
            // 
            this.lblSalario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.Location = new System.Drawing.Point(27, 178);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(61, 21);
            this.lblSalario.TabIndex = 43;
            this.lblSalario.Text = "Salario";
            // 
            // txtPagoNeto
            // 
            this.txtPagoNeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPagoNeto.BackColor = System.Drawing.Color.White;
            this.txtPagoNeto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPagoNeto.Location = new System.Drawing.Point(219, 395);
            this.txtPagoNeto.Name = "txtPagoNeto";
            this.txtPagoNeto.ReadOnly = true;
            this.txtPagoNeto.Size = new System.Drawing.Size(129, 27);
            this.txtPagoNeto.TabIndex = 42;
            // 
            // txtImpuestoTotal
            // 
            this.txtImpuestoTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImpuestoTotal.BackColor = System.Drawing.Color.White;
            this.txtImpuestoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtImpuestoTotal.Location = new System.Drawing.Point(219, 351);
            this.txtImpuestoTotal.Name = "txtImpuestoTotal";
            this.txtImpuestoTotal.ReadOnly = true;
            this.txtImpuestoTotal.Size = new System.Drawing.Size(129, 27);
            this.txtImpuestoTotal.TabIndex = 41;
            // 
            // txtAFP
            // 
            this.txtAFP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAFP.BackColor = System.Drawing.Color.White;
            this.txtAFP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAFP.Location = new System.Drawing.Point(219, 263);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.ReadOnly = true;
            this.txtAFP.Size = new System.Drawing.Size(129, 27);
            this.txtAFP.TabIndex = 40;
            // 
            // txtISSS
            // 
            this.txtISSS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtISSS.BackColor = System.Drawing.Color.White;
            this.txtISSS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtISSS.Location = new System.Drawing.Point(219, 219);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.ReadOnly = true;
            this.txtISSS.Size = new System.Drawing.Size(129, 27);
            this.txtISSS.TabIndex = 39;
            // 
            // lblPagoNeto
            // 
            this.lblPagoNeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPagoNeto.AutoSize = true;
            this.lblPagoNeto.BackColor = System.Drawing.Color.Transparent;
            this.lblPagoNeto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblPagoNeto.Location = new System.Drawing.Point(27, 401);
            this.lblPagoNeto.Name = "lblPagoNeto";
            this.lblPagoNeto.Size = new System.Drawing.Size(98, 21);
            this.lblPagoNeto.TabIndex = 38;
            this.lblPagoNeto.Text = "Pago Neto:";
            // 
            // lblImpuestosTotales
            // 
            this.lblImpuestosTotales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImpuestosTotales.AutoSize = true;
            this.lblImpuestosTotales.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuestosTotales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblImpuestosTotales.Location = new System.Drawing.Point(27, 357);
            this.lblImpuestosTotales.Name = "lblImpuestosTotales";
            this.lblImpuestosTotales.Size = new System.Drawing.Size(152, 21);
            this.lblImpuestosTotales.TabIndex = 37;
            this.lblImpuestosTotales.Text = "Impuestos totales:";
            // 
            // lblAFP
            // 
            this.lblAFP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAFP.AutoSize = true;
            this.lblAFP.BackColor = System.Drawing.Color.Transparent;
            this.lblAFP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAFP.Location = new System.Drawing.Point(27, 269);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(44, 21);
            this.lblAFP.TabIndex = 36;
            this.lblAFP.Text = "AFP:";
            // 
            // lblISSS
            // 
            this.lblISSS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblISSS.AutoSize = true;
            this.lblISSS.BackColor = System.Drawing.Color.Transparent;
            this.lblISSS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblISSS.Location = new System.Drawing.Point(27, 225);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(43, 21);
            this.lblISSS.TabIndex = 35;
            this.lblISSS.Text = "ISSS:";
            // 
            // errorMATH
            // 
            this.errorMATH.ContainerControl = this;
            // 
            // CalculadoraAFPyISSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.pcbPagoNeto);
            this.Controls.Add(this.pcbImpuestos);
            this.Controls.Add(this.pcbRenta);
            this.Controls.Add(this.pcbAFP);
            this.Controls.Add(this.pcbISSS);
            this.Controls.Add(this.pcbSalario);
            this.Controls.Add(this.txtRenta);
            this.Controls.Add(this.lblRenta);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtPagoNeto);
            this.Controls.Add(this.txtImpuestoTotal);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.lblPagoNeto);
            this.Controls.Add(this.lblImpuestosTotales);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.lblISSS);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.pcbIngresoBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboPor);
            this.Controls.Add(this.lblValorDeFecha);
            this.Controls.Add(this.txtIngresoBruto);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculadoraAFPyISSS";
            this.Text = "CalculadoraAFPyISSS";
            this.Load += new System.EventHandler(this.CalculadoraAFPyISSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIngresoBruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPagoNeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImpuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbISSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMATH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pcbIngresoBruto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cboPor;
        private System.Windows.Forms.Label lblValorDeFecha;
        private System.Windows.Forms.TextBox txtIngresoBruto;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pcbPagoNeto;
        private System.Windows.Forms.PictureBox pcbImpuestos;
        private System.Windows.Forms.PictureBox pcbRenta;
        private System.Windows.Forms.PictureBox pcbAFP;
        private System.Windows.Forms.PictureBox pcbISSS;
        private System.Windows.Forms.PictureBox pcbSalario;
        private System.Windows.Forms.TextBox txtRenta;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtPagoNeto;
        private System.Windows.Forms.TextBox txtImpuestoTotal;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.Label lblPagoNeto;
        private System.Windows.Forms.Label lblImpuestosTotales;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.Label lblISSS;
        private System.Windows.Forms.ErrorProvider errorMATH;
    }
}