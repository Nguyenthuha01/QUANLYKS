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
    public partial class frm_PhieuDKP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable comdt1 = new DataTable();
        DataTable comdt2 = new DataTable();
        string sql, constr, fname;
        int i , n;
        Boolean addnewflag = false;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frm_PhieuDKP()
        {
            InitializeComponent();
            txtngaydk.Value = DateTime.Now;
        }

        private void btnDau1_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, 0];
            NapCTPHONG();

        }

        private void btnTruoc1_Click(object sender, EventArgs e)
        {
            i = grddata.CurrentRow.Index;
            if (i > 0)
            {
                grddata.CurrentCell = grddata[0, i - 1];
                NapCTPHONG();
            }
        }

        private void btnSau1_Click(object sender, EventArgs e)
        {
            i = grddata.CurrentRow.Index;
            if (i < grddata.RowCount - 1)
            {
                grddata.CurrentCell = grddata[0, i + 1];
                NapCTPHONG();
            }
        }

        private void btnCuoi1_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, grddata.RowCount - 1];
            NapCTPHONG();
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

        private void grddata1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnHuydk_Click(object sender, EventArgs e)
        {
            Form f = new frm_PhieuHDK();
            f.ShowDialog();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            
            sql = "Select * from PHIEUDK" + " where " + fname + " =N'" + cmbGiatri.Text + "'";        
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata1.DataSource = dt;
            grddata1.Refresh();
            NapCT();

        }
        private void grddata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCTPHONG();
        }

        private void cmbTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbTentruong.Text == "Mã đăng ký")
                fname = "MADK";
            if (cmbTentruong.Text == "Mã khách hàng")
                fname = "MAKH";
            if (cmbTentruong.Text == "Mã phòng")
                fname = "MAP";
            if (cmbTentruong.Text == "Ngày đăng ký")
                fname = "NGAYDK";
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

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            sql = "Select * from PHIEUDK order by MADK";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata1.DataSource = dt;
            grddata1.Refresh();
            NapCT();
        }

        private void btntimkiemkh_Click(object sender, EventArgs e)
        {
            frm_DMKH f = new frm_DMKH();
            this.Hide();
            f.ShowDialog();
            this.Show();
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

        private void frm_PhieuDKP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLKSDataSet.PHONG);
            // TODO: This line of code loads data into the 'qLKSDataSet.PHIEUDK' table. You can move, or remove it, as needed.
            this.pHIEUDKTableAdapter.Fill(this.qLKSDataSet.PHIEUDK);
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            NapCT();


            sql = "select distinct MADK from PHIEUDK order by MADK";
            da = new SqlDataAdapter(sql, conn);
            comdt1.Clear();
            da.Fill(comdt1);
            txtmadk.DataSource = comdt1;
            txtmadk.DisplayMember = "MADK";
            txtmadk.ValueMember = "MADK";            

            sql = "select distinct MAKH from KHACHHANG order by MAKH";
            da = new SqlDataAdapter(sql, conn);
            comdt2.Clear();
            da.Fill(comdt2);
            txtmakh.DataSource = comdt2;
            txtmakh.DisplayMember = "MAKH";
            txtmakh.ValueMember = "MAKH";

            sql = "select distinct MAP from PHONG order by MAP";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            txtmap.DataSource = comdt;
            txtmap.DisplayMember = "MAP";
            txtmap.ValueMember = "MAP";

        }

        public void NapCT()
        {
            i = grddata1.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmadk.Text = grddata1.Rows[i].Cells["MADK"].Value.ToString();
            txtngaydk.Text = grddata1.Rows[i].Cells["NGAYDK"].Value.ToString();
            txtmakh.Text = grddata1.Rows[i].Cells["MAKH"].Value.ToString();         
            txtmap.Text = grddata1.Rows[i].Cells["MAP"].Value.ToString();
            txtngayden.Text = grddata1.Rows[i].Cells["NGAYDEN"].Value.ToString();
            txtngaydi.Text = grddata1.Rows[i].Cells["NGAYDI"].Value.ToString();
            txtcoctruoc.Text = grddata1.Rows[i].Cells["COCTRUOC"].Value.ToString();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            grddata1.CurrentCell = grddata1[0, grddata1.RowCount - 1];
            NapCT();
            txtmadk.Focus();
            btnDangky.Enabled = true;
            addnewflag = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời? (Y/N)", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {              
                sql = "Delete From  PHIEUDK where MADK='" + txtmadk.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                grddata1.Rows.RemoveAt(grddata1.CurrentRow.Index);
                NapCT();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnDangky.Enabled = true;
            MessageBox.Show("Hãy thực hiện sửa đổi nội dung trên các ô chi tiết đăng ký. Kết thúc bằng cách bấm nút Lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {         
            if (addnewflag == true)
            {
                //cập nhật thêm mới
                string ngaydk = txtngaydk.Value.ToString("yyyy-MM-dd");
                string ngayden = txtngayden.Value.ToString("yyyy-MM-dd");
                string ngaydi = txtngaydi.Value.ToString("yyyy-MM-dd");
                sql = "insert into PHIEUDK (MADK, NGAYDK, MAKH, MAP, NGAYDEN, NGAYDI, COCTRUOC) values" +
                "('" + txtmadk.Text + " ',' " + ngaydk + " ','" + txtmakh.Text + " ','"+ txtmap.Text + " ','" + ngayden + "','" + ngaydi + "','" + txtcoctruoc.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addnewflag = false;
                btnDangky.Enabled = false;
                NaplaiCT();
            }
            else
            {
                //cập nhật sửa chữa
                n = grddata1.RowCount - 1;
                for (i = 0; i <= n; i++)
                {
                    string tngaydk = txtngaydk.Value.ToString("yyyy-MM-dd");
                    string tngayden = txtngayden.Value.ToString("yyyy-MM-dd");
                    string tngaydi = txtngaydi.Value.ToString("yyyy-MM-dd");
                    sql = "update PHIEUDK set NGAYDK='" + tngaydk
                    + "', MAKH='" + txtmakh.Text + "', MAP= '" + txtmap.Text + "',NGAYDEN='" + tngayden + "', NGAYDI= '"
                    + tngaydi + "' ,COCTRUOC= '" + txtcoctruoc.Text + "'" + "where MADK='" + txtmadk.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    this.pHIEUDKTableAdapter.Fill(this.qLKSDataSet.PHIEUDK);

                }
                btnDangky.Enabled = false;
                MessageBox.Show("Mọi sự sửa đổi đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void NaplaiCT()
        {
            sql = "Select MADK, NGAYDK, MAKH, MAP, NGAYDEN, NGAYDI, COCTRUOC from PHIEUDK order by MADK";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata1.DataSource = dt;
            grddata1.Refresh();
        }
        public void NapCTPHONG()
        {
            i = grddata.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmaphong.Text = grddata.Rows[i].Cells["MAPG"].Value.ToString();
            txtdongia.Text = grddata.Rows[i].Cells["DONGIA"].Value.ToString();
            txtmalp.Text = grddata.Rows[i].Cells["MALP"].Value.ToString();           
        }
    }
}
