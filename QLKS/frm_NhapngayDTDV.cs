using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKS
{
    public partial class frm_NhapngayDTDV : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable datarpt = new DataTable();
        string sql, constr;
        public frm_NhapngayDTDV()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NhapngayDTDV_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void btnmobaocao_Click(object sender, EventArgs e)
        {
            string tungay = txttungay.Value.ToString("yyyy-MM-dd");
            string denngay = txtdenngay.Value.ToString("yyyy-MM-dd");
            rpt_DoanhthuDV rpt = new rpt_DoanhthuDV();
            sql = "select DICHVU.MADV, DICHVU.TENDV, DICHVU.DONGIA, PHIEUSDDV.SL from DICHVU INNER JOIN PHIEUSDDV on DICHVU.MADV = PHIEUSDDV.MADV " +
                "where PHIEUSDDV.NGAYSD >= '" + tungay + "' and PHIEUSDDV.NGAYSD <= '" + denngay + "'";
            da = new SqlDataAdapter(sql, conn);
            datarpt.Clear();
            da.Fill(datarpt);
            rpt.SetDataSource(datarpt);
            rpt.DataDefinition.FormulaFields["tungay"].Text = "'" + txttungay.Text + "'";
            rpt.DataDefinition.FormulaFields["denngay"].Text = "'" + txtdenngay.Text + "'";
            rpt_DTDVprv rp = new rpt_DTDVprv(rpt);
            rp.Show();
        }
    }
}
