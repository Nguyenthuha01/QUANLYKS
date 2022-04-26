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
    public partial class frm_NhapnngayDTP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable datarpt = new DataTable();
        string sql, constr;

        public frm_NhapnngayDTP()
        {
            InitializeComponent();
        }

        private void btnmobaocao_Click(object sender, EventArgs e)
        {
            string tungay = txttungay.Value.ToString("yyyy-MM-dd");
            string denngay = txtdenngay.Value.ToString("yyyy-MM-dd");
            rptDoanhthuPhong rpt = new rptDoanhthuPhong();
            sql = "select PHONG.MAP, LOAIPHONG.MALP, LOAIPHONG.TENLP, PHONG.DONGIA, PHIEUDK.NGAYDEN, " +
                "PHIEUDK.NGAYDI FROM PHONG INNER JOIN LOAIPHONG ON PHONG.MALP = LOAIPHONG.MALP " +
                "AND PHONG.MALP = LOAIPHONG.MALP INNER JOIN PHIEUDK ON PHONG.MAP = PHIEUDK.MAP " +
                "where PHIEUDK.NGAYDEN >= '" + tungay + "' and PHIEUDK.NGAYDI <= '" + denngay + "'";
            da = new SqlDataAdapter(sql, conn);
            datarpt.Clear();
            da.Fill(datarpt);
            rpt.SetDataSource(datarpt);
            rpt.DataDefinition.FormulaFields["tungay"].Text = "'" + txttungay.Text + "'";
            rpt.DataDefinition.FormulaFields["denngay"].Text = "'" + txtdenngay.Text + "'";
            rptDoanhthuPhongprv rp = new rptDoanhthuPhongprv(rpt);
            rp.Show();
        }

        private void frm_NhapnngayDTP_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
