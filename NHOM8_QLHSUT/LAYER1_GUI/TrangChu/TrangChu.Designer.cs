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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANG CHỦ";
            // 
            // btn_dkuv
            // 
            this.btn_dkuv.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_dkuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dkuv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dkuv.Location = new System.Drawing.Point(307, 121);
            this.btn_dkuv.Name = "btn_dkuv";
            this.btn_dkuv.Size = new System.Drawing.Size(140, 90);
            this.btn_dkuv.TabIndex = 1;
            this.btn_dkuv.Text = "Đăng ký ứng viên";
            this.btn_dkuv.UseVisualStyleBackColor = false;
            this.btn_dkuv.Click += new System.EventHandler(this.btn_dkuv_Click);
            // 
            // btn_xemttdt
            // 
            this.btn_xemttdt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_xemttdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemttdt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xemttdt.Location = new System.Drawing.Point(95, 266);
            this.btn_xemttdt.Name = "btn_xemttdt";
            this.btn_xemttdt.Size = new System.Drawing.Size(144, 101);
            this.btn_xemttdt.TabIndex = 2;
            this.btn_xemttdt.Text = "Xem thông tin đăng tuyển";
            this.btn_xemttdt.UseVisualStyleBackColor = false;
            this.btn_xemttdt.Click += new System.EventHandler(this.btn_xemttdt_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_xemttdt);
            this.Controls.Add(this.btn_dkuv);
            this.Controls.Add(this.label1);
            this.Name = "TrangChu";
            this.Text = "Trang chủ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dkuv;
        private System.Windows.Forms.Button btn_xemttdt;
    }
}