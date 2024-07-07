namespace NHOM8_QLHSUT.LAYER1_GUI.DangThongBaoTuyenDung
{
    partial class MHDangThongBaoTuyenDung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_title = new System.Windows.Forms.Label();
            this.DSThongTinDangTuyen = new System.Windows.Forms.DataGridView();
            this.MADT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VITRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEUCAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSThongTinDangTuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_title.Location = new System.Drawing.Point(353, 18);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(242, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Thông Báo Tuyển Dụng";
            // 
            // DSThongTinDangTuyen
            // 
            this.DSThongTinDangTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DSThongTinDangTuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DSThongTinDangTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSThongTinDangTuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADT,
            this.MADN,
            this.VITRI,
            this.SOLUONG,
            this.NGAYBD,
            this.NGAYKT,
            this.YEUCAU});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DSThongTinDangTuyen.DefaultCellStyle = dataGridViewCellStyle2;
            this.DSThongTinDangTuyen.Location = new System.Drawing.Point(29, 61);
            this.DSThongTinDangTuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DSThongTinDangTuyen.Name = "DSThongTinDangTuyen";
            this.DSThongTinDangTuyen.RowHeadersWidth = 62;
            this.DSThongTinDangTuyen.RowTemplate.Height = 28;
            this.DSThongTinDangTuyen.Size = new System.Drawing.Size(960, 499);
            this.DSThongTinDangTuyen.TabIndex = 1;
            // 
            // MADT
            // 
            this.MADT.HeaderText = "Mã ĐT";
            this.MADT.MinimumWidth = 6;
            this.MADT.Name = "MADT";
            // 
            // MADN
            // 
            this.MADN.HeaderText = "Mã DN";
            this.MADN.MinimumWidth = 6;
            this.MADN.Name = "MADN";
            // 
            // VITRI
            // 
            this.VITRI.HeaderText = "Vị trí";
            this.VITRI.MinimumWidth = 6;
            this.VITRI.Name = "VITRI";
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            // 
            // NGAYBD
            // 
            this.NGAYBD.HeaderText = "Ngày BĐ";
            this.NGAYBD.MinimumWidth = 6;
            this.NGAYBD.Name = "NGAYBD";
            // 
            // NGAYKT
            // 
            this.NGAYKT.HeaderText = "Ngày KT";
            this.NGAYKT.MinimumWidth = 6;
            this.NGAYKT.Name = "NGAYKT";
            // 
            // YEUCAU
            // 
            this.YEUCAU.HeaderText = "Yêu cầu";
            this.YEUCAU.MinimumWidth = 6;
            this.YEUCAU.Name = "YEUCAU";
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQuaylai.Location = new System.Drawing.Point(865, 574);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(124, 45);
            this.btnQuaylai.TabIndex = 2;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = false;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai);
            // 
            // MHDangThongBaoTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 630);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.DSThongTinDangTuyen);
            this.Controls.Add(this.label_title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MHDangThongBaoTuyenDung";
            this.Text = "DangThongBaoTuyenDung_L1";
            this.Load += new System.EventHandler(this.DangThongBao_L1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSThongTinDangTuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView DSThongTinDangTuyen;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADN;
        private System.Windows.Forms.DataGridViewTextBoxColumn VITRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEUCAU;
    }
}