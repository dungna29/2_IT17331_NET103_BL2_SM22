using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BAI_1_5_EFCORE_CodeFirst.DomainClass
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(200)]
        public int? Msv { get; set; }
    }
}