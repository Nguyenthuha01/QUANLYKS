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
    public partial class rpt_Danhmuchoadonprv : Form
    {
        public rpt_Danhmuchoadonprv( rpt_Danhmuchoadon rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;

        }

        private void rpt_Danhmuchoadonprv_Load(object sender, EventArgs e)
        {

        }
    }
}
