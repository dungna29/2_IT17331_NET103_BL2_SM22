using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAI_1_2_CRUD_OBJ.Models;
using BAI_1_2_CRUD_OBJ.Services;
using BAI_1_2_CRUD_OBJ.Utilities;

namespace BAI_1_2_CRUD_OBJ.Views
{
    public partial class FrmQLCuaHang : Form
    {
        //Toàn bộ biến toàn cục sẽ code trên đầu và có dấu _ và private
        private QLCuaHangService _chService;

        private Guid _idWhenClick;

        public FrmQLCuaHang()
        {
            InitializeComponent();
            _chService = new QLCuaHangService();
            txt_Ma.Enabled = false;//Khóa textbox mã lại
            rbtn_KoHoatDong.Checked = true;
            LoadThanhPho();
            LoadDGridCH(null);
        }

        private void LoadThanhPho()
        {
            foreach (var x in _chService.GetAllThanhPhos())
            {
                cmb_ThanhPho.Items.Add(x);
            }
            cmb_ThanhPho.SelectedIndex = 0;//Hiển thị giá trị mặc định
        }

        private void LoadDGridCH(string input)
        {
            int stt = 1;
            Type type = typeof(CuaHang);
            int slThuoTinh = type.GetProperties().Length;//Đếm số lượng thuộc tính mà đối tượng cửa hàng có.
            dgrid_CuaHangs.ColumnCount = slThuoTinh + 1;//Cộng 1 là vì muốn thêm 1 cột số thứ tự
            dgrid_CuaHangs.Columns[0].Name = "STT";
            dgrid_CuaHangs.Columns[1].Name = "Id";
            dgrid_CuaHangs.Columns[2].Name = "Mã";
            dgrid_CuaHangs.Columns[3].Name = "Tên";
            dgrid_CuaHangs.Columns[4].Name = "Địa Chỉ";
            dgrid_CuaHangs.Columns[5].Name = "Thành Phố";
            dgrid_CuaHangs.Columns[6].Name = "Quốc Gia";
            dgrid_CuaHangs.Columns[7].Name = "Trạng Thái";
            dgrid_CuaHangs.Rows.Clear();//Xóa data mỗi lần call vào phương thức này

            foreach (var x in _chService.GetAllCuaHangs(input))
            {
                dgrid_CuaHangs.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia, (x.Status == 1 ? "Hoạt động" : x.Status == 0 ? " Không hoạt động" : "Sửa chữa"));
            }
        }

        private CuaHang GetDataFromGui()
        {
            return new CuaHang()
            {
                Id = Guid.Empty,
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                ThanhPho = cmb_ThanhPho.Text,
                DiaChi = txt_Dc.Text,
                QuocGia = txt_QuocGia.Text,
                Status = (rbtn_HoatDong.Checked ? 1 : rbtn_KoHoatDong.Checked ? 0 : 2)
            };
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ten.Text)) return;
            txt_Ma.Text = Utility.ZenMaTuDong(txt_Ten.Text) + _chService.GetAllCuaHangs(null).Count;
        }

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ten.Text)) return;
            txt_Ten.Text = Utility.VietHoaFullName(txt_Ten.Text);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chService.Add(GetDataFromGui()));
            LoadDGridCH(null);
        }

        private void dgrid_CuaHangs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1.Lấy được row index khi người dùng bấm
            int rowIndex = e.RowIndex;
            if (rowIndex == _chService.GetAllCuaHangs(null).Count) return;
            //2. Lấy được khóa chính trên grid
            _idWhenClick = Guid.Parse(dgrid_CuaHangs.Rows[rowIndex].Cells[1].Value.ToString());

            //3. TÌm đối tượng theo id
            var obj = _chService.GetAllCuaHangs().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Ma.Text = obj.Ma;
            txt_Ten.Text = obj.Ten;
            txt_Dc.Text = obj.DiaChi;
            cmb_ThanhPho.SelectedItem = obj.ThanhPho;
            txt_QuocGia.Text = obj.QuocGia;
            if (obj.Status == 1)
            {
                rbtn_HoatDong.Checked = true;
            }
            else if (obj.Status == 0)
            {
                rbtn_KoHoatDong.Checked = true;
                return;
            }

            rbtn_SuaChua.Checked = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Update(temp));
            LoadDGridCH(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Delete(temp));
            LoadDGridCH(null);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimKiem.Text)) return;
            LoadDGridCH(txt_TimKiem.Text);
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "Tìm kiếm .......";
            LoadDGridCH(null);
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Clear();
        }
    }
}