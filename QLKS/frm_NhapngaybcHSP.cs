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
    public partial class frm_NhapngaybcHSP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable datarpt = new DataTable();
        string sql, constr, sql1;
        public frm_NhapngaybcHSP()
        {
            InitializeComponent();
        }

        private void btnmobaocao_Click(object sender, EventArgs e)
        {
            string tungay = txttungay.Value.ToString("yyyy-MM-dd");
            string denngay = txtdenngay.Value.ToString("yyyy-MM-dd");
            sql= "update NGAYNHAP set NGAYBD = '" + tungay + "', NGAYKT = '" + denngay + "' where STT = 1";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            sql = "Select DATEDIFF( DAY, NGAYBD, NGAYKT) from NGAYNHAP where STT = 1";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            int i = 0;
            if (rd.Read())
            {
                int n = rd.GetInt32(0);
                
                for (i =0; i <= n;)
                {
                    conn.Close();
                    conn.Open();
                    sql1 = "DECLARE @SLPDUOCTHUE INT = (SELECT COUNT([PHIEUDK].MAP) FROM PHIEUDK " +
                        "WHERE PHIEUDK.NGAYDEN <= DATEADD(DAY, " + i + " , (select NGAYBD from NGAYNHAP " +
                        "where STT = 1)) AND DATEADD(DAY, " + i + ", (select NGAYNHAP.NGAYBD from NGAYNHAP " +
                        "where NGAYNHAP.STT = 1)) <= PHIEUDK.NGAYDI), @SLPHONG INT = (SELECT COUNT([PHONG].MAP) FROM[PHONG] ), " +
                        "@DTPHONG INT = (SELECT SUM(PHONG.DONGIA * DATEDIFF(DAY, PHIEUDK.NGAYDEN, PHIEUDK.NGAYDI)) " +
                        "FROM PHIEUDK, PHONG WHERE PHIEUDK.MAP = PHONG.MAP and PHIEUDK.NGAYDEN <= DATEADD(DAY, " + i + ", (select NGAYBD from NGAYNHAP where STT = 1)) " +
                        "AND DATEADD(DAY, " + i + ", (select NGAYNHAP.NGAYBD from NGAYNHAP where NGAYNHAP.STT = 1)) <= PHIEUDK.NGAYDI) " +
                        "insert into HIEUSUATP(NGAY, SLP, SLPDUOCTHUE, DTP, AOR, ADR, REVPAR) " +
                        "SELECT DATEADD(DAY, " + i + ", (select NGAYBD from NGAYNHAP where STT = 1)), " +
                        "@SLPHONG, @SLPDUOCTHUE, @DTPHONG , CONVERT(DECIMAL(4, 2), CONVERT(DECIMAL(14, 4), @SLPDUOCTHUE) / CONVERT(DECIMAL(14, 4), @SLPHONG)), " +
                        "CONVERT(DECIMAL(14, 2), CONVERT(DECIMAL(14, 4), @DTPHONG) / CONVERT(DECIMAL(14, 4), @SLPDUOCTHUE)), CONVERT(DECIMAL(14, 2), " +
                        "CONVERT(DECIMAL(14, 4), @DTPHONG) / CONVERT(DECIMAL(14, 4), @SLPHONG))";
                // DTP = DONGIA*( NGAYDI- NGAYDEN)
                //  SLPDUOCTHUE/ SLPHONG = AOR
                //  DTP/ SLPDUOCTHUE = ADR
                //  DTP / SLPHONG = REVPAR

                cmd1 = new SqlCommand(sql1, conn);
                    cmd1.ExecuteNonQuery();
                    i++;
                }
                conn.Close();
            }
            conn.Open();
            rpt_HSP rpt = new rpt_HSP();
            sql = "select * from HIEUSUATP ";
            da = new SqlDataAdapter(sql, conn);
            datarpt.Clear();
            da.Fill(datarpt);
            rpt.SetDataSource(datarpt);
            rpt.DataDefinition.FormulaFields["tungay"].Text = "'" + txttungay.Text + "'";
            rpt.DataDefinition.FormulaFields["denngay"].Text = "'" + txtdenngay.Text + "'";
            rpt_HSPprv rp = new rpt_HSPprv(rpt);
            rp.Show();
            conn.Close();
            conn.Open();
            sql = " delete from HIEUSUATP";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NhapngaybcHSP_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }
    }
}
