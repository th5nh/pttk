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
            this.label_title = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btc_vtc = new System.Windows.Forms.Button();
            this.MADT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VITRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEUCAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(276, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(242, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Thông Báo Tuyển Dụng";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADT,
            this.MADN,
            this.VITRI,
            this.SOLUONG,
            this.NGAYBD,
            this.NGAYKT,
            this.YEUCAU});
            this.dataGridView.Location = new System.Drawing.Point(33, 48);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(728, 316);
            this.dataGridView.TabIndex = 1;
            // 
            // btc_vtc
            // 
            this.btc_vtc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btc_vtc.Location = new System.Drawing.Point(323, 384);
            this.btc_vtc.Name = "btc_vtc";
            this.btc_vtc.Size = new System.Drawing.Size(139, 44);
            this.btc_vtc.TabIndex = 2;
            this.btc_vtc.Text = "Trang chủ";
            this.btc_vtc.UseVisualStyleBackColor = false;
            this.btc_vtc.Click += new System.EventHandler(this.btc_vtc_Click);
            // 
            // MADT
            // 
            this.MADT.HeaderText = "Mã ĐT";
            this.MADT.MinimumWidth = 6;
            this.MADT.Name = "MADT";
            this.MADT.Width = 110;
            // 
            // MADN
            // 
            this.MADN.HeaderText = "Mã DN";
            this.MADN.MinimumWidth = 6;
            this.MADN.Name = "MADN";
            this.MADN.Width = 150;
            // 
            // VITRI
            // 
            this.VITRI.HeaderText = "Vị trí";
            this.VITRI.MinimumWidth = 6;
            this.VITRI.Name = "VITRI";
            this.VITRI.Width = 110;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 110;
            // 
            // NGAYBD
            // 
            this.NGAYBD.HeaderText = "Ngày BĐ";
            this.NGAYBD.MinimumWidth = 6;
            this.NGAYBD.Name = "NGAYBD";
            this.NGAYBD.Width = 150;
            // 
            // NGAYKT
            // 
            this.NGAYKT.HeaderText = "Ngày KT";
            this.NGAYKT.MinimumWidth = 6;
            this.NGAYKT.Name = "NGAYKT";
            this.NGAYKT.Width = 150;
            // 
            // YEUCAU
            // 
            this.YEUCAU.HeaderText = "Yêu cầu";
            this.YEUCAU.MinimumWidth = 6;
            this.YEUCAU.Name = "YEUCAU";
            this.YEUCAU.Width = 110;
            // 
            // DangThongBaoTuyenDung_L1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btc_vtc);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label_title);
            this.Name = "DangThongBaoTuyenDung_L1";
            this.Text = "DangThongBaoTuyenDung_L1";
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