

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public int idNV { get; set; }

        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }
        public int loaiNV { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
    }
}
