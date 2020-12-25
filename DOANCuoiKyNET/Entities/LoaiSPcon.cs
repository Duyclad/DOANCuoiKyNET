using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Entities
{
    [Table("LoaiSPcon")]
    public class LoaiSPcon
    {
        [Key]
        public int idLoaiSPcon { get; set; }
        [Required]
        [MaxLength(50)]
        public string tenLoaiSP { get; set; }
      
        public string hinhAnh { get; set; }
        [Required]
        public string metaTitle { get; set; }



        public string trangThai { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }

        public int idLoaiSP { get; set; }
        [ForeignKey("idLoaiSP")]
        public LoaiSP LoaiSP { get; set; }

        public ICollection<SanPham> SanPhams { get; set; }
        public LoaiSPcon()
        {

            SanPhams = new HashSet<SanPham>();
        }
    }
}
