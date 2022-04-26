
namespace QuanlyKS
{
    partial class frm_DMLP
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
            this.txtmalp = new System.Windows.Forms.ComboBox();
            this.btnNaplai = new System.Windows.Forms.Button();
            this.grddata = new System.Windows.Forms.DataGridView();
            this.MALP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKSDataSet = new QuanlyKS.QLKSDataSet();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txttenlp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cmbGiatri = new System.Windows.Forms.ComboBox();
            this.cmbTentruong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lOAIPHONGTableAdapter = new QuanlyKS.QLKSDataSetTableAdapters.LOAIPHONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmalp
            // 
            this.txtmalp.FormattingEnabled = true;
            this.txtmalp.Location = new System.Drawing.Point(551, 92);
            this.txtmalp.Name = "txtmalp";
            this.txtmalp.Size = new System.Drawing.Size(126, 21);
            this.txtmalp.TabIndex = 241;
            // 
            // btnNaplai
            // 
            this.btnNaplai.Location = new System.Drawing.Point(265, 156);
            this.btnNaplai.Name = "btnNaplai";
            this.btnNaplai.Size = new System.Drawing.Size(61, 23);
            this.btnNaplai.TabIndex = 240;
            this.btnNaplai.Text = "Nạp lại";
            this.btnNaplai.UseVisualStyleBackColor = true;
            this.btnNaplai.Click += new System.EventHandler(this.btnNaplai_Click);
            // 
            // grddata
            // 
            this.grddata.AutoGenerateColumns = false;
            this.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALP,
            this.TENLP});
            this.grddata.DataSource = this.lOAIPHONGBindingSource;
            this.grddata.Location = new System.Drawing.Point(71, 327);
            this.grddata.Name = "grddata";
            this.grddata.Size = new System.Drawing.Size(656, 202);
            this.grddata.TabIndex = 239;
            this.grddata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddata_CellClick);
            // 
            // MALP
            // 
            this.MALP.DataPropertyName = "MALP";
            this.MALP.HeaderText = "Mã loại phòng";
            this.MALP.Name = "MALP";
            this.MALP.Width = 250;
            // 
            // TENLP
            // 
            this.TENLP.DataPropertyName = "TENLP";
            this.TENLP.HeaderText = "Tên loại phòng";
            this.TENLP.Name = "TENLP";
            this.TENLP.Width = 380;
            // 
            // lOAIPHONGBindingSource
            // 
            this.lOAIPHONGBindingSource.DataMember = "LOAIPHONG";
            this.lOAIPHONGBindingSource.DataSource = this.qLKSDataSet;
            // 
            // qLKSDataSet
            // 
            this.qLKSDataSet.DataSetName = "QLKSDataSet";
            this.qLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.Location = new System.Drawing.Point(233, 286);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(75, 23);
            this.btnSau.TabIndex = 238;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(152, 286);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnTruoc.TabIndex = 237;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.CadetBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(446, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 236;
            this.label11.Text = "Chi tiết";
            // 
            // txttenlp
            // 
            this.txttenlp.Location = new System.Drawing.Point(551, 130);
            this.txttenlp.Name = "txttenlp";
            this.txttenlp.Size = new System.Drawing.Size(126, 20);
            this.txttenlp.TabIndex = 231;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(448, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 230;
            this.label3.Text = "Tên loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(448, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 229;
            this.label2.Text = "Mã loại phòng";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.CadetBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(431, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 113);
            this.label10.TabIndex = 228;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.CadetBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(101, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 227;
            this.label8.Text = "Tìm kiếm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(197, 156);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(62, 23);
            this.btnTimkiem.TabIndex = 226;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cmbGiatri
            // 
            this.cmbGiatri.FormattingEnabled = true;
            this.cmbGiatri.Location = new System.Drawing.Point(181, 129);
            this.cmbGiatri.Name = "cmbGiatri";
            this.cmbGiatri.Size = new System.Drawing.Size(145, 21);
            this.cmbGiatri.TabIndex = 225;
            // 
            // cmbTentruong
            // 
            this.cmbTentruong.FormattingEnabled = true;
            this.cmbTentruong.Items.AddRange(new object[] {
            "Mã loại phòng",
            "Tên loại phòng"});
            this.cmbTentruong.Location = new System.Drawing.Point(181, 91);
            this.cmbTentruong.Name = "cmbTentruong";
            this.cmbTentruong.Size = new System.Drawing.Size(145, 21);
            this.cmbTentruong.TabIndex = 224;
            this.cmbTentruong.SelectedIndexChanged += new System.EventHandler(this.cmbTentruong_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(101, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 223;
            this.label6.Text = "Giá trị";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.CadetBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(101, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 222;
            this.label9.Text = "Tên trường";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(90, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 113);
            this.label7.TabIndex = 221;
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(314, 286);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(75, 23);
            this.btnCuoi.TabIndex = 220;
            this.btnCuoi.Text = ">>";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(71, 286);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(75, 23);
            this.btnDau.TabIndex = 219;
            this.btnDau.Text = "<<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(671, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 218;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCapnhat.Location = new System.Drawing.Point(652, 220);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 217;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(571, 220);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 216;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(490, 220);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 215;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(409, 220);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemmoi.TabIndex = 214;
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
            this.label1.Size = new System.Drawing.Size(771, 36);
            this.label1.TabIndex = 213;
            this.label1.Text = "DANH MỤC LOẠI PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lOAIPHONGTableAdapter
            // 
            this.lOAIPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // frm_DMLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(769, 569);
            this.Controls.Add(this.txtmalp);
            this.Controls.Add(this.btnNaplai);
            this.Controls.Add(this.grddata);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txttenlp);
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
            this.Name = "frm_DMLP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH MỤC LOẠI PHÒNG";
            this.Load += new System.EventHandler(this.frm_DMLP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtmalp;
        private System.Windows.Forms.Button btnNaplai;
        private System.Windows.Forms.DataGridView grddata;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttenlp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cmbGiatri;
        private System.Windows.Forms.ComboBox cmbTentruong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Label label1;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.BindingSource lOAIPHONGBindingSource;
        private QLKSDataSetTableAdapters.LOAIPHONGTableAdapter lOAIPHONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLP;
    }
}