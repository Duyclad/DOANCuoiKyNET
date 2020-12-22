

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table ("LuotMua")]
    public class LuotMua
    {
        [Key]
        public int idLuotMua { get; set; }

        public int idSP { get; set; }
        [ForeignKey("idSP")]
        public SanPham SanPham { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }
    }
}
