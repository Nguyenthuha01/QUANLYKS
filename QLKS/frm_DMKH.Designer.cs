
namespace QuanlyKS
{
    partial class frm_DMKH
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
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGiatri = new System.Windows.Forms.ComboBox();
            this.cmbTentruong = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grddata = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKSDataSet = new QuanlyKS.QLKSDataSet();
            this.kHACHHANGTableAdapter = new QuanlyKS.QLKSDataSetTableAdapters.KHACHHANGTableAdapter();
            this.txtMakh = new System.Windows.Forms.ComboBox();
            this.btnNaplai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.Location = new System.Drawing.Point(185, 288);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(75, 23);
            this.btnSau.TabIndex = 179;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(104, 288);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnTruoc.TabIndex = 178;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(511, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 177;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 176;
            this.label8.Text = "Email";
            // 
            // txtFb
            // 
            this.txtFb.Location = new System.Drawing.Point(511, 196);
            this.txtFb.Name = "txtFb";
            this.txtFb.Size = new System.Drawing.Size(170, 20);
            this.txtFb.TabIndex = 175;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 174;
            this.label7.Text = "Facebook";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(511, 170);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(170, 20);
            this.txtDiachi.TabIndex = 173;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 172;
            this.label6.Text = "Địa chỉ";
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(511, 91);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(170, 20);
            this.txtTenkh.TabIndex = 171;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 170;
            this.label5.Text = "Tên khách hàng";
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(511, 143);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(170, 20);
            this.txtCmnd.TabIndex = 169;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 168;
            this.label4.Text = "CMND";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(511, 117);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(170, 20);
            this.txtSdt.TabIndex = 167;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 166;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 164;
            this.label2.Text = "Mã khách hàng";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.CadetBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(414, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 29);
            this.label13.TabIndex = 163;
            this.label13.Text = "Chi tiết";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.CadetBlue;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(394, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(313, 193);
            this.label14.TabIndex = 162;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(171, 131);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 161;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 160;
            this.label10.Text = "Giá trị";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 159;
            this.label9.Text = "Tên trường";
            // 
            // cmbGiatri
            // 
            this.cmbGiatri.FormattingEnabled = true;
            this.cmbGiatri.Location = new System.Drawing.Point(171, 104);
            this.cmbGiatri.Name = "cmbGiatri";
            this.cmbGiatri.Size = new System.Drawing.Size(158, 21);
            this.cmbGiatri.TabIndex = 158;
            // 
            // cmbTentruong
            // 
            this.cmbTentruong.FormattingEnabled = true;
            this.cmbTentruong.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng",
            "Số điện thoại",
            "CMND"});
            this.cmbTentruong.Location = new System.Drawing.Point(171, 77);
            this.cmbTentruong.Name = "cmbTentruong";
            this.cmbTentruong.Size = new System.Drawing.Size(158, 21);
            this.cmbTentruong.TabIndex = 157;
            this.cmbTentruong.SelectedIndexChanged += new System.EventHandler(this.cmbTentruong_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.CadetBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(87, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 21);
            this.label11.TabIndex = 156;
            this.label11.Text = "Tìm kiếm";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.CadetBlue;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(76, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 113);
            this.label12.TabIndex = 155;
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(266, 288);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(75, 23);
            this.btnCuoi.TabIndex = 154;
            this.btnCuoi.Text = ">>";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(23, 288);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(75, 23);
            this.btnDau.TabIndex = 153;
            this.btnDau.Text = "<<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(587, 270);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 151;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(496, 270);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 150;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCapnhat.Location = new System.Drawing.Point(677, 270);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 149;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(677, 539);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 152;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(405, 270);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemmoi.TabIndex = 148;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 38);
            this.label1.TabIndex = 146;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grddata
            // 
            this.grddata.AutoGenerateColumns = false;
            this.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.HOTEN,
            this.SDT,
            this.CMND,
            this.DIACHI,
            this.FB,
            this.EMAIL});
            this.grddata.DataSource = this.kHACHHANGBindingSource;
            this.grddata.Location = new System.Drawing.Point(15, 329);
            this.grddata.Name = "grddata";
            this.grddata.Size = new System.Drawing.Size(737, 199);
            this.grddata.TabIndex = 180;
            this.grddata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddata_CellClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 120;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Tên khách hàng";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 140;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 90;
            // 
            // FB
            // 
            this.FB.DataPropertyName = "FB";
            this.FB.HeaderText = "Face book";
            this.FB.Name = "FB";
            this.FB.Width = 90;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLKSDataSet;
            // 
            // qLKSDataSet
            // 
            this.qLKSDataSet.DataSetName = "QLKSDataSet";
            this.qLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // txtMakh
            // 
            this.txtMakh.FormattingEnabled = true;
            this.txtMakh.Location = new System.Drawing.Point(511, 64);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(170, 21);
            this.txtMakh.TabIndex = 181;
            // 
            // btnNaplai
            // 
            this.btnNaplai.Location = new System.Drawing.Point(254, 131);
            this.btnNaplai.Name = "btnNaplai";
            this.btnNaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNaplai.TabIndex = 182;
            this.btnNaplai.Text = "Nạp lại";
            this.btnNaplai.UseVisualStyleBackColor = true;
            this.btnNaplai.Click += new System.EventHandler(this.btnNaplai_Click);
            // 
            // frm_DMKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(772, 574);
            this.Controls.Add(this.btnNaplai);
            this.Controls.Add(this.txtMakh);
            this.Controls.Add(this.grddata);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenkh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCmnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbGiatri);
            this.Controls.Add(this.cmbTentruong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.label1);
            this.Name = "frm_DMKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH MỤC KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frm_DMKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGiatri;
        private System.Windows.Forms.ComboBox cmbTentruong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grddata;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLKSDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FB;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.ComboBox txtMakh;
        private System.Windows.Forms.Button btnNaplai;
    }
}