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
    public partial class fTaoTK : Form
    {
        public fTaoTK()
        {
            InitializeComponent();
        }

        //Tạo tài khoản mới
        private void button1_Click(object sender, EventArgs e)
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                String query = "Select Count(*) from QUANLY where Username=N'" + txtUsername.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);
                if (data.Rows[0][0].ToString() != "1") // Kiểm tra tên tài khoản đã tồn tại chưa
                {
                    query = "Insert into QUANLY values(N'" + txtUsername.Text + "',N'" + txtPassword.Text + "',N'" + txtName.Text + "')";
                    command = new SqlCommand(query, connection);

                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản thất bại thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản đã tồn tại, vui lòng chọn tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Hủy tạo tài khoản
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
