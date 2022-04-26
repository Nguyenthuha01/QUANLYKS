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
    public partial class frm_DMKH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr, tmakh, ttenkh, tsdt, tcmnd, tdiachi, tfb, temail, fname;
        int i, n;
        Boolean addnewflag = false;
        public frm_DMKH()
        {
            InitializeComponent();
        }

        private void frm_DMKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLKSDataSet.KHACHHANG);
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            NapCT();

            sql = "select distinct MAKH from KHACHHANG order by MAKH";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            txtMakh.DataSource = comdt;
            txtMakh.DisplayMember = "MAKH";
            txtMakh.ValueMember = "MAKH";

        }
        private void btnDau_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, 0];
            NapCT();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            i = grddata.CurrentRow.Index;
            if (i > 0)
            {
                grddata.CurrentCell = grddata[0, i - 1];
                NapCT();
            }
        }

        private void cmbTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTentruong.Text == "Mã khách hàng")
                fname = "MAKH";
            if (cmbTentruong.Text == "Tên khách hàng")
                fname = "HOTEN";
            if (cmbTentruong.Text == "Số điện thoại")
                fname = "SDT";
            if (cmbTentruong.Text == "CMND")
                fname = "CMND";

            sql = "Select distinct " + fname + " from KHACHHANG";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            cmbGiatri.DataSource = dt;
            cmbGiatri.DisplayMember = fname;
            cmbGiatri.ValueMember = fname;

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            sql = "Select * from KHACHHANG" + " where " + fname + " =N'" + cmbGiatri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCT();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            sql = "Select * from KHACHHANG order by MAKH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCT();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            i = grddata.CurrentRow.Index;
            if (i < grddata.RowCount - 1)
            {
                grddata.CurrentCell = grddata[0, i + 1];
                NapCT();
            }
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, grddata.RowCount - 1];
            NapCT();
        }

        private void grddata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnCapnhat.Enabled = true;
            MessageBox.Show("Hãy thực hiện sửa đổi nội dung trên ô lưới.Kết thúc bằng cách bấm nút Cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời? (Y/N)", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete From  KHACHHANG where MAKH='" + txtMakh.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                grddata.Rows.RemoveAt(grddata.CurrentRow.Index);
                NapCT();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                //cập nhật thêm mới
                sql = "insert into KHACHHANG (MAKH, HOTEN, SDT, CMND, DIACHI, FB, EMAIL) values" +
                "('" + txtMakh.Text + " ',N'" + txtTenkh.Text + " ','" + txtSdt.Text + " ','" + txtCmnd.Text + "', N'" + txtDiachi.Text + "', N'" + txtFb.Text + "', '" + txtEmail.Text + "' )";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addnewflag = false;
                btnCapnhat.Enabled = false;
                NaplaiCT();
            }
            else
            {
                //cập nhật sửa chữa
                n = grddata.RowCount - 1;
                for (i = 0; i <= 0; i++)
                {
                    tmakh = grddata.Rows[i].Cells["MAKH"].Value.ToString();
                    ttenkh = grddata.Rows[i].Cells["HOTEN"].Value.ToString();
                    tsdt = grddata.Rows[i].Cells["SDT"].Value.ToString();
                    tcmnd = grddata.Rows[i].Cells["CMND"].Value.ToString();
                    tdiachi = grddata.Rows[i].Cells["DIACHI"].Value.ToString();
                    tfb = grddata.Rows[i].Cells["FB"].Value.ToString();
                    temail = grddata.Rows[i].Cells["EMAIL"].Value.ToString();
                    sql = "update KHACHHANG set HOTEN= N'" + ttenkh
                    + "', SDT='" + tsdt + "', CMND= '" + tcmnd + "', DIACHI= N'" + tdiachi + "', FB= N'" + tfb + "', EMAIL= '" + temail + "'" + "where MAKH='" + tmakh + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                }
                btnCapnhat.Enabled = false;
                MessageBox.Show("Mọi sự sửa đổi trên ô lưới đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, grddata.RowCount - 1];
            NapCT();
            txtMakh.Focus();
            btnCapnhat.Enabled = true;
            addnewflag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void NapCT()
        {
            i = grddata.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtMakh.Text = grddata.Rows[i].Cells["MAKH"].Value.ToString();
            txtTenkh.Text = grddata.Rows[i].Cells["HOTEN"].Value.ToString();
            txtSdt.Text = grddata.Rows[i].Cells["SDT"].Value.ToString();
            txtCmnd.Text = grddata.Rows[i].Cells["CMND"].Value.ToString();
            txtDiachi.Text = grddata.Rows[i].Cells["DIACHI"].Value.ToString();
            txtFb.Text = grddata.Rows[i].Cells["FB"].Value.ToString();
            txtEmail.Text = grddata.Rows[i].Cells["EMAIL"].Value.ToString();
        }
        public void NaplaiCT()
        {
            sql = "Select * from KHACHHANG order by MAKH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
        }
    }
}
