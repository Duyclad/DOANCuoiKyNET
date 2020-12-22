using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("ChiTietTTSP")]
    public class ChiTietTTSP
    {
        public int idCTTTSP { get; set; }

        public string tenCTTTSP { get; set; }

        public int idTTSP { get; set; }
        [ForeignKey("idTTSP")]
        public ThuocTinhSP ThuocTinhSP { get; set; }
        public string trangThai { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }
    }
}
