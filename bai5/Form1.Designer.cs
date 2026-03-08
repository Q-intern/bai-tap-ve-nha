namespace bai5
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
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtThongBao = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            this.SuspendLayout();
            // 
            // nudA
            // 
            this.nudA.Location = new System.Drawing.Point(175, 69);
            this.nudA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(65, 22);
            this.nudA.TabIndex = 0;
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(403, 71);
            this.nudB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(66, 22);
            this.nudB.TabIndex = 1;
            // 
            // nudC
            // 
            this.nudC.Location = new System.Drawing.Point(621, 72);
            this.nudC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(70, 22);
            this.nudC.TabIndex = 2;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(530, 173);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(161, 22);
            this.txtX1.TabIndex = 3;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(530, 238);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(161, 22);
            this.txtX2.TabIndex = 4;
            // 
            // txtThongBao
            // 
            this.txtThongBao.Location = new System.Drawing.Point(81, 194);
            this.txtThongBao.Name = "txtThongBao";
            this.txtThongBao.Size = new System.Drawing.Size(268, 22);
            this.txtThongBao.TabIndex = 5;
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(235, 338);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(75, 23);
            this.btnGiai.TabIndex = 6;
            this.btnGiai.Text = "Giải PTBH";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(467, 338);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(144, 71);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(15, 16);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nghiệm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "x1 = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "x2 =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtThongBao);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.nudC);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtThongBao;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

