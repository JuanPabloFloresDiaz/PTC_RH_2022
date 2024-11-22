namespace PTC_Oficial
{
    partial class OtrasFunciones
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
            this.PanelDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.btnFuncionesEmpleados = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnDatos = new PTC_Oficial.BotonEsquinaRedonda();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.PanelDivisor.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 2;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.btnFuncionesEmpleados, 1, 0);
            this.PanelDivisor.Controls.Add(this.btnDatos, 0, 0);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 1;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 0;
            // 
            // btnFuncionesEmpleados
            // 
            this.btnFuncionesEmpleados.BackColor = System.Drawing.Color.Blue;
            this.btnFuncionesEmpleados.BackgroundColor = System.Drawing.Color.Blue;
            this.btnFuncionesEmpleados.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFuncionesEmpleados.BorderRadius = 40;
            this.btnFuncionesEmpleados.BorderSize = 0;
            this.btnFuncionesEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFuncionesEmpleados.FlatAppearance.BorderSize = 0;
            this.btnFuncionesEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionesEmpleados.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFuncionesEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnFuncionesEmpleados.Location = new System.Drawing.Point(345, 3);
            this.btnFuncionesEmpleados.Name = "btnFuncionesEmpleados";
            this.btnFuncionesEmpleados.Size = new System.Drawing.Size(336, 420);
            this.btnFuncionesEmpleados.TabIndex = 2;
            this.btnFuncionesEmpleados.Text = "Crear funciones para empledos";
            this.btnFuncionesEmpleados.TextColor = System.Drawing.Color.White;
            this.btnFuncionesEmpleados.UseVisualStyleBackColor = false;
            this.btnFuncionesEmpleados.Click += new System.EventHandler(this.btnFuncionesEmpleados_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.BackColor = System.Drawing.Color.Green;
            this.btnDatos.BackgroundColor = System.Drawing.Color.Green;
            this.btnDatos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDatos.BorderRadius = 40;
            this.btnDatos.BorderSize = 0;
            this.btnDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatos.FlatAppearance.BorderSize = 0;
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatos.ForeColor = System.Drawing.Color.White;
            this.btnDatos.Location = new System.Drawing.Point(3, 3);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(336, 420);
            this.btnDatos.TabIndex = 1;
            this.btnDatos.Text = "Ingresar datos del empleado";
            this.btnDatos.TextColor = System.Drawing.Color.White;
            this.btnDatos.UseVisualStyleBackColor = false;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Controls.Add(this.PanelDivisor);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 1;
            // 
            // OtrasFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OtrasFunciones";
            this.Text = "OtrasFunciones";
            this.Load += new System.EventHandler(this.OtrasFunciones_Load);
            this.PanelDivisor.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private BotonEsquinaRedonda btnFuncionesEmpleados;
        private BotonEsquinaRedonda btnDatos;
        private System.Windows.Forms.Panel panelContenedor;
    }
}