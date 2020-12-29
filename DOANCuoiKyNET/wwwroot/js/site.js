// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

(function ($) {
    $(document).ready(function () {
        $("#submitlogin").click(function () {

            if ($("#emaillogin").val() == "" || $("#mkhaulogin").val() == "") {
                $("#kqua").html("Bạn chưa nhập đầy đủ thông tin!");
            }
            else {
                var x = navigator.appVersion;
             
              
             
                $.ajax({
                    url: "Login/Verify",
                    data: {
                        email: $("#emaillogin").val().trim(),
                        mkhau: $("#mkhaulogin").val().trim(),
                  
                        x: x,
                    },
                    type: "POST",
                    success: function (data) {
                        if (data == "users") {
                            window.location = "Home";
                        }
                        else if (data == "admins") {
                            window.location = "Admin/HomeAdmin"
                        }
                        else if (data == "staffs") {
                            window.location = "Admin/HomeAdmin"
                        }
                        else {
                            $("#kqua").html(data);

                        }

                    },
                });
            }


        });


        function checkDate(strDate) {
            var comp = strDate.split('/')
            var d = parseInt(comp[0], 10)
            var m = parseInt(comp[1], 10)
            var y = parseInt(comp[2], 10)
            var date = new Date(y, m - 1, d);
            if (date.getFullYear() == y && date.getMonth() + 1 == m && date.getDate() == d) {
                return true
            }
            return false
        }
        function checkEmail(email) {
     
            var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
            if (!filter.test(email)) {
                alert('Hay nhap dia chi email hop le.\nExample@gmail.com');
         
                return false;
            }
            else {
                return true;
                alert('OK roi day, Email nay hop le.');
            }
        }
        $("#dky").click(function () {
            if ($("#houser").val() == "" || $("#tenuser").val() == "" || $("#emailuser").val() == "" || $("#sdtuser").val() == "" || $("#pwuser").val() == "" || $("#repwuser").val() == "") {
                $("#kqua2").html("Chưa điền đầy đủ thông tin!")
            }
            else {
               
                  
                   
                        var str3 = $('#emailuser').val();
                if (!checkEmail(str3)) {
                    $("#kqua2").html("Email không hợp lệ!");
                }
                else {
                    if ($("#pwuser").val() != $("#repwuser").val()) {
                        $("#kqua2").html("Mật khẩu không trùng khớp!");
                    }
                    else {
                        var x = navigator.appVersion;
                   
                                    $.ajax({
                                        url: "/Login/Signup",
                                        data: {
                                            emailuser: $("#emailuser").val().trim(),
                                            pwuser: $("#pwuser").val().trim(),
                                            houser: $("#houser").val().trim(),
                                            tenuser: $("#tenuser").val().trim(),
                                            sdtuser: $("#sdtuser").val().trim(),
                                            gioiTinh: $("#gioiTinh").val().trim(),
                                            ngaysinh: $("#ngaysinh").val().trim(),
                                            thangsinh: $("#thangsinh").val().trim(),
                                            namsinh: $("#namsinh").val().trim(),
                                            x: x,
                                        },
                                        type: "POST",
                                        success: function (data) {
                                            if (data == "1") {
                                                $("#kqua2").html("Tài khoản đã tồn tại, vui lòng đăng nhập!");
                                            }
                                            else {
                                                window.location = "/Sendmail/";

                                            }

                                        },
                                    });
            
                    }

                }
                          
                                    
           
                                
                        }

                    
                




            
        });

    });

})(jQuery); // End of use strict
