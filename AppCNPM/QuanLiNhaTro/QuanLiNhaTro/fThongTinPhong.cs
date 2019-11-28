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
    public partial class fThongTinPhong : Form
    {
        public fThongTinPhong()
        {
            InitializeComponent();
        }

        //Hiển thị thông tin phòng trọ
        private void fThongTinPhong_Load(object sender, EventArgs e)
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            
            String query = "Select * From PHONGTRO";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVPhong.DataSource = data;
            for (int i = 0; i < DataGVPhong.Rows.Count - 1; i++)
            {
                if (DataGVPhong.Rows[i].Cells[1].Value.ToString() == "Phòng đã cho thuê")
                {
                    DataGVPhong.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                }
            }
            connection.Close();
        }

        //Hiển thị thông tin khách thuê khi click vào một phòng đang cho thuê
        private void DataGVPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGVPhong.CurrentRow.Selected = true;
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "Select PHONGTRO.MaPhong, KHACH_THUE.MaKhach, KHACH_THUE.TenKhach, KHACH_THUE.NgheNghiep, KHACH_THUE.QueQuan from PHONGTRO, KHACH_THUE, CT_KHACH_THUE where PHONGTRO.MaPhong = CT_KHACH_THUE.MaPhong and CT_KHACH_THUE.MaKhach = KHACH_THUE.MaKhach and PHONGTRO.MaPhong = '" + DataGVPhong.CurrentRow.Cells[0].Value + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVCTKhach.DataSource = data;
        }
    }
}
