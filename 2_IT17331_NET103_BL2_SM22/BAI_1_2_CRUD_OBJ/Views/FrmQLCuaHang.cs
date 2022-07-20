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

namespace BAI_1_2_CRUD_OBJ.Views
{
    public partial class FrmQLCuaHang : Form
    {
        //Toàn bộ biến toàn cục sẽ code trên đầu và có dấu _ và private
        private QLCuaHangService _chService;

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
            dgrid_CuaHangs.Columns[1].Name = "Mã";
            dgrid_CuaHangs.Columns[2].Name = "Tên";
            dgrid_CuaHangs.Columns[3].Name = "Địa Chỉ";
            dgrid_CuaHangs.Columns[4].Name = "Thành Phố";
            dgrid_CuaHangs.Columns[5].Name = "Quốc Gia";
            dgrid_CuaHangs.Columns[6].Name = "Trạng Thái";
            dgrid_CuaHangs.Rows.Clear();//Xóa data mỗi lần call vào phương thức này

            foreach (var x in _chService.GetAllCuaHangs(input))
            {
                dgrid_CuaHangs.Rows.Add(stt++, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia, (x.Status == 1 ? "Hoạt động" : x.Status == 0 ? " Không hoạt động" : "Sửa chữa"));
            }
        }
    }
}