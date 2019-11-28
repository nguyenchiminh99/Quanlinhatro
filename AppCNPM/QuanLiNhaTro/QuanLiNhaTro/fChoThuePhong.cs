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
    public partial class fChoThuePhong : Form
    {
        public fChoThuePhong()
        {
            InitializeComponent();
        }

        private void fChoThuePhong_Load(object sender, EventArgs e)
        {
            //Load danh sách khách chưa có phòng
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            
            String query = "Select MaKhach,TenKhach from KHACH_THUE where TenKhach NOT IN(Select TenKhach from KHACH_THUE, CT_KHACH_THUE where KHACH_THUE.MaKhach = CT_KHACH_THUE.MaKhach)";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVKhach.DataSource = data;
            
            connection.Close();

        }

        //Nếu click vào radio button này thì sẽ hiển thị danh sách phòng có thể ghép
        private void rdGhep_CheckedChanged(object sender, EventArgs e)
        {

            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "Select MaPhong from PHONGTRO where MaPhong IN (Select PHONGTRO.MaPhong from PHONGTRO, CT_KHACH_THUE where PHONGTRO.MaPhong = CT_KHACH_THUE.MaPhong Group by PHONGTRO.MaPhong)";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVPhong.DataSource = data;

            connection.Close();
        }

        //Hiển thị danh sách phòng trống khi click radio button này
        private void rdPhongMoi_CheckedChanged(object sender, EventArgs e)
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "Select MaPhong from PHONGTRO where MaPhong NOT IN (Select PHONGTRO.MaPhong from PHONGTRO, CT_KHACH_THUE where PHONGTRO.MaPhong = CT_KHACH_THUE.MaPhong Group by PHONGTRO.MaPhong)";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVPhong.DataSource = data;

            connection.Close();
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem đã nhấn chọn khách, phòng và radio button chưa
            if (DataGVKhach.CurrentRow.Selected && DataGVPhong.CurrentRow.Selected && (rdGhep.Checked || rdPhongMoi.Checked))
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();

                String query = "Insert into CT_KHACH_THUE values ('" + DataGVKhach.CurrentRow.Cells[0].Value + "','" + DataGVPhong.CurrentRow.Cells[0].Value + "','" + dateTimePicker1.Value + "')";
                SqlCommand command = new SqlCommand(query, connection);
                int ret = command.ExecuteNonQuery();
                if (ret > 0)    //Nếu insert thành công thì sẽ cập nhật lại trạng thái phòng
                {

                    MessageBox.Show("Đã thêm khách hàng " + DataGVKhach.CurrentRow.Cells[1].Value.ToString() + " vào phòng " + DataGVPhong.CurrentRow.Cells[0].Value.ToString() + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Open();
                    query = "Update PHONGTRO set TrangThai=N'Phòng đã cho thuê' where MaPhong='" + DataGVPhong.CurrentRow.Cells[0].Value + "'";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng " + DataGVKhach.CurrentRow.Cells[1].Value.ToString() + " vào phòng " + DataGVPhong.CurrentRow.Cells[0].Value.ToString() + " thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Select cả 1 hàng trong DataGridView Khách
        private void DataGVKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGVKhach.CurrentRow.Selected = true;
        }

        //Select cả 1 hàng trong DataGridView Phòng
        private void DataGVPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGVPhong.CurrentRow.Selected = true;
        }
    }
}
