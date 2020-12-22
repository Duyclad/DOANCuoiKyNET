using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("TraHang")]
    public class TraHang
    {
        [Key]
        public int idTraHang { get; set; }
        
        public int idDH { get; set; }
        [ForeignKey("idDH")]
        public DonHang DonHang { get; set; }
        
        public int idSP { get; set; }
        [ForeignKey("idSP")]
        public SanPham SanPham { get; set; }
        [Required]
        public string lyDoTraHang { get; set; }
     
        public string trangThai { get; set; }
        
        public DateTime ngayYeuCauTraHang { get; set; }

        public DateTime ngayHoanTien { get; set; }
    }
}
