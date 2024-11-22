namespace PTC_Oficial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelBarradetitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pbar = new CircularProgressBar_NET5.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarradetitulo
            // 
            this.panelBarradetitulo.BackColor = System.Drawing.Color.Gray;
            this.panelBarradetitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarradetitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarradetitulo.Name = "panelBarradetitulo";
            this.panelBarradetitulo.Size = new System.Drawing.Size(984, 55);
            this.panelBarradetitulo.TabIndex = 0;
            this.panelBarradetitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarradetitulo_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Turquoise;
            this.panelContenedor.Controls.Add(this.pbar);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 55);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(984, 506);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pbar
            // 
            this.pbar.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            this.pbar.AnimationSpeed = 500;
            this.pbar.BackColor = System.Drawing.Color.Transparent;
            this.pbar.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pbar.ForeColor = System.Drawing.Color.Teal;
            this.pbar.InnerColor = System.Drawing.Color.Turquoise;
            this.pbar.InnerMargin = 2;
            this.pbar.InnerWidth = -1;
            this.pbar.Location = new System.Drawing.Point(323, 67);
            this.pbar.MarqueeAnimationSpeed = 2000;
            this.pbar.Name = "pbar";
            this.pbar.OuterColor = System.Drawing.Color.MediumAquamarine;
            this.pbar.OuterMargin = -25;
            this.pbar.OuterWidth = 26;
            this.pbar.ProgressColor = System.Drawing.Color.Cyan;
            this.pbar.ProgressWidth = 25;
            this.pbar.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pbar.Size = new System.Drawing.Size(320, 320);
            this.pbar.StartAngle = 270;
            this.pbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbar.SubscriptText = "";
            this.pbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbar.SuperscriptText = "";
            this.pbar.TabIndex = 0;
            this.pbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarradetitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = " ";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarradetitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private CircularProgressBar_NET5.CircularProgressBar pbar;
        private System.Windows.Forms.Timer timer1;
    }
}
