
namespace QuanlyKS
{
    partial class frm_quanlyTK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNaplai = new System.Windows.Forms.Button();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txttentk = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.grddata = new System.Windows.Forms.DataGridView();
            this.TENTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAIKHOANNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKSDataSet = new QuanlyKS.QLKSDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cmbGiatri = new System.Windows.Forms.ComboBox();
            this.cmbTentruong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquyen = new System.Windows.Forms.ComboBox();
            this.tAIKHOANNVTableAdapter = new QuanlyKS.QLKSDataSetTableAdapters.TAIKHOANNVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNaplai
            // 
            this.btnNaplai.Location = new System.Drawing.Point(277, 132);
            this.btnNaplai.Name = "btnNaplai";
            this.btnNaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNaplai.TabIndex = 297;
            this.btnNaplai.Text = "Nạp lại";
            this.btnNaplai.UseVisualStyleBackColor = true;
            this.btnNaplai.Click += new System.EventHandler(this.btnNaplai_Click);
            // 
            // txthoten
            // 
            this.txthoten.ForeColor = System.Drawing.Color.Black;
            this.txthoten.Location = new System.Drawing.Point(515, 131);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(174, 20);
            this.txthoten.TabIndex = 295;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(412, 131);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 15);
            this.label21.TabIndex = 294;
            this.label21.Text = "Họ và tên";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.ForeColor = System.Drawing.Color.Black;
            this.txtmatkhau.Location = new System.Drawing.Point(515, 106);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(174, 20);
            this.txtmatkhau.TabIndex = 293;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(412, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 15);
            this.label20.TabIndex = 292;
            this.label20.Text = "Mật khẩu";
            // 
            // txttentk
            // 
            this.txttentk.ForeColor = System.Drawing.Color.Black;
            this.txttentk.Location = new System.Drawing.Point(515, 79);
            this.txttentk.Name = "txttentk";
            this.txttentk.Size = new System.Drawing.Size(174, 20);
            this.txttentk.TabIndex = 291;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(412, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 15);
            this.label19.TabIndex = 290;
            this.label19.Text = "Tên tài khoản";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.CadetBlue;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Yellow;
            this.label18.Location = new System.Drawing.Point(410, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 22);
            this.label18.TabIndex = 289;
            this.label18.Text = "Chi tiết phòng";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.CadetBlue;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(396, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(317, 184);
            this.label17.TabIndex = 288;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(569, 262);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 23);
            this.btnXoa.TabIndex = 282;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(419, 262);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(69, 23);
            this.btnThemmoi.TabIndex = 281;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.Location = new System.Drawing.Point(231, 299);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(75, 23);
            this.btnSau.TabIndex = 280;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(150, 299);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnTruoc.TabIndex = 279;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(312, 299);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(75, 23);
            this.btnCuoi.TabIndex = 278;
            this.btnCuoi.Text = ">>";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(69, 299);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(75, 23);
            this.btnDau.TabIndex = 277;
            this.btnDau.Text = "<<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // grddata
            // 
            this.grddata.AutoGenerateColumns = false;
            this.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENTK,
            this.PASS,
            this.HOTEN,
            this.SDT,
            this.EMAIL,
            this.QUYEN});
            this.grddata.DataSource = this.tAIKHOANNVBindingSource;
            this.grddata.Location = new System.Drawing.Point(69, 337);
            this.grddata.Name = "grddata";
            this.grddata.Size = new System.Drawing.Size(644, 174);
            this.grddata.TabIndex = 265;
            this.grddata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddata_CellClick);
            // 
            // TENTK
            // 
            this.TENTK.DataPropertyName = "TENTK";
            this.TENTK.HeaderText = "Tên TK";
            this.TENTK.Name = "TENTK";
            this.TENTK.Width = 120;
            // 
            // PASS
            // 
            this.PASS.DataPropertyName = "PASS";
            this.PASS.HeaderText = "Mật khẩu";
            this.PASS.Name = "PASS";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            // 
            // QUYEN
            // 
            this.QUYEN.DataPropertyName = "QUYEN";
            this.QUYEN.HeaderText = "Quyền";
            this.QUYEN.Name = "QUYEN";
            // 
            // tAIKHOANNVBindingSource
            // 
            this.tAIKHOANNVBindingSource.DataMember = "TAIKHOANNV";
            this.tAIKHOANNVBindingSource.DataSource = this.qLKSDataSet;
            // 
            // qLKSDataSet
            // 
            this.qLKSDataSet.DataSetName = "QLKSDataSet";
            this.qLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.CadetBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(78, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 258;
            this.label8.Text = "Tìm kiếm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(187, 132);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 257;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cmbGiatri
            // 
            this.cmbGiatri.FormattingEnabled = true;
            this.cmbGiatri.Location = new System.Drawing.Point(173, 105);
            this.cmbGiatri.Name = "cmbGiatri";
            this.cmbGiatri.Size = new System.Drawing.Size(179, 21);
            this.cmbGiatri.TabIndex = 256;
            // 
            // cmbTentruong
            // 
            this.cmbTentruong.FormattingEnabled = true;
            this.cmbTentruong.Items.AddRange(new object[] {
            "Tên tài khoản",
            "Họ và tên",
            "Số điện thoại",
            "Quyền"});
            this.cmbTentruong.Location = new System.Drawing.Point(173, 78);
            this.cmbTentruong.Name = "cmbTentruong";
            this.cmbTentruong.Size = new System.Drawing.Size(179, 21);
            this.cmbTentruong.TabIndex = 255;
            this.cmbTentruong.SelectedIndexChanged += new System.EventHandler(this.cmbTentruong_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(94, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 254;
            this.label6.Text = "Giá trị";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.CadetBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(90, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 253;
            this.label9.Text = "Tên trường";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(69, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 99);
            this.label7.TabIndex = 252;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(682, 541);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 251;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(494, 262);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 23);
            this.btnSua.TabIndex = 249;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Location = new System.Drawing.Point(644, 262);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(69, 23);
            this.btnLuu.TabIndex = 248;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 39);
            this.label1.TabIndex = 247;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(412, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 302;
            this.label2.Text = "Quyền";
            // 
            // txtemail
            // 
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Location = new System.Drawing.Point(515, 184);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(174, 20);
            this.txtemail.TabIndex = 301;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(412, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 300;
            this.label3.Text = "Email";
            // 
            // txtsdt
            // 
            this.txtsdt.ForeColor = System.Drawing.Color.Black;
            this.txtsdt.Location = new System.Drawing.Point(515, 157);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(174, 20);
            this.txtsdt.TabIndex = 299;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(412, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 298;
            this.label4.Text = "Số điện thoại";
            // 
            // txtquyen
            // 
            this.txtquyen.FormattingEnabled = true;
            this.txtquyen.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.txtquyen.Location = new System.Drawing.Point(515, 210);
            this.txtquyen.Name = "txtquyen";
            this.txtquyen.Size = new System.Drawing.Size(174, 21);
            this.txtquyen.TabIndex = 303;
            // 
            // tAIKHOANNVTableAdapter
            // 
            this.tAIKHOANNVTableAdapter.ClearBeforeFill = true;
            // 
            // frm_quanlyTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(769, 575);
            this.Controls.Add(this.txtquyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNaplai);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txttentk);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.grddata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cmbGiatri);
            this.Controls.Add(this.cmbTentruong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Name = "frm_quanlyTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frm_quanlyTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNaplai;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txttentk;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.DataGridView grddata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cmbGiatri;
        private System.Windows.Forms.ComboBox cmbTentruong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtquyen;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.BindingSource tAIKHOANNVBindingSource;
        private QLKSDataSetTableAdapters.TAIKHOANNVTableAdapter tAIKHOANNVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYEN;
    }
}