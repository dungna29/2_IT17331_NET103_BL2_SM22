using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BAI_1_5_EFCORE_CodeFirst.DomainClass
{
    [Table("Point")]
    public class Point
    {
        [Key]
        public Guid Id { get; set; }

        public string MonHoc { get; set; }

        [ForeignKey("IdSv")]
        public SinhVien SinhVien { get; set; }
    }
}