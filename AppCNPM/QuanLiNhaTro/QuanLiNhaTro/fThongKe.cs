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
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }

        private void fThongKe_Load(object sender, EventArgs e)
        {
            Load_Thang();
            Load_Nam();
        }

        //Load các tháng có hóa đơn được tạo vào combobox
        public void Load_Thang()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "Select DISTINCT Month(NgayLap) as NgayLap from HOA_DON";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            cbThang.DisplayMember = "NgayLap";
            cbThang.DataSource = data;
            connection.Close();
        }

        //Load các năm có hóa đơn được tạo vào combobox
        public void Load_Nam()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "Select DISTINCT  Year(NgayLap) as NgayLap from HOA_DON";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            cbNam.DisplayMember = "NgayLap";
            cbNam.DataSource = data;
            connection.Close();
        }

        //Hiển thị các hóa đơn theo tháng và năm đã chọn
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbNam.Text) && !String.IsNullOrEmpty(cbThang.Text))
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();

                String query = "Select MaHoaDon,MaPhong,NgayLap from HOA_DON where Month(NgayLap)='" + cbThang.Text + "' and Year(NgayLap)='" + cbNam.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);
                DataGVHD.DataSource = data;
                //Tính Doanh Thu Của Tháng
                /*Tổng tiền dịch vụ của tháng*/
                query = "select SUM(ThanhTien) from CT_HOADON,HOA_DON where Month(HOA_DON.NgayLap)='" + cbThang.Text + "' and Year(HOA_DON.NgayLap)='" + cbNam.Text + "' and CT_HOADON.MaHoaDon=HOA_DON.MaHoaDon";
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                data = new DataTable();
                adapter.Fill(data);
                int tongTienDichVuThang = int.Parse(data.Rows[0][0].ToString());
                /*Tổng tiền phòng trọ của tháng*/
                query = "select SUM(GIA_THUE.GiaTien) from GIA_THUE, PHONGTRO, HOA_DON where PHONGTRO.MaPhong=HOA_DON.MaPhong and PHONGTRO.LoaiPhong=GIA_THUE.LoaiPhong and Month(HOA_DON.NgayLap)='" + cbThang.Text + "' and Year(HOA_DON.NgayLap)='" + cbNam.Text + "' ";
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                data = new DataTable();
                adapter.Fill(data);
                int tongTienPhongThang = int.Parse(data.Rows[0][0].ToString());
                txtDTT.Text = (tongTienDichVuThang + tongTienPhongThang).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Tháng và Năm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DataGVHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGVHD.CurrentRow.Selected = true;

            //Lấy Giá Tiền Của Phòng
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            String query = "Select PHONGTRO.MaPhong, GIA_THUE.GiaTien from PHONGTRO, GIA_THUE where PHONGTRO.LoaiPhong=GIA_THUE.LoaiPhong and PHONGTRO.MaPhong='" + DataGVHD.CurrentRow.Cells[1].Value + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVTP.DataSource = data;

            //Lấy Thông Tin Các Dịch Vụ Mà Phòng Sử Dụng
            query = "Select * from CT_HOADON where MaHoaDon='" + DataGVHD.CurrentRow.Cells[0].Value + "'";
            command = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(command);
            data = new DataTable();
            adapter.Fill(data);
            DataGVTDV.DataSource = data;

            //Tính Tổng Tiền Phòng Của Phòng Trong Tháng
            query = "select SUM(ThanhTien) from CT_HOADON, HOA_DON where Month(HOA_DON.NgayLap)= '" + cbThang.Text + "' and Year(HOA_DON.NgayLap)= '" + cbNam.Text + "' and CT_HOADON.MaHoaDon = HOA_DON.MaHoaDon and CT_HOADON.MaHoaDon='" + DataGVHD.CurrentRow.Cells[0].Value + "'";
            command = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(command);
            data = new DataTable();
            adapter.Fill(data);
            int GiaDV = int.Parse(data.Rows[0][0].ToString());
            int GiaPhong = int.Parse(DataGVTP.Rows[0].Cells[1].Value.ToString());
            int TienPhong = GiaDV + GiaPhong;
            txtTP.Text = TienPhong.ToString();
            connection.Close();
        }
    }
}
