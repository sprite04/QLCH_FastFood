﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FastFood.BLL;

namespace FastFood.UIQuanLy
{
    public partial class Revenue : UserControl
    {

        BLLThongKe blTK;
        public Revenue()
        {
            InitializeComponent();
            blTK = new BLLThongKe();
            string err;
            blTK.Insert(DateTime.Now.Year, DateTime.Now.Month, out err);
            dateTimePicker1.CustomFormat = "YYYY";
            try
            {

                getRevenueByYearTableAdapter.Fill(dataSet_Report.GetRevenueByYear, dateTimePicker1.Value.Year);
                reportViewer1.RefreshReport();

            }
            catch
            {
                reportViewer1.RefreshReport();
            }
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

            reportViewer1.RefreshReport();
        }
        
        private void THONGKE_TBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pn_reportview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                getRevenueByYearTableAdapter.Fill(dataSet_Report.GetRevenueByYear, dateTimePicker1.Value.Year);
                reportViewer1.RefreshReport();
            }
            catch
            {
                reportViewer1.RefreshReport();
            }
        }
    }
}
