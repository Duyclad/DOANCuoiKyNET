using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("HinhAnh")]
    public class HinhAnh
    {
        [Key]
        public int idHinhAnh { get; set; }

        public string tenHinhAnh { get; set; }

        public double kichThuoc { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }

        public ICollection<AnhSP> AnhSPs { get; set; }

        public HinhAnh()
        {
            AnhSPs = new HashSet<AnhSP>();
        }
    }
}
