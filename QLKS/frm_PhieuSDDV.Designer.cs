
namespace QuanlyKS
{
    partial class frm_PhieuSDDV
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
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnSau1 = new System.Windows.Forms.Button();
            this.btnTruoc1 = new System.Windows.Forms.Button();
            this.btnCuoi1 = new System.Windows.Forms.Button();
            this.btnDau1 = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grddata1 = new System.Windows.Forms.DataGridView();
            this.MAPDVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUSDDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKSDataSet = new QuanlyKS.QLKSDataSet();
            this.grddata = new System.Windows.Forms.DataGridView();
            this.MADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cmbGiatri = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbTentruong = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnInphieu = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.dICHVUTableAdapter = new QuanlyKS.QLKSDataSetTableAdapters.DICHVUTableAdapter();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtmapdk = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtmap = new System.Windows.Forms.ComboBox();
            this.txtmadv1 = new System.Windows.Forms.ComboBox();
            this.txtngaysd = new System.Windows.Forms.DateTimePicker();
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txttendv = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnNaplai = new System.Windows.Forms.Button();
            this.pHIEUSDDVTableAdapter = new QuanlyKS.QLKSDataSetTableAdapters.PHIEUSDDVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grddata1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUSDDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSau
            // 
            this.btnSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.Location = new System.Drawing.Point(588, 508);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(75, 23);
            this.btnSau.TabIndex = 260;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.Location = new System.Drawing.Point(507, 508);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnTruoc.TabIndex = 259;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(669, 508);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(75, 23);
            this.btnCuoi.TabIndex = 258;
            this.btnCuoi.Text = ">>";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnSau1
            // 
            this.btnSau1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau1.Location = new System.Drawing.Point(588, 233);
            this.btnSau1.Name = "btnSau1";
            this.btnSau1.Size = new System.Drawing.Size(75, 23);
            this.btnSau1.TabIndex = 264;
            this.btnSau1.Text = ">";
            this.btnSau1.UseVisualStyleBackColor = true;
            this.btnSau1.Click += new System.EventHandler(this.btnSau1_Click);
            // 
            // btnTruoc1
            // 
            this.btnTruoc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc1.Location = new System.Drawing.Point(507, 233);
            this.btnTruoc1.Name = "btnTruoc1";
            this.btnTruoc1.Size = new System.Drawing.Size(75, 23);
            this.btnTruoc1.TabIndex = 263;
            this.btnTruoc1.Text = "<";
            this.btnTruoc1.UseVisualStyleBackColor = true;
            this.btnTruoc1.Click += new System.EventHandler(this.btnTruoc1_Click);
            // 
            // btnCuoi1
            // 
            this.btnCuoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi1.Location = new System.Drawing.Point(669, 233);
            this.btnCuoi1.Name = "btnCuoi1";
            this.btnCuoi1.Size = new System.Drawing.Size(75, 23);
            this.btnCuoi1.TabIndex = 262;
            this.btnCuoi1.Text = ">>";
            this.btnCuoi1.UseVisualStyleBackColor = true;
            this.btnCuoi1.Click += new System.EventHandler(this.btnCuoi1_Click);
            // 
            // btnDau1
            // 
            this.btnDau1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau1.Location = new System.Drawing.Point(426, 233);
            this.btnDau1.Name = "btnDau1";
            this.btnDau1.Size = new System.Drawing.Size(75, 23);
            this.btnDau1.TabIndex = 261;
            this.btnDau1.Text = "<<";
            this.btnDau1.UseVisualStyleBackColor = true;
            this.btnDau1.Click += new System.EventHandler(this.btnDau1_Click);
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(426, 508);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(75, 23);
            this.btnDau.TabIndex = 257;
            this.btnDau.Text = "<<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(57, 477);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 251;
            this.label16.Text = "Ngày sử dụng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(393, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 18);
            this.label13.TabIndex = 250;
            this.label13.Text = "Thông tin phiếu sử dụng dịch vụ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(393, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 18);
            this.label12.TabIndex = 249;
            this.label12.Text = "Thông tin dịch vụ";
            // 
            // grddata1
            // 
            this.grddata1.AutoGenerateColumns = false;
            this.grddata1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddata1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPDVU,
            this.MAP,
            this.MADVU,
            this.SL,
            this.NGAYSD});
            this.grddata1.DataSource = this.pHIEUSDDVBindingSource;
            this.grddata1.Location = new System.Drawing.Point(396, 312);
            this.grddata1.Name = "grddata1";
            this.grddata1.Size = new System.Drawing.Size(349, 180);
            this.grddata1.TabIndex = 248;
            this.grddata1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddata1_CellClick);
            // 
            // MAPDVU
            // 
            this.MAPDVU.DataPropertyName = "MAPDV";
            this.MAPDVU.HeaderText = "MAPDV";
            this.MAPDVU.Name = "MAPDVU";
            // 
            // MAP
            // 
            this.MAP.DataPropertyName = "MAP";
            this.MAP.HeaderText = "MAP";
            this.MAP.Name = "MAP";
            // 
            // MADVU
            // 
            this.MADVU.DataPropertyName = "MADV";
            this.MADVU.HeaderText = "MADV";
            this.MADVU.Name = "MADVU";
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // NGAYSD
            // 
            this.NGAYSD.DataPropertyName = "NGAYSD";
            this.NGAYSD.HeaderText = "NGAYSD";
            this.NGAYSD.Name = "NGAYSD";
            // 
            // pHIEUSDDVBindingSource
            // 
            this.pHIEUSDDVBindingSource.DataMember = "PHIEUSDDV";
            this.pHIEUSDDVBindingSource.DataSource = this.qLKSDataSet;
            // 
            // qLKSDataSet
            // 
            this.qLKSDataSet.DataSetName = "QLKSDataSet";
            this.qLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.grddata.Location = new System.Drawing.Point(396, 89);
            this.grddata.Name = "grddata";
            this.grddata.Size = new System.Drawing.Size(349, 128);
            this.grddata.TabIndex = 247;
            this.grddata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddata_CellClick);
            // 
            // MADV
            // 
            this.MADV.DataPropertyName = "MADV";
            this.MADV.HeaderText = "Mã dịch vụ";
            this.MADV.Name = "MADV";
            this.MADV.Width = 90;
            // 
            // TENDV
            // 
            this.TENDV.DataPropertyName = "TENDV";
            this.TENDV.HeaderText = "Tên dịch vụ";
            this.TENDV.Name = "TENDV";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "ĐVT";
            this.DVT.Name = "DVT";
            this.DVT.Width = 50;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.qLKSDataSet;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.CadetBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(57, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 246;
            this.label11.Text = "Chi tiết sử dụng DV";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(160, 451);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(177, 20);
            this.txtsoluong.TabIndex = 245;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(57, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 244;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(57, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 242;
            this.label5.Text = "Mã dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 240;
            this.label3.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 238;
            this.label2.Text = "Mã phiếu SDDV";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.CadetBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 157);
            this.label10.TabIndex = 237;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.CadetBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(55, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 236;
            this.label8.Text = "Tìm kiếm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(182, 157);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 235;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cmbGiatri
            // 
            this.cmbGiatri.FormattingEnabled = true;
            this.cmbGiatri.Location = new System.Drawing.Point(161, 130);
            this.cmbGiatri.Name = "cmbGiatri";
            this.cmbGiatri.Size = new System.Drawing.Size(179, 21);
            this.cmbGiatri.TabIndex = 234;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(71, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 232;
            this.label6.Text = "Giá trị";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.CadetBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(67, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 231;
            this.label9.Text = "Tên trường";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 102);
            this.label7.TabIndex = 230;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(670, 559);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 229;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 36);
            this.label1.TabIndex = 225;
            this.label1.Text = "PHIẾU SỬ DỤNG DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 233;
            // 
            // cmbTentruong
            // 
            this.cmbTentruong.FormattingEnabled = true;
            this.cmbTentruong.Items.AddRange(new object[] {
            "Mã phiếu dịch vụ",
            "Mã phòng"});
            this.cmbTentruong.Location = new System.Drawing.Point(161, 103);
            this.cmbTentruong.Name = "cmbTentruong";
            this.cmbTentruong.Size = new System.Drawing.Size(179, 21);
            this.cmbTentruong.TabIndex = 265;
            this.cmbTentruong.SelectedIndexChanged += new System.EventHandler(this.cmbTentruong_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(200, 532);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 270;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(119, 532);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 269;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnInphieu
            // 
            this.btnInphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInphieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInphieu.Location = new System.Drawing.Point(279, 565);
            this.btnInphieu.Name = "btnInphieu";
            this.btnInphieu.Size = new System.Drawing.Size(75, 23);
            this.btnInphieu.TabIndex = 268;
            this.btnInphieu.Text = "In phiếu";
            this.btnInphieu.UseVisualStyleBackColor = true;
            this.btnInphieu.Click += new System.EventHandler(this.btnInphieu_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(38, 532);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemmoi.TabIndex = 267;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Location = new System.Drawing.Point(281, 532);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 271;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtmapdk
            // 
            this.txtmapdk.FormattingEnabled = true;
            this.txtmapdk.Location = new System.Drawing.Point(160, 372);
            this.txtmapdk.Name = "txtmapdk";
            this.txtmapdk.Size = new System.Drawing.Size(177, 21);
            this.txtmapdk.TabIndex = 272;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.CadetBlue;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(40, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(314, 122);
            this.label14.TabIndex = 273;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.CadetBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Yellow;
            this.label15.Location = new System.Drawing.Point(55, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 23);
            this.label15.TabIndex = 274;
            this.label15.Text = "Chi tiết dịch vụ";
            // 
            // txtmap
            // 
            this.txtmap.FormattingEnabled = true;
            this.txtmap.Location = new System.Drawing.Point(160, 398);
            this.txtmap.Name = "txtmap";
            this.txtmap.Size = new System.Drawing.Size(177, 21);
            this.txtmap.TabIndex = 275;
            // 
            // txtmadv1
            // 
            this.txtmadv1.FormattingEnabled = true;
            this.txtmadv1.Location = new System.Drawing.Point(160, 424);
            this.txtmadv1.Name = "txtmadv1";
            this.txtmadv1.Size = new System.Drawing.Size(177, 21);
            this.txtmadv1.TabIndex = 276;
            // 
            // txtngaysd
            // 
            this.txtngaysd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaysd.Location = new System.Drawing.Point(160, 477);
            this.txtngaysd.Name = "txtngaysd";
            this.txtngaysd.Size = new System.Drawing.Size(177, 20);
            this.txtngaysd.TabIndex = 277;
            // 
            // txtmadv
            // 
            this.txtmadv.Enabled = false;
            this.txtmadv.Location = new System.Drawing.Point(163, 223);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(177, 20);
            this.txtmadv.TabIndex = 279;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(60, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 15);
            this.label17.TabIndex = 278;
            this.label17.Text = "Mã dịch vụ";
            // 
            // txttendv
            // 
            this.txttendv.Enabled = false;
            this.txttendv.Location = new System.Drawing.Point(163, 249);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(177, 20);
            this.txttendv.TabIndex = 281;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(60, 249);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 15);
            this.label18.TabIndex = 280;
            this.label18.Text = "Tên dịch vụ";
            // 
            // txtdvt
            // 
            this.txtdvt.Enabled = false;
            this.txtdvt.Location = new System.Drawing.Point(163, 275);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(177, 20);
            this.txtdvt.TabIndex = 283;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(60, 275);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 15);
            this.label19.TabIndex = 282;
            this.label19.Text = "Đơn vị tính";
            // 
            // txtdongia
            // 
            this.txtdongia.Enabled = false;
            this.txtdongia.Location = new System.Drawing.Point(163, 301);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(177, 20);
            this.txtdongia.TabIndex = 285;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(60, 301);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 15);
            this.label20.TabIndex = 284;
            this.label20.Text = "Đơn giá";
            // 
            // btnNaplai
            // 
            this.btnNaplai.Location = new System.Drawing.Point(263, 157);
            this.btnNaplai.Name = "btnNaplai";
            this.btnNaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNaplai.TabIndex = 286;
            this.btnNaplai.Text = "Nạp lại";
            this.btnNaplai.UseVisualStyleBackColor = true;
            this.btnNaplai.Click += new System.EventHandler(this.btnNaplai_Click);
            // 
            // pHIEUSDDVTableAdapter
            // 
            this.pHIEUSDDVTableAdapter.ClearBeforeFill = true;
            // 
            // frm_PhieuSDDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(769, 598);
            this.Controls.Add(this.btnNaplai);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtdvt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txttendv);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtngaysd);
            this.Controls.Add(this.txtmadv1);
            this.Controls.Add(this.txtmap);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtmapdk);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnInphieu);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.cmbTentruong);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnSau1);
            this.Controls.Add(this.btnTruoc1);
            this.Controls.Add(this.btnCuoi1);
            this.Controls.Add(this.btnDau1);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grddata1);
            this.Controls.Add(this.grddata);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cmbGiatri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frm_PhieuSDDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.frm_PhieuSDDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddata1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUSDDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnSau1;
        private System.Windows.Forms.Button btnTruoc1;
        private System.Windows.Forms.Button btnCuoi1;
        private System.Windows.Forms.Button btnDau1;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView grddata1;
        private System.Windows.Forms.DataGridView grddata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cmbGiatri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbTentruong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnInphieu;
        private System.Windows.Forms.Button btnThemmoi;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private QLKSDataSetTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox txtmapdk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox txtmap;
        private System.Windows.Forms.ComboBox txtmadv1;
        private System.Windows.Forms.DateTimePicker txtngaysd;
        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txttendv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnNaplai;
        private System.Windows.Forms.BindingSource pHIEUSDDVBindingSource;
        private QLKSDataSetTableAdapters.PHIEUSDDVTableAdapter pHIEUSDDVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPDVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSD;
    }
}