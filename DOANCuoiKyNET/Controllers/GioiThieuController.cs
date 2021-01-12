﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Controllers
{
    public class GioiThieuController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.tieude = "GIỚI THIỆU VỀ GONZ";
            ViewBag.noidung = "Công ty thời trang GONZ được thành lập từ tháng 01 năm 2021";

            ViewBag.cau1 = "Người đại diện: Cổ Lê Anh Duy";
            ViewBag.cau2 = "GONZ là một trong những thương hiệu thời trang nam dành cho giới trẻ uy tín hàng đầu Việt Nam. Với sự quản lý chặt chẽ, chuyên nghiệp của đội ngủ quản lý; Nỗ lực sáng tạo không ngừng của bộ phận thiết kế, Sự tận tâm chuyên nghiệp của nhân viên bán hàng… là những yếu tố làm nên thương hiệu thời trang GONZ lớn mạnh như hiện nay.";

            ViewBag.cau3 = "GONZ luôn quan niệm thời trang là sự tìm tòi và sáng tạo nên những sản phẩm của Chúng tôi đều được thiết kế riêng với sự trẻ trung, hiện đại, cá tính để mang lại guu thời trang hợp mốt nhất, cập nhật các xu hướng hot nhất cho các bạn trẻ. Các dòng sản phẩm của GONZ không ngừng đa dạng về kiểu dáng, màu sắc và mẫu mã từ áo sơ mi, áo thun, bộ đồ đôi, áo khoác, quần jean, quần tây, quần kaki… đến các phụ kiện thời trang vô cùng sành điệu như balo, kính, giày dép…, tất cả tạo nên vẻ đẹp hoàn hảo, trẻ trung, hiện đại, phong cách thành thị cho phái mạnh.";

            ViewBag.cau4 = "Bên cạnh đó GONZ luôn đặt mình vào tâm thế và quyền lợi của khách hàng để đưa ra những dòng sản phẩm thời trang chất lượng tốt, mẫu mã cực đẹp đón các đầu xu hướng thời trang, mới lạ cá tính nhưng với giá cả cực kì hấp dẫn, cạnh tranh nhất.";

            ViewBag.cau5 = "Hiện nay, thương hiệu thời trang nam GONZ phát triển ngày càng lớn mạnh thành một hệ thống với nhiều chi nhánh cửa hàng bán lẻ tại Hà Nội. Ngoài ra, nhằm tạo sự tiện lợi mua sắm tối đa cho khách hàng, GONZ phát triển hệ thống bán hàng online qua website; và fanpag: là Fanpage chính thức của nhãn hàng, chúng tôi giao hàng đến tận tay người tiêu dung trên toàn quốc.Giờ đây ngay tại nhà bạn cũng có thể chọn cho mình những sản phẩm phù hợp với sở thích và phong cách";

            ViewBag.cau6 = "Đến với GONZ, chúng tôi luôn tận tâm tư vấn giúp quý khách tìm được những sản phẩm yêu thích, phù hợp với nhu cầu và góp phần tạo nên phong cách cho riêng mình!";
            return View();
        }
    }
}
