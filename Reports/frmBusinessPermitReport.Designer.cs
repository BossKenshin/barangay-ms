
namespace plths.Business
{
    partial class frmBusinessPermitReport
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
            this.bnPermitReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // bnPermitReport
            // 
            this.bnPermitReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnPermitReport.LocalReport.ReportEmbeddedResource = "plths.Business.business_permit.rdlc";
            this.bnPermitReport.Location = new System.Drawing.Point(0, 0);
            this.bnPermitReport.Name = "bnPermitReport";
            this.bnPermitReport.ServerReport.BearerToken = null;
            this.bnPermitReport.Size = new System.Drawing.Size(800, 450);
            this.bnPermitReport.TabIndex = 0;
            // 
            // frmBusinessPermitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnPermitReport);
            this.Name = "frmBusinessPermitReport";
            this.Text = "frmBusinessPermitReport";
            this.Load += new System.EventHandler(this.frmBusinessPermitReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer bnPermitReport;
    }
}