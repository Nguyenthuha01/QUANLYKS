
namespace QuanlyKS
{
    partial class frm_Thongtinphong01
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmakh = new System.Windows.Forms.ComboBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtngayden = new System.Windows.Forms.DateTimePicker();
            this.txtngaydi = new System.Windows.Forms.DateTimePicker();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phòng P01";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày đến :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày đi :";
            // 
            // txtmakh
            // 
            this.txtmakh.FormattingEnabled = true;
            this.txtmakh.Location = new System.Drawing.Point(140, 71);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(200, 21);
            this.txtmakh.TabIndex = 6;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(140, 102);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(200, 20);
            this.txttenkh.TabIndex = 8;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(140, 133);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(200, 20);
            this.txtsdt.TabIndex = 9;
            // 
            // txtngayden
            // 
            this.txtngayden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngayden.Location = new System.Drawing.Point(140, 166);
            this.txtngayden.Name = "txtngayden";
            this.txtngayden.Size = new System.Drawing.Size(200, 20);
            this.txtngayden.TabIndex = 10;
            // 
            // txtngaydi
            // 
            this.txtngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaydi.Location = new System.Drawing.Point(140, 198);
            this.txtngaydi.Name = "txtngaydi";
            this.txtngaydi.Size = new System.Drawing.Size(200, 20);
            this.txtngaydi.TabIndex = 11;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(265, 235);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 14;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frm_Thongtinphong01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 273);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtngaydi);
            this.Controls.Add(this.txtngayden);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Thongtinphong01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin phòng P01";
            this.Load += new System.EventHandler(this.frm_Thongtinphong01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtmakh;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DateTimePicker txtngayden;
        private System.Windows.Forms.DateTimePicker txtngaydi;
        private System.Windows.Forms.Button btnthoat;
    }
}