namespace PTC_Oficial
{
    partial class HorarioEmpleado
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
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errorHorario = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Location = new System.Drawing.Point(12, 51);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.RowHeadersVisible = false;
            this.dgvHorario.RowTemplate.Height = 25;
            this.dgvHorario.Size = new System.Drawing.Size(660, 363);
            this.dgvHorario.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(274, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Horario";
            // 
            // errorHorario
            // 
            this.errorHorario.ContainerControl = this;
            // 
            // HorarioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HorarioEmpleado";
            this.Text = "HorarioEmpleado";
            this.Load += new System.EventHandler(this.HorarioEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errorHorario;
    }
}