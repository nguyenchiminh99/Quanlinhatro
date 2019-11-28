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
    public partial class fGiaDV : Form
    {
        public fGiaDV()
        {
            InitializeComponent();
        }

        //Tạo hàm Load dịch vụ và giá
        private void DataBind()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "Select * From DICH_VU";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();

            adapter.Fill(data);
            DataGVDV.DataSource = data;

            connection.Close();
        }

        //Load dịch vụ và giá
        private void fGiaDV_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        //Hiển thị thông tin chi tiết dịch vụ vào textbox
        private void DataGVDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGVDV.CurrentRow.Selected = true;
            txtTen.Text = DataGVDV.CurrentRow.Cells[1].Value.ToString();
            txtGia.Text = String.Format("{0:0,0}", DataGVDV.CurrentRow.Cells[2].Value); //Format kiểu hiển thị tiền
            txtDonVi.Text = DataGVDV.CurrentRow.Cells[3].Value.ToString();
        }

        //Thêm dịch vụ mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTen.Text) && !String.IsNullOrEmpty(txtGia.Text) && !String.IsNullOrEmpty(txtDonVi.Text))
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();
                
                
                String query = "Select Count(*) from DICH_VU where TenDichVu=N'" + txtTen.Text + "' ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);
                if (int.Parse(data.Rows[0][0].ToString()) > 0)  //Kiểm tra dịch vụ có tồn tại hay chưa
                {
                    MessageBox.Show("Dịch vụ này đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
                else
                {
                    //Nếu chưa tồn tại thì thực thi query
                    query = "Insert into DICH_VU values(N'" + txtTen.Text + "', '" + txtGia.Text + "', N'" + txtDonVi.Text + "') ";
                    command = new SqlCommand(query, connection);
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Thêm dịch vụ mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBind();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm dịch vụ thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cập nhật thông tin dịch vụ
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTen.Text) && !String.IsNullOrEmpty(txtGia.Text) && !String.IsNullOrEmpty(txtDonVi.Text))
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();

                String query = "Update DICH_VU set TenDichVu=N'" + txtTen.Text + "', GiaDichVu='" + txtGia.Text + "', DonViTinh='" + txtDonVi.Text + "'  where MaDichVu='" + DataGVDV.CurrentRow.Cells[0].Value + "' ";
                SqlCommand command = new SqlCommand(query, connection);
                if (MessageBox.Show("Bạn Thật Sự Muốn Cập nhật Thông Tin Này?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Cập nhật thông tin  thất bại!");
                }
                else
                {
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        DataBind();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }


            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Xóa dịch vụ đã chọn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DataGVDV.CurrentRow.Selected == false)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();
                
                String query = "Delete from DICH_VU where TenDichVu=N'" + DataGVDV.CurrentRow.Cells[1].Value + "'";
                SqlCommand command = new SqlCommand(query, connection);
                if (MessageBox.Show("Bạn Thật Sự Muốn Xóa Dịch Vụ Này?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Xóa dịch vụ thất bại!");
                }
                else
                {
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        DataBind();
                    }
                    else
                    {
                        MessageBox.Show("Xóa dịch vụ thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
            }
        }
    }
}
