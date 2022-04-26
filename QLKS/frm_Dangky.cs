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
    public partial class frm_Dangky : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql, connstr;
        public frm_Dangky()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn hủy ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Hide();
                Form f = new frm_Dangnhap();
                f.Show();


            }
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
           if(txttaikhoan.Text == "")
            {
                MessageBox.Show(" Bạn chưa nhập tên tài khoản !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txttaikhoan.Focus(); // Đưa con trỏ chuột về lại 
            }
            else if (txtmatkhau.Text == "")
            {
                MessageBox.Show(" Bạn chưa nhập mật khẩu !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtmatkhau.Focus(); // Đưa con trỏ chuột về lại 
            }
            else if (txtnhaplaimk.Text == "")
            {
                MessageBox.Show(" Bạn chưa xác nhận lại mật khẩu !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtnhaplaimk.Focus(); // Đưa con trỏ chuột về lại 
            }
            else if (txtnhaplaimk.Text != txtmatkhau.Text)
            {
                MessageBox.Show(" Mật khẩu và Nhập lại mật khẩu phải giống nhau !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtnhaplaimk.Focus(); // Đưa con trỏ chuột về lại 
                txtnhaplaimk.SelectAll();
            }
            else
            {
                sql = "Insert into TAIKHOANNV ( TENTK, PASS, HOTEN, SDT, EMAIL) values " +
                    "('" + txttaikhoan.Text + "', '" + txtmatkhau.Text + "', N'" + txthoten.Text + "', '" + txtsdt.Text + "', '" + txtemail.Text + "')";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                MessageBox.Show("Đã đăng ký thành công, hệ thống sẽ quay lại màn hình đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                dt.Clear();
                Form f = new frm_Dangnhap();
                this.Hide();
                f.Show();
            }    
        }

        private void frm_Dangky_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();
        }

        private void txthoten_MouseEnter(object sender, EventArgs e)
        {
            txthoten.BackColor = Color.LightBlue;
        }

        private void txthoten_MouseLeave(object sender, EventArgs e)
        {
            txthoten.BackColor = Color.White;
        }
        private void txtemail_MouseEnter(object sender, EventArgs e)
        {
            txtemail.BackColor = Color.LightBlue;
        }

        private void txtemail_MouseLeave(object sender, EventArgs e)
        {
            txtemail.BackColor = Color.White;
        }

        private void txtsdt_MouseEnter(object sender, EventArgs e)
        {
            txtsdt.BackColor = Color.LightBlue;
        }

        private void txtsdt_MouseLeave(object sender, EventArgs e)
        {
            txtsdt.BackColor = Color.White;
        }

        private void txttaikhoan_MouseEnter(object sender, EventArgs e)
        {
            txttaikhoan.BackColor = Color.LightBlue;
        }

        private void txttaikhoan_MouseLeave(object sender, EventArgs e)
        {
            txttaikhoan.BackColor = Color.White;
        }

        private void txtmatkhau_MouseEnter(object sender, EventArgs e)
        {
            txtmatkhau.BackColor = Color.LightBlue;
        }

        private void txtmatkhau_MouseLeave(object sender, EventArgs e)
        {
            txtmatkhau.BackColor = Color.White;
        }

        private void txtnhaplaimk_MouseEnter(object sender, EventArgs e)
        {
            txtnhaplaimk.BackColor = Color.LightBlue;
        }
        private void txtnhaplaimk_MouseLeave(object sender, EventArgs e)
        {
            txtnhaplaimk.BackColor = Color.White;
        }

        private void btndangky_MouseEnter(object sender, EventArgs e)
        {
            btndangky.BackColor = Color.LightBlue;
        }

        private void btndangky_MouseLeave(object sender, EventArgs e)
        {
            btndangky.BackColor = Color.White;
        }

        private void btnhuy_MouseEnter(object sender, EventArgs e)
        {
            btnhuy.BackColor = Color.LightBlue;
        }
        private void btnhuy_MouseLeave(object sender, EventArgs e)
        {
            btnhuy.BackColor = Color.White;
        }

        private void txttaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || ((e.KeyChar >= 'a') && (e.KeyChar <= 'z')) ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtmatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || ((e.KeyChar >= 'a') && (e.KeyChar <= 'z')) ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }






    }
}
