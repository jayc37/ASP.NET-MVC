using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBook.Models
{
    public class RegisterModel
    {
        [Key]
        public long ID { get; set; }
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage ="Nhập tên đăng nhập")]
        public string UserName { get; set; }
        [DisplayName("Mật khẩu")]
        [StringLength(20,MinimumLength = 4, ErrorMessage ="Độ dài tối thiểu 4 kí tự")]
        public string PassWord { get; set; }
        [DisplayName("Nhập lại mật khẩu")]
        [Compare("PassWord",ErrorMessage = "mật khẩu không khớp")]
        public string ConfirmPassWord { get; set; }
        [DisplayName("Họ và Tên")]
        [Required(ErrorMessage = "Nhập tên đầy đủ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nhập Email")]
        public string Email { get; set; }
    }
}