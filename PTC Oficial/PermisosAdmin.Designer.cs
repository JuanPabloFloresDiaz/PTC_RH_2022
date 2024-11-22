namespace PTC_Oficial
{
    partial class PermisosAdmin
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
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.PanelDiv1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirmar = new PTC_Oficial.BotonEsquinaRedonda();
            this.PanelCampos = new System.Windows.Forms.TableLayoutPanel();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.errorPermisos = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.PanelDivisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.PanelDiv1.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            this.PanelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.PanelDivisor);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 1;
            // 
            // PanelDivisor
            // 
            this.PanelDivisor.ColumnCount = 1;
            this.PanelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Controls.Add(this.dgvPermisos, 0, 1);
            this.PanelDivisor.Controls.Add(this.PanelDiv1, 0, 0);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 2;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 1;
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermisos.Location = new System.Drawing.Point(3, 216);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.ReadOnly = true;
            this.dgvPermisos.RowHeadersVisible = false;
            this.dgvPermisos.RowTemplate.Height = 25;
            this.dgvPermisos.Size = new System.Drawing.Size(678, 207);
            this.dgvPermisos.TabIndex = 1;
            this.dgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellContentClick);
            // 
            // PanelDiv1
            // 
            this.PanelDiv1.ColumnCount = 1;
            this.PanelDiv1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDiv1.Controls.Add(this.PanelBotones, 0, 1);
            this.PanelDiv1.Controls.Add(this.PanelCampos, 0, 0);
            this.PanelDiv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDiv1.Location = new System.Drawing.Point(3, 3);
            this.PanelDiv1.Name = "PanelDiv1";
            this.PanelDiv1.RowCount = 2;
            this.PanelDiv1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDiv1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDiv1.Size = new System.Drawing.Size(678, 207);
            this.PanelDiv1.TabIndex = 2;
            // 
            // PanelBotones
            // 
            this.PanelBotones.ColumnCount = 1;
            this.PanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelBotones.Controls.Add(this.btnConfirmar, 0, 0);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBotones.Location = new System.Drawing.Point(3, 106);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.RowCount = 1;
            this.PanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelBotones.Size = new System.Drawing.Size(672, 98);
            this.PanelBotones.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.BackColor = System.Drawing.Color.Snow;
            this.btnConfirmar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnConfirmar.BorderColor = System.Drawing.Color.Lime;
            this.btnConfirmar.BorderRadius = 40;
            this.btnConfirmar.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.Lime;
            this.btnConfirmar.Location = new System.Drawing.Point(213, 29);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(246, 40);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.Lime;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // PanelCampos
            // 
            this.PanelCampos.ColumnCount = 2;
            this.PanelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelCampos.Controls.Add(this.cboEstatus, 0, 0);
            this.PanelCampos.Controls.Add(this.lblEstatus, 0, 0);
            this.PanelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCampos.Location = new System.Drawing.Point(3, 3);
            this.PanelCampos.Name = "PanelCampos";
            this.PanelCampos.RowCount = 1;
            this.PanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelCampos.Size = new System.Drawing.Size(672, 97);
            this.PanelCampos.TabIndex = 1;
            // 
            // cboEstatus
            // 
            this.cboEstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(339, 34);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(330, 28);
            this.cboEstatus.TabIndex = 49;
            // 
            // lblEstatus
            // 
            this.lblEstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblEstatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstatus.ForeColor = System.Drawing.Color.Black;
            this.lblEstatus.Location = new System.Drawing.Point(102, 38);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(132, 20);
            this.lblEstatus.TabIndex = 48;
            this.lblEstatus.Text = "Estatus del permiso:";
            this.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorPermisos
            // 
            this.errorPermisos.ContainerControl = this;
            // 
            // PermisosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PermisosAdmin";
            this.Text = "PermisosAdmin";
            this.Load += new System.EventHandler(this.PermisosAdmin_Load);
            this.panelContenedor.ResumeLayout(false);
            this.PanelDivisor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.PanelDiv1.ResumeLayout(false);
            this.PanelBotones.ResumeLayout(false);
            this.PanelCampos.ResumeLayout(false);
            this.PanelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.TableLayoutPanel PanelDiv1;
        private System.Windows.Forms.TableLayoutPanel PanelBotones;
        private System.Windows.Forms.TableLayoutPanel PanelCampos;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.ComboBox cboEstatus;
        private BotonEsquinaRedonda btnConfirmar;
        private System.Windows.Forms.ErrorProvider errorPermisos;
    }
}