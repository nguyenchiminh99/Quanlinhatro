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
    public partial class fTraPhong : Form
    {
        public fTraPhong()
        {
            InitializeComponent();
        }

        private void fTraPhong_Load(object sender, EventArgs e)
        {
            Load_Phong();
        }

        //Load danh sách phòng đang được cho thuê vào combobox
        private void Load_Phong()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            
            String query = "Select MaPhong from PHONGTRO where TrangThai=N'Phòng đã cho thuê'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            cbTraPhong.DisplayMember = "MaPhong";
            cbTraPhong.DataSource = data;
            connection.Close();
        }

        //Load thông tin khách sau khi chọn phòng
        private void Load_Khach()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            
            String query = "Select PHONGTRO.MaPhong, KHACH_THUE.MaKhach, KHACH_THUE.TenKhach, KHACH_THUE.NgheNghiep, KHACH_THUE.QueQuan from PHONGTRO, KHACH_THUE, CT_KHACH_THUE where PHONGTRO.MaPhong = CT_KHACH_THUE.MaPhong and CT_KHACH_THUE.MaKhach = KHACH_THUE.MaKhach and PHONGTRO.MaPhong = '" + cbTraPhong.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVTraPhong.DataSource = data;
            connection.Close();
        }

        private void cbTraPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Khach();
        }

        //Khi nhấn nút trả phòng thì xóa thông tin khách thuê tương ứng
        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thông tin thuê phòng này sẽ bị xóa?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK){
                MessageBox.Show("Thao đã tác bị hủy!");
            }
            else
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";

                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();
                //Xóa Thông tin trong chi tiết khách thuê trước
                String query = "Delete from CT_KHACH_THUE where MaPhong='" + cbTraPhong.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int ret = command.ExecuteNonQuery();

                if (ret > 0)
                {
                    MessageBox.Show("Xóa thông tin thuê phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Update lại trạng thái phòng trọ
                    query = "Update PHONGTRO set TrangThai=N'Phòng trống' where MaPhong='"+cbTraPhong.Text+"'";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    Load_Khach();
                    Load_Phong();
                }
                else
                {
                    MessageBox.Show("Xóa thông tin thuê phòng thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Load_Khach();
                    Load_Phong();
                    connection.Close();
                }
            }
        }
    }
}
