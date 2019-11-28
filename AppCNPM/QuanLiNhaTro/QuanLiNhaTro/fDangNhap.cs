using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaTro
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();

        }
        //Khởi tạo biến để lưu lại username
        public static string Username = "";

        //Nếu click button thoát thì chương trình kết thúc
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Xử lí sự kiện đóng form
        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Nếu người dùng chọn Cancel thì sẽ hủy tác vụ đóng form
            if (MessageBox.Show("Bạn Thật Sự Muốn Thoát Chương Trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void DangNhap()
        {
            //Tạo kết nối với database
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionStr);

            //khởi tạo câu truy vấn
            String query = "Select Count(*) From QUANLY Where Username ='" + txtTaikhoan.Text + "' and Password='" + txtPassword.Text + "' ";

            //Mở kết nối
            connection.Open();

            //Xử lí câu truy vấn
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable data = new DataTable();

            //Fill dữ liệu vào adapter
            adapter.Fill(data);

            //Đóng kết nối
            connection.Close();

            //Nếu username và password đã được nhập đầy đủ
            if (!String.IsNullOrEmpty(txtTaikhoan.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                //Nếu username và password đúng
                if (data.Rows[0][0].ToString() == "1")
                {
                    //Lưu lại username mà người dùng đã nhập
                    Username = txtTaikhoan.Text;
                    //Tạo form quản lí
                    fQuanLi f = new fQuanLi();
                    //Ẩn form Đăng Nhập
                    this.Hide();
                    //Show form quản lí
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    //Nếu người dùng nhập sai username và password
                    MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Chính Xác, Xin Vui Lòng Nhập Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Nếu người dùng chưa nhập đầy đủ username và password
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Tài Khoản Và Mật Khẩu!");
            }
        }
        //Nếu người dùng chọn button đăng nhập thì sẽ tạo kết nối và so sánh dữ liệu username và password người dùng đã nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
            txtPassword.Clear();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
                txtPassword.Clear();
            }

        }
    }
}
