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
    public partial class frm_PhieuHDK : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable comdt1 = new DataTable();
        string sql, constr, fname;
        int i, n;
        Boolean addnewflag = false;
        public frm_PhieuHDK()
        {
            InitializeComponent();
            txtngayhuy.Value = DateTime.Now;
        }

        private void frm_PhieuHDK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.PHIEUHDK' table. You can move, or remove it, as needed.
            this.pHIEUHDKTableAdapter.Fill(this.qLKSDataSet.PHIEUHDK);
            // TODO: This line of code loads data into the 'qLKSDataSet.PHIEUDK' table. You can move, or remove it, as needed.
            this.pHIEUDKTableAdapter.Fill(this.qLKSDataSet.PHIEUDK);
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            NapCT();

            sql = "select distinct MAHDK from PHIEUHDK order by MAHDK";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            txtmahdk.DataSource = comdt;
            txtmahdk.DisplayMember = "MAHDK";
            txtmahdk.ValueMember = "MAHDK";

            sql = "select distinct MADK from PHIEUDK order by MADK";
            da = new SqlDataAdapter(sql, conn);
            comdt1.Clear();
            da.Fill(comdt1);
            txtmadk1.DataSource = comdt1;
            txtmadk1.DisplayMember = "MADK";
            txtmadk1.ValueMember = "MADK";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDau1_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, 0];
            NapCTDK();
        }

        private void btnTruoc1_Click(object sender, EventArgs e)
        {
            i = grddata.CurrentRow.Index;
            if (i > 0)
            {
                grddata.CurrentCell = grddata[0, i - 1];
                NapCTDK();
            }
        }

        private void btnSau1_Click(object sender, EventArgs e)
        {
            i = grddata.CurrentRow.Index;
            if (i < grddata.RowCount - 1)
            {
                grddata.CurrentCell = grddata[0, i + 1];
                NapCTDK();
            }
        }

        private void btnCuoi1_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, grddata.RowCount - 1];
            NapCTDK();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            grddata1.CurrentCell = grddata1[0, 0];
            NapCT();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            i = grddata1.CurrentRow.Index;
            if (i > 0)
            {
                grddata1.CurrentCell = grddata1[0, i - 1];
                NapCT();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            i = grddata1.CurrentRow.Index;
            if (i < grddata1.RowCount - 1)
            {
                grddata1.CurrentCell = grddata1[0, i + 1];
                NapCT();
            }
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            grddata1.CurrentCell = grddata1[0, grddata1.RowCount - 1];
            NapCT();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            grddata1.CurrentCell = grddata1[0, grddata1.RowCount - 1];
            NapCT();
            txtmahdk.Focus();
            btnLuu.Enabled = true;
            addnewflag = true;
        }

        private void grddata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCTDK();
        }

        private void grddata1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void cmbTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTentruong.Text == "Mã đăng ký")
                fname = "MADK";
            if (cmbTentruong.Text == "Ngày đăng ký")
                fname = "NGAYDK";
            if (cmbTentruong.Text == "Mã khách hàng")
                fname = "MAKH";
            if (cmbTentruong.Text == "Ngày đến")
                fname = "NGAYDEN";
            if (cmbTentruong.Text == "Ngày đi")
                fname = "NGAYDI";

            sql = "Select distinct " + fname + " from PHIEUDK";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            cmbGiatri.DataSource = dt;
            cmbGiatri.DisplayMember = fname;
            cmbGiatri.ValueMember = fname;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            sql = "Select * from PHIEUDK" + " where " + fname + " =N'" + cmbGiatri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCTDK();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            sql = "Select * from PHIEUDK order by MADK";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCTDK();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            MessageBox.Show("Hãy thực hiện sửa đổi nội dung trên các ô chi tiết hủy đăng ký .Kết thúc bằng cách bấm nút Lưu!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời? (Y/N)", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete From  PHIEUHDK where MAHDK='" + txtmahdk.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                grddata1.Rows.RemoveAt(grddata1.CurrentRow.Index);
                NapCT();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                //cập nhật thêm mới
                string ngayhuy = txtngayhuy.Value.ToString("yyyy-MM-dd");
                sql = "insert into PHIEUHDK (MAHDK, NGAYHUY, MADK) values" +
                "('" + txtmahdk.Text + " ',' " + ngayhuy + " ','" + txtmadk1.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addnewflag = false;
                btnLuu.Enabled = false;
                NaplaiCT();
            }
            else
            {
                //cập nhật sửa chữa
                n = grddata1.RowCount - 1;
                for (i = 0; i <= 0; i++)
                {
                    string tngayhuy = txtngayhuy.Value.ToString("yyyy-MM-dd");            
                    sql = "update PHIEUHDK set NGAYHUY='" + tngayhuy
                    + "', MADK='" + txtmadk1.Text + "'" + "where MAHDK='" + txtmahdk.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    this.pHIEUHDKTableAdapter.Fill(this.qLKSDataSet.PHIEUHDK);
                }
                btnLuu.Enabled = false;
                MessageBox.Show("Mọi sự sửa đổi đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void NapCT()
        {
            i = grddata1.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmahdk.Text = grddata1.Rows[i].Cells["MAHDK"].Value.ToString();
            txtmadk1.Text = grddata1.Rows[i].Cells["MADK"].Value.ToString();
            txtngayhuy.Text = grddata1.Rows[i].Cells["NGAYHUY"].Value.ToString();
        }
        public void NaplaiCT()
        {
            sql = "Select MAHDK, NGAYHUY, MADK from PHIEUHDK order by MAHDK";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata1.DataSource = dt;
            grddata1.Refresh();
        }
        public void NapCTDK()
        {
            i = grddata.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmadk.Text = grddata.Rows[i].Cells["MDK"].Value.ToString();
            txtngaydk.Text = grddata.Rows[i].Cells["NGAYDK"].Value.ToString();
            txtmakh.Text = grddata.Rows[i].Cells["MAKH"].Value.ToString();
            txtmap.Text = grddata.Rows[i].Cells["MAP"].Value.ToString();
            txtngayden.Text = grddata.Rows[i].Cells["NGAYDEN"].Value.ToString();
            txtngaydi.Text = grddata.Rows[i].Cells["NGAYDI"].Value.ToString();
            txtcoctruoc.Text = grddata.Rows[i].Cells["COCTRUOC"].Value.ToString();
        }

    }
}
