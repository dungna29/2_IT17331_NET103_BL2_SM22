using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAI_1_6_CRUD_EF.DomainClass;
using BAI_1_6_CRUD_EF.Services;

namespace BAI_1_6_CRUD_EF.Views
{
    public partial class FrmQLCuaHang : Form
    {  //Toàn bộ biến toàn cục sẽ code trên đầu và có dấu _ và private
        private QLCuaHangService _chService;

        private Guid _idWhenClick;

        public FrmQLCuaHang()
        {
            InitializeComponent();
            _chService = new QLCuaHangService();
            LoadThanhPho();
            LoadDGridCH(null);
        }

        private void LoadThanhPho()
        {
            foreach (var x in _chService.GetAllThanhPhos())
            {
                cmb_TP.Items.Add(x);
            }
            cmb_TP.SelectedIndex = 0;//Hiển thị giá trị mặc định
        }

        private void LoadDGridCH(string input)
        {
            int stt = 1;
            Type type = typeof(CuaHang);
            int slThuoTinh = type.GetProperties().Length;//Đếm số lượng thuộc tính mà đối tượng cửa hàng có.
            dgridCuaHang.ColumnCount = slThuoTinh + 1;//Cộng 1 là vì muốn thêm 1 cột số thứ tự
            dgridCuaHang.Columns[0].Name = "STT";
            dgridCuaHang.Columns[1].Name = "Id";
            dgridCuaHang.Columns[2].Name = "Mã";
            dgridCuaHang.Columns[3].Name = "Tên";
            dgridCuaHang.Columns[4].Name = "Địa Chỉ";
            dgridCuaHang.Columns[5].Name = "Thành Phố";
            dgridCuaHang.Columns[6].Name = "Quốc Gia";
            dgridCuaHang.Rows.Clear();//Xóa data mỗi lần call vào phương thức này

            foreach (var x in _chService.GetAllCuaHangs(input))
            {
                dgridCuaHang.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia);
            }
        }

        private CuaHang GetDataFromGui()
        {
            return new CuaHang()
            {
                Id = Guid.Empty,
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                ThanhPho = cmb_TP.Text,
                DiaChi = txt_DiaChi.Text,
                QuocGia = txt_QuocGia.Text
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chService.Add(GetDataFromGui()));
            LoadDGridCH(null);
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

        private void dgridCuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //1.Lấy được row index khi người dùng bấm
            int rowIndex = e.RowIndex;
            if (rowIndex == _chService.GetAllCuaHangs(null).Count) return;
            //2. Lấy được khóa chính trên grid
            _idWhenClick = Guid.Parse(dgridCuaHang.Rows[rowIndex].Cells[1].Value.ToString());

            //3. TÌm đối tượng theo id
            var obj = _chService.GetAllCuaHangs().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Ma.Text = obj.Ma;
            txt_Ten.Text = obj.Ten;
            txt_DiaChi.Text = obj.DiaChi;
            cmb_TP.SelectedItem = obj.ThanhPho;
            txt_QuocGia.Text = obj.QuocGia;
        }
    }
}