using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Entities
{
    [Table("ipuser")]
    public class ipuser
    {
        [Key]
        public int idipuser { get; set; }
        [Required]
        public int iduser { get; set; }
        public string diachiip { get; set; }
    }
}
