

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("AnhSP")]
    public class AnhSP
    {
        [Key]
        public int idHinhAnh { get; set; }
        [ForeignKey("idHinhAnh")]
        public HinhAnh HinhAnh { get; set; }
        [Key]
        public int idSP { get; set; }
        public SanPham SanPham { get; set; }
    }
}
