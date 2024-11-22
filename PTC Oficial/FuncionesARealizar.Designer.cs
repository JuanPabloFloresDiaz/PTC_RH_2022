namespace PTC_Oficial
{
    partial class FuncionesARealizar
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
            this.panelDivisor = new System.Windows.Forms.TableLayoutPanel();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.panelObjetos = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnAgregar = new PTC_Oficial.BotonEsquinaRedonda();
            this.panelCampos = new System.Windows.Forms.TableLayoutPanel();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.lblFunciones = new System.Windows.Forms.Label();
            this.errorFunciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelDivisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.panelObjetos.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Controls.Add(this.panelDivisor);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 426);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelDivisor
            // 
            this.panelDivisor.ColumnCount = 1;
            this.panelDivisor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDivisor.Controls.Add(this.dgvFunciones, 0, 1);
            this.panelDivisor.Controls.Add(this.panelObjetos, 0, 0);
            this.panelDivisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDivisor.Location = new System.Drawing.Point(0, 0);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.RowCount = 2;
            this.panelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDivisor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDivisor.Size = new System.Drawing.Size(684, 426);
            this.panelDivisor.TabIndex = 0;
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFunciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFunciones.Location = new System.Drawing.Point(3, 216);
            this.dgvFunciones.MultiSelect = false;
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFunciones.RowTemplate.Height = 25;
            this.dgvFunciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunciones.Size = new System.Drawing.Size(678, 207);
            this.dgvFunciones.TabIndex = 0;
            this.dgvFunciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunciones_CellContentClick);
            // 
            // panelObjetos
            // 
            this.panelObjetos.ColumnCount = 1;
            this.panelObjetos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelObjetos.Controls.Add(this.panelBotones, 0, 1);
            this.panelObjetos.Controls.Add(this.panelCampos, 0, 0);
            this.panelObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjetos.Location = new System.Drawing.Point(3, 3);
            this.panelObjetos.Name = "panelObjetos";
            this.panelObjetos.RowCount = 2;
            this.panelObjetos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelObjetos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelObjetos.Size = new System.Drawing.Size(678, 207);
            this.panelObjetos.TabIndex = 1;
            // 
            // panelBotones
            // 
            this.panelBotones.ColumnCount = 3;
            this.panelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.panelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.panelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.panelBotones.Controls.Add(this.btnEliminar, 2, 0);
            this.panelBotones.Controls.Add(this.btnActualizar, 1, 0);
            this.panelBotones.Controls.Add(this.btnAgregar, 0, 0);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Location = new System.Drawing.Point(3, 106);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.RowCount = 1;
            this.panelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBotones.Size = new System.Drawing.Size(672, 98);
            this.panelBotones.TabIndex = 0;
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
            this.btnEliminar.Location = new System.Drawing.Point(467, 29);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(201, 40);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.Red;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnActualizar.Location = new System.Drawing.Point(236, 29);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(217, 40);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Lime;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.Snow;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.Snow;
            this.btnAgregar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.Location = new System.Drawing.Point(8, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(209, 40);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelCampos
            // 
            this.panelCampos.ColumnCount = 2;
            this.panelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCampos.Controls.Add(this.txtFuncion, 1, 0);
            this.panelCampos.Controls.Add(this.lblFunciones, 0, 0);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(3, 3);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.RowCount = 1;
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.panelCampos.Size = new System.Drawing.Size(672, 97);
            this.panelCampos.TabIndex = 1;
            // 
            // txtFuncion
            // 
            this.txtFuncion.BackColor = System.Drawing.Color.White;
            this.txtFuncion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFuncion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFuncion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFuncion.Location = new System.Drawing.Point(339, 3);
            this.txtFuncion.Multiline = true;
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(330, 91);
            this.txtFuncion.TabIndex = 26;
            // 
            // lblFunciones
            // 
            this.lblFunciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFunciones.AutoSize = true;
            this.lblFunciones.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFunciones.ForeColor = System.Drawing.Color.Black;
            this.lblFunciones.Location = new System.Drawing.Point(196, 38);
            this.lblFunciones.Name = "lblFunciones";
            this.lblFunciones.Size = new System.Drawing.Size(137, 20);
            this.lblFunciones.TabIndex = 14;
            this.lblFunciones.Text = "Funciones a realizar: ";
            // 
            // errorFunciones
            // 
            this.errorFunciones.ContainerControl = this;
            // 
            // FuncionesARealizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FuncionesARealizar";
            this.Text = "FuncionesARealizar";
            this.Load += new System.EventHandler(this.FuncionesARealizar_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelDivisor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.panelObjetos.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFunciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TableLayoutPanel panelDivisor;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.TableLayoutPanel panelObjetos;
        private System.Windows.Forms.TableLayoutPanel panelBotones;
        private System.Windows.Forms.TableLayoutPanel panelCampos;
        private System.Windows.Forms.Label lblFunciones;
        private System.Windows.Forms.TextBox txtFuncion;
        private BotonEsquinaRedonda btnAgregar;
        private BotonEsquinaRedonda btnEliminar;
        private BotonEsquinaRedonda btnActualizar;
        private System.Windows.Forms.ErrorProvider errorFunciones;
    }
}