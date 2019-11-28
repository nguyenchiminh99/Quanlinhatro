namespace QuanLiNhaTro
{
    partial class fThongTinPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongTinPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGVCTKhach = new System.Windows.Forms.DataGridView();
            this.MP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGVPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTinPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVCTKhach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 668);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGVCTKhach);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1185, 279);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết khách thuê";
            // 
            // DataGVCTKhach
            // 
            this.DataGVCTKhach.AllowUserToAddRows = false;
            this.DataGVCTKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGVCTKhach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGVCTKhach.BackgroundColor = System.Drawing.Color.LightCyan;
            this.DataGVCTKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVCTKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MP,
            this.MaKhach,
            this.TenKhach,
            this.NgheNghiep,
            this.QueQuan});
            this.DataGVCTKhach.Location = new System.Drawing.Point(48, 34);
            this.DataGVCTKhach.Name = "DataGVCTKhach";
            this.DataGVCTKhach.RowHeadersVisible = false;
            this.DataGVCTKhach.RowHeadersWidth = 62;
            this.DataGVCTKhach.RowTemplate.Height = 28;
            this.DataGVCTKhach.Size = new System.Drawing.Size(1090, 235);
            this.DataGVCTKhach.TabIndex = 0;
            // 
            // MP
            // 
            this.MP.DataPropertyName = "MaPhong";
            this.MP.HeaderText = "Mã Phòng";
            this.MP.MinimumWidth = 8;
            this.MP.Name = "MP";
            // 
            // MaKhach
            // 
            this.MaKhach.DataPropertyName = "MaKhach";
            this.MaKhach.HeaderText = "Mã Khách";
            this.MaKhach.MinimumWidth = 8;
            this.MaKhach.Name = "MaKhach";
            // 
            // TenKhach
            // 
            this.TenKhach.DataPropertyName = "TenKhach";
            this.TenKhach.HeaderText = "Tên Khách";
            this.TenKhach.MinimumWidth = 8;
            this.TenKhach.Name = "TenKhach";
            // 
            // NgheNghiep
            // 
            this.NgheNghiep.DataPropertyName = "NgheNghiep";
            this.NgheNghiep.HeaderText = "Nghề Nghiệp";
            this.NgheNghiep.MinimumWidth = 8;
            this.NgheNghiep.Name = "NgheNghiep";
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.MinimumWidth = 8;
            this.QueQuan.Name = "QueQuan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGVPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // DataGVPhong
            // 
            this.DataGVPhong.AllowUserToAddRows = false;
            this.DataGVPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGVPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGVPhong.BackgroundColor = System.Drawing.Color.LightCyan;
            this.DataGVPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TrangThai,
            this.ThongTinPhong,
            this.LoaiPhong});
            this.DataGVPhong.Location = new System.Drawing.Point(48, 34);
            this.DataGVPhong.Name = "DataGVPhong";
            this.DataGVPhong.ReadOnly = true;
            this.DataGVPhong.RowHeadersVisible = false;
            this.DataGVPhong.RowHeadersWidth = 62;
            this.DataGVPhong.RowTemplate.Height = 28;
            this.DataGVPhong.Size = new System.Drawing.Size(1090, 328);
            this.DataGVPhong.TabIndex = 0;
            this.DataGVPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVPhong_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 8;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // ThongTinPhong
            // 
            this.ThongTinPhong.DataPropertyName = "ThongTinPhong";
            this.ThongTinPhong.HeaderText = "Thông Tin";
            this.ThongTinPhong.MinimumWidth = 8;
            this.ThongTinPhong.Name = "ThongTinPhong";
            this.ThongTinPhong.ReadOnly = true;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.MinimumWidth = 8;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            // 
            // fThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 681);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "fThongTinPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông Tin Phòng";
            this.Load += new System.EventHandler(this.fThongTinPhong_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVCTKhach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGVPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGVCTKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTinPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
    }
}