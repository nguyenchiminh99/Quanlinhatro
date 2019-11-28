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
    public partial class fThongTinKhach : Form
    {
        public fThongTinKhach()
        {
            InitializeComponent();
        }

        //Load dữ liệu vào datagridview
        private void DataBind()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionStr);

            String query = "Select * From KHACH_THUE";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable data = new DataTable();

            adapter.Fill(data);
            DataGVTTK.DataSource = data;
            connection.Close();
        }
        private void fThongTinKhach_Load(object sender, EventArgs e)
        {
            DataBind();

        }

        //Hiển thị chi tiết thông tin khách thuê
        private void DataGVTTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGVTTK.CurrentRow.Selected = true;
            txtHoten.Text = DataGVTTK.CurrentRow.Cells[1].Value.ToString();
            if (DataGVTTK.CurrentRow.Cells[2].Value.Equals("Nam")) //Nếu giá trị là Nữ thì check vào radio button Nữ và ngược lại
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            txtCMND.Text = DataGVTTK.CurrentRow.Cells[3].Value.ToString();
            txtQQ.Text = DataGVTTK.CurrentRow.Cells[4].Value.ToString();
            txtNN.Text = DataGVTTK.CurrentRow.Cells[5].Value.ToString();
        }

        //Thêm khách thuê vào danh sách
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String Phai = null;
            if (rbNam.Checked == true)
            {
                Phai = "Nam";
            }
            else
            {
                Phai = "Nữ";
            }

            if (!String.IsNullOrEmpty(txtHoten.Text) && !String.IsNullOrEmpty(Phai) && !String.IsNullOrEmpty(txtCMND.Text) && !String.IsNullOrEmpty(txtNN.Text) && !String.IsNullOrEmpty(txtQQ.Text))
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();

                String query = "Select Count(*) from KHACH_THUE where CMND='" + txtCMND.Text + "' ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);
                if (int.Parse(data.Rows[0][0].ToString()) > 0) //Kiểm tra sự tồn tại của khách hàng
                {
                    MessageBox.Show("Khách hàng đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
                else
                {
                    //Thực hiện câu truy vấn thêm khách
                    query = "Insert into KHACH_THUE values(N'" + txtHoten.Text + "', N'" + Phai + "', N'" + txtCMND.Text + "', N'" + txtQQ.Text + "', N'" + txtNN.Text + "') ";
                    command = new SqlCommand(query, connection);
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Thêm khách hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBind();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng mới thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Chỉnh sủa thông tin khách
        private void btnEdit_Click(object sender, EventArgs e)
        {
            String Phai = "";
            if (rbNam.Checked == true)
            {
                Phai = "Nam";
            }
            else
            {
                Phai = "Nữ";
            }

            if (DataGVTTK.CurrentRow.Selected == false)
            {
                MessageBox.Show("Vui lòng chọn thông tin khách cần chỉnh sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!String.IsNullOrEmpty(txtHoten.Text) && !String.IsNullOrEmpty(Phai) && !String.IsNullOrEmpty(txtCMND.Text) && !String.IsNullOrEmpty(txtNN.Text) && !String.IsNullOrEmpty(txtQQ.Text))
                {
                    String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionStr);
                    connection.Open();
                    
                    String query = "Update KHACH_THUE SET TenKhach=N'" + txtHoten.Text + "', Phai= N'" + Phai + "', CMND='" + txtCMND.Text + "', QueQuan=N'" + txtQQ.Text + "', NgheNghiep=N'" + txtNN.Text + "' where MaKhach ='" + DataGVTTK.CurrentRow.Cells[0].Value.ToString() + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    if (MessageBox.Show("Bạn Thật Sự Muốn Sửa Thông Tin Khách Hàng Này?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thất bại!");
                    }
                    else
                    {
                        int ret = command.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                            DataBind();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin khách hàng thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Xóa khách thuê
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DataGVTTK.CurrentRow.Selected == false)
            {
                MessageBox.Show("Vui lòng chọn thông tin khách cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!String.IsNullOrEmpty(txtHoten.Text) || rbNam.Checked != true && !rbNu.Checked != true || !String.IsNullOrEmpty(txtCMND.Text) || !String.IsNullOrEmpty(txtNN.Text) || !String.IsNullOrEmpty(txtQQ.Text))
                {
                    String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionStr);
                    connection.Open();
                    
                    String query = "Delete from KHACH_THUE where MaKhach='" + DataGVTTK.CurrentRow.Cells[0].Value.ToString() + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    if (MessageBox.Show("Bạn Thật Sự Muốn Xóa Khách Hàng Này?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                    {
                        MessageBox.Show("Xóa thông tin khách hàng thất bại!");
                    }
                    else
                    {
                        int ret = command.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            MessageBox.Show("Xóa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                            DataBind();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thông tin khách hàng thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DataBind();
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Tìm kiếm thông tin khách hàng dựa theo tên
        private void btnTim_Click(object sender, EventArgs e)
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            
            String query = "Select * From KHACH_THUE where TenKhach like N'%" + txtTimKiem.Text + "%'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVTTK.DataSource = data;
            connection.Close();
        }
    }
}
