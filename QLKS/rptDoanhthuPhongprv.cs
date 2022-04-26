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
    public partial class rptDoanhthuPhongprv : Form
    {
        public rptDoanhthuPhongprv( rptDoanhthuPhong rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void rptDoanhthuPhongprv_Load(object sender, EventArgs e)
        {

        }
    }
}
