using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_1_2_CRUD_OBJ._3.DAL.DomainClass;

namespace BAI_1_2_CRUD_OBJ._3.DAL.Repositories
{
    //Class này sẽ thực hiện hành động CRUD đối tượng
    internal class CuaHangRepositories
    {
        private List<CuaHang> _lstCuaHangs;

        public CuaHangRepositories()
        {
            _lstCuaHangs = new List<CuaHang>();
        }

        public string Add(CuaHang ch)
        {
            ch.Id = Guid.NewGuid();//Khi thêm mới phải khởi tạo mới khóa chính
            _lstCuaHangs.Add(ch);
            return "Thêm thành công";
        }
        public string Update(CuaHang ch)
        {
            int indexCanTim = _lstCuaHangs.FindIndex(c => c.Id == ch.Id);
            _lstCuaHangs[indexCanTim] = ch;
            return "Sửa thành công";
        }
        public string Delete(CuaHang ch)
        {
            int indexCanTim = _lstCuaHangs.FindIndex(c => c.Id == ch.Id);
            _lstCuaHangs.RemoveAt(indexCanTim);
            return "Sửa thành công";
        }  
        public List<CuaHang> GetAll()
        {
            return _lstCuaHangs;
        } 
        public CuaHang Find(Guid id)
        {
            return _lstCuaHangs.Where(c=>c.Id == id).FirstOrDefault();
        }
    }
}
