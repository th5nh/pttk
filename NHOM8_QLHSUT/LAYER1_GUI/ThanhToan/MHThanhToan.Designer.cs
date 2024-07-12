namespace NHOM8_QLHSUT.LAYER1_GUI.ThanhToan
{
    partial class MHThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDangTuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHinhThucThanhToan
            // 
            this.lbHinhThucThanhToan.AutoSize = true;
            this.lbHinhThucThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHinhThucThanhToan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbHinhThucThanhToan.Location = new System.Drawing.Point(99, 273);
            this.lbHinhThucThanhToan.Name = "lbHinhThucThanhToan";
            this.lbHinhThucThanhToan.Size = new System.Drawing.Size(248, 29);
            this.lbHinhThucThanhToan.TabIndex = 12;
            this.lbHinhThucThanhToan.Text = "Hình thức thanh toán";
            // 
            // labelDot
            // 
            this.labelDot.AutoSize = true;
            this.labelDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDot.Location = new System.Drawing.Point(541, 262);
            this.labelDot.Name = "labelDot";
            this.labelDot.Size = new System.Drawing.Size(53, 29);
            this.labelDot.TabIndex = 14;
            this.labelDot.Text = "Đợt";
            // 
            // dtDangTuyen
            // 
            this.dtDangTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDangTuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtDangTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDangTuyen.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtDangTuyen.Location = new System.Drawing.Point(12, 115);
            this.dtDangTuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDangTuyen.MultiSelect = false;
            this.dtDangTuyen.Name = "dtDangTuyen";
            this.dtDangTuyen.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDangTuyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtDangTuyen.RowHeadersVisible = false;
            this.dtDangTuyen.RowHeadersWidth = 51;
            this.dtDangTuyen.RowTemplate.Height = 24;
            this.dtDangTuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDangTuyen.Size = new System.Drawing.Size(968, 124);
            this.dtDangTuyen.TabIndex = 16;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTongTien.Location = new System.Drawing.Point(616, 382);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(209, 29);
            this.lbTongTien.TabIndex = 17;
            this.lbTongTien.Text = "Tổng tiền cần trả";
            // 
            // lbCachThucThanhToan
            // 
            this.lbCachThucThanhToan.AutoSize = true;
            this.lbCachThucThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCachThucThanhToan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCachThucThanhToan.Location = new System.Drawing.Point(99, 363);
            this.lbCachThucThanhToan.Name = "lbCachThucThanhToan";
            this.lbCachThucThanhToan.Size = new System.Drawing.Size(254, 29);
            this.lbCachThucThanhToan.TabIndex = 18;
            this.lbCachThucThanhToan.Text = "Cách thức thanh toán";
            // 
            // cbbHinhThucThanhToan
            // 
            this.cbbHinhThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHinhThucThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbHinhThucThanhToan.FormattingEnabled = true;
            this.cbbHinhThucThanhToan.Items.AddRange(new object[] {
            "Thanh toán 1 đợt",
            "Thanh toán nhiều đợt"});
            this.cbbHinhThucThanhToan.Location = new System.Drawing.Point(104, 306);
            this.cbbHinhThucThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.cbbHinhThucThanhToan.Name = "cbbHinhThucThanhToan";
            this.cbbHinhThucThanhToan.Size = new System.Drawing.Size(265, 28);
            this.cbbHinhThucThanhToan.TabIndex = 19;
            this.cbbHinhThucThanhToan.SelectedIndexChanged += new System.EventHandler(this.cbbHinhThucThanhToan_SelectedIndexChanged);
            // 
            // cbbCachThucThanhToan
            // 
            this.cbbCachThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCachThucThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbCachThucThanhToan.FormattingEnabled = true;
            this.cbbCachThucThanhToan.Items.AddRange(new object[] {
            "Thanh toán trực tiếp",
            "Thanh toán qua thẻ"});
            this.cbbCachThucThanhToan.Location = new System.Drawing.Point(104, 396);
            this.cbbCachThucThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCachThucThanhToan.Name = "cbbCachThucThanhToan";
            this.cbbCachThucThanhToan.Size = new System.Drawing.Size(265, 28);
            this.cbbCachThucThanhToan.TabIndex = 20;
            this.cbbCachThucThanhToan.SelectedIndexChanged += new System.EventHandler(this.cbbCachThucThanhToan_SelectedIndexChanged);
            // 
            // lbDot
            // 
            this.lbDot.AutoSize = true;
            this.lbDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDot.Location = new System.Drawing.Point(685, 262);
            this.lbDot.Name = "lbDot";
            this.lbDot.Size = new System.Drawing.Size(53, 29);
            this.lbDot.TabIndex = 21;
            this.lbDot.Text = "Đợt";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.White;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(655, 489);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(153, 54);
            this.btnThanhToan.TabIndex = 22;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lbVoucher
            // 
            this.lbVoucher.AutoSize = true;
            this.lbVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbVoucher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVoucher.Location = new System.Drawing.Point(541, 318);
            this.lbVoucher.Name = "lbVoucher";
            this.lbVoucher.Size = new System.Drawing.Size(109, 29);
            this.lbVoucher.TabIndex = 23;
            this.lbVoucher.Text = "Voucher";
            // 
            // cbbVoucher
            // 
            this.cbbVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbVoucher.FormattingEnabled = true;
            this.cbbVoucher.Location = new System.Drawing.Point(668, 318);
            this.cbbVoucher.Margin = new System.Windows.Forms.Padding(4);
            this.cbbVoucher.Name = "cbbVoucher";
            this.cbbVoucher.Size = new System.Drawing.Size(216, 28);
            this.cbbVoucher.TabIndex = 24;
            this.cbbVoucher.SelectedIndexChanged += new System.EventHandler(this.cbbVoucher_SelectedIndexChanged);
            // 
            // lbThanhToan
            // 
            this.lbThanhToan.AutoSize = true;
            this.lbThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhToan.Location = new System.Drawing.Point(385, 42);
            this.lbThanhToan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThanhToan.Name = "lbThanhToan";
            this.lbThanhToan.Size = new System.Drawing.Size(211, 39);
            this.lbThanhToan.TabIndex = 25;
            this.lbThanhToan.Text = "Thanh Toán";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTien.Location = new System.Drawing.Point(684, 433);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(77, 36);
            this.lbTien.TabIndex = 26;
            this.lbTien.Text = "Tiền";
            // 
            // lbMaThe
            // 
            this.lbMaThe.AutoSize = true;
            this.lbMaThe.Enabled = false;
            this.lbMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaThe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaThe.Location = new System.Drawing.Point(99, 455);
            this.lbMaThe.Name = "lbMaThe";
            this.lbMaThe.Size = new System.Drawing.Size(101, 29);
            this.lbMaThe.TabIndex = 27;
            this.lbMaThe.Text = "Mã Thẻ";
            // 
            // txtMaThe
            // 
            this.txtMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaThe.Location = new System.Drawing.Point(104, 489);
            this.txtMaThe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(265, 26);
            this.txtMaThe.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(446, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 29;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MHThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 620);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MHThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button1;
    }
}