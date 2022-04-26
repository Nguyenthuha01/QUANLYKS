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
    public partial class frm_Nhapngaybchd : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable datarpt = new DataTable();
        string sql, constr;
        public frm_Nhapngaybchd()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Nhapngaybchd_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void btnmobaocao_Click(object sender, EventArgs e)
        {
            rpt_Danhmuchoadon rpt = new rpt_Danhmuchoadon();
            string ttungay = txttungay.Value.ToString("yyyy-MM-dd");
            string tdenngay = txtdenngay.Value.ToString("yyyy-MM-dd");
            sql = "select MAHD, Convert(nvarchar(10),NGAYHD, 103) AS NGAYHD , TIENP, TONGTIENDV, COCTRUOC, TONGTIEN from HDTTOAN, PHIEUDK " +
                "where PHIEUDK.MADK = HDTTOAN.MADK and NGAYHD between '" + ttungay + "' and '" + tdenngay + "'";
            da = new SqlDataAdapter(sql, conn);
            datarpt.Clear();
            da.Fill(datarpt);
            rpt.SetDataSource(datarpt);
            rpt.DataDefinition.FormulaFields["tungay"].Text = "'" + txttungay.Text + "'";
            rpt.DataDefinition.FormulaFields["denngay"].Text = "'" + txtdenngay.Text + "'";
            rpt_Danhmuchoadonprv rp = new rpt_Danhmuchoadonprv(rpt);
            rp.Show();

        }
    }
}
