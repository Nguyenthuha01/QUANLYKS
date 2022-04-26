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
    public partial class frm_Doimk : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql, connstr;
        int i = 0;

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            if ( txtTaikhoan.Text != "" && txtMatkhaucu.Text != "" && (txtMatkhaumoi.Text != null) && (txtNhaplaimk.Text != null))
            {

                sql = "SELECT * FROM TAIKHOANNV WHERE TENTK = '" + txtTaikhoan.Text + "' AND PASS = '" + txtMatkhaucu.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt);
                if (i < 3)
                {
                    if (dt.Rows.Count != 0)
                    {
                        if (txtMatkhaumoi.Text == txtMatkhaucu.Text)
                        {
                            MessageBox.Show(" Mật khẩu mới phải khác mật khẩu cũ. Bạn có muốn tiếp tục thay đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            txtMatkhaucu.Text = "";
                            txtMatkhaumoi.Text = "";
                            txtNhaplaimk.Text = "";
                            
                        }
                        else
                        {
                            if (txtMatkhaumoi.Text == txtNhaplaimk.Text)
                            {


                                if (MessageBox.Show("Bạn có muốn đổi mật khẩu", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    sql = "Update TAIKHOANNV set PASS='" + txtMatkhaumoi.Text + "' where TENTK ='" + txtTaikhoan.Text + "'";
                                    da = new SqlDataAdapter(sql, conn);
                                    dt.Clear();
                                    da.Fill(dt);
                                    MessageBox.Show("Đã đổi mật khẩu thành công, hệ thống sẽ quay lại màn hình đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dt.Clear();
                                    Form f = new frm_Dangnhap();
                                    this.Hide();
                                    f.Show();
                                    
                                }

                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu mới không khớp vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMatkhaucu.Text = "";
                                txtMatkhaumoi.Text = "";
                                txtNhaplaimk.Text = "";
                               
                            }
                        }

                    }
                    else
                    {
                        i++;
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatkhaucu.Text = "";
                        txtMatkhaumoi.Text = "";
                        txtNhaplaimk.Text = "";                      
                    }
                }
                else
                {
                    i = 0;
                    MessageBox.Show("Nhập sai quá nhiều lần, hệ thống sẽ quay lại màn hình đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form f = new frm_Dangnhap();
                    this.Hide();
                    f.Show();
                    
                }
            }
        }

        private void txtNhaplaimk_Enter(object sender, EventArgs e)
        {
            btnDoimk.Focus();
        }

        private void txtNhaplaimk_Leave(object sender, EventArgs e)
        {
            btnDoimk.Focus();
        }
        private void frm_Doimk_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn hủy ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Hide();
                conn.Close();
                Form f = new Mainform();
                f.Show();
            }
        }

        private void txtTaikhoan_MouseEnter(object sender, EventArgs e)
        {
            txtTaikhoan.BackColor = Color.LightBlue;
        }

        private void txtTaikhoan_MouseLeave(object sender, EventArgs e)
        {
            txtTaikhoan.BackColor = Color.White;
        }

        private void txtMatkhaucu_MouseEnter(object sender, EventArgs e)
        {
            txtMatkhaucu.BackColor = Color.LightBlue;
        }

        private void txtMatkhaucu_MouseLeave(object sender, EventArgs e)
        {
            txtMatkhaucu.BackColor = Color.White;
        }

        private void txtMatkhaumoi_MouseEnter(object sender, EventArgs e)
        {
            txtMatkhaumoi.BackColor = Color.LightBlue;
        }

        private void txtMatkhaumoi_MouseLeave(object sender, EventArgs e)
        {
            txtMatkhaumoi.BackColor = Color.White;
        }

        private void txtNhaplaimk_MouseEnter(object sender, EventArgs e)
        {
            txtNhaplaimk.BackColor = Color.LightBlue;
        }

        private void txtNhaplaimk_MouseLeave(object sender, EventArgs e)
        {
            txtNhaplaimk.BackColor = Color.White;
        }

        private void btnDoimk_MouseEnter(object sender, EventArgs e)
        {
            btnDoimk.BackColor = Color.LightBlue;
        }

        private void btnDoimk_MouseLeave(object sender, EventArgs e)
        {
            btnDoimk.BackColor = Color.White;
        }

        private void btnHuy_MouseEnter(object sender, EventArgs e)
        {
            btnHuy.BackColor = Color.LightBlue;
        }

        private void btnHuy_MouseLeave(object sender, EventArgs e)
        {
            btnHuy.BackColor = Color.White;
        }

        public frm_Doimk()
        {
            InitializeComponent();
            //SplitContainer.Fix = System.Windows.Forms.FixedPanel.Panel1;
        }

        
    }
}
