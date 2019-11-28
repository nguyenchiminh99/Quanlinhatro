namespace QuanLiNhaTro
{
    partial class fGiaPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGiaPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGVGT = new System.Windows.Forms.DataGridView();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnThemLoai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVGT)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 350);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGVGT);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Giá";
            // 
            // DataGVGT
            // 
            this.DataGVGT.BackgroundColor = System.Drawing.Color.LightCyan;
            this.DataGVGT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVGT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiPhong,
            this.GiaTien});
            this.DataGVGT.Location = new System.Drawing.Point(6, 25);
            this.DataGVGT.Name = "DataGVGT";
            this.DataGVGT.ReadOnly = true;
            this.DataGVGT.RowHeadersVisible = false;
            this.DataGVGT.RowHeadersWidth = 62;
            this.DataGVGT.RowTemplate.Height = 28;
            this.DataGVGT.Size = new System.Drawing.Size(471, 319);
            this.DataGVGT.TabIndex = 0;
            this.DataGVGT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVGT_CellClick);
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.MinimumWidth = 8;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            this.LoaiPhong.Width = 150;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            dataGridViewCellStyle1.Format = "#,### Đồng/Tháng";
            dataGridViewCellStyle1.NullValue = "0";
            this.GiaTien.DefaultCellStyle = dataGridViewCellStyle1;
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.MinimumWidth = 8;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(525, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 174);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox);
            this.groupBox2.Controls.Add(this.txtGiaTien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 171);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox.Location = new System.Drawing.Point(116, 51);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 28);
            this.comboBox.TabIndex = 4;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(116, 111);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(204, 26);
            this.txtGiaTien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Phòng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnChinhSua);
            this.panel3.Controls.Add(this.btnThemLoai);
            this.panel3.Location = new System.Drawing.Point(525, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 154);
            this.panel3.TabIndex = 2;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(207, 33);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(122, 87);
            this.btnChinhSua.TabIndex = 1;
            this.btnChinhSua.Text = "Cập Nhật";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Location = new System.Drawing.Point(36, 33);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(122, 87);
            this.btnThemLoai.TabIndex = 0;
            this.btnThemLoai.Text = "Thêm Loại Phòng";
            this.btnThemLoai.UseVisualStyleBackColor = true;
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // fGiaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 388);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fGiaPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng Giá Phòng Trọ";
            this.Load += new System.EventHandler(this.fGiaPhong_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVGT)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThemLoai;
        private System.Windows.Forms.DataGridView DataGVGT;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
    }
}