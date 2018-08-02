namespace YollukProgrami
{
    partial class Yazdirfrm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vtDataSet = new YollukProgrami.vtDataSet();
            this.yollukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yollukTableAdapter = new YollukProgrami.vtDataSetTableAdapters.yollukTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.vtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yollukBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vtDataSet
            // 
            this.vtDataSet.DataSetName = "vtDataSet";
            this.vtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yollukBindingSource
            // 
            this.yollukBindingSource.DataMember = "yolluk";
            this.yollukBindingSource.DataSource = this.vtDataSet;
            // 
            // yollukTableAdapter
            // 
            this.yollukTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.yollukBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YollukProgrami.rpr.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(753, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // Yazdirfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 475);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Yazdirfrm";
            this.Text = "Yazdirfrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Yazdirfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yollukBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource yollukBindingSource;
        private vtDataSet vtDataSet;
        private vtDataSetTableAdapters.yollukTableAdapter yollukTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}