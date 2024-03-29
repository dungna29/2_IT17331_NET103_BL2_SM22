﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BAI_1_4_EFCORE_DBFirst.DomainModels
{
    [Table("GioHang")]
    [Index(nameof(Ma), Name = "UQ__GioHang__3214CC9E18998A02", IsUnique = true)]
    public partial class GioHang
    {
        public GioHang()
        {
            GioHangChiTiets = new HashSet<GioHangChiTiet>();
        }

        [Key]
        public Guid Id { get; set; }
        [Column("IdKH")]
        public Guid? IdKh { get; set; }
        [Column("IdNV")]
        public Guid? IdNv { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayThanhToan { get; set; }
        [StringLength(50)]
        public string TenNguoiNhan { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(30)]
        public string Sdt { get; set; }
        public int? TinhTrang { get; set; }

        [ForeignKey(nameof(IdKh))]
        [InverseProperty(nameof(KhachHang.GioHangs))]
        public virtual KhachHang IdKhNavigation { get; set; }
        [InverseProperty(nameof(GioHangChiTiet.IdGioHangNavigation))]
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
    }
}
