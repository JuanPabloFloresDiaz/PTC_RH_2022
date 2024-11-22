namespace PTC_Oficial
{
    partial class Registrarse
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
            this.PanelDoble = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnEliminar = new PTC_Oficial.BotonEsquinaRedonda();
            this.btnRegistrar = new PTC_Oficial.BotonEsquinaRedonda();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.errorRegistro = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelDoble.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDoble
            // 
            this.PanelDoble.ColumnCount = 1;
            this.PanelDoble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDoble.Controls.Add(this.panelBotones, 0, 0);
            this.PanelDoble.Controls.Add(this.dgvUsuarios, 0, 1);
            this.PanelDoble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDoble.Location = new System.Drawing.Point(0, 0);
            this.PanelDoble.Name = "PanelDoble";
            this.PanelDoble.RowCount = 2;
            this.PanelDoble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDoble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelDoble.Size = new System.Drawing.Size(684, 426);
            this.PanelDoble.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelBotones.Controls.Add(this.pictureBox3);
            this.panelBotones.Controls.Add(this.pictureBox2);
            this.panelBotones.Controls.Add(this.pictureBox1);
            this.panelBotones.Controls.Add(this.pcbUsuario);
            this.panelBotones.Controls.Add(this.btnActualizar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnRegistrar);
            this.panelBotones.Controls.Add(this.cboTipoUsuario);
            this.panelBotones.Controls.Add(this.txtCorreo);
            this.panelBotones.Controls.Add(this.txtContraseña);
            this.panelBotones.Controls.Add(this.txtNombre);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Location = new System.Drawing.Point(3, 3);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(678, 207);
            this.panelBotones.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::PTC_Oficial.Properties.Resources.TIPOUSUARIO_removebg_preview;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(438, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 26);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PTC_Oficial.Properties.Resources.GMAIL2_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(438, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PTC_Oficial.Properties.Resources.contraseña_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(72, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pcbUsuario.BackgroundImage = global::PTC_Oficial.Properties.Resources.usuario_icon;
            this.pcbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbUsuario.Location = new System.Drawing.Point(72, 9);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(25, 26);
            this.pcbUsuario.TabIndex = 8;
            this.pcbUsuario.TabStop = false;
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
            this.btnActualizar.Location = new System.Drawing.Point(469, 155);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 40);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Lime;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(288, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.Red;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnRegistrar.Location = new System.Drawing.Point(95, 155);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 40);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipoUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(469, 85);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(148, 28);
            this.cboTipoUsuario.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(469, 9);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(148, 26);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.txtContraseña.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.Location = new System.Drawing.Point(95, 87);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(148, 26);
            this.txtContraseña.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(95, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 216);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(678, 207);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // errorRegistro
            // 
            this.errorRegistro.ContainerControl = this;
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.PanelDoble);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            this.PanelDoble.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelDoble;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private BotonEsquinaRedonda btnRegistrar;
        private BotonEsquinaRedonda btnActualizar;
        private BotonEsquinaRedonda btnEliminar;
        private System.Windows.Forms.ErrorProvider errorRegistro;
        private System.Windows.Forms.PictureBox pcbUsuario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}