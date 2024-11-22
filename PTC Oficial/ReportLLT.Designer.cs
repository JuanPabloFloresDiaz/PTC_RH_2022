namespace PTC_Oficial
{
    partial class ReportLLT
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
            this.reportViewerlLlegadatarde = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerlLlegadatarde
            // 
            this.reportViewerlLlegadatarde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerlLlegadatarde.LocalReport.ReportEmbeddedResource = "PTC_Oficial.ReporteLlegadaTar.rdlc";
            this.reportViewerlLlegadatarde.Location = new System.Drawing.Point(0, 0);
            this.reportViewerlLlegadatarde.Name = "ReportViewer";
            this.reportViewerlLlegadatarde.ServerReport.BearerToken = null;
            this.reportViewerlLlegadatarde.Size = new System.Drawing.Size(677, 426);
            this.reportViewerlLlegadatarde.TabIndex = 0;
            // 
            // ReportLLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(677, 426);
            this.Controls.Add(this.reportViewerlLlegadatarde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportLLT";
            this.Text = "ReportLLT";
            this.Load += new System.EventHandler(this.ReportLLT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerlLlegadatarde;
    }
}