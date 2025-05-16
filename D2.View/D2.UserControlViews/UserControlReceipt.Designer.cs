namespace _3_13_25.D2.View.D2.UserControlViews
{
    partial class UserControlReceipt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewerReceipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerReceipt
            // 
            this.reportViewerReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportViewerReceipt.Location = new System.Drawing.Point(26, 18);
            this.reportViewerReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewerReceipt.Name = "reportViewerReceipt";
            this.reportViewerReceipt.ServerReport.BearerToken = null;
            this.reportViewerReceipt.Size = new System.Drawing.Size(555, 527);
            this.reportViewerReceipt.TabIndex = 1;
            this.reportViewerReceipt.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // UserControlReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewerReceipt);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlReceipt";
            this.Size = new System.Drawing.Size(612, 568);
            this.Load += new System.EventHandler(this.UserControlReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReceipt;
    }
}
