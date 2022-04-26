
namespace QuanlyKS
{
    partial class frm_DMDV
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGiatri = new System.Windows.Forms.ComboBox();
            this.cmbTentruong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTendv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.grddata = new System.Windows.Forms.DataGridView();
            this.MADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKSDataSet = new QuanlyKS.QLKSDataSet();
            this.dICHVUTableAdapter = new QuanlyKS.QLKSDataSetTableAdapters.DICHVUTableAdapter();
            this.btnNaplai = new System.Windows.Forms.Button();
            this.txtMadv = new System.Windows.Forms.ComboBox();
            this.txtDvt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(684, 534);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 74;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCapnhat.Location = new System.Drawing.Point(682, 264);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 73;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(591, 264);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 72;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(500, 264);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 71;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(410, 264);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemmoi.TabIndex = 70;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 36);
            this.label1.TabIndex = 63;
            this.label1.Text = "DANH MỤC DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(265, 285);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(75, 23);
            this.btnCuoi.TabIndex = 84;
            this.btnCuoi.Text = ">>";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(22, 285);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(75, 23);
            this.btnDau.TabIndex = 83;
            this.btnDau.Text = "<<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(90, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 113);
            this.label7.TabIndex = 87;
            // 
            // cmbGiatri
            // 
            this.cmbGiatri.FormattingEnabled = true;
            this.cmbGiatri.Location = new System.Drawing.Point(181, 128);
            this.cmbGiatri.Name = "cmbGiatri";
            this.cmbGiatri.Size = new System.Drawing.Size(145, 21);
            this.cmbGiatri.TabIndex = 91;
            // 
            // cmbTentruong
            // 
            this.cmbTentruong.FormattingEnabled = true;
            this.cmbTentruong.Items.AddRange(new object[] {
            "Mã dịch vụ",
            "Tên dịch vụ"});
            this.cmbTentruong.Location = new System.Drawing.Point(181, 90);
            this.cmbTentruong.Name = "cmbTentruong";
            this.cmbTentruong.Size = new System.Drawing.Size(145, 21);
            this.cmbTentruong.TabIndex = 90;
            this.cmbTentruong.SelectedIndexChanged += new System.EventHandler(this.cmbTentruong_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(101, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 89;
            this.label6.Text = "Giá trị";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.CadetBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(101, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 88;
            this.label9.Text = "Tên trường";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(197, 155);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(62, 23);
            this.btnTimkiem.TabIndex = 92;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.CadetBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(101, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 93;
            this.label8.Text = "Tìm kiếm";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.CadetBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(454, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 168);
            this.label10.TabIndex = 102;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(574, 209);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(126, 20);
            this.txtDongia.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(471, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 109;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(471, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 107;
            this.label5.Text = "Đơn vị tính";
            // 
            // txtTendv
            // 
            this.txtTendv.Location = new System.Drawing.Point(574, 129);
            this.txtTendv.Name = "txtTendv";
            this.txtTendv.Size = new System.Drawing.Size(126, 20);
            this.txtTendv.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(471, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 105;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(471, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 103;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.CadetBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(469, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 111;
            this.label11.Text = "Chi tiết";
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.Location = new System.Drawing.Point(184, 285);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(75, 23);
            this.btnSau.TabIndex = 113;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(103, 285);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnTruoc.TabIndex = 112;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // grddata
            // 
            this.grddata.AutoGenerateColumns = false;
            this.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADV,
            this.TENDV,
            this.DVT,
            this.DONGIA});
            this.grddata.DataSource = this.dICHVUBindingSource;
            this.grddata.Location = new System.Drawing.Point(22, 326);
            this.grddata.Name = "grddata";
            this.grddata.Size = new System.Drawing.Size(737, 202);
            this.grddata.TabIndex = 181;
            this.grddata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddata_CellClick);
            // 
            // MADV
            // 
            this.MADV.DataPropertyName = "MADV";
            this.MADV.HeaderText = "Mã dịch vụ";
            this.MADV.Name = "MADV";
            this.MADV.Width = 160;
            // 
            // TENDV
            // 
            this.TENDV.DataPropertyName = "TENDV";
            this.TENDV.HeaderText = "Tên dịch vụ";
            this.TENDV.Name = "TENDV";
            this.TENDV.Width = 200;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            this.DVT.Width = 160;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 200;
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.qLKSDataSet;
            // 
            // qLKSDataSet
            // 
            this.qLKSDataSet.DataSetName = "QLKSDataSet";
            this.qLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // btnNaplai
            // 
            this.btnNaplai.Location = new System.Drawing.Point(265, 155);
            this.btnNaplai.Name = "btnNaplai";
            this.btnNaplai.Size = new System.Drawing.Size(61, 23);
            this.btnNaplai.TabIndex = 182;
            this.btnNaplai.Text = "Nạp lại";
            this.btnNaplai.UseVisualStyleBackColor = true;
            this.btnNaplai.Click += new System.EventHandler(this.btnNaplai_Click);
            // 
            // txtMadv
            // 
            this.txtMadv.FormattingEnabled = true;
            this.txtMadv.Location = new System.Drawing.Point(574, 91);
            this.txtMadv.Name = "txtMadv";
            this.txtMadv.Size = new System.Drawing.Size(126, 21);
            this.txtMadv.TabIndex = 183;
            // 
            // txtDvt
            // 
            this.txtDvt.FormattingEnabled = true;
            this.txtDvt.Location = new System.Drawing.Point(574, 170);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(126, 21);
            this.txtDvt.TabIndex = 184;
            // 
            // frm_DMDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(769, 569);
            this.Controls.Add(this.txtDvt);
            this.Controls.Add(this.txtMadv);
            this.Controls.Add(this.btnNaplai);
            this.Controls.Add(this.grddata);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTendv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cmbGiatri);
            this.Controls.Add(this.cmbTentruong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_DMDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH MỤC DỊCH VỤ";
            this.Load += new System.EventHandler(this.frm_DMDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGiatri;
        private System.Windows.Forms.ComboBox cmbTentruong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTendv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.DataGridView grddata;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private QLKSDataSetTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.Button btnNaplai;
        private System.Windows.Forms.ComboBox txtMadv;
        private System.Windows.Forms.ComboBox txtDvt;
    }
}