
namespace QuanlyKS
{
    partial class frm_Doimk
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtNhaplaimk = new System.Windows.Forms.TextBox();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtMatkhaucu = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoimk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::QuanlyKS.Properties.Resources.delete;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(513, 543);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(103, 36);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            this.btnHuy.MouseEnter += new System.EventHandler(this.btnHuy_MouseEnter);
            this.btnHuy.MouseLeave += new System.EventHandler(this.btnHuy_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(119, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nhập lại mật khẩu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(122, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 22);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mật khẩu cũ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(319, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đổi mật khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.txtNhaplaimk);
            this.splitContainer1.Panel1.Controls.Add(this.txtMatkhaumoi);
            this.splitContainer1.Panel1.Controls.Add(this.txtMatkhaucu);
            this.splitContainer1.Panel1.Controls.Add(this.txtTaikhoan);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnDoimk);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer1.Panel2.BackgroundImage = global::QuanlyKS.Properties.Resources.Hotel;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(1367, 749);
            this.splitContainer1.SplitterDistance = 821;
            this.splitContainer1.TabIndex = 5;
            // 
            // txtNhaplaimk
            // 
            this.txtNhaplaimk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaplaimk.Location = new System.Drawing.Point(275, 475);
            this.txtNhaplaimk.Multiline = true;
            this.txtNhaplaimk.Name = "txtNhaplaimk";
            this.txtNhaplaimk.Size = new System.Drawing.Size(440, 29);
            this.txtNhaplaimk.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtNhaplaimk, "Nhập lại mật khẩu mới !");
            this.txtNhaplaimk.MouseEnter += new System.EventHandler(this.txtNhaplaimk_MouseEnter);
            this.txtNhaplaimk.MouseLeave += new System.EventHandler(this.txtNhaplaimk_MouseLeave);
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhaumoi.Location = new System.Drawing.Point(275, 427);
            this.txtMatkhaumoi.Multiline = true;
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Size = new System.Drawing.Size(440, 29);
            this.txtMatkhaumoi.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txtMatkhaumoi, "Chỉ được nhập ký tự a-z và 0-9 !");
            this.txtMatkhaumoi.MouseEnter += new System.EventHandler(this.txtMatkhaumoi_MouseEnter);
            this.txtMatkhaumoi.MouseLeave += new System.EventHandler(this.txtMatkhaumoi_MouseLeave);
            // 
            // txtMatkhaucu
            // 
            this.txtMatkhaucu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhaucu.Location = new System.Drawing.Point(275, 378);
            this.txtMatkhaucu.Multiline = true;
            this.txtMatkhaucu.Name = "txtMatkhaucu";
            this.txtMatkhaucu.Size = new System.Drawing.Size(440, 29);
            this.txtMatkhaucu.TabIndex = 22;
            this.txtMatkhaucu.MouseEnter += new System.EventHandler(this.txtMatkhaucu_MouseEnter);
            this.txtMatkhaucu.MouseLeave += new System.EventHandler(this.txtMatkhaucu_MouseLeave);
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.Location = new System.Drawing.Point(275, 327);
            this.txtTaikhoan.Multiline = true;
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(440, 29);
            this.txtTaikhoan.TabIndex = 21;
            this.txtTaikhoan.MouseEnter += new System.EventHandler(this.txtTaikhoan_MouseEnter);
            this.txtTaikhoan.MouseLeave += new System.EventHandler(this.txtTaikhoan_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mật khẩu mới";
            // 
            // btnDoimk
            // 
            this.btnDoimk.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoimk.Image = global::QuanlyKS.Properties.Resources.diskette;
            this.btnDoimk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoimk.Location = new System.Drawing.Point(355, 543);
            this.btnDoimk.Name = "btnDoimk";
            this.btnDoimk.Size = new System.Drawing.Size(99, 36);
            this.btnDoimk.TabIndex = 18;
            this.btnDoimk.Text = "Lưu";
            this.btnDoimk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoimk.UseVisualStyleBackColor = true;
            this.btnDoimk.Click += new System.EventHandler(this.btnDoimk_Click);
            this.btnDoimk.MouseEnter += new System.EventHandler(this.btnDoimk_MouseEnter);
            this.btnDoimk.MouseLeave += new System.EventHandler(this.btnDoimk_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanlyKS.Properties.Resources.password1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(125, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 172);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 749);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // frm_Doimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Name = "frm_Doimk";
            this.Text = "frm_Doimk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Doimk_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDoimk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhaplaimk;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.TextBox txtMatkhaucu;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}