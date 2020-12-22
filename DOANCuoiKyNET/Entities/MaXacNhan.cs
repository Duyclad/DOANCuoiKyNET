using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Entities
{
    [Table("MaXacNhan")]
    public class MaXacNhan
    {
        [Key]
        public int idMaXacNhan { get; set; }
       
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }
        public int code { get; set; }
        public DateTime ngayGui { get; set; }
        public DateTime ngayXacNhan { get; set; }
        public int loai { get; set; }
        public string trangThai { get; set; }
    }
}
