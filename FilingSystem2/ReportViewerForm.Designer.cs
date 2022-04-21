namespace FilingSystem2
{
    partial class reportViewerForm
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
            this.db_filingsystemDataSetForReports1 = new FilingSystem2.db_filingsystemDataSetForReports();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbfilingsystemDataSetForReports1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_fileTableAdapter = new FilingSystem2.db_filingsystemDataSetForReportsTableAdapters.tbl_fileTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_filingsystemDataSetForReports1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfilingsystemDataSetForReports1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // db_filingsystemDataSetForReports1
            // 
            this.db_filingsystemDataSetForReports1.DataSetName = "db_filingsystemDataSetForReports";
            this.db_filingsystemDataSetForReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblfileBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FilingSystem2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbfilingsystemDataSetForReports1BindingSource
            // 
            this.dbfilingsystemDataSetForReports1BindingSource.DataSource = this.db_filingsystemDataSetForReports1;
            this.dbfilingsystemDataSetForReports1BindingSource.Position = 0;
            // 
            // tblfileBindingSource
            // 
            this.tblfileBindingSource.DataMember = "tbl_file";
            this.tblfileBindingSource.DataSource = this.dbfilingsystemDataSetForReports1BindingSource;
            // 
            // tbl_fileTableAdapter
            // 
            this.tbl_fileTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportViewerForm";
            this.Text = "Report Viewer";
            this.Load += new System.EventHandler(this.reportViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_filingsystemDataSetForReports1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfilingsystemDataSetForReports1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private db_filingsystemDataSetForReports db_filingsystemDataSetForReports1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dbfilingsystemDataSetForReports1BindingSource;
        private System.Windows.Forms.BindingSource tblfileBindingSource;
        private db_filingsystemDataSetForReportsTableAdapters.tbl_fileTableAdapter tbl_fileTableAdapter;
    }
}