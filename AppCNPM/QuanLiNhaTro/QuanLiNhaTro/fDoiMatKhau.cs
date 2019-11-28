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
    public partial class fDoiMatKhau : Form
    {
        public fDoiMatKhau()
        {
            InitializeComponent();

        }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "select *from QUANLY where Username='" + fDangNhap.Username + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())// Tự động điền username
            {
                txtUsername.Text = reader.GetString(0).Trim();
            }
            else
            {
                ;
            }
            reader.Close();
            connection.Close();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            if (!String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(txtOldpassword.Text) && !String.IsNullOrEmpty(txtNewpassword.Text) && !String.IsNullOrEmpty(txtRepNewPass.Text))
            {
                String query = "select *from QUANLY where Username=N'" + fDangNhap.Username + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (txtOldpassword.Text == reader.GetString(1).Trim()) //Xác thực password
                    {
                        reader.Close();
                        if (txtRepNewPass.Text == txtNewpassword.Text) // Nếu mật khẩu mới và xác nhận mật khẩu mới đúng thì thực thi query
                        {
                            query = "exec DoiMatKhauADMIN '" + txtUsername.Text + "','" + txtNewpassword.Text + "'";
                            command = new SqlCommand(query, connection);
                            int ret = command.ExecuteNonQuery();
                            if (ret > 0)
                            {
                                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                connection.Close();
                            }
                            else
                            {
                                MessageBox.Show("Đổi mật khẩu thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                connection.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhập lại mật khẩu mới chưa chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ chưa chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
