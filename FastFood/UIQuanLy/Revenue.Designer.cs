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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_reportview = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Report = new FastFood.DataSet_Report();
            this.dataSetReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getRevenueByYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getRevenueByYearTableAdapter = new FastFood.DataSet_ReportTableAdapters.GetRevenueByYearTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.pn_reportview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRevenueByYearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 69);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "REVENUE";
            // 
            // pn_reportview
            // 
            this.pn_reportview.Controls.Add(this.reportViewer1);
            this.pn_reportview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_reportview.Location = new System.Drawing.Point(0, 69);
            this.pn_reportview.Name = "pn_reportview";
            this.pn_reportview.Size = new System.Drawing.Size(1310, 699);
            this.pn_reportview.TabIndex = 16;
            this.pn_reportview.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_reportview_Paint);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.getRevenueByYearBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FastFood.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1310, 699);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Report
            // 
            this.dataSet_Report.DataSetName = "DataSet_Report";
            this.dataSet_Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetReportBindingSource
            // 
            this.dataSetReportBindingSource.DataSource = this.dataSet_Report;
            this.dataSetReportBindingSource.Position = 0;
            // 
            // dataSetReportBindingSource1
            // 
            this.dataSetReportBindingSource1.DataSource = this.dataSet_Report;
            this.dataSetReportBindingSource1.Position = 0;
            // 
            // getRevenueByYearBindingSource
            // 
            this.getRevenueByYearBindingSource.DataMember = "GetRevenueByYear";
            this.getRevenueByYearBindingSource.DataSource = this.dataSetReportBindingSource1;
            // 
            // getRevenueByYearTableAdapter
            // 
            this.getRevenueByYearTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(598, 26);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_reportview);
            this.Controls.Add(this.panel1);
            this.Name = "Revenue";
            this.Size = new System.Drawing.Size(1310, 768);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_reportview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRevenueByYearBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_reportview;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getRevenueByYearBindingSource;
        private System.Windows.Forms.BindingSource dataSetReportBindingSource1;
        private DataSet_Report dataSet_Report;
        private System.Windows.Forms.BindingSource dataSetReportBindingSource;
        private DataSet_ReportTableAdapters.GetRevenueByYearTableAdapter getRevenueByYearTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
