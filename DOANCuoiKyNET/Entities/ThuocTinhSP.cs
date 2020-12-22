using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("ThuocTinhSP")]
    public class ThuocTinhSP
    {
        [Key]
        public int idTTSP { get; set; }
        [Required]
        public string tenTTSP { get; set; }

        public int idSP { get; set; }
        [ForeignKey("idSP")]
        public SanPham SanPham { get; set; }

        public string trangThai { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }

        public ICollection<ChiTietTTSP> ChiTietTTSPs { get; set; }

        public ThuocTinhSP()
        {
            ChiTietTTSPs = new HashSet<ChiTietTTSP>();
        }
    }
}
