namespace bai3
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
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.chkGiamGia = new System.Windows.Forms.CheckBox();
            this.rad5 = new System.Windows.Forms.RadioButton();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(291, 81);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(231, 22);
            this.txtMaHang.TabIndex = 0;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(291, 129);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(231, 22);
            this.txtDonGia.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(291, 180);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(231, 22);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(291, 228);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(231, 22);
            this.txtTongTien.TabIndex = 3;
            // 
            // chkGiamGia
            // 
            this.chkGiamGia.AutoSize = true;
            this.chkGiamGia.Location = new System.Drawing.Point(168, 292);
            this.chkGiamGia.Name = "chkGiamGia";
            this.chkGiamGia.Size = new System.Drawing.Size(83, 20);
            this.chkGiamGia.TabIndex = 4;
            this.chkGiamGia.Text = "Giảm giá";
            this.chkGiamGia.UseVisualStyleBackColor = true;
            this.chkGiamGia.CheckedChanged += new System.EventHandler(this.chkGiamGia_CheckedChanged);
            // 
            // rad5
            // 
            this.rad5.AutoSize = true;
            this.rad5.Location = new System.Drawing.Point(311, 292);
            this.rad5.Name = "rad5";
            this.rad5.Size = new System.Drawing.Size(47, 20);
            this.rad5.TabIndex = 5;
            this.rad5.TabStop = true;
            this.rad5.Text = "5%";
            this.rad5.UseVisualStyleBackColor = true;
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Location = new System.Drawing.Point(433, 292);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(54, 20);
            this.rad10.TabIndex = 6;
            this.rad10.TabStop = true;
            this.rad10.Text = "10%";
            this.rad10.UseVisualStyleBackColor = true;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(217, 363);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(75, 23);
            this.btnThucHien.TabIndex = 7;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(469, 363);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(165, 84);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 16);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Mã hàng";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(165, 129);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 16);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "Đơn giá";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(165, 180);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(60, 16);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "Số lượng";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(165, 228);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(66, 16);
            this.lbl4.TabIndex = 12;
            this.lbl4.Text = "Tổng tiền:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.rad10);
            this.Controls.Add(this.rad5);
            this.Controls.Add(this.chkGiamGia);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtMaHang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.CheckBox chkGiamGia;
        private System.Windows.Forms.RadioButton rad5;
        private System.Windows.Forms.RadioButton rad10;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}

