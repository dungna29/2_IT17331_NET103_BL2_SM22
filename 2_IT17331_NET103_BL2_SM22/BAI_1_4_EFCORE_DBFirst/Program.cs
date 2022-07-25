using System;
using System.Linq;
using BAI_1_4_EFCORE_DBFirst.Context;
using BAI_1_4_EFCORE_DBFirst.DomainModels;

namespace BAI_1_4_EFCORE_DBFirst
{
    internal class Program
    {
        //Data Source=DUNGNAPC\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;User ID=dungna35;Password=123456

        //Scaffold-DbContext 'Data Source=DUNGNAPC\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;User ID=dungna35;Password=123456' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainModels -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
        private static void Main(string[] args)
        {
            FpolyDBContext dbContext = new FpolyDBContext();
            MauSac ms1 = new MauSac() { Id = Guid.Empty, Ma = "RD1", Ten = "Red" };
            dbContext.Add(ms1);
            dbContext.SaveChanges();

            foreach (var x in dbContext.MauSacs.ToList().OrderBy(c => c.Ma))
            {
                Console.WriteLine($"{x.Id} {x.Ma} {x.Ten}");
            }
        }
    }
}