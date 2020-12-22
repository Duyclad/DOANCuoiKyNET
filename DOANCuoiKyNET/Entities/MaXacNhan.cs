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
        [Required]
        public int idkh { get; set; }
        public string code { get; set; }
        public DateTime ngaygui { get; set; }
        public DateTime ngayxacnhan { get; set; }
        public string trangthai { get; set; }
    }
}
