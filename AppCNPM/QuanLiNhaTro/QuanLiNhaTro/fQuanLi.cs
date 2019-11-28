using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaTro
{
    public partial class fQuanLi : Form
    {
        public fQuanLi()
        {
            InitializeComponent();
        }

        private void fQuanLi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Thật Sự Muốn Thoát Chương Trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {

                e.Cancel = true;
            }

        }

        private void thôngTinPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinPhong fttp = new fThongTinPhong();
            fttp.ShowDialog();
        }

        private void choThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChoThuePhong fctp = new fChoThuePhong();
            fctp.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMatKhau fdmk = new fDoiMatKhau();
            fdmk.ShowDialog();
        }

        private void tạoMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTaoTK fttk = new fTaoTK();
            fttk.ShowDialog();
        }

        private void thôngTinKháchThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinKhach fttk = new fThongTinKhach();
            fttk.ShowDialog();
        }

        private void giáPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGiaPhong fgp = new fGiaPhong();
            fgp.ShowDialog();
        }

        private void giáDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGiaDV fgdv = new fGiaDV();
            fgdv.ShowDialog();
        }

        private void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHoaDon fhd = new fHoaDon();
            fhd.ShowDialog();
        }

        private void thốngKêHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongKe ftk = new fThongKe();
            ftk.ShowDialog();
        }

        private void thêmPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemPhong ftp = new fThemPhong();
            ftp.ShowDialog();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraPhong ftraphong = new fTraPhong();
            ftraphong.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
