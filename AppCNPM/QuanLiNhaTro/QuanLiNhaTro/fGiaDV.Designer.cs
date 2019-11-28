namespace QuanLiNhaTro
{
    partial class fGiaDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGiaDV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGVDV = new System.Windows.Forms.DataGridView();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVDV)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(26, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 426);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGVDV);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Giá";
            // 
            // DataGVDV
            // 
            this.DataGVDV.BackgroundColor = System.Drawing.Color.LightCyan;
            this.DataGVDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDichVu,
            this.TenDichVu,
            this.GiaDichVu,
            this.DonViTinh});
            this.DataGVDV.Location = new System.Drawing.Point(0, 25);
            this.DataGVDV.Name = "DataGVDV";
            this.DataGVDV.ReadOnly = true;
            this.DataGVDV.RowHeadersVisible = false;
            this.DataGVDV.RowHeadersWidth = 62;
            this.DataGVDV.RowTemplate.Height = 28;
            this.DataGVDV.Size = new System.Drawing.Size(435, 389);
            this.DataGVDV.TabIndex = 0;
            this.DataGVDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVDV_CellClick);
            // 
            // MaDichVu
            // 
            this.MaDichVu.DataPropertyName = "MaDichVu";
            this.MaDichVu.HeaderText = "Mã Dịch Vụ";
            this.MaDichVu.MinimumWidth = 8;
            this.MaDichVu.Name = "MaDichVu";
            this.MaDichVu.ReadOnly = true;
            this.MaDichVu.Width = 150;
            // 
            // TenDichVu
            // 
            this.TenDichVu.DataPropertyName = "TenDichVu";
            this.TenDichVu.HeaderText = "Tên";
            this.TenDichVu.MinimumWidth = 8;
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.ReadOnly = true;
            this.TenDichVu.Width = 150;
            // 
            // GiaDichVu
            // 
            this.GiaDichVu.DataPropertyName = "GiaDichVu";
            dataGridViewCellStyle1.Format = "#,###";
            dataGridViewCellStyle1.NullValue = "0";
            this.GiaDichVu.DefaultCellStyle = dataGridViewCellStyle1;
            this.GiaDichVu.HeaderText = "Giá Tiền";
            this.GiaDichVu.MinimumWidth = 8;
            this.GiaDichVu.Name = "GiaDichVu";
            this.GiaDichVu.ReadOnly = true;
            this.GiaDichVu.Width = 150;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.MinimumWidth = 8;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(506, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 238);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDonVi);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 230);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(139, 156);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(245, 26);
            this.txtDonVi.TabIndex = 5;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(139, 100);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(245, 26);
            this.txtGia.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(139, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(245, 26);
            this.txtTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn Vị Tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Dịch Vụ:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnChinhSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(473, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 96);
            this.panel3.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(340, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 75);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa Dịch Vụ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(192, 16);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(131, 75);
            this.btnChinhSua.TabIndex = 1;
            this.btnChinhSua.Text = "Cập Nhật";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 75);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm Dịch Vụ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // fGiaDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 492);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fGiaDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng Giá Dịch Vụ";
            this.Load += new System.EventHandler(this.fGiaDV_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVDV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DataGVDV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
    }
}