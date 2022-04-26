using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKS
{
    public partial class Mainform : Form
    {
        public static string Quyen;
        public Mainform()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dmp_Click(object sender, EventArgs e)
        {
            Form f = new frm_DMP();
            f.ShowDialog();
        }

        private void dmlp_Click(object sender, EventArgs e)
        {
            Form f = new frm_DMLP();
            f.ShowDialog();
        }

        private void dmdv_Click(object sender, EventArgs e)
        {
            Form f = new frm_DMDV();
            f.ShowDialog();
        }

        private void dmkh_Click(object sender, EventArgs e)
        {
            Form f = new frm_DMKH();
            f.ShowDialog();
        }

        private void btndmp_Click(object sender, EventArgs e)
        {
            btndmp.BackColor = Color.CadetBlue;
            Form f = new frm_DMP();
            f.ShowDialog();
            btndmp.BackColor = Color.White;
        }
        private void btndmdv_Click(object sender, EventArgs e)
        {
                btndmdv.BackColor = Color.CadetBlue;
                Form f = new frm_DMDV();
                f.ShowDialog();       
                btndmdv.BackColor = Color.White;
        }

        private void Dangxuat_Click(object sender, EventArgs e)
        {
            Form f = new frm_Dangnhap();
            this.Hide();
            f.Show();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            Form f = new frm_Dangnhap();
            this.Hide();
            f.Show();
        }

        private void doimk_Click(object sender, EventArgs e)
        {
            Form f = new frm_Doimk();
            this.Hide();
            f.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            if(Quyen == "user")
            {
                quanlytk.Visible= false;
                baocao.Visible = false;
       
            }    
        }

        private void btnDangkyphong_Click(object sender, EventArgs e)
        {
                btnDangkyphong.BackColor = Color.CadetBlue;
                Form f = new frm_PhieuDKP();
                f.ShowDialog();
                btnDangkyphong.BackColor = Color.White;
        }

        private void btnHuydkp_Click(object sender, EventArgs e)
        {
                btnHuydkp.BackColor = Color.CadetBlue;
                Form f = new frm_PhieuHDK();
                f.ShowDialog();
                btnHuydkp.BackColor = Color.White;
        }

        private void btnSDDV_Click(object sender, EventArgs e)
        {
                btnSDDV.BackColor = Color.CadetBlue;
                Form f = new frm_PhieuSDDV();
                f.ShowDialog();
                btnSDDV.BackColor = Color.White;
        }

        private void phieudkp_Click(object sender, EventArgs e)
        {
            Form f = new frm_PhieuDKP();
            f.ShowDialog();
        }

        private void phieuhdk_Click(object sender, EventArgs e)
        {
            Form f = new frm_PhieuHDK();
            f.ShowDialog();
        }

        private void phieusddv_Click(object sender, EventArgs e)
        {
            Form f = new frm_PhieuSDDV();
            f.ShowDialog();
        }

        private void hoadontt_Click(object sender, EventArgs e)
        {
            Form f = new frm_Hoadontt();
            f.ShowDialog();
        }


        private void phong1_Click(object sender, EventArgs e)
        {
            Form f = new frm_Thongtinphong01();
            f.ShowDialog();
        }   

        private void cmsDao_Click(object sender, EventArgs e)
        {
            phong1.BackColor = Color.Red;
        }

        private void cmsTrong_Click(object sender, EventArgs e)
        {
            phong1.BackColor = Color.Teal;
        }
        private void phong02_Click(object sender, EventArgs e)
        {
            Form f = new frm_Thongtinphong02();
            f.ShowDialog();
        }

        private void cmsDao1_Click(object sender, EventArgs e)
        {
            phong2.BackColor = Color.Red;
        }

        private void cmsTrong1_Click(object sender, EventArgs e)
        {
            phong2.BackColor = Color.Teal;
        }
        private void btnHoadonTT_Click(object sender, EventArgs e)
        {
            btnHoadonTT.BackColor = Color.CadetBlue;
            Form f = new frm_Hoadontt();
            f.ShowDialog();
            btnHoadonTT.BackColor = Color.White;
        }

        private void cmsdangsc_Click(object sender, EventArgs e)
        {
            phong1.BackColor = Color.Gray;
        }

        private void cmsDadattruoc_Click_1(object sender, EventArgs e)
        {
            phong1.BackColor = Color.Khaki;
        }

        private void cmsdadattruoc1_Click(object sender, EventArgs e)
        {
            phong2.BackColor = Color.Khaki;
        }

        private void cmsDangsc1_Click(object sender, EventArgs e)
        {
            phong2.BackColor = Color.Gray;
        }

        private void thongtinks_Click(object sender, EventArgs e)
        {
            frm_Thongtinks f = new frm_Thongtinks();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void báoCáoDoanhThuPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frm_NhapnngayDTP();
            f.ShowDialog();
        }

        private void quanlytk_Click(object sender, EventArgs e)
        {
            frm_quanlyTK f = new frm_quanlyTK();
            f.ShowDialog();
        }

        private void báoCáoDoanhThuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhapngayDTDV f = new frm_NhapngayDTDV();
            f.ShowDialog();
        }

        private void hiệuSuấtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhapngaybcHSP f = new frm_NhapngaybcHSP();
            f.ShowDialog();
        }
    }
}
