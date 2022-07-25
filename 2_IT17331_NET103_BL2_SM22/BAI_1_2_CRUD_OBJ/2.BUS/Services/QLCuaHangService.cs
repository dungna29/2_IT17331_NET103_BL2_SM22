using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_1_2_CRUD_OBJ._3.DAL.DomainClass;
using BAI_1_2_CRUD_OBJ._3.DAL.Repositories;

namespace BAI_1_2_CRUD_OBJ._2.BUS.Services
{
    //Tại đây sẽ gọi lên Repo
    //Tại đây sẽ giải quyết tất cả các chứng năng mà bài toán cần.
    internal class QLCuaHangService
    {
        private CuaHangRepositories _cuaHangRepositories;

        public QLCuaHangService()
        {
            _cuaHangRepositories = new CuaHangRepositories();
        }

        public string Add(CuaHang ch)
        {
            return _cuaHangRepositories.Add(ch);
        }
        public string Update(CuaHang ch)
        {
            return _cuaHangRepositories.Update(ch);
        }
        public string Delete(CuaHang ch)
        {
            return _cuaHangRepositories.Delete(ch);
        }

    }
}
