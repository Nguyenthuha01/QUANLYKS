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
    public partial class frm_Dangnhap : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql, constr;
        public frm_Dangnhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                conn.Close();
                Application.Exit();
            }
        }

        private void frm_Dangnhap_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
        }

        private void chbhienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (chbhienmk.Checked)
            {
                txtMatkhau.PasswordChar = (Char)0;
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void lblDangky_Click(object sender, EventArgs e)
        {
            Form f = new frm_Dangky();
            this.Hide();
            f.Show();
        }

        private void txtMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || ((e.KeyChar >= 'a') && (e.KeyChar <= 'z')) ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtTaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || ((e.KeyChar >= 'a') && (e.KeyChar <= 'z')) ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtTaikhoan_MouseEnter(object sender, EventArgs e)
        {
            txtTaikhoan.BackColor = Color.LightBlue;
        }

        private void txtTaikhoan_MouseLeave(object sender, EventArgs e)
        {
            txtTaikhoan.BackColor = Color.White;
        }

        private void txtMatkhau_MouseEnter(object sender, EventArgs e)
        {
            txtMatkhau.BackColor = Color.LightBlue;
        }

        private void txtMatkhau_MouseLeave(object sender, EventArgs e)
        {
            txtMatkhau.BackColor = Color.White;
        }

        private void btnDangnhap_MouseEnter(object sender, EventArgs e)
        {
            btnDangnhap.BackColor = Color.LightBlue;
        }

        private void btnDangnhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangnhap.BackColor = Color.White;
        }

        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.LightBlue;
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.White;
        }

        private void lblDangky_MouseEnter(object sender, EventArgs e)
        {
            lblDangky.ForeColor = Color.Blue;
        }

        private void lblDangky_MouseLeave(object sender, EventArgs e)
        {
            lblDangky.ForeColor = Color.Black;
        }

        private void btndangnhapNV_Click(object sender, EventArgs e)
        {
            string tentk = txtTaikhoan.Text.Trim();
            string mk = txtMatkhau.Text.Trim();
            sql = "SELECT * FROM TAIKHOANNV WHERE TENTK = '" + txtTaikhoan.Text + "' AND PASS = '" + txtMatkhau.Text + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd); DataSet ds = new DataSet();
            adapt.Fill(ds);

            if (tentk != "" || mk != "")
            {
                if (ds.Tables[0].Rows.Count == 0)

                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    string sql2 = "SELECT QUYEN FROM TAIKHOANNV WHERE TENTK = '" + txtTaikhoan.Text + "' AND PASS = '" + txtMatkhau.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    SqlDataAdapter adapt2 = new SqlDataAdapter(cmd2); DataSet ds2 = new DataSet();
                    adapt2.Fill(ds2);
                    if (ds2.Tables[0].Rows[0][0].ToString().Trim() == "user")
                    {
                        if (ds.Tables[0].Rows.Count != 0)
                        {
                            MessageBox.Show("Bạn đã nhập thành công với tư cách là Nhân viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string sql = "SELECT QUYEN FROM TAIKHOANNV WHERE TENTK = '" + txtTaikhoan.Text + "' AND PASS = '" + txtMatkhau.Text + "'";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            SqlDataAdapter adapt1 = new SqlDataAdapter(cmd); DataSet ds1 = new DataSet();
                            adapt1.Fill(ds1);
                            Mainform.Quyen = ds1.Tables[0].Rows[0][0].ToString().Trim();
                            Mainform f = new Mainform();
                            this.Hide();
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (ds2.Tables[0].Rows[0][0].ToString().Trim() == "admin")
                    {
                        MessageBox.Show("Bạn đang đăng nhập với tư cách Nhân viên. Vui lòng đăng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ds2.Tables[0].Rows[0][0].ToString().Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa được cấp quyền đăng nhập. Vui lòng đăng nhập lại sau khi đã được cấp quyền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên tài khoản và mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndangnhapNV_MouseEnter(object sender, EventArgs e)
        {
            btndangnhapNV.BackColor = Color.LightBlue;
        }

        private void btndangnhapNV_MouseLeave(object sender, EventArgs e)
        {
            btndangnhapNV.BackColor = Color.White;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tentk = txtTaikhoan.Text.Trim();
            string mk = txtMatkhau.Text.Trim();
            sql = "SELECT * FROM TAIKHOANNV WHERE TENTK = '" + tentk + "' AND PASS = '" + mk + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd); DataSet ds = new DataSet();
            adapt.Fill(ds);
            if (tentk != "" || mk != "")
            {
                if (ds.Tables[0].Rows.Count == 0)

                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    string sql2 = "SELECT QUYEN FROM TAIKHOANNV WHERE TENTK = '" + tentk + "' AND PASS = '" + mk + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    SqlDataAdapter adapt2 = new SqlDataAdapter(cmd2); DataSet ds2 = new DataSet();
                    adapt2.Fill(ds2);

                    if (ds2.Tables[0].Rows[0][0].ToString().Trim() == "admin")
                    {
                        if (ds.Tables[0].Rows.Count != 0)
                        {
                            MessageBox.Show("Bạn đã đăng nhập thành công với tư cách Quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string sql = "SELECT QUYEN FROM TAIKHOANNV WHERE TENTK = '" + tentk + "' AND PASS = '" + mk + "'";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            SqlDataAdapter adapt1 = new SqlDataAdapter(cmd); DataSet ds1 = new DataSet();
                            adapt1.Fill(ds1);
                            Mainform.Quyen = ds1.Tables[0].Rows[0][0].ToString().Trim();
                            Mainform f = new Mainform();
                            this.Hide();
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (ds2.Tables[0].Rows[0][0].ToString().Trim() == "user")
                    {
                        MessageBox.Show("Bạn không có quyền đăng nhập với tư cách Quản lý. Vui lòng đăng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ds2.Tables[0].Rows[0][0].ToString().Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa được cấp quyền đăng nhập. Vui lòng đăng nhập lại sau khi đã được cấp quyền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                MessageBox.Show("Vui lòng điền tên tài khoản và mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                }
            }
        }

