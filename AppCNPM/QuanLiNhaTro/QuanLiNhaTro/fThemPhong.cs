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
    public partial class fThemPhong : Form
    {
        public fThemPhong()
        {
            InitializeComponent();
        }

        //Load loại phòng vào combobox
        private void Load_LoaiPhong()
        {
            String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
           
            String query = "Select LoaiPhong from GIA_THUE";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            cbLoaiPhong.DisplayMember = "LoaiPhong";
            cbLoaiPhong.DataSource = data;

            connection.Close();
        }

        private void fThemPhong_Load(object sender, EventArgs e)
        {
            Load_LoaiPhong();
        }

        //Thêm phòng mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbLoaiPhong.Text) && !String.IsNullOrEmpty(txtThongTin.Text))
            {
                String connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QUANLYNHATRO;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();

                String query = "Insert into PHONGTRO values(N'Phòng Trống',N'"+txtThongTin.Text+"','"+int.Parse(cbLoaiPhong.Text)+"')";
                SqlCommand command = new SqlCommand(query, connection);
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Đã thêm một phòng mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm phòng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
