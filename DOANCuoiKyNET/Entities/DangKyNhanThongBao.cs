using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("DangKyNhanThongBao")]
    public class DangKyNhanThongBao
    {
        [Key]
        public int idDKNTB { get; set; }
        [Required]
        [MaxLength(200)]
        [EmailAddress(ErrorMessage = "Nhập đúng định dạng email!")]
        public string eMail { get; set; }

        public DateTime ngayDK { get; set; }

        public string trangThai { get; set; }
    }
}
