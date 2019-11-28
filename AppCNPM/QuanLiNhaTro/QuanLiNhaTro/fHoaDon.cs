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
    public partial class fHoaDon : Form
    {
        public fHoaDon()
        {
            InitializeComponent();
        }

        //Load Mã phòng có trạng thái đã cho thuê vào combobox
        private void Load_Phong()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "Select MaPhong from PHONGTRO where TrangThai=N'Phòng Đã Cho Thuê'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();

            adapter.Fill(data);
            cbPhong.DisplayMember = "MaPhong";
            cbPhong.DataSource = data;

            connection.Close();
        }

        //Load Tên các dịch vụ vào combobox
        private void Load_DichVu()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "Select * from DICH_VU";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();

            adapter.Fill(data);
            cbDV.DisplayMember = "TenDichVu";
            cbDV.DataSource = data;
            txtGia.DataBindings.Add("Text", cbDV.DataSource, "GiaDichVu");
            connection.Close();

        }

        //Load thông tin phòng, dịch vụ và hóa đơn sau khi form được load
        private void fHoaDon_Load(object sender, EventArgs e)
        {
            Load_Phong();
            Load_DichVu();
            Load_HoaDon();
        }

        //Load thông tin chi tiết hóa đơn
        public void Load_CTHD()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "Select DICH_VU.TenDichVu, CT_HOADON.DonViSuDung, CT_HOADON.ThanhTien from CT_HOADON,DICH_VU, HOA_DON where CT_HOADON.MaHoaDon=HOA_DON.MaHoaDon and HOA_DON.NgayLap='" + dateTimePicker1.Value + "' and HOA_DON.MaPhong='" + cbPhong.Text + "' and CT_HOADON.MaDichVu=DICH_VU.MaDichVu";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVCTHD.DataSource = data;
            connection.Close();
        }

        //Thêm dịch vụ vào hóa  đơn đã tạo
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbPhong.Text) || String.IsNullOrEmpty(cbDV.Text) || String.IsNullOrEmpty(txtSL.Text) || String.IsNullOrEmpty(txtNguoiLap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DataGVHD.CurrentRow == null)
                {
                    MessageBox.Show("Chưa lập hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionStr);
                    connection.Open();

                    String query = "Select Count(*) from HOA_DON, CT_HOADON, DICH_VU where CT_HOADON.MaDichVu=DICH_VU.MaDichVu and CT_HOADON.MaHoaDon=HOA_DON.MaHoaDon and HOA_DON.MaHoaDon='" + DataGVHD.CurrentRow.Cells[0].Value + "'  and DICH_VU.TenDichVu =N'" + cbDV.Text + "' and MONTH(HOA_DON.NgayLap) = '" + dateTimePicker1.Value.Month + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    if (int.Parse(data.Rows[0][0].ToString()) > 0)
                    {
                        MessageBox.Show("Dịch vụ này đã có trong chi tiết hóa đơn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        query = "select MaDichVu from DICH_VU where TenDichVu=N'" + cbDV.Text + "'";
                        command = new SqlCommand(query, connection);
                        adapter = new SqlDataAdapter(command);
                        data = new DataTable();
                        adapter.Fill(data);
                        int MaHD = int.Parse(data.Rows[0][0].ToString());
                        if (DataGVHD.CurrentRow.Selected == true)
                        {
                            query = "Insert into CT_HOADON values('" + DataGVHD.CurrentRow.Cells[0].Value + "','" + MaHD + "','" + txtSL.Text + "','" + labelTien.Text + "')";
                            command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            Load_CTHD();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn hóa đơn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        //Load hóa đơn vào gridview
        public void Load_HoaDon()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            
            String query = "Select * from HOA_DON";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVHD.DataSource = data;
            connection.Close();
        }

        //Lập hóa đơn
        private void btnTAO_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbPhong.Text) || String.IsNullOrEmpty(dateTimePicker1.Value.ToString()) || String.IsNullOrEmpty(txtNguoiLap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Phòng, Thời Gian và Tên Người Lập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();

                String query = "Select Count(*) from HOA_DON where MaPhong='" + cbPhong.Text + "' and Month(NgayLap)='" + dateTimePicker1.Value.Month + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);
                if (int.Parse(data.Rows[0][0].ToString()) > 0) //Kiểm tra sự tồn tại của hóa đơn
                {
                    MessageBox.Show("Hóa đơn tháng " + dateTimePicker1.Value.Month + " của phòng " + cbPhong.Text + " đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
                else
                {
                    query = "Insert into HOA_DON values('" + cbPhong.Text + "','" + dateTimePicker1.Value + "',N'" + txtNguoiLap.Text + "')";
                    command = new SqlCommand(query, connection);
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Tạo hóa đơn cho phòng " + cbPhong.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        Load_HoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Tạo hóa đơn cho phòng " + cbPhong.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
                connection.Close();

            }
        }

        //Hiển thị Chi tiết hóa đơn khi click vào hóa đơn
        private void DataGVHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGVHD.CurrentRow.Selected = true;
            cbPhong.Text = DataGVHD.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = DataGVHD.CurrentRow.Cells[2].Value.ToString();
            Load_CTHD();
        }

        //Xóa hóa đơn
        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (DataGVHD.CurrentRow == null)
            {
                MessageBox.Show("Không có hóa đơn để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();
                
                String query = "Delete  from HOA_DON where MaHoaDon ='" + DataGVHD.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand command = new SqlCommand(query, connection);
                if (MessageBox.Show("Bạn Thật Sự Muốn Xóa Hóa Đơn Này?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Xóa hóa đơn thất bại!");
                }
                else
                {
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_HoaDon();
                        Load_CTHD();
                        connection.Close();

                    }
                    else
                    {
                        MessageBox.Show("Xóa hóa đơn thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Load_HoaDon();
                        connection.Close();
                    }
                }
            }
        }

        //Hiển thị thành tiền khi đã chọn số lượng và tên dịch vụ
        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSL.Text))
            {
                //Tính tiền dịch vụ
                labelTien.Text = (int.Parse(txtGia.Text) * int.Parse(txtSL.Text)).ToString();
            }
            else
            {
                labelTien.Text = null;
            }
        }
    }
}
