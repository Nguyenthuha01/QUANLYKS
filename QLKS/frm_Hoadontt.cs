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
    public partial class frm_Hoadontt : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable datarpt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable comdt1 = new DataTable();
        DataTable comdt2 = new DataTable();
        DataTable comdt3 = new DataTable();
        DataTable comdt4 = new DataTable();
        DataTable comdt5 = new DataTable();
        DataTable comdt6 = new DataTable();
        DataTable comdt7 = new DataTable();
        string sql, constr, fname, fname1, fname2;
        int i;

        public frm_Hoadontt()
        {

            InitializeComponent();

        }

        private void frm_Hoadontt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.HDTTOAN' table. You can move, or remove it, as needed.
            this.hDTTOANTableAdapter.Fill(this.qLKSDataSet.HDTTOAN);

            // TODO: This line of code loads data into the 'qLKSDataSet.PHIEUSDDV' table. You can move, or remove it, as needed.
            this.pHIEUSDDVTableAdapter.Fill(this.qLKSDataSet.PHIEUSDDV);
            // TODO: This line of code loads data into the 'qLKSDataSet.PHIEUDK' table. You can move, or remove it, as needed.
            this.pHIEUDKTableAdapter.Fill(this.qLKSDataSet.PHIEUDK);


            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            if (txtmap.Text != "")
            {
                sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
               " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
               "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD and PHIEUSDDV.MAP = '" + txtmap.Text + "' order by PHIEUSDDV.MAPDV";
            }
            else
            {
                sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
               " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
               "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD order by PHIEUSDDV.MAPDV";
            }
            da = new SqlDataAdapter(sql, conn);
            dt3.Clear();
            da.Fill(dt3);
            grddata.DataSource = dt3;
            grddata.Refresh();

            sql = "select* from KHACHHANG order by MAKH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            txtmakh.DataSource = dt;
            txtmakh.DisplayMember = "MAKH";
            //txtmakh.Text = "";


            sql = "select* from PHIEUDK order by MADK";
            da = new SqlDataAdapter(sql, conn);
            dt1.Clear();
            da.Fill(dt1);
            txtmadk.DataSource = dt1;
            txtmadk.DisplayMember = "MADK";
            //txtmadk.Text = "";

            sql = "select* from PHONG order by MAP";
            da = new SqlDataAdapter(sql, conn);
            dt2.Clear();
            da.Fill(dt2);
            txtmap.DataSource = dt2;
            txtmap.DisplayMember = "MAP";
            //txtmap.Text = "";



            AddBinding();
            conn.Close();


        }

        void AddBinding()
        {
            txttenkh.DataBindings.Add(new Binding("Text", txtmakh.DataSource, "HOTEN"));
            //txttenkh.Text = "";
            txtsdt.DataBindings.Add(new Binding("Text", txtmakh.DataSource, "SDT"));
            //txtsdt.Text = "";
            txtcmnd.DataBindings.Add(new Binding("Text", txtmakh.DataSource, "CMND"));
            //txtcmnd.Text = "";
            txtngaydk.DataBindings.Add(new Binding("Text", txtmadk.DataSource, "NGAYDK"));
            //txtngaydk.Value = DateTime.Now;
            txtmap.DataBindings.Add(new Binding("Text", txtmadk.DataSource, "MAP"));
            //txtmap.Text = "";
            txtngayden.DataBindings.Add(new Binding("Text", txtmadk.DataSource, "NGAYDEN"));
            //txtngayden.Value = DateTime.Now;
            txtngaydi.DataBindings.Add(new Binding("Text", txtmadk.DataSource, "NGAYDI"));
            //txtngaydi.Value = DateTime.Now;
            txtcoctruoc.DataBindings.Add(new Binding("Text", txtmadk.DataSource, "COCTRUOC"));
            //txtcoctruoc.Text = "";
            txtdongia.DataBindings.Add(new Binding("Text", txtmap.DataSource, "DONGIA"));
            //txtdongia.Text = "";
            txtmakh.DataBindings.Add(new Binding("Text", txtmadk.DataSource, "MAKH"));
        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "select (PHONG.DONGIA*DATEDIFF(DAY, PHIEUDK.NGAYDEN, PHIEUDK.NGAYDI)) " +
                "from PHIEUDK, PHONG where PHIEUDK.MAP = PHONG.MAP and MADK = '" + txtmadk.Text + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txttienphong.Text = rd[0].ToString();
            }
            conn.Close();
            conn.Open();
            sql = " select SUM( DICHVU.DONGIA * PHIEUSDDV.SL) from PHIEUSDDV, DICHVU, PHIEUDK " +
                "where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP " +
                "and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD and PHIEUDK.MAP = '" + txtmap.Text + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txttiendv.Text = rdr[0].ToString();
            }
            conn.Close();
            if (txttiendv.Text != "")
            {
                txttongtien.Text = (int.Parse(txttienphong.Text) + int.Parse(txttiendv.Text) - int.Parse(txtcoctruoc.Text)).ToString();
            }
            else
            {
                txttiendv.Text = " 0 ";
                txttongtien.Text = (int.Parse(txttienphong.Text) - int.Parse(txtcoctruoc.Text)).ToString();
            }
            }
        private void btnloc_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtmap.Text != "")
            {
                sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
               " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
               "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD and PHIEUSDDV.MAP = '" + txtmap.Text + "' order by PHIEUSDDV.MAPDV";
            }
            else
            {
                sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
               " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
               "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD order by PHIEUSDDV.MAPDV";
            }
            da = new SqlDataAdapter(sql, conn);
            dt3.Clear();
            da.Fill(dt3);
            grddata.DataSource = dt3;
            grddata.Refresh();
            conn.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            sql = "Select * from PHIEUDK" + " where " + fname + " =N'" + cmbGiatri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            grdpdkp.DataSource = comdt;
            grdpdkp.Refresh();
            //conn.Close();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
            //conn.Open();
            sql = "Select * from PHIEUDK order by MADK";
            da = new SqlDataAdapter(sql, conn);
            comdt1.Clear();
            da.Fill(comdt1);
            grdpdkp.DataSource = comdt1;
            grdpdkp.Refresh();

        }

        private void btnTimkiem1_Click(object sender, EventArgs e)
        {

            sql = "Select * from PHIEUSDDV"  + " where " + fname1 + " =N'" + cmbGiatri1.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            comdt2.Clear();
            da.Fill(comdt2);
            grdpsddv.DataSource = comdt2;
            grdpsddv.Refresh();
            //conn.Close();
        }

        private void btnNaplai1_Click(object sender, EventArgs e)
        {
            //conn.Open();
            sql = "Select * from PHIEUSDDV order by MAPDV";
            da = new SqlDataAdapter(sql, conn);
            comdt3.Clear();
            da.Fill(comdt3);
            grdpsddv.DataSource = comdt3;
            grdpsddv.Refresh();
        }

        private void grdpdkp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            conn.Open();
            string ngayhd = txtngayhd.Value.ToString("yyyy-MM-dd");
            sql = "insert into HDTTOAN (MAHD, NGAYHD, MADK, PTTT, TIENP, TONGTIENDV, TONGTIEN) values" +
            "('" + txtmahd.Text + "', '" + ngayhd + "','" + txtmadk.Text + "',N'" + txtpttt.Text + "','" + txttienphong.Text + "', '" + txttiendv.Text + "', '" + txttongtien.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            this.hDTTOANTableAdapter.Fill(this.qLKSDataSet.HDTTOAN);
            conn.Close();
        }

        private void cmbTentruong1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTentruong1.Text == "Mã phiếu dịch vụ")
                fname1 = "MAPDV";
            if (cmbTentruong1.Text == "Mã phòng")
                fname1 = "MAP";
            if (cmbTentruong1.Text == "Ngày sử dụng")
                fname1 = "NGAYSD";

            sql = "Select distinct " + fname1 + " from PHIEUSDDV";
            da = new SqlDataAdapter(sql, conn);
            comdt4.Clear();
            da.Fill(comdt4);
            cmbGiatri1.DataSource = comdt4;
            cmbGiatri1.DisplayMember = fname1;
            cmbGiatri1.ValueMember = fname1;
        }

        private void btntimkiemhd_Click(object sender, EventArgs e)
        {
            sql = "Select * from HDTTOAN" + " where " + fname2 + " =N'" + cmbgiatrihd.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            comdt6.Clear();
            da.Fill(comdt6);
            grdhdtt.DataSource = comdt6;
            grdhdtt.Refresh();
        }

        private void grdhdtt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            NapHD();
            if (txtmap.Text != "")
            {
                sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
               " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
               "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD and PHIEUSDDV.MAP = '" + txtmap.Text + "' order by PHIEUSDDV.MAPDV";
            }
            else
            {
                sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
               " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
               "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD order by PHIEUSDDV.MAPDV";
            }
            da = new SqlDataAdapter(sql, conn);
            dt3.Clear();
            da.Fill(dt3);
            grddata.DataSource = dt3;
            grddata.Refresh();
            conn.Close();
            btnthanhtoan.Enabled = false;
        }

        private void btnnaplaihd_Click(object sender, EventArgs e)
        {
            sql = "Select * from HDTTOAN order by MAHD";
            da = new SqlDataAdapter(sql, conn);
            comdt6.Clear();
            da.Fill(comdt6);
            grdhdtt.DataSource = comdt6;
            grdhdtt.Refresh();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            grdhdtt.CurrentCell = grdhdtt[0, 0];
            NapHD();
            btnthanhtoan.Enabled = false;
            if (txtmap.Text != "")
            {
                sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
               " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
               "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD and PHIEUSDDV.MAP = '" + txtmap.Text + "' order by PHIEUSDDV.MAPDV";
            }
            else
            {
                sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
               " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
               "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD order by PHIEUSDDV.MAPDV";
            }
            da = new SqlDataAdapter(sql, conn);
            dt3.Clear();
            da.Fill(dt3);
            grddata.DataSource = dt3;
            grddata.Refresh();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            i = grdhdtt.CurrentRow.Index;
            if (i > 0)
            {
                grdhdtt.CurrentCell = grdhdtt[0, i - 1];
                NapHD();
                btnthanhtoan.Enabled = false;
                if (txtmap.Text != "")
                {
                    sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
                   " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
                   "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD and PHIEUSDDV.MAP = '" + txtmap.Text + "' order by PHIEUSDDV.MAPDV";
                }
                else
                {
                    sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
                   " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
                   "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD order by PHIEUSDDV.MAPDV";
                }
                da = new SqlDataAdapter(sql, conn);
                dt3.Clear();
                da.Fill(dt3);
                grddata.DataSource = dt3;
                grddata.Refresh();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            i = grdhdtt.CurrentRow.Index;
            if (i < grdhdtt.RowCount - 1)
            {
                grdhdtt.CurrentCell = grdhdtt[0, i + 1];
                NapHD();
                btnthanhtoan.Enabled = false;
                if (txtmap.Text != "")
                {
                    sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
                   " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
                   "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD and PHIEUSDDV.MAP = '" + txtmap.Text + "' order by PHIEUSDDV.MAPDV";
                }
                else
                {
                    sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
                   " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
                   "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD order by PHIEUSDDV.MAPDV";
                }
                da = new SqlDataAdapter(sql, conn);
                dt3.Clear();
                da.Fill(dt3);
                grddata.DataSource = dt3;
                grddata.Refresh();
            }
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            grdhdtt.CurrentCell = grdhdtt[0, grdhdtt.RowCount - 1];
            NapHD();
            btnthanhtoan.Enabled = false;
            if (txtmap.Text != "")
            {
                sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
               " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
               "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD and PHIEUSDDV.MAP = '" + txtmap.Text + "' order by PHIEUSDDV.MAPDV";
            }
            else
            {
                sql = " select PHIEUSDDV.MAPDV AS 'MÃ PDV', PHIEUSDDV.MADV AS 'Mã DV', DICHVU.DONGIA AS 'Đơn giá', PHIEUSDDV.SL, PHIEUSDDV.NGAYSD AS 'Ngày SD', ( DICHVU.DONGIA * PHIEUSDDV.SL) AS 'Thành tiền' " +
               " from PHIEUSDDV, DICHVU, PHIEUDK where PHIEUSDDV.MADV = DICHVU.MADV and PHIEUSDDV.MAP = PHIEUDK.MAP and PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD " +
               "and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD order by PHIEUSDDV.MAPDV";
            }
            da = new SqlDataAdapter(sql, conn);
            dt3.Clear();
            da.Fill(dt3);
            grddata.DataSource = dt3;
            grddata.Refresh();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            grdhdtt.CurrentCell = grdhdtt[0, grdhdtt.RowCount - 1];
            NapHD();
            txtmahd.Focus();
            btnthanhtoan.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hiện thời? (Y/N)", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete From  HDTTOAN where MAHD='" + txtmahd.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                grdhdtt.Rows.RemoveAt(grdhdtt.CurrentRow.Index);
                NapHD();
            }
            conn.Close();
        }


        private void cmbtentruonghd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtentruonghd.Text == "Mã hóa đơn")
                fname2 = "MAHD";
            if (cmbtentruonghd.Text == "Ngày hóa đơn")
                fname2 = "NGAYHD";
            if (cmbtentruonghd.Text == "Mã đăng ký")
                fname2 = "MADK";
            sql = "Select distinct " + fname2 + " from HDTTOAN";
            da = new SqlDataAdapter(sql, conn);
            comdt6.Clear();
            da.Fill(comdt6);
            cmbgiatrihd.DataSource = comdt6;
            cmbgiatrihd.DisplayMember = fname2;
            cmbgiatrihd.ValueMember = fname2;
        }

        private void btnbaocaohd_Click(object sender, EventArgs e)
        {
            frm_Nhapngaybchd f = new frm_Nhapngaybchd();
            f.ShowDialog();
        }

        private void btninhd_Click(object sender, EventArgs e)
        {
            rpt_Hoadontt rpt = new rpt_Hoadontt();
           
            sql = " SELECT HDTTOAN.MAHD, HDTTOAN.NGAYHD, KHACHHANG.MAKH, KHACHHANG.HOTEN, KHACHHANG.SDT, KHACHHANG.CMND, " +
            " HDTTOAN.PTTT, PHIEUDK.MADK, PHIEUDK.NGAYDK, PHIEUDK.MAP, PHONG.DONGIA, PHIEUDK.NGAYDEN, " +
            " PHIEUDK.NGAYDI, PHIEUDK.COCTRUOC, PHIEUSDDV.MAPDV, PHIEUSDDV.MADV, DICHVU.TENDV, " +
            " DICHVU.DONGIA, PHIEUSDDV.SL, PHIEUSDDV.NGAYSD, HDTTOAN.TIENP, HDTTOAN.TONGTIENDV, " +
            " HDTTOAN.TONGTIEN from HDTTOAN FULL JOIN PHIEUDK ON HDTTOAN.MADK = PHIEUDK.MADK " +
            " FULL JOIN KHACHHANG ON PHIEUDK.MAKH = KHACHHANG.MAKH FULL JOIN PHONG ON PHONG.MAP = PHIEUDK.MAP " +
            " FULL JOIN PHIEUSDDV ON PHONG.MAP = PHIEUSDDV.MAP FULL JOIN DICHVU ON PHIEUSDDV.MADV = DICHVU.MADV " +
            " WHERE PHIEUDK.MADK IS NOT NULL AND PHIEUDK.NGAYDEN <= PHIEUSDDV.NGAYSD and PHIEUDK.NGAYDI >= PHIEUSDDV.NGAYSD and MAHD = '" + txtmahd.Text + "' " +
            " UNION ALL SELECT HDTTOAN.MAHD, HDTTOAN.NGAYHD, KHACHHANG.MAKH, KHACHHANG.HOTEN, KHACHHANG.SDT, KHACHHANG.CMND, HDTTOAN.PTTT, PHIEUDK.MADK, " +
            " PHIEUDK.NGAYDK, PHIEUDK.MAP, PHONG.DONGIA, PHIEUDK.NGAYDEN, PHIEUDK.NGAYDI, PHIEUDK.COCTRUOC, PHIEUSDDV.MAPDV, PHIEUSDDV.MADV, DICHVU.TENDV, " +
            " DICHVU.DONGIA, PHIEUSDDV.SL, PHIEUSDDV.NGAYSD, HDTTOAN.TIENP, HDTTOAN.TONGTIENDV," +
            " HDTTOAN.TONGTIEN from HDTTOAN FULL JOIN PHIEUDK ON HDTTOAN.MADK = PHIEUDK.MADK" +
            " FULL JOIN KHACHHANG ON PHIEUDK.MAKH = KHACHHANG.MAKH FULL JOIN PHONG ON PHONG.MAP = PHIEUDK.MAP" +
            " FULL JOIN PHIEUSDDV ON PHONG.MAP = PHIEUSDDV.MAP FULL JOIN DICHVU ON PHIEUSDDV.MADV = DICHVU.MADV" +
            " WHERE PHIEUDK.MADK IS NOT NULL AND PHIEUSDDV.NGAYSD IS NULL and MAHD = '" + txtmahd.Text + "'";

            da = new SqlDataAdapter(sql, conn);
            datarpt.Clear();
            da.Fill(datarpt);
            rpt.SetDataSource(datarpt);
            rpt_Hdthanhtoanprv rp = new rpt_Hdthanhtoanprv(rpt);
            rp.Show();
        }

        private void btntao_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = grdhdtt.Rows.Count;
            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(grdhdtt.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi1.Remove(0, 2)));
            if (chuoi2 +1< 10)
                txtmahd.Text = "HD0" + (chuoi2 +1).ToString();
            else if (chuoi2 +1 < 100)
                txtmahd.Text = "HD" + (chuoi2 +1).ToString();

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
            comdt5.Clear();
            da.Fill(comdt5);
            cmbGiatri.DataSource = comdt5;
            cmbGiatri.DisplayMember = fname;
            cmbGiatri.ValueMember = fname;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void NapCT()
        {
            i = grdpdkp.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmadk.Text = grdpdkp.Rows[i].Cells["MADK"].Value.ToString();
            txtngaydk.Text = grdpdkp.Rows[i].Cells["NGAYDK"].Value.ToString();
            txtmap.Text = grdpdkp.Rows[i].Cells["MAP"].Value.ToString();
            txtngayden.Text = grdpdkp.Rows[i].Cells["NGAYDEN"].Value.ToString();
            txtngaydi.Text = grdpdkp.Rows[i].Cells["NGAYDI"].Value.ToString();
            txtmakh.Text = grdpdkp.Rows[i].Cells["MAKH"].Value.ToString();
            txtcoctruoc.Text = grdpdkp.Rows[i].Cells["COCTRUOC"].Value.ToString();
        }
        public void NapHD()
        {
            i = grdhdtt.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
            txtmahd.Text = grdhdtt.Rows[i].Cells["MAHD"].Value.ToString();
            txtngayhd.Text = grdhdtt.Rows[i].Cells["NGAYHD"].Value.ToString();
            txtpttt.Text = grdhdtt.Rows[i].Cells["PTTT"].Value.ToString();
            txtmadk.Text = grdhdtt.Rows[i].Cells["MADKY"].Value.ToString();
            txttienphong.Text = grdhdtt.Rows[i].Cells["TIENP"].Value.ToString();
            txttiendv.Text = grdhdtt.Rows[i].Cells["TIENDV"].Value.ToString();
            txttongtien.Text = grdhdtt.Rows[i].Cells["TONG"].Value.ToString();
        }

    }
}
