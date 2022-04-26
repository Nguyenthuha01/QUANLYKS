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
    public partial class frm_Thongtinphong01 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string constr;
        public frm_Thongtinphong01()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frm_Thongtinphong01_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BS05RCC\\HAA;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = " SELECT KHACHHANG.MAKH, KHACHHANG.HOTEN, KHACHHANG.SDT, PHIEUDK.NGAYDEN, PHIEUDK.NGAYDI FROM KHACHHANG , PHIEUDK " +
                "WHERE KHACHHANG.MAKH = PHIEUDK.MAKH AND MAP = 'P01' AND GETDATE() <= NGAYDI AND GETDATE() >= NGAYDEN";
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txtmakh.Text = rd[0].ToString();
                txttenkh.Text = rd[1].ToString();
                txtsdt.Text = rd[2].ToString();
                txtngayden.Text = rd[3].ToString();
                txtngaydi.Text = rd[4].ToString();
            }
            conn.Close();
        }
    }
}
