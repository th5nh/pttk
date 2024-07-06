namespace NHOM8_QLHSUT.LAYER1_GUI.ThanhToan
{
    partial class ThanhToan_L1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbHinhThucThanhToan = new System.Windows.Forms.Label();
            this.labelDot = new System.Windows.Forms.Label();
            this.dtDangTuyen = new System.Windows.Forms.DataGridView();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbCachThucThanhToan = new System.Windows.Forms.Label();
            this.cbbHinhThucThanhToan = new System.Windows.Forms.ComboBox();
            this.cbbCachThucThanhToan = new System.Windows.Forms.ComboBox();
            this.lbDot = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lbVoucher = new System.Windows.Forms.Label();
            this.cbbVoucher = new System.Windows.Forms.ComboBox();
            this.lbThanhToan = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.lbMaThe = new System.Windows.Forms.Label();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtDangTuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHinhThucThanhToan
            // 
            this.lbHinhThucThanhToan.AutoSize = true;
            this.lbHinhThucThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHinhThucThanhToan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbHinhThucThanhToan.Location = new System.Drawing.Point(74, 222);
            this.lbHinhThucThanhToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHinhThucThanhToan.Name = "lbHinhThucThanhToan";
            this.lbHinhThucThanhToan.Size = new System.Drawing.Size(204, 24);
            this.lbHinhThucThanhToan.TabIndex = 12;
            this.lbHinhThucThanhToan.Text = "Hình thức thanh toán";
            // 
            // labelDot
            // 
            this.labelDot.AutoSize = true;
            this.labelDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDot.Location = new System.Drawing.Point(406, 213);
            this.labelDot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDot.Name = "labelDot";
            this.labelDot.Size = new System.Drawing.Size(41, 24);
            this.labelDot.TabIndex = 14;
            this.labelDot.Text = "Đợt";
            // 
            // dtDangTuyen
            // 
            this.dtDangTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDangTuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtDangTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDangTuyen.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtDangTuyen.Location = new System.Drawing.Point(78, 112);
            this.dtDangTuyen.Margin = new System.Windows.Forms.Padding(2);
            this.dtDangTuyen.MultiSelect = false;
            this.dtDangTuyen.Name = "dtDangTuyen";
            this.dtDangTuyen.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDangTuyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtDangTuyen.RowHeadersVisible = false;
            this.dtDangTuyen.RowHeadersWidth = 51;
            this.dtDangTuyen.RowTemplate.Height = 24;
            this.dtDangTuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDangTuyen.Size = new System.Drawing.Size(586, 82);
            this.dtDangTuyen.TabIndex = 16;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTongTien.Location = new System.Drawing.Point(462, 310);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(168, 24);
            this.lbTongTien.TabIndex = 17;
            this.lbTongTien.Text = "Tổng tiền cần trả";
            // 
            // lbCachThucThanhToan
            // 
            this.lbCachThucThanhToan.AutoSize = true;
            this.lbCachThucThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCachThucThanhToan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCachThucThanhToan.Location = new System.Drawing.Point(74, 295);
            this.lbCachThucThanhToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCachThucThanhToan.Name = "lbCachThucThanhToan";
            this.lbCachThucThanhToan.Size = new System.Drawing.Size(208, 24);
            this.lbCachThucThanhToan.TabIndex = 18;
            this.lbCachThucThanhToan.Text = "Cách thức thanh toán";
            // 
            // cbbHinhThucThanhToan
            // 
            this.cbbHinhThucThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbHinhThucThanhToan.FormattingEnabled = true;
            this.cbbHinhThucThanhToan.Items.AddRange(new object[] {
            "1 Đợt",
            "Nhiều Đợt"});
            this.cbbHinhThucThanhToan.Location = new System.Drawing.Point(78, 249);
            this.cbbHinhThucThanhToan.Name = "cbbHinhThucThanhToan";
            this.cbbHinhThucThanhToan.Size = new System.Drawing.Size(200, 24);
            this.cbbHinhThucThanhToan.TabIndex = 19;
            // 
            // cbbCachThucThanhToan
            // 
            this.cbbCachThucThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbCachThucThanhToan.FormattingEnabled = true;
            this.cbbCachThucThanhToan.Items.AddRange(new object[] {
            "Thanh toán trực tiếp",
            "Thanh toán qua thẻ"});
            this.cbbCachThucThanhToan.Location = new System.Drawing.Point(78, 322);
            this.cbbCachThucThanhToan.Name = "cbbCachThucThanhToan";
            this.cbbCachThucThanhToan.Size = new System.Drawing.Size(200, 24);
            this.cbbCachThucThanhToan.TabIndex = 20;
            this.cbbCachThucThanhToan.SelectedIndexChanged += new System.EventHandler(this.cbbCachThucThanhToan_SelectedIndexChanged);
            // 
            // lbDot
            // 
            this.lbDot.AutoSize = true;
            this.lbDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDot.Location = new System.Drawing.Point(514, 213);
            this.lbDot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDot.Name = "lbDot";
            this.lbDot.Size = new System.Drawing.Size(41, 24);
            this.lbDot.TabIndex = 21;
            this.lbDot.Text = "Đợt";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.White;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(491, 397);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(115, 44);
            this.btnThanhToan.TabIndex = 22;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // lbVoucher
            // 
            this.lbVoucher.AutoSize = true;
            this.lbVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbVoucher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVoucher.Location = new System.Drawing.Point(406, 258);
            this.lbVoucher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVoucher.Name = "lbVoucher";
            this.lbVoucher.Size = new System.Drawing.Size(90, 24);
            this.lbVoucher.TabIndex = 23;
            this.lbVoucher.Text = "Voucher";
            // 
            // cbbVoucher
            // 
            this.cbbVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbVoucher.FormattingEnabled = true;
            this.cbbVoucher.Location = new System.Drawing.Point(501, 258);
            this.cbbVoucher.Name = "cbbVoucher";
            this.cbbVoucher.Size = new System.Drawing.Size(163, 24);
            this.cbbVoucher.TabIndex = 24;
            this.cbbVoucher.SelectedIndexChanged += new System.EventHandler(this.cbbVoucher_SelectedIndexChanged);
            // 
            // lbThanhToan
            // 
            this.lbThanhToan.AutoSize = true;
            this.lbThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhToan.Location = new System.Drawing.Point(289, 34);
            this.lbThanhToan.Name = "lbThanhToan";
            this.lbThanhToan.Size = new System.Drawing.Size(170, 31);
            this.lbThanhToan.TabIndex = 25;
            this.lbThanhToan.Text = "Thanh Toán";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTien.Location = new System.Drawing.Point(513, 352);
            this.lbTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(66, 29);
            this.lbTien.TabIndex = 26;
            this.lbTien.Text = "Tiền";
            // 
            // lbMaThe
            // 
            this.lbMaThe.AutoSize = true;
            this.lbMaThe.Enabled = false;
            this.lbMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaThe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaThe.Location = new System.Drawing.Point(74, 370);
            this.lbMaThe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaThe.Name = "lbMaThe";
            this.lbMaThe.Size = new System.Drawing.Size(81, 24);
            this.lbMaThe.TabIndex = 27;
            this.lbMaThe.Text = "Mã Thẻ";
            // 
            // txtMaThe
            // 
            this.txtMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaThe.Location = new System.Drawing.Point(78, 397);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(200, 23);
            this.txtMaThe.TabIndex = 28;
            // 
            // ThanhToan_L1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 470);
            this.Controls.Add(this.txtMaThe);
            this.Controls.Add(this.lbMaThe);
            this.Controls.Add(this.lbTien);
            this.Controls.Add(this.lbThanhToan);
            this.Controls.Add(this.cbbVoucher);
            this.Controls.Add(this.lbVoucher);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lbDot);
            this.Controls.Add(this.cbbCachThucThanhToan);
            this.Controls.Add(this.cbbHinhThucThanhToan);
            this.Controls.Add(this.lbCachThucThanhToan);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.dtDangTuyen);
            this.Controls.Add(this.labelDot);
            this.Controls.Add(this.lbHinhThucThanhToan);
            this.Name = "ThanhToan_L1";
            this.Text = "ThanhToan_L1";
            this.Load += new System.EventHandler(this.ThanhToan_L1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDangTuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbHinhThucThanhToan;
        private System.Windows.Forms.Label labelDot;
        private System.Windows.Forms.DataGridView dtDangTuyen;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbCachThucThanhToan;
        private System.Windows.Forms.ComboBox cbbHinhThucThanhToan;
        private System.Windows.Forms.ComboBox cbbCachThucThanhToan;
        private System.Windows.Forms.Label lbDot;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lbVoucher;
        private System.Windows.Forms.ComboBox cbbVoucher;
        private System.Windows.Forms.Label lbThanhToan;
        private System.Windows.Forms.Label lbTien;
        private System.Windows.Forms.Label lbMaThe;
        private System.Windows.Forms.TextBox txtMaThe;
    }
}