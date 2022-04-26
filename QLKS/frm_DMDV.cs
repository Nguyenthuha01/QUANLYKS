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
    public partial class frm_DMDV : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable comdt1 = new DataTable();
        string sql, constr, tmadv, ttendv, tdvt, tdongia, fname;
        int i, n;
        Boolean addnewflag = false;

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

        public frm_DMDV()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnCapnhat.Enabled = true;
            MessageBox.Show("Hãy thực hiện sửa đổi nội dung trên ô lưới.Kết thúc bằng cách bấm nút Cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTentruong.Text == "Mã dịch vụ")
                fname = "MADV";
            if (cmbTentruong.Text == "Tên dịch vụ")
                fname = "TENDV";

            sql = "Select distinct " + fname + " from DICHVU";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            cmbGiatri.DataSource = dt;
            cmbGiatri.DisplayMember = fname;
            cmbGiatri.ValueMember = fname;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            sql = "Select * from DICHVU" + " where " + fname + " =N'" + cmbGiatri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCT();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            sql = "Select * from DICHVU order by MADV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCT();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời? (Y/N)", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete From  DICHVU where MADV='" + txtMadv.Text + "'";
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
                sql = "insert into DICHVU (MADV, TENDV, DVT, DONGIA) values" +
                "('" + txtMadv.Text + " ', N'" + txtTendv.Text + " ', N'" + txtDvt.Text + " ','" + txtDongia.Text + " ')";
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
                    tmadv = grddata.Rows[i].Cells["MADV"].Value.ToString();
                    ttendv = grddata.Rows[i].Cells["TENDV"].Value.ToString();
                    tdvt = grddata.Rows[i].Cells["DVT"].Value.ToString();
                    tdongia = grddata.Rows[i].Cells["DONGIA"].Value.ToString();
                    sql = "update DICHVU set TENDV= N'" + ttendv
                    + "', DVT= N'" + tdvt + "', DONGIA= '" + tdongia + "'" + "where MADV='" + tmadv + "'";
                    cmd1 = new SqlCommand(sql, conn);
                    cmd1.ExecuteNonQuery();

                }
                btnCapnhat.Enabled = false;
                MessageBox.Show("Mọi sự sửa đổi trên ô lưới đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frm_DMDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.qLKSDataSet.DICHVU);
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            NapCT();

            sql = "select distinct MADV from DICHVU order by MADV";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            txtMadv.DataSource = comdt;
            txtMadv.DisplayMember = "MADV";
            txtMadv.ValueMember = "MADV";

            sql = "select distinct DVT from DICHVU order by DVT";
            da = new SqlDataAdapter(sql, conn);
            comdt1.Clear();
            da.Fill(comdt1);
            txtDvt.DataSource = comdt1;
            txtDvt.DisplayMember = "DVT";
            txtDvt.ValueMember = "DVT";
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, grddata.RowCount - 1];
            NapCT();
            txtMadv.Focus();
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
            txtMadv.Text = grddata.Rows[i].Cells["MADV"].Value.ToString();
            txtTendv.Text = grddata.Rows[i].Cells["TENDV"].Value.ToString();
            txtDvt.Text = grddata.Rows[i].Cells["DVT"].Value.ToString();
            txtDongia.Text = grddata.Rows[i].Cells["DONGIA"].Value.ToString();
        }
        public void NaplaiCT()
        {
            sql = "Select * from DICHVU order by MADV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
        }

    }
 }
