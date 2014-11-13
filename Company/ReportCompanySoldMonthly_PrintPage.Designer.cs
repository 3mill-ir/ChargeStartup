namespace Company
{
    partial class ReportCompanySoldMonthly_PrintPage
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.WholeData_DTDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.WholeData_DTDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WholeData_DTDataTableBindingSource
            // 
            this.WholeData_DTDataTableBindingSource.DataSource = typeof(CompanyBussinesLayer.CompanyPurchaseDailyDataSet.WholeData_DTDataTable);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportCompanypurchaseDaily_Print";
            reportDataSource1.Value = this.WholeData_DTDataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Company.ReportCompanySoldMonthly_PrintTemplate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportViewer1.Size = new System.Drawing.Size(784, 559);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportCompanySoldMonthly_PrintPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 559);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("B Koodak", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportCompanySoldMonthly_PrintPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ReportCompanypurchaseDaily_PrintPage";
            this.Load += new System.EventHandler(this.ReportCompanypurchaseDaily_PrintPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WholeData_DTDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WholeData_DTDataTableBindingSource;
    }
}