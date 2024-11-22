namespace PTC_Oficial
{
    partial class SalarioEmpleado
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
            this.dgvSalario = new System.Windows.Forms.DataGridView();
            this.errorSalario = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(278, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(93, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Salario";
            // 
            // dgvSalario
            // 
            this.dgvSalario.AllowUserToAddRows = false;
            this.dgvSalario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalario.Location = new System.Drawing.Point(12, 51);
            this.dgvSalario.Name = "dgvSalario";
            this.dgvSalario.ReadOnly = true;
            this.dgvSalario.RowHeadersVisible = false;
            this.dgvSalario.RowTemplate.Height = 25;
            this.dgvSalario.Size = new System.Drawing.Size(660, 363);
            this.dgvSalario.TabIndex = 3;
            // 
            // errorSalario
            // 
            this.errorSalario.ContainerControl = this;
            // 
            // SalarioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.dgvSalario);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalarioEmpleado";
            this.Text = "SalarioEmpleado";
            this.Load += new System.EventHandler(this.SalarioEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvSalario;
        private System.Windows.Forms.ErrorProvider errorSalario;
    }
}