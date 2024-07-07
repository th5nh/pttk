namespace NHOM8_QLHSUT.LAYER1_GUI.DangThongBaoTuyenDung
{
    partial class DangThongBaoTuyenDung_L1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_title = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MADT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VITRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEUCAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btc_vtc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADT,
            this.MADN,
            this.VITRI,
            this.SOLUONG,
            this.NGAYBD,
            this.NGAYKT,
            this.YEUCAU});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Location = new System.Drawing.Point(29, 61);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(960, 499);
            this.dataGridView.TabIndex = 1;
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
            // btc_vtc
            // 
            this.btc_vtc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btc_vtc.Location = new System.Drawing.Point(865, 574);
            this.btc_vtc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btc_vtc.Name = "btc_vtc";
            this.btc_vtc.Size = new System.Drawing.Size(124, 45);
            this.btc_vtc.TabIndex = 2;
            this.btc_vtc.Text = "Quay lại";
            this.btc_vtc.UseVisualStyleBackColor = false;
            this.btc_vtc.Click += new System.EventHandler(this.btc_vtc_Click);
            // 
            // DangThongBaoTuyenDung_L1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 630);
            this.Controls.Add(this.btc_vtc);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label_title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangThongBaoTuyenDung_L1";
            this.Text = "DangThongBaoTuyenDung_L1";
            this.Load += new System.EventHandler(this.DangThongBao_L1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btc_vtc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADN;
        private System.Windows.Forms.DataGridViewTextBoxColumn VITRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEUCAU;
    }
}