namespace QuanLiNhaTro
{
    partial class fThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongKe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGVTP = new System.Windows.Forms.DataGridView();
            this.MaPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGVTDV = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataGVHD = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDTT = new System.Windows.Forms.TextBox();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTP)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTDV)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVHD)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 143);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGVTP);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiền phòng trọ";
            // 
            // DataGVTP
            // 
            this.DataGVTP.BackgroundColor = System.Drawing.Color.Cyan;
            this.DataGVTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPH,
            this.GiaTien});
            this.DataGVTP.Location = new System.Drawing.Point(6, 25);
            this.DataGVTP.Name = "DataGVTP";
            this.DataGVTP.ReadOnly = true;
            this.DataGVTP.RowHeadersVisible = false;
            this.DataGVTP.RowHeadersWidth = 62;
            this.DataGVTP.RowTemplate.Height = 28;
            this.DataGVTP.Size = new System.Drawing.Size(458, 103);
            this.DataGVTP.TabIndex = 0;
            // 
            // MaPH
            // 
            this.MaPH.DataPropertyName = "MaPhong";
            this.MaPH.HeaderText = "Mã Phòng";
            this.MaPH.MinimumWidth = 8;
            this.MaPH.Name = "MaPH";
            this.MaPH.ReadOnly = true;
            this.MaPH.Width = 150;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.MinimumWidth = 8;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(12, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 307);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGVTDV);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 301);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiền dịch vụ sử dụng";
            // 
            // DataGVTDV
            // 
            this.DataGVTDV.BackgroundColor = System.Drawing.Color.Cyan;
            this.DataGVTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVTDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaDV,
            this.DonViSuDung,
            this.ThanhTien});
            this.DataGVTDV.Location = new System.Drawing.Point(5, 25);
            this.DataGVTDV.Name = "DataGVTDV";
            this.DataGVTDV.ReadOnly = true;
            this.DataGVTDV.RowHeadersVisible = false;
            this.DataGVTDV.RowHeadersWidth = 62;
            this.DataGVTDV.RowTemplate.Height = 28;
            this.DataGVTDV.Size = new System.Drawing.Size(463, 270);
            this.DataGVTDV.TabIndex = 0;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHoaDon";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 80;
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDichVu";
            this.MaDV.HeaderText = "Mã Dịch Vụ";
            this.MaDV.MinimumWidth = 8;
            this.MaDV.Name = "MaDV";
            this.MaDV.ReadOnly = true;
            this.MaDV.Width = 80;
            // 
            // DonViSuDung
            // 
            this.DonViSuDung.DataPropertyName = "DonViSuDung";
            this.DonViSuDung.HeaderText = "Đơn Vị SD";
            this.DonViSuDung.MinimumWidth = 8;
            this.DonViSuDung.Name = "DonViSuDung";
            this.DonViSuDung.ReadOnly = true;
            this.DonViSuDung.Width = 80;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(478, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "THỐNG KÊ HÓA ĐƠN";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(494, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 456);
            this.panel3.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataGVHD);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 449);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hóa đơn";
            // 
            // DataGVHD
            // 
            this.DataGVHD.BackgroundColor = System.Drawing.Color.Cyan;
            this.DataGVHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.MaPhong,
            this.NgayLap});
            this.DataGVHD.Location = new System.Drawing.Point(6, 21);
            this.DataGVHD.Name = "DataGVHD";
            this.DataGVHD.ReadOnly = true;
            this.DataGVHD.RowHeadersVisible = false;
            this.DataGVHD.RowHeadersWidth = 62;
            this.DataGVHD.RowTemplate.Height = 28;
            this.DataGVHD.Size = new System.Drawing.Size(342, 422);
            this.DataGVHD.TabIndex = 0;
            this.DataGVHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVHD_CellClick);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.MinimumWidth = 8;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            this.MaHoaDon.Width = 70;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 8;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Width = 70;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 8;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 150;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDTT);
            this.panel4.Controls.Add(this.txtTP);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnIn);
            this.panel4.Location = new System.Drawing.Point(861, 254);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 279);
            this.panel4.TabIndex = 4;
            // 
            // txtDTT
            // 
            this.txtDTT.Location = new System.Drawing.Point(176, 113);
            this.txtDTT.Name = "txtDTT";
            this.txtDTT.Size = new System.Drawing.Size(169, 26);
            this.txtDTT.TabIndex = 5;
            // 
            // txtTP
            // 
            this.txtTP.Location = new System.Drawing.Point(176, 43);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(169, 26);
            this.txtTP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doanh Thu Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng Tiền Phòng:";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(99, 216);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(169, 54);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "IN PHIẾU";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTim);
            this.panel5.Controls.Add(this.groupBox5);
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Location = new System.Drawing.Point(861, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(356, 171);
            this.panel5.TabIndex = 5;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(143, 116);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 39);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbNam);
            this.groupBox5.Location = new System.Drawing.Point(186, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 61);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Năm";
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(11, 22);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 28);
            this.cbNam.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbThang);
            this.groupBox4.Location = new System.Drawing.Point(33, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 61);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tháng";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(11, 22);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 28);
            this.cbThang.TabIndex = 0;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 559);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fThongKe";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống Kê Hóa Đơn";
            this.Load += new System.EventHandler(this.fThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTDV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVHD)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGVTP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGVTDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DataGVHD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDTT;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}