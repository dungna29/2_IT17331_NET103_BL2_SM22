using System;
using System.Collections.Generic;
using System.Text;
using BAI_1_5_EFCORE_CodeFirst.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace BAI_1_5_EFCORE_CodeFirst.Context
{
    public class FpolyDBContext : DbContext//Phải kế thừa lớp DbContext
    {
        //1. Ghi đè 1 phương thức OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Cấu hình đường kết nối
            optionsBuilder.UseSqlServer(@"Data Source=DUNGNAPC\SQLEXPRESS;Initial Catalog=IT17311_CodeFirst;Persist Security Info=True;User ID=dungna34;Password=123456");
        }

        //2. Khai báo các bảng
        public DbSet<SinhVien> SinhViens { get; set; }

        public DbSet<Point> Points { get; set; }
    }
}