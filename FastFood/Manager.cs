﻿using FastFood.UIQuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Manager : Form
    {
        public Manager(Login l)
        {
            InitializeComponent();
            login = l;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Form1 FORM = new Form1();
        Login login = new Login();
        public Manager(Form1 form)
        {
            InitializeComponent();
            FORM = form;
            this.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (pnList.Width == 258)
                pnList.Width = 80;
            else
                pnList.Width = 258;
        }


        private void picItem_Click(object sender, EventArgs e)
        {
            btnItem.PerformClick();
        }

        private void picBill_Click(object sender, EventArgs e)
        {
            btnBill.PerformClick();
        }

        private void picEmployee_Click(object sender, EventArgs e)
        {
            btnEmployee.PerformClick();
        }

        private void picSalary_Click(object sender, EventArgs e)
        {
            btnSalary.PerformClick();
        }

        private void picRevenue_Click(object sender, EventArgs e)
        {
            btnRevene.PerformClick();
        }

        private void picDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            pnShow.Controls.Clear();
            Products products = new Products();
            products.Dock = DockStyle.Fill;
            pnShow.Controls.Add(products);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
            pnShow.Controls.Clear();
            Employee employee = new Employee(login);
            employee.Dock = DockStyle.Fill;
            pnShow.Controls.Add(employee);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRevene_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            pnShow.Controls.Clear();
            Material materials = new Material();
            materials.Dock = DockStyle.Fill;
            pnShow.Controls.Add(materials);
        }
    }
}
