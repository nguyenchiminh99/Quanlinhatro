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
    public partial class fGiaPhong : Form
    {
        public fGiaPhong()
        {
            InitializeComponent();
        }

        //Tạo hàm Load thông tin giá thuê phòng
        private void DataBind()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();

            String query = "Select * From GIA_THUE";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            DataGVGT.DataSource = data;

            connection.Close();
        }

        //Load thông tin giá thuê phòng
        private void fGiaPhong_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        //Hiển thị thông tin chi tiết giá thuê phòng
        private void DataGVGT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGVGT.CurrentRow.Selected = true;
            comboBox.Text = DataGVGT.CurrentRow.Cells[0].Value.ToString();
            String currency = String.Format("{0:0,0}", DataGVGT.CurrentRow.Cells[1].Value); //Format kiểu hiển thị của giá tiền
            txtGiaTien.Text = currency;
        }

        //Cập nhật thông tin giá thuê phòng
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (DataGVGT.CurrentRow.Selected == false)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần chỉnh sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!String.IsNullOrEmpty(comboBox.Text) && !String.IsNullOrEmpty(txtGiaTien.Text))
                {
                    String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionStr);
                    connection.Open();

                    //Update lại giá tiền
                    String query = "Update GIA_THUE set LoaiPhong='" + comboBox.Text + "', GiaTien ='" + txtGiaTien.Text + "' where LoaiPhong='" + DataGVGT.CurrentRow.Cells[0].Value + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    if (MessageBox.Show("Bạn Thật Sự Muốn Cập Nhật Thông Tin Này?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
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
        }

        //Thêm một loại phòng mới
        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox.Text) && !String.IsNullOrEmpty(txtGiaTien.Text))
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();

                //Kiểm tra loại phòng này đã tông tại hay chưa
                String query = "Select Count(*) from GIA_THUE where LoaiPhong='" + comboBox.Text + "' ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);
                if (int.Parse(data.Rows[0][0].ToString()) > 0)
                {
                    MessageBox.Show("Loại phòng này đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
                else
                {
                    query = "Insert into GIA_THUE values('" + comboBox.Text + "', '" + txtGiaTien.Text + "') ";
                    command = new SqlCommand(query, connection);
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Thêm loại phòng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBind();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại phòng thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
