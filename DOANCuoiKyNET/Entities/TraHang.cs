using System;
using System.ComponentModel.DataAnnotations;

namespace DOANCuoiKyNET.Entities
{
    [Table("TraHang")]
    public class TraHang
    {
        [Key]
        public int idTraHang { get; set; }
        [Required]
        [MaxLength(100)]
        public int idHoaDon { get; set; }
        [Required]
        
        public int idSP { get; set; }
        [Required]
        
        public string lydotrahang { get; set; }
        [Required]
        public string trangthai { get; set; }
        
        public DateTime ngayyeucautrahang { get; set; }
        public DateTime ngayhoantien { get; set; }
    }
}
