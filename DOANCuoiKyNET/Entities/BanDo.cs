using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DOANCuoiKyNET.Entities
{
    [Table("BanDo")]
    public class BanDo
    {
        [Key]
        public int idBanDo { get; set; }
       
        public string tenBanDo { get; set; }
        [Required]
        public string url { get; set; }
       
        public string trangThai { get; set; }
        public string moTa { get; set; }
        public DateTime ngayTao { get; set; }
        public DateTime ngayCapNhat { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }
        
    }
}
