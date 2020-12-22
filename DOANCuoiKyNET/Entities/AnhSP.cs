

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("AnhSP")]
    public class AnhSP
    {

        [Key]
        public int idAnhSP { get; set; }
        public int idHinhAnh { get; set; }
        [ForeignKey("idHinhAnh")]
        public HinhAnh HinhAnh { get; set; }
        
        public int idSP { get; set; }
        [ForeignKey("idSP")]
        public SanPham SanPham { get; set; }
    }
}
