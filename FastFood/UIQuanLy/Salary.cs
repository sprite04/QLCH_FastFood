using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FastFood.UIQuanLy
{
    public partial class Salary : UserControl
    {
        SqlConnection conn;
        public Salary()
        {
            InitializeComponent();
        }
        public Salary(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }
    }
}
