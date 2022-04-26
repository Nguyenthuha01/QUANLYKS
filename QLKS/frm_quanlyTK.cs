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
    public partial class frm_quanlyTK : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr, fname;
        int i, n;
        Boolean addnewflag = false;
        public frm_quanlyTK()
        {
            InitializeComponent();
        }

        private void frm_quanlyTK_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from TAIKHOANNV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grddata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            sql = "select * from TAIKHOANNV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCT();
        }

        private void cmbTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTentruong.Text == "Tên tài khoản")
            {
                fname = "TENTK";
            }    
            if (cmbTentruong.Text == "Họ và tên")
            {
                fname = "HOTEN";
            }    
            if (cmbTentruong.Text == "Số điện thoại")
            {
                fname = "SDT";
            }    
            if (cmbTentruong.Text == "Quyền")
            {     
                fname = "QUYEN";
            }

            sql = "Select distinct " + fname + " from TAIKHOANNV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            cmbGiatri.DataSource = dt;
            cmbGiatri.DisplayMember = fname;
            cmbGiatri.ValueMember = fname;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, grddata.RowCount - 1];
            NapCT();
            txttentk.Focus();
            btnLuu.Enabled = true;
            addnewflag = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            MessageBox.Show("Hãy thực hiện sửa đổi nội dung trên các ô chi tiết đăng ký. Kết thúc bằng cách bấm nút Lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời? (Y/N)", "Xác nhận",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete From  TAIKHOANNV where TENTK='" + txttentk.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                grddata.Rows.RemoveAt(grddata.CurrentRow.Index);
                NapCT();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {
                //cập nhật thêm mới
                sql = "insert into TAIKHOANNV (TENTK, PASS, HOTEN, SDT, EMAIL, QUYEN) values" +
                "(N'" + txttentk.Text + " ',' " + txtmatkhau.Text + " ',N'" + txthoten.Text + " ','" + txtsdt.Text + " ','" + txtemail.Text + "', N'" + txtquyen.Text + "')";
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
                n = grddata.RowCount - 1;
                for (i = 0; i <= n; i++)
                {
                    sql = "update TAIKHOANNV set PASS ='" + txtmatkhau.Text + "', HOTEN = N'" + txthoten.Text + "', SDT = '" + txtsdt.Text + "', EMAIL = '"
                    + txtemail.Text + "' , QUYEN = N'" + txtquyen.Text + "' where TENTK = N'" + txttentk.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                   
                }
                btnLuu.Enabled = false;
                NaplaiCT();
                MessageBox.Show("Mọi sự sửa đổi đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            sql = "select * from TAIKHOANNV  where " + fname + " =N'" + cmbGiatri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
            NapCT();
        }

        public void NapCT()
        {
            i = grddata.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txttentk.Text = grddata.Rows[i].Cells["TENTK"].Value.ToString();
            txtmatkhau.Text = grddata.Rows[i].Cells["PASS"].Value.ToString();
            txthoten.Text = grddata.Rows[i].Cells["HOTEN"].Value.ToString();
            txtsdt.Text = grddata.Rows[i].Cells["SDT"].Value.ToString();
            txtemail.Text = grddata.Rows[i].Cells["EMAIL"].Value.ToString();
            txtquyen.Text = grddata.Rows[i].Cells["QUYEN"].Value.ToString();
        }
        public void NaplaiCT()
        {
            sql = "select * from TAIKHOANNV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata.DataSource = dt;
            grddata.Refresh();
        }    
    }
}
