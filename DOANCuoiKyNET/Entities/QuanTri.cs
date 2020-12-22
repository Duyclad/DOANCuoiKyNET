using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("QuanTri")]
    public class QuanTri
    {
        [Key]
        public int idQT { get; set; }

        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }
       

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
    }
}
