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
    public partial class frm_PhieuSDDV : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable comdt1 = new DataTable();
        DataTable comdt2 = new DataTable();
        DataTable comdt3 = new DataTable();
        DataTable datarpt = new DataTable();
        string sql, constr, fname;
        int i, n;
        Boolean addnewflag = false;
        public frm_PhieuSDDV()
        {
            InitializeComponent();
            txtngaysd.Value = DateTime.Now;
        }

        private void frm_PhieuSDDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.PHIEUSDDV' table. You can move, or remove it, as needed.
            this.pHIEUSDDVTableAdapter.Fill(this.qLKSDataSet.PHIEUSDDV);

            // TODO: This line of code loads data into the 'qLKSDataSet.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.qLKSDataSet.DICHVU);
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            NapCT();

            sql = "select distinct MAPDV from PHIEUSDDV order by MAPDV";
            da = new SqlDataAdapter(sql, conn);
            comdt1.Clear();
            da.Fill(comdt1);
            txtmapdk.DataSource = comdt1;
            txtmapdk.DisplayMember = "MAPDV";
            txtmapdk.ValueMember = "MAPDV";

            sql = "select distinct MAP from PHONG order by MAP";
            da = new SqlDataAdapter(sql, conn);
            comdt2.Clear();
            da.Fill(comdt2);
            txtmap.DataSource = comdt2;
            txtmap.DisplayMember = "MAP";
            txtmap.ValueMember = "MAP";

            sql = "select distinct MADV from DICHVU order by MADV";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            txtmadv1.DataSource = comdt;
            txtmadv1.DisplayMember = "MADV";
            txtmadv1.ValueMember = "MADV";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDau1_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, 0];
            NapCTDV();
        }

        private void btnTruoc1_Click(object sender, EventArgs e)
        {
            i = grddata.CurrentRow.Index;
            if (i > 0)
            {
                grddata.CurrentCell = grddata[0, i - 1];
                NapCTDV();
            }
        }

        private void btnSau1_Click(object sender, EventArgs e)
        {
            i = grddata.CurrentRow.Index;
            if (i < grddata.RowCount - 1)
            {
                grddata.CurrentCell = grddata[0, i + 1];
                NapCTDV();
            }
        }

        private void btnCuoi1_Click(object sender, EventArgs e)
        {
            grddata.CurrentCell = grddata[0, grddata.RowCount - 1];
            NapCTDV();
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

        private void grddata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCTDV();
        }

        private void grddata1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void cmbTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTentruong.Text == "Mã phiếu dịch vụ")
                fname = "MAPDV";
            if (cmbTentruong.Text == "Mã phòng")
                fname = "MAP";
           // if (cmbTentruong.Text == "Ngày sử dụng")
               // fname = "NGAYSD";

            sql = "Select distinct " + fname + " from PHIEUSDDV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            cmbGiatri.DataSource = dt;
            cmbGiatri.DisplayMember = fname;
            cmbGiatri.ValueMember = fname;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        { 
                sql = "Select * from PHIEUSDDV" + " where " + fname + " ='" + cmbGiatri.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                grddata1.DataSource = dt;
                grddata1.Refresh();
                NapCT();
            
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            sql = "Select * from PHIEUSDDV order by MAPDV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata1.DataSource = dt;
            grddata1.Refresh();
            NapCT();
        }

        private void btnInphieu_Click(object sender, EventArgs e)
        {
            if (txtmapdk.Text != "")
            {
                rpt_Phieusddv rpt = new rpt_Phieusddv();
                sql = "select PHIEUSDDV.MAPDV,  Convert(nvarchar(10),PHIEUSDDV.NGAYSD, 103) AS NGAYSD, PHIEUSDDV.MAP,  DICHVU.MADV, DICHVU.TENDV, " +
                    "DICHVU.DONGIA, DICHVU.DVT, PHIEUSDDV.SL from PHIEUSDDV full join DICHVU  on " +
                    "PHIEUSDDV.MADV = DICHVU.MADV where PHIEUSDDV.MAPDV = '" + txtmapdk.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                comdt3.Clear();
                da.Fill(comdt3);
                rpt.SetDataSource(comdt3);
               //rpt.DataDefinition.FormulaFields["MAPDV"].Text = "'" + txtmapdk.Text + "'";
                rpt_Phieusddvprv rp = new rpt_Phieusddvprv(rpt);
                rp.Show();
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
            txtmapdk.Focus();
            btnLuu.Enabled = true;
            addnewflag = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            MessageBox.Show("Hãy thực hiện sửa đổi nội dung trên các ô chi tiết phiếu SDDV.Kết thúc bằng cách bấm nút Lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời? (Y/N)", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete From  PHIEUSDDV where MAPDV='" + txtmapdk.Text + "'";
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
                string ngaysd = txtngaysd.Value.ToString("yyyy-MM-dd");
                sql = "insert into PHIEUSDDV (MAPDV, MAP, MADV, SL, NGAYSD) values" +
                "('" + txtmapdk.Text + "', '" + txtmap.Text + "','" + txtmadv1.Text + "','" + txtsoluong.Text + "','" + ngaysd + "')";
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
                    string tngaysd = txtngaysd.Value.ToString("yyyy-MM-dd");
                    sql = "update PHIEUSDDV set NGAYSD='" + tngaysd
                    + "', MAP='" + txtmap.Text + "', MADV= '" + txtmadv1.Text + "',SL='" + txtsoluong.Text + "'" + "where MAPDV='" + txtmapdk.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    this.pHIEUSDDVTableAdapter.Fill(this.qLKSDataSet.PHIEUSDDV);
                }
                btnLuu.Enabled = false;
                MessageBox.Show("Mọi sự sửa đổi trên ô lưới đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void NapCT()
        {
            //string ngaysd = txtngaysd.Value.ToString("yyyy-MM-dd");
            i = grddata1.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmapdk.Text = grddata1.Rows[i].Cells["MAPDVU"].Value.ToString();
            txtmap.Text = grddata1.Rows[i].Cells["MAP"].Value.ToString();
            txtmadv1.Text = grddata1.Rows[i].Cells["MADVU"].Value.ToString();
            txtsoluong.Text = grddata1.Rows[i].Cells["SL"].Value.ToString();
            txtngaysd.Text = grddata1.Rows[i].Cells["NGAYSD"].Value.ToString();
        }
        public void NaplaiCT()
        {
            sql = "Select * from PHIEUSDDV order by MAPDV";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grddata1.DataSource = dt;
            grddata1.Refresh();
        }
        public void NapCTDV()
        {
            i = grddata.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmadv.Text = grddata.Rows[i].Cells["MADV"].Value.ToString();
            txttendv.Text = grddata.Rows[i].Cells["TENDV"].Value.ToString();
            txtdvt.Text = grddata.Rows[i].Cells["DVT"].Value.ToString();
            txtdongia.Text = grddata.Rows[i].Cells["DONGIA"].Value.ToString();
        }
    }
}
