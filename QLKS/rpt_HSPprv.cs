﻿using System;
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
    public partial class rpt_HSPprv : Form
    {
        public rpt_HSPprv( rpt_HSP rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void rpt_HSPprv_Load(object sender, EventArgs e)
        {

        }
    }
}
