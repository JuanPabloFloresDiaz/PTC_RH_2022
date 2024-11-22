namespace PTC_Oficial
{
    partial class AdelantosAdmin
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
            this.dgvAdelantos = new System.Windows.Forms.DataGridView();
            this.PanelDiv2 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirmar = new PTC_Oficial.BotonEsquinaRedonda();
            this.PanelDivCampos = new System.Windows.Forms.TableLayoutPanel();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.errorAdelantos = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.PanelDivisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).BeginInit();
            this.PanelDiv2.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            this.PanelDivCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdelantos)).BeginInit();
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
            this.PanelDivisor.Controls.Add(this.dgvAdelantos, 0, 1);
            this.PanelDivisor.Controls.Add(this.PanelDiv2, 0, 0);
            this.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivisor.Location = new System.Drawing.Point(0, 0);
            this.PanelDivisor.Name = "PanelDivisor";
            this.PanelDivisor.RowCount = 2;
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivisor.Size = new System.Drawing.Size(684, 426);
            this.PanelDivisor.TabIndex = 0;
            // 
            // dgvAdelantos
            // 
            this.dgvAdelantos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdelantos.Location = new System.Drawing.Point(3, 216);
            this.dgvAdelantos.Name = "dgvAdelantos";
            this.dgvAdelantos.ReadOnly = true;
            this.dgvAdelantos.RowHeadersVisible = false;
            this.dgvAdelantos.RowTemplate.Height = 25;
            this.dgvAdelantos.Size = new System.Drawing.Size(678, 207);
            this.dgvAdelantos.TabIndex = 1;
            this.dgvAdelantos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdelantos_CellContentClick);
            // 
            // PanelDiv2
            // 
            this.PanelDiv2.ColumnCount = 1;
            this.PanelDiv2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDiv2.Controls.Add(this.PanelBotones, 0, 1);
            this.PanelDiv2.Controls.Add(this.PanelDivCampos, 0, 0);
            this.PanelDiv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDiv2.Location = new System.Drawing.Point(3, 3);
            this.PanelDiv2.Name = "PanelDiv2";
            this.PanelDiv2.RowCount = 2;
            this.PanelDiv2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDiv2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDiv2.Size = new System.Drawing.Size(678, 207);
            this.PanelDiv2.TabIndex = 0;
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
            this.btnConfirmar.Location = new System.Drawing.Point(220, 29);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(231, 40);
            this.btnConfirmar.TabIndex = 29;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.Lime;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // PanelDivCampos
            // 
            this.PanelDivCampos.ColumnCount = 2;
            this.PanelDivCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivCampos.Controls.Add(this.cboEstatus, 0, 0);
            this.PanelDivCampos.Controls.Add(this.lblEstatus, 0, 0);
            this.PanelDivCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDivCampos.Location = new System.Drawing.Point(3, 3);
            this.PanelDivCampos.Name = "PanelDivCampos";
            this.PanelDivCampos.RowCount = 1;
            this.PanelDivCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDivCampos.Size = new System.Drawing.Size(672, 97);
            this.PanelDivCampos.TabIndex = 1;
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
            this.cboEstatus.TabIndex = 48;
            // 
            // lblEstatus
            // 
            this.lblEstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblEstatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstatus.ForeColor = System.Drawing.Color.Black;
            this.lblEstatus.Location = new System.Drawing.Point(101, 38);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(134, 20);
            this.lblEstatus.TabIndex = 47;
            this.lblEstatus.Text = "Estatus del adelanto:";
            this.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorAdelantos
            // 
            this.errorAdelantos.ContainerControl = this;
            // 
            // AdelantosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdelantosAdmin";
            this.Text = "AdelantosAdmin";
            this.Load += new System.EventHandler(this.AdelantosAdmin_Load);
            this.panelContenedor.ResumeLayout(false);
            this.PanelDivisor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).EndInit();
            this.PanelDiv2.ResumeLayout(false);
            this.PanelBotones.ResumeLayout(false);
            this.PanelDivCampos.ResumeLayout(false);
            this.PanelDivCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdelantos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TableLayoutPanel PanelDivisor;
        private System.Windows.Forms.TableLayoutPanel PanelDiv2;
        private System.Windows.Forms.TableLayoutPanel PanelBotones;
        private System.Windows.Forms.TableLayoutPanel PanelDivCampos;
        private System.Windows.Forms.DataGridView dgvAdelantos;
        private BotonEsquinaRedonda btnConfirmar;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.ErrorProvider errorAdelantos;
    }
}