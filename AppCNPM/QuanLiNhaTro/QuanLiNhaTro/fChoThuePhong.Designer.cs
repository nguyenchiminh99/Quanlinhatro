namespace QuanLiNhaTro
{
    partial class fChoThuePhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChoThuePhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGVKhach = new System.Windows.Forms.DataGridView();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGVPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdPhongMoi = new System.Windows.Forms.RadioButton();
            this.rdGhep = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVKhach)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVPhong)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(24, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 563);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGVKhach);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 557);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khách Chưa Có Phòng";
            // 
            // DataGVKhach
            // 
            this.DataGVKhach.AllowUserToAddRows = false;
            this.DataGVKhach.BackgroundColor = System.Drawing.Color.LightCyan;
            this.DataGVKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVKhach.ColumnHeadersVisible = false;
            this.DataGVKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhach,
            this.TenKhach});
            this.DataGVKhach.Location = new System.Drawing.Point(0, 25);
            this.DataGVKhach.Name = "DataGVKhach";
            this.DataGVKhach.ReadOnly = true;
            this.DataGVKhach.RowHeadersVisible = false;
            this.DataGVKhach.RowHeadersWidth = 62;
            this.DataGVKhach.RowTemplate.Height = 28;
            this.DataGVKhach.Size = new System.Drawing.Size(371, 526);
            this.DataGVKhach.TabIndex = 0;
            this.DataGVKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVKhach_CellClick);
            // 
            // MaKhach
            // 
            this.MaKhach.DataPropertyName = "MaKhach";
            this.MaKhach.HeaderText = "Mã Khách";
            this.MaKhach.MinimumWidth = 8;
            this.MaKhach.Name = "MaKhach";
            this.MaKhach.ReadOnly = true;
            this.MaKhach.Width = 30;
            // 
            // TenKhach
            // 
            this.TenKhach.DataPropertyName = "TenKhach";
            this.TenKhach.HeaderText = "Họ Tên Khách Hàng";
            this.TenKhach.MinimumWidth = 8;
            this.TenKhach.Name = "TenKhach";
            this.TenKhach.ReadOnly = true;
            this.TenKhach.Width = 226;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(462, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 563);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGVPhong);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 557);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng";
            // 
            // DataGVPhong
            // 
            this.DataGVPhong.AllowUserToAddRows = false;
            this.DataGVPhong.BackgroundColor = System.Drawing.Color.LightCyan;
            this.DataGVPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVPhong.ColumnHeadersVisible = false;
            this.DataGVPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong});
            this.DataGVPhong.Location = new System.Drawing.Point(0, 25);
            this.DataGVPhong.Name = "DataGVPhong";
            this.DataGVPhong.ReadOnly = true;
            this.DataGVPhong.RowHeadersVisible = false;
            this.DataGVPhong.RowHeadersWidth = 62;
            this.DataGVPhong.RowTemplate.Height = 28;
            this.DataGVPhong.Size = new System.Drawing.Size(170, 526);
            this.DataGVPhong.TabIndex = 0;
            this.DataGVPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVPhong_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "MaPhong";
            this.MaPhong.MinimumWidth = 8;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdPhongMoi);
            this.panel3.Controls.Add(this.rdGhep);
            this.panel3.Location = new System.Drawing.Point(669, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 140);
            this.panel3.TabIndex = 2;
            // 
            // rdPhongMoi
            // 
            this.rdPhongMoi.AutoSize = true;
            this.rdPhongMoi.Location = new System.Drawing.Point(14, 76);
            this.rdPhongMoi.Name = "rdPhongMoi";
            this.rdPhongMoi.Size = new System.Drawing.Size(198, 24);
            this.rdPhongMoi.TabIndex = 1;
            this.rdPhongMoi.TabStop = true;
            this.rdPhongMoi.Text = "Khách Thuê Phòng Mới";
            this.rdPhongMoi.UseVisualStyleBackColor = true;
            this.rdPhongMoi.CheckedChanged += new System.EventHandler(this.rdPhongMoi_CheckedChanged);
            // 
            // rdGhep
            // 
            this.rdGhep.AutoSize = true;
            this.rdGhep.Location = new System.Drawing.Point(14, 28);
            this.rdGhep.Name = "rdGhep";
            this.rdGhep.Size = new System.Drawing.Size(139, 24);
            this.rdGhep.TabIndex = 0;
            this.rdGhep.TabStop = true;
            this.rdGhep.Text = "Khách Ở Ghép";
            this.rdGhep.UseVisualStyleBackColor = true;
            this.rdGhep.CheckedChanged += new System.EventHandler(this.rdGhep_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThemKhach);
            this.panel4.Location = new System.Drawing.Point(695, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 78);
            this.panel4.TabIndex = 3;
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(3, 3);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(196, 72);
            this.btnThemKhach.TabIndex = 0;
            this.btnThemKhach.Text = "Thêm Khách";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(669, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // fChoThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 625);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "fChoThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Kí Thuê Phòng";
            this.Load += new System.EventHandler(this.fChoThuePhong_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVKhach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVPhong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGVKhach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGVPhong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdPhongMoi;
        private System.Windows.Forms.RadioButton rdGhep;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhach;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}