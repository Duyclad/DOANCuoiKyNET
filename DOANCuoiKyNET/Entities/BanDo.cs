using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Entities
{
    [Table("BanDo")]
    public class BanDo
    {
        [Key]
        public int idBanDo { get; set; }
        [Required]
        public string tenbando { get; set; }
        [Required]
        public string url { get; set; }
        [Required]
        public string trangthai { get; set; }
        public string mota { get; set; }
        public DateTime ngaytao { get; set; }
        public DateTime ngaycapnhat { get; set; }
        public int iduser { get; set; }
    }
}
