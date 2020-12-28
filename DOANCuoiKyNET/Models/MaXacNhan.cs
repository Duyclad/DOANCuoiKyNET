using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Models
{
    public class MaXacNhan
    {
     
      

        public int idUser { get; set; }
     
      
        public int code { get; set; }
        public DateTime ngayGui { get; set; }
        public DateTime ngayXacNhan { get; set; }
        public int loai { get; set; } //0 xacnhan , 1 quenmkhau
        public string trangThai { get; set; }
    }
}
