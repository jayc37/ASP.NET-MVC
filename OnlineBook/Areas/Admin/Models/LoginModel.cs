using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBook.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập tên đăng nhập")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        public string PassWord { get; set; }
        public bool Remember { get; set; }

    }
}