using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKS
{
    public partial class rpt_Hdthanhtoanprv : Form
    {
        public rpt_Hdthanhtoanprv( rpt_Hoadontt rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void rpt_Hdthanhtoanprv_Load(object sender, EventArgs e)
        {

        }
    }
}
