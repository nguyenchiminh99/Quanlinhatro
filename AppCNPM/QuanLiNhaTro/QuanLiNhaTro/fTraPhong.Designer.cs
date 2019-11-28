namespace QuanLiNhaTro
{
    partial class fTraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTraPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTraPhong = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGVTraPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTraPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTraPhong);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTraPhong);
            this.panel1.Location = new System.Drawing.Point(45, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 130);
            this.panel1.TabIndex = 0;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTraPhong.Location = new System.Drawing.Point(715, 51);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(153, 76);
            this.btnTraPhong.TabIndex = 3;
            this.btnTraPhong.Text = "Xác Nhận";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Phòng:";
            // 
            // cbTraPhong
            // 
            this.cbTraPhong.FormattingEnabled = true;
            this.cbTraPhong.Location = new System.Drawing.Point(715, 5);
            this.cbTraPhong.Name = "cbTraPhong";
            this.cbTraPhong.Size = new System.Drawing.Size(153, 28);
            this.cbTraPhong.TabIndex = 0;
            this.cbTraPhong.SelectedIndexChanged += new System.EventHandler(this.cbTraPhong_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(45, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 265);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGVTraPhong);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách thuê phòng";
            // 
            // DataGVTraPhong
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVTraPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGVTraPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVTraPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.MaKhach,
            this.TenKhach,
            this.NgheNghiep,
            this.QueQuan});
            this.DataGVTraPhong.Location = new System.Drawing.Point(6, 25);
            this.DataGVTraPhong.Name = "DataGVTraPhong";
            this.DataGVTraPhong.RowHeadersVisible = false;
            this.DataGVTraPhong.RowHeadersWidth = 62;
            this.DataGVTraPhong.RowTemplate.Height = 28;
            this.DataGVTraPhong.Size = new System.Drawing.Size(887, 228);
            this.DataGVTraPhong.TabIndex = 0;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 8;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 150;
            // 
            // MaKhach
            // 
            this.MaKhach.DataPropertyName = "MaKhach";
            this.MaKhach.HeaderText = "Mã Khách";
            this.MaKhach.MinimumWidth = 8;
            this.MaKhach.Name = "MaKhach";
            this.MaKhach.Width = 150;
            // 
            // TenKhach
            // 
            this.TenKhach.DataPropertyName = "TenKhach";
            this.TenKhach.HeaderText = "Tên Khách";
            this.TenKhach.MinimumWidth = 8;
            this.TenKhach.Name = "TenKhach";
            this.TenKhach.Width = 200;
            // 
            // NgheNghiep
            // 
            this.NgheNghiep.DataPropertyName = "NgheNghiep";
            this.NgheNghiep.HeaderText = "Nghề Nghiệp";
            this.NgheNghiep.MinimumWidth = 8;
            this.NgheNghiep.Name = "NgheNghiep";
            this.NgheNghiep.Width = 200;
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.MinimumWidth = 8;
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Width = 200;
            // 
            // fTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trả Phòng";
            this.Load += new System.EventHandler(this.fTraPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTraPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTraPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGVTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
    }
}