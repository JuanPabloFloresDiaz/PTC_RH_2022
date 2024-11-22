namespace PTC_Oficial
{
    partial class DatosEmpleado
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
            this.btnDocumentos = new FontAwesome.Sharp.IconButton();
            this.btnDatosEmpleados = new FontAwesome.Sharp.IconButton();
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
            this.panelContenedor.TabIndex = 0;
            // 
            // panelObjetos
            // 
            this.panelObjetos.Controls.Add(this.PanelDivisor);
            this.panelObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjetos.Location = new System.Drawing.Point(0, 0);
            this.panelObjetos.Name = "panelObjetos";
            this.panelObjetos.Size = new System.Drawing.Size(684, 426);
            this.panelObjetos.TabIndex = 0;
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 2;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.btnDocumentos, 1, 0);
            this.PanelDivisor.Controls.Add(this.btnDatosEmpleados, 0, 0);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 1;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 0;
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDocumentos.ForeColor = System.Drawing.Color.White;
            this.btnDocumentos.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnDocumentos.IconColor = System.Drawing.Color.White;
            this.btnDocumentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocumentos.Location = new System.Drawing.Point(345, 3);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(336, 420);
            this.btnDocumentos.TabIndex = 0;
            this.btnDocumentos.Text = "Documentos de empleado";
            this.btnDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocumentos.UseVisualStyleBackColor = false;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // btnDatosEmpleados
            // 
            this.btnDatosEmpleados.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDatosEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatosEmpleados.FlatAppearance.BorderSize = 0;
            this.btnDatosEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosEmpleados.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatosEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnDatosEmpleados.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnDatosEmpleados.IconColor = System.Drawing.Color.White;
            this.btnDatosEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatosEmpleados.Location = new System.Drawing.Point(3, 3);
            this.btnDatosEmpleados.Name = "btnDatosEmpleados";
            this.btnDatosEmpleados.Size = new System.Drawing.Size(336, 420);
            this.btnDatosEmpleados.TabIndex = 1;
            this.btnDatosEmpleados.Text = "Registro de datos del empleado";
            this.btnDatosEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatosEmpleados.UseVisualStyleBackColor = false;
            this.btnDatosEmpleados.Click += new System.EventHandler(this.btnDatosEmpleados_Click);
            // 
            // DatosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosEmpleado";
            this.Text = "DatosEmpleado";
            this.Load += new System.EventHandler(this.DatosEmpleado_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelObjetos.ResumeLayout(false);
            this.PanelDivisor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelObjetos;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private FontAwesome.Sharp.IconButton btnDocumentos;
        private FontAwesome.Sharp.IconButton btnDatosEmpleados;
    }
}