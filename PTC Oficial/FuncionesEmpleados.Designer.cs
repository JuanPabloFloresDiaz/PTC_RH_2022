namespace PTC_Oficial
{
    partial class FuncionesEmpleados
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelObjetos = new System.Windows.Forms.Panel();
            this.PanelDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.btnCrearHorarios = new FontAwesome.Sharp.IconButton();
            this.btnPERMISOSEMPLEADOS = new FontAwesome.Sharp.IconButton();
            this.btnCrearSalarios = new FontAwesome.Sharp.IconButton();
            this.btnAdelantosEmpleados = new FontAwesome.Sharp.IconButton();
            this.panelContenedor.SuspendLayout();
            this.panelObjetos.SuspendLayout();
            this.PanelDivisor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelObjetos);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 1;
            // 
            // panelObjetos
            // 
            this.panelObjetos.Controls.Add(this.PanelDivisor);
            this.panelObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjetos.Location = new System.Drawing.Point(0, 0);
            this.panelObjetos.Name = "panelObjetos";
            this.panelObjetos.Size = new System.Drawing.Size(684, 426);
            this.panelObjetos.TabIndex = 1;
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 2;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.btnCrearHorarios, 1, 0);
            this.PanelDivisor.Controls.Add(this.btnPERMISOSEMPLEADOS, 1, 1);
            this.PanelDivisor.Controls.Add(this.btnCrearSalarios, 0, 0);
            this.PanelDivisor.Controls.Add(this.btnAdelantosEmpleados, 0, 1);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 2;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 0;
            // 
            // btnCrearHorarios
            // 
            this.btnCrearHorarios.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCrearHorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearHorarios.FlatAppearance.BorderSize = 0;
            this.btnCrearHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearHorarios.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearHorarios.ForeColor = System.Drawing.Color.White;
            this.btnCrearHorarios.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.btnCrearHorarios.IconColor = System.Drawing.Color.White;
            this.btnCrearHorarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearHorarios.Location = new System.Drawing.Point(345, 3);
            this.btnCrearHorarios.Name = "btnCrearHorarios";
            this.btnCrearHorarios.Size = new System.Drawing.Size(336, 207);
            this.btnCrearHorarios.TabIndex = 0;
            this.btnCrearHorarios.Text = "Horarios";
            this.btnCrearHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearHorarios.UseVisualStyleBackColor = false;
            this.btnCrearHorarios.Click += new System.EventHandler(this.btnCrearHorarios_Click);
            // 
            // btnPERMISOSEMPLEADOS
            // 
            this.btnPERMISOSEMPLEADOS.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPERMISOSEMPLEADOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPERMISOSEMPLEADOS.FlatAppearance.BorderSize = 0;
            this.btnPERMISOSEMPLEADOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPERMISOSEMPLEADOS.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPERMISOSEMPLEADOS.ForeColor = System.Drawing.Color.White;
            this.btnPERMISOSEMPLEADOS.IconChar = FontAwesome.Sharp.IconChar.HandDots;
            this.btnPERMISOSEMPLEADOS.IconColor = System.Drawing.Color.White;
            this.btnPERMISOSEMPLEADOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPERMISOSEMPLEADOS.Location = new System.Drawing.Point(345, 216);
            this.btnPERMISOSEMPLEADOS.Name = "btnPERMISOSEMPLEADOS";
            this.btnPERMISOSEMPLEADOS.Size = new System.Drawing.Size(336, 207);
            this.btnPERMISOSEMPLEADOS.TabIndex = 1;
            this.btnPERMISOSEMPLEADOS.Text = "Permisos empleados";
            this.btnPERMISOSEMPLEADOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPERMISOSEMPLEADOS.UseVisualStyleBackColor = false;
            this.btnPERMISOSEMPLEADOS.Click += new System.EventHandler(this.btnPERMISOSEMPLEADOS_Click);
            // 
            // btnCrearSalarios
            // 
            this.btnCrearSalarios.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCrearSalarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearSalarios.FlatAppearance.BorderSize = 0;
            this.btnCrearSalarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearSalarios.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearSalarios.ForeColor = System.Drawing.Color.White;
            this.btnCrearSalarios.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnCrearSalarios.IconColor = System.Drawing.Color.White;
            this.btnCrearSalarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearSalarios.Location = new System.Drawing.Point(3, 3);
            this.btnCrearSalarios.Name = "btnCrearSalarios";
            this.btnCrearSalarios.Size = new System.Drawing.Size(336, 207);
            this.btnCrearSalarios.TabIndex = 2;
            this.btnCrearSalarios.Text = "Salarios";
            this.btnCrearSalarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearSalarios.UseVisualStyleBackColor = false;
            this.btnCrearSalarios.Click += new System.EventHandler(this.btnCrearSalarios_Click);
            // 
            // btnAdelantosEmpleados
            // 
            this.btnAdelantosEmpleados.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnAdelantosEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdelantosEmpleados.FlatAppearance.BorderSize = 0;
            this.btnAdelantosEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdelantosEmpleados.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdelantosEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnAdelantosEmpleados.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnAdelantosEmpleados.IconColor = System.Drawing.Color.White;
            this.btnAdelantosEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdelantosEmpleados.Location = new System.Drawing.Point(3, 216);
            this.btnAdelantosEmpleados.Name = "btnAdelantosEmpleados";
            this.btnAdelantosEmpleados.Size = new System.Drawing.Size(336, 207);
            this.btnAdelantosEmpleados.TabIndex = 3;
            this.btnAdelantosEmpleados.Text = "Adelantos empleados";
            this.btnAdelantosEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdelantosEmpleados.UseVisualStyleBackColor = false;
            this.btnAdelantosEmpleados.Click += new System.EventHandler(this.btnAdelantosEmpleados_Click);
            // 
            // FuncionesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FuncionesEmpleados";
            this.Text = "FuncionesEmpleados";
            this.panelContenedor.ResumeLayout(false);
            this.panelObjetos.ResumeLayout(false);
            this.PanelDivisor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelObjetos;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private FontAwesome.Sharp.IconButton btnCrearHorarios;
        private FontAwesome.Sharp.IconButton btnPERMISOSEMPLEADOS;
        private FontAwesome.Sharp.IconButton btnCrearSalarios;
        private FontAwesome.Sharp.IconButton btnAdelantosEmpleados;
    }
}