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
    public partial class frm_DMP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable comdt1 = new DataTable();
        string sql, constr, tmap, tdongia, tmalp, fname;
        int i, n;
        Boolean addnewflag = false;
        public frm_DMP()
        {
            InitializeComponent();
        }

        private void frm_DMP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLKSDataSet.PHONG);
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            NapCT();

            sql = "select distinct MAP from PHONG order by MAP";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            txtmap.DataSource = comdt;
            txtmap.DisplayMember = "MAP";
            txtmap.ValueMember = "MAP";

            sql = "select distinct MALP from LOAIPHONG order by MALP";
            da = new SqlDataAdapter(sql, conn);
            comdt1.Clear();
            da.Fill(comdt1);
            txtmalp.DataSource = comdt1;
            txtmalp.DisplayMember = "MALP";
            txtmalp.ValueMember = "MALP";
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, grddata.RowCount - 1];
            NapCT();
            txtmap.Focus();
            btnCapnhat.Enabled = true;
            addnewflag = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời? (Y/N)", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete From  PHONG where MAP='" + txtmap.Text + "'";
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
                sql = "insert into PHONG (MAP, DONGIA, MALP) values" +
                "('" + txtmap.Text + " ','" + txtdongia.Text + "', '" + txtmalp.Text + "' )";
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
                    tmap = grddata.Rows[i].Cells["MAP"].Value.ToString();
                    tdongia = grddata.Rows[i].Cells["DONGIA"].Value.ToString();
                    tmalp = grddata.Rows[i].Cells["MALP"].Value.ToString();
                    sql = "update PHONG set DONGIA= '" + tdongia
                    + "'" + "where MALP='" + tmap + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                }
                btnCapnhat.Enabled = false;
                MessageBox.Show("Mọi sự sửa đổi trên ô lưới đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnCapnhat.Enabled = true;
            MessageBox.Show("Hãy thực hiện sửa đổi nội dung trên ô lưới.Kết thúc bằng cách bấm nút Cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTentruong.Text == "Mã phòng")
                fname = "MAP";
            if (cmbTentruong.Text == "Đơn giá")
                fname = "DONGIA";
            if (cmbTentruong.Text == "Mã loại phòng")
                fname = "MALP";

            sql = "Select distinct " + fname + " from PHONG";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            cmbGiatri.DataSource = dt;
            cmbGiatri.DisplayMember = fname;
            cmbGiatri.ValueMember = fname;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            sql = "Select * from PHONG" + " where " + fname + " =N'" + cmbGiatri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCT();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            sql = "Select * from PHONG order by MAP";
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
        public void NapCT()
        {
            i = grddata.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmap.Text = grddata.Rows[i].Cells["MAP"].Value.ToString();
            txtdongia.Text = grddata.Rows[i].Cells["DONGIA"].Value.ToString();
            txtmalp.Text = grddata.Rows[i].Cells["MALP"].Value.ToString();
        }
        public void NaplaiCT()
        {
            sql = "Select * from PHONG order by MAP";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
        }
    }
}
