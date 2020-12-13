namespace FastFood.UIQuanLy
{
    partial class Revenue
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getRevenueByYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Report = new FastFood.DataSet_Report();
            this.pn_reportview = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getRevenueByYearTableAdapter = new FastFood.DataSet_ReportTableAdapters.GetRevenueByYearTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.getRevenueByYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Report)).BeginInit();
            this.pn_reportview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getRevenueByYearBindingSource
            // 
            this.getRevenueByYearBindingSource.DataMember = "GetRevenueByYear";
            this.getRevenueByYearBindingSource.DataSource = this.dataSetReportBindingSource1;
            // 
            // dataSetReportBindingSource1
            // 
            this.dataSetReportBindingSource1.DataSource = this.dataSet_Report;
            this.dataSetReportBindingSource1.Position = 0;
            // 
            // dataSet_Report
            // 
            this.dataSet_Report.DataSetName = "DataSet_Report";
            this.dataSet_Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pn_reportview
            // 
            this.pn_reportview.Controls.Add(this.reportViewer1);
            this.pn_reportview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_reportview.Location = new System.Drawing.Point(0, 27);
            this.pn_reportview.Name = "pn_reportview";
            this.pn_reportview.Size = new System.Drawing.Size(1310, 741);
            this.pn_reportview.TabIndex = 16;
            this.pn_reportview.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_reportview_Paint);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getRevenueByYearBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FastFood.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1310, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetReportBindingSource
            // 
            this.dataSetReportBindingSource.DataSource = this.dataSet_Report;
            this.dataSetReportBindingSource.Position = 0;
            // 
            // getRevenueByYearTableAdapter
            // 
            this.getRevenueByYearTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(598, 26);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 27);
            this.panel1.TabIndex = 14;
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_reportview);
            this.Controls.Add(this.panel1);
            this.Name = "Revenue";
            this.Size = new System.Drawing.Size(1310, 768);
            ((System.ComponentModel.ISupportInitialize)(this.getRevenueByYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Report)).EndInit();
            this.pn_reportview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_reportview;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getRevenueByYearBindingSource;
        private System.Windows.Forms.BindingSource dataSetReportBindingSource1;
        private DataSet_Report dataSet_Report;
        private System.Windows.Forms.BindingSource dataSetReportBindingSource;
        private DataSet_ReportTableAdapters.GetRevenueByYearTableAdapter getRevenueByYearTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
    }
}
