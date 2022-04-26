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
    public partial class frm_DMLP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr, tmalp, ttenlp, fname;
        int i, n;
        Boolean addnewflag = false;
        private void frm_DMLP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.LOAIPHONG' table. You can move, or remove it, as needed.
            this.lOAIPHONGTableAdapter.Fill(this.qLKSDataSet.LOAIPHONG);
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            NapCT();

            sql = "select distinct MALP from LOAIPHONG order by MALP";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            txtmalp.DataSource = comdt;
            txtmalp.DisplayMember = "MALP";
            txtmalp.ValueMember = "MALP";

        }
        private void btnCuoi_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, grddata.RowCount - 1];
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

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            i = grddata.CurrentRow.Index;
            if (i > 0)
            {
                grddata.CurrentCell = grddata[0, i - 1];
                NapCT();
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, 0];
            NapCT();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, grddata.RowCount - 1];
            NapCT();
            txtmalp.Focus();
            btnCapnhat.Enabled = true;
            addnewflag = true;
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
                sql = "Delete From  LOAIPHONG where MALP='" + txtmalp.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                grddata.Rows.RemoveAt(grddata.CurrentRow.Index);
                NapCT();
            }
        }

        private void cmbTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTentruong.Text == "Mã loại phòng")
                fname = "MALP";
            if (cmbTentruong.Text == "Tên loại phòng")
                fname = "TENLP";

            sql = "Select distinct " + fname + " from LOAIPHONG";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            cmbGiatri.DataSource = dt;
            cmbGiatri.DisplayMember = fname;
            cmbGiatri.ValueMember = fname;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            sql = "Select * from LOAIPHONG" + " where " + fname + " =N'" + cmbGiatri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCT();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            sql = "Select * from LOAIPHONG order by MALP";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCT();
        }

        private void grddata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        public frm_DMLP()
        {
            InitializeComponent();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                //cập nhật thêm mới
                sql = "insert into LOAIPHONG (MALP, TENLP) values" +
                "('" + txtmalp.Text + " ',N'" + txttenlp.Text + "')";
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
                    tmalp = grddata.Rows[i].Cells["MALP"].Value.ToString();
                    ttenlp = grddata.Rows[i].Cells["TENLP"].Value.ToString();                  
                    sql = "update LOAIPHONG set TENLP= N'" + ttenlp
                    + "'" + "where MALP='" + tmalp + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                }
                btnCapnhat.Enabled = false;
                MessageBox.Show("Mọi sự sửa đổi trên ô lưới đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void NapCT()
        {
            i = grddata.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmalp.Text = grddata.Rows[i].Cells["MALP"].Value.ToString();
            txttenlp.Text = grddata.Rows[i].Cells["TENLP"].Value.ToString();
        }
        public void NaplaiCT()
        {
            sql = "Select * from LOAIPHONG order by MALP";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
        }
    }
}
