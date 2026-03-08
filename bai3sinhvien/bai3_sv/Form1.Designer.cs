namespace bai3_sv
{
    partial class Form1
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
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboChuyenNganh = new System.Windows.Forms.ComboBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(278, 88);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(242, 22);
            this.txtMaSV.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(278, 131);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(242, 22);
            this.txtTen.TabIndex = 1;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(278, 267);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(242, 22);
            this.txtDiemTB.TabIndex = 2;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(278, 174);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtNgaySinh.TabIndex = 3;
            // 
            // cboChuyenNganh
            // 
            this.cboChuyenNganh.FormattingEnabled = true;
            this.cboChuyenNganh.Location = new System.Drawing.Point(278, 218);
            this.cboChuyenNganh.Name = "cboChuyenNganh";
            this.cboChuyenNganh.Size = new System.Drawing.Size(242, 24);
            this.cboChuyenNganh.TabIndex = 4;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(236, 364);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(55, 16);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "Kết quả:";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(351, 326);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 6;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(143, 88);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(84, 16);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Mã sinh viên:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(143, 131);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(89, 16);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Tên sinh viên:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(143, 221);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(95, 16);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Chuyên ngành:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(143, 180);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(70, 16);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "Ngày sinh:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(143, 273);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(101, 16);
            this.lbl5.TabIndex = 11;
            this.lbl5.Text = "Điểm trung bình:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.cboChuyenNganh);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cboChuyenNganh;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
    }
}

