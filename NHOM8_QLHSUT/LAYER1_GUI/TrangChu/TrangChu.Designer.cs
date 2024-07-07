namespace NHOM8_QLHSUT.LAYER1_GUI.ManHinhChinh
{
    partial class TrangChu
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
            this.btn_dkuv = new System.Windows.Forms.Button();
            this.btn_xemttdt = new System.Windows.Forms.Button();
            this.btn_phieudkut = new System.Windows.Forms.Button();
            this.btn_xemtbtd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANG CHỦ";
            // 
            // btn_dkuv
            // 
            this.btn_dkuv.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_dkuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dkuv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dkuv.Location = new System.Drawing.Point(54, 129);
            this.btn_dkuv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dkuv.Name = "btn_dkuv";
            this.btn_dkuv.Size = new System.Drawing.Size(169, 138);
            this.btn_dkuv.TabIndex = 1;
            this.btn_dkuv.Text = "Đăng ký ứng viên";
            this.btn_dkuv.UseVisualStyleBackColor = false;
            this.btn_dkuv.Click += new System.EventHandler(this.btn_dkuv_Click);
            // 
            // btn_xemttdt
            // 
            this.btn_xemttdt.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_xemttdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemttdt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xemttdt.Location = new System.Drawing.Point(54, 318);
            this.btn_xemttdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xemttdt.Name = "btn_xemttdt";
            this.btn_xemttdt.Size = new System.Drawing.Size(169, 138);
            this.btn_xemttdt.TabIndex = 2;
            this.btn_xemttdt.Text = "Xem thông tin đăng tuyển";
            this.btn_xemttdt.UseVisualStyleBackColor = false;
            this.btn_xemttdt.Click += new System.EventHandler(this.btn_xemttdt_Click);
            // 
            // btn_phieudkut
            // 
            this.btn_phieudkut.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_phieudkut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phieudkut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_phieudkut.Location = new System.Drawing.Point(290, 129);
            this.btn_phieudkut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_phieudkut.Name = "btn_phieudkut";
            this.btn_phieudkut.Size = new System.Drawing.Size(169, 138);
            this.btn_phieudkut.TabIndex = 3;
            this.btn_phieudkut.Text = "Ghi nhận phiếu đăng ký ứng tuyển";
            this.btn_phieudkut.UseVisualStyleBackColor = false;
            this.btn_phieudkut.Click += new System.EventHandler(this.btn_phieudkut_Click);
            // 
            // btn_xemtbtd
            // 
            this.btn_xemtbtd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_xemtbtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemtbtd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xemtbtd.Location = new System.Drawing.Point(290, 318);
            this.btn_xemtbtd.Name = "btn_xemtbtd";
            this.btn_xemtbtd.Size = new System.Drawing.Size(169, 138);
            this.btn_xemtbtd.TabIndex = 4;
            this.btn_xemtbtd.Text = "Xem thông báo tuyển dụng";
            this.btn_xemtbtd.UseVisualStyleBackColor = false;
            this.btn_xemtbtd.Click += new System.EventHandler(this.btn_xemtbtd_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 655);
            this.Controls.Add(this.btn_xemtbtd);
            this.Controls.Add(this.btn_phieudkut);
            this.Controls.Add(this.btn_xemttdt);
            this.Controls.Add(this.btn_dkuv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TrangChu";
            this.Text = "Trang chủ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dkuv;
        private System.Windows.Forms.Button btn_xemttdt;
        private System.Windows.Forms.Button btn_phieudkut;
        private System.Windows.Forms.Button btn_xemtbtd;
    }
}