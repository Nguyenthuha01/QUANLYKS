
namespace QuanlyKS
{
    partial class frm_Nhapngaybchd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttungay = new System.Windows.Forms.DateTimePicker();
            this.txtdenngay = new System.Windows.Forms.DateTimePicker();
            this.btnmobaocao = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo hóa đơn theo ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày :";
            // 
            // txttungay
            // 
            this.txttungay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txttungay.Location = new System.Drawing.Point(115, 74);
            this.txttungay.Name = "txttungay";
            this.txttungay.Size = new System.Drawing.Size(147, 27);
            this.txttungay.TabIndex = 3;
            // 
            // txtdenngay
            // 
            this.txtdenngay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdenngay.Location = new System.Drawing.Point(113, 124);
            this.txtdenngay.Name = "txtdenngay";
            this.txtdenngay.Size = new System.Drawing.Size(149, 27);
            this.txtdenngay.TabIndex = 4;
            // 
            // btnmobaocao
            // 
            this.btnmobaocao.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmobaocao.ForeColor = System.Drawing.Color.Red;
            this.btnmobaocao.Location = new System.Drawing.Point(279, 124);
            this.btnmobaocao.Name = "btnmobaocao";
            this.btnmobaocao.Size = new System.Drawing.Size(82, 26);
            this.btnmobaocao.TabIndex = 5;
            this.btnmobaocao.Text = "Mở báo cáo";
            this.btnmobaocao.UseVisualStyleBackColor = true;
            this.btnmobaocao.Click += new System.EventHandler(this.btnmobaocao_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthoat.Location = new System.Drawing.Point(279, 170);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(82, 26);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frm_Nhapngaybchd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(374, 211);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnmobaocao);
            this.Controls.Add(this.txtdenngay);
            this.Controls.Add(this.txttungay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Nhapngaybchd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập ngày báo cáo hóa đơn";
            this.Load += new System.EventHandler(this.frm_Nhapngaybchd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txttungay;
        private System.Windows.Forms.DateTimePicker txtdenngay;
        private System.Windows.Forms.Button btnmobaocao;
        private System.Windows.Forms.Button btnthoat;
    }
}