
namespace QuanlyKS
{
    partial class frm_NhapngayDTDV
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnmobaocao = new System.Windows.Forms.Button();
            this.txtdenngay = new System.Windows.Forms.DateTimePicker();
            this.txttungay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthoat.Location = new System.Drawing.Point(277, 169);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(82, 26);
            this.btnthoat.TabIndex = 20;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnmobaocao
            // 
            this.btnmobaocao.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmobaocao.ForeColor = System.Drawing.Color.Red;
            this.btnmobaocao.Location = new System.Drawing.Point(277, 123);
            this.btnmobaocao.Name = "btnmobaocao";
            this.btnmobaocao.Size = new System.Drawing.Size(82, 26);
            this.btnmobaocao.TabIndex = 19;
            this.btnmobaocao.Text = "Mở báo cáo";
            this.btnmobaocao.UseVisualStyleBackColor = true;
            this.btnmobaocao.Click += new System.EventHandler(this.btnmobaocao_Click);
            // 
            // txtdenngay
            // 
            this.txtdenngay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdenngay.Location = new System.Drawing.Point(115, 119);
            this.txtdenngay.Name = "txtdenngay";
            this.txtdenngay.Size = new System.Drawing.Size(149, 27);
            this.txtdenngay.TabIndex = 18;
            // 
            // txttungay
            // 
            this.txttungay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txttungay.Location = new System.Drawing.Point(117, 69);
            this.txttungay.Name = "txttungay";
            this.txttungay.Size = new System.Drawing.Size(147, 27);
            this.txttungay.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Đến ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Từ ngày :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Báo cáo doanh thu dịch vụ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_NhapngayDTDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 211);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnmobaocao);
            this.Controls.Add(this.txtdenngay);
            this.Controls.Add(this.txttungay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_NhapngayDTDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập ngày lập doanh thu dịch vụ";
            this.Load += new System.EventHandler(this.frm_NhapngayDTDV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnmobaocao;
        private System.Windows.Forms.DateTimePicker txtdenngay;
        private System.Windows.Forms.DateTimePicker txttungay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}